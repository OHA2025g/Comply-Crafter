using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [TableName("tbl_action_address_change", "tbl_action_address_change")]
    public class ChangeOfficeAddress : BaseModel
    {
        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("effective_date")]
        public DateTime? EffectiveDate { get; set; }

        [Column("existing_address")]
        public string? ExistingAddress { get; set; }

        [Column("new_office_line1")]
        public string? NewOfficeLine1 { get; set; }

        [Column("new_office_line2")]
        public string? NewOfficeLine2 { get; set; }

        [Column("new_office_city")]
        public string? NewOfficeCity { get; set; }

        [Column("new_office_state")]
        public string? NewOfficeState { get; set; }

        [Column("new_office_district")]
        public string? NewOfficeDistrict { get; set; }

        [Column("new_office_country")]
        public string? NewOfficeCountry { get; set; }

        [Column("new_office_pincode")]
        public string? NewOfficePincode { get; set; }

        [Column("registered_office_premises")]
        public string? RegisteredOfficePremises { get; set; }

        [Column("proposed_roc")]
        public string? ProposedRoC { get; set; }

        [Column("police_station_name")]
        public string? PoliceStationName { get; set; }

        [Column("police_station_address_line1")]
        public string? PoliceStationAddressLine1 { get; set; }

        [Column("police_station_address_line2")]
        public string? PoliceStationAddressLine2 { get; set; }

        [Column("police_station_city")]
        public string? PoliceStationCity { get; set; }

        [Column("police_station_state")]
        public string? PoliceStationState { get; set; }

        [Column("police_station_pincode")]
        public string? PoliceStationPincode { get; set; }

        [Column("utility_services_bill")]
        public string? UtilityServicesBill { get; set; }

        [Column("meeting_type")]
        public string? MeetingType { get; set; }

        [Column("incorporate_agenda")]
        public string? IncorporateAgenda { get; set; }

        [Column("general_meeting_date")]
        public DateTime? GeneralMeetingDate { get; set; }

        [Column("general_meeting_time")]
        public string? GeneralMeetingTime { get; set; }

        [Column("existing_agm")]
        public string? ExistingAGM { get; set; }

        [Column("existing_egm")]
        public string? ExistingEGM { get; set; }

        [Column("incorporate_bm")]
        public string? IncorporateBM { get; set; }

        [Column("board_meeting_date")]
        public DateTime? BoardMeetingDate { get; set; }

        [Column("board_meeting_time")]
        public string? BoardMeetingTime { get; set; }

        [Column("existing_bm")]
        public string? ExistingBM { get; set; }

        [Column("authorized_signatory")]
        public string? AuthorizedSignatory { get; set; }

        [Column("director_name")]
        public string? DirectorName { get; set; }

        [Column("director_din")]
        public string? DirectorDIN { get; set; }

        [Column("director_designation")]
        public string? DirectorDesignation { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("professional_category")]
        public string? ProfessionalCategory { get; set; }

        [Column("professional_name")]
        public string? ProfessionalName { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("practice_number")]
        public string? PracticeNumber { get; set; }

        [Column("associate_fellow")]
        public string? AssociateFellow { get; set; }
    }

}
