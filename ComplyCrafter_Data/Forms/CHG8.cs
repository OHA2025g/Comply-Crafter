using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_chg8", "vw_chg8")]
    public class CHG8 : BaseModel
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

        [Column("condonation_type")]
        public string? CondonationType { get; set; }

        [Column("type_of_charge")]
        public string? TypeOfCharge { get; set; }

        [Column("application_made_by")]
        public string? ApplicationMadeBy { get; set; }

        [Column("relevant_form")]
        public string? RelevantForm { get; set; }

        [Column("srn_of_form_selected")]
        public string? SrnOfFormSelected { get; set; }

        [Column("charge_identification_number")]
        public string? ChargeIdentificationNumber { get; set; }

        [Column("date_of_creation_modification_satisfaction")]
        public DateTime? DateOfCreationModificationSatisfaction { get; set; }

        [Column("amount_of_charge_created_modified_satisfied")]
        public string? AmountOfChargeCreatedModifiedSatisfied { get; set; }

        [Column("names_of_charge_holders")]
        public string? NamesOfChargeHolders { get; set; }

        [Column("property_or_asset_details")]
        public string? PropertyOrAssetDetails { get; set; }

        [Column("reasons_for_delay_omission_misstatement")]
        public string? ReasonsForDelayOmissionMisstatement { get; set; }

        // Declaration Information
        [Column("declaration_name")]
        public string? DeclarationName { get; set; }

        [Column("resolution_no")]
        public string? ResolutionNo { get; set; }

        [Column("declaration_date")]
        public DateTime? DeclarationDate { get; set; }

        [Column("member_designation")]
        public string? MemberDesignation { get; set; }

        [Column("member_id")]
        public string? MemberId { get; set; }
    }

    [TableName("tbl_chg8", "vw_chg8")]
    public class CHG8View : CHG8
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}