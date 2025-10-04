using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form4", "vw_form4")]
    public class FORM4 : BaseModel
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


        // Part 1
        [Column("num_indiv_desig_partner")]
        public int? NumIndivDesigPartner { get; set; }

        [Column("num_bodies_corp_nominees")]
        public int? NumBodiesCorpNominees { get; set; }

        [Column("num_indiv_partner")]
        public int? NumIndivPartner { get; set; }

        [Column("num_bodies_corp_partners")]
        public int? NumBodiesCorpPartners { get; set; }

        [Column("total_partners")]
        public int? TotalPartners { get; set; }

        // Part 2
        [Column("designated_partner")]
        public string? DesignatedPartner { get; set; }

        [Column("dpin_designated_partner")]
        public string? DpinDesignatedPartner { get; set; }

        [Column("professional_category")]
        public string? ProfessionalCategory { get; set; }

        [Column("selected_pcs")]
        public string? SelectedPCS { get; set; }

        [Column("membership_type")]
        public string? MembershipType { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }



    }

    [TableName("tbl_form4", "vw_form4")]
    public class FORM4View : FORM4
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}