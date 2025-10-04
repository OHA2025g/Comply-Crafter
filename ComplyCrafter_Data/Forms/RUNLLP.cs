using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_runllp", "vw_runllp")]
    public class RUNLLP : BaseModel
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

        //part-1

        [Column("purpose")]
        public string? Purpose { get; set; }

        //[Column("llp_llpin")]
        //public string? LlpLlpin { get; set; }

        //[Column("count_check")]
        //public string? CountCheck { get; set; }

        //[Column("search_code")]
        //public string? SearchCode { get; set; }

        [Column("nic_code_serial")]
        public string? NicCodeSerial { get; set; }

        //[Column("code_nici")]
        //public string? CodeNici { get; set; }

        //[Column("nic_code1_desc")]
        //public string? NicCode1Desc { get; set; }

        //[Column("remove")]
        //public string? Remove { get; set; }

        //[Column("code_nic_serial")]
        //public string? CodeNicSerial { get; set; }

        //[Column("code_nic2")]
        //public string? CodeNic2 { get; set; }

        //[Column("code2_nic_cdesc")]
        //public string? Code2NicCdesc { get; set; }

        //[Column("code_serial_nic")]
        //public string? CodeSerialNic { get; set; }

        //[Column("nic_code3_desc")]
        //public string? NicCode3Desc { get; set; }

        [Column("codes_nic")]
        public string? CodesNic { get; set; }

        [Column("nic_codes_desc")]
        public string? NicCodesDesc { get; set; }

        [Column("proposed_name1")]
        public string? ProposedName1 { get; set; }

        [Column("proposed_name2")]
        public string? ProposedName2 { get; set; }

        [Column("attachment_file_name")]
        public string? AttachmentFileName { get; set; }


    }

    [TableName("tbl_runllp", "vw_runllp")]
    public class RUNLLPView : RUNLLP
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}