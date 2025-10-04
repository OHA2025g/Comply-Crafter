using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_chg1", "vw_chg1")]
    public class CHG1 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("company_email")]
        public string? CompanyEmail { get; set; }

        [Column("company_address")]
        public string? CompanyAddress { get; set; }

        [Column("registration")]
        public string? Registration { get; set; }

        [Column("modification_charge_id")]
        public string? ModificationChargeId { get; set; }

        [Column("applicant")]
        public string? Applicant { get; set; }

        [Column("instrument_date")]
        public DateTime? InstrumentDate { get; set; }

        [Column("charge")]
        public string? Charge { get; set; }

        [Column("natureanddescription")]
        public string? NatureAndDescription { get; set; }

        [Column("chk_interest")]
        public Boolean? ChkInterest { get; set; }

        [Column("chk_movable_property")]
        public Boolean? ChkMovableProperty { get; set; }

        [Column("chk_intangible_licence")]
        public Boolean? ChkIntangibleLicence { get; set; }

        [Column("chk_commercial")]
        public Boolean? ChkCommercial { get; set; }

        [Column("chk_copy_right_patent")]
        public Boolean? ChkCopyRightPatent { get; set; }

        [Column("chk_licence")]
        public Boolean? ChkLicence { get; set; }

        [Column("chk_interest_there_in")]
        public Boolean? ChkInterestThereIn { get; set; }

        [Column("chk_property_situated")]
        public Boolean? ChkPropertySituated { get; set; }

        [Column("chk_calls")]
        public Boolean? ChkCalls { get; set; }

        [Column("chk_inventory")]
        public Boolean? ChkInventory { get; set; }

        [Column("chk_trade_marks")]
        public Boolean? ChkTradeMarks { get; set; }

        [Column("chk_intangible_patent")]
        public Boolean? ChkIntangiblePatent { get; set; }

        [Column("chk_ship")]
        public Boolean? ChkShip { get; set; }

        [Column("chk_licence_under_patent")]
        public Boolean? ChkLicenceUnderPatent { get; set; }

        [Column("chk_intangible_copy_right")]
        public Boolean? ChkIntangibleCopyRight { get; set; }

        [Column("chk_equipment_machinery")]
        public Boolean? ChkEquipmentMachinery { get; set; }

        [Column("chk_intangible_designs")]
        public Boolean? ChkIntangibleDesigns { get; set; }

        [Column("chk_intangible_ipr")]
        public Boolean? ChkIntangibleIPR { get; set; }

        [Column("chk_motor_vehicle")]
        public Boolean? ChkMotorVehicle { get; set; }

        [Column("chk_intangible_others")]
        public Boolean? ChkIntangibleOthers { get; set; }

        [Column("chk_uncalled_capital")]
        public Boolean? ChkUncalledCapital { get; set; }

        [Column("chk_movable_property_others")]
        public Boolean? ChkMovablePropertyOthers { get; set; }

        [Column("chk_book_debts")]
        public Boolean? ChkBookDebts { get; set; }

        [Column("chk_others")]
        public Boolean? ChkOthers { get; set; }

        [Column("chk_consortium_finance")]
        public string? ChkConsortiumFinance { get; set; }

        [Column("banker_name")]
        public string? BankerName { get; set; }

        [Column("chk_joint_charge_involved")]
        public string? ChkJointChargeInvolved { get; set; }

        [Column("number_of_charge_holder")]
        public string? NumberOfChargeHolder { get; set; }

        [Column("chk_pari_passu")]
        public string? ChkPariPassu { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("charge_holder")]
        public string? ChargeHolder { get; set; }

        [Column("applicable_cin")]
        public string? ApplicableCin { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("address_line1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("zip")]
        public string? Zip { get; set; }

        [Column("area")]
        public string? Area { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("email_id")]
        public string? EmailId { get; set; }

        [Column("branch_code")]
        public string? BranchCode { get; set; }

        [Column("valid_pan")]
        public string? ValidPAN { get; set; }

        [Column("tax_pan")]
        public string? TaxPan { get; set; }

        [Column("secured_charge")]
        public string? SecuredCharge { get; set; }

        [Column("secured_amount")]
        public decimal? SecuredAmount { get; set; }

        [Column("security_interest_date")]
        public DateTime? SecurityInterestDate { get; set; }

        [Column("account_number")]
        public string? AccountNumber { get; set; }

        [Column("interest_rate")]
        public string? InterestRate { get; set; }

        [Column("repayment_term")]
        public int? RepaymentTerm { get; set; }

        [Column("terms_of_repayment")]
        public string? TermsOfRepayment { get; set; }

        [Column("nature_facility")]
        public string? NatureFacility { get; set; }

        [Column("date_of_disbursement")]
        public DateTime? DateOfDisbursement { get; set; }

        [Column("narrative_information")]
        public string? NarrativeInformation { get; set; }

        [Column("margin")]
        public string? Margin { get; set; }

        [Column("operation_charge")]
        public string? OperationCharge { get; set; }

        [Column("other")]
        public string? Other { get; set; }

        [Column("evidence_charge")]
        public string? EvidenceCharge { get; set; }

        [Column("instrument_description_charge")]
        public string? InstrumentDescriptionCharge { get; set; }

        [Column("date_of_acquisition")]
        public DateTime? DateOfAcquisition { get; set; }

        [Column("charge_id")]
        public string? ChargeId { get; set; }

        [Column("charge_amount")]
        public decimal? ChargeAmount { get; set; }

        [Column("property_charge")]
        public string? PropertyCharge { get; set; }

        [Column("property_or_assets")]
        public string? PropertyOrAssets { get; set; }

        [Column("number_of_title")]
        public string? NumberOfTitle { get; set; }

        [Column("document_title")]
        public string? DocumentTitle { get; set; }

        [Column("registered_property")]
        public string? RegisteredProperty { get; set; }

        [Column("individual_pan")]
        public string? IndividualPan { get; set; }

        [Column("registered_name")]
        public string? RegisteredName { get; set; }

        [Column("chk_authorised")]
        public Boolean? ChkAuthorised { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("declaration_date")]
        public DateTime? DeclarationDate { get; set; }

        [Column("terms")]
        public Boolean? Terms { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("manager_pan")]
        public string? ManagerPan { get; set; }

        [Column("checkbox3")]
        public Boolean? Checkbox3 { get; set; }

        [Column("checkbox4")]
        public Boolean? Checkbox4 { get; set; }

        [Column("pan_charge_holder")]
        public string? PanChargeHolder { get; set; }

        [Column("pan_assignee")]
        public string? PanAssignee { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("modification_charge")]
        public string? ModificationCharge { get; set; }

        [Column("professional_flag")]
        public string? ProfessionalFlag { get; set; }

        [Column("nameofpcs")]
        public string? NameOfPcs { get; set; }

        [Column("member_ship_number")]
        public string? MemberShipNumber { get; set; }
    }

    [TableName("tbl_chg1", "vw_chg1")]
    public class CHG1View : CHG1
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}