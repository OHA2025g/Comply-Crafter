using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mgt6", "vw_mgt6")]
    public class MGT6 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("company_address")]
        public string? CompanyAddress { get; set; }

        [Column("company_email")]
        public string? CompanyEmail { get; set; }

        [Column("filed_registered")]
        public int? FiledRegistered { get; set; }

        [Column("section89")]
        public string? Section89 { get; set; }

        [Column("person_declare")]
        public string? PersonDeclare { get; set; }

        [Column("attachment_add")]
        public string? AttachmentAdd { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("declaration_designation")]
        public string? DeclarationDesignation { get; set; }

        [Column("declaration_membership_no")]
        public string? DeclarationMembershipNo { get; set; }

        [Column("din_memebers")]
        public string? DinMemebers { get; set; }

    }

    [TableName("tbl_mgt6", "vw_mgt6")]
    public class MGT6View : MGT6
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}