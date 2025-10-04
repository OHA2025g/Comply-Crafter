using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    public class ClassMaster : BaseModel
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("class_type")]
        public string? ClassType { get; set; }

        [Column("class_name")]
        public string? ClassName { get; set; }

        [Column("class_terms")]
        public string? ClassTerms { get; set; }

        [BypassInSQLUpdate]
        [Column("is_deleted")]
        public Boolean IsDeleted { get; set; }
    }
}
