using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_company_details")]
    public class CompanyDetails: NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("authorized_capital")]
        public decimal? AuthorizedCapital { get; set; }

        [Column("paid_up_capital")]
        public decimal? PaidUpCapital { get; set; }

        [Column("company_class")]
        public string? CompanyClass{ get; set; }

        [Column("registration_number")]
        public int RegistrationNumber { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("sub_category")]
        public string? SubCategory { get; set; }

        [Column("date_of_last_balance_sheet")]
        public DateTime? DateOfLastBalanceSheet { get; set; }

        [Column("last_agm_date")]
        public DateTime? LastAgmDate { get; set; }

        [Column("whether_listed")]
        public string? WhetherListed { get; set; }

        [Column("roc")]
        public string? Roc { get; set; }

        [Column("address_books_maintained_at")]
        public string? AddressBooksMaintainedAt { get; set; }

        [Column("business_activity")]
        public string? BusinessActivity { get; set; }

        [Column("main_business_division_code")]
        public string? MainBusinessDivisionCode { get; set; }

        [Column("main_objects")]
        public string? MainObjects { get; set; }

    }

}