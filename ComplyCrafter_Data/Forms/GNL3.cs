using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_gnl3", "vw_gnl3")]
    public class GNL3 : BaseModel
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

        [Column("number_charged")]
        public int? NumberCharged { get; set; }

        [Column("permission_withdrawn")]
        public string? PermissionWithdrawn { get; set; }

        [Column("consent_date")]
        public DateTime? ConsentDate { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("copy_attachment")]
        public string? CopyAttachment { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }

        [Column("director_resolution")]
        public string? DirectorResolution { get; set; }

        [Column("director_date")]
        public DateTime? DirectorDate { get; set; }

        [Column("certification_declaration")]
        public Boolean? CertificationDeclaration { get; set; }

        [Column("din_of_person_charged")]
        public string? DinOfPersonCharged { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("din")]
        public string? Din { get; set; }

        [Column("category")]
        public string? Category { get; set; }

       

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("associate_or_fellow")]
        public string? AssociateOrFellow { get; set; }

        [Column("membership_number")]
        public int? MembershipNumber { get; set; }


    }

    [TableName("tbl_gnl3", "vw_gnl3")]
    public class GNL3View : GNL3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}