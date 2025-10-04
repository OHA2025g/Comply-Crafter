using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    public class SUBSIDIARY : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("company_cin")]
        public string? CompanyCin { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("company_provision")]
        public string? CompanyProvision { get; set; }
    }
    public class CAG : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("cag_comments")]
        public string? CagComments { get; set; }

        [Column("bod_reply")]
        public string? BodReply { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

    }
    public class RESERVATION : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("auditor_qualification")]
        public string? AuditorQualification { get; set; }

        [Column("director_comments")]
        public string? DirectorComments { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

    }
}