using AlphaUtil.Core;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface BaseInterface<T1,T2> 
        where T1 : BaseModel, new()
        where T2 : BaseModel, T1, new()
    {
        IEnumerable<T2> Get();
        T2? GetById(int id = 0);
        T1? Save(T1 obj);
        bool Delete(T1 obj);
    }

    public class BaseRepository<T1, T2> : BaseInterface<T1, T2>
        where T1 : BaseModel,new()
        where T2 : BaseModel, T1, new()
    {
        protected string TABLE_NAME = typeof(T2).GetCustomAttribute<TableNameAttribute>()?.TABLE_NAME ??
                                        typeof(T1).GetCustomAttribute<TableNameAttribute>()?.TABLE_NAME ?? "";
        protected string VIEW_NAME = typeof(T2).GetCustomAttribute<TableNameAttribute>()?.VIEW_NAME ??
                                        typeof(T1).GetCustomAttribute<TableNameAttribute>()?.VIEW_NAME ?? "";

        public virtual IEnumerable<T2> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME}").ParseList<T2>();
            return dt;
        }

        public virtual T2? GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<T2>().FirstOrDefault();
            return dt;
        }

        public virtual T1? Save(T1 obj) 
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

        public virtual bool Delete(T1 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {TABLE_NAME} where id = @id", new Dictionary<string, object> {
                { "@id", obj.Id }
            }) > 0;
        }
    }
}
