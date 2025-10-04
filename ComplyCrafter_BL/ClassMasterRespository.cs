using AlphaUtil.Core;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface IClassMaster
    {
        IEnumerable<ClassMaster> Get(int userId, int companyId, string classType);
        ClassMaster? GetById(int userId, int companyId, int id, string classType);
        ClassMaster? Save(ClassMaster obj);
        bool MarkDelete(int id);
    }

    public class ClassMasterRespository : IClassMaster
    {
        private const string TABLE_NAME = "tbl_class_master";
        private const string VIEW_NAME = "vw_class_master";

        public IEnumerable<ClassMaster> Get(int userId, int companyId, string classType)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where user_id = @userId and company_id = @companyId and class_type = @classType;", new Dictionary<string, object>
               {
                    { "@userId", userId },
                    { "@companyId", companyId },
                    { "@classType", classType },
               }, ThrowError: true)
                .ParseList<ClassMaster>();
            return dt;
        }

        public ClassMaster? GetById(int userId, int companyId, int id, string classType)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id and user_id=@userId and company_id = @companyId and class_type = @classType;",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@userId", userId },
                    { "@companyId", companyId },
                    { "@classType", classType },
               }, ThrowError: true)
               .ParseList<ClassMaster>().FirstOrDefault();
            return dt;
        }

        public ClassMaster? Save(ClassMaster obj)
        {
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
            return obj;
        }
        public bool MarkDelete(int id)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_deleted = true, updated_on = NOW(), updated_by = 1 where id = @id", new Dictionary<string, object>
            {
                { "@id", id }
            }, ThrowError: true) > 0;
        }

    }
}
