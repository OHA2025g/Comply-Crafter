using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_gnl2", "vw_gnl2")]
    public class GNL2 : BaseModel
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

        [Column("filed_document")]
        public string? FiledDocument { get; set; }

        [Column("issued_advertisement_date")]
        public string? IssuedAdvertisementDate { get; set; }

        [Column("opening_acceptance")]
        public string? OpeningAcceptance { get; set; }

        [Column("expected_advertisement_date")]
        public string? ExpectedAdvertisementDate { get; set; }

        [Column("others")]
        public string? Others { get; set; }

        [Column("reference_act")]
        public string? ReferenceAct { get; set; }

        [Column("companies_act")]
        public string? CompaniesAct { get; set; }

        [Column("srn")]
        public int? Srn { get; set; }

        [Column("special_resolutiondate")]
        public string? SpecialResolutionDate { get; set; }

        [Column("event_date")]
        public string? EventDate { get; set; }

        [Column("directors_date")]
        public string? DirectorsDate { get; set; }

        [Column("prospectus_document")]
        public string? ProspectusDocument { get; set; }

        [Column("herring_document")]
        public string? HerringDocument { get; set; }

        [Column("advertisement_document")]
        public string? AdvertisementDocument { get; set; }

        [Column("placement_document")]
        public string? PlacementDocument { get; set; }

        [Column("companies_document")]
        public string? CompaniesDocument { get; set; }

        [Column("companies_rules_document")]
        public string? CompaniesRulesDocument { get; set; }

        [Column("companies153_document")]
        public string? Companies153Document { get; set; }

        [Column("companies154_document")]
        public string? Companies154Document { get; set; }

        [Column("companies156_document")]
        public string? Companies156Document { get; set; }

        [Column("companies157_document")]
        public string? Companies157Document { get; set; }

        [Column("companies158_document")]
        public string? Companies158Document { get; set; }

        [Column("companies159_document")]
        public string? Companies159Document { get; set; }

        [Column("liquidation_document")]
        public string? LiquidationDocument { get; set; }

        [Column("relevant_document")]
        public string? RelevantDocument { get; set; }

        [Column("financial_document")]
        public string? FinancialDocument { get; set; }

        [Column("valuation_document")]
        public string? ValuationDocument { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("capacity")]
        public string? Capacity { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("din")]
        public string? Din { get; set; }

    }

        [TableName("tbl_gnl2", "vw_gnl2")]
    public class GNL2View : GNL2
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}