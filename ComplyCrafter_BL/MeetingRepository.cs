using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IMeeting : BaseInterface<Meeting, MeetingView>
    {
        bool ChangeActiveStatus(Meeting obj);
        IEnumerable<MeetingView> GetByCompanyAndType(int id, string type, string finYear);
        Task UploadImage(IFormFileCollection files, int id);
        IEnumerable<MeetingResolution> GetResolutions(int meeting);
        MeetingResolution? AddResolution(MeetingResolution resolution);
        bool DeleteResolution(int meeting, int resolution);
    }

    public class MeetingRepository : BaseRepository<Meeting, MeetingView>, IMeeting
    {
        const string SPECIAL_INVITEE_TABLE_NAME = "tbl_meeting_special_invitee";
        const string CIRCULATION_TABLE_NAME = "tbl_meeting_circulation";
        const string COMMUNICATE_COMMENT_TABLE_NAME = "tbl_meeting_communicate_comment";
        const string RESOLUTION_TABLE_NAME = "tbl_meeting_resolution";

        public new MeetingView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<MeetingView>().FirstOrDefault();
            if (dt != null)
            {
                dt.SpecialInviteeList = GetSpecialInviteeList(id);
                dt.CNoticeList = GetCirculationList(id, "cNotice");
                dt.CDraftList = GetCirculationList(id, "cDraft");
                dt.CSignedList = GetCirculationList(id, "cSigned");
                dt.CommunicateCommentList = GetCommunicateCommentList(id);
            }
            return dt;
        }
        public new Meeting Save(Meeting obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);

                // SPECIAL_INVITEE
                var existingSpecialInvitee = GetSpecialInviteeList(obj.Id);
                var specialInviteeTodelete = existingSpecialInvitee.Where(d => (obj.SpecialInviteeList == null || !obj.SpecialInviteeList.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
                specialInviteeTodelete?.ToList().ForEach(child =>
                {
                    DeleteSpecialInvitee(child);
                });
                obj.SpecialInviteeList?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SPECIAL_INVITEE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SPECIAL_INVITEE_TABLE_NAME, "id");
                    }
                });

                // COMMUNICATE_COMMENT
                var existingCommunicateComment = GetCommunicateCommentList(obj.Id);
                var communicateCommentTodelete = existingCommunicateComment.Where(d => (obj.CommunicateCommentList == null || !obj.CommunicateCommentList.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
                communicateCommentTodelete?.ToList().ForEach(child =>
                {
                    DeleteCommunicateComment(child);
                });
                obj.CommunicateCommentList?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, COMMUNICATE_COMMENT_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, COMMUNICATE_COMMENT_TABLE_NAME, "id");
                    }
                });

                // NOTICE CIRCULATION
                var noticeCirculation = GetCirculationList(obj.Id, "cNotice");
                var noticeCirculationTodelete = noticeCirculation.Where(x => (obj.CNoticeList == null || !obj.CNoticeList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                noticeCirculationTodelete?.ToList().ForEach(child =>
                {
                    DeleteCirculation(child);
                });
                obj.CNoticeList?.ToList().ForEach(child =>
                {
                    child.Type = "cNotice";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CIRCULATION_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                    }
                });

                // DRAFT CIRCULATION
                var draftCirculation = GetCirculationList(obj.Id, "cDraft");
                var draftCirculationTodelete = draftCirculation.Where(x => (obj.CDraftList == null || !obj.CDraftList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                draftCirculationTodelete?.ToList().ForEach(child =>
                {
                    DeleteCirculation(child);
                });
                obj.CDraftList?.ToList().ForEach(child =>
                {
                    child.Type = "cDraft";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CIRCULATION_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                    }
                });

                // Signed CIRCULATION
                var signedCirculation = GetCirculationList(obj.Id, "cSigned");
                var signedCirculationTodelete = signedCirculation.Where(x => (obj.CSignedList == null || !obj.CSignedList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                signedCirculationTodelete?.ToList().ForEach(child =>
                {
                    DeleteCirculation(child);
                });
                obj.CSignedList?.ToList().ForEach(child =>
                {
                    child.Type = "cSigned";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CIRCULATION_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                    }
                });


            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.SpecialInviteeList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SPECIAL_INVITEE_TABLE_NAME, "id");
                });

                obj.CNoticeList?.ToList().ForEach(child =>
                {
                    child.Type = "cNotice";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                });
                obj.CDraftList?.ToList().ForEach(child =>
                {
                    child.Type = "cDraft";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                });
                obj.CSignedList?.ToList().ForEach(child =>
                {
                    child.Type = "cSigned";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CIRCULATION_TABLE_NAME, "id");
                });

                obj.CommunicateCommentList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, COMMUNICATE_COMMENT_TABLE_NAME, "id");
                });
            }
            if (obj.ResolutionList != null && obj.ResolutionList.Count() > 0)
            {
                var res = GetResolutions(obj.Id);
                obj.ResolutionList.Join(
                    res,
                    x => x.Resolution,
                    y => y.Resolution,
                    (a, b) => new
                    {
                        SavingTable = a,
                        DBTable = b
                    }).ToList().ForEach(z =>
                    {
                        z.SavingTable.Id = z.DBTable.Id;
                        z.SavingTable.Meeting = obj.Id;
                        z.SavingTable.UpdateIntoDB(R.ConnectionString, RESOLUTION_TABLE_NAME, "id", z.SavingTable.Id);
                    });
            }
            return obj;
        }

        public IEnumerable<MeetingSpecialInvitee> GetSpecialInviteeList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {SPECIAL_INVITEE_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<MeetingSpecialInvitee>();
            return dt;
        }
        public bool DeleteSpecialInvitee(MeetingSpecialInvitee obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {SPECIAL_INVITEE_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<MeetingCommunicateComment> GetCommunicateCommentList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {COMMUNICATE_COMMENT_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<MeetingCommunicateComment>();
            return dt;
        }
        public bool DeleteCommunicateComment(MeetingCommunicateComment obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {COMMUNICATE_COMMENT_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public IEnumerable<MeetingCirculation> GetCirculationList(int id = 0, string type = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {CIRCULATION_TABLE_NAME} where type = @type and parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<MeetingCirculation>();
            return dt;
        }
        public bool DeleteCirculation(MeetingCirculation obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {CIRCULATION_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool ChangeActiveStatus(Meeting obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<MeetingView> GetByCompanyAndType(int id, string type, string finYear)
        {
            IEnumerable<MeetingView> dt;

            if (finYear == "none")
            {
                dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id and type = @type",
                                  new Dictionary<string, object>
                                  {
                                      { "@id", id },
                                      { "@type", type },
                                  })
                                  .ParseList<MeetingView>();
            }
            else
            {
                string finYearStart = string.Empty;
                string finYearEnd = string.Empty;
                string[] finYearSplit = finYear.Split('-');
                finYearStart = $"{finYearSplit[0]}-04-01";
                int yearPreFix = int.Parse(finYearSplit[0].Substring(0, 2));
                if (int.Parse(finYearSplit[1]) < int.Parse(finYearSplit[0].Substring(2)))
                {
                    yearPreFix++;
                }
                finYearEnd = $"{yearPreFix}{finYearSplit[1]}-04-01";

                dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id and type = @type and date_meeting between @finYearStart and @finYearEnd",
                                  new Dictionary<string, object>
                                  {
                                      { "@id", id },
                                      { "@type", type },
                                      { "@finYearStart", DateTime.ParseExact(finYearStart, "yyyy-MM-dd", CultureInfo.InvariantCulture) },
                                      { "@finYearEnd", DateTime.ParseExact(finYearEnd, "yyyy-MM-dd", CultureInfo.InvariantCulture) },
                                  })
                                  .ParseList<MeetingView>();
            }
            return dt;
        }
        public async Task UploadImage(IFormFileCollection files, int id)
        {
            try
            {
                foreach (var file in files)
                {
                    string filePath = @$"/Meeting/{id}_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{file.FileName}";
                    var bunnyCDNStorage = new BunnyCDNStorage(R.AppSet("Bunny:StorageZone"), R.AppSet("Bunny:Key"));
                    byte[] fileBytes;
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        fileBytes = memoryStream.ToArray();
                    }
                    using (MemoryStream ms = new MemoryStream(fileBytes))
                        await bunnyCDNStorage.UploadAsync(ms, R.AppSet("Bunny:BasePath") + filePath);
                    var sql = $@"update {TABLE_NAME} set {ConvertToSnakeCase(file.Name)} = @url where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@url", R.AppSet("Bunny:BaseUrl") + filePath },
                        { "@id", id },
                    }, ThrowError: true);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static string ConvertToSnakeCase(string input)
        => string.Concat(input.Select((c, i) => char.IsUpper(c) && i > 0 ? $"_{char.ToLower(c)}" : char.ToLower(c).ToString()));

        public IEnumerable<MeetingResolution> GetResolutions(int meeting)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {RESOLUTION_TABLE_NAME} where meeting = @meeting order by sequence_no",
                new Dictionary<string, object> { { "@meeting", meeting } }).ParseList<MeetingResolution>();
            return dt;
        }

        public MeetingResolution? AddResolution(MeetingResolution resolution)
        {
            var res = GetResolutions(resolution.Meeting ?? 0);
            resolution.Sequence = (res.Max(r => r.Sequence) ?? 0) + 1;
            resolution.Id = resolution.InsertIntoDBOutIdentity(R.ConnectionString, RESOLUTION_TABLE_NAME, "id");
            return resolution;
        }

        public bool DeleteResolution(int meeting, int resolution)
        {
            new MeetingAgendaDetailRepository().DeleteMeetingAgendaDetail(meeting, resolution);
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from  {RESOLUTION_TABLE_NAME} where meeting = @meeting and resolution = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public int MeetingCount(int id, int type)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id and type = @type",
                new Dictionary<string, object>
                {
                    { "@id", id },
                    { "@type", type },
                })
                .ParseList<MeetingView>();
            return 0;
        }
    }
}
