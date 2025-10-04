using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir12", "vw_dir12")]
    public class DIR12 : BaseModel
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

        [Column("num_managing_directors")]
        public int? NumManagingDirectors { get; set; }

        [Column("num_kmp")]
        public int? NumKMP { get; set; }

        [Column("srn_inc28")]
        public string? SrnInc28 { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("director_id")]
        public string? DirectorId { get; set; }

        [Column("authorized_person")]
        public string? AuthorizedPerson { get; set; }

        [Column("authorization_details")]
        public string? AuthorizationDetails { get; set; }

        [Column("authorization_date")]
        public DateTime? AuthorizationDate { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_dir12", "vw_dir12")]
    public class DIR12View : DIR12
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}