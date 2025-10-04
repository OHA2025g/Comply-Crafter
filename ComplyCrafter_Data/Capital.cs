using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_capital", "vw_capital")]
    public class Capital : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("type")]
        public string? Type { get; set; }


        [Column("event_date")]
        public DateTime? EventDate { get; set; }

        [Column("unclassified")]
        public decimal? Unclassified { get; set; }

        [Column("total_capital")]
        public decimal? TotalCapital { get; set; }

        [Column("incorporate_agenda")]
        public string? IncorporateAgenda { get; set; }

        [Column("meeting_date")]
        public DateTime? MeetingDate { get; set; }

        [Column("meeting_time")]
        public string? MeetingTime { get; set; }

        [Column("existing_meeting")]
        public string? ExistingMeeting { get; set; }

        [Column("authorized_signatory")]
        public string? AuthorizedSignatory { get; set; }

        [Column("meeting_type")]
        public string? MeetingType { get; set; }

        [Column("incorporate_agenda_gm")]
        public string? IncorporateAgendaGM { get; set; }

        [Column("general_meeting_date")]
        public DateTime? GeneralMeetingDate { get; set; }

        [Column("general_meeting_time")]
        public string? GeneralMeetingTime { get; set; }

        [Column("existing_agm")]
        public string? ExistingAGM { get; set; }

        [Column("existing_egm")]
        public string? ExistingEGM { get; set; }

        [Column("aoa_clause")]
        public string? AoaClause { get; set; }


        [BypassInSQL]
        public IEnumerable<CapitalChild>? EquityList { get; set; }

        [BypassInSQL]
        public IEnumerable<CapitalChild>? PreferenceList { get; set; }
    }

    [TableName("tbl_capital", "vw_capital")]
    public class CapitalView : Capital
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }

        [Column("equity")]
        public string? Equity { get; set; }

        [Column("preference")]
        public string? Preference { get; set; }
    }

    public class CapitalChild : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("child_type")]
        public string? ChildType { get; set; }

        [Column("shares")]
        public decimal? Shares { get; set; }

        [Column("share_value")]
        public decimal? ShareValue { get; set; }

        [Column("total")]
        public decimal? Total { get; set; }

        [Column("class")]
        public string? Class { get; set; }

        [Column("sub_class")]
        public string? SubClass { get; set; }

        [Column("rights")]
        public string? Rights { get; set; }
    }
}