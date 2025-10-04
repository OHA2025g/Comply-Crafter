using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_auditor_partner")]
    public class AuditorPartner : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("auditor")]
        public int Auditor { get; set; }

        [Column("member_no")]
        public string? MemberNo { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }
    }

}