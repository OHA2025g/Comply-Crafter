using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_pas6", "vw_pas6")]
    public class PAS6 : BaseModel
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

        [Column("from_date")]
        public DateTime? FromDate { get; set; }

        [Column("to_date")]
        public DateTime? ToDate { get; set; }

        [Column("securities")]
        public int? Securities { get; set; }

        [Column("held_shares_cdsl")]
        public int? HeldSharesOfCdsl { get; set; }

        [Column("held_capitals_cdsl")]
        public decimal? HeldCapitalsOfCdsl { get; set; }

        [Column("held_shares_nsdl")]
        public int? HeldSharesOfNsdl { get; set; }

        [Column("held_capitals_nsdl")]
        public decimal? HeldCapitalsOfNsdl { get; set; }

        [Column("shares_held_physical_form")]
        public int? SharesHeldPhysicalForm { get; set; }

        [Column("capital_held_physical")]
        public decimal? CapitalHeldPhysical { get; set; }

        [Column("issued_shares")]
        public int? IssuedShares { get; set; }

        [Column("number_total")]
        public int? NumberTotal { get; set; }

        [Column("reason_physical_shares")]
        public string? ReasonOfPhysicalShares { get; set; }

        [Column("beginning_shares")]
        public int? BeginningShares { get; set; }

        [Column("reporting_whether")]
        public string? ReportingWhether { get; set; }

        [Column("shares_number")]
        public int? SharesNumber { get; set; }

        [Column("rights_number_of_shares")]
        public int? RightsNumberOfShares { get; set; }

        [Column("rights_nsdl")]
        public string? RightsNSDL { get; set; }

        [Column("rights_cdsl")]
        public string? RightsCDSL { get; set; }

        [Column("bonus_shares")]
        public int? BonusShares { get; set; }

        [Column("bonus_intimate_to_nsdl")]
        public string? BonusIntimateToNSDL { get; set; }

        [Column("bonus_intimate_to_cdsl")]
        public string? BonusIntimateToCDSL { get; set; }

        [Column("private_placement_shares")]
        public int? PrivatePlacementShares { get; set; }

        [Column("private_placement_to_nsdl")]
        public string? PrivatePlacementToNSDL { get; set; }

        [Column("private_placement_to_cdsl")]
        public string? PrivatePlacementToCDSL { get; set; }

        [Column("shares_of_esops")]
        public int? SharesOfESOPs { get; set; }

        [Column("esop_intimated_to_nsdl")]
        public string? EsopIntimatedToNSDL { get; set; }

        [Column("esop_intimated_to_cdsl")]
        public string? EsopIntimatedToCDSL { get; set; }

        [Column("shares_of_amalgamation")]
        public int? SharesOfAmalgamation { get; set; }

        [Column("amalgamation_nsdl")]
        public string? AmalgamationNSDL { get; set; }

        [Column("amalgamation_cdsl")]
        public string? AmalgamationCDSL { get; set; }

        [Column("shares_of_conversion")]
        public int? SharesOfConversion { get; set; }

        [Column("conversion_nsdl")]
        public string? ConversionNSDL    { get; set; }

        [Column("conversion_cdsl")]
        public string? ConversionCDSL { get; set; }

        [Column("shares_of_buyback")]
        public int? SharesOfBuyBack { get; set; }

        [Column("buy_nsdl")]
        public string? BuyNSDL { get; set; }

        [Column("buy_cdsl")]
        public string? BuyCDSL { get; set; }

        [Column("shares_of_capital_reduction")]
        public int? SharesOfCapitalReduction { get; set; }

        [Column("reduction_nsdl")]
        public string? ReductionNSDL { get; set; }

        [Column("reduction_cdsl")]
        public string? ReductionCDSL { get; set; }

        [Column("shares_of_forfeiture")]
        public int? SharesOfForfeiture { get; set; }

        [Column("forfeiture_nsdl")]
        public string? ForfeitureNSDL { get; set; }

        [Column("forfeiture_cdsl")]
        public string? ForfeitureCDSL { get; set; }


        [Column("any_other_shares")]
        public int? AnyOtherShares { get; set; }

        [Column("specify_nsdl")]
        public string? SpecifyNSDL { get; set; }

        [Column("specify_cdsl")]
        public string? SpecifyCDSL { get; set; }

        [Column("total_reporting_shares")]
        public int? TotalReportingShares { get; set; }
   

        [Column("promoters_of_demat")]
        public int? PromotersOfDemat { get; set; }

        [Column("promoters_of_physical")]
        public int? PromotersOfPhysical { get; set; }

        [Column("promoters_of_total")]
        public int? PromotersOfTotal { get; set; }

        [Column("directors_demat")]
        public int? DirectorsDemat { get; set; }

        [Column("directors_physical")]
        public int? DirectorsPhysical { get; set; }

        [Column("directors_total")]
        public int? DirectorsTotal { get; set; }

        [Column("kmps_demat")]
        public int? KMPsDemat { get; set; }

        [Column("kmps_physical")]
        public int? KMPsPhysical { get; set; }

        [Column("kmps_total")]
        public int? KMPsTotal { get; set; }

        [Column("whether_members")]
        public string? WhetherMembers { get; set; }

        [Column("update_date")]
        public string? UpdateDate { get; set; }

        [Column("confirmed_requests")]
        public int? ConfirmedRequests { get; set; }

        [Column("confirmed_share")]
        public int? ConfirmedShare { get; set; }

        [Column("confirmed_delay_reasons")]
        public string? ConfirmedDelayReasons { get; set; }

        [Column("pending_requests")]
        public int? PendingRequests { get; set; }

        [Column("pending_share")]
        public int? PendingShare { get; set; }

        [Column("pending_delay_reasons")]
        public string? PendingDelayReasons { get; set; }

        [Column("whether_appointment")]
        public string? WhetherAppointment { get; set; }

        [Column("agency_company_name")]
        public string? AgencyCompanyName { get; set; }

        [Column("other_details")]
        public string? OtherDetails { get; set; }

        [Column("resolution_number")]
        public int? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("certified_name")]
        public string? CertifiedName { get; set; }

        [Column("profession")]
        public string? Profession { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("din")]
        public int? Din { get; set; }

        [Column("professional_name")]
        public string? ProfessionalName { get; set; }

        [Column("professional_address")]
        public string? ProfessionalAddress { get; set; }

        [Column("professional_email")]
        public string? ProfessionalEmail { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("name_of_associate")]
        public string? NameOfAssociate { get; set; }

        [Column("certificate_number")]
        public int? CertificateNumber { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }

    }

    [TableName("tbl_pas6", "vw_pas6")]
    public class PAS6View : PAS6
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}