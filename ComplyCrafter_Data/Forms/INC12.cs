using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc12", "vw_inc12")]
    public class INC12 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("company_address")]
        public string? CompanyAddress { get; set; }

        [Column("company_email")]
        public string? CompanyEmail { get; set; }

        [Column("company_type")]
        public string? CompanyType { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("sub_category")]
        public string? SubCategory { get; set; }

        [Column("company_capital")]
        public string? CompanyCapital { get; set; }

        [Column("authorized_capital")]
        public string? AuthorizedCapital { get; set; }

        [Column("division")]
        public string? Division { get; set; }

        [Column("division_description")]
        public string? DivisionDescription { get; set; }

        [Column("proposed_conversion")]
        public string? ProposedConversion { get; set; }

        [Column("proposed_main_division_description")]
        public string? ProposedMainDivisionDescription { get; set; }

        [Column("application_grounds")]
        public string? ApplicationGrounds { get; set; }

        // Part 2 - Attachments
        [Column("attachment_approval_noc")]
        public string? AttachmentApprovalNoc { get; set; }

        [Column("attachment_assets_liabilities")]
        public string? AttachmentAssetsLiabilities { get; set; }

        [Column("attachment_board_resolution")]
        public string? AttachmentBoardResolution { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }

        // Part 2 - Text/Number/Date Inputs
        [Column("authorized_person_name")]
        public string? AuthorizedPersonName { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("signitory")]
        public string? Signitory { get; set; }

        [Column("din_director")]
        public string? DinDirector { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        // Checkboxes
        [Column("declaration_compliance")]
        public bool DeclarationCompliance { get; set; }

        [Column("declaration_truthfulness")]
        public bool DeclarationTruthfulness { get; set; }

        [Column("declaration_moa_aoa")]
        public bool DeclarationMoaAoa { get; set; }

        [Column("professional_declaration_moa_aoa")]
        public bool ProfessionalDeclarationMoaAoa { get; set; }

        [Column("professional_declaration_compliance")]
        public bool ProfessionalDeclarationCompliance { get; set; }

        // Radio Groups
        [Column("professional_category")]
        public string? ProfessionalCategory { get; set; }

        [Column("whether_associate_fellow")]
        public string? WhetherAssociateFellow { get; set; }

        // Select Inputs
        [Column("designation")]
        public string? Designation { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        // Part 3 - Directors
        [Column("directors_number")]
        public string? DirectorsNumber { get; set; }

        [Column("first_din")]
        public string? FirstDin { get; set; }

        // First Director Details
        [Column("first_designation")]
        public string? FirstDesignation { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("first_company")]
        public string? FirstCompany { get; set; }

        // Second Director Details
        [Column("second_designation")]
        public string? SecondDesignation { get; set; }

        [Column("second_din")]
        public string? SecondDin { get; set; }

        [Column("second_name")]
        public string? SecondName { get; set; }

        [Column("second_company")]
        public string? SecondCompany { get; set; }

        // Key Managerial Personnel (KMP) Details
        [Column("managerial_key")]
        public string? ManagerialKey { get; set; }

        // Entrenchment Question
        [Column("articles_entrenched")]
        public string? ArticlesEntrenched { get; set; }  // e.g., "Y" or "N"

        [Column("no_of_articles")]
        public string? NoOfArticles { get; set; }

        // Estimation of Future Income and Expenditure (Year 1)
        [Column("period_year1")]
        public string PeriodYear1 { get; set; } = "Year 1";

        [Column("estimated_income_year1")]
        public string? EstimatedIncomeYear1 { get; set; }

        [Column("estimated_expenditure_year1")]
        public string? EstimatedExpenditureYear1 { get; set; }

        [Column("estimated_surplus_year1")]
        public string? EstimatedSurplusYear1 { get; set; }

        [Column("remarks_year1")]
        public string? RemarksYear1 { get; set; }

        // Estimation for Year 2
        [Column("period_year2")]
        public string PeriodYear2 { get; set; } = "Year 2";

        [Column("estimated_income_year2")]
        public string? EstimatedIncomeYear2 { get; set; }

        [Column("estimated_expenditure_year2")]
        public string? EstimatedExpenditureYear2 { get; set; }

        [Column("estimated_surplus_year2")]
        public string? EstimatedSurplusYear2 { get; set; }

        [Column("remarks_year2")]
        public string? RemarksYear2 { get; set; }

        // Estimation for Year 3
        [Column("period_year3")]
        public string PeriodYear3 { get; set; } = "Year 3";

        [Column("estimated_income_year3")]
        public string? EstimatedIncomeYear3 { get; set; }

        [Column("estimated_expenditure_year3")]
        public string? EstimatedExpenditureYear3 { get; set; }

        [Column("estimated_surplus_year3")]
        public string? EstimatedSurplusYear3 { get; set; }

        [Column("remarks_year3")]
        public string? RemarksYear3 { get; set; }

        // Resolution Meeting Details
        [Column("resolution_meeting_type")]
        public string? ResolutionMeetingType { get; set; } // e.g., "Board Meeting" or "General Meeting"

        [Column("date_of_passing")]
        public DateTime? DateOfPassing { get; set; }

        [Column("mode_of_resolution")]
        public string? ModeOfResolution { get; set; }

        [Column("votes_in_favour")]
        public string? VotesInFavour { get; set; }

        [Column("votes_against")]
        public string? VotesAgainst { get; set; }

        [Column("srn_mgt14")]
        public string? SrnMgt14 { get; set; }

    }

    [TableName("tbl_inc12", "vw_inc12")]
    public class INC12View : INC12
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}