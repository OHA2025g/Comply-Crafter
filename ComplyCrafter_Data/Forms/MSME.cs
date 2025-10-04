using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_msme", "vw_msme")]
    public class MSME : BaseModel
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

        [Column("company_pan")]
        public string CompanyPan { get; set; }

        [Column("return_type")]
        public string ReturnType { get; set; }

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("attachment_file")]
        public string AttachmentFile { get; set; }

        [Column("declaration_designation")]
        public string DeclarationDesignation { get; set; }

        [Column("declaration_membership_no")]
        public string DeclarationMembershipNo { get; set; }

        [Column("din_members")]
        public string? dinMemebers { get; set; }


    }

    [TableName("tbl_msme", "vw_msme")]
    public class MSMEView : MSME
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}