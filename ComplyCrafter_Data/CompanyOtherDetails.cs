using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_company_other_details")]
    public class CompanyOtherDetails : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("tan")]
        public string? Tan { get; set; }

        [Column("brn_no")]
        public string? BrnNo { get; set; }

        [Column("food_licence_no")]
        public string? FoodLicenceNo { get; set; }

        [Column("msme_no")]
        public string? MsmeNo { get; set; }

        [Column("imp_exp_code")]
        public string? ImpExpCode { get; set; }

        [Column("trade_mark_no")]
        public string? TradeMarkNo { get; set; }

        [Column("cor")]
        public string? Cor { get; set; }

    }
}