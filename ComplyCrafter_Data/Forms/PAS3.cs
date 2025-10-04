using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_pas3", "vw_pas3")]
    public class PAS3 : BaseModel
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

        [Column("number_of_allotments")]
        public int? NumberOfAllotments { get; set; }

        [Column("no_of_classes_preference")]
        public int? NoOfClassesPreference { get; set; }

        [Column("no_of_classes_equity")]
        public int? NoOfClassesEquity { get; set; }

        [Column("no_of_unclassified")]
        public int? NoOfUnclassified { get; set; }

        [Column("total_unclassified")]
        public int? TotalUnclassified { get; set; }

        [Column("debentures")]
        public int? Debentures { get; set; }

        [Column("loan_secured")]
        public int? LoanSecured { get; set; }

        [Column("others")]
        public int? others { get; set; }


        //[Column("equity_authorized_capital")]
        //public string? EquityAuthorizedCapital { get; set; }

        //[Column("equity_paidup_capital")]
        //public string? EquityPaidupCapital { get; set; }

        [Column("allottees_list")]
        public string? AllotteesList { get; set; }

        [Column("another_attachment")]
        public string? AnotherAttachment { get; set; }

       
        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }


        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("assososiate_or_fellow")]
        public string? AssososiateOrFellow { get; set; }

        [Column("membership_number")]
        public int? MembershipNumber { get; set; }

        [BypassInSQL]
        public IEnumerable<ShareChild>? EquityShareList { get; set; }

        [BypassInSQL]
        public IEnumerable<ShareChild>? PreferenceShareList { get; set; }

    }

    [TableName("tbl_pas3", "vw_pas3")]
    public class PAS3View : PAS3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }
    public class ShareChild : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("class_of_shares")]
        public string? ClassOfShares { get; set; }

        [Column("authorized_capital")]
        public decimal? AuthorizedCapital { get; set; }
 
        [Column("issued_capital")]
        public decimal? IssuedCapital { get; set; }

        [Column("subscribed_capital")]
        public decimal? SubscribedCapital { get; set; }

        [Column("paid_up_capital")]
        public decimal? PaidUpCapital { get; set; }

        [Column("nominal_amnt_per_share")]
        public decimal? NominalAmountPerShare { get; set; }

        [Column("nominal_amnt_per_share_issue")]
        public decimal? NominalAmountPerShareIssue { get; set; }

        [Column("nominal_amnt_per_share_sub")]
        public decimal? NominalAmountPerShareSub { get; set; }

        [Column("nominal_amnt_per_share_paid")]
        public decimal? NominalAmountPerSharePaid { get; set; }

        [Column("total_amnt_shares")]
        public decimal? TotalAmountShares { get; set; }

        [Column("total_amnt_shares_issue")]
        public decimal? TotalAmountSharesIssue { get; set; }

        [Column("total_amnt_shares_sub")]
        public decimal? TotalAmountSharesSub { get; set; }

        [Column("total_amnt_shares_paid")]
        public decimal? TotalAmountSharesPaid { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }
    }
}