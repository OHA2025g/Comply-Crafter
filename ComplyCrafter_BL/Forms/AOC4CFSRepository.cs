using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IAOC4CFS : BaseInterface<AOC4CFS, AOC4CFSView>
    {
        bool ChangeActiveStatus(AOC4CFS obj);
        IEnumerable<AOC4CFSView> GetByCompany(int id);
    }

    public class AOC4CFSRepository : BaseRepository<AOC4CFS, AOC4CFSView>, IAOC4CFS
    {
        const string SUBSIDIARY_TABLE_NAME = "tbl_subsidiary";
        const string CAG_TABLE_NAME = "tbl_cag";
        const string RESERVATION_TABLE_NAME = "tbl_reservation";
        public new AOC4CFSView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<AOC4CFSView>().FirstOrDefault();
            if (dt != null)
            {
                dt.SubsidiaryList = GetSubsidiaryList(id, "subsidiary");
                dt.AssociateList = GetSubsidiaryList(id, "associate"); ;
                dt.ReservationList = GetReservationList(id);
                dt.CagList = GetCagList(id);
               
            }
            return dt;
        }

        public new AOC4CFS Save(AOC4CFS obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);

                //Subsidiary
                var subsidiaryLst = GetSubsidiaryList(obj.Id, "subsidiary");
                var subsidiaryTodelete = subsidiaryLst.Where(x => (obj.SubsidiaryList == null || !obj.SubsidiaryList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                subsidiaryTodelete?.ToList().ForEach(child =>
                {
                    DeleteSubsidiary(child);
                });
                obj.SubsidiaryList?.ToList().ForEach(child =>
                {
                    child.Type = "subsidiary";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id");
                    }
                });

                //Associate
                var associateLst = GetSubsidiaryList(obj.Id, "associate");
                var associateTodelete = associateLst.Where(x => (obj.AssociateList == null || !obj.AssociateList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                associateTodelete?.ToList().ForEach(child =>
                {
                    DeleteSubsidiary(child);
                });
                obj.SubsidiaryList?.ToList().ForEach(child =>
                {
                    child.Type = "associate";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id");
                    }
                });


                //Cag
                var existingCag = GetCagList(obj.Id);
                var specialInviteeTodelete = existingCag.Where(d => (obj.CagList == null || !obj.CagList.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
                specialInviteeTodelete?.ToList().ForEach(child =>
                {
                    DeleteCag(child);
                });
                obj.CagList?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CAG_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CAG_TABLE_NAME, "id");
                    }
                });

                //Reservation
                var existingReservation = GetReservationList(obj.Id);
                var reservationTodelete = existingReservation.Where(d => (obj.ReservationList == null || !obj.ReservationList.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
                reservationTodelete?.ToList().ForEach(child =>
                {
                    DeleteReservation(child);
                });
                obj.CagList?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CAG_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CAG_TABLE_NAME, "id");
                    }
                });
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;


                obj.SubsidiaryList?.ToList().ForEach(child =>
                {
                    child.Type = "subsidiary";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id");
                });
                obj.AssociateList?.ToList().ForEach(child =>
                {
                    child.Type = "associate";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SUBSIDIARY_TABLE_NAME, "id");
                });
                obj.CagList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CAG_TABLE_NAME, "id");
                });

                obj.ReservationList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, RESERVATION_TABLE_NAME, "id");
                });


            }
            return obj;
        }

        public bool DeleteSubsidiary(SUBSIDIARY obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {SUBSIDIARY_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool DeleteCag(CAG obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {CAG_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool DeleteReservation(RESERVATION obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {RESERVATION_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool ChangeActiveStatus(AOC4CFS obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<AOC4CFSView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<AOC4CFSView>();
            return dt;
        }

        public IEnumerable<RESERVATION> GetReservationList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {RESERVATION_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<RESERVATION>();
            return dt;
        }
        public IEnumerable<CAG> GetCagList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {CAG_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CAG>();
            return dt;
        }

        public IEnumerable<SUBSIDIARY> GetSubsidiaryList(int id = 0, string type = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {SUBSIDIARY_TABLE_NAME} where type = @type and parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<SUBSIDIARY>();
            return dt;
        }
    }
}
