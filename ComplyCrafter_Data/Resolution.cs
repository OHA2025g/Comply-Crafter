using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_resolution", "vw_resolution")]
    public class Resolution : BaseModel
    {
        [Column("number")]
        public string? Number { get; set; }

        [Column("title")]
        public string? Title { get; set; }

        [Column("agenda_text")]
        public string? AgendaText { get; set; }

        [Column("meeting_text")]
        public string? MeetingText { get; set; }

        [Column("resolution_text")]
        public string? ResolutionText { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("subcategory")]
        public string? SubCategory { get; set; }

    }

    [TableName("tbl_resolution", "vw_resolution")]
    public class ResolutionView : Resolution
    {
    }
}