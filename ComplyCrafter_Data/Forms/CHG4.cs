using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_chg4", "vw_chg4")]
    public class CHG4 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; } // Corporate Identity Number (CIN) or FCRN (Disabled)

        [Column("company_name")]
        public string? CompanyName { get; set; } // Name of the Company (Disabled)

        [Column("company_address")]
        public string? CompanyAddress { get; set; } // Address of the registered office (Disabled)

        [Column("company_email")]
        public string? CompanyEmail { get; set; } // E-mail ID of the company (Disabled)

        [Column("satisfaction_date")]
        public DateTime? SatisfactionDate { get; set; } // Date of satisfaction of charge in full

        [Column("charge_creation_number")]
        public string? ChargeCreationNumber { get; set; } // Charge creation identification (ID) number

        [Column("rca_user")]
        public string? RcaUser { get; set; } // MCA User (Select User)

        // Satisfaction date related fields
        [Column("is_valid_satisfaction_date")]
        public string? IsValidSatisfactionDate { get; set; } // Beyond 30 days but within 300 days (Radio button - Yes/No)

        [Column("reason_of_delay")]
        public string? ReasonOfDelay { get; set; } // If yes, reason for delay (Text input)

        [Column("required_application")]
        public string? RequiredApplication { get; set; } // Beyond 300 days, application required (Radio button - Yes/No)

        [Column("is_company")]
        public string? IsCompany { get; set; } // Whether the applicant is a Company or Chargeholder (Radio button)

        [Column("is_satisfied_charge")]
        public string? IsSatisfiedCharge { get; set; } // Whether the charge is satisfied in favor of asset reconstruction company or assignee (Radio button)

        // Chargeholder related fields
        [Column("chg_holder_name")]
        public string? ChgHolderName { get; set; } // Name of the charge holder

        [Column("other_cin")]
        public string? OtherCin { get; set; } // CIN (if applicable) for others

        [Column("chg_name")]
        public string? ChgName { get; set; } // Name of the individual (chargeholder)

        [Column("chg_email")]
        public string? ChgEmail { get; set; } // Email of the chargeholder

        [Column("chg_address")]
        public string? ChgAddress { get; set; } // Address of the chargeholder

        // Charge details
        [Column("charge_creation_date")]
        public DateTime? ChargeCreationDate { get; set; } // Charge creation date

        [Column("last_modified_date")]
        public DateTime? LastModifiedDate { get; set; } // Charge last modified date (if applicable)

        [Column("secured_amount")]
        public decimal? SecuredAmount { get; set; } // Final amount secured (in INR)

        [Column("secured_amount_in_words")]
        public string? SecuredAmountInWords { get; set; } // Amount secured by the charge in words

        [Column("foreign_currency")]
        public string? ForeignCurrency { get; set; } // In case amount secured is in foreign currency, mention details



        // Declaration
        [Column("authorised")]
        public Boolean? Authorised { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("declaration_date")]
        public DateTime? DeclarationDate { get; set; }

        [Column("chk_declaration")]
        public Boolean? ChkDeclaration { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("manager_pan")]
        public string? ManagerPan { get; set; }

        [Column("declaration")]
        public Boolean? Declaration { get; set; }

        [Column("tax_declaration")]
        public Boolean? TaxDeclaration { get; set; }

        [Column("pan_charge_holder")]
        public string? PanChargeHolder { get; set; }

        [Column("pan_assignee")]
        public string? PanAssignee { get; set; }

        [Column("signed_by_designation")]
        public string? SignedByDesignation { get; set; }

        [Column("signed_by_pan")]
        public string? SignedByPan { get; set; }

        [Column("signed_by_email_id")]
        public string? SignedByEmailId { get; set; }

        [Column("modification_charge")]
        public string? ModificationCharge { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("professional_flag")]
        public string? ProfessionalFlag { get; set; }

        [Column("company_secretary")]
        public string? CompanySecretary { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        //Part3
        [Column("instrument_creating")]
        public string? InstrumentCreating { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }
    }

    [TableName("tbl_chg4", "vw_chg4")]
    public class CHG4View : CHG4
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}