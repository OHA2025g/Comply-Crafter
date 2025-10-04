using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplyCrafter_Data
{
    [TableName("", "")]
    public class MeetingAgendaDetail : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [BypassInSQL]
        public MeetingAppointmentDetails? AppointmentDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingAuthorizationDetails>? AuthorizationDetails { get; set; }

        [BypassInSQL]
        public MeetingAgendaDetails? MeetingAgendaDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingResolutionForNoticeCertificateDetails>? MeetingResolutionForNoticeCertificateDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingResolutionForMinutesCertificateDetails>? MeetingResolutionForMinutesCertificateDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingResolutionSignatureDetails>? MeetingResolutionSignatureDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingSubscriberDetails>? MeetingSubscriberDetails { get; set; }

        [BypassInSQL]
        public MeetingKMPDetails? MeetingKMPDetails { get; set; }

        [BypassInSQL]
        public MeetingApprovalCertificateConsolidationDetails? MeetingApprovalCertificateConsolidationDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingPerticularsOfCertificatesDetails>? MeetingPerticularsOfCertificatesDetails { get; set; }

        [BypassInSQL]
        public MeetingDirectorDetails? MeetingDirectorDetails { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingInterestInOtherEntitiesDetails>? MeetingInterestInOtherEntitiesDetails { get; set; }
    }

    [TableName("tbl_meeting_appointment_details", "tbl_meeting_appointment_details")]
    public class MeetingAppointmentDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("appointed_director")]
        public string? AppointedDirector { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("number_of_year")]
        public int? NumberOfYear { get; set; }

        [Column("appointment_date")]
        public DateTime? AppointmentDate { get; set; }

        [Column("retirement_date")]
        public DateTime? RetirementDate { get; set; }

        [Column("appointed_director_din")]
        public string? AppointedDirectorDIN { get; set; }

        [Column("director1_approver")]
        public string? Director1Approver { get; set; }

        [Column("director2_approver")]
        public string? Director2Approver { get; set; }

        [Column("share_type")]
        public string? ShareType { get; set; }

        [Column("number_of_shares")]
        public int? NumberOfShares { get; set; }

        [Column("serial_number_from_to")]
        public string? SerialNumberFromTo { get; set; }

        [Column("date_of_consent")]
        public DateTime? DateOfConsent { get; set; }

        [Column("place_of_consent")]
        public string? PlaceOfConsent { get; set; }

        [Column("incorporate_agenda_in_existing_meeting")]
        public string? IncorporateAgendaInExistingMeeting { get; set; }

        [Column("existing_meeting")]
        public string? ExistingMeeting { get; set; }

        [Column("authorized_signatory")]
        public string? AuthorizedSignatory { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("appointee_is")]
        public string? AppointeeIs { get; set; }

        [Column("date_of_passing_circular_resolution")]
        public DateTime? DateOfPassingCircularResolution { get; set; }
    }

    [TableName("tbl_meeting_authorization_details", "tbl_meeting_authorization_details")]
    public class MeetingAuthorizationDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("authorizer")]
        public string? AppointedDirector { get; set; }
    }

    [TableName("tbl_meeting_agenda_details", "tbl_meeting_agenda_details")]
    public class MeetingAgendaDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("agenda")]
        public string? Agenda { get; set; }

        [Column("agenda_heading")]
        public string? AgendaHeading { get; set; }

        [Column("minute_heading")]
        public string? MinuteHeading { get; set; }

        [Column("agenda_preface")]
        public string? AgendaPreface { get; set; }

        [Column("minute_preface")]
        public string? MinutePreface { get; set; }

        [Column("resolution_for_notice_para1")]
        public string? ResolutionForNoticePara1 { get; set; }

        [Column("resolution_for_notice_para2")]
        public string? ResolutionForNoticePara2 { get; set; }

        [Column("resolution_for_minutes_para1")]
        public string? ResolutionForMinutesPara1 { get; set; }

        [Column("resolution_for_minutes_para2")]
        public string? ResolutionForMinutesPara2 { get; set; }

        [Column("signing_director1")]
        public string? SigningDirector1 { get; set; }

        [Column("signing_director2")]
        public string? SigningDirector2 { get; set; }

        [Column("authorized_signatory")]
        public string? AuthorizedSignatory { get; set; }
    }

    [TableName("tbl_meeting_resolution_for_notice_certificate_details", "tbl_meeting_resolution_for_notice_certificate_details")]
    public class MeetingResolutionForNoticeCertificateDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("sr_no")]
        public string? SrNo { get; set; }

        [Column("name_of_holder")]
        public string? NameOfHolder { get; set; }

        [Column("folio_no")]
        public string? FolioNo { get; set; }

        [Column("certificate_no")]
        public string? CertificateNo { get; set; }

        [Column("distinctive_no_from")]
        public string? DistinctiveNoFrom { get; set; }

        [Column("distinctive_no_to")]
        public string? DistinctiveNoTo { get; set; }

        [Column("type_of_securities")]
        public string? TypeOfSecurities { get; set; }

        [Column("no_of_securities")]
        public int? NoOfSecurities { get; set; }

        [Column("new_certificate_no")]
        public string? NewCertificateNo { get; set; }
    }

    [TableName("tbl_meeting_resolution_for_minutes_certificate_details", "tbl_meeting_resolution_for_minutes_certificate_details")]
    public class MeetingResolutionForMinutesCertificateDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("sr_no")]
        public string? SrNo { get; set; }

        [Column("name_of_holder")]
        public string? NameOfHolder { get; set; }

        [Column("folio_no")]
        public string? FolioNo { get; set; }

        [Column("certificate_no")]
        public string? CertificateNo { get; set; }

        [Column("distinctive_no_from")]
        public string? DistinctiveNoFrom { get; set; }

        [Column("distinctive_no_to")]
        public string? DistinctiveNoTo { get; set; }

        [Column("type_of_securities")]
        public string? TypeOfSecurities { get; set; }

        [Column("no_of_securities")]
        public int? NoOfSecurities { get; set; }

        [Column("new_certificate_no")]
        public string? NewCertificateNo { get; set; }
    }

    [TableName("tbl_meeting_resolution_signature_details", "tbl_meeting_resolution_signature_details")]
    public class MeetingResolutionSignatureDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("signing_director")]
        public string? SigningDirector { get; set; }

        [Column("din_pan")]
        public string? DinPan { get; set; }

        [Column("signing_date")]
        public DateTime? SigningDate { get; set; }
    }

    [TableName("tbl_meeting_subscriber_details", "tbl_meeting_subscriber_details")]
    public class MeetingSubscriberDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("subscriber_name")]
        public string? SubscriberName { get; set; }

        [Column("folio_no")]
        public string? FolioNo { get; set; }

        [Column("number_of_share")]
        public int? NumberOfShare { get; set; }
    }

    [TableName("tbl_meeting_kmp_details", "tbl_meeting_kmp_details")]
    public class MeetingKMPDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("father_name")]
        public string? FatherName { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("address_line1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("pincode")]
        public int? Pincode { get; set; }

        [Column("country")]
        public string? Country { get; set; }
    }

    [TableName("tbl_meeting_approval_certificate_consolidaton_details", "tbl_meeting_approval_certificate_consolidaton_details")]
    public class MeetingApprovalCertificateConsolidationDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("approval_mode")]
        public string? ApprovalMode { get; set; }

        [Column("date_of_passing_circular_resolution")]
        public string? DateOfPassingCircularResolution { get; set; }

        [Column("incorporate_agenda_in_existing_board_meeting")]
        public string? IncorporateAgendaInExistingBoardMeeting { get; set; }

        [Column("existing_board_meeting")]
        public string? ExistingBoardMeeting { get; set; }

        [Column("date_of_new_meeting")]
        public string? DateOfNewMeeting { get; set; }

        [Column("time_of_new_meeting")]
        public string? TimeOfNewMeeting { get; set; }

        [Column("authorized_signatory")]
        public string? AuthorizedSignatory { get; set; }
    }

    [TableName("tbl_meeting_perticulars_of_certificates_details", "tbl_meeting_perticulars_of_certificates_details")]
    public class MeetingPerticularsOfCertificatesDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("type_of_share")]
        public string? TypeOfShare { get; set; }

        [Column("shareholder")]
        public string? Shareholder { get; set; }

        [Column("date_of_issue")]
        public DateTime? DateOfIssue { get; set; }
    }

    [TableName("tbl_meeting_director_details", "tbl_meeting_director_details")]
    public class MeetingDirectorDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("din")]
        public string? DIN { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("father_name")]
        public string? FatherName { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("occupation")]
        public string? Occupation { get; set; }

        [Column("date_of_appointment")]
        public DateTime? DateOfAppointment { get; set; }

        [Column("date_of_consent")]
        public DateTime? DateOfConsent { get; set; }

        [Column("place_of_signing_consent")]
        public string? PlaceOfSigningConsent { get; set; }

        [Column("applicant_from_professional_institute")]
        public string? ApplicantFromProfessionalInstitute { get; set; }

        [Column("professional_institute_name")]
        public string? ProfessionalInstituteName { get; set; }

        [Column("membership_no")]
        public string? MembershipNo { get; set; }

        [Column("certificate_practice_no")]
        public string? CertificatePracticeNo { get; set; }
    }

    [TableName("tbl_meeting_interest_in_other_entities_details", "tbl_meeting_interest_in_other_entities_details")]
    public class MeetingInterestInOtherEntitiesDetails : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("meeting_id")]
        public int? MeetingId { get; set; }

        [BypassInSQLUpdate]
        [Column("resolution_id")]
        public int? ResolutionId { get; set; }

        [Column("cin")]
        public string? CIN { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("date_of_appointment")]
        public DateTime? DateOfAppointment { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("other_if_any")]
        public string? OtherIfAny { get; set; }
    }
}
