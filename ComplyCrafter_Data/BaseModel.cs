using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplyCrafter_Data
{
    public class BaseModel : NpgSQLTable
    {

        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [BypassInSQLUpdate]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [BypassInSQLUpdate]
        [Column("created_on")]
        public DateTime? CreatedOn { get; set; }

        [Column("updated_by")]
        public int UpdatedBy { get; set; }

        [Column("updated_on")]
        public DateTime? UpdatedOn { get; set; }

        [BypassInSQLUpdate]
        [Column("is_active")]
        public Boolean IsActive { get; set; }

        public void PreInsert(AppUser user)
        {
            this.CreatedBy = user.Id;
            this.CreatedOn = DateTime.Now;
            this.UpdatedBy = user.Id;
            this.UpdatedOn = DateTime.Now;
            this.IsActive = true;
            //this.DeletedOn = null;
        }
    }

    [System.AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class TableNameAttribute : Attribute
    {
        public readonly string TABLE_NAME;
        public readonly string VIEW_NAME;

        public TableNameAttribute(string table_name, string? view_name = null)
        {
            this.TABLE_NAME = table_name;
            this.VIEW_NAME = view_name ?? table_name;
        }
    }
}
