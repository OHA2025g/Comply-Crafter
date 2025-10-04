using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplyCrafter_Data
{
    public class ApiLog : NpgSQLTable
    {

        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("url")]
        public string? URL { get; set; }

        [Column("method")]
        public string? Method { get; set; }

        [Column("input")]
        public string? Input { get; set; }

        [Column("output")]
        public string? Output { get; set; }

        [BypassInSQLUpdate]
        [Column("created_on")]
        public DateTime? CreatedOn { get; set; }

    }
}
