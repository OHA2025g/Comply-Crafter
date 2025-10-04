using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mgt14", "vw_mgt14")]
    public class MGT14 : BaseModel
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

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("din")]
        public string? Din { get; set; }

        [Column("resolution_number")]
        public int? ResolutionNumber { get; set; }


        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("category_type")]
        public string? CategoryType { get; set; }

        [Column("company_secretary")]
        public string? CompanySecretary { get; set; }

        [Column("whether_assosiate_or_fellow")]
        public string? WhetherAssosiateOrFellow { get; set; }

        [Column("membership_number")]
        public int? MembershipNumber { get; set; }

        [Column("resolution_copy")]
        public string? ResolutionCopy { get; set; }

        [Column("optional_attatchment")]
        public string? OptionalAttatchment { get; set; }

        [Column("resolution")]
        public Boolean? Resolution { get; set; }

        [Column("agreement")]
        public Boolean? Agreement { get; set; }

        [Column("postal_ballot")]
        public Boolean? PostalBallot { get; set; }

        [Column("notice_dispatch_date")]
        public DateTime? NoticeDispatchDate { get; set; }

        [Column("passing_resolution_date")]
        public DateTime? PassingResolutionDate { get; set; }

        [Column("dispatch_ballot_date")]
        public DateTime? DispatchBallotDate { get; set; }

        [Column("postal_ballot_resolutiont_date")]
        public DateTime? PostalBallotResolutiontDate { get; set; }

        [Column("number_of_resolution")]
        public int? NumberOfResolution { get; set; }

        [Column("agreement_date")]
        public DateTime? AgreementDate { get; set; }

        [Column("companies_act")]
        public string? CompaniesAct { get; set; }


        [Column("agreement_purpose")]
        public string? AgreementPurpose { get; set; }


        [Column("agreement_subject")]
        public string? AgreementSubject { get; set; }

        [Column("authority")]
        public string? Authority { get; set; }

        [Column("srn")]
        public string? Srn { get; set; }

         [Column("resolution_purpose")]
        public string? ResolutionPurpose { get; set; }
    }

        [TableName("tbl_mgt14", "vw_mgt14")]
        public class MGT14View : MGT14
        {
            [Column("ref_user_name")]
            public string? RefUserName { get; set; }
        }

    
}