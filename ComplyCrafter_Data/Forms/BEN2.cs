using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_ben2", "vw_ben2")]
    public class BEN2 : BaseModel
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
        [Column("reporting_company")]
        public Boolean? ReportingCompany { get; set; }

        [Column("declaration_ownership")]
        public Boolean? DeclarationOwnership { get; set; }

        [Column("change_ownership")]
        public Boolean? ChangeOwnership { get; set; }

        [Column("change_exiting")]
        public Boolean? ChangeExiting { get; set; }

        [Column("change_reporting_company")]
        public Boolean? ChangeReportingCompany { get; set; }

        [Column("cin_holding_company")]
        public int? CinHoldingCompany { get; set; }

        [Column("name_holding_company")]
        public string? NameHoldingCompany { get; set; }

        [Column("number_of_significant_owners")]
        public int? NumberOfSignificantOwners { get; set; }

        [Column("copy_attachment")]
        public string? CopyAttachment { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }

        [Column("resolution_number")]
        public int? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("signitory")]
        public string? Signitory { get; set; }

        [Column("din_pan")]
        public string? DinPan { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("associate_or_fellow")]
        public string? AssociateOrFellow { get; set; }

        [Column("membership_number")]
        public int? MembershipNumber { get; set; }

    }

    [TableName("tbl_ben2", "vw_ben2")]
    public class BEN2View : BEN2
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}