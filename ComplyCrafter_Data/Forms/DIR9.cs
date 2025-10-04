using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir9", "vw_dir9")]
    public class DIR9 : BaseModel
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

        [Column("roc_alert")]
        public string? RocAlert { get; set; }

        [Column("disqualification_section")]
        public string? DisqualificationSection { get; set; }

        [Column("num_directors")]
        public int? NumDirectors { get; set; }

        [Column("reason_11642b")]
        public bool? Reason11642b { get; set; }

        [Column("repay_deposit_date")]
        public DateTime? RepayDepositDate { get; set; }

        [Column("repay_deposit_expire")]
        public DateTime? RepayDepositExpire { get; set; }

        [Column("reason_21642b")]
        public bool? Reason21642b { get; set; }

        [Column("pay_deposit_due")]
        public DateTime? PayDepositDue { get; set; }

        [Column("pay_deposit_expire")]
        public DateTime? PayDepositExpire { get; set; }

        [Column("reason_31642b")]
        public bool? Reason31642b { get; set; }

        [Column("failed_to_redeem")]
        public DateTime? FailedToRedeem { get; set; }

        [Column("failed_to_redeem_expire")]
        public DateTime? FailedToRedeemExpire { get; set; }

        [Column("reason_41642b")]
        public bool? Reason41642b { get; set; }

        [Column("debentures_redeem")]
        public DateTime? DebenturesRedeem { get; set; }

        [Column("debentures_redeem_expire")]
        public DateTime? DebenturesRedeemExpire { get; set; }

        [Column("reason_51642b")]
        public bool? Reason51642b { get; set; }

        [Column("dividend_date")]
        public DateTime? DividendDate { get; set; }

        [Column("dividend_expire")]
        public DateTime? DividendExpire { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }

        [Column("din_pan")]
        public string? DinPan { get; set; }
    }

    [TableName("tbl_dir9", "vw_dir9")]
    public class DIR9View : DIR9
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}