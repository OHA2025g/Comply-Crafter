using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form11", "vw_form11")]
    public class FORM11 : BaseModel
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


        [Column("financial_year_from_date")]
        public DateTime? FinancialYearFromDate { get; set; }

        [Column("financial_year_to_date")]
        public DateTime? FinancialYearToDate { get; set; }

        [Column("offence_date_11")]
        public DateTime? OffenceDate11 { get; set; }

        [Column("offence_1")]
        public string? Offence1 { get; set; }

        [Column("offence_2")]
        public string? Offence2 { get; set; }

        [Column("offence_3")]
        public string? Offence3{ get; set; }

        [Column("jurisdiction_police_station_address")]
        public string? JurisdictionPoliceStationAddress { get; set; }

        [Column("other_address_under_13c")]
        public string? OtherAddressUnder13C { get; set; }

        [Column("jurisdiction_police_station_other_address")]
        public string? JurisdictionPoliceStationOtherAddress { get; set; }

        [Column("business_classification")]
        public string? BusinessClassification { get; set; }

        [Column("business_principal_activities")]
        public string? BusinessPrincipalActivities { get; set; }

        [Column("total_number_of_designated_partners")]
        public string? TotalNumberOfDesignatedPartners { get; set; }

        [Column("total_number_of_partners")]
        public string? TotalNumberOfPartners { get; set; }

        [Column("total_obligation_of_contribution")]
        public string? TotalObligationOfContribution { get; set; }

        [Column("total_contribution_received_from")]
        public string? TotalContributionReceivedFrom { get; set; }

        [Column("invi_partner_data")]
        public string? InviPartnerData { get; set; }

        [Column("bodycor_partner_data")]
        public string? BodycorPartnerData { get; set; }


        // Part-2


        [Column("number_of_partner_1")]
        public string? NumberOfPartner1 { get; set; }


        [Column("number_of_partner_2")]
        public string? NumberOfPartner2 { get; set; }

        [Column("number_of_partner_3")]
        public string? NumberOfPartner3 { get; set; }

        [Column("number_of_partner_4")]
        public string? NumberOfPartner4 { get; set; }

        [Column("number_of_partner_5")]
        public string? NumberOfPartner5 { get; set; }

        [Column("number_of_partner_6")]
        public string? NumberOfPartner6 { get; set; }

        [Column("number_of_partner_7")]
        public string? NumberOfPartner7 { get; set; }

        [Column("number_of_partner_8")]
        public string? NumberOfPartner8 { get; set; }



        [Column("number_of_partner")]
        public string? TotalPartner1Number { get; set; }


        [Column("resident_in_india")]
        public string? ResidentInIndia { get; set; }

        [Column("other_resident")]
        public string? OtherResident { get; set; }

        [Column("total_partner_1")]
        public string? TotalPartner1 { get; set; }

        [Column("total_partner_2")]
        public string? TotalPartner2 { get; set; }

        [Column("total_partner_3")]
        public string? TotalPartner3 { get; set; }

        [Column("total_partner_4")]
        public string? TotalPartner4 { get; set; }

        [Column("total_partner_5")]
        public string? TotalPartner5 { get; set; }

        [Column("total_partner_6")]
        public string? TotalPartner6 { get; set; }

        [Column("total_partner_7")]
        public string? TotalPartner7 { get; set; }

        [Column("total_partner_8")]
        public string? TotalPartner8 { get; set; }



        [Column("resident_in_india_2")]
        public string? ResidentInIndia2 { get; set; }

        [Column("other_resident_2")]
        public string? OtherResident2 { get; set; }
 

         [Column("resident_in_india_3")]
        public string? ResidentInIndia3 { get; set; }

        [Column("other_resident_3")]
        public string? OtherResident3 { get; set; }


      

        [Column("resident_in_india_4")]
        public string? ResidentInIndia4 { get; set; }

        [Column("other_resident_4")]
        public string? OtherResident4 { get; set; }


        [Column("resident_in_india_5")]
        public string? ResidentInIndia5 { get; set; }

        [Column("other_resident_5")]
        public string? OtherResident5 { get; set; }



        [Column("resident_in_india_6")]
        public string? ResidentInIndia6 { get; set; }

        [Column("other_resident_6")]
        public string? OtherResident6 { get; set; }

  
        [Column("resident_in_india_7")]
        public string? ResidentInIndia7 { get; set; }

        [Column("other_resident_7")]
        public string? OtherResident7 { get; set; }

  

        [Column("resident_in_india_8")]
        public string? ResidentInIndia8 { get; set; }

        [Column("other_resident_8")]
        public string? OtherResident8 { get; set; }


        [Column("rows_required_10a")]
        public string? RowsRequired10A { get; set; }

        [Column("section_number")]
        public string? SectionNumber { get; set; }



        [Column("penalty_imposed")]
        public string? PenaltyImposed { get; set; }

        [Column("rows_required_10b")]
        public string? RowsRequired10B { get; set; }

        [Column("offenses_2")]
        public string? Offenses2 { get; set; }

        [Column("dpin_pan_passport")]
        public string? DpinPanPassport { get; set; }

        [Column("name_of_partner")]
        public string? NameOfPartner { get; set; }

        [Column("nominee_name")]
        public string? NomineeName { get; set; }

        [Column("section_num")]
        public string? SectionNum { get; set; }

        [Column("rows_required_11a")]
        public string? RowsRequired11A { get; set; }

        [Column("section_number_11")]
        public string? SectionNumber11 { get; set; }

        
        [Column("offense_date_11")]
        public string? OffenseDate11 { get; set; }

        [Column("turn_over_of_the_llp_exceeds_5cr")]
        public string? TurnOverOfTheLlpExceeds5Cr { get; set; }

        // Part-3

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("name_of_person_signing")]
        public string? NameOfPersonSigning { get; set; }

        [Column("designation_of_person")]
        public string? DesignationOfPerson { get; set; }

        [Column("id_of_person_signing")]
        public string? IdOfPersonSigning { get; set; }

        [Column("annual_return_certify")]
        public Boolean? AnnualReturnCertify { get; set; }

        [Column("dpin_designated_partner_textbox")]
        public string? DpinDesignatedPartnerTextbox { get; set; }

        [Column("here_by_certified")]
        public Boolean? HereByCertified { get; set; }

        [Column("company_name_2")]
        public string? CompanyName2 { get; set; }

        [Column("certi_practice_no_box")]
        public string? CertiPracticeNoBox { get; set; }

        [Column("whether_associate_or_fellow")]
        public string? WhetherAssociateOrFellow { get; set; }

        [Column("penalty_imp")]
        public string? PenaltyImp { get; set; }






    }

    [TableName("tbl_form11", "vw_form11")]
    public class FORM11View : FORM11
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}