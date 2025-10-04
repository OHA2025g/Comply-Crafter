using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_company_financial_details")]
    public class CompanyFinancialDetails : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("previous_name")]
        public string? PreviousName { get; set; }

        [Column("previous_begin_date")]
        public DateTime? PreviousBeginDate { get; set; }

        [Column("previous_end_date")]
        public DateTime? PreviousEndDate { get; set; }

        [Column("financial_year_begin_month")]
        public string? FinancialYearBeginMonth { get; set; }

        [Column("financial_year_end_month")]
        public string? FinancialYearEndMonth { get; set; }

        [Column("other_cin")]
        public string? OtherCin { get; set; }

        [Column("other_cin_begin_date")]
        public DateTime? OtherCinBeginDate { get; set; }

        [Column("other_cin_end_date")]
        public DateTime? OtherCinEndDate { get; set; }

        [Column("other_address")]
        public string? OtherAddress { get; set; }

        [Column("other_address_begin_date")]
        public DateTime? OtherAddressBeginDate { get; set; }

        [Column("other_address_end_date")]
        public DateTime? OtherAddressEndDate { get; set; }


    }
}