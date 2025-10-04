using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form22", "vw_form22")]
    public class FORM22 : BaseModel
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


        [Column("jurisdiction_of_police_station")]
        public string? JurisdictionOfPoliceStation { get; set; }

        [Column("order_passed")]
        public string? OrderPassed { get; set; }

        [Column("name_of_order_passed")]
        public string? NameOfOrderPassed { get; set; }

        [Column("location")]
        public string? Location { get; set; }

        [Column("specify_others")]
        public string? SpecifyOthers { get; set; }

        [Column("application_number")]
        public string? ApplicationNumber { get; set; }

        [Column("order_number")]
        public string? OrderNumber { get; set; }

        [Column("date_of_passing_order")]
        public string? DateOfPassingOrder { get; set; }

        [Column("relevant_act")]
        public string? RelevantAct { get; set; }

        [Column("section_of_llp_2008")]
        public string? SectionOfLlp2008 { get; set; }

        [Column("section_of_insolvency")]
        public string? SectionOfInsolvency { get; set; }

        [Column("no_of_days")]
        public string? NoOfDays { get; set; }

        [Column("other_section_details")]
        public string? OtherSectionDetails { get; set; }

        [Column("other_section_description")]
        public string? otherSectionDes { get; set; }

        [Column("application_date")]
        public DateTime? ApplicationDate { get; set; }

        [Column("issue_date")]
        public DateTime? IssueDate { get; set; }


        [Column("due_date")]
        public string? DueDate { get; set; }

        [Column("description_order")]
        public string? DescriptionOrder { get; set; }

        [Column("compounding_srn")]
        public string? CompoundingSrn { get; set; }

        [Column("offence_srn")]
        public string? OffenceSrn { get; set; }

        [Column("form_31_srn")]
        public string? Form31Srn { get; set; }

        [Column("srn_form_22")]
        public string? SrnForm22 { get; set; }

        [Column("whether_cost_involved")]
        public string? WhetherCostInvolved { get; set; }

        [Column("details_of_cost_paid")]
        public string? DetailsOfCostPaid { get; set; }

        [Column("registration_no_irp")]
        public string? RegistrationNoIrp { get; set; }

        [Column("pan_number_irp")]
        public string? PanNumberIrp { get; set; }

        [Column("name_irp")]
        public string? NameIrp { get; set; }

        [Column("mobile_no_irp")]
        public string? MobileNoIrp { get; set; }

        [Column("email_irp")]
        public string? EmailIrp { get; set; }

        [Column("address_line_1_irp")]
        public string? AddLine1Irp { get; set; }

        [Column("address_line_2_orp")]
        public string? AddLine2Orp { get; set; }

        [Column("country_irp")]
        public string? CountryIrp { get; set; }

        [Column("pin_code_irp")]
        public string? PinCodeIrp { get; set; }

        [Column("locality_irp")]
        public string? LocalityIrp { get; set; }

        [Column("city_irp")]
        public string? CityIrp { get; set; }

        [Column("state_irp")]
        public string? StateIrp { get; set; }

        [Column("district_irp")]
        public string? DistrictIrp { get; set; }

        // Part-2
        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("verification_checkbox_1")]
        public Boolean? VerificationCheckbox1 { get; set; }

        [Column("verification_checkbox_2")]
        public Boolean? VerificationCheckbox2 { get; set; }

        [Column("designation_auth")]
        public string? DesignationAuth { get; set; }

        [Column("name_auth_representative")]
        public string? NameAuthrePresentative { get; set; }

        [Column("name_designated_partner")]
        public string? NameDesignatedPartner { get; set; }

        [Column("dpin_partner")]
        public string? DpinPartner { get; set; }

        [Column("capacity")]
        public string? Capacity { get; set; }


    }

    [TableName("tbl_form22", "vw_form22")]
    public class FORM22View : FORM22
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}