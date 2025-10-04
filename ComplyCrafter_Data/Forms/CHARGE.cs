using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_charge", "vw_charge")]
    public class CHARGE : BaseModel
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

        // Part-1
        [Column("purpose")]
        public string? Purpose { get; set; }

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

        [Column("form_purpose")]
        public string? FormPurpose { get; set; }

        [Column("charge_identification_no")]
        public string? ChargeIdentificationNo { get; set; }

        [Column("whether_charge_is_modified")]
        public string? WhetherChargeIsModified { get; set; }

        [Column("whether_charge_holder_is_authorized")]
        public string? WhetherChargeHolderIsAuthorized { get; set; }

        [Column("charge_type")]
        public bool ChargeType { get; set; }

        [Column("other_desc_of_charge")]
        public string? OtherDescOfCharge { get; set; }

        [Column("whether_consortium_finance_is_involved")]
        public string? WhetherConsortiumFinanceisInvolved { get; set; }

        [Column("banker_name")]
        public string? BankerName { get; set; }

        [Column("whether_joint_charge_involved")]
        public string? WhetherJointChargeInvolved { get; set; }

        [Column("no_of_charge_holders")]
        public int NoOfChargeHolders { get; set; }

        [Column("whether_charger_rank_pari_passu")]
        public string? WhetherChargerRankPariPassu { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("others")]
        public string? Others { get; set; }

        [Column("name_of_charge_holder")]
        public string? NameOfChargeHolder { get; set; }

        [Column("cin_arc_assignee")]
        public string? CinArcAssignee { get; set; }

        [Column("name_based_on_cin")]
        public string? NameBasedOnCin { get; set; }

        [Column("address1_based_on_cin")]
        public string? Address1BasedOnCin { get; set; }

        [Column("address2_based_on_cin")]
        public string? Address2BasedOnCin { get; set; }

        [Column("country_based_on_cin")]
        public string? CountryBasedOnCin { get; set; }

        [Column("pin_based_on_cin")]
        public string? PinBasedOnCin { get; set; }

        [Column("area_based_on_cin")]
        public string? AreaBasedOnCin { get; set; }

        [Column("city_based_on_cin")]
        public string? CityBasedOnCin { get; set; }

        [Column("district_based_on_cin")]
        public string? DistrictBasedOnCin { get; set; }

        [Column("state_based_on_cin")]
        public string? StateBasedOnCin { get; set; }

        [Column("email_id_based_on_cin")]
        public string? EmailIdBasedOnCIN { get; set; }

        [Column("jurisdiction_police_station2")]
        public string? JurisdictionPoliceStation2 { get; set; }

        [Column("brs_code")]
        public string? BrsCode { get; set; }

        [Column("whether_charge_holder_having_pan")]
        public string? WhetherChargeHolderHavingPan { get; set; }

        [Column("panno")]
        public string? Panno { get; set; }

        [Column("nature_of_instrument")]
        public string? NatureOfInstrument { get; set; }

        [Column("date_of_instrument_create")]
        public DateTime? DateOfInstrumentCreate { get; set; }

        [Column("description_of_instrument")]
        public string? DescriptionOfInstrument { get; set; }

        [Column("date_of_instrument_modify")]
        public DateTime? DateOfInstrumentModify { get; set; }

        [Column("date_of_satisfaction_full")]
        public DateTime? DateOfSatisfactionFull { get; set; }

        [Column("charge_modified_india")]
        public string? ChargeModifiedIndia { get; set; }

        [Column("date_of_receipt_documents_in_india")]
        public DateTime? DateOfRecieptDocumentsInIndia { get; set; }

        [Column("maximum_amount_secured_charge")]
        public string? MaximumAmountSecuredCharge { get; set; }

        [Column("maximum_amount_secured_charge_words")]
        public string? MaximumAmountSecuredChargeWords { get; set; }

        [Column("foreign_currency_details")]
        public string? ForeignCurrencydetails { get; set; }

        [Column("date_of_creating")]
        public DateTime? DateOfCreating { get; set; }

        [Column("borrower_account_number")]
        public string? BorrowerAccountNumber { get; set; }

        [Column("rate_of_interest")]
        public string? RateOfInterest { get; set; }

        [Column("repayment_term")]
        public string? RepaymentTerm { get; set; }

        [Column("terms_of_repayment")]
        public string? TermsOfRepayment { get; set; }

        [Column("nature_of_facility")]
        public string? NatureOfFacility { get; set; }

        [Column("date_of_disbursement")]
        public DateTime? DateOfDisbursement { get; set; }

        [Column("miscellaneous_narrative_information")]
        public string? MiscellaneousNarrativeInformation { get; set; }

        [Column("margin")]
        public string? Margin { get; set; }

        [Column("extent_operation_charge")]
        public string? ExtentOperationCharge { get; set; }

        [Column("others1")]
        public string? Others1 { get; set; }

        [Column("whether_plot_or_dwelling_interest")]
        public string? WhetherPlotOrDwellingInterest { get; set; }

        [Column("date_of_instrument")]
        public DateTime? DateOfInstrument { get; set; }

        [Column("date_of_acquisition")]
        public DateTime? DateOfAcquisition { get; set; }

        [Column("charge_id")]
        public string? ChargeId { get; set; }

        [Column("amount_charge")]
        public string? AmountCharge { get; set; }

        [Column("particulars_of_property")]
        public string? ParticularsOfProperty { get; set; }

        [Column("short_particulars")]
        public string? ShortParticulars { get; set; }

        [Column("plot_unit_evaluated_price")]
        public string? PlotUnitEvaluatedPrice { get; set; }

        [Column("plot_unit_nature_of_property")]
        public string? PlotUnitNatureOfProperty { get; set; }

        [Column("plot_unit_plot_id_number")]
        public string? PlotUnitPlotIdNumber { get; set; }

        [Column("plot_unit_survey_number_or_gat_number")]
        public string? PlotUnitSurveyNumberOrGatNumber { get; set; }

        [Column("dwelling_interest_dwelling_unit_id")]
        public string? DwellingInterestDwellingUnitId { get; set; }

        [Column("dwelling_interest_floor_number")]
        public string? DwellingInterestFloorNumber { get; set; }

        [Column("name_of_building_society")]
        public string? NameOfBuildingSociety { get; set; }

        [Column("street_number_and_name")]
        public string? StreetNumberAndName { get; set; }

        [Column("sector_block_number")]
        public string? SectorBlockNumber { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("landmark")]
        public string? Landmark { get; set; }

        [Column("village")]
        public string? Village { get; set; }

        [Column("taluka")]
        public string? Taluka { get; set; }

        [Column("area_locality")]
        public string? AreaLocality { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("latitude")]
        public int? Latitude { get; set; }

        [Column("longitude")]
        public int? Longitude { get; set; }

        [Column("plot_area")]
        public string? PlotArea { get; set; }

        [Column("dwelling_area")]
        public string? DwellingArea { get; set; }

        [Column("bounded_by_north")]
        public string? BoundedByNorth { get; set; }

        [Column("bounded_by_south")]
        public string? BoundedBySouth { get; set; }

        [Column("bounded_by_east")]
        public string? BoundedByEast { get; set; }

        [Column("bounded_by_west")]
        public string? BoundedByWest { get; set; }

        [Column("whether_property_or_interest_register")]
        public string? WhetherPropertyOrInterestRegister { get; set; }

        [Column("register_pan_no")]
        public string? RegisterPanNo { get; set; }

        [Column("llpid_of_company")]
        public string? LlpidOfCompany { get; set; }

        [Column("in_whose_name_it_is_registered")]
        public string? InWhoseNameItIsRegistered { get; set; }

        [Column("date_of_creation_modification")]
        public DateTime? DateOfCreationModification { get; set; }

        [Column("particulars_of_present_modification2")]
        public string? ParticularsOfPresentModification2 { get; set; }

        // Part-2
        [Column("partner_din")]
        public string? PartnerDin { get; set; }

        [Column("income_tax_pan")]
        public string? IncomeTaxPan { get; set; }

        [Column("designation_of_charge_holder")]
        public string? DesignationOfChargeHolder { get; set; }

        [Column("designation_of_arc_assignee")]
        public string? DesignationOfArcAssignee { get; set; }

        [Column("certified_by")]
        public string? CertifiedBy { get; set; }

        [Column("category1")]
        public string? Category1 { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("certificate_membership_practice")]
        public string? CertificateMembershipPractice { get; set; }

        // Part-3
        [Column("instrument_file")]
        public string? InstrumentFile { get; set; }

        [Column("evidence_file")]
        public string? EvidenceFile { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }
    }

    [TableName("tbl_charge", "vw_charge")]
    public class CHARGEView : CHARGE
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}