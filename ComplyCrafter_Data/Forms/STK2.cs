using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_stk2", "vw_stk2")]
    public class STK2 : BaseModel
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

        [Column("cin_corporate")]
        public string? cinCorporate { get; set; }

        [Column("office_address")]
        public string? officeAddress { get; set; }

        [Column("notice_received")]
        public string? noticeRecieved { get; set; }

        [Column("reason_for_closure")]
        public string? reasonForClosure { get; set; }

        [Column("delisted_received")]
        public string? delistedRecieved { get; set; }

        [Column("regulator")]
        public string? regulator { get; set; }

        [Column("resolution")]
        public string? resolution{ get; set; }

        [Column("other")]
        public string? other { get; set; }

        [Column("approval_date")]
        public string? approvalDate { get; set; }

        [Column("srn_related_form")]
        public string? srnRelatedForm { get; set; }

        [Column("mgt_resolution")]
        public string? mgtResolution { get; set; }

        [Column("srn_no_mgt14")]
        public string? srnNoMgt14 { get; set; }

        [Column("description_of_moa")]
        public string? descriptionOfMOA { get; set; }

        [Column("director_manager")]
        public int? directorManager { get; set; }

        [Column("litigations")]
        public string? litigations { get; set; }

        [BypassInSQL]
        public IEnumerable<LitigationChild>? LitigationList { get; set; }

        [Column("declarant_name")]
        public string? DeclarantName { get; set; }

        [Column("declarant_parent_name")]
        public string? DeclarantParentName { get; set; }

        [Column("declarant_company")]
        public string? DeclarantCompany { get; set; }

        [Column("regulated_activities")]
        public string? RegulatedActivities { get; set; }

        [Column("declarant_resolution_number")]
        public string? DeclarantResolutionNumber { get; set; }

        [Column("declaration_date")]
        public string? DeclarationDate { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("member_name")]
        public string? MemberName { get; set; }

        [Column("member_designation")]
        public string? MemberDesignation { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("indemnity_attachment_file")]
        public string? IndemnityAttachmentFile { get; set; }

        [Column("optional_attachment_file")]
        public string? OptinalAttachmentFile { get; set; }

        [Column("director")]
        public string? Director { get; set; }

        [Column("director_din")]
        public string? DirectorDin { get; set; }

        [Column("accountant_type")]
        public string? AccountantType { get; set; }

        [Column("company_secretary")]
        public string? CompanySecretary { get; set; }

        [Column("whether_associate_or_fellow")]
        public string? WhetherAssociateOrFellow { get; set; }

        [Column("certificate_number")]
        public string? CertificateNumber { get; set; }

    }

    [TableName("tbl_stk2", "vw_stk2")]
    public class STK2View : STK2
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

     public class LitigationChild : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("litigation_pending_act")]
        public string? LitigationPendingAct { get; set; }

        [Column("name_of_authority")]
        public string? NameOfAuthority { get; set; }

        [Column("case_number")]
        public string? CaseNumber { get; set; }

        [Column("subject_matter")]
        public string? SubjectMatter { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }
    }

}