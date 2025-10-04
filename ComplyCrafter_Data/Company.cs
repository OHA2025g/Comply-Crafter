using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_company", "vw_company")]
    public class Company : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [BypassInSQLUpdate]
        [Column("cin")]
        public string? Cin { get; set; }

        [BypassInSQLUpdate]
        [Column("cin_updated_on")]
        public DateTime? CinUpdatedOn { get; set; }

        [Column("incorporation_date")]
        public DateTime? IncorporationDate { get; set; }

        [Column("company_contact_no")]
        public string? CompanyContactNo { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("company_type")]
        public string? CompanyType { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("gst_no")]
        public string? GstNo { get; set; }

        [Column("website")]
        public string? Website { get; set; }

        [Column("is_deleted")]
        public Boolean? IsDeleted { get; set; }

        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [Column("deleted_by")]
        public int DeletedBy { get; set; }

        [BypassInSQL]
        public CompanyDetails? Details { get; set; }

        [BypassInSQL]
        public CompanyOtherDetails? OtherDetails { get; set; }

        [BypassInSQL]
        public CompanyFinancialDetails? FinancialDetails { get; set; }

        [BypassInSQL]
        public List<Director> Directors { get; set; } = new List<Director>();

        [BypassInSQL]
        public List<CompanyIndexCharge> Charges { get; set; } = new List<CompanyIndexCharge>();
    }

    [TableName("tbl_company", "vw_company")]
    public class CompanyView : Company
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

    [TableName("tbl_company_ioc")]
    public class CompanyIndexCharge : NpgSQLTable
    {

        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("srn")]
        public string? SRN { get; set; }

        [Column("charge_id")]
        public string? ChargeId { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [Column("holder_name")]
        public string? HolderName { get; set; }

        [Column("amount")]
        public int? Amount { get; set; }

        [Column("creation_date")]
        public DateTime? CreationDate { get; set; }

        [Column("modification_date")]
        public DateTime? ModificationDate { get; set; }

        [Column("address_1")]
        public string? Address1 { get; set; }

        [Column("address_2")]
        public string? Address2 { get; set; }

    }
}