using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    public class SH7Share : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("type_of_shares")]
        public string? TypeOfShares { get; set; }

        [Column("class_of_shares")]
        public string? ClassOfShares { get; set; }

        [Column("nominal_value_per_share")]
        public decimal? NominalValuePerShare { get; set; }

        [Column("existing_number_of_shares")]
        public int? ExistingNumberOfShares { get; set; }

        [Column("revision_required")]
        public string? RevisionRequired { get; set; }

        [Column("additional_number_of_shares")]
        public int? AdditionalNumberOfShares { get; set; }

        [Column("revised_number_of_shares")]
        public int? RevisedNumberOfShares { get; set; }

        [Column("existing_total_value")]
        public decimal? ExistingTotalValue { get; set; }

        [Column("revised_total_value")]
        public decimal? RevisedTotalValue { get; set; }

        [Column("total_addition")]
        public decimal? TotalAddition { get; set; }

        [Column("brief_description_of_conditions")]
        public string? BriefDescriptionOfConditions { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }
    }

}