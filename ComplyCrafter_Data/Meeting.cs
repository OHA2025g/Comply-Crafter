using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_meeting", "vw_meeting")]
    public class Meeting : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("agm_fy")]
        public string? AgmFY { get; set; }

        [Column("agm_number")]
        public int? AgmNumber { get; set; }

        [Column("eogm_requisition")]
        public string? EogmRequisition { get; set; }

        [Column("date_notice")]
        public DateTime? DateNotice { get; set; }

        [Column("date_meeting")]
        public DateTime? DateMeeting { get; set; }

        [Column("time_meeting")]
        public string? TimeMeeting { get; set; }

        [Column("commencement_meeting")]
        public string? CommencementMeeting { get; set; }

        [Column("number_meeting")]
        public int? NumberMeeting { get; set; }

        [Column("person_signing_notice")]
        public string? PersonSigningNotice { get; set; }

        [Column("signing_meeting_place")]
        public string? SigningMeetingPlace { get; set; }

        [Column("meeting_mode")]
        public string? MeetingMode { get; set; }

        [Column("office_yes_no")]
        public string? OfficeYesNo { get; set; }

        [Column("name_dir")]
        public string? NameDir { get; set; }

        [Column("designation_dir")]
        public string? DesignationDir { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("last_date")]
        public DateTime? LastDate { get; set; }

        [Column("phone_no")]
        public string? PhoneNo { get; set; }

        [Column("email_id")]
        public string? EmailId { get; set; }

        [Column("advance_consent_date")]
        public DateTime? AdvanceConsentDate { get; set; }

        [Column("meeting_venue")]
        public string? MeetingVenue { get; set; }

        [Column("venue_address")]
        public string? VenueAddress { get; set; }

        [Column("venue_state")]
        public string? VenueState { get; set; }

        [Column("venue_city")]
        public string? VenueCity { get; set; }

        [Column("venue_pincode")]
        public string? VenuePincode { get; set; }

        [Column("signing_director")]
        public string? SigningDirector { get; set; }

        [Column("roc_address")]
        public string? RocAddress { get; set; }

        [Column("signing_date")]
        public string? SigningDate { get; set; }

        [Column("signing_place")]
        public string? SigningPlace { get; set; }

        [Column("query_registration_date")]
        public DateTime? QueryRegistrationDate { get; set; }

        [Column("query_registration_time")]
        public string? QueryRegistrationTime { get; set; }

        [Column("query_registration_email")]
        public string? QueryRegistrationEmail { get; set; }

        [Column("director_attend_electronically")]
        public string? DirectorAttendElectronically { get; set; }

        [Column("special_invitee")]
        public string? SpecialInvitee { get; set; }

        [Column("create_general_meeting")]
        public string? CreateGeneralMeeting { get; set; }

        [Column("type_of_meeting")]
        public string? TypeOfMeeting { get; set; }

        [Column("existing_agm")]
        public string? ExistingAGM { get; set; }

        [Column("existing_egm")]
        public string? ExistingEGM { get; set; }

        [Column("general_meeting_date")]
        public DateTime? GeneralMeetingDate { get; set; }

        [Column("general_meeting_time")]
        public string? GeneralMeetingTime { get; set; }

        [Column("agm_number_str")]
        public string? AgmNumberStr { get; set; }

        [Column("egm_place")]
        public string? EgmPlace { get; set; }

        [Column("authorized_signatory_1")]
        public string? AuthorizedSignatory1 { get; set; }

        [Column("authorized_signatory_2")]
        public string? AuthorizedSignatory2 { get; set; }

        // Minutes section
        [Column("chairperson_director")]
        public string? ChairpersonDirector { get; set; }

        [Column("chairperson_member")]
        public string? ChairpersonMember { get; set; }

        [Column("chairperson_chairperson")]
        public string? ChairpersonChairperson { get; set; }

        [Column("chairperson_type")]
        public string? ChairpersonType { get; set; }

        [Column("chairperson_role")]
        public string? ChairpersonRole { get; set; }

        [Column("meeting_time_concluded")]
        public string? MeetingTimeConcluded { get; set; }

        [Column("entry_in_minutes_book_date")]
        public DateTime? EntryInMinutesBookDate { get; set; }

        [Column("signing_minutes_place")]
        public string? SigningMinutesPlace { get; set; }

        [Column("signing_minutes_date")]
        public DateTime? SigningMinutesDate { get; set; }

        [Column("signing_attendance_place")]
        public string? SigningAttendancePlace { get; set; }

        [Column("signing_attendance_date")]
        public DateTime? SigningAttendanceDate { get; set; }

        [Column("authorized_person_in_minutes")]
        public string? AuthorizedPersonInMinutes { get; set; }

        [Column("authorized_person_in_minutes_details")]
        public string? AuthorizedPersonInMinutesDetails { get; set; }

        // Dispatch section
        [Column("draft_minutes_circulated")]
        public string? DraftMinutesCirculated { get; set; }

        [Column("communicated_comments")]
        public string? CommunicatedComments { get; set; }

        [Column("signed_minutes_circulated")]
        public string? SignedMinutesCirculated { get; set; }

        [BypassInSQLUpdate]
        [Column("ack_draft_url")]
        public string? AckDraftUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("ack_signed_url")]
        public string? AckSignedUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("ack_notice_url")]
        public string? AckNoticeUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("reg_att_url")]
        public string? RegAttUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("meet_dir_url")]
        public string? MeetDirUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("notice_url")]
        public string? NoticeUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("minutes_url")]
        public string? MinutesUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("ctc_url")]
        public string? CtcUrl { get; set; }


        [BypassInSQL]
        public IEnumerable<MeetingSpecialInvitee>? SpecialInviteeList { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingCirculation>? CNoticeList { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingCirculation>? CDraftList { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingCirculation>? CSignedList { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingCommunicateComment>? CommunicateCommentList { get; set; }

        [BypassInSQL]
        public IEnumerable<MeetingResolution>? ResolutionList { get; set; }
    }

    [TableName("tbl_meeting", "vw_meeting")]
    public class MeetingView : Meeting
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

    [TableName("tbl_meeting_resolution", "tbl_meeting_resolution")]
    public class MeetingResolution : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("meeting")]
        public int? Meeting { get; set; }

        [Column("resolution")]
        public int? Resolution { get; set; }

        [Column("action")]
        public int? Action { get; set; }

        [Column("sequence_no")]
        public int? Sequence { get; set; }

    }

}