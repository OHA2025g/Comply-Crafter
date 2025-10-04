using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;

namespace ComplyCrafter_BL
{
    public interface IActionGeneral : BaseInterface<GeneralAction, GeneralAction>
    {
        bool ChangeActiveStatus(GeneralAction obj);
        IEnumerable<GeneralAction> GetByCompany(int id);
    }

    public class ActionGeneralRepository : BaseRepository<GeneralAction, GeneralAction>, IActionGeneral
    {
        public bool ChangeActiveStatus(GeneralAction obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<GeneralAction> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<GeneralAction>();
            return dt;
        }
    }
}
