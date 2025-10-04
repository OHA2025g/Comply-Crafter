using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_run", "vw_run")]
    public class RUN : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; }

        //[Column("company_name")]
        //public string? CompanyName { get; set; }

        //[Column("company_address")]
        //public string? CompanyAddress { get; set; }

        //[Column("company_email")]
        //public string? CompanyEmail { get; set; }


        [Column("proposed_name")]
        public string? ProposedName { get; set; }

        [Column("proposed_second_name")]
        public string? ProposedSecondName { get; set; }

        [Column("application_comments")]
        public string? ApplicationComments { get; set; }
 
        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

    }

    [TableName("tbl_run", "vw_run")]
    public class RUNView : RUN
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}