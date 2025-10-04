using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [TableName("tbl_action_general", "tbl_action_general")]
    public class GeneralAction : BaseModel
    {
        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("content")]
        public string? Content { get; set; }
    }

}
