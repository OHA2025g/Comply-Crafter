using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [TableName("tbl_action_director_appointment", "tbl_action_director_appointment")]
    public class DirectorAppointment : BaseModel
    {
        [Column("company_id")]
        public int? CompanyId { get; set; }


        // Part 1
        [Column("category")]
        public string? Category { get; set; }

        [Column("sub_category")]
        public string? SubCategory { get; set; }

        [Column("appointee_type")]
        public string? AppointeeType { get; set; }

        [Column("bank_name")]
        public string? BankName { get; set; }

        [Column("nom_auth_sign")]
        public string? NomAuthSign { get; set; }

        [Column("nom_auth_desi")]
        public string? NomAuthDesi { get; set; }

        [Column("nom_auth_din_pan")]
        public string? NomAuthDinPan { get; set; }

        [Column("nom_auth_date")]
        public DateTime? NomAuthDate { get; set; }

        [Column("nom_auth_place")]
        public string? NomAuthPlace { get; set; }

        [Column("type_meeting")]
        public string? TypeMeeting { get; set; }

        [Column("exist_meeting")]
        public string? ExistMeeting { get; set; }

        [Column("existing_meeting")]
        public string? ExistingMeeting { get; set; }

        [Column("meeting_date")]
        public DateTime? MeetingDate { get; set; }

        [Column("timing")]
        public string? Timing { get; set; }

        [Column("circular_res_date")]
        public DateTime? CircularResDate { get; set; }

        [Column("chairman")]
        public string? Chairman { get; set; }

        [Column("which_meeting")]
        public string? WhichMeeting { get; set; }

        [Column("exist_meeting_agm")]
        public string? ExistMeetingAgm { get; set; }

        [Column("m_id_agm")]
        public string? MIdAgm { get; set; }

        [Column("m_id_egm")]
        public string? MIdEgm { get; set; }

        [Column("meeting_date_agm")]
        public DateTime? MeetingDateAgm { get; set; }

        [Column("timing_agm")]
        public string? TimingAgm { get; set; }

        // Part 2
        [Column("din")]
        public string? Din { get; set; }

        [Column("appointee_name")]
        public string? AppointeeName { get; set; }

        [Column("f_name")]
        public string? FName { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("dob")]
        public DateTime? Dob { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("occupation")]
        public string? Occupation { get; set; }

        [Column("date_appointment")]
        public DateTime? DateAppointment { get; set; }

        [Column("date_consent")]
        public DateTime? DateConsent { get; set; }

        [Column("place_consent")]
        public string? PlaceConsent { get; set; }

        [Column("issecurity_clear")]
        public string? IsSecurityClear { get; set; }

        [Column("ismem_institute")]
        public string? IsMemInstitute { get; set; }

        [Column("institue_name")]
        public string? InstitueName { get; set; }

        [Column("membership_no")]
        public decimal? MembershipNo { get; set; }

        [Column("practice_no")]
        public decimal? PracticeNo { get; set; }

     
        // Part 4
        [Column("date_of_signing")]
        public DateTime? DateOfSigning { get; set; }

        [Column("place_of_consent")]
        public string? PlaceOfConsent { get; set; }

        [Column("date_of_signing_consent")]
        public DateTime? DateOfSigningConsent { get; set; }

        [Column("place_of_consent_consent")]
        public string? PlaceOfConsentConsent { get; set; }

    }

}
