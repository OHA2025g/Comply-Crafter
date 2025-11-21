--
-- PostgreSQL database dump
--

-- Dumped from database version 16.0
-- Dumped by pg_dump version 17.1

-- Started on 2025-04-12 16:42:05
CREATE DATABASE comply_crafter

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 434 (class 1259 OID 230304)
-- Name: tbl_action_address_change; Type: TABLE; Schema: public; Owner: postgres
--


CREATE TABLE public.tbl_action_address_change (
    id integer NOT NULL,
    company_id integer NOT NULL,
    category character varying,
    effective_date date,
    existing_address text,
    new_office_line1 text,
    new_office_line2 text,
    new_office_city character varying,
    new_office_state character varying,
    new_office_district character varying,
    new_office_country character varying,
    new_office_pincode character varying,
    registered_office_premises text,
    proposed_roc character varying,
    police_station_name character varying,
    police_station_address_line1 text,
    police_station_address_line2 text,
    police_station_city character varying,
    police_station_state character varying,
    police_station_pincode character varying,
    utility_services_bill text,
    meeting_type character varying,
    incorporate_agenda text,
    general_meeting_date date,
    general_meeting_time character varying,
    existing_agm text,
    existing_egm text,
    incorporate_bm text,
    board_meeting_date date,
    board_meeting_time character varying,
    existing_bm text,
    authorized_signatory character varying,
    director_name character varying,
    director_din character varying,
    director_designation character varying,
    resolution_number character varying,
    resolution_date date,
    professional_category character varying,
    professional_name character varying,
    membership_number character varying,
    practice_number character varying,
    associate_fellow character varying,
    is_active boolean,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_by integer,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_action_address_change OWNER TO postgres;

--
-- TOC entry 433 (class 1259 OID 230303)
-- Name: tbl_action_address_change_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_action_address_change_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_action_address_change_id_seq OWNER TO postgres;

--
-- TOC entry 6156 (class 0 OID 0)
-- Dependencies: 433
-- Name: tbl_action_address_change_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_action_address_change_id_seq OWNED BY public.tbl_action_address_change.id;


--
-- TOC entry 473 (class 1259 OID 231923)
-- Name: tbl_action_director_appointment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_action_director_appointment (
    id integer NOT NULL,
    company_id integer NOT NULL,
    cin text,
    company_name text,
    category text,
    sub_category text,
    appointee_type text,
    bank_name text,
    nom_auth_sign text,
    nom_auth_desi text,
    nom_auth_din_pan text,
    nom_auth_date timestamp without time zone,
    nom_auth_place text,
    type_meeting text,
    exist_meeting text,
    existing_meeting text,
    meeting_date timestamp without time zone,
    timing text,
    circular_res_date timestamp without time zone,
    chairman text,
    which_meeting text,
    exist_meeting_agm text,
    m_id_agm text,
    m_id_egm text,
    meeting_date_agm timestamp without time zone,
    timing_agm text,
    din text,
    appointee_name text,
    f_name text,
    gender text,
    dob timestamp without time zone,
    address text,
    email text,
    mobile text,
    pan text,
    nationality text,
    occupation text,
    date_appointment timestamp without time zone,
    date_consent timestamp without time zone,
    place_consent text,
    issecurity_clear text,
    ismem_institute text,
    institue_name text,
    membership_no numeric,
    practice_no numeric,
    date_of_signing timestamp without time zone,
    place_of_consent text,
    date_of_signing_consent timestamp without time zone,
    place_of_consent_consent text,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean
);


ALTER TABLE public.tbl_action_director_appointment OWNER TO postgres;

--
-- TOC entry 468 (class 1259 OID 231273)
-- Name: tbl_action_general; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_action_general (
    id integer NOT NULL,
    company_id integer,
    category character varying,
    content text,
    is_active boolean,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_by integer,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_action_general OWNER TO postgres;

--
-- TOC entry 467 (class 1259 OID 231272)
-- Name: tbl_action_general_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_action_general_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_action_general_id_seq OWNER TO postgres;

--
-- TOC entry 6159 (class 0 OID 0)
-- Dependencies: 467
-- Name: tbl_action_general_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_action_general_id_seq OWNED BY public.tbl_action_general.id;


--
-- TOC entry 417 (class 1259 OID 223669)
-- Name: tbl_adt1; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_adt1 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    falling_section text,
    appointment_nature text,
    is_auditor_appointed text,
    auditor_number numeric,
    annual_general_meeting text,
    agm_date timestamp without time zone,
    appointment_date timestamp without time zone,
    is_casual_vacancy text,
    sr_no_of_relevant_form text,
    person_vacated text,
    vacancy_date timestamp without time zone,
    casual_vacancy_reasons text,
    membership_number numeric,
    auditor_serial boolean,
    auditor_member_no text,
    resolution_number text,
    resolution_date timestamp without time zone,
    signed_by text,
    designation text,
    din text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_adt1 OWNER TO postgres;

--
-- TOC entry 416 (class 1259 OID 223668)
-- Name: tbl_adt1_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_adt1_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_adt1_id_seq OWNER TO postgres;

--
-- TOC entry 6161 (class 0 OID 0)
-- Dependencies: 416
-- Name: tbl_adt1_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_adt1_id_seq OWNED BY public.tbl_adt1.id;


--
-- TOC entry 420 (class 1259 OID 223745)
-- Name: tbl_adt3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_adt3 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    auditor text,
    category text,
    reason text,
    resignation_place text,
    other_reason text,
    letter_date timestamp without time zone,
    effective_date timestamp without time zone,
    place_disqualified text,
    relative_name text,
    relation text,
    intimation_date timestamp without time zone,
    place text,
    auditor_category text,
    pan text,
    auditor_name text,
    membership text,
    auditor_address text,
    city text,
    state text,
    pin_code integer,
    auditor_email text,
    appointment_date timestamp without time zone,
    resignation_date timestamp without time zone,
    resignation_reasons text,
    designation text,
    fellow_associate text,
    membership_number numeric,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_adt3 OWNER TO postgres;

--
-- TOC entry 419 (class 1259 OID 223744)
-- Name: tbl_adt3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_adt3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_adt3_id_seq OWNER TO postgres;

--
-- TOC entry 6162 (class 0 OID 0)
-- Dependencies: 419
-- Name: tbl_adt3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_adt3_id_seq OWNED BY public.tbl_adt3.id;


--
-- TOC entry 465 (class 1259 OID 230913)
-- Name: tbl_aoc4; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_aoc4 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    authorised_capital text,
    members_number numeric DEFAULT 0,
    from_year_start_date timestamp without time zone,
    to_year_end_date timestamp without time zone,
    approved_date timestamp without time zone,
    statement_nature text,
    provisional_financial_statement text,
    adopted_agm text,
    nature_revision text,
    financial_date timestamp without time zone,
    srn_inc_28 text,
    srn_aoc_4 text,
    is_general_meeting_held text,
    agm_date timestamp without time zone,
    agm_due_date timestamp without time zone,
    is_agm_granted text,
    due_date_of_agm timestamp without time zone,
    is_financial_statement_signer_selected1 boolean,
    is_financial_statement_signer_selected2 boolean,
    date_of_signing1 timestamp without time zone,
    date_of_signing2 timestamp without time zone,
    report_referred_date timestamp without time zone,
    is_board_report_signer_selected1 boolean,
    is_board_report_signer_selected2 boolean,
    board_report_signing_date1 timestamp without time zone,
    board_report_signing_date2 timestamp without time zone,
    auditor_signing_report_date timestamp without time zone,
    is_subsidiary_company text,
    has_subsidiary_companies text,
    subsidiary_provision text,
    is_auditor_selected boolean,
    auditor_member_no text,
    srn_adt1 text,
    is_schedule3_applicable text,
    industry_type text,
    are_consolidated_financials_required text,
    maintains_electronic_books text,
    server_address_line1 text,
    server_address_line2 text,
    city text,
    state text,
    district text,
    country text,
    pin_code_address numeric,
    phone_number numeric,
    service_provider_name text,
    service_provider_ip text,
    service_provider_location text,
    books_on_cloud text,
    service_provider_address text,
    tangible_assets_current numeric,
    tangible_assets_previous numeric,
    intangible_assets_current numeric,
    current_reporting_period text,
    previous_reporting_period text,
    share_capital_current numeric,
    share_capital_previous numeric,
    reserves_and_surplus_current numeric,
    reserves_and_surplus_previous numeric,
    money_against_share_warrants_current numeric,
    money_against_share_warrants_previous numeric,
    share_application_money_pending_allotment_current numeric,
    share_application_money_pending_allotment_previous numeric,
    long_term_borrowings_current numeric,
    long_term_borrowings_previous numeric,
    deferred_tax_liabilities_current numeric,
    deferred_tax_liabilities_previous numeric,
    other_long_term_liabilities_current numeric,
    other_long_term_liabilities_previous numeric,
    long_term_provisions_current numeric,
    long_term_provisions_previous numeric,
    short_term_borrowings_current numeric,
    short_term_borrowings_previous numeric,
    trade_payables_current numeric,
    trade_payables_previous numeric,
    other_current_liabilities_current numeric,
    other_current_liabilities_previous numeric,
    short_term_provisions_current numeric,
    short_term_provisions_previous numeric,
    total_equity_and_liabilities_current numeric,
    total_equity_and_liabilities_previous numeric,
    intangible_assets_previous numeric,
    capital_work_in_progress_current numeric,
    capital_work_in_progress_previous numeric,
    intangible_assets_under_development_current numeric,
    intangible_assets_under_development_previous numeric,
    non_current_investments_current numeric,
    non_current_investments_previous numeric,
    deferred_tax_assets_current numeric,
    deferred_tax_assets_previous numeric,
    long_term_loans_and_advances_current numeric,
    long_term_loans_and_advances_previous numeric,
    other_non_current_assets_current numeric,
    other_non_current_assets_previous numeric,
    current_investments_current numeric,
    current_investments_previous numeric,
    inventories_current numeric,
    inventories_previous numeric,
    trade_receivables_current numeric,
    trade_receivables_previous numeric,
    cash_and_equivalents_current numeric,
    cash_and_equivalents_previous numeric,
    short_term_loans_and_advances_current numeric,
    short_term_loans_and_advances_previous numeric,
    other_current_assets_current numeric,
    other_current_assets_previous numeric,
    total_assets_current numeric,
    total_assets_previous numeric,
    starting_date_current timestamp without time zone,
    closing_date_current timestamp without time zone,
    sales_goods_manufactured_current numeric,
    sales_goods_traded_current numeric,
    sales_supply_services_current numeric,
    export_sales_goods_manufactured_current numeric,
    export_sales_goods_traded_current numeric,
    export_sales_supply_services_current numeric,
    other_income_current numeric,
    total_revenue_current numeric,
    cost_material_consumed_current numeric,
    purchases_stock_trade_current numeric,
    changes_inventories_finished_goods_current numeric,
    changes_inventories_work_in_progress_current numeric,
    changes_inventories_stock_trade_current numeric,
    employee_benefit_expense_current numeric,
    managerial_remuneration_current numeric,
    payment_to_auditors_current numeric,
    insurance_expenses_current numeric,
    power_and_fuel_current numeric,
    finance_cost_current numeric,
    depreciation_amortisation_current numeric,
    other_expenses_current numeric,
    total_expenses_current numeric,
    profit_before_exceptional_items_current numeric,
    exceptional_items_current numeric,
    profit_before_extraordinary_items_current numeric,
    extraordinary_items_current numeric,
    profit_before_tax_current numeric,
    current_tax_current numeric,
    deferred_tax_current numeric,
    profit_loss_continuing_operations_current numeric,
    profit_loss_discontinuing_operations_current numeric,
    tax_expense_discontinuing_operations_current numeric,
    profit_loss_discontinuing_after_tax_current numeric,
    total_profit_loss_current numeric,
    basic_eps_before_extraordinary_items_current numeric,
    diluted_eps_before_extraordinary_items_current numeric,
    basic_eps_after_extraordinary_items_current numeric,
    diluted_eps_after_extraordinary_items_current numeric,
    starting_date_previous timestamp without time zone,
    closing_date_previous timestamp without time zone,
    sales_goods_manufactured_previous numeric,
    sales_goods_traded_previous numeric,
    sales_supply_services_previous numeric,
    export_sales_goods_manufactured_previous numeric,
    export_sales_goods_traded_previous numeric,
    export_sales_supply_services_previous numeric,
    other_income_previous numeric,
    total_revenue_previous numeric,
    cost_material_consumed_previous numeric,
    purchases_stock_trade_previous numeric,
    changes_inventories_finished_goods_previous numeric,
    changes_inventories_work_in_progress_previous numeric,
    changes_inventories_stock_trade_previous numeric,
    employee_benefit_expense_previous numeric,
    managerial_remuneration_previous numeric,
    payment_to_auditors_previous numeric,
    insurance_expenses_previous numeric,
    power_and_fuel_previous numeric,
    finance_cost_previous numeric,
    depreciation_amortisation_previous numeric,
    other_expenses_previous numeric,
    total_expenses_previous numeric,
    profit_before_exceptional_items_previous numeric,
    exceptional_items_previous numeric,
    profit_before_extraordinary_items_previous numeric,
    extraordinary_items_previous numeric,
    profit_before_tax_previous numeric,
    current_tax_previous numeric,
    deferred_tax_previous numeric,
    profit_loss_continuing_operations_previous numeric,
    profit_loss_discontinuing_operations_previous numeric,
    tax_expense_discontinuing_operations_previous numeric,
    profit_loss_discontinuing_after_tax_previous numeric,
    total_profit_loss_previous numeric,
    basic_eps_before_extraordinary_items_previous numeric,
    diluted_eps_before_extraordinary_items_previous numeric,
    basic_eps_after_extraordinary_items_previous numeric,
    diluted_eps_after_extraordinary_items_previous numeric,
    public_iss_eqt numeric,
    public_iss_pre numeric,
    public_iss_total numeric,
    bonus_iss_eqt numeric,
    bonus_iss_pre numeric,
    bonus_iss_total numeric,
    right_iss_eqt numeric,
    right_iss_pre numeric,
    right_iss_total numeric,
    pri_plc_deb_pre1 numeric,
    pri_plc_deb_pre2 numeric,
    pri_plc_deb_pre_total numeric,
    other_plc_deb_pre1 numeric,
    other_plc_deb_pre2 numeric,
    other_plc_deb_pre_total numeric,
    pre_all_deb1 numeric,
    pre_all_deb2 numeric,
    pre_all_deb_total numeric,
    other_pre_all1 numeric,
    other_pre_all2 numeric,
    other_pre_all_total numeric,
    esop_eqt numeric,
    esop_pre numeric,
    esop_total numeric,
    other_eqt numeric,
    other_pre numeric,
    other_total numeric,
    total_amt_eqt numeric,
    total_amt_pre numeric,
    total_amt_total numeric,
    amt_issue_all numeric,
    app_money_given numeric,
    share_app_mom_give numeric,
    app_money_rec numeric,
    app_money_refund numeric,
    paid_up_cap numeric,
    paid_up_cap_per numeric,
    paid_up_cap_fore numeric,
    paid_up_cap_fore_per numeric,
    bought_back_share numeric,
    deposits_accepted numeric,
    deposited_matured numeric,
    claimed_not_paid numeric,
    matured_not_claimed numeric,
    unclaimed_matured numeric,
    debenture_claimed numeric,
    interest_on_deposits numeric,
    unpaid_dividend numeric,
    invest_in_subsidiary numeric,
    invest_in_government numeric,
    capital_reserves numeric,
    investor_education numeric,
    inter_corporate numeric,
    gross_value numeric,
    grants_received numeric,
    unpaid_directors numeric,
    calls_unpaid numeric,
    forfeited_shares numeric,
    forfeited_shares_reissue numeric,
    foreign_institutional numeric,
    borrowing_foreign numeric,
    corporate_borrowing numeric,
    unsecured_borrowing numeric,
    commercial_paper numeric,
    warrents_conversion numeric,
    preference_warrants_convewrter numeric,
    debenture_warrants_convewrter numeric,
    reporting_period_warrents numeric,
    rupees_warrents_issued numeric,
    payment_short_term numeric,
    payment_long_term numeric,
    opr_lease_con_finleas text,
    financial_net_worth numeric,
    num_shareholder numeric,
    secured_loan numeric,
    gross_fix_ass numeric,
    deprec numeric,
    mis_exp numeric,
    unhedged_fore_ex numeric,
    bonds_deb_cr numeric,
    bonds_deb_pr numeric,
    bank_loans_cr numeric,
    bank_loans_pr numeric,
    other_loan_cr numeric,
    other_loan_pr numeric,
    deferred_lib_cr numeric,
    deferred_lib_pr numeric,
    deposits_cr numeric,
    deposits_pr numeric,
    loan_from_rp_cr numeric,
    loan_from_rp_pr numeric,
    financial_lease_cr numeric,
    financial_lease_pr numeric,
    other_advances_cr numeric,
    other_advances_pr numeric,
    total_l_borring_cr numeric,
    total_l_borring_pr numeric,
    aggregate_amt_cr numeric,
    aggregate_amt_pr numeric,
    other_loan_cr_short numeric,
    other_loan_pr_short numeric,
    loans_advances_cr numeric,
    loans_advances_pr numeric,
    deposits_cr_short numeric,
    deposits_pr_short numeric,
    other_advance_loan_cr numeric,
    other_advance_loan_pr numeric,
    total_borrowing_cr numeric,
    total_borrowing_pr numeric,
    aggregate_amount_cr numeric,
    aggregate_amount_pr numeric,
    unsecured_cap_ad_cr numeric,
    unsecured_cap_ad_pr numeric,
    doubt_cap_ad_cr numeric,
    doubt_cap_ad_pr numeric,
    un_security_dep_cr numeric,
    un_security_dep_pr numeric,
    dt_security_dep_cr numeric,
    dt_security_dep_pr numeric,
    un_rp_loan_cr numeric,
    un_rp_loan_pr numeric,
    dt_rp_loan_cr numeric,
    dt_rp_loan_pr numeric,
    un_other_loan_cr numeric,
    un_other_loan_pr numeric,
    dt_other_loan_cr numeric,
    dt_other_loan_pr numeric,
    un_total_cr numeric,
    un_total_pr numeric,
    dt_total_cr numeric,
    dt_total_pr numeric,
    un_rp_baddebt_cr numeric,
    un_rp_baddebt_pr numeric,
    dt_rp_baddebt_cr numeric,
    dt_rp_baddebt_pr numeric,
    un_other_baddebt_cr numeric,
    un_other_baddebt_pr numeric,
    dt_other_baddebt_cr numeric,
    dt_other_baddebt_pr numeric,
    un_net_loan_cr numeric,
    un_net_loan_pr numeric,
    dt_net_loan_cr numeric,
    dt_net_loan_pr numeric,
    un_due_loan_cr numeric,
    un_due_loan_pr numeric,
    dt_due_loan_cr numeric,
    dt_due_loan_pr numeric,
    consider_good_ces numeric,
    consider_good_cws numeric,
    consider_good_pes numeric,
    consider_good_pws numeric,
    unsecured_con_ces numeric,
    unsecured_con_cws numeric,
    unsecured_con_pes numeric,
    unsecured_con_pws numeric,
    doubtful_ces numeric,
    doubtful_cws numeric,
    doubtful_pes numeric,
    doubtful_pws numeric,
    trade_receivables_ces numeric,
    trade_receivables_cws numeric,
    trade_receivables_pes numeric,
    trade_receivables_pws numeric,
    doubtful_debts_ces numeric,
    doubtful_debts_cws numeric,
    doubtful_debts_pes numeric,
    doubtful_debts_pws numeric,
    net_trade_ces numeric,
    net_trade_cws numeric,
    net_trade_pes numeric,
    net_trade_pws numeric,
    other_officers_ces numeric,
    other_officers_cws numeric,
    other_officers_pes numeric,
    other_officers_pws numeric,
    exports_goods_cr numeric,
    int_div_cr numeric,
    royalty_cr numeric,
    know_how_cr numeric,
    pro_con_cr numeric,
    other_in_cr numeric,
    total_earn_cr numeric,
    exports_goods_pr numeric,
    int_div_pr numeric,
    royalty_pr numeric,
    know_how_pr numeric,
    pro_con_pr numeric,
    other_in_pr numeric,
    total_earn_pr numeric,
    raw_mat_cr numeric,
    raw_mat_pr numeric,
    com_sap_cr numeric,
    com_sap_pr numeric,
    cap_goods_cr numeric,
    cap_goods_pr numeric,
    exp_royality_cr numeric,
    exp_royality_pr numeric,
    exp_know_cr numeric,
    exp_know_pr numeric,
    exp_pro_cr numeric,
    exp_pro_pr numeric,
    exp_int_cr numeric,
    exp_int_pr numeric,
    other_mat_cr numeric,
    other_mat_pr numeric,
    did_paid_cr numeric,
    did_paid_pr numeric,
    total_exp_cr numeric,
    total_exp_pr numeric,
    pro_did_rup numeric,
    pro_did_per numeric,
    earn_basic_share numeric,
    earn_diluted_share numeric,
    income_in_fc numeric,
    exp_in_fc numeric,
    revenue_rec numeric,
    rent_paid numeric,
    consup_str_sp numeric,
    gross_val_trans numeric,
    bad_debts numeric,
    is_csr_applicable text,
    turnover numeric,
    net_worth numeric,
    first_financial_year_ended numeric,
    second_financial_year_ended numeric,
    third_financial_year_ended numeric,
    first_year_profit_before_tax numeric,
    second_year_profit_before_tax numeric,
    third_year_profit_before_tax numeric,
    first_year_computed_net_profit numeric,
    second_year_computed_net_profit numeric,
    third_year_computed_net_profit numeric,
    average_net_profit numeric,
    prescribed_csr_expenditure numeric,
    total_csr_spending numeric,
    local_area_spending numeric,
    details_of_implenting_agency text,
    explanation_for_not_spending text,
    other_explaination_reason text,
    responsibility_statement_of_csr text,
    cost_record_maintain text,
    central_excise_tariff text,
    cost_record_sn1 text,
    centralexcisetariff2 text,
    is_cag_commented text,
    has_auditor_remarks text,
    is_caro_applicable text,
    caro_fixed_assets text,
    caro_inventories text,
    caro_loans_given text,
    caro_public_deposits text,
    caro_cost_records text,
    caro_statutory_dues text,
    caro_term_loans text,
    caro_fraud_noticed text,
    caro_other_remarks text,
    is_secretarial_audit_applicable text,
    has_director_report_disclosures text,
    resolution_number text,
    resolution_date text,
    signatory_name text,
    signatory_designation text,
    din_pan_number text,
    certified_by text,
    certifying_professional text,
    professional_type text,
    membership_number text,
    practice_certificate_number text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_aoc4 OWNER TO postgres;

--
-- TOC entry 464 (class 1259 OID 230912)
-- Name: tbl_aoc4_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_aoc4_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_aoc4_id_seq OWNER TO postgres;

--
-- TOC entry 6163 (class 0 OID 0)
-- Dependencies: 464
-- Name: tbl_aoc4_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_aoc4_id_seq OWNED BY public.tbl_aoc4.id;


--
-- TOC entry 457 (class 1259 OID 230647)
-- Name: tbl_aoc4cfs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_aoc4cfs (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    aoc4_srn text,
    financial_year_starting_date timestamp without time zone,
    financial_year_ending_date timestamp without time zone,
    board_meeting_date timestamp without time zone,
    section134_approval_date timestamp without time zone,
    director1_signed boolean,
    director1_signing_date timestamp without time zone,
    director2_signed boolean,
    director2_signing_date timestamp without time zone,
    board_director1_signed boolean,
    board_director1_signing_date timestamp without time zone,
    board_director2_signed boolean,
    board_director2_signing_date timestamp without time zone,
    auditor_signing_date timestamp without time zone,
    first_auditor_serial boolean,
    first_auditor_member_no text,
    first_auditor_srn text,
    second_auditor_serial boolean,
    second_auditor_member_no text,
    second_auditor_srn text,
    has_subsidiary text,
    associate_or_venture text,
    industries_type text,
    schedule_applicable text,
    has_cag_comments text,
    has_cag_supplementary_audit text,
    has_auditor_remarks text,
    is_caro_applicable text,
    fixed_assets text,
    inventories text,
    loans_given text,
    public_deposits text,
    cost_records text,
    statutory_dues text,
    term_loans text,
    fraud_noticed text,
    other_comments text,
    is_secretarial_audit_applicable text,
    has_detailed_disclosures text,
    resolution_number numeric,
    resolution_date timestamp without time zone,
    signatory_id text,
    signatory_designation text,
    signatory_din_pan text,
    certified_by text,
    name_of_pcs text,
    associate_or_fellow text,
    memb_number text,
    cert_practice_no text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_aoc4cfs OWNER TO postgres;

--
-- TOC entry 456 (class 1259 OID 230646)
-- Name: tbl_aoc4cfs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_aoc4cfs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_aoc4cfs_id_seq OWNER TO postgres;

--
-- TOC entry 6164 (class 0 OID 0)
-- Dependencies: 456
-- Name: tbl_aoc4cfs_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_aoc4cfs_id_seq OWNED BY public.tbl_aoc4cfs.id;


--
-- TOC entry 353 (class 1259 OID 221564)
-- Name: tbl_aoc5; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_aoc5 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    decision_date timestamp without time zone,
    line_address1 text,
    line_address2 text,
    longitude text,
    latitude text,
    country text,
    pin_code text,
    locality_area text,
    city text,
    district text,
    ut_state text,
    police_station_name text,
    line_address3 text,
    line_address4 text,
    country2 text,
    pin_code2 text,
    locality_area2 text,
    city2 text,
    district2 text,
    ut_state2 text,
    address_proof text,
    bills_copy text,
    register_office_photo text,
    attachment_file text,
    comp_vide_resolution text,
    date_declaration timestamp without time zone,
    designation text,
    signatory text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_aoc5 OWNER TO postgres;

--
-- TOC entry 352 (class 1259 OID 221563)
-- Name: tbl_aoc5_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_aoc5_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_aoc5_id_seq OWNER TO postgres;

--
-- TOC entry 6165 (class 0 OID 0)
-- Dependencies: 352
-- Name: tbl_aoc5_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_aoc5_id_seq OWNED BY public.tbl_aoc5.id;


--
-- TOC entry 384 (class 1259 OID 222376)
-- Name: tbl_aoccuntnsolvencyform; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_aoccuntnsolvencyform (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    purpose text,
    statement_of_account_date timestamp without time zone,
    llpin_fllp_in timestamp without time zone,
    statement_of_asests_and_liabilities_at timestamp without time zone,
    llp_fllp_name text,
    jurisdiction_police_station text,
    contribution_total text,
    llp_fllp_enquiry_confirmation boolean,
    llp_fllp_name_2 text,
    llp_fllp_pay_debts text,
    append_statement boolean,
    statement_of_assets_and_liabilities_at text,
    income_and_expenditure_ended_on timestamp without time zone,
    confirmation_on_filing text,
    declare_turnover boolean,
    turnover text,
    declare_obligation_of_contribution boolean,
    obligation_of_contribution text,
    confirming_partners boolean,
    confirming_the_statement_is_true boolean,
    contingent_liabilities_radio_btn text,
    description_of_contingent_liability text,
    amount text,
    confirmation_on_filling boolean,
    description_of_contigent_liability text,
    contingent_liabilites_radio_btn text,
    statement_assets_liabilities text,
    contribution_received_cr text,
    contribution_received_pr text,
    reserves_surplus_cr text,
    reserves_surplus_pr text,
    secured_loans_cr text,
    secured_loans_pr text,
    unsecure_loans_cr text,
    unsecure_loans_pr text,
    short_term_cr text,
    short_term_pr text,
    payables_advance_cr text,
    payables_advance_pr text,
    other_liabilities_name_cr text,
    other_liabilities_cr text,
    other_liabilities_pr text,
    for_taxation_cr text,
    for_taxation_pr text,
    for_contingencies_cr text,
    for_contingencies_pr text,
    for_insurance_cr text,
    for_insurance_pr text,
    other_provisions_cr text,
    other_provisions_pr text,
    total_cr text,
    total_pr text,
    fixed_assets_cr text,
    fixed_assets_pr text,
    depreciation_cr text,
    depreciation_pr text,
    net_fixed_assets_cr text,
    net_fixed_assets_pr text,
    investments_cr text,
    investments_pr text,
    loans_cr text,
    loans_pr text,
    inventories_cr text,
    inventories_pr text,
    trade_receivables_cr text,
    trade_receivables_pr text,
    cash_equivalents_cr text,
    cash_equivalents_pr text,
    other_assets_cr text,
    other_assets_pr text,
    total_assets_cr text,
    total_assets_pr text,
    other_assets_name_cr text,
    starting_date_cr timestamp without time zone,
    starting_date_pr timestamp without time zone,
    closing_date_cr timestamp without time zone,
    closing_date_pr timestamp without time zone,
    gross_turnover_cr text,
    gross_turnover_pr text,
    excise_duty_cr text,
    excise_duty_pr text,
    net_turnover_cr text,
    net_turnover_pr text,
    sales_good_cr text,
    sales_good_pr text,
    sales_goods_t_cr text,
    sales_goods_t_pr text,
    sales_supply_cr text,
    sales_supply_pr text,
    sales_goods_1_cr text,
    sales_goods_1_pr text,
    sale_goods_t_1_cr text,
    sale_goods_t_1_pr text,
    sales_supply_1_cr text,
    sales_supply_1_pr text,
    other_income_cr text,
    other_income_pr text,
    increase_cr text,
    increase_pr text,
    total_revenue_cr text,
    total_revenue_pr text,
    material_cr text,
    material_pr text,
    purchase_made_c text,
    purchase_made_p text,
    consumption_cr text,
    consumption_pr text,
    power_cr text,
    power_pr text,
    personnel_cr text,
    personnel_pr text,
    administrative_cr text,
    administrative_pr text,
    payment_cr text,
    payment_pr text,
    selling_c text,
    selling_p text,
    insurance_exp_cr text,
    insurance_exp_pr text,
    depreciation_p_cr text,
    depreciation_p_pr text,
    interest_cr text,
    interest_pr text,
    other_expenses_c text,
    other_expenses_p text,
    total_expenses_c text,
    total_expenses_p text,
    profit_net_cr text,
    profit_net_pr text,
    provision_c text,
    provision_p text,
    profit_aft_tax_c text,
    profit_aft_tax_p text,
    profit_transfer_cr text,
    profit_transfer_pr text,
    prof_tra_res_ser_c text,
    prof_tra_res_ser_p text,
    dpin_income_tax_pan_11 text,
    dpin_income_tax_pan_12 text,
    administrator_name text,
    designation text,
    administrator_id text,
    certified_radio_button text,
    number_membership text,
    designated_name text,
    address_line_1 text,
    address_line_2 text,
    country text,
    pin_code_1 text,
    area_locality_1 text,
    city_1 text,
    district_1 text,
    state_1 text,
    jurisdiction text,
    phone text,
    email_id text,
    certificate_name text,
    category_radio_buttons text,
    name_of_pcs text,
    professional_type text,
    certificate_of_practice_number text,
    attachment_file text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_aoccuntnsolvencyform OWNER TO postgres;

--
-- TOC entry 383 (class 1259 OID 222375)
-- Name: tbl_aoccuntnsolvencyform_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_aoccuntnsolvencyform_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_aoccuntnsolvencyform_id_seq OWNER TO postgres;

--
-- TOC entry 6166 (class 0 OID 0)
-- Dependencies: 383
-- Name: tbl_aoccuntnsolvencyform_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_aoccuntnsolvencyform_id_seq OWNED BY public.tbl_aoccuntnsolvencyform.id;


--
-- TOC entry 232 (class 1259 OID 163725)
-- Name: tbl_api_log; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_api_log (
    id integer NOT NULL,
    url character varying,
    input text,
    output text,
    method character varying,
    created_on timestamp without time zone
);


ALTER TABLE public.tbl_api_log OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 163724)
-- Name: tbl_api_log_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_api_log_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_api_log_id_seq OWNER TO postgres;

--
-- TOC entry 6167 (class 0 OID 0)
-- Dependencies: 231
-- Name: tbl_api_log_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_api_log_id_seq OWNED BY public.tbl_api_log.id;


--
-- TOC entry 243 (class 1259 OID 180242)
-- Name: tbl_auditor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_auditor (
    id integer NOT NULL,
    category character varying,
    frn character varying,
    firm_name character varying,
    pan character varying,
    firm_email character varying,
    address character varying,
    country character varying,
    state character varying,
    city character varying,
    pincode character varying,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean
);


ALTER TABLE public.tbl_auditor OWNER TO postgres;

--
-- TOC entry 242 (class 1259 OID 180241)
-- Name: tbl_auditor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_auditor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_auditor_id_seq OWNER TO postgres;

--
-- TOC entry 6168 (class 0 OID 0)
-- Dependencies: 242
-- Name: tbl_auditor_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_auditor_id_seq OWNED BY public.tbl_auditor.id;


--
-- TOC entry 245 (class 1259 OID 180251)
-- Name: tbl_auditor_partner; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_auditor_partner (
    id integer NOT NULL,
    auditor integer,
    member_no character varying,
    name character varying,
    mobile character varying,
    email character varying,
    designation character varying
);


ALTER TABLE public.tbl_auditor_partner OWNER TO postgres;

--
-- TOC entry 244 (class 1259 OID 180250)
-- Name: tbl_auditor_partner_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_auditor_partner_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_auditor_partner_id_seq OWNER TO postgres;

--
-- TOC entry 6169 (class 0 OID 0)
-- Dependencies: 244
-- Name: tbl_auditor_partner_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_auditor_partner_id_seq OWNED BY public.tbl_auditor_partner.id;


--
-- TOC entry 344 (class 1259 OID 221456)
-- Name: tbl_ben2; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_ben2 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    reporting_company boolean,
    declaration_ownership boolean,
    change_ownership boolean,
    change_exiting boolean,
    change_reporting_company boolean,
    cin_holding_company integer,
    name_holding_company text,
    number_of_significant_owners integer,
    copy_attachment text,
    optional_attachment text,
    resolution_number integer,
    resolution_date timestamp without time zone,
    designation text,
    signitory text,
    din_pan text,
    category text,
    name_of_pcs text,
    associate_or_fellow text,
    membership_number integer,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_ben2 OWNER TO postgres;

--
-- TOC entry 343 (class 1259 OID 221455)
-- Name: tbl_ben2_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_ben2_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_ben2_id_seq OWNER TO postgres;

--
-- TOC entry 6170 (class 0 OID 0)
-- Dependencies: 343
-- Name: tbl_ben2_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_ben2_id_seq OWNED BY public.tbl_ben2.id;


--
-- TOC entry 460 (class 1259 OID 230765)
-- Name: tbl_boardreport; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_boardreport (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    financial_year text,
    amount_figure text,
    type_board_report text,
    agmnotice_date timestamp without time zone,
    date_agm timestamp without time zone,
    day_date timestamp without time zone,
    time_agm text,
    no_of_agm integer,
    paidup_capital text,
    no_of_board_meeting integer,
    board_meeting_sr_no text,
    board_meeting_date timestamp without time zone,
    board_strength1 integer NOT NULL,
    no_of_directors_present1 integer,
    board_meeting_sr_no2 text,
    board_meeting_date2 timestamp without time zone,
    board_strength2 integer,
    no_of_directors_present2 integer,
    numbers_of_board_meeting_during_year text,
    board_meeting_date3 timestamp without time zone,
    board_strength3 integer,
    no_of_directors_present3 integer,
    sr_no4 text,
    board_meeting_date4 timestamp without time zone,
    board_strength4 integer,
    no_of_directors_present4 numeric,
    sr_no5 text,
    board_meeting_date5 timestamp without time zone,
    board_strength5 integer,
    no_of_directors_present5 integer,
    sr_no6 text,
    board_meeting_date6 timestamp without time zone,
    board_strength6 integer,
    no_of_directors_present6 integer,
    no_of_general_meeting integer,
    number_of_meeting_during_year2 text,
    select_meeting_type text,
    general_meeting_date timestamp without time zone,
    general_strength_meeting integer,
    no_of_members_present integer,
    have_website text,
    website_name text,
    operation_revenue_cur text,
    operation_revenue_pre text,
    profit_before_cur text,
    profit_before_pre text,
    other_income_cur text,
    other_income_pre text,
    finance_charge_cur text,
    finance_charge_pre text,
    depreciation_cur text,
    depreciation_pre text,
    otherexp_cur text,
    otherexp_pre text,
    net_profit_before_cur text,
    net_profit_before_pre text,
    tax_expense_cur text,
    tax_expense_pre text,
    deffere_tax_expense_cur text,
    deffered_tax_expense_pre text,
    net_profit_cur text,
    net_profit_pre text,
    revenue_changes text,
    pbdit_changes text,
    pbt_changes text,
    pat_changes text,
    is_independ_director text,
    have_csr text,
    risk_management_policy text,
    no_of_committee_meeting integer,
    have_cas text,
    is_committee_of_director text,
    name_of_audit_firm text,
    date_appo_auditor timestamp without time zone,
    category text,
    firm_registration text,
    period_appointment text,
    effective_date_au timestamp without time zone,
    any_observation text,
    have_costaudit text,
    name_of_secretarial_auditor text,
    date_secretaria_auditor timestamp without time zone,
    any_observation_sect text,
    cost_secretaria_fees text,
    have_internalaudit text,
    name_of_internal_auditor text,
    date_internal_auditor timestamp without time zone,
    any_observation_int text,
    cost_internal_fees text,
    loan_invest text,
    no_of_party text,
    detail_loan_invest text,
    related_party_trans text,
    related_party_trans_matrial text,
    no_teno_of_related_party text,
    is_related_party_detail text,
    no_of_matarial integer,
    is_related_party_detailarms text,
    no_of_contracts integer,
    changes_nature text,
    tab_changes_nature text,
    changes_share text,
    authorised_capital text,
    no_of_authorized integer,
    share_issue text,
    no_of_share_issue text,
    buy_back text,
    no_of_buck_back text,
    data_box1 text,
    data_box2 text,
    data_boxs3 text,
    data_box4 text,
    sweet_equity text,
    no_of_sweet_equity text,
    value_sweet_equity text,
    total_sweet_equity text,
    bonus_share text,
    no_of_bonus_share text,
    value_bonus_share text,
    total_bonu_share text,
    esop_share text,
    no_of_esopshare text,
    value_esopshare text,
    total_esopshare text,
    shared_if_right text,
    no_of_shared_if_right text,
    value_shared_if_right text,
    total_shared_if_right text,
    amount_transfer_reserve text,
    no_of_transfer_reserve text,
    have_dividend text,
    reason_no_payment text,
    interim_dividend text,
    dividend_distribution_tax_interim text,
    data_board_interim text,
    data_board_interim_face_value text,
    data_board_interim_percent text,
    final_dividend text,
    dividend_distribution_tax_final text,
    board_dividend_share text,
    board_face_value_share text,
    board_percent_of_dividend text,
    transfer_dividend text,
    trans_dividend_amount text,
    have_changes text,
    no_of_events text,
    conserve_energy text,
    tech_absortion text,
    tech_absortion_step3 text,
    foreign_exchange text,
    foreign_exchange_income text,
    foreign_exchange_income_pre text,
    foreign_exchange_import text,
    foreign_exchange_import_pre text,
    foreign_exchange_pnterest text,
    foreign_exchange_interest_pre text,
    foreign_exchange_travel text,
    foreign_exchange_travel_pre text,
    foreign_exchange_other text,
    foreign_exchange_other_pre text,
    directors_kmp text,
    director_and_kmp_name text,
    designation text,
    select_type_of_change text,
    date_appointment_cessation timestamp without time zone,
    no_of_directors_kmp_rotation integer,
    deposits text,
    deposits_accept text,
    tab_deposits text,
    deposit_accept text,
    deposit_unpaid text,
    whether_default text,
    no_such_cases text,
    tamount_begining text,
    tmaount_during text,
    tamount_end text,
    details_deposits text,
    disclouser_related text,
    no_of_persons text,
    board_evalution text,
    info_about_subsidiary text,
    commen_ceoperations_subs text,
    liquidated_subs text,
    commen_ceoperations_jv text,
    liquidated_jv text,
    regulator_order text,
    tab_regulator_order text,
    have_vigil text,
    have_fraud text,
    have_adequacy text,
    adequacy_text_area text,
    sexual_rating text,
    complaints_received text,
    complaints_disposed text,
    complaints_pending text,
    complaints_unsolved text,
    have_manaperson text,
    name_appoint text,
    designation_app text,
    remuneraion text,
    credit_rating text,
    secretarial_standard text,
    detail_secretarial_standard text,
    any_cirp text,
    any_corporateaction text,
    any_topten text,
    annexure text,
    detail_any_topten text,
    dis_emp_name text,
    dis_designation text,
    dis_remuneration text,
    dis_nature text,
    dis_qualification text,
    dis_date_commence timestamp without time zone,
    dis_age text,
    dis_last_emp text,
    dis_percent_equity text,
    dis_nature_name text,
    any_diffvalution text,
    any_disclosure text,
    place_boardreport text,
    meeting_date timestamp without time zone,
    director_name1 text,
    director_din1 text,
    director_desigation1 text,
    director_name2 text,
    director_din2 text,
    director_desigation2 text,
    title text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_boardreport OWNER TO postgres;

--
-- TOC entry 459 (class 1259 OID 230764)
-- Name: tbl_boardreport_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_boardreport_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_boardreport_id_seq OWNER TO postgres;

--
-- TOC entry 6171 (class 0 OID 0)
-- Dependencies: 459
-- Name: tbl_boardreport_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_boardreport_id_seq OWNED BY public.tbl_boardreport.id;


--
-- TOC entry 450 (class 1259 OID 230586)
-- Name: tbl_cag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_cag (
    id integer NOT NULL,
    parent_id integer,
    cag_comments text,
    bod_reply text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_cag OWNER TO postgres;

--
-- TOC entry 449 (class 1259 OID 230585)
-- Name: tbl_cag_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_cag_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_cag_id_seq OWNER TO postgres;

--
-- TOC entry 6172 (class 0 OID 0)
-- Dependencies: 449
-- Name: tbl_cag_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_cag_id_seq OWNED BY public.tbl_cag.id;


--
-- TOC entry 368 (class 1259 OID 221877)
-- Name: tbl_capital; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_capital (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    type text,
    event_date timestamp without time zone,
    unclassified numeric,
    total_capital numeric,
    incorporate_agenda text,
    meeting_date timestamp without time zone,
    meeting_time text,
    existing_meeting text,
    authorized_signatory text,
    meeting_type text,
    incorporate_agenda_gm text,
    general_meeting_date timestamp without time zone,
    general_meeting_time text,
    existing_agm text,
    existing_egm text,
    aoa_clause text
);


ALTER TABLE public.tbl_capital OWNER TO postgres;

--
-- TOC entry 370 (class 1259 OID 221891)
-- Name: tbl_capital_child; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_capital_child (
    id integer NOT NULL,
    parent_id integer,
    child_type text,
    shares numeric,
    share_value numeric,
    total numeric,
    class text,
    sub_class text,
    rights text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_capital_child OWNER TO postgres;

--
-- TOC entry 369 (class 1259 OID 221890)
-- Name: tbl_capital_child_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_capital_child_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_capital_child_id_seq OWNER TO postgres;

--
-- TOC entry 6173 (class 0 OID 0)
-- Dependencies: 369
-- Name: tbl_capital_child_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_capital_child_id_seq OWNED BY public.tbl_capital_child.id;


--
-- TOC entry 367 (class 1259 OID 221876)
-- Name: tbl_capital_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_capital_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_capital_id_seq OWNER TO postgres;

--
-- TOC entry 6174 (class 0 OID 0)
-- Dependencies: 367
-- Name: tbl_capital_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_capital_id_seq OWNED BY public.tbl_capital.id;


--
-- TOC entry 402 (class 1259 OID 223284)
-- Name: tbl_charge; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_charge (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    purpose text,
    jurisdiction_police_station text,
    form_purpose text,
    charge_identification_no text,
    whether_charge_is_modified text,
    whether_charge_holder_is_authorized text,
    charge_type boolean,
    other_desc_of_charge text,
    whether_consortium_finance_is_involved text,
    banker_name text,
    whether_joint_charge_involved text,
    no_of_charge_holders integer,
    whether_charger_rank_pari_passu text,
    category text,
    others text,
    name_of_charge_holder text,
    cin_arc_assignee text,
    name_based_on_cin text,
    address1_based_on_cin text,
    address2_based_on_cin text,
    country_based_on_cin text,
    pin_based_on_cin text,
    area_based_on_cin text,
    city_based_on_cin text,
    district_based_on_cin text,
    state_based_on_cin text,
    email_id_based_on_cin text,
    jurisdiction_police_station2 text,
    brs_code text,
    whether_charge_holder_having_pan text,
    panno text,
    nature_of_instrument text,
    date_of_instrument_create timestamp without time zone,
    description_of_instrument text,
    date_of_instrument_modify timestamp without time zone,
    date_of_satisfaction_full timestamp without time zone,
    charge_modified_india text,
    date_of_receipt_documents_in_india timestamp without time zone,
    maximum_amount_secured_charge text,
    maximum_amount_secured_charge_words text,
    foreign_currency_details text,
    date_of_creating timestamp without time zone,
    borrower_account_number text,
    rate_of_interest text,
    repayment_term text,
    terms_of_repayment text,
    nature_of_facility text,
    date_of_disbursement timestamp without time zone,
    miscellaneous_narrative_information text,
    margin text,
    extent_operation_charge text,
    others1 text,
    date_of_instrument timestamp without time zone,
    date_of_acquisition timestamp without time zone,
    charge_id text,
    amount_charge text,
    particulars_of_property text,
    short_particulars text,
    whether_plot_or_dwelling_interest text,
    plot_unit_evaluated_price text,
    plot_unit_nature_of_property text,
    plot_unit_plot_id_number text,
    plot_unit_survey_number_or_gat_number text,
    dwelling_interest_dwelling_unit_id text,
    dwelling_interest_floor_number text,
    name_of_building_society text,
    street_number_and_name text,
    sector_block_number text,
    pin_code text,
    landmark text,
    village text,
    taluka text,
    area_locality text,
    district text,
    state text,
    latitude integer,
    longitude integer,
    plot_area text,
    dwelling_area text,
    bounded_by_north text,
    bounded_by_south text,
    bounded_by_east text,
    bounded_by_west text,
    whether_property_or_interest_register text,
    register_pan_no text,
    llpid_of_company text,
    in_whose_name_it_is_registered text,
    date_of_creation_modification timestamp without time zone,
    particulars_of_present_modification2 text,
    partner_din text,
    income_tax_pan text,
    designation_of_charge_holder text,
    designation_of_arc_assignee text,
    certified_by text,
    category1 text,
    name_of_pcs text,
    professional_type text,
    certificate_membership_practice text,
    instrument_file text,
    evidence_file text,
    optional_attachment text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_charge OWNER TO postgres;

--
-- TOC entry 401 (class 1259 OID 223283)
-- Name: tbl_charge_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_charge_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_charge_id_seq OWNER TO postgres;

--
-- TOC entry 6175 (class 0 OID 0)
-- Dependencies: 401
-- Name: tbl_charge_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_charge_id_seq OWNED BY public.tbl_charge.id;


--
-- TOC entry 431 (class 1259 OID 230257)
-- Name: tbl_chg1; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_chg1 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin character varying,
    company_name character varying,
    company_email character varying,
    company_address character varying,
    registration character varying,
    modification_charge_id character varying,
    applicant character varying,
    instrument_date timestamp without time zone,
    charge character varying,
    natureanddescription character varying,
    chk_interest boolean,
    chk_movable_property boolean,
    chk_intangible_licence boolean,
    chk_commercial boolean,
    chk_copy_right_patent boolean,
    chk_licence boolean,
    chk_interest_there_in boolean,
    chk_property_situated boolean,
    chk_calls boolean,
    chk_inventory boolean,
    chk_trade_marks boolean,
    chk_intangible_patent boolean,
    chk_ship boolean,
    chk_licence_under_patent boolean,
    chk_intangible_copy_right boolean,
    chk_equipment_machinery boolean,
    chk_intangible_designs boolean,
    chk_intangible_ipr boolean,
    chk_motor_vehicle boolean,
    chk_intangible_others boolean,
    chk_uncalled_capital boolean,
    chk_movable_property_others boolean,
    chk_book_debts boolean,
    chk_others boolean,
    chk_consortium_finance text,
    banker_name character varying,
    chk_joint_charge_involved character varying,
    number_of_charge_holder character varying,
    chk_pari_passu character varying,
    category character varying,
    charge_holder character varying,
    applicable_cin character varying,
    name character varying,
    address_line1 character varying,
    address_line2 character varying,
    country character varying,
    zip character varying,
    area character varying,
    city character varying,
    district character varying,
    state character varying,
    email_id character varying,
    branch_code character varying,
    valid_pan character varying,
    tax_pan character varying,
    secured_charge character varying,
    secured_amount numeric,
    security_interest_date timestamp without time zone,
    account_number character varying,
    interest_rate character varying,
    repayment_term integer,
    terms_of_repayment character varying,
    nature_facility character varying,
    date_of_disbursement timestamp without time zone,
    narrative_information character varying,
    margin character varying,
    operation_charge character varying,
    other character varying,
    evidence_charge character varying,
    instrument_description_charge character varying,
    date_of_acquisition timestamp without time zone,
    charge_id character varying,
    charge_amount numeric,
    property_charge character varying,
    property_or_assets character varying,
    number_of_title character varying,
    document_title character varying,
    registered_property character varying,
    individual_pan character varying,
    registered_name character varying,
    chk_authorised boolean,
    resolution_number text,
    declaration_date timestamp without time zone,
    terms boolean,
    designation text,
    manager_pan text,
    checkbox3 boolean,
    checkbox4 boolean,
    pan_charge_holder text,
    pan_assignee text,
    professional_type text,
    modification_charge text,
    professional_flag text,
    nameofpcs text,
    member_ship_number text
);


ALTER TABLE public.tbl_chg1 OWNER TO postgres;

--
-- TOC entry 430 (class 1259 OID 230256)
-- Name: tbl_chg1_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_chg1_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_chg1_id_seq OWNER TO postgres;

--
-- TOC entry 6176 (class 0 OID 0)
-- Dependencies: 430
-- Name: tbl_chg1_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_chg1_id_seq OWNED BY public.tbl_chg1.id;


--
-- TOC entry 454 (class 1259 OID 230633)
-- Name: tbl_chg4; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_chg4 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    satisfaction_date timestamp without time zone,
    charge_creation_number text,
    rca_user text,
    is_valid_satisfaction_date text,
    reason_of_delay text,
    required_application text,
    is_company text,
    is_satisfied_charge text,
    chg_holder_name text,
    other_cin text,
    chg_name text,
    chg_email text,
    chg_address text,
    charge_creation_date timestamp without time zone,
    last_modified_date timestamp without time zone,
    secured_amount numeric,
    secured_amount_in_words text,
    foreign_currency text,
    authorised boolean,
    resolution_number text,
    declaration_date timestamp without time zone,
    chk_declaration boolean,
    designation text,
    manager_pan text,
    declaration boolean,
    tax_declaration boolean,
    pan_charge_holder text,
    pan_assignee text,
    signed_by_designation text,
    signed_by_pan text,
    signed_by_email_id text,
    modification_charge text,
    professional_type text,
    professional_flag text,
    company_secretary text,
    membership_number text,
    instrument_creating text,
    optional_attachment text
);


ALTER TABLE public.tbl_chg4 OWNER TO postgres;

--
-- TOC entry 453 (class 1259 OID 230632)
-- Name: tbl_chg4_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_chg4_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_chg4_id_seq OWNER TO postgres;

--
-- TOC entry 6177 (class 0 OID 0)
-- Dependencies: 453
-- Name: tbl_chg4_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_chg4_id_seq OWNED BY public.tbl_chg4.id;


--
-- TOC entry 256 (class 1259 OID 180571)
-- Name: tbl_chg6; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_chg6 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    filled_by text,
    notice_type text,
    pan_number text,
    receiver_name text,
    address_line1 text,
    address_line2 text,
    country text,
    zip_code integer,
    locality text,
    city text,
    district text,
    state text,
    appointment_date timestamp without time zone,
    appointment_type text,
    number_of_charges text,
    pan_number2 text
);


ALTER TABLE public.tbl_chg6 OWNER TO postgres;

--
-- TOC entry 255 (class 1259 OID 180570)
-- Name: tbl_chg6_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_chg6_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_chg6_id_seq OWNER TO postgres;

--
-- TOC entry 6178 (class 0 OID 0)
-- Dependencies: 255
-- Name: tbl_chg6_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_chg6_id_seq OWNED BY public.tbl_chg6.id;


--
-- TOC entry 259 (class 1259 OID 180592)
-- Name: tbl_chg8; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_chg8 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    condonation_type text,
    type_of_charge text,
    application_made_by text,
    relevant_form text,
    srn_of_form_selected text,
    charge_identification_number text,
    date_of_creation_modification_satisfaction timestamp without time zone,
    amount_of_charge_created_modified_satisfied text,
    names_of_charge_holders text,
    property_or_asset_details text,
    reasons_for_delay_omission_misstatement text,
    declaration_name text,
    resolution_no text,
    declaration_date timestamp without time zone,
    member_designation text,
    member_id text
);


ALTER TABLE public.tbl_chg8 OWNER TO postgres;

--
-- TOC entry 258 (class 1259 OID 180591)
-- Name: tbl_chg8_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_chg8_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_chg8_id_seq OWNER TO postgres;

--
-- TOC entry 6179 (class 0 OID 0)
-- Dependencies: 258
-- Name: tbl_chg8_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_chg8_id_seq OWNED BY public.tbl_chg8.id;


--
-- TOC entry 262 (class 1259 OID 180619)
-- Name: tbl_chg9; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_chg9 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    form_registration_for text,
    applicant_type text,
    resolution_no text,
    declaration_date timestamp without time zone,
    member_designation text,
    member_id text,
    pan_of_charge_holder text,
    pan_assignee text,
    signed_by_designation text,
    signed_by_pan text,
    signed_by_email_id text,
    professional_type text,
    professional_flag text
);


ALTER TABLE public.tbl_chg9 OWNER TO postgres;

--
-- TOC entry 261 (class 1259 OID 180618)
-- Name: tbl_chg9_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_chg9_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_chg9_id_seq OWNER TO postgres;

--
-- TOC entry 6180 (class 0 OID 0)
-- Dependencies: 261
-- Name: tbl_chg9_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_chg9_id_seq OWNED BY public.tbl_chg9.id;


--
-- TOC entry 218 (class 1259 OID 162989)
-- Name: tbl_company; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company (
    id integer NOT NULL,
    company_name character varying,
    cin character varying,
    cin_updated_on timestamp without time zone,
    incorporation_date timestamp without time zone,
    company_contact_no character varying,
    email character varying,
    address character varying,
    company_type character varying,
    pan character varying,
    gst_no character varying,
    website character varying,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean
);


ALTER TABLE public.tbl_company OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 163007)
-- Name: tbl_company_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_details (
    id integer NOT NULL,
    company_id integer NOT NULL,
    authorized_capital numeric,
    paid_up_capital numeric,
    company_class character varying,
    registration_number integer NOT NULL,
    category character varying,
    sub_category character varying,
    date_of_last_balance_sheet timestamp without time zone,
    last_agm_date timestamp without time zone,
    whether_listed character varying,
    roc character varying,
    address_books_maintained_at character varying,
    business_activity character varying,
    main_business_division_code character varying,
    main_objects character varying
);


ALTER TABLE public.tbl_company_details OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 163006)
-- Name: tbl_company_details_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_details_id_seq OWNER TO postgres;

--
-- TOC entry 6181 (class 0 OID 0)
-- Dependencies: 221
-- Name: tbl_company_details_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_details_id_seq OWNED BY public.tbl_company_details.id;


--
-- TOC entry 463 (class 1259 OID 230818)
-- Name: tbl_company_director; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_director (
    id integer NOT NULL,
    company_id integer,
    director_id integer,
    appointment_date date,
    updated_on timestamp without time zone
);


ALTER TABLE public.tbl_company_director OWNER TO postgres;

--
-- TOC entry 462 (class 1259 OID 230817)
-- Name: tbl_company_director_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_director_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_director_id_seq OWNER TO postgres;

--
-- TOC entry 6183 (class 0 OID 0)
-- Dependencies: 462
-- Name: tbl_company_director_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_director_id_seq OWNED BY public.tbl_company_director.id;


--
-- TOC entry 224 (class 1259 OID 163016)
-- Name: tbl_company_financial_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_financial_details (
    id integer NOT NULL,
    company_id integer NOT NULL,
    previous_name character varying,
    previous_begin_date timestamp without time zone,
    previous_end_date timestamp without time zone,
    financial_year_begin_month character varying,
    financial_year_end_month character varying,
    other_cin character varying,
    other_cin_begin_date timestamp without time zone,
    other_cin_end_date timestamp without time zone,
    other_address character varying,
    other_address_begin_date timestamp without time zone,
    other_address_end_date timestamp without time zone
);


ALTER TABLE public.tbl_company_financial_details OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 163015)
-- Name: tbl_company_financial_details_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_financial_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_financial_details_id_seq OWNER TO postgres;

--
-- TOC entry 6185 (class 0 OID 0)
-- Dependencies: 223
-- Name: tbl_company_financial_details_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_financial_details_id_seq OWNED BY public.tbl_company_financial_details.id;


--
-- TOC entry 217 (class 1259 OID 162988)
-- Name: tbl_company_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_id_seq OWNER TO postgres;

--
-- TOC entry 6186 (class 0 OID 0)
-- Dependencies: 217
-- Name: tbl_company_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_id_seq OWNED BY public.tbl_company.id;


--
-- TOC entry 478 (class 1259 OID 231969)
-- Name: tbl_company_ioc; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_ioc (
    id integer NOT NULL,
    company_id integer,
    srn character varying,
    charge_id character varying,
    name character varying,
    status character varying,
    holder_name character varying,
    amount integer,
    creation_date date,
    modification_date date,
    address_1 text,
    address_2 text
);


ALTER TABLE public.tbl_company_ioc OWNER TO postgres;

--
-- TOC entry 477 (class 1259 OID 231968)
-- Name: tbl_company_ioc_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_ioc_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_ioc_id_seq OWNER TO postgres;

--
-- TOC entry 6188 (class 0 OID 0)
-- Dependencies: 477
-- Name: tbl_company_ioc_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_ioc_id_seq OWNED BY public.tbl_company_ioc.id;


--
-- TOC entry 302 (class 1259 OID 196515)
-- Name: tbl_company_notice; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_notice (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    is_active boolean,
    issue_date timestamp without time zone,
    meeting_date timestamp without time zone,
    type text,
    resolution text
);


ALTER TABLE public.tbl_company_notice OWNER TO postgres;

--
-- TOC entry 301 (class 1259 OID 196514)
-- Name: tbl_company_notice_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_notice_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_notice_id_seq OWNER TO postgres;

--
-- TOC entry 6190 (class 0 OID 0)
-- Dependencies: 301
-- Name: tbl_company_notice_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_notice_id_seq OWNED BY public.tbl_company_notice.id;


--
-- TOC entry 226 (class 1259 OID 163025)
-- Name: tbl_company_other_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_other_details (
    id integer NOT NULL,
    company_id integer NOT NULL,
    tan character varying,
    brn_no character varying,
    food_licence_no character varying,
    msme_no character varying,
    imp_exp_code character varying,
    trade_mark_no character varying,
    cor character varying
);


ALTER TABLE public.tbl_company_other_details OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 163024)
-- Name: tbl_company_other_details_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_other_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_other_details_id_seq OWNER TO postgres;

--
-- TOC entry 6191 (class 0 OID 0)
-- Dependencies: 225
-- Name: tbl_company_other_details_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_other_details_id_seq OWNED BY public.tbl_company_other_details.id;


--
-- TOC entry 446 (class 1259 OID 230536)
-- Name: tbl_company_otp; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_company_otp (
    id integer NOT NULL,
    "user" integer,
    otp_type integer,
    otp character varying,
    valid_till timestamp without time zone,
    is_valid boolean,
    mobile character varying,
    verified boolean
);


ALTER TABLE public.tbl_company_otp OWNER TO postgres;

--
-- TOC entry 445 (class 1259 OID 230535)
-- Name: tbl_company_otp_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_company_otp_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_company_otp_id_seq OWNER TO postgres;

--
-- TOC entry 6193 (class 0 OID 0)
-- Dependencies: 445
-- Name: tbl_company_otp_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_company_otp_id_seq OWNED BY public.tbl_company_otp.id;


--
-- TOC entry 237 (class 1259 OID 180080)
-- Name: tbl_debenture; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_debenture (
    first_name character varying,
    middle_name character varying,
    last_name character varying,
    category character varying,
    sub_category character varying,
    under_sub_category character varying,
    has_valid_din boolean,
    director integer,
    gender character varying,
    pan character varying,
    dob date,
    email character varying,
    mobile character varying,
    marital_status character varying,
    guardian character varying,
    cin_reg_no character varying,
    date_of_incorporation_reg date,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    type character varying,
    shareholder integer,
    id integer NOT NULL,
    salutation character varying,
    passport character varying
);


ALTER TABLE public.tbl_debenture OWNER TO postgres;

--
-- TOC entry 238 (class 1259 OID 180087)
-- Name: tbl_debenture_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_debenture_details (
    debenture integer,
    address_line_1 character varying,
    city character varying,
    state character varying,
    country character varying,
    pin_code character varying,
    father_name character varying,
    mother_name character varying,
    nationality character varying,
    voter_id character varying,
    aadhar_no character varying,
    occupation character varying,
    spouse_name character varying,
    pan_url character varying,
    aadhar_url character varying,
    id integer NOT NULL
);


ALTER TABLE public.tbl_debenture_details OWNER TO postgres;

--
-- TOC entry 240 (class 1259 OID 180103)
-- Name: tbl_debenture_details_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_debenture_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_debenture_details_id_seq OWNER TO postgres;

--
-- TOC entry 6195 (class 0 OID 0)
-- Dependencies: 240
-- Name: tbl_debenture_details_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_debenture_details_id_seq OWNED BY public.tbl_debenture_details.id;


--
-- TOC entry 239 (class 1259 OID 180094)
-- Name: tbl_debenture_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_debenture_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_debenture_id_seq OWNER TO postgres;

--
-- TOC entry 6196 (class 0 OID 0)
-- Dependencies: 239
-- Name: tbl_debenture_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_debenture_id_seq OWNED BY public.tbl_debenture.id;


--
-- TOC entry 280 (class 1259 OID 180818)
-- Name: tbl_dir11; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir11 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    director integer,
    director_name text,
    nationality text,
    appointment_date timestamp without time zone,
    designation text,
    category text,
    filing_date timestamp without time zone,
    effective_resignation_date timestamp without time zone,
    resignation_reason text,
    other_reason_details text,
    confirmation_received text,
    director_name2 text,
    din text
);


ALTER TABLE public.tbl_dir11 OWNER TO postgres;

--
-- TOC entry 279 (class 1259 OID 180817)
-- Name: tbl_dir11_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir11_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir11_id_seq OWNER TO postgres;

--
-- TOC entry 6197 (class 0 OID 0)
-- Dependencies: 279
-- Name: tbl_dir11_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir11_id_seq OWNED BY public.tbl_dir11.id;


--
-- TOC entry 283 (class 1259 OID 180847)
-- Name: tbl_dir12; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir12 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    num_managing_directors integer,
    num_kmp integer,
    srn_inc28 text,
    designation text,
    director_id text,
    authorized_person text,
    authorization_details text,
    authorization_date timestamp without time zone,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_dir12 OWNER TO postgres;

--
-- TOC entry 282 (class 1259 OID 180846)
-- Name: tbl_dir12_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir12_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir12_id_seq OWNER TO postgres;

--
-- TOC entry 6198 (class 0 OID 0)
-- Dependencies: 282
-- Name: tbl_dir12_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir12_id_seq OWNED BY public.tbl_dir12.id;


--
-- TOC entry 268 (class 1259 OID 180724)
-- Name: tbl_dir3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir3 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    is_citizen_of_india text,
    passport_size_photograph text,
    applicant_first_name text,
    applicant_middle_name text,
    applicant_last_name text,
    father_first_name text,
    father_middle_name text,
    father_last_name text,
    nationality text,
    is_resident_in_india text,
    occupation_type text,
    educational_qualification text,
    date_of_birth timestamp without time zone,
    gender text,
    income_tax_permanent_account_number text,
    income_tax_pan_file text,
    has_aadhaar text,
    aadhaar_number text,
    aadhaar_file text,
    voter_id_number text,
    voter_id_file text,
    passport_number text,
    passport_file text,
    driving_license_number text,
    driving_license_file text,
    address_line1 text,
    address_line2 text,
    country text,
    pin_code text,
    area_locality text,
    city text,
    district text,
    state_ut text,
    jurisdiction_police_station text,
    phone text,
    fax text,
    email text,
    is_address_same text,
    present_address_line1 text,
    present_address_line2 text,
    present_country text,
    present_pin_code text,
    present_area_locality text,
    present_city text,
    present_district text,
    present_state_ut text,
    present_jurisdiction_police_station text,
    present_phone text,
    present_fax text,
    verification_name text,
    verification_fathers_name text,
    verification_dob timestamp without time zone,
    verification_address text,
    security_clearance text,
    category_select text,
    director_dpin_or_pan_or_membership_number text,
    category_select_duplicate text
);


ALTER TABLE public.tbl_dir3 OWNER TO postgres;

--
-- TOC entry 267 (class 1259 OID 180723)
-- Name: tbl_dir3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir3_id_seq OWNER TO postgres;

--
-- TOC entry 6199 (class 0 OID 0)
-- Dependencies: 267
-- Name: tbl_dir3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir3_id_seq OWNED BY public.tbl_dir3.id;


--
-- TOC entry 271 (class 1259 OID 180739)
-- Name: tbl_dir5; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir5 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    reason_for_surrender text,
    retaining_din text,
    din_to_retain text,
    first_name text,
    middle_name text,
    last_name text,
    father_first_name text,
    father_middle_name text,
    father_last_name text,
    dob timestamp without time zone,
    pan text,
    num_of_dins_surrendered integer,
    is_digitally_signed text,
    other_information text,
    name text,
    id_number text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_dir5 OWNER TO postgres;

--
-- TOC entry 270 (class 1259 OID 180738)
-- Name: tbl_dir5_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir5_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir5_id_seq OWNER TO postgres;

--
-- TOC entry 6200 (class 0 OID 0)
-- Dependencies: 270
-- Name: tbl_dir5_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir5_id_seq OWNED BY public.tbl_dir5.id;


--
-- TOC entry 274 (class 1259 OID 180766)
-- Name: tbl_dir6; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir6 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    director_din text,
    director_name text,
    photograph text,
    citizen_of_india text,
    director_first_name text,
    director_middle_name text,
    director_last_name text,
    father_first_name text,
    father_middle_name text,
    father_last_name text,
    nationality text,
    is_resident_in_india text,
    dob timestamp without time zone,
    gender text,
    pan_number text,
    pan_attachment text,
    aadhaar_number text,
    aadhaar_attachment text,
    voter_id_number text,
    voter_id_attachment text,
    passport_number text,
    passport_attachment text,
    driving_license_number text,
    driving_license_attachment text,
    permanent_address_line_1 text,
    permanent_address_line_2 text,
    permanent_country text,
    permanent_pin_code text,
    permanent_area text,
    permanent_city text,
    permanent_district text,
    permanent_state text,
    permanent_police_station text,
    phone text,
    fax text,
    same_address text,
    present_address_line_1 text,
    present_address_line_2 text,
    present_country text,
    present_pin_code text,
    present_area text,
    present_city text,
    present_district text,
    present_state text,
    present_police_station text,
    present_phone text,
    present_fax text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_dir6 OWNER TO postgres;

--
-- TOC entry 273 (class 1259 OID 180765)
-- Name: tbl_dir6_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir6_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir6_id_seq OWNER TO postgres;

--
-- TOC entry 6201 (class 0 OID 0)
-- Dependencies: 273
-- Name: tbl_dir6_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir6_id_seq OWNED BY public.tbl_dir6.id;


--
-- TOC entry 277 (class 1259 OID 180804)
-- Name: tbl_dir9; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dir9 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    roc_alert text,
    disqualification_section text,
    num_directors integer,
    reason_11642b boolean,
    repay_deposit_date timestamp without time zone,
    repay_deposit_expire timestamp without time zone,
    reason_21642b boolean,
    pay_deposit_due timestamp without time zone,
    pay_deposit_expire timestamp without time zone,
    reason_31642b boolean,
    failed_to_redeem timestamp without time zone,
    failed_to_redeem_expire timestamp without time zone,
    reason_41642b boolean,
    debentures_redeem timestamp without time zone,
    debentures_redeem_expire timestamp without time zone,
    reason_51642b boolean,
    dividend_date timestamp without time zone,
    dividend_expire timestamp without time zone,
    resolution_date timestamp without time zone,
    designation text,
    signatory text,
    din_pan text
);


ALTER TABLE public.tbl_dir9 OWNER TO postgres;

--
-- TOC entry 276 (class 1259 OID 180803)
-- Name: tbl_dir9_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dir9_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dir9_id_seq OWNER TO postgres;

--
-- TOC entry 6202 (class 0 OID 0)
-- Dependencies: 276
-- Name: tbl_dir9_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dir9_id_seq OWNED BY public.tbl_dir9.id;


--
-- TOC entry 220 (class 1259 OID 162998)
-- Name: tbl_director; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_director (
    id integer NOT NULL,
    first_name character varying,
    middle_name character varying,
    last_name character varying,
    din character varying,
    pan character varying,
    mobile character varying,
    aadhar character varying,
    email character varying,
    dsc_expiry timestamp without time zone,
    din_status character varying,
    dir_kyc_status character varying,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    din_updated_on timestamp without time zone,
    passport character varying,
    salutation character varying
);


ALTER TABLE public.tbl_director OWNER TO postgres;

--
-- TOC entry 472 (class 1259 OID 231922)
-- Name: tbl_director_appointment_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_director_appointment_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_director_appointment_id_seq OWNER TO postgres;

--
-- TOC entry 6203 (class 0 OID 0)
-- Dependencies: 472
-- Name: tbl_director_appointment_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_director_appointment_id_seq OWNED BY public.tbl_action_director_appointment.id;


--
-- TOC entry 228 (class 1259 OID 163034)
-- Name: tbl_director_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_director_details (
    id integer NOT NULL,
    director_id integer NOT NULL,
    address character varying,
    country character varying,
    state character varying,
    city character varying,
    pincode integer,
    father_name character varying,
    date_of_birth timestamp without time zone,
    occupation character varying,
    gender character varying,
    nationality character varying,
    residential_status character varying,
    marital_status character varying,
    qualification character varying,
    experience character varying,
    passport character varying,
    passport_expiry_date timestamp without time zone,
    permanent_address character varying,
    other_communication_address character varying,
    pan_url character varying,
    aadhar_url character varying,
    passport_url character varying,
    voter_id_url character varying,
    driving_licence_url character varying
);


ALTER TABLE public.tbl_director_details OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 163033)
-- Name: tbl_director_details_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_director_details_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_director_details_id_seq OWNER TO postgres;

--
-- TOC entry 6204 (class 0 OID 0)
-- Dependencies: 227
-- Name: tbl_director_details_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_director_details_id_seq OWNED BY public.tbl_director_details.id;


--
-- TOC entry 219 (class 1259 OID 162997)
-- Name: tbl_director_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_director_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_director_id_seq OWNER TO postgres;

--
-- TOC entry 6205 (class 0 OID 0)
-- Dependencies: 219
-- Name: tbl_director_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_director_id_seq OWNED BY public.tbl_director.id;


--
-- TOC entry 444 (class 1259 OID 230465)
-- Name: tbl_dms; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dms (
    id integer NOT NULL,
    company_id integer,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_by integer,
    deleted_on timestamp without time zone,
    is_active boolean,
    type character varying,
    form_name character varying,
    event_date date,
    financial_year integer,
    form_original text,
    form_client text,
    challan_original text,
    challan_client text
);


ALTER TABLE public.tbl_dms OWNER TO postgres;

--
-- TOC entry 443 (class 1259 OID 230464)
-- Name: tbl_dms_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dms_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dms_id_seq OWNER TO postgres;

--
-- TOC entry 6207 (class 0 OID 0)
-- Dependencies: 443
-- Name: tbl_dms_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dms_id_seq OWNED BY public.tbl_dms.id;


--
-- TOC entry 265 (class 1259 OID 180710)
-- Name: tbl_dpt3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dpt3 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    type text,
    form_purpose text,
    is_gov text,
    company_objects text,
    deposit_accepted text,
    return_period timestamp without time zone,
    date_of_issue timestamp without time zone,
    date_of_expiry timestamp without time zone,
    paid_up_share_capital numeric,
    free_reserves numeric,
    securities_premium_account numeric,
    accumulated_loss numeric,
    deferred_revenue_expenditure_balance numeric,
    accumulated_unprovided_depreciation numeric,
    miscellaneous_expense numeric,
    other_intangible_assets numeric,
    net_worth numeric,
    deposit_max_limit numeric,
    total_deposit_holders_start integer,
    total_deposit_holders_end integer,
    existing_deposits_start integer,
    deposits_renewed integer,
    secured_deposits integer,
    unsecured_deposits integer,
    deposits_repaid integer,
    deposits_outstanding integer,
    matured_not_claimed integer,
    matured_claimed_not_paid integer,
    deposits_maturing_before_march integer,
    deposits_maturing_following_next_year integer,
    amount_required_in_liquid_assets numeric,
    current_deposits_free_from_charge numeric,
    face_value_gov_securities numeric,
    market_value_gov_securities numeric,
    face_value_trust_securities numeric,
    market_value_trust_securities numeric,
    credit_rating_agency text,
    credit_rating text,
    credit_rating_date timestamp without time zone,
    gnl_form_srn text,
    auditor_name text,
    auditor_designation text,
    membership_number text,
    resolution_number text,
    declaration_date timestamp without time zone,
    signatory_designation text,
    signatory_id text
);


ALTER TABLE public.tbl_dpt3 OWNER TO postgres;

--
-- TOC entry 264 (class 1259 OID 180709)
-- Name: tbl_dpt3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dpt3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dpt3_id_seq OWNER TO postgres;

--
-- TOC entry 6209 (class 0 OID 0)
-- Dependencies: 264
-- Name: tbl_dpt3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dpt3_id_seq OWNED BY public.tbl_dpt3.id;


--
-- TOC entry 253 (class 1259 OID 180439)
-- Name: tbl_dpt4; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_dpt4 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    cin character varying(255),
    company_name character varying(255),
    company_address text,
    company_email character varying(255),
    company_type character varying(255),
    is_gov character varying(10),
    amt character varying(255),
    number_of_depositors character varying(255),
    deposits_due_but_not_paid character varying(255),
    interest_due_there_on_but_not_paid character varying(255),
    deposits_due_but_not_claimed character varying(255),
    interest_due_there_on_but_not_claimed character varying(255),
    deposits_not_yet_due_for_repayment character varying(255),
    deposits_due_for_repayment_three_months character varying(255),
    arrangement_for_repayment_deposits_due character varying(255),
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    resolution_no character varying,
    resolution_date timestamp without time zone
);


ALTER TABLE public.tbl_dpt4 OWNER TO postgres;

--
-- TOC entry 252 (class 1259 OID 180438)
-- Name: tbl_dpt4_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_dpt4_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_dpt4_id_seq OWNER TO postgres;

--
-- TOC entry 6210 (class 0 OID 0)
-- Dependencies: 252
-- Name: tbl_dpt4_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_dpt4_id_seq OWNED BY public.tbl_dpt4.id;


--
-- TOC entry 390 (class 1259 OID 222782)
-- Name: tbl_form11; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form11 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    financial_year_from_date timestamp without time zone,
    financial_year_to_date timestamp without time zone,
    offence_date_11 timestamp without time zone,
    jurisdiction_police_station_address text,
    other_address_under_13c text,
    jurisdiction_police_station_other_address text,
    business_classification text,
    business_principal_activities text,
    total_number_of_designated_partners text,
    total_number_of_partners text,
    total_obligation_of_contribution text,
    total_contribution_received_from text,
    invi_partner_data text,
    bodycor_partner_data text,
    number_of_partner_1 text,
    number_of_partner text,
    resident_in_india text,
    other_resident text,
    number_of_partner_2 text,
    resident_in_india_2 text,
    other_resident_2 text,
    number_of_partner_3 text,
    resident_in_india_3 text,
    other_resident_3 text,
    number_of_partner_4 text,
    resident_in_india_4 text,
    other_resident_4 text,
    total_partner_1 text,
    total_partner_2 text,
    total_partner_3 text,
    total_partner_4 text,
    total_partner_5 text,
    total_partner_6 text,
    total_partner_7 text,
    total_partner_8 text,
    number_of_partner_5 text,
    resident_in_india_5 text,
    other_resident_5 text,
    number_of_partner_6 text,
    resident_in_india_6 text,
    other_resident_6 text,
    number_of_partner_7 text,
    resident_in_india_7 text,
    other_resident_7 text,
    number_of_partner_8 text,
    resident_in_india_8 text,
    other_resident_8 text,
    rows_required_10a text,
    section_number text,
    offence_1 text,
    offence_2 text,
    offence_3 text,
    penalty_imp text,
    penalty_imposed text,
    rows_required_10b text,
    offenses_2 text,
    dpin_pan_passport text,
    name_of_partner text,
    nominee_name text,
    section_num text,
    rows_required_11a text,
    section_number_11 text,
    offense_date_11 text,
    turn_over_of_the_llp_exceeds_5cr text,
    attachment_file text,
    name_of_person_signing text,
    designation_of_person text,
    id_of_person_signing text,
    annual_return_certify boolean,
    dpin_designated_partner_textbox text,
    here_by_certified boolean,
    company_name_2 text,
    certi_practice_no_box text,
    whether_associate_or_fellow text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form11 OWNER TO postgres;

--
-- TOC entry 389 (class 1259 OID 222781)
-- Name: tbl_form11_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form11_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form11_id_seq OWNER TO postgres;

--
-- TOC entry 6211 (class 0 OID 0)
-- Dependencies: 389
-- Name: tbl_form11_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form11_id_seq OWNED BY public.tbl_form11.id;


--
-- TOC entry 396 (class 1259 OID 222879)
-- Name: tbl_form12; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form12 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    llp_name text,
    jurisdiction_police_station text,
    address_line1 text,
    address_line2 text,
    country text,
    pin_code text,
    area_locality text,
    city text,
    district text,
    latitude text,
    state text,
    longitude text,
    phone text,
    fax text,
    jurisdiction_police_station2 text,
    reason_change_address text,
    clause_reference text,
    relevant_extract text,
    consent_date timestamp without time zone,
    verified_status boolean,
    authorised_status boolean,
    partner_din text,
    dpin text,
    records_certified text,
    professional_practice text,
    name_of_pcs text,
    professional_type text,
    membership_number integer,
    instrument_creating text,
    affidavit text,
    charge_holder text,
    attachment_file text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form12 OWNER TO postgres;

--
-- TOC entry 395 (class 1259 OID 222878)
-- Name: tbl_form12_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form12_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form12_id_seq OWNER TO postgres;

--
-- TOC entry 6212 (class 0 OID 0)
-- Dependencies: 395
-- Name: tbl_form12_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form12_id_seq OWNED BY public.tbl_form12.id;


--
-- TOC entry 399 (class 1259 OID 223159)
-- Name: tbl_form15; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form15 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    llp_name text,
    jurisdiction_of_police_station text,
    purpose text,
    address_line1 text,
    address_line2 text,
    country text,
    pin_code text,
    area_locality text,
    city text,
    latitude text,
    state text,
    district text,
    longitude text,
    new_jurisdiction_of_police_station text,
    prosecution_pending text,
    case_number integer,
    section_prosecution_pending text,
    act_name_prosecution_pending text,
    stage_prosecution_pending text,
    court_name_prosecution_pending text,
    case_details text,
    application_pending text,
    brief_details text,
    date_publication_in_english timestamp without time zone,
    date_publication_in_vernacular timestamp without time zone,
    newspaper_name_publication_in_english text,
    newspaper_name_publication_in_vernaular text,
    brief_details_objection_received text,
    change_in_address text,
    date_of_consent_partners timestamp without time zone,
    clause_reference_llp_agreement text,
    relevant_extract_llp_agreement text,
    consent_of_secured_creditors text,
    date_of_consent_taken_of_creditors timestamp without time zone,
    verification_check_box1 boolean,
    verification_check_box2 boolean,
    verification_check_box3 boolean,
    d_pin text,
    particulars_record text,
    to_be_digitally_signed_by_member text,
    name_of_pcs text,
    whether_associate text,
    membership_number text,
    instrument_creating text,
    affidavit text,
    charge_holder text,
    attachment_file text,
    partner_din text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form15 OWNER TO postgres;

--
-- TOC entry 398 (class 1259 OID 223158)
-- Name: tbl_form15_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form15_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form15_id_seq OWNER TO postgres;

--
-- TOC entry 6213 (class 0 OID 0)
-- Dependencies: 398
-- Name: tbl_form15_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form15_id_seq OWNED BY public.tbl_form15.id;


--
-- TOC entry 411 (class 1259 OID 223439)
-- Name: tbl_form22; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form22 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    jurisdiction_of_police_station text,
    order_passed text,
    name_of_order_passed text,
    location text,
    specify_others text,
    application_number text,
    order_number text,
    date_of_passing_order text,
    relevant_act text,
    section_of_llp_2008 text,
    section_of_insolvency text,
    no_of_days text,
    other_section_details text,
    other_section_description text,
    application_date timestamp without time zone,
    issue_date timestamp without time zone,
    due_date text,
    description_order text,
    compounding_srn text,
    offence_srn text,
    form_31_srn text,
    srn_form_22 text,
    whether_cost_involved text,
    details_of_cost_paid text,
    registration_no_irp text,
    pan_number_irp text,
    name_irp text,
    mobile_no_irp text,
    email_irp text,
    address_line_1_irp text,
    address_line_2_orp text,
    country_irp text,
    pin_code_irp text,
    locality_irp text,
    city_irp text,
    state_irp text,
    district_irp text,
    attachment_file text,
    verification_checkbox_1 boolean,
    verification_checkbox_2 boolean,
    designation_auth text,
    name_auth_representative text,
    name_designated_partner text,
    dpin_partner text,
    capacity text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form22 OWNER TO postgres;

--
-- TOC entry 410 (class 1259 OID 223438)
-- Name: tbl_form22_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form22_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form22_id_seq OWNER TO postgres;

--
-- TOC entry 6214 (class 0 OID 0)
-- Dependencies: 410
-- Name: tbl_form22_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form22_id_seq OWNED BY public.tbl_form22.id;


--
-- TOC entry 405 (class 1259 OID 223311)
-- Name: tbl_form23; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form23 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    catagory text,
    line2 text,
    country text,
    pin_code text,
    area text,
    city text,
    district text,
    state text,
    jurisdiction_police_station text,
    phone_no text,
    mobile_no text,
    llpin text,
    name_llp text,
    email_id1 text,
    registered_llp text,
    grounds_of_objection text,
    self_declaration boolean,
    provision_declaration boolean,
    authorized_declaration boolean,
    designation text,
    designation_name text,
    dpin_number text,
    authority text,
    attachment_file text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form23 OWNER TO postgres;

--
-- TOC entry 404 (class 1259 OID 223310)
-- Name: tbl_form23_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form23_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form23_id_seq OWNER TO postgres;

--
-- TOC entry 6215 (class 0 OID 0)
-- Dependencies: 404
-- Name: tbl_form23_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form23_id_seq OWNED BY public.tbl_form23.id;


--
-- TOC entry 408 (class 1259 OID 223415)
-- Name: tbl_form24; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form24 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    application_reason text,
    is_action_initiated text,
    income_tax_updated text,
    ceased_llp_date timestamp without time zone,
    llp_under_law text,
    regulator_name text,
    noc_approval_date timestamp without time zone,
    prosecutions_pending text,
    number_of_prosecutions numeric,
    statement_of_acc_date timestamp without time zone,
    capital numeric,
    reserves_and_surplus numeric,
    secured_loans_from_fi numeric,
    secured_loans_from_bank numeric,
    secured_loans_from_govt numeric,
    others_secured_loans numeric,
    debentures numeric,
    unsecured_loans numeric,
    deposits_and_interest numeric,
    total_loan_funds numeric,
    total numeric,
    fixed_assets numeric,
    investments numeric,
    current_assets numeric,
    creditors numeric,
    unpaid_dividend numeric,
    payables numeric,
    others numeric,
    total_current_liabilities numeric,
    net_current_assets numeric,
    miscellaneous_expenditure numeric,
    profit_and_loss_account numeric,
    total2 numeric,
    name text,
    place text,
    designation text,
    membership_number text,
    partner_name text,
    partner_dpin text,
    self_declaration boolean,
    assets_declaration boolean,
    liability_declaration boolean,
    authority_copy text,
    acknowledgment_copy text,
    statement_copy text,
    return_copy text,
    order_copy text,
    signed_affidavit text,
    optional_attachment text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form24 OWNER TO postgres;

--
-- TOC entry 407 (class 1259 OID 223414)
-- Name: tbl_form24_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form24_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form24_id_seq OWNER TO postgres;

--
-- TOC entry 6216 (class 0 OID 0)
-- Dependencies: 407
-- Name: tbl_form24_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form24_id_seq OWNED BY public.tbl_form24.id;


--
-- TOC entry 372 (class 1259 OID 221981)
-- Name: tbl_form3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form3 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    form_filled_for text,
    llp_in integer,
    llp_name text,
    jurisdiction_police_station text,
    liability_state3 text,
    business_activities text,
    total_partners_as_on_date_of_filing text,
    initial_llp_attach text,
    total_monetary_value_partner_contribution_llp text,
    new_mutual_rights text,
    new_restrictions text,
    new_acts_matters_things text,
    new_meeting_procedure text,
    new_indemnity_clause text,
    new_partner_admission text,
    new_partner_retirement text,
    new_partner_cessation text,
    new_partner_expulsion text,
    new_partner_resignation text,
    new_disputes_partner text,
    new_disputes_between_partner_llp text,
    new_llp_duration text,
    new_voluntary_winding_up text,
    new_rule16 text,
    new_rule17 text,
    new_rule120 text,
    new_rule24 text,
    new_other_information_clause text,
    date_of_modification16 timestamp without time zone,
    number_of_changes integer,
    delete_row text,
    srn_number text,
    change_in_business_activities_flag text,
    change_in_partner_flag text,
    changes_in_partners_profit_sharing_flag text,
    changes_due_to_other_reason_flag text,
    other_reason_mutual_rights_flag text,
    search_code text,
    nic_code_serial text,
    nic_code1 text,
    nic_code1_desc text,
    remove text,
    nic_code2_desc text,
    nic_code3 text,
    nic_code3_desc text,
    nic_codes text,
    nic_codes_desc text,
    des_business_activity18f text,
    change_business_activity18g text,
    changes_in_llp_attach text,
    table2_excel_data text,
    total_existing_partner19b integer,
    total_partner_appointed19b text,
    total_partners_removed19b text,
    total_partners_changed19b text,
    existing19c integer,
    addition19c integer,
    reduction19c integer,
    total_sum19c text,
    total_in_words text,
    chg_mutual_rights text,
    chg_restrictions text,
    chg_acts_matters_things text,
    chg_meeting_procedure text,
    chg_indemnity_clause text,
    chg_partner_admission text,
    chg_partner_retirement text,
    chg_partner_cessation text,
    chg_partner_expulsion text,
    chg_partner_resignation text,
    chg_disputes_partner text,
    chg_disputes_between_partner_llp text,
    chg_llp_duration text,
    chg_voluntary_winding_up text,
    chg_rule16 text,
    chg_rule17 text,
    chg_rule20 text,
    chg_rule24 text,
    chg_other_information_clause text,
    initial_llp text,
    changes_llp text,
    attachment_file text,
    designated_partner text,
    designated_partner_id text,
    professional_practice text,
    name_of_pcs text,
    professional_type text,
    membership_number text,
    certificate_number text,
    nic_code_serial_2 text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form3 OWNER TO postgres;

--
-- TOC entry 371 (class 1259 OID 221980)
-- Name: tbl_form3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form3_id_seq OWNER TO postgres;

--
-- TOC entry 6217 (class 0 OID 0)
-- Dependencies: 371
-- Name: tbl_form3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form3_id_seq OWNED BY public.tbl_form3.id;


--
-- TOC entry 350 (class 1259 OID 221522)
-- Name: tbl_form4; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form4 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    num_indiv_desig_partner integer,
    num_bodies_corp_nominees integer,
    num_indiv_partner integer,
    num_bodies_corp_partners integer,
    total_partners integer,
    designated_partner text,
    dpin_designated_partner text,
    professional_category text,
    selected_pcs text,
    membership_type text,
    membership_number text
);


ALTER TABLE public.tbl_form4 OWNER TO postgres;

--
-- TOC entry 349 (class 1259 OID 221521)
-- Name: tbl_form4_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form4_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form4_id_seq OWNER TO postgres;

--
-- TOC entry 6218 (class 0 OID 0)
-- Dependencies: 349
-- Name: tbl_form4_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form4_id_seq OWNED BY public.tbl_form4.id;


--
-- TOC entry 378 (class 1259 OID 222128)
-- Name: tbl_form5; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_form5 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    number_partnership text,
    llp_name text,
    srn_run text,
    llp_new_name text,
    police_station_jurisdiction text,
    change_name_declaration text,
    srn_of_3 text,
    name_change_1 boolean,
    name_change_2 boolean,
    name_change_3 boolean,
    name_change_4 boolean,
    number_clause text,
    extract_relevant text,
    date_of_consent text,
    statements_1 boolean,
    statements_2 boolean,
    designation text,
    designated_partners text,
    professional_practice text,
    name_of_pcs text,
    professional_type text,
    practice_number text,
    consent_partners text,
    minutes text,
    central text,
    registrar text,
    attachment_add text,
    attachment_file text,
    company_address_llp text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_form5 OWNER TO postgres;

--
-- TOC entry 377 (class 1259 OID 222127)
-- Name: tbl_form5_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_form5_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_form5_id_seq OWNER TO postgres;

--
-- TOC entry 6219 (class 0 OID 0)
-- Dependencies: 377
-- Name: tbl_form5_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_form5_id_seq OWNED BY public.tbl_form5.id;


--
-- TOC entry 423 (class 1259 OID 223824)
-- Name: tbl_gnl1; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_gnl1 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    applicant_category text,
    corporate_gln text,
    name text,
    address_line1 text,
    address_line2 text,
    city text,
    state text,
    iso_code text,
    country text,
    pin_code integer,
    email text,
    filed_for text,
    others text,
    application_details text,
    filed_company boolean,
    filed_director boolean,
    filed_manager boolean,
    filed_other boolean,
    persons_filed integer,
    application_filed text,
    notice_number numeric,
    section_filed text,
    particulars_brief text,
    agm_date timestamp without time zone,
    srn_mgt14 text,
    date_passing timestamp without time zone,
    mgt14_date timestamp without time zone,
    stamp_duty_amount numeric,
    director_authorization boolean,
    resolution_no text,
    resolution_date timestamp without time zone,
    self_declaration boolean,
    designation text,
    declaration text,
    din text,
    digitally_signed_by text,
    name_of_pcs text,
    associate_or_fellow text,
    membership_number numeric,
    cert_practise_number text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_gnl1 OWNER TO postgres;

--
-- TOC entry 422 (class 1259 OID 223823)
-- Name: tbl_gnl1_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_gnl1_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_gnl1_id_seq OWNER TO postgres;

--
-- TOC entry 6220 (class 0 OID 0)
-- Dependencies: 422
-- Name: tbl_gnl1_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_gnl1_id_seq OWNED BY public.tbl_gnl1.id;


--
-- TOC entry 328 (class 1259 OID 221121)
-- Name: tbl_gnl2; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_gnl2 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    filed_document text,
    issued_advertisement_date text,
    opening_acceptance text,
    expected_advertisement_date text,
    others text,
    reference_act text,
    companies_act text,
    srn integer,
    special_resolutiondate text,
    event_date text,
    directors_date text,
    prospectus_document text,
    herring_document text,
    advertisement_document text,
    placement_document text,
    companies_document text,
    companies_rules_document text,
    companies153_document text,
    companies154_document text,
    companies156_document text,
    companies157_document text,
    companies158_document text,
    companies159_document text,
    liquidation_document text,
    relevant_document text,
    financial_document text,
    valuation_document text,
    optional_attachment text,
    designation text,
    resolution_date timestamp without time zone,
    name text,
    capacity text,
    din text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_gnl2 OWNER TO postgres;

--
-- TOC entry 327 (class 1259 OID 221120)
-- Name: tbl_gnl2_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_gnl2_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_gnl2_id_seq OWNER TO postgres;

--
-- TOC entry 6221 (class 0 OID 0)
-- Dependencies: 327
-- Name: tbl_gnl2_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_gnl2_id_seq OWNED BY public.tbl_gnl2.id;


--
-- TOC entry 331 (class 1259 OID 221162)
-- Name: tbl_gnl3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_gnl3 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    number_charged integer,
    permission_withdrawn text,
    consent_date timestamp without time zone,
    resolution_date timestamp without time zone,
    copy_attachment text,
    optional_attachment text,
    director_resolution text,
    director_date timestamp without time zone,
    certification_declaration boolean,
    din_of_person_charged text,
    designation text,
    din text,
    category text,
    whole text,
    name_of_pcs text,
    associate_or_fellow text,
    membership_number integer,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_gnl3 OWNER TO postgres;

--
-- TOC entry 330 (class 1259 OID 221161)
-- Name: tbl_gnl3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_gnl3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_gnl3_id_seq OWNER TO postgres;

--
-- TOC entry 6222 (class 0 OID 0)
-- Dependencies: 330
-- Name: tbl_gnl3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_gnl3_id_seq OWNED BY public.tbl_gnl3.id;


--
-- TOC entry 393 (class 1259 OID 222811)
-- Name: tbl_iepf2; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_iepf2 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    purpose text,
    sub_purpose text,
    is_existing_nodal_officer text,
    cin_of_holding_or_subsidiary text,
    name_of_the_nodal_officer text,
    first_name text,
    middle_name text,
    last_name text,
    fathers_first_name text,
    fathers_middle_name text,
    fathers_last_name text,
    dob timestamp without time zone,
    pan text,
    designation text,
    gender text,
    official_address_line1 text,
    official_address_line2 text,
    country text,
    pin_code text,
    locality text,
    city text,
    district text,
    state text,
    phone_number text,
    mobile_number text,
    nodal_officer_email text,
    dob_resolution timestamp without time zone,
    deputy_nodal_officer_added integer,
    deputy_nodal_officer_update integer,
    deputy_nodal_officer_ceased integer,
    financial_year_end_date timestamp without time zone,
    date_of_agm timestamp without time zone,
    registered_with_rbi text,
    number_of_small_share_holders integer,
    number_of_small_depositors integer,
    unclaimed_dividend_fy1 integer,
    unclaimed_dividend_fy2 integer,
    unclaimed_dividend_fy3 integer,
    unclaimed_dividend_fy4 integer,
    unclaimed_dividend_fy5 integer,
    unclaimed_dividend_fy6 integer,
    unclaimed_dividend_fy7 integer,
    unclaimed_dividend_total integer,
    underlying_shares_fy1 integer,
    underlying_shares_fy2 integer,
    underlying_shares_fy3 integer,
    underlying_shares_fy4 integer,
    underlying_shares_fy5 integer,
    underlying_shares_fy6 integer,
    underlying_shares_fy7 integer,
    underlying_shares_total integer,
    refund_by_company_fy1 integer,
    refunded_by_company_fy2 integer,
    refunded_by_company_fy3 integer,
    refunded_by_company_fy4 integer,
    refunded_by_company_fy5 integer,
    refunded_by_company_fy6 integer,
    refunded_by_company_fy7 integer,
    refunded_by_company_fytotal integer,
    recieved_under_sec38_fy1 integer,
    recieved_under_sec38_fy2 integer,
    recieved_under_sec38_fy3 integer,
    recieved_under_sec38_fy4 integer,
    recieved_under_sec38_fy5 integer,
    recieved_under_sec38_fy6 integer,
    recieved_under_sec38_fy7 integer,
    recieved_under_sec38_fytotal integer,
    recieved_and_due_for_refund_fy1 integer,
    recieved_and_due_for_refund_fy2 integer,
    recieved_and_due_for_refund_fy3 integer,
    recieved_and_due_for_refund_fy4 integer,
    recieved_and_due_for_refund_fy5 integer,
    recieved_and_due_for_refund_fy6 integer,
    recieved_and_due_for_refund_fy7 integer,
    recieved_and_due_for_refund_fytotal integer,
    matured_deposit_fy1 integer,
    matured_deposit_fy2 integer,
    matured_deposit_fy3 integer,
    matured_deposit_fy4 integer,
    matured_deposit_fy5 integer,
    matured_deposit_fy6 integer,
    matured_deposit_fy7 integer,
    matured_deposit_fytotal integer,
    refund_by_comp_from_meture_deposit_fy1 integer,
    refund_by_comp_from_meture_deposit_fy2 integer,
    refund_by_comp_from_meture_deposit_fy3 integer,
    refund_by_comp_from_meture_deposit_fy4 integer,
    refund_by_comp_from_meture_deposit_fy5 integer,
    refund_by_comp_from_meture_deposit_fy6 integer,
    refund_by_comp_from_meture_deposit_fy7 integer,
    refund_by_comp_from_meture_deposit_fytotal integer,
    amount_of_debentures_fy1 integer,
    amount_of_debentures_fy2 integer,
    amount_of_debentures_fy3 integer,
    amount_of_debentures_fy4 integer,
    amount_of_debentures_fy5 integer,
    amount_of_debentures_fy6 integer,
    amount_of_debentures_fy7 integer,
    amount_of_debentures_fytotal integer,
    refund_by_comp_from_meture_debentures_fy1 integer,
    refund_by_comp_from_meture_debentures_fy2 integer,
    refund_by_comp_from_meture_debentures_fy3 integer,
    refund_by_comp_from_meture_debentures_fy4 integer,
    refund_by_comp_from_meture_debentures_fy5 integer,
    refund_by_comp_from_meture_debentures_fy6 integer,
    refund_by_comp_from_meture_debentures_fy7 integer,
    refund_by_comp_from_meture_debentures_fytotal integer,
    intrest_accured_on_amounts_fy1 text,
    intrest_accured_on_amounts_fy2 text,
    intrest_accured_on_amounts_fy3 text,
    intrest_accured_on_amounts_fy4 text,
    intrest_accured_on_amounts_fy5 text,
    intrest_accured_on_amounts_fy6 text,
    intrest_accured_on_amounts_fy7 text,
    intrest_accured_on_amounts_fytotal text,
    app_money_due_for_refund_fy1 integer,
    app_money_due_for_refund_fy2 integer,
    app_money_due_for_refund_fy3 integer,
    app_money_due_for_refund_fy4 integer,
    app_money_due_for_refund_fy5 integer,
    app_money_due_for_refund_fy6 integer,
    app_money_due_for_refund_fy7 integer,
    app_money_due_for_refund_fytotal integer,
    matured_deposit_with_companey_fy1 integer,
    matured_deposit_with_companey_fy2 integer,
    matured_deposit_with_companey_fy3 integer,
    matured_deposit_with_companey_fy4 integer,
    matured_deposit_with_companey_fy5 integer,
    matured_deposit_with_companey_fy6 integer,
    matured_deposit_with_companey_fy7 integer,
    matured_deposit_with_companey_fytotal integer,
    matured_debentures_with_companey_fy1 integer,
    matured_debentures_with_companey_fy2 integer,
    matured_debentures_with_companey_fy3 integer,
    matured_debentures_with_companey_fy4 integer,
    matured_debentures_with_companey_fy5 integer,
    matured_debentures_with_companey_fy6 integer,
    matured_debentures_with_companey_fy7 integer,
    matured_debentures_with_companey_fy8 integer,
    fractional_shares_fy1 integer,
    fractional_shares_fy2 integer,
    fractional_shares_fy3 integer,
    fractional_shares_fy4 integer,
    fractional_shares_fy5 integer,
    fractional_shares_fy6 integer,
    fractional_shares_fy7 integer,
    fractional_shares_fytotal integer,
    redemption_amount_fy1 integer,
    redemption_amount_fy2 integer,
    redemption_amount_fy3 integer,
    redemption_amount_fy4 integer,
    redemption_amount_fy5 integer,
    redemption_amount_fy6 integer,
    redemption_amount_fy7 integer,
    redemption_amount_fytotal integer,
    others_fy1 integer,
    others_fy2 integer,
    others_fy3 integer,
    others_fy4 integer,
    others_fy5 integer,
    others_fy6 integer,
    others_fy7 integer,
    others_fytotal integer,
    total_fy1 integer,
    total_fy2 integer,
    total_fy3 integer,
    total_fy4 integer,
    total_fy5 integer,
    total_fy6 integer,
    total_fy7 integer,
    total_fyamt integer,
    dividend_declaired_on_shares integer,
    other_benefits_declaired integer,
    investor_file text,
    nodal_appointment text,
    attachment_file text,
    resolution_number text,
    resolution_date timestamp without time zone,
    declaration_designation text,
    declaration_membership_no text,
    din_memebers text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_iepf2 OWNER TO postgres;

--
-- TOC entry 392 (class 1259 OID 222810)
-- Name: tbl_iepf2_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_iepf2_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_iepf2_id_seq OWNER TO postgres;

--
-- TOC entry 6223 (class 0 OID 0)
-- Dependencies: 392
-- Name: tbl_iepf2_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_iepf2_id_seq OWNED BY public.tbl_iepf2.id;


--
-- TOC entry 374 (class 1259 OID 222047)
-- Name: tbl_iepf5; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_iepf5 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    applicant_category text,
    applicant_first_name text,
    applicant_middle_name text,
    applicant_last_name text,
    applicant_fathers_first_name text,
    applicant_fathers_middle_name text,
    applicant_fathers_last_name text,
    applicant_dob timestamp without time zone,
    type_of_entity text,
    entity_identification_no text,
    entity_name text,
    entity_incorporate_date timestamp without time zone,
    applicant_address text,
    applicant_phone_no text,
    applicant_mobile_no text,
    applicant_mobile_otp text,
    applicant_email_id text,
    applicant_email_otp text,
    applicant_aadhar_no text,
    aadhaar_attach text,
    passport text,
    passport_attach text,
    applicant_pan text,
    bcin text,
    company_name_bank text,
    company_reg_office_address text,
    company_email_id text,
    covered_rules text,
    security_holder_name text,
    security_holder_relation text,
    no_nominee text,
    death_certificate text,
    will_certificate text,
    no_objection_certificate text,
    indemnity text,
    other_doc text,
    claim_type text,
    number_of_folio text,
    number_of_claims text,
    bank_account_number text,
    bank_name text,
    ifsc_code text,
    bank_branch text,
    demat_account_number text,
    clients_list text,
    entitle text,
    cheque text,
    attachment_file text,
    declaration boolean,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_iepf5 OWNER TO postgres;

--
-- TOC entry 373 (class 1259 OID 222046)
-- Name: tbl_iepf5_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_iepf5_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_iepf5_id_seq OWNER TO postgres;

--
-- TOC entry 6224 (class 0 OID 0)
-- Dependencies: 373
-- Name: tbl_iepf5_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_iepf5_id_seq OWNED BY public.tbl_iepf5.id;


--
-- TOC entry 387 (class 1259 OID 222491)
-- Name: tbl_inc12; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc12 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    company_type text,
    category text,
    sub_category text,
    company_capital text,
    authorized_capital text,
    division text,
    division_description text,
    proposed_conversion text,
    proposed_main_division_description text,
    application_grounds text,
    attachment_approval_noc text,
    attachment_assets_liabilities text,
    attachment_board_resolution text,
    optional_attachment text,
    authorized_person_name text,
    resolution_number text,
    resolution_date timestamp without time zone,
    signitory text,
    din_director text,
    membership_number text,
    declaration_compliance boolean,
    declaration_truthfulness boolean,
    declaration_moa_aoa boolean,
    professional_declaration_moa_aoa boolean,
    professional_declaration_compliance boolean,
    professional_category text,
    whether_associate_fellow text,
    designation text,
    name_of_pcs text,
    directors_number text,
    first_designation text,
    first_din text,
    first_name text,
    first_company text,
    second_designation text,
    second_din text,
    second_name text,
    second_company text,
    managerial_key text,
    articles_entrenched text,
    no_of_articles text,
    period_year1 text,
    estimated_income_year1 text,
    estimated_expenditure_year1 text,
    estimated_surplus_year1 text,
    remarks_year1 text,
    period_year2 text,
    estimated_income_year2 text,
    estimated_expenditure_year2 text,
    estimated_surplus_year2 text,
    remarks_year2 text,
    period_year3 text,
    estimated_income_year3 text,
    estimated_expenditure_year3 text,
    estimated_surplus_year3 text,
    remarks_year3 text,
    resolution_meeting_type text,
    date_of_passing timestamp without time zone,
    mode_of_resolution text,
    votes_in_favour text,
    votes_against text,
    srn_mgt14 text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_inc12 OWNER TO postgres;

--
-- TOC entry 386 (class 1259 OID 222490)
-- Name: tbl_inc12_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc12_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc12_id_seq OWNER TO postgres;

--
-- TOC entry 6225 (class 0 OID 0)
-- Dependencies: 386
-- Name: tbl_inc12_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc12_id_seq OWNED BY public.tbl_inc12.id;


--
-- TOC entry 305 (class 1259 OID 196619)
-- Name: tbl_inc20a; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc20a (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    longitude numeric,
    latitude numeric,
    is_regulated_by_sector text,
    regulator_name text,
    other_regulator_name text,
    letter_number text,
    approval_date timestamp without time zone,
    number_of_shareholders integer,
    resolution_number integer,
    resolution_date timestamp without time zone,
    director integer,
    director_din text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_inc20a OWNER TO postgres;

--
-- TOC entry 304 (class 1259 OID 196618)
-- Name: tbl_inc20a_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc20a_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc20a_id_seq OWNER TO postgres;

--
-- TOC entry 6226 (class 0 OID 0)
-- Dependencies: 304
-- Name: tbl_inc20a_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc20a_id_seq OWNED BY public.tbl_inc20a.id;


--
-- TOC entry 286 (class 1259 OID 180947)
-- Name: tbl_inc22; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc22 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    purpose_of_filing text,
    registered_office_date timestamp without time zone,
    address_line1 text,
    address_line2 text,
    country text,
    pin_code text,
    area_locality text,
    city text,
    district text,
    state_ut text,
    longitude text,
    latitude text,
    declarant_name text,
    designation text,
    designation2 text,
    resolution_number text,
    resolution_date timestamp without time zone,
    director_name text,
    identification_number text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_inc22 OWNER TO postgres;

--
-- TOC entry 285 (class 1259 OID 180946)
-- Name: tbl_inc22_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc22_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc22_id_seq OWNER TO postgres;

--
-- TOC entry 6227 (class 0 OID 0)
-- Dependencies: 285
-- Name: tbl_inc22_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc22_id_seq OWNED BY public.tbl_inc22.id;


--
-- TOC entry 381 (class 1259 OID 222347)
-- Name: tbl_inc23; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc23 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    fillig_purpose text,
    filed_mgt14 text,
    request_number text,
    state text,
    office_roc text,
    reason_shifting_office text,
    is_objections text,
    english_advertisement_date timestamp without time zone,
    vernacular_advertisement_date timestamp without time zone,
    brief_objection text,
    prosecution text,
    prosecution_details text,
    inquiry boolean,
    inspection boolean,
    investigation boolean,
    inspection_details text,
    application_copy text,
    service_acknowledgement_date timestamp without time zone,
    pending_application text,
    pending_application_details text,
    attorney text,
    newspaper_adv text,
    authority_proof text,
    resolution_number text,
    resolution_date text,
    attachment_declaration boolean,
    attachment_declaration2 boolean,
    authority_declaration boolean,
    payment_declaration boolean,
    jurisdiction_declaration boolean,
    shifting_declaration boolean,
    enquiry_declaration boolean,
    declaration_designation text,
    signatory text,
    din text
);


ALTER TABLE public.tbl_inc23 OWNER TO postgres;

--
-- TOC entry 380 (class 1259 OID 222346)
-- Name: tbl_inc23_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc23_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc23_id_seq OWNER TO postgres;

--
-- TOC entry 6228 (class 0 OID 0)
-- Dependencies: 380
-- Name: tbl_inc23_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc23_id_seq OWNED BY public.tbl_inc23.id;


--
-- TOC entry 308 (class 1259 OID 196716)
-- Name: tbl_inc28; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc28 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    order_passed_by text,
    court_name text,
    central_gov_office_name text,
    debt_recovery_tribunal_name text,
    competent_authority_name text,
    location text,
    petition_number text,
    order_number text,
    date_of_passing_order timestamp without time zone,
    relevant_act text,
    order_filling_days text,
    application_date timestamp without time zone,
    certified_copy_date timestamp without time zone,
    due_date_registrar timestamp without time zone,
    board_resolution_number text,
    board_resolution_date timestamp without time zone,
    director_dsc text,
    director_din text,
    category_time text,
    name_of_pcs text,
    whether_associate text,
    membership_number text
);


ALTER TABLE public.tbl_inc28 OWNER TO postgres;

--
-- TOC entry 307 (class 1259 OID 196715)
-- Name: tbl_inc28_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc28_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc28_id_seq OWNER TO postgres;

--
-- TOC entry 6229 (class 0 OID 0)
-- Dependencies: 307
-- Name: tbl_inc28_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc28_id_seq OWNED BY public.tbl_inc28.id;


--
-- TOC entry 414 (class 1259 OID 223588)
-- Name: tbl_inc4; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_inc4 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    purpose text,
    withdrwal_nominee_name text,
    withdrawl_subscriber_name text,
    withdrawl_date timestamp without time zone,
    subscriber_name text,
    member_company_name text,
    first_name text,
    middle_name text,
    last_name text,
    intimation_date timestamp without time zone,
    nominee_name text,
    cessation_subscr_name text,
    cess_company_name text,
    cesstion_date timestamp without time zone,
    due_reason text,
    cessation_first_name text,
    cessation_midd_name text,
    cessation_last_name text,
    sole_member text,
    change_nominee_scr_name text,
    either_member_or_new text,
    nominee_company text,
    nominee_first_name text,
    nominee_midname text,
    nominee_last_name text,
    nominee_date timestamp without time zone,
    nominee_din text,
    first_name_of_din text,
    mid_name_of_din text,
    sur_name_of_din text,
    father_first_name text,
    father_mid_name_of_din text,
    father_surname text,
    father_gender text,
    father_dob timestamp without time zone,
    nationality text,
    nominee_pan text,
    place_of_birth text,
    occupation text,
    occupation_area text,
    qualification text,
    line1 text,
    line2 text,
    country text,
    pin_code text,
    area_locality text,
    city text,
    district text,
    state text,
    phone text,
    mobile text,
    fax text,
    email_id text,
    whether_address_same text,
    present_line1 text,
    present_line2 text,
    present_country text,
    present_pin_code text,
    present_area_locality text,
    present_city text,
    present_district text,
    present_state text,
    present_address text,
    presentaddressyears text,
    identity_proof text,
    identity_proof_no text,
    identity_prf_doc text,
    residental_proof text,
    residental_proof_no text,
    residental_proof_doc text,
    declarant_nominee_name text,
    declarant_company_name text,
    event_death text,
    optional_attachment text,
    pan text,
    designation text,
    signatory text,
    din text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_inc4 OWNER TO postgres;

--
-- TOC entry 413 (class 1259 OID 223587)
-- Name: tbl_inc4_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_inc4_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_inc4_id_seq OWNER TO postgres;

--
-- TOC entry 6230 (class 0 OID 0)
-- Dependencies: 413
-- Name: tbl_inc4_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_inc4_id_seq OWNED BY public.tbl_inc4.id;


--
-- TOC entry 476 (class 1259 OID 231956)
-- Name: tbl_litigation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_litigation (
    id integer NOT NULL,
    parent_id integer,
    litigation_pending_act text,
    name_of_authority text,
    case_number text,
    subject_matter text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_litigation OWNER TO postgres;

--
-- TOC entry 475 (class 1259 OID 231955)
-- Name: tbl_litigation_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_litigation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_litigation_id_seq OWNER TO postgres;

--
-- TOC entry 6231 (class 0 OID 0)
-- Dependencies: 475
-- Name: tbl_litigation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_litigation_id_seq OWNED BY public.tbl_litigation.id;


--
-- TOC entry 320 (class 1259 OID 204781)
-- Name: tbl_meeting; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_meeting (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    type text,
    agm_fy text,
    agm_number integer,
    eogm_requisition text,
    date_notice timestamp without time zone,
    date_meeting timestamp without time zone,
    time_meeting text,
    commencement_meeting text,
    number_meeting integer,
    person_signing_notice text,
    signing_meeting_place text,
    meeting_mode text,
    office_yes_no text,
    name_dir text,
    designation_dir text,
    gender text,
    last_date timestamp without time zone,
    phone_no text,
    email_id text,
    advance_consent_date timestamp without time zone,
    meeting_venue text,
    venue_address text,
    venue_state text,
    venue_city text,
    venue_pincode text,
    signing_director text,
    roc_address text,
    signing_date text,
    signing_place text,
    query_registration_date timestamp without time zone,
    query_registration_time text,
    query_registration_email text,
    director_attend_electronically text,
    special_invitee text,
    create_general_meeting text,
    type_of_meeting text,
    existing_agm text,
    existing_egm text,
    general_meeting_date timestamp without time zone,
    general_meeting_time text,
    agm_number_str text,
    egm_place text,
    authorized_signatory_1 text,
    authorized_signatory_2 text,
    chairperson_director text,
    chairperson_member text,
    chairperson_chairperson text,
    chairperson_type text,
    chairperson_role text,
    meeting_time_concluded text,
    entry_in_minutes_book_date timestamp without time zone,
    signing_minutes_place text,
    signing_minutes_date timestamp without time zone,
    signing_attendance_place text,
    signing_attendance_date timestamp without time zone,
    authorized_person_in_minutes text,
    authorized_person_in_minutes_details text,
    draft_minutes_circulated text,
    communicated_comments text,
    signed_minutes_circulated text,
    ack_draft_url text,
    ack_signed_url text,
    ack_notice_url text,
    reg_att_url text,
    meet_dir_url text,
    notice_url text,
    minutes_url text,
    ctc_url text
);


ALTER TABLE public.tbl_meeting OWNER TO postgres;

--
-- TOC entry 313 (class 1259 OID 197007)
-- Name: tbl_meeting_circulation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_meeting_circulation (
    id integer NOT NULL,
    parent_id integer,
    type text,
    c_director text,
    c_date timestamp without time zone,
    c_receipt_date timestamp without time zone,
    c_mode text,
    c_other text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_meeting_circulation OWNER TO postgres;

--
-- TOC entry 312 (class 1259 OID 197006)
-- Name: tbl_meeting_circulation_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_meeting_circulation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_meeting_circulation_id_seq OWNER TO postgres;

--
-- TOC entry 6232 (class 0 OID 0)
-- Dependencies: 312
-- Name: tbl_meeting_circulation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_meeting_circulation_id_seq OWNED BY public.tbl_meeting_circulation.id;


--
-- TOC entry 315 (class 1259 OID 197016)
-- Name: tbl_meeting_communicate_comment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_meeting_communicate_comment (
    id integer NOT NULL,
    parent_id integer,
    cc_received_on timestamp without time zone,
    cc_director text,
    cc_comment text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_meeting_communicate_comment OWNER TO postgres;

--
-- TOC entry 314 (class 1259 OID 197015)
-- Name: tbl_meeting_communicate_comment_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_meeting_communicate_comment_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_meeting_communicate_comment_id_seq OWNER TO postgres;

--
-- TOC entry 6233 (class 0 OID 0)
-- Dependencies: 314
-- Name: tbl_meeting_communicate_comment_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_meeting_communicate_comment_id_seq OWNED BY public.tbl_meeting_communicate_comment.id;


--
-- TOC entry 319 (class 1259 OID 204780)
-- Name: tbl_meeting_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_meeting_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_meeting_id_seq OWNER TO postgres;

--
-- TOC entry 6234 (class 0 OID 0)
-- Dependencies: 319
-- Name: tbl_meeting_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_meeting_id_seq OWNED BY public.tbl_meeting.id;


--
-- TOC entry 436 (class 1259 OID 230317)
-- Name: tbl_meeting_resolution; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_meeting_resolution (
    id integer NOT NULL,
    meeting integer,
    resolution integer,
    action integer,
    sequence_no integer
);


ALTER TABLE public.tbl_meeting_resolution OWNER TO postgres;

--
-- TOC entry 435 (class 1259 OID 230316)
-- Name: tbl_meeting_resolution_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_meeting_resolution_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_meeting_resolution_id_seq OWNER TO postgres;

--
-- TOC entry 6236 (class 0 OID 0)
-- Dependencies: 435
-- Name: tbl_meeting_resolution_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_meeting_resolution_id_seq OWNED BY public.tbl_meeting_resolution.id;


--
-- TOC entry 311 (class 1259 OID 196998)
-- Name: tbl_meeting_special_invitee; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_meeting_special_invitee (
    id integer NOT NULL,
    parent_id integer,
    si_name text,
    si_designation text,
    si_org text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_meeting_special_invitee OWNER TO postgres;

--
-- TOC entry 310 (class 1259 OID 196997)
-- Name: tbl_meeting_special_invitee_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_meeting_special_invitee_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_meeting_special_invitee_id_seq OWNER TO postgres;

--
-- TOC entry 6238 (class 0 OID 0)
-- Dependencies: 310
-- Name: tbl_meeting_special_invitee_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_meeting_special_invitee_id_seq OWNED BY public.tbl_meeting_special_invitee.id;


--
-- TOC entry 322 (class 1259 OID 204998)
-- Name: tbl_mgt14; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mgt14 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    designation text,
    din text,
    resolution_number integer,
    resolution_date timestamp without time zone,
    category_type text,
    company_secretary text,
    whether_assosiate_or_fellow text,
    membership_number integer,
    resolution_copy text,
    optional_attatchment text,
    resolution boolean,
    agreement boolean,
    postal_ballot boolean,
    notice_dispatch_date timestamp without time zone,
    passing_resolution_date timestamp without time zone,
    dispatch_ballot_date timestamp without time zone,
    postal_ballot_resolutiont_date timestamp without time zone,
    number_of_resolution integer,
    agreement_date timestamp without time zone,
    companies_act text,
    agreement_purpose text,
    agreement_subject text,
    authority text,
    srn text,
    resolution_purpose text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_mgt14 OWNER TO postgres;

--
-- TOC entry 321 (class 1259 OID 204997)
-- Name: tbl_mgt14_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mgt14_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mgt14_id_seq OWNER TO postgres;

--
-- TOC entry 6239 (class 0 OID 0)
-- Dependencies: 321
-- Name: tbl_mgt14_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mgt14_id_seq OWNED BY public.tbl_mgt14.id;


--
-- TOC entry 341 (class 1259 OID 221388)
-- Name: tbl_mgt6; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mgt6 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    filed_registered integer,
    section89 text,
    person_declare text,
    attachment_add text,
    attachment_file text,
    resolution_date timestamp without time zone,
    declaration_designation text,
    declaration_membership_no text,
    din_memebers text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_mgt6 OWNER TO postgres;

--
-- TOC entry 340 (class 1259 OID 221387)
-- Name: tbl_mgt6_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mgt6_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mgt6_id_seq OWNER TO postgres;

--
-- TOC entry 6240 (class 0 OID 0)
-- Dependencies: 340
-- Name: tbl_mgt6_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mgt6_id_seq OWNED BY public.tbl_mgt6.id;


--
-- TOC entry 470 (class 1259 OID 231854)
-- Name: tbl_mgt7a; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mgt7a (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    company_gln text,
    pan text,
    company_date_incorporation timestamp without time zone,
    company_website text,
    telephone text,
    type_of_company text,
    category_company text,
    sub_category_company text,
    company_share_capital text,
    form_filed text,
    financial_year_from text,
    financial_year_to text,
    annual_general_meeting text,
    date_amg timestamp without time zone,
    due_date_amg timestamp without time zone,
    extension_agm text,
    srn_application_extention text,
    due_date_agm2 timestamp without time zone,
    reasons_specify text,
    turn_over text,
    net_worth text,
    total_auth numeric,
    total_iss numeric,
    total_sub numeric,
    total_paid numeric,
    total_auth_amount numeric,
    total_iss_amount numeric,
    total_sub_amount numeric,
    total_paid_amount numeric,
    preference_shares_authorized_count numeric,
    preference_shares_issued_count numeric,
    preference_shares_subscribed_count numeric,
    preference_shares_paid_up_count numeric,
    preference_shares_authorized_amount numeric,
    preference_shares_issued_amount numeric,
    preference_shares_subscribed_amount numeric,
    preference_shares_paid_up_amount numeric,
    share_capital numeric,
    equity_shares_at_beginning_number_of_shares numeric,
    equity_shares_at_beginning_nominal_amount numeric,
    equity_shares_at_beginning_paid_up_amount numeric,
    equity_shares_at_beginning_premium numeric,
    equity_shares_increase_number_of_shares numeric,
    equity_shares_increase_nominal_amount numeric,
    equity_shares_increase_paid_up_amount numeric,
    equity_shares_increase_premium numeric,
    public_issues_number_of_shares numeric,
    public_issues_nominal_amount numeric,
    public_issues_paid_up_amount numeric,
    public_issues_premium numeric,
    rights_issue_number_of_shares numeric,
    rights_issue_nominal_amount numeric,
    rights_issue_paid_up_amount numeric,
    rights_issue_premium numeric,
    bonus_issue_number_of_shares numeric,
    bonus_issue_nominal_amount numeric,
    bonus_issue_paid_up_amount numeric,
    bonus_issue_premium numeric,
    private_placement_number_of_shares numeric,
    private_placement_nominal_amount numeric,
    private_placement_paid_up_amount numeric,
    private_placement_premium numeric,
    esops_number_of_shares numeric,
    esops_nominal_amount numeric,
    esops_paid_up_amount numeric,
    esops_premium numeric,
    sweat_equity_number_of_shares numeric,
    sweat_equity_nominal_amount numeric,
    sweat_equity_paid_up_amount numeric,
    sweat_equity_premium numeric,
    preference_conversion_number_of_shares numeric,
    preference_conversion_nominal_amount numeric,
    preference_conversion_paid_up_amount numeric,
    preference_conversion_premium numeric,
    debenture_conversion_number_of_shares numeric,
    debenture_conversion_nominal_amount numeric,
    debenture_conversion_paid_up_amount numeric,
    debenture_conversion_premium numeric,
    gdr_adr_number_of_shares numeric,
    gdr_adr_nominal_amount numeric,
    gdr_adr_paid_up_amount numeric,
    gdr_adr_premium numeric,
    other_equity_description text,
    other_equity_number_of_shares numeric,
    other_equity_nominal_amount numeric,
    other_equity_paid_up_amount numeric,
    other_equity_premium numeric,
    equity_shares_decrease_number_of_shares numeric,
    equity_shares_decrease_nominal_amount numeric,
    equity_shares_decrease_paid_up_amount numeric,
    equity_shares_decrease_premium numeric,
    buy_back_number_of_shares numeric,
    buy_back_nominal_amount numeric,
    buy_back_paid_up_amount numeric,
    buy_back_premium numeric,
    forfeited_shares_number_of_shares numeric,
    forfeited_shares_nominal_amount numeric,
    forfeited_shares_paid_up_amount numeric,
    forfeited_shares_premium numeric,
    capital_reduction_number_of_shares numeric,
    capital_reduction_nominal_amount numeric,
    capital_reduction_paid_up_amount numeric,
    capital_reduction_premium numeric,
    other_decrease_description text,
    other_decrease_number_of_shares numeric,
    other_decrease_nominal_amount numeric,
    other_decrease_paid_up_amount numeric,
    other_decrease_premium numeric,
    equity_shares_at_end_number_of_shares numeric,
    equity_shares_at_end_nominal_amount numeric,
    equity_shares_at_end_paid_up_amount numeric,
    equity_shares_at_end_premium numeric,
    preference_shares_at_beginning_number_of_shares numeric,
    preference_shares_at_beginning_nominal_amount numeric,
    preference_shares_at_beginning_paid_up_amount numeric,
    preference_shares_at_beginning_premium numeric,
    preference_shares_increase_number_of_shares numeric,
    preference_shares_increase_nominal_amount numeric,
    preference_shares_increase_paid_up_amount numeric,
    preference_shares_increase_premium numeric,
    preference_shares_issued_number_of_shares numeric,
    preference_shares_issued_nominal_amount numeric,
    preference_shares_issued_paid_up_amount numeric,
    preference_shares_issued_premium numeric,
    preference_shares_reissued_number_of_shares numeric,
    preference_shares_reissued_nominal_amount numeric,
    preference_shares_reissued_paid_up_amount numeric,
    preference_shares_reissued_premium numeric,
    other_preference_increase_description text,
    other_preference_increase_number_of_shares numeric,
    other_preference_increase_nominal_amount numeric,
    other_preference_increase_paid_up_amount numeric,
    other_preference_increase_premium numeric,
    preference_shares_decrease_number_of_shares numeric,
    preference_shares_decrease_nominal_amount numeric,
    preference_shares_decrease_paid_up_amount numeric,
    preference_shares_decrease_premium numeric,
    preference_shares_redeemed_number_of_shares numeric,
    preference_shares_redeemed_nominal_amount numeric,
    preference_shares_redeemed_paid_up_amount numeric,
    preference_shares_redeemed_premium numeric,
    preference_shares_forfeited_number_of_shares numeric,
    preference_shares_forfeited_nominal_amount numeric,
    preference_shares_forfeited_paid_up_amount numeric,
    preference_shares_forfeited_premium numeric,
    preference_capital_reduction_number_of_shares numeric,
    preference_capital_reduction_nominal_amount numeric,
    preference_capital_reduction_paid_up_amount numeric,
    preference_capital_reduction_premium numeric,
    other_preference_decrease_description text,
    other_preference_decrease_number_of_shares numeric,
    other_preference_decrease_nominal_amount numeric,
    other_preference_decrease_paid_up_amount numeric,
    other_preference_decrease_premium numeric,
    preference_shares_at_end_number_of_shares numeric,
    preference_shares_at_end_nominal_amount numeric,
    preference_shares_at_end_paid_up_amount numeric,
    preference_shares_at_end_premium numeric,
    is_nil boolean,
    details_provided_in_digital_media text,
    seprate_sheet_transfers text,
    previous_annual_meeting_date timestamp without time zone,
    debentures_number_of_units numeric,
    nominal_value_per_unit numeric,
    deb_total_unit1 numeric,
    partly_convertible_debentures_number_of_units numeric,
    partly_convertible_debentures_nominal_value numeric,
    partly_convertible_debentures_total_value numeric,
    fully_convertible_debentures_number_of_units numeric,
    fully_convertible_debentures_nominal_value_per_unit numeric,
    fully_convertible_debentures_total_value numeric,
    total_debentures_number_of_units numeric,
    total_debentures_nominal_value_per_unit numeric,
    total_debentures_total_value numeric,
    non_convertible_debentures_outstanding_at_beginning numeric,
    non_convertible_debentures_increase_during_year numeric,
    non_convertible_debentures_decrease_during_year numeric,
    non_convertible_debentures_outstanding_at_end numeric,
    partly_convertible_debentures_outstanding_at_beginning numeric,
    partly_convertible_debentures_increase_during_year numeric,
    partly_convertible_debentures_decrease_during_year numeric,
    partly_convertible_debentures_outstanding_at_end numeric,
    fully_convertible_debentures_outstanding_at_beginning numeric,
    fully_convertible_debentures_increase_during_year numeric,
    fully_convertible_debentures_decrease_during_year numeric,
    fully_convertible_debentures_outstanding_at_end numeric,
    ind_eqt_num numeric,
    ind_eqt_pre numeric,
    ind_pre_num numeric,
    ind_pre_pre numeric,
    nri_eqt_num numeric,
    nri_eqt_pre numeric,
    nri_pre_num numeric,
    nri_pre_pre numeric,
    oth_eqt_num numeric,
    oth_eqt_pre numeric,
    oth_pre_num numeric,
    oth_pre_pre numeric,
    cgov_eqt_num numeric,
    cgov_eqt_pre numeric,
    cgov_pre_num numeric,
    cgov_pre_pre numeric,
    sgov_eqt_num numeric,
    sgov_eqt_pre numeric,
    sgov_pre_num numeric,
    sgov_pre_pre numeric,
    govcom_eqt_num numeric,
    govcom_eqt_pre numeric,
    govcom_pre_num numeric,
    govcom_pre_pre numeric,
    insur_eqt_num numeric,
    insur_eqt_pre numeric,
    insur_pre_num numeric,
    insur_pre_pre numeric,
    banks_eqt_num numeric,
    banks_eqt_pre numeric,
    banks_pre_num numeric,
    banks_pre_pre numeric,
    finist_eqt_num numeric,
    finist_eqt_pre numeric,
    finist_pre_num numeric,
    finist_pre_pre numeric,
    fit_eqt_num numeric,
    fit_eqt_pre numeric,
    fit_pre_num numeric,
    fit_pre_pre numeric,
    mf_eqt_num numeric,
    mf_eqt_pre numeric,
    mf_pre_num numeric,
    mf_pre_pre numeric,
    vc_eqt_num numeric,
    vc_eqt_pre numeric,
    vc_pre_num numeric,
    vc_pre_pre numeric,
    corp_eqt_num numeric,
    corp_eqt_pre numeric,
    corp_pre_num numeric,
    corp_pre_pre numeric,
    other_eqt_num numeric,
    other_eqt_pre numeric,
    other_pre_num numeric,
    other_pre_pre numeric,
    total_eqt_num numeric,
    total_eqt_pre numeric,
    total_pre_num numeric,
    total_pre_pre numeric,
    numbers_promoters numeric,
    ind_eqt_num_pub numeric,
    ind_eqt_pre_pub numeric,
    ind_pre_num_pub numeric,
    ind_pre_pre_pub numeric,
    nri_eqt_num_pub numeric,
    nri_eqt_pre_pub numeric,
    nri_pre_num_pub numeric,
    nri_pre_pre_pub numeric,
    oth_eqt_num_pub numeric,
    oth_eqt_pre_pub numeric,
    oth_pre_num_pub numeric,
    oth_pre_pre_pub numeric,
    cgov_eqt_num_pub numeric,
    cgov_eqt_pre_pub numeric,
    cgov_pre_num_pub numeric,
    cgov_pre_pre_pub numeric,
    sgov_eqt_num_pub numeric,
    sgov_eqt_pre_pub numeric,
    sgov_pre_num_pub numeric,
    sgov_pre_pre_pub numeric,
    govcom_eqt_num_pub numeric,
    govcom_eqt_pre_pub numeric,
    govcom_pre_num_pub numeric,
    govcom_pre_pre_pub numeric,
    insur_eqt_num_pub numeric,
    insur_eqt_pre_pub numeric,
    insur_pre_num_pub numeric,
    insur_pre_pre_pub numeric,
    banks_eqt_num_pub numeric,
    banks_eqt_pre_pub numeric,
    banks_pre_num_pub numeric,
    banks_pre_pre_pub numeric,
    finist_eqt_num_pub numeric,
    finist_eqt_pre_pub numeric,
    finist_pre_num_pub numeric,
    finist_pre_pre_pub numeric,
    fit_eqt_num_pub numeric,
    fit_eqt_pre_pub numeric,
    fit_pre_num_pub numeric,
    fit_pre_pre_pub numeric,
    mf_eqt_num_pub numeric,
    mf_eqt_pre_pub numeric,
    mf_pre_num_pub numeric,
    mf_pre_pre_pub numeric,
    vc_eqt_num_pub numeric,
    vc_eqt_pre_pub numeric,
    vc_pre_num_pub numeric,
    vc_pre_pre_pub numeric,
    corp_eqt_num_pub numeric,
    corp_eqt_pre_pub numeric,
    corp_pre_num_pub numeric,
    corp_pre_pre_pub numeric,
    other_eqt_num_pub numeric,
    other_eqt_pre_pub numeric,
    other_pre_num_pub numeric,
    other_pre_pre_pub numeric,
    total_eqt_num_pub numeric,
    total_eqt_pre_pub numeric,
    total_pre_num_pub numeric,
    total_pre_pre_pub numeric,
    numbers_promoters_pub numeric,
    num_of_promoters numeric,
    num_of_promoters1 numeric,
    num_of_members numeric,
    num_of_members1 numeric,
    num_of_deb numeric,
    num_of_deb1 numeric,
    complince_made text,
    reason text,
    resolution_number text,
    resolution_date timestamp without time zone,
    signed text,
    din_pan text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_mgt7a OWNER TO postgres;

--
-- TOC entry 469 (class 1259 OID 231853)
-- Name: tbl_mgt7a_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mgt7a_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mgt7a_id_seq OWNER TO postgres;

--
-- TOC entry 6241 (class 0 OID 0)
-- Dependencies: 469
-- Name: tbl_mgt7a_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mgt7a_id_seq OWNED BY public.tbl_mgt7a.id;


--
-- TOC entry 440 (class 1259 OID 230431)
-- Name: tbl_mgt8; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mgt8 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    financial_year text,
    firm_name text,
    signing_pcs text,
    membership_no text,
    certificate text,
    designation text,
    udin text,
    date_of_signing timestamp without time zone,
    place_of_signing text,
    format_transaction text,
    annual_return boolean,
    status boolean,
    maintenance boolean,
    filling_of_forms boolean,
    commitees_members boolean,
    register_of_members boolean,
    advances_and_loans boolean,
    related_party_contracts boolean,
    issue_or_allotments boolean,
    keeping_in_abeyance boolean,
    declaration boolean,
    signing_of_audited boolean,
    constitution boolean,
    filling_up_casual boolean,
    approvals_required boolean,
    repayment_of_deposits boolean,
    borrowings boolean,
    investements_or_guarantees boolean,
    alteration_provisions boolean,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_mgt8 OWNER TO postgres;

--
-- TOC entry 439 (class 1259 OID 230430)
-- Name: tbl_mgt8_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mgt8_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mgt8_id_seq OWNER TO postgres;

--
-- TOC entry 6242 (class 0 OID 0)
-- Dependencies: 439
-- Name: tbl_mgt8_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mgt8_id_seq OWNED BY public.tbl_mgt8.id;


--
-- TOC entry 438 (class 1259 OID 230416)
-- Name: tbl_mgt9; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mgt9 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    financial_year text,
    is_registrar_agent text DEFAULT 'no'::text,
    registrar_agent_name text,
    registrar_agent_address text,
    registrar_agent_phone text,
    registrar_agent_email text,
    no_of_business numeric,
    no_of_holding numeric,
    secured_principal_beg numeric,
    unsecured_principal_beg numeric,
    deposit_principal_beg numeric,
    total_principal_beg numeric,
    secured_interest_due_beg numeric,
    unsecured_interest_due_beg numeric,
    deposit_interest_due_beg numeric,
    total_interest_due_beg numeric,
    secured_interest_accrued_beg numeric,
    unsecured_interest_accrued_beg numeric,
    deposit_interest_accrued_beg numeric,
    total_interest_accrued_beg numeric,
    total_secured_beg numeric,
    total_unsecured_beg numeric,
    total_deposit_beg numeric,
    total_beg numeric,
    secured_addition_beg numeric,
    unsecured_addition_beg numeric,
    deposit_addition_beg numeric,
    total_addition_beg numeric,
    secured_reduction_beg numeric,
    unsecured_reduction_beg numeric,
    deposit_reduction_beg numeric,
    total_reduction_beg numeric,
    secured_net_change numeric,
    unsecured_net_change numeric,
    deposit_net_change numeric,
    total_net_change numeric,
    secured_principal_end numeric,
    unsecured_principal_end numeric,
    deposit_principal_end numeric,
    total_principal_end numeric,
    secured_interest_due_end numeric,
    unsecured_interest_due_end numeric,
    deposit_interest_due_end numeric,
    total_interest_due_end numeric,
    secured_interest_accrued_end numeric,
    unsecured_interest_accrued_end numeric,
    deposit_interest_accrued_end numeric,
    total_interest_accrued_end numeric,
    total_secured_end numeric,
    total_unsecured_end numeric,
    total_deposit_end numeric,
    total_end numeric,
    is_remuneration text DEFAULT 'Not Applicable'::text,
    no_of_persons numeric,
    is_remuneration_other text DEFAULT 'Not Applicable'::text,
    no_of_independent_directors numeric,
    no_of_non_executive_directors numeric,
    over_all_ceiling text,
    is_remuneration_other_kmp text DEFAULT 'Not Applicable'::text,
    ceo_name text,
    ceo_salary numeric,
    ceo_stock numeric,
    ceo_value numeric,
    ceo_sweat numeric,
    ceo_profit numeric,
    ceo_commisionper numeric,
    ceo_gross numeric,
    ceo_commision_other numeric,
    ceo_other_amount numeric,
    sec_name text,
    sec_salary numeric,
    sec_stock numeric,
    sec_value numeric,
    sec_sweat numeric,
    sec_profit numeric,
    sec_commisionper numeric,
    sec_gross numeric,
    sec_commision_other numeric,
    sec_other_amount numeric,
    cfo_name text,
    cfo_salary numeric,
    cfo_stock numeric,
    cfo_value numeric,
    cfo_sweat numeric,
    cfo_profit numeric,
    cfo_commisionper numeric,
    cfo_gross numeric,
    cfo_commisionother numeric,
    cfo_otheramount numeric,
    is_penalties text DEFAULT 'Not Applicable'::text,
    company_section_penalty text,
    company_descriptioin_penalty text,
    company_fees_penalty numeric,
    company_imposed_penalty text,
    company_detail_penalty text,
    company_section_punishment text,
    company_descriptioin_punishment text,
    company_fees_punishment numeric,
    company_imposed_punishment text,
    company_detail_punishment text,
    company_section_compounding text,
    company_descriptioin_compounding text,
    company_fees_compounding numeric,
    company_imposed_compounding text,
    company_detail_compounding text,
    director_section_penalty text,
    director_descriptioin_penalty text,
    director_fees_penalty numeric,
    director_imposed_penalty text,
    director_detail_penalty text,
    director_section_punishment text,
    director_descriptioin_punishment text,
    director_fees_punishment numeric,
    director_imposed_punishment text,
    director_detail_punishment text,
    director_section_compounding text,
    director_descriptioin_compounding text,
    director_fees_compounding numeric,
    director_imposed_compounding text,
    director_detail_compounding text,
    officer_section_penalty text,
    officer_descriptioin_penalty text,
    officer_fees_penalty numeric,
    officer_imposed_penalty text,
    officer_detail_penalty text,
    officer_section_punishment text,
    officer_descriptioin_punishment text,
    officer_dees_punishment numeric,
    officer_dmposed_punishment text,
    officer_detail_punishment text,
    officer_section_compounding text,
    officer_descriptioin_compounding text,
    officer_fees_compounding numeric,
    officer_imposed_compounding text,
    officer_detail_compounding text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_mgt9 OWNER TO postgres;

--
-- TOC entry 437 (class 1259 OID 230415)
-- Name: tbl_mgt9_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mgt9_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mgt9_id_seq OWNER TO postgres;

--
-- TOC entry 6243 (class 0 OID 0)
-- Dependencies: 437
-- Name: tbl_mgt9_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mgt9_id_seq OWNED BY public.tbl_mgt9.id;


--
-- TOC entry 296 (class 1259 OID 181133)
-- Name: tbl_mr1; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_mr1 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    public text,
    appointee_name text,
    appointee_din_pan text,
    appointee_designation text,
    appointee_resolution_date timestamp without time zone,
    appointee_appointment_date timestamp without time zone,
    remuneration_type text,
    remuneration_salary numeric,
    remuneration_perquisites numeric,
    remuneration_others numeric,
    remuneration_total numeric,
    appointment_from timestamp without time zone,
    appointment_to timestamp without time zone,
    age_over_70 text,
    convicted_detained text,
    non_resident text,
    approval_obtained text,
    srn_mr2 text,
    resolution_number text,
    resolution_date timestamp without time zone,
    designation text,
    officer_designation text,
    signatory_id text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_mr1 OWNER TO postgres;

--
-- TOC entry 295 (class 1259 OID 181132)
-- Name: tbl_mr1_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_mr1_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_mr1_id_seq OWNER TO postgres;

--
-- TOC entry 6244 (class 0 OID 0)
-- Dependencies: 295
-- Name: tbl_mr1_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_mr1_id_seq OWNED BY public.tbl_mr1.id;


--
-- TOC entry 347 (class 1259 OID 221506)
-- Name: tbl_msme; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_msme (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    company_pan text,
    return_type text,
    start_date timestamp without time zone,
    end_date timestamp without time zone,
    attachment_file text,
    declaration_designation text,
    declaration_membership_no text,
    din_members text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_msme OWNER TO postgres;

--
-- TOC entry 346 (class 1259 OID 221505)
-- Name: tbl_msme_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_msme_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_msme_id_seq OWNER TO postgres;

--
-- TOC entry 6245 (class 0 OID 0)
-- Dependencies: 346
-- Name: tbl_msme_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_msme_id_seq OWNED BY public.tbl_msme.id;


--
-- TOC entry 247 (class 1259 OID 180282)
-- Name: tbl_other_auditor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_other_auditor (
    category character varying,
    sub_category character varying,
    profession character varying,
    frn character varying,
    firm_name character varying,
    auditor_name character varying,
    auditor_designation_in_firm character varying,
    member_no character varying,
    certificate_of_practice character varying,
    auditor_mobile character varying,
    auditor_email character varying,
    address_of_firm_auditor character varying,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    type character varying,
    id integer NOT NULL
);


ALTER TABLE public.tbl_other_auditor OWNER TO postgres;

--
-- TOC entry 249 (class 1259 OID 180305)
-- Name: tbl_other_auditor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_other_auditor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_other_auditor_id_seq OWNER TO postgres;

--
-- TOC entry 6246 (class 0 OID 0)
-- Dependencies: 249
-- Name: tbl_other_auditor_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_other_auditor_id_seq OWNED BY public.tbl_other_auditor.id;


--
-- TOC entry 335 (class 1259 OID 221251)
-- Name: tbl_pas3; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_pas3 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    number_of_allotments integer,
    no_of_classes_preference integer,
    no_of_classes_equity integer,
    no_of_unclassified integer,
    total_unclassified integer,
    debentures integer,
    loan_secured integer,
    others integer,
    allottees_list text,
    another_attachment text,
    optional_attachment text,
    resolution_number text,
    resolution_date timestamp without time zone,
    designation text,
    signatory text,
    category text,
    name_of_pcs text,
    assososiate_or_fellow text,
    membership_number integer,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_pas3 OWNER TO postgres;

--
-- TOC entry 334 (class 1259 OID 221250)
-- Name: tbl_pas3_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_pas3_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_pas3_id_seq OWNER TO postgres;

--
-- TOC entry 6247 (class 0 OID 0)
-- Dependencies: 334
-- Name: tbl_pas3_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_pas3_id_seq OWNED BY public.tbl_pas3.id;


--
-- TOC entry 325 (class 1259 OID 205270)
-- Name: tbl_pas6; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_pas6 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    from_date timestamp without time zone,
    to_date timestamp without time zone,
    securities integer,
    held_shares_cdsl integer,
    held_capitals_cdsl numeric,
    held_shares_nsdl integer,
    held_capitals_nsdl numeric,
    shares_held_physical_form integer,
    capital_held_physical numeric,
    issued_shares integer,
    number_total integer,
    reason_physical_shares text,
    beginning_shares integer,
    reporting_whether text,
    shares_number integer,
    rights_number_of_shares integer,
    rights_nsdl text,
    rights_cdsl text,
    bonus_shares integer,
    bonus_intimate_to_nsdl text,
    bonus_intimate_to_cdsl text,
    private_placement_shares integer,
    private_placement_to_nsdl text,
    private_placement_to_cdsl text,
    shares_of_esops integer,
    esop_intimated_to_nsdl text,
    esop_intimated_to_cdsl text,
    shares_of_amalgamation integer,
    amalgamation_nsdl text,
    amalgamation_cdsl text,
    shares_of_conversion integer,
    conversion_nsdl text,
    conversion_cdsl text,
    shares_of_buyback integer,
    buy_nsdl text,
    buy_cdsl text,
    shares_of_capital_reduction integer,
    reduction_nsdl text,
    reduction_cdsl text,
    shares_of_forfeiture integer,
    forfeiture_nsdl text,
    forfeiture_cdsl text,
    any_other_shares integer,
    specify_nsdl text,
    specify_cdsl text,
    total_reporting_shares integer,
    promoters_of_demat integer,
    promoters_of_physical integer,
    promoters_of_total integer,
    directors_demat integer,
    directors_physical integer,
    directors_total integer,
    kmps_demat integer,
    kmps_physical integer,
    kmps_total integer,
    whether_members text,
    update_date text,
    confirmed_requests integer,
    confirmed_share integer,
    confirmed_delay_reasons text,
    pending_requests integer,
    pending_share integer,
    pending_delay_reasons text,
    whether_appointment text,
    agency_company_name text,
    other_details text,
    resolution_number integer,
    resolution_date timestamp without time zone,
    certified_name text,
    profession text,
    designation text,
    din integer,
    professional_name text,
    professional_address text,
    professional_email text,
    professional_type text,
    name_of_pcs text,
    name_of_associate text,
    certificate_number integer,
    optional_attachment text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_pas6 OWNER TO postgres;

--
-- TOC entry 324 (class 1259 OID 205269)
-- Name: tbl_pas6_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_pas6_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_pas6_id_seq OWNER TO postgres;

--
-- TOC entry 6248 (class 0 OID 0)
-- Dependencies: 324
-- Name: tbl_pas6_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_pas6_id_seq OWNED BY public.tbl_pas6.id;


--
-- TOC entry 452 (class 1259 OID 230595)
-- Name: tbl_reservation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_reservation (
    id integer NOT NULL,
    parent_id integer,
    auditor_qualification text,
    director_comments text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_reservation OWNER TO postgres;

--
-- TOC entry 451 (class 1259 OID 230594)
-- Name: tbl_reservation_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_reservation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_reservation_id_seq OWNER TO postgres;

--
-- TOC entry 6249 (class 0 OID 0)
-- Dependencies: 451
-- Name: tbl_reservation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_reservation_id_seq OWNED BY public.tbl_reservation.id;


--
-- TOC entry 299 (class 1259 OID 188249)
-- Name: tbl_resolution; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_resolution (
    id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    is_active boolean,
    number text,
    title text,
    agenda_text text,
    meeting_text text,
    resolution_text text,
    category character varying,
    subcategory character varying
);


ALTER TABLE public.tbl_resolution OWNER TO postgres;

--
-- TOC entry 298 (class 1259 OID 188248)
-- Name: tbl_resolution_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_resolution_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_resolution_id_seq OWNER TO postgres;

--
-- TOC entry 6250 (class 0 OID 0)
-- Dependencies: 298
-- Name: tbl_resolution_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_resolution_id_seq OWNED BY public.tbl_resolution.id;


--
-- TOC entry 356 (class 1259 OID 221640)
-- Name: tbl_run; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_run (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    proposed_name text,
    proposed_second_name text,
    application_comments text,
    attachment_file text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_run OWNER TO postgres;

--
-- TOC entry 355 (class 1259 OID 221639)
-- Name: tbl_run_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_run_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_run_id_seq OWNER TO postgres;

--
-- TOC entry 6251 (class 0 OID 0)
-- Dependencies: 355
-- Name: tbl_run_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_run_id_seq OWNED BY public.tbl_run.id;


--
-- TOC entry 365 (class 1259 OID 221862)
-- Name: tbl_runllp; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_runllp (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    purpose text,
    nic_code_serial text,
    codes_nic text,
    nic_codes_desc text,
    proposed_name1 text,
    proposed_name2 text,
    attachment_file_name text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_runllp OWNER TO postgres;

--
-- TOC entry 364 (class 1259 OID 221861)
-- Name: tbl_runllp_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_runllp_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_runllp_id_seq OWNER TO postgres;

--
-- TOC entry 6252 (class 0 OID 0)
-- Dependencies: 364
-- Name: tbl_runllp_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_runllp_id_seq OWNED BY public.tbl_runllp.id;


--
-- TOC entry 362 (class 1259 OID 221812)
-- Name: tbl_sh11; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh11 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    srn_of_sh8 text,
    srn_of_sh9 text,
    amount_as_on timestamp without time zone,
    free_reserve boolean,
    free_reserve_amount text,
    free_reserve_utilized_amount text,
    securities_premium boolean,
    securities_premium_amount text,
    securities_premium_utilized_amount text,
    preceding_capital boolean,
    proceeds_capital_amount text,
    proceeds_capital_utilized text,
    capital_share_date timestamp without time zone,
    equity_classes integer,
    preference_classes integer,
    capital_description text,
    pre_buy_shares_auth integer,
    pre_buy_shares_issue integer,
    pre_buy_shares_subs integer,
    pre_buy_shares_paid_up integer,
    shares_eqty_auth integer,
    shares_issue integer,
    shares_subs integer,
    shares_paid_up integer,
    total_amount_auth integer,
    total_amount_issue integer,
    total_amount_subs integer,
    total_amount_paid_up integer,
    securities_auth integer,
    securities_issue integer,
    securities_subs integer,
    securities_paid_up integer,
    buy_back_price_auth integer,
    buy_back_price_issue integer,
    buy_back_price_subs integer,
    buy_back_price_paid_up integer,
    total_amount_of_buy_back_auth integer,
    total_amount_of_buy_back_issue integer,
    total_amount_of_buy_back_subs integer,
    total_amount_of_buy_back_paid_up integer,
    post_buy_back_auth integer,
    post_buy_back_issue integer,
    post_buy_back_subs integer,
    post_buy_back_paid_up integer,
    amount_shares_auth integer,
    amount_shares_issue integer,
    amount_shares_subs integer,
    amount_shares_paid_up integer,
    unclassified_capital integer,
    details_date timestamp without time zone,
    equity_total integer,
    capital_paid integer,
    free_reserved_capital integer,
    premium_securities integer,
    amount_total integer,
    board_director_date timestamp without time zone,
    srn_of_mgt_14 text,
    completion_date timestamp without time zone,
    opening_offer_date timestamp without time zone,
    closing_offer_date timestamp without time zone,
    buy_back_completion_date timestamp without time zone,
    payment_consideration_date timestamp without time zone,
    ratio_applicable text,
    free_reserve_ratio text,
    pre_buy_back_debt_and_reserve_ratio text,
    post_buy_back_debt_and_reserve_ration text,
    securities_held_before_date timestamp without time zone,
    securities_held_after_date timestamp without time zone,
    government_central_securities integer,
    number_of_shares_buy_back integer,
    securities_held_government_companies integer,
    securities_back_government_companies integer,
    public_financial_institution integer,
    public_financial_securities integer,
    nationalized_other_bank_securities integer,
    nationalized_other_buy_back_securities integer,
    mutual_fund_security integer,
    mutual_fund_buy_back_securities integer,
    venture_capital_securities integer,
    venture_capital_buy_back_securities integer,
    foreign_securities_before integer,
    foreign_securities_after integer,
    corporate_securities_before integer,
    corporate_securities_after integer,
    directors_back_on integer,
    directors_back_on_relatives integer,
    shareholders_back_on integer,
    shareholders_securities integer,
    others_back_on integer,
    others_securities integer,
    total_back_on integer,
    total_securities integer,
    buy_back_back_on integer,
    buy_back_securities integer,
    buy_back_details text,
    board_resolution_copy text,
    optional_attachment text,
    resolution_number text,
    application_date timestamp without time zone,
    designation1 text,
    director_name1 text,
    din1 text,
    designation2 text,
    director_name2 text,
    din2 text,
    certified_by text,
    associate_or_fellow text,
    membership_number text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_sh11 OWNER TO postgres;

--
-- TOC entry 361 (class 1259 OID 221811)
-- Name: tbl_sh11_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh11_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh11_id_seq OWNER TO postgres;

--
-- TOC entry 6253 (class 0 OID 0)
-- Dependencies: 361
-- Name: tbl_sh11_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh11_id_seq OWNED BY public.tbl_sh11.id;


--
-- TOC entry 289 (class 1259 OID 181066)
-- Name: tbl_sh7; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh7 (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    form_purpose text,
    share_type text,
    resolution_date timestamp without time zone,
    srn_number text,
    members_present integer,
    shares_held integer,
    members_voted_for integer,
    shares_voted_for integer,
    members_voted_against integer,
    shares_voted_against integer,
    members_abstained integer,
    shares_abstained integer,
    existing_members integer,
    revised_members integer,
    difference_members integer,
    max_members_excluding_employees integer,
    order_number text,
    order_date timestamp without time zone,
    government_type text,
    state text,
    debentures boolean,
    loans boolean,
    order_received_date timestamp without time zone,
    appeal_filed text,
    tribunal_order_date timestamp without time zone,
    order_receipt_date timestamp without time zone,
    srn_inc28 text,
    company_notice_date timestamp without time zone,
    impact_consolidated boolean,
    impact_converted boolean,
    impact_reconverted boolean,
    impact_subdivided boolean,
    impact_cancellation boolean,
    articles_altered text,
    memorandum_altered text,
    stamp_state text,
    stamp_duty_amount numeric,
    stamp_details text,
    dec_name text,
    designation text,
    designation2 text,
    identifier text,
    category text,
    pcs text,
    membership_status text,
    membership_number text
);


ALTER TABLE public.tbl_sh7 OWNER TO postgres;

--
-- TOC entry 288 (class 1259 OID 181065)
-- Name: tbl_sh7_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh7_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh7_id_seq OWNER TO postgres;

--
-- TOC entry 6254 (class 0 OID 0)
-- Dependencies: 288
-- Name: tbl_sh7_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh7_id_seq OWNED BY public.tbl_sh7.id;


--
-- TOC entry 292 (class 1259 OID 181093)
-- Name: tbl_sh7_share; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh7_share (
    id integer NOT NULL,
    parent_id integer,
    type_of_shares text,
    class_of_shares text,
    nominal_value_per_share numeric,
    existing_number_of_shares integer,
    revision_required text,
    additional_number_of_shares integer,
    revised_number_of_shares integer,
    existing_total_value numeric,
    revised_total_value numeric,
    total_addition numeric,
    brief_description_of_conditions text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_sh7_share OWNER TO postgres;

--
-- TOC entry 291 (class 1259 OID 181092)
-- Name: tbl_sh7_share_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh7_share_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh7_share_id_seq OWNER TO postgres;

--
-- TOC entry 6255 (class 0 OID 0)
-- Dependencies: 291
-- Name: tbl_sh7_share_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh7_share_id_seq OWNED BY public.tbl_sh7_share.id;


--
-- TOC entry 294 (class 1259 OID 181102)
-- Name: tbl_sh7_structure; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh7_structure (
    id integer NOT NULL,
    parent_id integer,
    type text,
    share_type text,
    class_of_shares text,
    auth_number_of_shares integer,
    auth_nominal_value numeric,
    auth_total_amount numeric,
    issued_number_of_shares integer,
    issued_nominal_value numeric,
    issued_total_amount numeric,
    subscribed_number_of_shares integer,
    subscribed_nominal_value numeric,
    subscribed_total_amount numeric,
    paid_up_number_of_shares integer,
    paid_up_nominal_value numeric,
    paid_up_total_amount numeric,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_sh7_structure OWNER TO postgres;

--
-- TOC entry 293 (class 1259 OID 181101)
-- Name: tbl_sh7_structure_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh7_structure_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh7_structure_id_seq OWNER TO postgres;

--
-- TOC entry 6256 (class 0 OID 0)
-- Dependencies: 293
-- Name: tbl_sh7_structure_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh7_structure_id_seq OWNED BY public.tbl_sh7_structure.id;


--
-- TOC entry 359 (class 1259 OID 221725)
-- Name: tbl_sh8; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh8 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    capital_date timestamp without time zone,
    equity_share_classes integer,
    preference_share_classes integer,
    share_description text,
    number_of_shares_authorize_capital integer,
    number_of_shares_issued_capital integer,
    nominal_number_of_shares_issued_capital integer,
    number_of_shares_subscribed_capital integer,
    number_of_shares_paid_up integer,
    nominal_of_shares_eqty_auth integer,
    nominal_shares_subs integer,
    nominal_shares_paid_up integer,
    total_authorised integer,
    total_issued integer,
    total_subscribed integer,
    total_paid_up integer,
    unclassified_share_total integer,
    equity_capital_date timestamp without time zone,
    total_paid_up_equity integer,
    free_reserves_capital integer,
    premium_securities integer,
    date_of_completion timestamp without time zone,
    expected_proposed_date timestamp without time zone,
    proposed_completion_date timestamp without time zone,
    extinguishment_date timestamp without time zone,
    free_reserves boolean,
    security_premium_account boolean,
    other_specified_securities boolean,
    amount_date timestamp without time zone,
    free_reserve_amount integer,
    buy_back_reserves_amount integer,
    securities_premium_amount integer,
    security_buy_back_amount integer,
    other_specified_securities_amount integer,
    other_specified_securities_buy_back integer,
    equity_shares boolean,
    preference_shares boolean,
    other_shares boolean,
    classes_number integer,
    total_buy_back_amount integer,
    existing_holders boolean,
    open_market boolean,
    odd_lots_listed boolean,
    employees_stock boolean,
    sweat_equity boolean,
    any_other_mode boolean,
    specify_details text,
    article_authorising text,
    directors_date timestamp without time zone,
    resolution_date timestamp without time zone,
    srn text,
    equity_shares_preceding integer,
    preference_shares_preceding integer,
    other_shares_preceding integer,
    total_shares_preceding integer,
    equity_shares_purchased integer,
    preference_shares_purchased integer,
    other_shares_purchased integer,
    total_shares_purchased integer,
    equity_shares_purchased_after_meeting integer,
    preference_shares_purchased_after_meeting integer,
    other_shares_purchased_after_meeting integer,
    total_shares_purchased_after_meeting integer,
    max_price_equity numeric,
    max_price_preference numeric,
    max_price_other numeric,
    total_max_price numeric,
    max_price_date_equity timestamp without time zone,
    max_price_date_preference timestamp without time zone,
    max_price_date_other timestamp without time zone,
    total_max_price_date text,
    equity_shares_sold integer,
    preference_shares_sold integer,
    other_shares_sold integer,
    total_shares_sold integer,
    equity_shares_sold_after_meeting integer,
    preference_shares_sold_after_meeting integer,
    other_shares_sold_after_meeting integer,
    total_shares_sold_after_meeting integer,
    max_price_received_equity numeric,
    max_price_received_preference numeric,
    max_price_received_other numeric,
    total_max_price_received numeric,
    max_price_received_date_equity timestamp without time zone,
    max_price_received_date_preference timestamp without time zone,
    max_price_received_date_other timestamp without time zone,
    total_max_price_received_date text,
    balance_equity_shares integer,
    balance_preference_shares integer,
    balance_other_shares integer,
    total_balance_shares integer,
    security_date timestamp without time zone,
    government_holders text,
    government_companies_holders text,
    public_financial_holder text,
    nationalized_bank text,
    mutual_funds text,
    venture_capital text,
    foreign_financial text,
    bodies_corporate text,
    relatives_of_directors text,
    other_top_fifty text,
    others text,
    total text,
    total_share_holder text,
    government_ratio text,
    board_of_resolution text,
    reserve_debt text,
    reserve_post text,
    repayment_deposit text,
    annual_return text,
    first_designation text,
    first_director_name text,
    first_directors_din text,
    second_designation text,
    second_director_name text,
    second_director_din text,
    unaudited_financial_statement text,
    auditor_declaration text,
    statutory_approval text,
    board_resolution_copy text,
    optional_attachment text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_sh8 OWNER TO postgres;

--
-- TOC entry 358 (class 1259 OID 221724)
-- Name: tbl_sh8_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh8_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh8_id_seq OWNER TO postgres;

--
-- TOC entry 6257 (class 0 OID 0)
-- Dependencies: 358
-- Name: tbl_sh8_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh8_id_seq OWNED BY public.tbl_sh8.id;


--
-- TOC entry 338 (class 1259 OID 221358)
-- Name: tbl_sh9; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_sh9 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    company_whether text,
    resolution_directors text,
    special_date timestamp without time zone,
    service_number integer,
    resolution_number integer,
    resolution_pass text,
    approved text,
    shares_in_words text,
    companies_act text,
    day_of text,
    designation text,
    name_director text,
    director_din text,
    second_directors_designation text,
    second_director_name text,
    second_directors_din text,
    liabilities text,
    report text,
    affidavit text,
    attachment_file text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_sh9 OWNER TO postgres;

--
-- TOC entry 337 (class 1259 OID 221357)
-- Name: tbl_sh9_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_sh9_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_sh9_id_seq OWNER TO postgres;

--
-- TOC entry 6258 (class 0 OID 0)
-- Dependencies: 337
-- Name: tbl_sh9_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_sh9_id_seq OWNED BY public.tbl_sh9.id;


--
-- TOC entry 234 (class 1259 OID 180057)
-- Name: tbl_shareholder; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_shareholder (
    id integer NOT NULL,
    first_name character varying,
    middle_name character varying,
    last_name character varying,
    category character varying,
    sub_category character varying,
    under_sub_category character varying,
    has_valid_din boolean,
    director integer,
    gender character varying,
    pan character varying,
    dob date,
    email character varying,
    mobile character varying,
    marital_status character varying,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    type character varying,
    salutation character varying,
    cin_reg character varying,
    unique_id character varying,
    incorporation_date timestamp without time zone,
    company_name character varying,
    passport character varying
);


ALTER TABLE public.tbl_shareholder OWNER TO postgres;

--
-- TOC entry 236 (class 1259 OID 180066)
-- Name: tbl_shareholder_details; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_shareholder_details (
    id integer NOT NULL,
    shareholder integer,
    address_line_1 character varying,
    city character varying,
    state character varying,
    country character varying,
    pin_code character varying,
    father_name character varying,
    mother_name character varying,
    nationality character varying,
    voter_id character varying,
    aadhar_no character varying,
    occupation character varying,
    spouse_name character varying,
    pan_url character varying,
    aadhar_url character varying,
    gaurdian character varying
);


ALTER TABLE public.tbl_shareholder_details OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 180065)
-- Name: tbl_shareholder_detail_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_shareholder_detail_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_shareholder_detail_id_seq OWNER TO postgres;

--
-- TOC entry 6259 (class 0 OID 0)
-- Dependencies: 235
-- Name: tbl_shareholder_detail_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_shareholder_detail_id_seq OWNED BY public.tbl_shareholder_details.id;


--
-- TOC entry 233 (class 1259 OID 180056)
-- Name: tbl_shareholder_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_shareholder_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_shareholder_id_seq OWNER TO postgres;

--
-- TOC entry 6260 (class 0 OID 0)
-- Dependencies: 233
-- Name: tbl_shareholder_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_shareholder_id_seq OWNED BY public.tbl_shareholder.id;


--
-- TOC entry 426 (class 1259 OID 223838)
-- Name: tbl_shareholder_management; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_shareholder_management (
    id integer NOT NULL,
    company_id integer NOT NULL,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    deleted_on timestamp without time zone,
    ref_user integer,
    is_active boolean,
    joint_shareholding text,
    joint_shareholders_count integer,
    category text,
    sh_list text,
    date_of_becoming_member timestamp without time zone,
    shareholder_status text,
    shareholding_mode text,
    type_of_share text,
    number_of_shares_subscribed integer,
    per_share_value numeric,
    percentage_of_shares_held numeric,
    folio_no text,
    dp_client_id text,
    is_bene text
);


ALTER TABLE public.tbl_shareholder_management OWNER TO postgres;

--
-- TOC entry 425 (class 1259 OID 223837)
-- Name: tbl_shareholder_management_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_shareholder_management_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_shareholder_management_id_seq OWNER TO postgres;

--
-- TOC entry 6261 (class 0 OID 0)
-- Dependencies: 425
-- Name: tbl_shareholder_management_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_shareholder_management_id_seq OWNED BY public.tbl_shareholder_management.id;


--
-- TOC entry 429 (class 1259 OID 223852)
-- Name: tbl_shareholder_management_owner; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_shareholder_management_owner (
    id integer NOT NULL,
    parent_id integer,
    owner_name text,
    owner_address text,
    dec_date text,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_shareholder_management_owner OWNER TO postgres;

--
-- TOC entry 428 (class 1259 OID 223851)
-- Name: tbl_shareholder_management_owner_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_shareholder_management_owner_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_shareholder_management_owner_id_seq OWNER TO postgres;

--
-- TOC entry 6262 (class 0 OID 0)
-- Dependencies: 428
-- Name: tbl_shareholder_management_owner_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_shareholder_management_owner_id_seq OWNED BY public.tbl_shareholder_management_owner.id;


--
-- TOC entry 317 (class 1259 OID 204673)
-- Name: tbl_stk2; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_stk2 (
    id integer NOT NULL,
    ref_user integer,
    company_id integer,
    cin text,
    company_name text,
    company_address text,
    company_email text,
    cin_corporate text,
    office_address text,
    notice_received text,
    reason_for_closure text,
    delisted_received text,
    resolution text,
    other text,
    approval_date text,
    srn_related_form text,
    mgt_resolution text,
    srn_no_mgt14 text,
    description_of_moa text,
    director_manager integer,
    litigations text,
    litigation_pending_act text,
    name_of_authority text,
    case_number text,
    subject_matter text,
    declarant_name text,
    declarant_parent_name text,
    declarant_company text,
    declarant_resolution_number text,
    declaration_date text,
    attachment_file text,
    member_name text,
    member_designation text,
    membership_number text,
    indemnity_attachment_file text,
    optional_attachment_file text,
    director text,
    director_din text,
    accountant_type text,
    company_secretary text,
    whether_associate_or_fellow text,
    certificate_number text,
    created_by integer,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone,
    regulated_activities text,
    regulator text
);


ALTER TABLE public.tbl_stk2 OWNER TO postgres;

--
-- TOC entry 316 (class 1259 OID 204672)
-- Name: tbl_stk2_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_stk2_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_stk2_id_seq OWNER TO postgres;

--
-- TOC entry 6263 (class 0 OID 0)
-- Dependencies: 316
-- Name: tbl_stk2_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_stk2_id_seq OWNED BY public.tbl_stk2.id;


--
-- TOC entry 448 (class 1259 OID 230545)
-- Name: tbl_subsidiary; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_subsidiary (
    id integer NOT NULL,
    parent_id integer,
    type text,
    company_cin text,
    company_name text,
    company_provision text,
    created_on timestamp without time zone,
    created_by integer,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone
);


ALTER TABLE public.tbl_subsidiary OWNER TO postgres;

--
-- TOC entry 447 (class 1259 OID 230544)
-- Name: tbl_subsidiary_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_subsidiary_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_subsidiary_id_seq OWNER TO postgres;

--
-- TOC entry 6264 (class 0 OID 0)
-- Dependencies: 447
-- Name: tbl_subsidiary_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_subsidiary_id_seq OWNED BY public.tbl_subsidiary.id;


--
-- TOC entry 216 (class 1259 OID 162924)
-- Name: tbl_user; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_user (
    id integer NOT NULL,
    name character varying,
    email character varying,
    mobile character varying,
    password character varying,
    email_verified boolean,
    mobile_verified boolean,
    role integer,
    image_path character varying,
    created_on timestamp without time zone,
    updated_by integer,
    updated_on timestamp without time zone,
    is_active boolean,
    deleted_on timestamp without time zone,
    created_by integer
);


ALTER TABLE public.tbl_user OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 162923)
-- Name: tbl_user_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_user_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_user_id_seq OWNER TO postgres;

--
-- TOC entry 6265 (class 0 OID 0)
-- Dependencies: 215
-- Name: tbl_user_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_user_id_seq OWNED BY public.tbl_user.id;


--
-- TOC entry 418 (class 1259 OID 223677)
-- Name: vw_adt1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_adt1 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.falling_section,
    a.appointment_nature,
    a.is_auditor_appointed,
    a.auditor_number,
    a.annual_general_meeting,
    a.agm_date,
    a.appointment_date,
    a.is_casual_vacancy,
    a.sr_no_of_relevant_form,
    a.person_vacated,
    a.vacancy_date,
    a.casual_vacancy_reasons,
    a.membership_number,
    a.auditor_serial,
    a.auditor_member_no,
    a.resolution_number,
    a.resolution_date,
    a.signed_by,
    a.designation,
    a.din,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_adt1 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_adt1 OWNER TO postgres;

--
-- TOC entry 421 (class 1259 OID 223753)
-- Name: vw_adt3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_adt3 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.auditor,
    a.category,
    a.reason,
    a.resignation_place,
    a.other_reason,
    a.letter_date,
    a.effective_date,
    a.place_disqualified,
    a.relative_name,
    a.relation,
    a.intimation_date,
    a.place,
    a.auditor_category,
    a.pan,
    a.auditor_name,
    a.membership,
    a.auditor_address,
    a.city,
    a.state,
    a.pin_code,
    a.auditor_email,
    a.appointment_date,
    a.resignation_date,
    a.resignation_reasons,
    a.designation,
    a.fellow_associate,
    a.membership_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_adt3 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_adt3 OWNER TO postgres;

--
-- TOC entry 466 (class 1259 OID 230923)
-- Name: vw_aoc4; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_aoc4 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.authorised_capital,
    a.members_number,
    a.from_year_start_date,
    a.to_year_end_date,
    a.approved_date,
    a.statement_nature,
    a.provisional_financial_statement,
    a.adopted_agm,
    a.nature_revision,
    a.financial_date,
    a.srn_inc_28,
    a.srn_aoc_4,
    a.is_general_meeting_held,
    a.agm_date,
    a.agm_due_date,
    a.is_agm_granted,
    a.due_date_of_agm,
    a.is_financial_statement_signer_selected1,
    a.is_financial_statement_signer_selected2,
    a.date_of_signing1,
    a.date_of_signing2,
    a.report_referred_date,
    a.is_board_report_signer_selected1,
    a.is_board_report_signer_selected2,
    a.board_report_signing_date1,
    a.board_report_signing_date2,
    a.auditor_signing_report_date,
    a.is_subsidiary_company,
    a.has_subsidiary_companies,
    a.subsidiary_provision,
    a.is_auditor_selected,
    a.auditor_member_no,
    a.srn_adt1,
    a.is_schedule3_applicable,
    a.industry_type,
    a.are_consolidated_financials_required,
    a.maintains_electronic_books,
    a.server_address_line1,
    a.server_address_line2,
    a.city,
    a.state,
    a.district,
    a.country,
    a.pin_code_address,
    a.phone_number,
    a.service_provider_name,
    a.service_provider_ip,
    a.service_provider_location,
    a.books_on_cloud,
    a.service_provider_address,
    a.tangible_assets_current,
    a.tangible_assets_previous,
    a.intangible_assets_current,
    a.current_reporting_period,
    a.previous_reporting_period,
    a.share_capital_current,
    a.share_capital_previous,
    a.reserves_and_surplus_current,
    a.reserves_and_surplus_previous,
    a.money_against_share_warrants_current,
    a.money_against_share_warrants_previous,
    a.share_application_money_pending_allotment_current,
    a.share_application_money_pending_allotment_previous,
    a.long_term_borrowings_current,
    a.long_term_borrowings_previous,
    a.deferred_tax_liabilities_current,
    a.deferred_tax_liabilities_previous,
    a.other_long_term_liabilities_current,
    a.other_long_term_liabilities_previous,
    a.long_term_provisions_current,
    a.long_term_provisions_previous,
    a.short_term_borrowings_current,
    a.short_term_borrowings_previous,
    a.trade_payables_current,
    a.trade_payables_previous,
    a.other_current_liabilities_current,
    a.other_current_liabilities_previous,
    a.short_term_provisions_current,
    a.short_term_provisions_previous,
    a.total_equity_and_liabilities_current,
    a.total_equity_and_liabilities_previous,
    a.intangible_assets_previous,
    a.capital_work_in_progress_current,
    a.capital_work_in_progress_previous,
    a.intangible_assets_under_development_current,
    a.intangible_assets_under_development_previous,
    a.non_current_investments_current,
    a.non_current_investments_previous,
    a.deferred_tax_assets_current,
    a.deferred_tax_assets_previous,
    a.long_term_loans_and_advances_current,
    a.long_term_loans_and_advances_previous,
    a.other_non_current_assets_current,
    a.other_non_current_assets_previous,
    a.current_investments_current,
    a.current_investments_previous,
    a.inventories_current,
    a.inventories_previous,
    a.trade_receivables_current,
    a.trade_receivables_previous,
    a.cash_and_equivalents_current,
    a.cash_and_equivalents_previous,
    a.short_term_loans_and_advances_current,
    a.short_term_loans_and_advances_previous,
    a.other_current_assets_current,
    a.other_current_assets_previous,
    a.total_assets_current,
    a.total_assets_previous,
    a.starting_date_current,
    a.closing_date_current,
    a.sales_goods_manufactured_current,
    a.sales_goods_traded_current,
    a.sales_supply_services_current,
    a.export_sales_goods_manufactured_current,
    a.export_sales_goods_traded_current,
    a.export_sales_supply_services_current,
    a.other_income_current,
    a.total_revenue_current,
    a.cost_material_consumed_current,
    a.purchases_stock_trade_current,
    a.changes_inventories_finished_goods_current,
    a.changes_inventories_work_in_progress_current,
    a.changes_inventories_stock_trade_current,
    a.employee_benefit_expense_current,
    a.managerial_remuneration_current,
    a.payment_to_auditors_current,
    a.insurance_expenses_current,
    a.power_and_fuel_current,
    a.finance_cost_current,
    a.depreciation_amortisation_current,
    a.other_expenses_current,
    a.total_expenses_current,
    a.profit_before_exceptional_items_current,
    a.exceptional_items_current,
    a.profit_before_extraordinary_items_current,
    a.extraordinary_items_current,
    a.profit_before_tax_current,
    a.current_tax_current,
    a.deferred_tax_current,
    a.profit_loss_continuing_operations_current,
    a.profit_loss_discontinuing_operations_current,
    a.tax_expense_discontinuing_operations_current,
    a.profit_loss_discontinuing_after_tax_current,
    a.total_profit_loss_current,
    a.basic_eps_before_extraordinary_items_current,
    a.diluted_eps_before_extraordinary_items_current,
    a.basic_eps_after_extraordinary_items_current,
    a.diluted_eps_after_extraordinary_items_current,
    a.starting_date_previous,
    a.closing_date_previous,
    a.sales_goods_manufactured_previous,
    a.sales_goods_traded_previous,
    a.sales_supply_services_previous,
    a.export_sales_goods_manufactured_previous,
    a.export_sales_goods_traded_previous,
    a.export_sales_supply_services_previous,
    a.other_income_previous,
    a.total_revenue_previous,
    a.cost_material_consumed_previous,
    a.purchases_stock_trade_previous,
    a.changes_inventories_finished_goods_previous,
    a.changes_inventories_work_in_progress_previous,
    a.changes_inventories_stock_trade_previous,
    a.employee_benefit_expense_previous,
    a.managerial_remuneration_previous,
    a.payment_to_auditors_previous,
    a.insurance_expenses_previous,
    a.power_and_fuel_previous,
    a.finance_cost_previous,
    a.depreciation_amortisation_previous,
    a.other_expenses_previous,
    a.total_expenses_previous,
    a.profit_before_exceptional_items_previous,
    a.exceptional_items_previous,
    a.profit_before_extraordinary_items_previous,
    a.extraordinary_items_previous,
    a.profit_before_tax_previous,
    a.current_tax_previous,
    a.deferred_tax_previous,
    a.profit_loss_continuing_operations_previous,
    a.profit_loss_discontinuing_operations_previous,
    a.tax_expense_discontinuing_operations_previous,
    a.profit_loss_discontinuing_after_tax_previous,
    a.total_profit_loss_previous,
    a.basic_eps_before_extraordinary_items_previous,
    a.diluted_eps_before_extraordinary_items_previous,
    a.basic_eps_after_extraordinary_items_previous,
    a.diluted_eps_after_extraordinary_items_previous,
    a.public_iss_eqt,
    a.public_iss_pre,
    a.public_iss_total,
    a.bonus_iss_eqt,
    a.bonus_iss_pre,
    a.bonus_iss_total,
    a.right_iss_eqt,
    a.right_iss_pre,
    a.right_iss_total,
    a.pri_plc_deb_pre1,
    a.pri_plc_deb_pre2,
    a.pri_plc_deb_pre_total,
    a.other_plc_deb_pre1,
    a.other_plc_deb_pre2,
    a.other_plc_deb_pre_total,
    a.pre_all_deb1,
    a.pre_all_deb2,
    a.pre_all_deb_total,
    a.other_pre_all1,
    a.other_pre_all2,
    a.other_pre_all_total,
    a.esop_eqt,
    a.esop_pre,
    a.esop_total,
    a.other_eqt,
    a.other_pre,
    a.other_total,
    a.total_amt_eqt,
    a.total_amt_pre,
    a.total_amt_total,
    a.amt_issue_all,
    a.app_money_given,
    a.share_app_mom_give,
    a.app_money_rec,
    a.app_money_refund,
    a.paid_up_cap,
    a.paid_up_cap_per,
    a.paid_up_cap_fore,
    a.paid_up_cap_fore_per,
    a.bought_back_share,
    a.deposits_accepted,
    a.deposited_matured,
    a.claimed_not_paid,
    a.matured_not_claimed,
    a.unclaimed_matured,
    a.debenture_claimed,
    a.interest_on_deposits,
    a.unpaid_dividend,
    a.invest_in_subsidiary,
    a.invest_in_government,
    a.capital_reserves,
    a.investor_education,
    a.inter_corporate,
    a.gross_value,
    a.grants_received,
    a.unpaid_directors,
    a.calls_unpaid,
    a.forfeited_shares,
    a.forfeited_shares_reissue,
    a.foreign_institutional,
    a.borrowing_foreign,
    a.corporate_borrowing,
    a.unsecured_borrowing,
    a.commercial_paper,
    a.warrents_conversion,
    a.preference_warrants_convewrter,
    a.debenture_warrants_convewrter,
    a.reporting_period_warrents,
    a.rupees_warrents_issued,
    a.payment_short_term,
    a.payment_long_term,
    a.opr_lease_con_finleas,
    a.financial_net_worth,
    a.num_shareholder,
    a.secured_loan,
    a.gross_fix_ass,
    a.deprec,
    a.mis_exp,
    a.unhedged_fore_ex,
    a.bonds_deb_cr,
    a.bonds_deb_pr,
    a.bank_loans_cr,
    a.bank_loans_pr,
    a.other_loan_cr,
    a.other_loan_pr,
    a.deferred_lib_cr,
    a.deferred_lib_pr,
    a.deposits_cr,
    a.deposits_pr,
    a.loan_from_rp_cr,
    a.loan_from_rp_pr,
    a.financial_lease_cr,
    a.financial_lease_pr,
    a.other_advances_cr,
    a.other_advances_pr,
    a.total_l_borring_cr,
    a.total_l_borring_pr,
    a.aggregate_amt_cr,
    a.aggregate_amt_pr,
    a.other_loan_cr_short,
    a.other_loan_pr_short,
    a.loans_advances_cr,
    a.loans_advances_pr,
    a.deposits_cr_short,
    a.deposits_pr_short,
    a.other_advance_loan_cr,
    a.other_advance_loan_pr,
    a.total_borrowing_cr,
    a.total_borrowing_pr,
    a.aggregate_amount_cr,
    a.aggregate_amount_pr,
    a.unsecured_cap_ad_cr,
    a.unsecured_cap_ad_pr,
    a.doubt_cap_ad_cr,
    a.doubt_cap_ad_pr,
    a.un_security_dep_cr,
    a.un_security_dep_pr,
    a.dt_security_dep_cr,
    a.dt_security_dep_pr,
    a.un_rp_loan_cr,
    a.un_rp_loan_pr,
    a.dt_rp_loan_cr,
    a.dt_rp_loan_pr,
    a.un_other_loan_cr,
    a.un_other_loan_pr,
    a.dt_other_loan_cr,
    a.dt_other_loan_pr,
    a.un_total_cr,
    a.un_total_pr,
    a.dt_total_cr,
    a.dt_total_pr,
    a.un_rp_baddebt_cr,
    a.un_rp_baddebt_pr,
    a.dt_rp_baddebt_cr,
    a.dt_rp_baddebt_pr,
    a.un_other_baddebt_cr,
    a.un_other_baddebt_pr,
    a.dt_other_baddebt_cr,
    a.dt_other_baddebt_pr,
    a.un_net_loan_cr,
    a.un_net_loan_pr,
    a.dt_net_loan_cr,
    a.dt_net_loan_pr,
    a.un_due_loan_cr,
    a.un_due_loan_pr,
    a.dt_due_loan_cr,
    a.dt_due_loan_pr,
    a.consider_good_ces,
    a.consider_good_cws,
    a.consider_good_pes,
    a.consider_good_pws,
    a.unsecured_con_ces,
    a.unsecured_con_cws,
    a.unsecured_con_pes,
    a.unsecured_con_pws,
    a.doubtful_ces,
    a.doubtful_cws,
    a.doubtful_pes,
    a.doubtful_pws,
    a.trade_receivables_ces,
    a.trade_receivables_cws,
    a.trade_receivables_pes,
    a.trade_receivables_pws,
    a.doubtful_debts_ces,
    a.doubtful_debts_cws,
    a.doubtful_debts_pes,
    a.doubtful_debts_pws,
    a.net_trade_ces,
    a.net_trade_cws,
    a.net_trade_pes,
    a.net_trade_pws,
    a.other_officers_ces,
    a.other_officers_cws,
    a.other_officers_pes,
    a.other_officers_pws,
    a.exports_goods_cr,
    a.int_div_cr,
    a.royalty_cr,
    a.know_how_cr,
    a.pro_con_cr,
    a.other_in_cr,
    a.total_earn_cr,
    a.exports_goods_pr,
    a.int_div_pr,
    a.royalty_pr,
    a.know_how_pr,
    a.pro_con_pr,
    a.other_in_pr,
    a.total_earn_pr,
    a.raw_mat_cr,
    a.raw_mat_pr,
    a.com_sap_cr,
    a.com_sap_pr,
    a.cap_goods_cr,
    a.cap_goods_pr,
    a.exp_royality_cr,
    a.exp_royality_pr,
    a.exp_know_cr,
    a.exp_know_pr,
    a.exp_pro_cr,
    a.exp_pro_pr,
    a.exp_int_cr,
    a.exp_int_pr,
    a.other_mat_cr,
    a.other_mat_pr,
    a.did_paid_cr,
    a.did_paid_pr,
    a.total_exp_cr,
    a.total_exp_pr,
    a.pro_did_rup,
    a.pro_did_per,
    a.earn_basic_share,
    a.earn_diluted_share,
    a.income_in_fc,
    a.exp_in_fc,
    a.revenue_rec,
    a.rent_paid,
    a.consup_str_sp,
    a.gross_val_trans,
    a.bad_debts,
    a.is_csr_applicable,
    a.turnover,
    a.net_worth,
    a.first_financial_year_ended,
    a.second_financial_year_ended,
    a.third_financial_year_ended,
    a.first_year_profit_before_tax,
    a.second_year_profit_before_tax,
    a.third_year_profit_before_tax,
    a.first_year_computed_net_profit,
    a.second_year_computed_net_profit,
    a.third_year_computed_net_profit,
    a.average_net_profit,
    a.prescribed_csr_expenditure,
    a.total_csr_spending,
    a.local_area_spending,
    a.details_of_implenting_agency,
    a.explanation_for_not_spending,
    a.other_explaination_reason,
    a.responsibility_statement_of_csr,
    a.cost_record_maintain,
    a.central_excise_tariff,
    a.cost_record_sn1,
    a.centralexcisetariff2,
    a.is_cag_commented,
    a.has_auditor_remarks,
    a.is_caro_applicable,
    a.caro_fixed_assets,
    a.caro_inventories,
    a.caro_loans_given,
    a.caro_public_deposits,
    a.caro_cost_records,
    a.caro_statutory_dues,
    a.caro_term_loans,
    a.caro_fraud_noticed,
    a.caro_other_remarks,
    a.is_secretarial_audit_applicable,
    a.has_director_report_disclosures,
    a.resolution_number,
    a.resolution_date,
    a.signatory_name,
    a.signatory_designation,
    a.din_pan_number,
    a.certified_by,
    a.certifying_professional,
    a.professional_type,
    a.membership_number,
    a.practice_certificate_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_aoc4 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_aoc4 OWNER TO postgres;

--
-- TOC entry 458 (class 1259 OID 230655)
-- Name: vw_aoc4cfs; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_aoc4cfs AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.aoc4_srn,
    a.financial_year_starting_date,
    a.financial_year_ending_date,
    a.board_meeting_date,
    a.section134_approval_date,
    a.director1_signed,
    a.director1_signing_date,
    a.director2_signed,
    a.director2_signing_date,
    a.board_director1_signed,
    a.board_director1_signing_date,
    a.board_director2_signed,
    a.board_director2_signing_date,
    a.auditor_signing_date,
    a.first_auditor_serial,
    a.first_auditor_member_no,
    a.first_auditor_srn,
    a.second_auditor_serial,
    a.second_auditor_member_no,
    a.second_auditor_srn,
    a.has_subsidiary,
    a.associate_or_venture,
    a.industries_type,
    a.schedule_applicable,
    a.has_cag_comments,
    a.has_cag_supplementary_audit,
    a.has_auditor_remarks,
    a.is_caro_applicable,
    a.fixed_assets,
    a.inventories,
    a.loans_given,
    a.public_deposits,
    a.cost_records,
    a.statutory_dues,
    a.term_loans,
    a.fraud_noticed,
    a.other_comments,
    a.is_secretarial_audit_applicable,
    a.has_detailed_disclosures,
    a.resolution_number,
    a.resolution_date,
    a.signatory_id,
    a.signatory_designation,
    a.signatory_din_pan,
    a.certified_by,
    a.name_of_pcs,
    a.associate_or_fellow,
    a.memb_number,
    a.cert_practice_no,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_aoc4cfs a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_aoc4cfs OWNER TO postgres;

--
-- TOC entry 354 (class 1259 OID 221572)
-- Name: vw_aoc5; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_aoc5 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.decision_date,
    a.line_address1,
    a.line_address2,
    a.longitude,
    a.latitude,
    a.country,
    a.pin_code,
    a.locality_area,
    a.city,
    a.district,
    a.ut_state,
    a.police_station_name,
    a.line_address3,
    a.line_address4,
    a.country2,
    a.pin_code2,
    a.locality_area2,
    a.city2,
    a.district2,
    a.ut_state2,
    a.address_proof,
    a.bills_copy,
    a.register_office_photo,
    a.attachment_file,
    a.comp_vide_resolution,
    a.date_declaration,
    a.designation,
    a.signatory,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_aoc5 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_aoc5 OWNER TO postgres;

--
-- TOC entry 385 (class 1259 OID 222384)
-- Name: vw_aoccuntnsolvencyform; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_aoccuntnsolvencyform AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.purpose,
    a.statement_of_account_date,
    a.llpin_fllp_in,
    a.statement_of_asests_and_liabilities_at,
    a.llp_fllp_name,
    a.jurisdiction_police_station,
    a.contribution_total,
    a.llp_fllp_enquiry_confirmation,
    a.llp_fllp_name_2,
    a.llp_fllp_pay_debts,
    a.append_statement,
    a.statement_of_assets_and_liabilities_at,
    a.income_and_expenditure_ended_on,
    a.confirmation_on_filing,
    a.declare_turnover,
    a.turnover,
    a.declare_obligation_of_contribution,
    a.obligation_of_contribution,
    a.confirming_partners,
    a.confirming_the_statement_is_true,
    a.contingent_liabilities_radio_btn,
    a.description_of_contingent_liability,
    a.amount,
    a.confirmation_on_filling,
    a.description_of_contigent_liability,
    a.contingent_liabilites_radio_btn,
    a.statement_assets_liabilities,
    a.contribution_received_cr,
    a.contribution_received_pr,
    a.reserves_surplus_cr,
    a.reserves_surplus_pr,
    a.secured_loans_cr,
    a.secured_loans_pr,
    a.unsecure_loans_cr,
    a.unsecure_loans_pr,
    a.short_term_cr,
    a.short_term_pr,
    a.payables_advance_cr,
    a.payables_advance_pr,
    a.other_liabilities_name_cr,
    a.other_liabilities_cr,
    a.other_liabilities_pr,
    a.for_taxation_cr,
    a.for_taxation_pr,
    a.for_contingencies_cr,
    a.for_contingencies_pr,
    a.for_insurance_cr,
    a.for_insurance_pr,
    a.other_provisions_cr,
    a.other_provisions_pr,
    a.total_cr,
    a.total_pr,
    a.fixed_assets_cr,
    a.fixed_assets_pr,
    a.depreciation_cr,
    a.depreciation_pr,
    a.net_fixed_assets_cr,
    a.net_fixed_assets_pr,
    a.investments_cr,
    a.investments_pr,
    a.loans_cr,
    a.loans_pr,
    a.inventories_cr,
    a.inventories_pr,
    a.trade_receivables_cr,
    a.trade_receivables_pr,
    a.cash_equivalents_cr,
    a.cash_equivalents_pr,
    a.other_assets_cr,
    a.other_assets_pr,
    a.total_assets_cr,
    a.total_assets_pr,
    a.other_assets_name_cr,
    a.starting_date_cr,
    a.starting_date_pr,
    a.closing_date_cr,
    a.closing_date_pr,
    a.gross_turnover_cr,
    a.gross_turnover_pr,
    a.excise_duty_cr,
    a.excise_duty_pr,
    a.net_turnover_cr,
    a.net_turnover_pr,
    a.sales_good_cr,
    a.sales_good_pr,
    a.sales_goods_t_cr,
    a.sales_goods_t_pr,
    a.sales_supply_cr,
    a.sales_supply_pr,
    a.sales_goods_1_cr,
    a.sales_goods_1_pr,
    a.sale_goods_t_1_cr,
    a.sale_goods_t_1_pr,
    a.sales_supply_1_cr,
    a.sales_supply_1_pr,
    a.other_income_cr,
    a.other_income_pr,
    a.increase_cr,
    a.increase_pr,
    a.total_revenue_cr,
    a.total_revenue_pr,
    a.material_cr,
    a.material_pr,
    a.purchase_made_c,
    a.purchase_made_p,
    a.consumption_cr,
    a.consumption_pr,
    a.power_cr,
    a.power_pr,
    a.personnel_cr,
    a.personnel_pr,
    a.administrative_cr,
    a.administrative_pr,
    a.payment_cr,
    a.payment_pr,
    a.selling_c,
    a.selling_p,
    a.insurance_exp_cr,
    a.insurance_exp_pr,
    a.depreciation_p_cr,
    a.depreciation_p_pr,
    a.interest_cr,
    a.interest_pr,
    a.other_expenses_c,
    a.other_expenses_p,
    a.total_expenses_c,
    a.total_expenses_p,
    a.profit_net_cr,
    a.profit_net_pr,
    a.provision_c,
    a.provision_p,
    a.profit_aft_tax_c,
    a.profit_aft_tax_p,
    a.profit_transfer_cr,
    a.profit_transfer_pr,
    a.prof_tra_res_ser_c,
    a.prof_tra_res_ser_p,
    a.dpin_income_tax_pan_11,
    a.dpin_income_tax_pan_12,
    a.administrator_name,
    a.designation,
    a.administrator_id,
    a.certified_radio_button,
    a.number_membership,
    a.designated_name,
    a.address_line_1,
    a.address_line_2,
    a.country,
    a.pin_code_1,
    a.area_locality_1,
    a.city_1,
    a.district_1,
    a.state_1,
    a.jurisdiction,
    a.phone,
    a.email_id,
    a.certificate_name,
    a.category_radio_buttons,
    a.name_of_pcs,
    a.professional_type,
    a.certificate_of_practice_number,
    a.attachment_file,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_aoccuntnsolvencyform a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_aoccuntnsolvencyform OWNER TO postgres;

--
-- TOC entry 246 (class 1259 OID 180277)
-- Name: vw_auditor; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_auditor AS
 SELECT a.id,
    a.category,
    a.frn,
    a.firm_name,
    a.pan,
    a.firm_email,
    a.address,
    a.country,
    a.state,
    a.city,
    a.pincode,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    ap.name AS partner_name,
    ap.mobile AS partner_mobile,
    u.name AS ref_user_name
   FROM ((public.tbl_auditor a
     LEFT JOIN ( SELECT ap_1.id,
            ap_1.auditor,
            ap_1.name,
            ap_1.mobile,
            row_number() OVER (PARTITION BY ap_1.auditor ORDER BY ap_1.id) AS row_num
           FROM public.tbl_auditor_partner ap_1) ap ON (((a.id = ap.auditor) AND (ap.row_num = 1))))
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.firm_name;


ALTER VIEW public.vw_auditor OWNER TO postgres;

--
-- TOC entry 345 (class 1259 OID 221464)
-- Name: vw_ben2; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_ben2 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.reporting_company,
    a.declaration_ownership,
    a.change_ownership,
    a.change_exiting,
    a.change_reporting_company,
    a.cin_holding_company,
    a.name_holding_company,
    a.number_of_significant_owners,
    a.copy_attachment,
    a.optional_attachment,
    a.resolution_number,
    a.resolution_date,
    a.designation,
    a.signitory,
    a.din_pan,
    a.category,
    a.name_of_pcs,
    a.associate_or_fellow,
    a.membership_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_ben2 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_ben2 OWNER TO postgres;

--
-- TOC entry 461 (class 1259 OID 230773)
-- Name: vw_boardreport; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_boardreport AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.financial_year,
    a.amount_figure,
    a.type_board_report,
    a.agmnotice_date,
    a.date_agm,
    a.day_date,
    a.time_agm,
    a.no_of_agm,
    a.paidup_capital,
    a.no_of_board_meeting,
    a.board_meeting_sr_no,
    a.board_meeting_date,
    a.board_strength1,
    a.no_of_directors_present1,
    a.board_meeting_sr_no2,
    a.board_meeting_date2,
    a.board_strength2,
    a.no_of_directors_present2,
    a.numbers_of_board_meeting_during_year,
    a.board_meeting_date3,
    a.board_strength3,
    a.no_of_directors_present3,
    a.sr_no4,
    a.board_meeting_date4,
    a.board_strength4,
    a.no_of_directors_present4,
    a.sr_no5,
    a.board_meeting_date5,
    a.board_strength5,
    a.no_of_directors_present5,
    a.sr_no6,
    a.board_meeting_date6,
    a.board_strength6,
    a.no_of_directors_present6,
    a.no_of_general_meeting,
    a.number_of_meeting_during_year2,
    a.select_meeting_type,
    a.general_meeting_date,
    a.general_strength_meeting,
    a.no_of_members_present,
    a.have_website,
    a.website_name,
    a.operation_revenue_cur,
    a.operation_revenue_pre,
    a.profit_before_cur,
    a.profit_before_pre,
    a.other_income_cur,
    a.other_income_pre,
    a.finance_charge_cur,
    a.finance_charge_pre,
    a.depreciation_cur,
    a.depreciation_pre,
    a.otherexp_cur,
    a.otherexp_pre,
    a.net_profit_before_cur,
    a.net_profit_before_pre,
    a.tax_expense_cur,
    a.tax_expense_pre,
    a.deffere_tax_expense_cur,
    a.deffered_tax_expense_pre,
    a.net_profit_cur,
    a.net_profit_pre,
    a.revenue_changes,
    a.pbdit_changes,
    a.pbt_changes,
    a.pat_changes,
    a.is_independ_director,
    a.have_csr,
    a.risk_management_policy,
    a.no_of_committee_meeting,
    a.have_cas,
    a.is_committee_of_director,
    a.name_of_audit_firm,
    a.date_appo_auditor,
    a.category,
    a.firm_registration,
    a.period_appointment,
    a.effective_date_au,
    a.any_observation,
    a.have_costaudit,
    a.name_of_secretarial_auditor,
    a.date_secretaria_auditor,
    a.any_observation_sect,
    a.cost_secretaria_fees,
    a.have_internalaudit,
    a.name_of_internal_auditor,
    a.date_internal_auditor,
    a.any_observation_int,
    a.cost_internal_fees,
    a.loan_invest,
    a.no_of_party,
    a.detail_loan_invest,
    a.related_party_trans,
    a.related_party_trans_matrial,
    a.no_teno_of_related_party,
    a.is_related_party_detail,
    a.no_of_matarial,
    a.is_related_party_detailarms,
    a.no_of_contracts,
    a.changes_nature,
    a.tab_changes_nature,
    a.changes_share,
    a.authorised_capital,
    a.no_of_authorized,
    a.share_issue,
    a.no_of_share_issue,
    a.buy_back,
    a.no_of_buck_back,
    a.data_box1,
    a.data_box2,
    a.data_boxs3,
    a.data_box4,
    a.sweet_equity,
    a.no_of_sweet_equity,
    a.value_sweet_equity,
    a.total_sweet_equity,
    a.bonus_share,
    a.no_of_bonus_share,
    a.value_bonus_share,
    a.total_bonu_share,
    a.esop_share,
    a.no_of_esopshare,
    a.value_esopshare,
    a.total_esopshare,
    a.shared_if_right,
    a.no_of_shared_if_right,
    a.value_shared_if_right,
    a.total_shared_if_right,
    a.amount_transfer_reserve,
    a.no_of_transfer_reserve,
    a.have_dividend,
    a.reason_no_payment,
    a.interim_dividend,
    a.dividend_distribution_tax_interim,
    a.data_board_interim,
    a.data_board_interim_face_value,
    a.data_board_interim_percent,
    a.final_dividend,
    a.dividend_distribution_tax_final,
    a.board_dividend_share,
    a.board_face_value_share,
    a.board_percent_of_dividend,
    a.transfer_dividend,
    a.trans_dividend_amount,
    a.have_changes,
    a.no_of_events,
    a.conserve_energy,
    a.tech_absortion,
    a.tech_absortion_step3,
    a.foreign_exchange,
    a.foreign_exchange_income,
    a.foreign_exchange_income_pre,
    a.foreign_exchange_import,
    a.foreign_exchange_import_pre,
    a.foreign_exchange_pnterest,
    a.foreign_exchange_interest_pre,
    a.foreign_exchange_travel,
    a.foreign_exchange_travel_pre,
    a.foreign_exchange_other,
    a.foreign_exchange_other_pre,
    a.directors_kmp,
    a.director_and_kmp_name,
    a.designation,
    a.select_type_of_change,
    a.date_appointment_cessation,
    a.no_of_directors_kmp_rotation,
    a.deposits,
    a.deposits_accept,
    a.tab_deposits,
    a.deposit_accept,
    a.deposit_unpaid,
    a.whether_default,
    a.no_such_cases,
    a.tamount_begining,
    a.tmaount_during,
    a.tamount_end,
    a.details_deposits,
    a.disclouser_related,
    a.no_of_persons,
    a.board_evalution,
    a.info_about_subsidiary,
    a.commen_ceoperations_subs,
    a.liquidated_subs,
    a.commen_ceoperations_jv,
    a.liquidated_jv,
    a.regulator_order,
    a.tab_regulator_order,
    a.have_vigil,
    a.have_fraud,
    a.have_adequacy,
    a.adequacy_text_area,
    a.sexual_rating,
    a.complaints_received,
    a.complaints_disposed,
    a.complaints_pending,
    a.complaints_unsolved,
    a.have_manaperson,
    a.name_appoint,
    a.designation_app,
    a.remuneraion,
    a.credit_rating,
    a.secretarial_standard,
    a.detail_secretarial_standard,
    a.any_cirp,
    a.any_corporateaction,
    a.any_topten,
    a.annexure,
    a.detail_any_topten,
    a.dis_emp_name,
    a.dis_designation,
    a.dis_remuneration,
    a.dis_nature,
    a.dis_qualification,
    a.dis_date_commence,
    a.dis_age,
    a.dis_last_emp,
    a.dis_percent_equity,
    a.dis_nature_name,
    a.any_diffvalution,
    a.any_disclosure,
    a.place_boardreport,
    a.meeting_date,
    a.director_name1,
    a.director_din1,
    a.director_desigation1,
    a.director_name2,
    a.director_din2,
    a.director_desigation2,
    a.title,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_boardreport a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_boardreport OWNER TO postgres;

--
-- TOC entry 376 (class 1259 OID 222060)
-- Name: vw_capital; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_capital AS
 WITH equity_preference AS (
         SELECT tbl_capital_child.parent_id,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'e'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN tbl_capital_child.shares
                    ELSE (0)::numeric
                END) AS totalshares_e,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'e'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN tbl_capital_child.share_value
                    ELSE (0)::numeric
                END) AS totalsharevalue_e,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'e'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN (tbl_capital_child.shares * tbl_capital_child.share_value)
                    ELSE (0)::numeric
                END) AS grandtotal_e,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'p'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN tbl_capital_child.shares
                    ELSE (0)::numeric
                END) AS totalshares_p,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'p'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN tbl_capital_child.share_value
                    ELSE (0)::numeric
                END) AS totalsharevalue_p,
            sum(
                CASE
                    WHEN ((tbl_capital_child.child_type = 'p'::text) AND (tbl_capital_child.deleted_on IS NULL)) THEN (tbl_capital_child.shares * tbl_capital_child.share_value)
                    ELSE (0)::numeric
                END) AS grandtotal_p
           FROM public.tbl_capital_child
          GROUP BY tbl_capital_child.parent_id
        )
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.type,
    a.event_date,
    a.unclassified,
    a.total_capital,
    a.incorporate_agenda,
    a.meeting_date,
    a.meeting_time,
    a.existing_meeting,
    a.authorized_signatory,
    a.meeting_type,
    a.incorporate_agenda_gm,
    a.general_meeting_date,
    a.general_meeting_time,
    a.existing_agm,
    a.existing_egm,
    a.aoa_clause,
    u.name AS ref_user_name,
    format('{"totalShares": %s, "totalShareValue": %s, "grandTotal": %s}'::text, COALESCE(ep.totalshares_e, (0)::numeric), COALESCE(ep.totalsharevalue_e, (0)::numeric), COALESCE(ep.grandtotal_e, (0)::numeric)) AS equity,
    format('{"totalShares": %s, "totalShareValue": %s, "grandTotal": %s}'::text, COALESCE(ep.totalshares_p, (0)::numeric), COALESCE(ep.totalsharevalue_p, (0)::numeric), COALESCE(ep.grandtotal_p, (0)::numeric)) AS preference
   FROM ((public.tbl_capital a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
     LEFT JOIN equity_preference ep ON ((ep.parent_id = a.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_capital OWNER TO postgres;

--
-- TOC entry 403 (class 1259 OID 223292)
-- Name: vw_charge; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_charge AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.purpose,
    a.jurisdiction_police_station,
    a.form_purpose,
    a.charge_identification_no,
    a.whether_charge_is_modified,
    a.whether_charge_holder_is_authorized,
    a.charge_type,
    a.other_desc_of_charge,
    a.whether_consortium_finance_is_involved,
    a.banker_name,
    a.whether_joint_charge_involved,
    a.no_of_charge_holders,
    a.whether_charger_rank_pari_passu,
    a.category,
    a.others,
    a.name_of_charge_holder,
    a.cin_arc_assignee,
    a.name_based_on_cin,
    a.address1_based_on_cin,
    a.address2_based_on_cin,
    a.country_based_on_cin,
    a.pin_based_on_cin,
    a.area_based_on_cin,
    a.city_based_on_cin,
    a.district_based_on_cin,
    a.state_based_on_cin,
    a.email_id_based_on_cin,
    a.jurisdiction_police_station2,
    a.brs_code,
    a.whether_charge_holder_having_pan,
    a.panno,
    a.nature_of_instrument,
    a.date_of_instrument_create,
    a.description_of_instrument,
    a.date_of_instrument_modify,
    a.date_of_satisfaction_full,
    a.charge_modified_india,
    a.date_of_receipt_documents_in_india,
    a.maximum_amount_secured_charge,
    a.maximum_amount_secured_charge_words,
    a.foreign_currency_details,
    a.date_of_creating,
    a.borrower_account_number,
    a.rate_of_interest,
    a.repayment_term,
    a.terms_of_repayment,
    a.nature_of_facility,
    a.date_of_disbursement,
    a.miscellaneous_narrative_information,
    a.margin,
    a.extent_operation_charge,
    a.others1,
    a.date_of_instrument,
    a.date_of_acquisition,
    a.charge_id,
    a.amount_charge,
    a.particulars_of_property,
    a.short_particulars,
    a.whether_plot_or_dwelling_interest,
    a.plot_unit_evaluated_price,
    a.plot_unit_nature_of_property,
    a.plot_unit_plot_id_number,
    a.plot_unit_survey_number_or_gat_number,
    a.dwelling_interest_dwelling_unit_id,
    a.dwelling_interest_floor_number,
    a.name_of_building_society,
    a.street_number_and_name,
    a.sector_block_number,
    a.pin_code,
    a.landmark,
    a.village,
    a.taluka,
    a.area_locality,
    a.district,
    a.state,
    a.latitude,
    a.longitude,
    a.plot_area,
    a.dwelling_area,
    a.bounded_by_north,
    a.bounded_by_south,
    a.bounded_by_east,
    a.bounded_by_west,
    a.whether_property_or_interest_register,
    a.register_pan_no,
    a.llpid_of_company,
    a.in_whose_name_it_is_registered,
    a.date_of_creation_modification,
    a.particulars_of_present_modification2,
    a.partner_din,
    a.income_tax_pan,
    a.designation_of_charge_holder,
    a.designation_of_arc_assignee,
    a.certified_by,
    a.category1,
    a.name_of_pcs,
    a.professional_type,
    a.certificate_membership_practice,
    a.instrument_file,
    a.evidence_file,
    a.optional_attachment,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_charge a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_charge OWNER TO postgres;

--
-- TOC entry 432 (class 1259 OID 230265)
-- Name: vw_chg1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_chg1 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_email,
    a.company_address,
    a.registration,
    a.modification_charge_id,
    a.applicant,
    a.instrument_date,
    a.charge,
    a.natureanddescription,
    a.chk_interest,
    a.chk_movable_property,
    a.chk_intangible_licence,
    a.chk_commercial,
    a.chk_copy_right_patent,
    a.chk_licence,
    a.chk_interest_there_in,
    a.chk_property_situated,
    a.chk_calls,
    a.chk_inventory,
    a.chk_trade_marks,
    a.chk_intangible_patent,
    a.chk_ship,
    a.chk_licence_under_patent,
    a.chk_intangible_copy_right,
    a.chk_equipment_machinery,
    a.chk_intangible_designs,
    a.chk_intangible_ipr,
    a.chk_motor_vehicle,
    a.chk_intangible_others,
    a.chk_uncalled_capital,
    a.chk_movable_property_others,
    a.chk_book_debts,
    a.chk_others,
    a.chk_consortium_finance,
    a.banker_name,
    a.chk_joint_charge_involved,
    a.number_of_charge_holder,
    a.chk_pari_passu,
    a.category,
    a.charge_holder,
    a.applicable_cin,
    a.name,
    a.address_line1,
    a.address_line2,
    a.country,
    a.zip,
    a.area,
    a.city,
    a.district,
    a.state,
    a.email_id,
    a.branch_code,
    a.valid_pan,
    a.tax_pan,
    a.secured_charge,
    a.secured_amount,
    a.security_interest_date,
    a.account_number,
    a.interest_rate,
    a.repayment_term,
    a.terms_of_repayment,
    a.nature_facility,
    a.date_of_disbursement,
    a.narrative_information,
    a.margin,
    a.operation_charge,
    a.other,
    a.evidence_charge,
    a.instrument_description_charge,
    a.date_of_acquisition,
    a.charge_id,
    a.charge_amount,
    a.property_charge,
    a.property_or_assets,
    a.number_of_title,
    a.document_title,
    a.registered_property,
    a.individual_pan,
    a.registered_name,
    a.chk_authorised,
    a.resolution_number,
    a.declaration_date,
    a.terms,
    a.designation,
    a.manager_pan,
    a.checkbox3,
    a.checkbox4,
    a.pan_charge_holder,
    a.pan_assignee,
    a.professional_type,
    a.modification_charge,
    a.professional_flag,
    a.nameofpcs,
    a.member_ship_number,
    u.name AS ref_user_name
   FROM (public.tbl_chg1 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_chg1 OWNER TO postgres;

--
-- TOC entry 455 (class 1259 OID 230641)
-- Name: vw_chg4; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_chg4 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.satisfaction_date,
    a.charge_creation_number,
    a.rca_user,
    a.is_valid_satisfaction_date,
    a.reason_of_delay,
    a.required_application,
    a.is_company,
    a.is_satisfied_charge,
    a.chg_holder_name,
    a.other_cin,
    a.chg_name,
    a.chg_email,
    a.chg_address,
    a.charge_creation_date,
    a.last_modified_date,
    a.secured_amount,
    a.secured_amount_in_words,
    a.foreign_currency,
    a.authorised,
    a.resolution_number,
    a.declaration_date,
    a.chk_declaration,
    a.designation,
    a.manager_pan,
    a.declaration,
    a.tax_declaration,
    a.pan_charge_holder,
    a.pan_assignee,
    a.signed_by_designation,
    a.signed_by_pan,
    a.signed_by_email_id,
    a.modification_charge,
    a.professional_type,
    a.professional_flag,
    a.company_secretary,
    a.membership_number,
    a.instrument_creating,
    a.optional_attachment,
    u.name AS ref_user_name
   FROM (public.tbl_chg4 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_chg4 OWNER TO postgres;

--
-- TOC entry 257 (class 1259 OID 180579)
-- Name: vw_chg6; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_chg6 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.filled_by,
    a.notice_type,
    a.pan_number,
    a.receiver_name,
    a.address_line1,
    a.address_line2,
    a.country,
    a.zip_code,
    a.locality,
    a.city,
    a.district,
    a.state,
    a.appointment_date,
    a.appointment_type,
    a.number_of_charges,
    a.pan_number2,
    u.name AS ref_user_name
   FROM (public.tbl_chg6 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_chg6 OWNER TO postgres;

--
-- TOC entry 260 (class 1259 OID 180600)
-- Name: vw_chg8; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_chg8 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.condonation_type,
    a.type_of_charge,
    a.application_made_by,
    a.relevant_form,
    a.srn_of_form_selected,
    a.charge_identification_number,
    a.date_of_creation_modification_satisfaction,
    a.amount_of_charge_created_modified_satisfied,
    a.names_of_charge_holders,
    a.property_or_asset_details,
    a.reasons_for_delay_omission_misstatement,
    a.declaration_name,
    a.resolution_no,
    a.declaration_date,
    a.member_designation,
    a.member_id,
    u.name AS ref_user_name
   FROM (public.tbl_chg8 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_chg8 OWNER TO postgres;

--
-- TOC entry 263 (class 1259 OID 180627)
-- Name: vw_chg9; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_chg9 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.form_registration_for,
    a.applicant_type,
    a.resolution_no,
    a.declaration_date,
    a.member_designation,
    a.member_id,
    a.pan_of_charge_holder,
    a.pan_assignee,
    a.signed_by_designation,
    a.signed_by_pan,
    a.signed_by_email_id,
    a.professional_type,
    a.professional_flag,
    u.name AS ref_user_name
   FROM (public.tbl_chg9 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_chg9 OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 163574)
-- Name: vw_company; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_company AS
 SELECT c.id,
    c.company_name,
    c.cin,
    c.cin_updated_on,
    c.incorporation_date,
    c.company_contact_no,
    c.email,
    c.address,
    c.company_type,
    c.pan,
    c.gst_no,
    c.website,
    c.created_by,
    c.created_on,
    c.updated_by,
    c.updated_on,
    c.deleted_on,
    c.ref_user,
    c.is_active,
    u.name AS ref_user_name
   FROM (public.tbl_company c
     LEFT JOIN public.tbl_user u ON ((c.ref_user = u.id)))
  WHERE (c.deleted_on IS NULL)
  ORDER BY c.company_name;


ALTER VIEW public.vw_company OWNER TO postgres;

--
-- TOC entry 303 (class 1259 OID 196523)
-- Name: vw_company_notice; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_company_notice AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.is_active,
    a.issue_date,
    a.meeting_date,
    a.type,
    a.resolution
   FROM (public.tbl_company_notice a
     LEFT JOIN public.tbl_company b ON ((a.company_id = b.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.meeting_date;


ALTER VIEW public.vw_company_notice OWNER TO postgres;

--
-- TOC entry 241 (class 1259 OID 180236)
-- Name: vw_debenture; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_debenture AS
 SELECT a.first_name,
    a.middle_name,
    a.last_name,
    a.category,
    a.sub_category,
    a.under_sub_category,
    a.has_valid_din,
    a.director,
    a.gender,
    a.pan,
    a.dob,
    a.email,
    a.mobile,
    a.marital_status,
    a.guardian,
    a.cin_reg_no,
    a.date_of_incorporation_reg,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.type,
    a.shareholder,
    a.id,
    a.salutation,
    u.name AS ref_user_name
   FROM (public.tbl_debenture a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.first_name, a.middle_name, a.last_name;


ALTER VIEW public.vw_debenture OWNER TO postgres;

--
-- TOC entry 281 (class 1259 OID 180826)
-- Name: vw_dir11; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir11 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.director,
    a.director_name,
    a.nationality,
    a.appointment_date,
    a.designation,
    a.category,
    a.filing_date,
    a.effective_resignation_date,
    a.resignation_reason,
    a.other_reason_details,
    a.confirmation_received,
    a.director_name2,
    a.din,
    u.name AS ref_user_name
   FROM (public.tbl_dir11 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dir11 OWNER TO postgres;

--
-- TOC entry 284 (class 1259 OID 180855)
-- Name: vw_dir12; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir12 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.num_managing_directors,
    a.num_kmp,
    a.srn_inc28,
    a.designation,
    a.director_id,
    a.authorized_person,
    a.authorization_details,
    a.authorization_date,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_dir12 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dir12 OWNER TO postgres;

--
-- TOC entry 269 (class 1259 OID 180732)
-- Name: vw_dir3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir3 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.is_citizen_of_india,
    a.passport_size_photograph,
    a.applicant_first_name,
    a.applicant_middle_name,
    a.applicant_last_name,
    a.father_first_name,
    a.father_middle_name,
    a.father_last_name,
    a.nationality,
    a.is_resident_in_india,
    a.occupation_type,
    a.educational_qualification,
    a.date_of_birth,
    a.gender,
    a.income_tax_permanent_account_number,
    a.income_tax_pan_file,
    a.has_aadhaar,
    a.aadhaar_number,
    a.aadhaar_file,
    a.voter_id_number,
    a.voter_id_file,
    a.passport_number,
    a.passport_file,
    a.driving_license_number,
    a.driving_license_file,
    a.address_line1,
    a.address_line2,
    a.country,
    a.pin_code,
    a.area_locality,
    a.city,
    a.district,
    a.state_ut,
    a.jurisdiction_police_station,
    a.phone,
    a.fax,
    a.email,
    a.is_address_same,
    a.present_address_line1,
    a.present_address_line2,
    a.present_country,
    a.present_pin_code,
    a.present_area_locality,
    a.present_city,
    a.present_district,
    a.present_state_ut,
    a.present_jurisdiction_police_station,
    a.present_phone,
    a.present_fax,
    a.verification_name,
    a.verification_fathers_name,
    a.verification_dob,
    a.verification_address,
    a.security_clearance,
    a.category_select,
    a.director_dpin_or_pan_or_membership_number,
    a.category_select_duplicate,
    u.name AS ref_user_name
   FROM (public.tbl_dir3 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dir3 OWNER TO postgres;

--
-- TOC entry 272 (class 1259 OID 180747)
-- Name: vw_dir5; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir5 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.reason_for_surrender,
    a.retaining_din,
    a.din_to_retain,
    a.first_name,
    a.middle_name,
    a.last_name,
    a.father_first_name,
    a.father_middle_name,
    a.father_last_name,
    a.dob,
    a.pan,
    a.num_of_dins_surrendered,
    a.is_digitally_signed,
    a.other_information,
    a.name,
    a.id_number,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_dir5 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dir5 OWNER TO postgres;

--
-- TOC entry 275 (class 1259 OID 180774)
-- Name: vw_dir6; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir6 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.director_din,
    a.director_name,
    a.photograph,
    a.citizen_of_india,
    a.director_first_name,
    a.director_middle_name,
    a.director_last_name,
    a.father_first_name,
    a.father_middle_name,
    a.father_last_name,
    a.nationality,
    a.is_resident_in_india,
    a.dob,
    a.gender,
    a.pan_number,
    a.pan_attachment,
    a.aadhaar_number,
    a.aadhaar_attachment,
    a.voter_id_number,
    a.voter_id_attachment,
    a.passport_number,
    a.passport_attachment,
    a.driving_license_number,
    a.driving_license_attachment,
    a.permanent_address_line_1,
    a.permanent_address_line_2,
    a.permanent_country,
    a.permanent_pin_code,
    a.permanent_area,
    a.permanent_city,
    a.permanent_district,
    a.permanent_state,
    a.permanent_police_station,
    a.phone,
    a.fax,
    a.same_address,
    a.present_address_line_1,
    a.present_address_line_2,
    a.present_country,
    a.present_pin_code,
    a.present_area,
    a.present_city,
    a.present_district,
    a.present_state,
    a.present_police_station,
    a.present_phone,
    a.present_fax,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_dir6 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.director_name;


ALTER VIEW public.vw_dir6 OWNER TO postgres;

--
-- TOC entry 278 (class 1259 OID 180812)
-- Name: vw_dir9; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dir9 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.roc_alert,
    a.disqualification_section,
    a.num_directors,
    a.reason_11642b,
    a.repay_deposit_date,
    a.repay_deposit_expire,
    a.reason_21642b,
    a.pay_deposit_due,
    a.pay_deposit_expire,
    a.reason_31642b,
    a.failed_to_redeem,
    a.failed_to_redeem_expire,
    a.reason_41642b,
    a.debentures_redeem,
    a.debentures_redeem_expire,
    a.reason_51642b,
    a.dividend_date,
    a.dividend_expire,
    a.resolution_date,
    a.designation,
    a.signatory,
    a.din_pan,
    u.name AS ref_user_name
   FROM (public.tbl_dir9 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dir9 OWNER TO postgres;

--
-- TOC entry 251 (class 1259 OID 180409)
-- Name: vw_director; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_director AS
 SELECT a.id,
    a.first_name,
    a.middle_name,
    a.last_name,
    a.din,
    a.pan,
    a.mobile,
    a.aadhar,
    a.email,
    a.dsc_expiry,
    a.din_status,
    a.dir_kyc_status,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.din_updated_on,
    a.passport,
    a.salutation,
    u.name AS ref_user_name
   FROM (public.tbl_director a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.first_name, a.middle_name, a.last_name;


ALTER VIEW public.vw_director OWNER TO postgres;

--
-- TOC entry 474 (class 1259 OID 231931)
-- Name: vw_director_appointment; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_director_appointment AS
 SELECT a.id,
    a.company_id,
    a.cin,
    a.company_name,
    a.category,
    a.sub_category,
    a.appointee_type,
    a.bank_name,
    a.nom_auth_sign,
    a.nom_auth_desi,
    a.nom_auth_din_pan,
    a.nom_auth_date,
    a.nom_auth_place,
    a.type_meeting,
    a.exist_meeting,
    a.existing_meeting,
    a.meeting_date,
    a.timing,
    a.circular_res_date,
    a.chairman,
    a.which_meeting,
    a.exist_meeting_agm,
    a.m_id_agm,
    a.m_id_egm,
    a.meeting_date_agm,
    a.timing_agm,
    a.din,
    a.appointee_name,
    a.f_name,
    a.gender,
    a.dob,
    a.address,
    a.email,
    a.mobile,
    a.pan,
    a.nationality,
    a.occupation,
    a.date_appointment,
    a.date_consent,
    a.place_consent,
    a.issecurity_clear,
    a.ismem_institute,
    a.institue_name,
    a.membership_no,
    a.practice_no,
    a.date_of_signing,
    a.place_of_consent,
    a.date_of_signing_consent,
    a.place_of_consent_consent,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    u.name AS ref_user_name
   FROM (public.tbl_action_director_appointment a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_director_appointment OWNER TO postgres;

--
-- TOC entry 266 (class 1259 OID 180718)
-- Name: vw_dpt3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dpt3 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.type,
    a.form_purpose,
    a.is_gov,
    a.company_objects,
    a.deposit_accepted,
    a.return_period,
    a.date_of_issue,
    a.date_of_expiry,
    a.paid_up_share_capital,
    a.free_reserves,
    a.securities_premium_account,
    a.accumulated_loss,
    a.deferred_revenue_expenditure_balance,
    a.accumulated_unprovided_depreciation,
    a.miscellaneous_expense,
    a.other_intangible_assets,
    a.net_worth,
    a.deposit_max_limit,
    a.total_deposit_holders_start,
    a.total_deposit_holders_end,
    a.existing_deposits_start,
    a.deposits_renewed,
    a.secured_deposits,
    a.unsecured_deposits,
    a.deposits_repaid,
    a.deposits_outstanding,
    a.matured_not_claimed,
    a.matured_claimed_not_paid,
    a.deposits_maturing_before_march,
    a.deposits_maturing_following_next_year,
    a.amount_required_in_liquid_assets,
    a.current_deposits_free_from_charge,
    a.face_value_gov_securities,
    a.market_value_gov_securities,
    a.face_value_trust_securities,
    a.market_value_trust_securities,
    a.credit_rating_agency,
    a.credit_rating,
    a.credit_rating_date,
    a.gnl_form_srn,
    a.auditor_name,
    a.auditor_designation,
    a.membership_number,
    a.resolution_number,
    a.declaration_date,
    a.signatory_designation,
    a.signatory_id,
    u.name AS ref_user_name
   FROM (public.tbl_dpt3 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dpt3 OWNER TO postgres;

--
-- TOC entry 254 (class 1259 OID 180452)
-- Name: vw_dpt4; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_dpt4 AS
 SELECT a.id,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.company_type,
    a.is_gov,
    a.amt,
    a.number_of_depositors,
    a.deposits_due_but_not_paid,
    a.interest_due_there_on_but_not_paid,
    a.deposits_due_but_not_claimed,
    a.interest_due_there_on_but_not_claimed,
    a.deposits_not_yet_due_for_repayment,
    a.deposits_due_for_repayment_three_months,
    a.arrangement_for_repayment_deposits_due,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.resolution_no,
    a.resolution_date,
    u.name AS ref_user_name
   FROM (public.tbl_dpt4 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_dpt4 OWNER TO postgres;

--
-- TOC entry 391 (class 1259 OID 222790)
-- Name: vw_form11; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form11 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.financial_year_from_date,
    a.financial_year_to_date,
    a.offence_date_11,
    a.offence_1,
    a.offence_2,
    a.offence_3,
    a.jurisdiction_police_station_address,
    a.other_address_under_13c,
    a.jurisdiction_police_station_other_address,
    a.business_classification,
    a.business_principal_activities,
    a.total_number_of_designated_partners,
    a.total_number_of_partners,
    a.total_obligation_of_contribution,
    a.total_contribution_received_from,
    a.invi_partner_data,
    a.bodycor_partner_data,
    a.number_of_partner_1,
    a.number_of_partner,
    a.resident_in_india,
    a.other_resident,
    a.number_of_partner_2,
    a.resident_in_india_2,
    a.other_resident_2,
    a.number_of_partner_3,
    a.resident_in_india_3,
    a.other_resident_3,
    a.number_of_partner_4,
    a.resident_in_india_4,
    a.other_resident_4,
    a.total_partner_1,
    a.total_partner_2,
    a.total_partner_3,
    a.total_partner_4,
    a.total_partner_5,
    a.total_partner_6,
    a.total_partner_7,
    a.total_partner_8,
    a.number_of_partner_5,
    a.resident_in_india_5,
    a.other_resident_5,
    a.number_of_partner_6,
    a.resident_in_india_6,
    a.other_resident_6,
    a.number_of_partner_7,
    a.resident_in_india_7,
    a.other_resident_7,
    a.number_of_partner_8,
    a.resident_in_india_8,
    a.other_resident_8,
    a.rows_required_10a,
    a.section_number,
    a.penalty_imp,
    a.penalty_imposed,
    a.rows_required_10b,
    a.dpin_pan_passport,
    a.name_of_partner,
    a.nominee_name,
    a.section_num,
    a.rows_required_11a,
    a.section_number_11,
    a.offense_date_11,
    a.turn_over_of_the_llp_exceeds_5cr,
    a.attachment_file,
    a.name_of_person_signing,
    a.designation_of_person,
    a.id_of_person_signing,
    a.annual_return_certify,
    a.dpin_designated_partner_textbox,
    a.here_by_certified,
    a.company_name_2,
    a.certi_practice_no_box,
    a.whether_associate_or_fellow,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form11 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form11 OWNER TO postgres;

--
-- TOC entry 397 (class 1259 OID 222887)
-- Name: vw_form12; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form12 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.llp_name,
    a.jurisdiction_police_station,
    a.address_line1,
    a.address_line2,
    a.country,
    a.pin_code,
    a.area_locality,
    a.city,
    a.district,
    a.latitude,
    a.state,
    a.longitude,
    a.phone,
    a.fax,
    a.jurisdiction_police_station2,
    a.reason_change_address,
    a.clause_reference,
    a.relevant_extract,
    a.consent_date,
    a.verified_status,
    a.authorised_status,
    a.partner_din,
    a.dpin,
    a.records_certified,
    a.professional_practice,
    a.name_of_pcs,
    a.professional_type,
    a.membership_number,
    a.instrument_creating,
    a.affidavit,
    a.charge_holder,
    a.attachment_file,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form12 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form12 OWNER TO postgres;

--
-- TOC entry 400 (class 1259 OID 223167)
-- Name: vw_form15; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form15 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.llp_name,
    a.jurisdiction_of_police_station,
    a.purpose,
    a.address_line1,
    a.address_line2,
    a.country,
    a.pin_code,
    a.area_locality,
    a.city,
    a.latitude,
    a.state,
    a.district,
    a.longitude,
    a.new_jurisdiction_of_police_station,
    a.prosecution_pending,
    a.case_number,
    a.section_prosecution_pending,
    a.act_name_prosecution_pending,
    a.stage_prosecution_pending,
    a.court_name_prosecution_pending,
    a.case_details,
    a.application_pending,
    a.brief_details,
    a.date_publication_in_english,
    a.date_publication_in_vernacular,
    a.newspaper_name_publication_in_english,
    a.newspaper_name_publication_in_vernaular,
    a.brief_details_objection_received,
    a.change_in_address,
    a.date_of_consent_partners,
    a.clause_reference_llp_agreement,
    a.relevant_extract_llp_agreement,
    a.consent_of_secured_creditors,
    a.date_of_consent_taken_of_creditors,
    a.verification_check_box1,
    a.verification_check_box2,
    a.verification_check_box3,
    a.d_pin,
    a.particulars_record,
    a.to_be_digitally_signed_by_member,
    a.name_of_pcs,
    a.whether_associate,
    a.membership_number,
    a.instrument_creating,
    a.affidavit,
    a.charge_holder,
    a.attachment_file,
    a.partner_din,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form15 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form15 OWNER TO postgres;

--
-- TOC entry 412 (class 1259 OID 223448)
-- Name: vw_form22; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form22 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.jurisdiction_of_police_station,
    a.order_passed,
    a.name_of_order_passed,
    a.location,
    a.specify_others,
    a.application_number,
    a.order_number,
    a.date_of_passing_order,
    a.relevant_act,
    a.section_of_llp_2008,
    a.section_of_insolvency,
    a.no_of_days,
    a.other_section_details,
    a.other_section_description,
    a.application_date,
    a.issue_date,
    a.due_date,
    a.description_order,
    a.compounding_srn,
    a.offence_srn,
    a.form_31_srn,
    a.srn_form_22,
    a.whether_cost_involved,
    a.details_of_cost_paid,
    a.registration_no_irp,
    a.pan_number_irp,
    a.name_irp,
    a.mobile_no_irp,
    a.email_irp,
    a.address_line_1_irp,
    a.address_line_2_orp,
    a.country_irp,
    a.pin_code_irp,
    a.locality_irp,
    a.city_irp,
    a.state_irp,
    a.district_irp,
    a.attachment_file,
    a.verification_checkbox_1,
    a.verification_checkbox_2,
    a.designation_auth,
    a.name_auth_representative,
    a.name_designated_partner,
    a.dpin_partner,
    a.capacity,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form22 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form22 OWNER TO postgres;

--
-- TOC entry 406 (class 1259 OID 223372)
-- Name: vw_form23; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form23 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.catagory,
    a.line2,
    a.country,
    a.pin_code,
    a.area,
    a.city,
    a.district,
    a.state,
    a.jurisdiction_police_station,
    a.phone_no,
    a.mobile_no,
    a.llpin,
    a.name_llp,
    a.email_id1,
    a.registered_llp,
    a.grounds_of_objection,
    a.self_declaration,
    a.provision_declaration,
    a.authorized_declaration,
    a.designation,
    a.designation_name,
    a.dpin_number,
    a.authority,
    a.attachment_file,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form23 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form23 OWNER TO postgres;

--
-- TOC entry 409 (class 1259 OID 223423)
-- Name: vw_form24; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form24 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.application_reason,
    a.is_action_initiated,
    a.income_tax_updated,
    a.ceased_llp_date,
    a.llp_under_law,
    a.regulator_name,
    a.noc_approval_date,
    a.prosecutions_pending,
    a.number_of_prosecutions,
    a.statement_of_acc_date,
    a.capital,
    a.reserves_and_surplus,
    a.secured_loans_from_fi,
    a.secured_loans_from_bank,
    a.secured_loans_from_govt,
    a.others_secured_loans,
    a.debentures,
    a.unsecured_loans,
    a.deposits_and_interest,
    a.total_loan_funds,
    a.total,
    a.fixed_assets,
    a.investments,
    a.current_assets,
    a.creditors,
    a.unpaid_dividend,
    a.payables,
    a.others,
    a.total_current_liabilities,
    a.net_current_assets,
    a.miscellaneous_expenditure,
    a.profit_and_loss_account,
    a.total2,
    a.name,
    a.place,
    a.designation,
    a.membership_number,
    a.partner_name,
    a.partner_dpin,
    a.self_declaration,
    a.assets_declaration,
    a.liability_declaration,
    a.authority_copy,
    a.acknowledgment_copy,
    a.statement_copy,
    a.return_copy,
    a.order_copy,
    a.signed_affidavit,
    a.optional_attachment,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form24 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form24 OWNER TO postgres;

--
-- TOC entry 351 (class 1259 OID 221530)
-- Name: vw_form4; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form4 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.num_indiv_desig_partner,
    a.num_bodies_corp_nominees,
    a.num_indiv_partner,
    a.num_bodies_corp_partners,
    a.total_partners,
    a.designated_partner,
    a.dpin_designated_partner,
    a.professional_category,
    a.selected_pcs,
    a.membership_type,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_form4 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form4 OWNER TO postgres;

--
-- TOC entry 379 (class 1259 OID 222136)
-- Name: vw_form5; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_form5 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.number_partnership,
    a.llp_name,
    a.srn_run,
    a.llp_new_name,
    a.police_station_jurisdiction,
    a.change_name_declaration,
    a.srn_of_3,
    a.name_change_1,
    a.name_change_2,
    a.name_change_3,
    a.name_change_4,
    a.number_clause,
    a.extract_relevant,
    a.date_of_consent,
    a.statements_1,
    a.statements_2,
    a.designation,
    a.designated_partners,
    a.professional_practice,
    a.name_of_pcs,
    a.professional_type,
    a.practice_number,
    a.consent_partners,
    a.minutes,
    a.central,
    a.registrar,
    a.attachment_add,
    a.attachment_file,
    a.company_address_llp,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_form5 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_form5 OWNER TO postgres;

--
-- TOC entry 424 (class 1259 OID 223832)
-- Name: vw_gnl1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_gnl1 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.applicant_category,
    a.corporate_gln,
    a.name,
    a.address_line1,
    a.address_line2,
    a.city,
    a.state,
    a.iso_code,
    a.country,
    a.pin_code,
    a.email,
    a.filed_for,
    a.others,
    a.application_details,
    a.filed_company,
    a.filed_director,
    a.filed_manager,
    a.filed_other,
    a.persons_filed,
    a.application_filed,
    a.notice_number,
    a.section_filed,
    a.particulars_brief,
    a.agm_date,
    a.srn_mgt14,
    a.date_passing,
    a.mgt14_date,
    a.stamp_duty_amount,
    a.director_authorization,
    a.resolution_no,
    a.resolution_date,
    a.self_declaration,
    a.designation,
    a.declaration,
    a.din,
    a.digitally_signed_by,
    a.name_of_pcs,
    a.associate_or_fellow,
    a.membership_number,
    a.cert_practise_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_gnl1 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_gnl1 OWNER TO postgres;

--
-- TOC entry 329 (class 1259 OID 221129)
-- Name: vw_gnl2; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_gnl2 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.filed_document,
    a.issued_advertisement_date,
    a.opening_acceptance,
    a.expected_advertisement_date,
    a.others,
    a.reference_act,
    a.companies_act,
    a.srn,
    a.special_resolutiondate,
    a.event_date,
    a.directors_date,
    a.prospectus_document,
    a.herring_document,
    a.advertisement_document,
    a.placement_document,
    a.companies_document,
    a.companies_rules_document,
    a.companies153_document,
    a.companies154_document,
    a.companies156_document,
    a.companies157_document,
    a.companies158_document,
    a.companies159_document,
    a.liquidation_document,
    a.relevant_document,
    a.financial_document,
    a.valuation_document,
    a.optional_attachment,
    a.designation,
    a.resolution_date,
    a.name,
    a.capacity,
    a.din,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_gnl2 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_gnl2 OWNER TO postgres;

--
-- TOC entry 332 (class 1259 OID 221170)
-- Name: vw_gnl3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_gnl3 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.number_charged,
    a.permission_withdrawn,
    a.consent_date,
    a.resolution_date,
    a.copy_attachment,
    a.optional_attachment,
    a.director_resolution,
    a.director_date,
    a.certification_declaration,
    a.din_of_person_charged,
    a.designation,
    a.din,
    a.category,
    a.whole,
    a.name_of_pcs,
    a.associate_or_fellow,
    a.membership_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_gnl3 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_gnl3 OWNER TO postgres;

--
-- TOC entry 394 (class 1259 OID 222847)
-- Name: vw_iepf2; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_iepf2 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.purpose,
    a.sub_purpose,
    a.is_existing_nodal_officer,
    a.cin_of_holding_or_subsidiary,
    a.name_of_the_nodal_officer,
    a.first_name,
    a.middle_name,
    a.last_name,
    a.fathers_first_name,
    a.fathers_middle_name,
    a.fathers_last_name,
    a.dob,
    a.pan,
    a.designation,
    a.gender,
    a.official_address_line1,
    a.official_address_line2,
    a.country,
    a.pin_code,
    a.locality,
    a.city,
    a.district,
    a.state,
    a.phone_number,
    a.mobile_number,
    a.nodal_officer_email,
    a.dob_resolution,
    a.deputy_nodal_officer_added,
    a.deputy_nodal_officer_update,
    a.deputy_nodal_officer_ceased,
    a.financial_year_end_date,
    a.date_of_agm,
    a.registered_with_rbi,
    a.number_of_small_share_holders,
    a.number_of_small_depositors,
    a.unclaimed_dividend_fy1,
    a.unclaimed_dividend_fy2,
    a.unclaimed_dividend_fy3,
    a.unclaimed_dividend_fy4,
    a.unclaimed_dividend_fy5,
    a.unclaimed_dividend_fy6,
    a.unclaimed_dividend_fy7,
    a.unclaimed_dividend_total,
    a.underlying_shares_fy1,
    a.underlying_shares_fy2,
    a.underlying_shares_fy3,
    a.underlying_shares_fy4,
    a.underlying_shares_fy5,
    a.underlying_shares_fy6,
    a.underlying_shares_fy7,
    a.underlying_shares_total,
    a.refund_by_company_fy1,
    a.refunded_by_company_fy2,
    a.refunded_by_company_fy3,
    a.refunded_by_company_fy4,
    a.refunded_by_company_fy5,
    a.refunded_by_company_fy6,
    a.refunded_by_company_fy7,
    a.refunded_by_company_fytotal,
    a.recieved_under_sec38_fy1,
    a.recieved_under_sec38_fy2,
    a.recieved_under_sec38_fy3,
    a.recieved_under_sec38_fy4,
    a.recieved_under_sec38_fy5,
    a.recieved_under_sec38_fy6,
    a.recieved_under_sec38_fy7,
    a.recieved_under_sec38_fytotal,
    a.recieved_and_due_for_refund_fy1,
    a.recieved_and_due_for_refund_fy2,
    a.recieved_and_due_for_refund_fy3,
    a.recieved_and_due_for_refund_fy4,
    a.recieved_and_due_for_refund_fy5,
    a.recieved_and_due_for_refund_fy6,
    a.recieved_and_due_for_refund_fy7,
    a.recieved_and_due_for_refund_fytotal,
    a.matured_deposit_fy1,
    a.matured_deposit_fy2,
    a.matured_deposit_fy3,
    a.matured_deposit_fy4,
    a.matured_deposit_fy5,
    a.matured_deposit_fy6,
    a.matured_deposit_fy7,
    a.matured_deposit_fytotal,
    a.refund_by_comp_from_meture_deposit_fy1,
    a.refund_by_comp_from_meture_deposit_fy2,
    a.refund_by_comp_from_meture_deposit_fy3,
    a.refund_by_comp_from_meture_deposit_fy4,
    a.refund_by_comp_from_meture_deposit_fy5,
    a.refund_by_comp_from_meture_deposit_fy6,
    a.refund_by_comp_from_meture_deposit_fy7,
    a.refund_by_comp_from_meture_deposit_fytotal,
    a.amount_of_debentures_fy1,
    a.amount_of_debentures_fy2,
    a.amount_of_debentures_fy3,
    a.amount_of_debentures_fy4,
    a.amount_of_debentures_fy5,
    a.amount_of_debentures_fy6,
    a.amount_of_debentures_fy7,
    a.amount_of_debentures_fytotal,
    a.refund_by_comp_from_meture_debentures_fy1,
    a.refund_by_comp_from_meture_debentures_fy2,
    a.refund_by_comp_from_meture_debentures_fy3,
    a.refund_by_comp_from_meture_debentures_fy4,
    a.refund_by_comp_from_meture_debentures_fy5,
    a.refund_by_comp_from_meture_debentures_fy6,
    a.refund_by_comp_from_meture_debentures_fy7,
    a.refund_by_comp_from_meture_debentures_fytotal,
    a.intrest_accured_on_amounts_fy1,
    a.intrest_accured_on_amounts_fy2,
    a.intrest_accured_on_amounts_fy3,
    a.intrest_accured_on_amounts_fy4,
    a.intrest_accured_on_amounts_fy5,
    a.intrest_accured_on_amounts_fy6,
    a.intrest_accured_on_amounts_fy7,
    a.intrest_accured_on_amounts_fytotal,
    a.app_money_due_for_refund_fy1,
    a.app_money_due_for_refund_fy2,
    a.app_money_due_for_refund_fy3,
    a.app_money_due_for_refund_fy4,
    a.app_money_due_for_refund_fy5,
    a.app_money_due_for_refund_fy6,
    a.app_money_due_for_refund_fy7,
    a.app_money_due_for_refund_fytotal,
    a.matured_deposit_with_companey_fy1,
    a.matured_deposit_with_companey_fy2,
    a.matured_deposit_with_companey_fy3,
    a.matured_deposit_with_companey_fy4,
    a.matured_deposit_with_companey_fy5,
    a.matured_deposit_with_companey_fy6,
    a.matured_deposit_with_companey_fy7,
    a.matured_deposit_with_companey_fytotal,
    a.matured_debentures_with_companey_fy1,
    a.matured_debentures_with_companey_fy2,
    a.matured_debentures_with_companey_fy3,
    a.matured_debentures_with_companey_fy4,
    a.matured_debentures_with_companey_fy5,
    a.matured_debentures_with_companey_fy6,
    a.matured_debentures_with_companey_fy7,
    a.matured_debentures_with_companey_fy8,
    a.fractional_shares_fy1,
    a.fractional_shares_fy2,
    a.fractional_shares_fy3,
    a.fractional_shares_fy4,
    a.fractional_shares_fy5,
    a.fractional_shares_fy6,
    a.fractional_shares_fy7,
    a.fractional_shares_fytotal,
    a.redemption_amount_fy1,
    a.redemption_amount_fy2,
    a.redemption_amount_fy3,
    a.redemption_amount_fy4,
    a.redemption_amount_fy5,
    a.redemption_amount_fy6,
    a.redemption_amount_fy7,
    a.redemption_amount_fytotal,
    a.others_fy1,
    a.others_fy2,
    a.others_fy3,
    a.others_fy4,
    a.others_fy5,
    a.others_fy6,
    a.others_fy7,
    a.others_fytotal,
    a.total_fy1,
    a.total_fy2,
    a.total_fy3,
    a.total_fy4,
    a.total_fy5,
    a.total_fy6,
    a.total_fy7,
    a.total_fyamt,
    a.dividend_declaired_on_shares,
    a.other_benefits_declaired,
    a.investor_file,
    a.nodal_appointment,
    a.attachment_file,
    a.resolution_number,
    a.resolution_date,
    a.declaration_designation,
    a.declaration_membership_no,
    a.din_memebers,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_iepf2 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_iepf2 OWNER TO postgres;

--
-- TOC entry 375 (class 1259 OID 222055)
-- Name: vw_iepf5; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_iepf5 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.applicant_category,
    a.applicant_first_name,
    a.applicant_middle_name,
    a.applicant_last_name,
    a.applicant_fathers_first_name,
    a.applicant_fathers_middle_name,
    a.applicant_fathers_last_name,
    a.applicant_dob,
    a.type_of_entity,
    a.entity_identification_no,
    a.entity_name,
    a.entity_incorporate_date,
    a.applicant_address,
    a.applicant_phone_no,
    a.applicant_mobile_no,
    a.applicant_mobile_otp,
    a.applicant_email_id,
    a.applicant_email_otp,
    a.applicant_aadhar_no,
    a.aadhaar_attach,
    a.passport,
    a.passport_attach,
    a.applicant_pan,
    a.bcin,
    a.company_name_bank,
    a.company_reg_office_address,
    a.company_email_id,
    a.covered_rules,
    a.security_holder_name,
    a.security_holder_relation,
    a.no_nominee,
    a.death_certificate,
    a.will_certificate,
    a.no_objection_certificate,
    a.indemnity,
    a.other_doc,
    a.claim_type,
    a.number_of_folio,
    a.number_of_claims,
    a.bank_account_number,
    a.bank_name,
    a.ifsc_code,
    a.bank_branch,
    a.demat_account_number,
    a.clients_list,
    a.entitle,
    a.cheque,
    a.attachment_file,
    a.declaration,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_iepf5 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL);


ALTER VIEW public.vw_iepf5 OWNER TO postgres;

--
-- TOC entry 388 (class 1259 OID 222499)
-- Name: vw_inc12; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc12 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.company_type,
    a.category,
    a.sub_category,
    a.company_capital,
    a.authorized_capital,
    a.division,
    a.division_description,
    a.proposed_conversion,
    a.proposed_main_division_description,
    a.application_grounds,
    a.attachment_approval_noc,
    a.attachment_assets_liabilities,
    a.attachment_board_resolution,
    a.optional_attachment,
    a.authorized_person_name,
    a.resolution_number,
    a.resolution_date,
    a.signitory,
    a.din_director,
    a.membership_number,
    a.declaration_compliance,
    a.declaration_truthfulness,
    a.declaration_moa_aoa,
    a.professional_declaration_moa_aoa,
    a.professional_declaration_compliance,
    a.professional_category,
    a.whether_associate_fellow,
    a.designation,
    a.name_of_pcs,
    a.directors_number,
    a.first_designation,
    a.first_din,
    a.first_name,
    a.first_company,
    a.second_designation,
    a.second_din,
    a.second_name,
    a.second_company,
    a.managerial_key,
    a.articles_entrenched,
    a.no_of_articles,
    a.period_year1,
    a.estimated_income_year1,
    a.estimated_expenditure_year1,
    a.estimated_surplus_year1,
    a.remarks_year1,
    a.period_year2,
    a.estimated_income_year2,
    a.estimated_expenditure_year2,
    a.estimated_surplus_year2,
    a.remarks_year2,
    a.period_year3,
    a.estimated_income_year3,
    a.estimated_expenditure_year3,
    a.estimated_surplus_year3,
    a.remarks_year3,
    a.resolution_meeting_type,
    a.date_of_passing,
    a.mode_of_resolution,
    a.votes_in_favour,
    a.votes_against,
    a.srn_mgt14,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_inc12 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc12 OWNER TO postgres;

--
-- TOC entry 306 (class 1259 OID 196627)
-- Name: vw_inc20a; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc20a AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.longitude,
    a.latitude,
    a.is_regulated_by_sector,
    a.regulator_name,
    a.other_regulator_name,
    a.letter_number,
    a.approval_date,
    a.number_of_shareholders,
    a.resolution_number,
    a.resolution_date,
    a.director,
    a.director_din,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_inc20a a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc20a OWNER TO postgres;

--
-- TOC entry 287 (class 1259 OID 180955)
-- Name: vw_inc22; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc22 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.purpose_of_filing,
    a.registered_office_date,
    a.address_line1,
    a.address_line2,
    a.country,
    a.pin_code,
    a.area_locality,
    a.city,
    a.district,
    a.state_ut,
    a.longitude,
    a.latitude,
    a.declarant_name,
    a.designation,
    a.designation2,
    a.resolution_number,
    a.resolution_date,
    a.director_name,
    a.identification_number,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_inc22 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc22 OWNER TO postgres;

--
-- TOC entry 382 (class 1259 OID 222355)
-- Name: vw_inc23; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc23 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.fillig_purpose,
    a.filed_mgt14,
    a.request_number,
    a.state,
    a.office_roc,
    a.reason_shifting_office,
    a.is_objections,
    a.english_advertisement_date,
    a.vernacular_advertisement_date,
    a.brief_objection,
    a.prosecution,
    a.prosecution_details,
    a.inquiry,
    a.inspection,
    a.investigation,
    a.inspection_details,
    a.application_copy,
    a.service_acknowledgement_date,
    a.pending_application,
    a.pending_application_details,
    a.attorney,
    a.newspaper_adv,
    a.authority_proof,
    a.resolution_number,
    a.resolution_date,
    a.attachment_declaration,
    a.attachment_declaration2,
    a.authority_declaration,
    a.payment_declaration,
    a.jurisdiction_declaration,
    a.shifting_declaration,
    a.enquiry_declaration,
    a.declaration_designation,
    a.signatory,
    a.din,
    u.name AS ref_user_name
   FROM (public.tbl_inc23 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc23 OWNER TO postgres;

--
-- TOC entry 309 (class 1259 OID 196724)
-- Name: vw_inc28; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc28 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.order_passed_by,
    a.court_name,
    a.central_gov_office_name,
    a.debt_recovery_tribunal_name,
    a.competent_authority_name,
    a.location,
    a.petition_number,
    a.order_number,
    a.date_of_passing_order,
    a.relevant_act,
    a.order_filling_days,
    a.application_date,
    a.certified_copy_date,
    a.due_date_registrar,
    a.board_resolution_number,
    a.board_resolution_date,
    a.director_dsc,
    a.director_din,
    a.category_time,
    a.name_of_pcs,
    a.whether_associate,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_inc28 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc28 OWNER TO postgres;

--
-- TOC entry 415 (class 1259 OID 223602)
-- Name: vw_inc4; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_inc4 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.purpose,
    a.withdrwal_nominee_name,
    a.withdrawl_subscriber_name,
    a.withdrawl_date,
    a.subscriber_name,
    a.member_company_name,
    a.first_name,
    a.middle_name,
    a.last_name,
    a.intimation_date,
    a.nominee_name,
    a.cessation_subscr_name,
    a.cess_company_name,
    a.cesstion_date,
    a.due_reason,
    a.cessation_first_name,
    a.cessation_midd_name,
    a.cessation_last_name,
    a.sole_member,
    a.change_nominee_scr_name,
    a.either_member_or_new,
    a.nominee_company,
    a.nominee_first_name,
    a.nominee_midname,
    a.nominee_last_name,
    a.nominee_date,
    a.nominee_din,
    a.first_name_of_din,
    a.mid_name_of_din,
    a.sur_name_of_din,
    a.father_first_name,
    a.father_mid_name_of_din,
    a.father_surname,
    a.father_gender,
    a.father_dob,
    a.nationality,
    a.nominee_pan,
    a.place_of_birth,
    a.occupation,
    a.occupation_area,
    a.qualification,
    a.line1,
    a.line2,
    a.country,
    a.pin_code,
    a.area_locality,
    a.city,
    a.district,
    a.state,
    a.phone,
    a.mobile,
    a.fax,
    a.email_id,
    a.whether_address_same,
    a.present_line1,
    a.present_line2,
    a.present_country,
    a.present_pin_code,
    a.present_area_locality,
    a.present_city,
    a.present_district,
    a.present_state,
    a.present_address,
    a.presentaddressyears,
    a.identity_proof,
    a.identity_proof_no,
    a.identity_prf_doc,
    a.residental_proof,
    a.residental_proof_no,
    a.residental_proof_doc,
    a.declarant_nominee_name,
    a.declarant_company_name,
    a.event_death,
    a.optional_attachment,
    a.pan,
    a.designation,
    a.signatory,
    a.din,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_inc4 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_inc4 OWNER TO postgres;

--
-- TOC entry 333 (class 1259 OID 221185)
-- Name: vw_meeting; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_meeting AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.type,
    a.agm_fy,
    a.agm_number,
    a.eogm_requisition,
    a.date_notice,
    a.date_meeting,
    a.time_meeting,
    a.commencement_meeting,
    a.number_meeting,
    a.person_signing_notice,
    a.signing_meeting_place,
    a.meeting_mode,
    a.office_yes_no,
    a.name_dir,
    a.designation_dir,
    a.gender,
    a.last_date,
    a.phone_no,
    a.email_id,
    a.advance_consent_date,
    a.meeting_venue,
    a.venue_address,
    a.venue_state,
    a.venue_city,
    a.venue_pincode,
    a.signing_director,
    a.roc_address,
    a.signing_date,
    a.signing_place,
    a.query_registration_date,
    a.query_registration_time,
    a.query_registration_email,
    a.director_attend_electronically,
    a.special_invitee,
    a.create_general_meeting,
    a.type_of_meeting,
    a.existing_agm,
    a.existing_egm,
    a.general_meeting_date,
    a.general_meeting_time,
    a.agm_number_str,
    a.egm_place,
    a.authorized_signatory_1,
    a.authorized_signatory_2,
    a.chairperson_director,
    a.chairperson_member,
    a.chairperson_chairperson,
    a.chairperson_type,
    a.chairperson_role,
    a.meeting_time_concluded,
    a.entry_in_minutes_book_date,
    a.signing_minutes_place,
    a.signing_minutes_date,
    a.signing_attendance_place,
    a.signing_attendance_date,
    a.authorized_person_in_minutes,
    a.authorized_person_in_minutes_details,
    a.draft_minutes_circulated,
    a.communicated_comments,
    a.signed_minutes_circulated,
    a.ack_draft_url,
    a.ack_signed_url,
    a.ack_notice_url,
    a.reg_att_url,
    a.meet_dir_url,
    a.notice_url,
    a.minutes_url,
    a.ctc_url,
    u.name AS ref_user_name
   FROM (public.tbl_meeting a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL);


ALTER VIEW public.vw_meeting OWNER TO postgres;

--
-- TOC entry 323 (class 1259 OID 205006)
-- Name: vw_mgt14; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mgt14 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.designation,
    a.din,
    a.resolution_number,
    a.resolution_date,
    a.category_type,
    a.company_secretary,
    a.whether_assosiate_or_fellow,
    a.membership_number,
    a.resolution_copy,
    a.optional_attatchment,
    a.resolution,
    a.agreement,
    a.postal_ballot,
    a.notice_dispatch_date,
    a.passing_resolution_date,
    a.dispatch_ballot_date,
    a.postal_ballot_resolutiont_date,
    a.number_of_resolution,
    a.agreement_date,
    a.companies_act,
    a.agreement_purpose,
    a.agreement_subject,
    a.authority,
    a.srn,
    a.resolution_purpose,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_mgt14 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mgt14 OWNER TO postgres;

--
-- TOC entry 342 (class 1259 OID 221396)
-- Name: vw_mgt6; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mgt6 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.filed_registered,
    a.section89,
    a.person_declare,
    a.attachment_add,
    a.attachment_file,
    a.resolution_date,
    a.declaration_designation,
    a.declaration_membership_no,
    a.din_memebers,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_mgt6 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mgt6 OWNER TO postgres;

--
-- TOC entry 471 (class 1259 OID 231862)
-- Name: vw_mgt7a; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mgt7a AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.company_gln,
    a.pan,
    a.company_date_incorporation,
    a.company_website,
    a.telephone,
    a.type_of_company,
    a.category_company,
    a.sub_category_company,
    a.company_share_capital,
    a.form_filed,
    a.financial_year_from,
    a.financial_year_to,
    a.annual_general_meeting,
    a.date_amg,
    a.due_date_amg,
    a.extension_agm,
    a.srn_application_extention,
    a.due_date_agm2,
    a.reasons_specify,
    a.turn_over,
    a.net_worth,
    a.total_auth,
    a.total_iss,
    a.total_sub,
    a.total_paid,
    a.total_auth_amount,
    a.total_iss_amount,
    a.total_sub_amount,
    a.total_paid_amount,
    a.preference_shares_authorized_count,
    a.preference_shares_issued_count,
    a.preference_shares_subscribed_count,
    a.preference_shares_paid_up_count,
    a.preference_shares_authorized_amount,
    a.preference_shares_issued_amount,
    a.preference_shares_subscribed_amount,
    a.preference_shares_paid_up_amount,
    a.share_capital,
    a.equity_shares_at_beginning_number_of_shares,
    a.equity_shares_at_beginning_nominal_amount,
    a.equity_shares_at_beginning_paid_up_amount,
    a.equity_shares_at_beginning_premium,
    a.equity_shares_increase_number_of_shares,
    a.equity_shares_increase_nominal_amount,
    a.equity_shares_increase_paid_up_amount,
    a.equity_shares_increase_premium,
    a.public_issues_number_of_shares,
    a.public_issues_nominal_amount,
    a.public_issues_paid_up_amount,
    a.public_issues_premium,
    a.rights_issue_number_of_shares,
    a.rights_issue_nominal_amount,
    a.rights_issue_paid_up_amount,
    a.rights_issue_premium,
    a.bonus_issue_number_of_shares,
    a.bonus_issue_nominal_amount,
    a.bonus_issue_paid_up_amount,
    a.bonus_issue_premium,
    a.private_placement_number_of_shares,
    a.private_placement_nominal_amount,
    a.private_placement_paid_up_amount,
    a.private_placement_premium,
    a.esops_number_of_shares,
    a.esops_nominal_amount,
    a.esops_paid_up_amount,
    a.esops_premium,
    a.sweat_equity_number_of_shares,
    a.sweat_equity_nominal_amount,
    a.sweat_equity_paid_up_amount,
    a.sweat_equity_premium,
    a.preference_conversion_number_of_shares,
    a.preference_conversion_nominal_amount,
    a.preference_conversion_paid_up_amount,
    a.preference_conversion_premium,
    a.debenture_conversion_number_of_shares,
    a.debenture_conversion_nominal_amount,
    a.debenture_conversion_paid_up_amount,
    a.debenture_conversion_premium,
    a.gdr_adr_number_of_shares,
    a.gdr_adr_nominal_amount,
    a.gdr_adr_paid_up_amount,
    a.gdr_adr_premium,
    a.other_equity_description,
    a.other_equity_number_of_shares,
    a.other_equity_nominal_amount,
    a.other_equity_paid_up_amount,
    a.other_equity_premium,
    a.equity_shares_decrease_number_of_shares,
    a.equity_shares_decrease_nominal_amount,
    a.equity_shares_decrease_paid_up_amount,
    a.equity_shares_decrease_premium,
    a.buy_back_number_of_shares,
    a.buy_back_nominal_amount,
    a.buy_back_paid_up_amount,
    a.buy_back_premium,
    a.forfeited_shares_number_of_shares,
    a.forfeited_shares_nominal_amount,
    a.forfeited_shares_paid_up_amount,
    a.forfeited_shares_premium,
    a.capital_reduction_number_of_shares,
    a.capital_reduction_nominal_amount,
    a.capital_reduction_paid_up_amount,
    a.capital_reduction_premium,
    a.other_decrease_description,
    a.other_decrease_number_of_shares,
    a.other_decrease_nominal_amount,
    a.other_decrease_paid_up_amount,
    a.other_decrease_premium,
    a.equity_shares_at_end_number_of_shares,
    a.equity_shares_at_end_nominal_amount,
    a.equity_shares_at_end_paid_up_amount,
    a.equity_shares_at_end_premium,
    a.preference_shares_at_beginning_number_of_shares,
    a.preference_shares_at_beginning_nominal_amount,
    a.preference_shares_at_beginning_paid_up_amount,
    a.preference_shares_at_beginning_premium,
    a.preference_shares_increase_number_of_shares,
    a.preference_shares_increase_nominal_amount,
    a.preference_shares_increase_paid_up_amount,
    a.preference_shares_increase_premium,
    a.preference_shares_issued_number_of_shares,
    a.preference_shares_issued_nominal_amount,
    a.preference_shares_issued_paid_up_amount,
    a.preference_shares_issued_premium,
    a.preference_shares_reissued_number_of_shares,
    a.preference_shares_reissued_nominal_amount,
    a.preference_shares_reissued_paid_up_amount,
    a.preference_shares_reissued_premium,
    a.other_preference_increase_description,
    a.other_preference_increase_number_of_shares,
    a.other_preference_increase_nominal_amount,
    a.other_preference_increase_paid_up_amount,
    a.other_preference_increase_premium,
    a.preference_shares_decrease_number_of_shares,
    a.preference_shares_decrease_nominal_amount,
    a.preference_shares_decrease_paid_up_amount,
    a.preference_shares_decrease_premium,
    a.preference_shares_redeemed_number_of_shares,
    a.preference_shares_redeemed_nominal_amount,
    a.preference_shares_redeemed_paid_up_amount,
    a.preference_shares_redeemed_premium,
    a.preference_shares_forfeited_number_of_shares,
    a.preference_shares_forfeited_nominal_amount,
    a.preference_shares_forfeited_paid_up_amount,
    a.preference_shares_forfeited_premium,
    a.preference_capital_reduction_number_of_shares,
    a.preference_capital_reduction_nominal_amount,
    a.preference_capital_reduction_paid_up_amount,
    a.preference_capital_reduction_premium,
    a.other_preference_decrease_description,
    a.other_preference_decrease_number_of_shares,
    a.other_preference_decrease_nominal_amount,
    a.other_preference_decrease_paid_up_amount,
    a.other_preference_decrease_premium,
    a.preference_shares_at_end_number_of_shares,
    a.preference_shares_at_end_nominal_amount,
    a.preference_shares_at_end_paid_up_amount,
    a.preference_shares_at_end_premium,
    a.is_nil,
    a.details_provided_in_digital_media,
    a.seprate_sheet_transfers,
    a.previous_annual_meeting_date,
    a.debentures_number_of_units,
    a.nominal_value_per_unit,
    a.deb_total_unit1,
    a.partly_convertible_debentures_number_of_units,
    a.partly_convertible_debentures_nominal_value,
    a.partly_convertible_debentures_total_value,
    a.fully_convertible_debentures_number_of_units,
    a.fully_convertible_debentures_nominal_value_per_unit,
    a.fully_convertible_debentures_total_value,
    a.total_debentures_number_of_units,
    a.total_debentures_nominal_value_per_unit,
    a.total_debentures_total_value,
    a.non_convertible_debentures_outstanding_at_beginning,
    a.non_convertible_debentures_increase_during_year,
    a.non_convertible_debentures_decrease_during_year,
    a.non_convertible_debentures_outstanding_at_end,
    a.partly_convertible_debentures_outstanding_at_beginning,
    a.partly_convertible_debentures_increase_during_year,
    a.partly_convertible_debentures_decrease_during_year,
    a.partly_convertible_debentures_outstanding_at_end,
    a.fully_convertible_debentures_outstanding_at_beginning,
    a.fully_convertible_debentures_increase_during_year,
    a.fully_convertible_debentures_decrease_during_year,
    a.fully_convertible_debentures_outstanding_at_end,
    a.ind_eqt_num,
    a.ind_eqt_pre,
    a.ind_pre_num,
    a.ind_pre_pre,
    a.nri_eqt_num,
    a.nri_eqt_pre,
    a.nri_pre_num,
    a.nri_pre_pre,
    a.oth_eqt_num,
    a.oth_eqt_pre,
    a.oth_pre_num,
    a.oth_pre_pre,
    a.cgov_eqt_num,
    a.cgov_eqt_pre,
    a.cgov_pre_num,
    a.cgov_pre_pre,
    a.sgov_eqt_num,
    a.sgov_eqt_pre,
    a.sgov_pre_num,
    a.sgov_pre_pre,
    a.govcom_eqt_num,
    a.govcom_eqt_pre,
    a.govcom_pre_num,
    a.govcom_pre_pre,
    a.insur_eqt_num,
    a.insur_eqt_pre,
    a.insur_pre_num,
    a.insur_pre_pre,
    a.banks_eqt_num,
    a.banks_eqt_pre,
    a.banks_pre_num,
    a.banks_pre_pre,
    a.finist_eqt_num,
    a.finist_eqt_pre,
    a.finist_pre_num,
    a.finist_pre_pre,
    a.fit_eqt_num,
    a.fit_eqt_pre,
    a.fit_pre_num,
    a.fit_pre_pre,
    a.mf_eqt_num,
    a.mf_eqt_pre,
    a.mf_pre_num,
    a.mf_pre_pre,
    a.vc_eqt_num,
    a.vc_eqt_pre,
    a.vc_pre_num,
    a.vc_pre_pre,
    a.corp_eqt_num,
    a.corp_eqt_pre,
    a.corp_pre_num,
    a.corp_pre_pre,
    a.other_eqt_num,
    a.other_eqt_pre,
    a.other_pre_num,
    a.other_pre_pre,
    a.total_eqt_num,
    a.total_eqt_pre,
    a.total_pre_num,
    a.total_pre_pre,
    a.numbers_promoters,
    a.ind_eqt_num_pub,
    a.ind_eqt_pre_pub,
    a.ind_pre_num_pub,
    a.ind_pre_pre_pub,
    a.nri_eqt_num_pub,
    a.nri_eqt_pre_pub,
    a.nri_pre_num_pub,
    a.nri_pre_pre_pub,
    a.oth_eqt_num_pub,
    a.oth_eqt_pre_pub,
    a.oth_pre_num_pub,
    a.oth_pre_pre_pub,
    a.cgov_eqt_num_pub,
    a.cgov_eqt_pre_pub,
    a.cgov_pre_num_pub,
    a.cgov_pre_pre_pub,
    a.sgov_eqt_num_pub,
    a.sgov_eqt_pre_pub,
    a.sgov_pre_num_pub,
    a.sgov_pre_pre_pub,
    a.govcom_eqt_num_pub,
    a.govcom_eqt_pre_pub,
    a.govcom_pre_num_pub,
    a.govcom_pre_pre_pub,
    a.insur_eqt_num_pub,
    a.insur_eqt_pre_pub,
    a.insur_pre_num_pub,
    a.insur_pre_pre_pub,
    a.banks_eqt_num_pub,
    a.banks_eqt_pre_pub,
    a.banks_pre_num_pub,
    a.banks_pre_pre_pub,
    a.finist_eqt_num_pub,
    a.finist_eqt_pre_pub,
    a.finist_pre_num_pub,
    a.finist_pre_pre_pub,
    a.fit_eqt_num_pub,
    a.fit_eqt_pre_pub,
    a.fit_pre_num_pub,
    a.fit_pre_pre_pub,
    a.mf_eqt_num_pub,
    a.mf_eqt_pre_pub,
    a.mf_pre_num_pub,
    a.mf_pre_pre_pub,
    a.vc_eqt_num_pub,
    a.vc_eqt_pre_pub,
    a.vc_pre_num_pub,
    a.vc_pre_pre_pub,
    a.corp_eqt_num_pub,
    a.corp_eqt_pre_pub,
    a.corp_pre_num_pub,
    a.corp_pre_pre_pub,
    a.other_eqt_num_pub,
    a.other_eqt_pre_pub,
    a.other_pre_num_pub,
    a.other_pre_pre_pub,
    a.total_eqt_num_pub,
    a.total_eqt_pre_pub,
    a.total_pre_num_pub,
    a.total_pre_pre_pub,
    a.numbers_promoters_pub,
    a.num_of_promoters,
    a.num_of_promoters1,
    a.num_of_members,
    a.num_of_members1,
    a.num_of_deb,
    a.num_of_deb1,
    a.complince_made,
    a.reason,
    a.resolution_number,
    a.resolution_date,
    a.signed,
    a.din_pan,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_mgt7a a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mgt7a OWNER TO postgres;

--
-- TOC entry 441 (class 1259 OID 230445)
-- Name: vw_mgt8; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mgt8 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.financial_year,
    a.firm_name,
    a.signing_pcs,
    a.membership_no,
    a.certificate,
    a.designation,
    a.udin,
    a.date_of_signing,
    a.place_of_signing,
    a.format_transaction,
    a.annual_return,
    a.status,
    a.maintenance,
    a.filling_of_forms,
    a.commitees_members,
    a.register_of_members,
    a.advances_and_loans,
    a.related_party_contracts,
    a.issue_or_allotments,
    a.keeping_in_abeyance,
    a.declaration,
    a.signing_of_audited,
    a.constitution,
    a.filling_up_casual,
    a.approvals_required,
    a.repayment_of_deposits,
    a.borrowings,
    a.investements_or_guarantees,
    a.alteration_provisions,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_mgt8 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mgt8 OWNER TO postgres;

--
-- TOC entry 442 (class 1259 OID 230450)
-- Name: vw_mgt9; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mgt9 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.financial_year,
    a.is_registrar_agent,
    a.registrar_agent_name,
    a.registrar_agent_address,
    a.registrar_agent_phone,
    a.registrar_agent_email,
    a.no_of_business,
    a.no_of_holding,
    a.secured_principal_beg,
    a.unsecured_principal_beg,
    a.deposit_principal_beg,
    a.total_principal_beg,
    a.secured_interest_due_beg,
    a.unsecured_interest_due_beg,
    a.deposit_interest_due_beg,
    a.total_interest_due_beg,
    a.secured_interest_accrued_beg,
    a.unsecured_interest_accrued_beg,
    a.deposit_interest_accrued_beg,
    a.total_interest_accrued_beg,
    a.total_secured_beg,
    a.total_unsecured_beg,
    a.total_deposit_beg,
    a.total_beg,
    a.secured_addition_beg,
    a.unsecured_addition_beg,
    a.deposit_addition_beg,
    a.total_addition_beg,
    a.secured_reduction_beg,
    a.unsecured_reduction_beg,
    a.deposit_reduction_beg,
    a.total_reduction_beg,
    a.secured_net_change,
    a.unsecured_net_change,
    a.deposit_net_change,
    a.total_net_change,
    a.secured_principal_end,
    a.unsecured_principal_end,
    a.deposit_principal_end,
    a.total_principal_end,
    a.secured_interest_due_end,
    a.unsecured_interest_due_end,
    a.deposit_interest_due_end,
    a.total_interest_due_end,
    a.secured_interest_accrued_end,
    a.unsecured_interest_accrued_end,
    a.deposit_interest_accrued_end,
    a.total_interest_accrued_end,
    a.total_secured_end,
    a.total_unsecured_end,
    a.total_deposit_end,
    a.total_end,
    a.is_remuneration,
    a.no_of_persons,
    a.is_remuneration_other,
    a.no_of_independent_directors,
    a.no_of_non_executive_directors,
    a.over_all_ceiling,
    a.is_remuneration_other_kmp,
    a.ceo_name,
    a.ceo_salary,
    a.ceo_stock,
    a.ceo_value,
    a.ceo_sweat,
    a.ceo_profit,
    a.ceo_commisionper,
    a.ceo_gross,
    a.ceo_commision_other,
    a.ceo_other_amount,
    a.sec_name,
    a.sec_salary,
    a.sec_stock,
    a.sec_value,
    a.sec_sweat,
    a.sec_profit,
    a.sec_commisionper,
    a.sec_gross,
    a.sec_commision_other,
    a.sec_other_amount,
    a.cfo_name,
    a.cfo_salary,
    a.cfo_stock,
    a.cfo_value,
    a.cfo_sweat,
    a.cfo_profit,
    a.cfo_commisionper,
    a.cfo_gross,
    a.cfo_commisionother,
    a.cfo_otheramount,
    a.is_penalties,
    a.company_section_penalty,
    a.company_descriptioin_penalty,
    a.company_fees_penalty,
    a.company_imposed_penalty,
    a.company_detail_penalty,
    a.company_section_punishment,
    a.company_descriptioin_punishment,
    a.company_fees_punishment,
    a.company_imposed_punishment,
    a.company_detail_punishment,
    a.company_section_compounding,
    a.company_descriptioin_compounding,
    a.company_fees_compounding,
    a.company_imposed_compounding,
    a.company_detail_compounding,
    a.director_section_penalty,
    a.director_descriptioin_penalty,
    a.director_fees_penalty,
    a.director_imposed_penalty,
    a.director_detail_penalty,
    a.director_section_punishment,
    a.director_descriptioin_punishment,
    a.director_fees_punishment,
    a.director_imposed_punishment,
    a.director_detail_punishment,
    a.director_section_compounding,
    a.director_descriptioin_compounding,
    a.director_fees_compounding,
    a.director_imposed_compounding,
    a.director_detail_compounding,
    a.officer_section_penalty,
    a.officer_descriptioin_penalty,
    a.officer_fees_penalty,
    a.officer_imposed_penalty,
    a.officer_detail_penalty,
    a.officer_section_punishment,
    a.officer_descriptioin_punishment,
    a.officer_dees_punishment,
    a.officer_dmposed_punishment,
    a.officer_detail_punishment,
    a.officer_section_compounding,
    a.officer_descriptioin_compounding,
    a.officer_fees_compounding,
    a.officer_imposed_compounding,
    a.officer_detail_compounding,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_mgt9 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mgt9 OWNER TO postgres;

--
-- TOC entry 297 (class 1259 OID 181141)
-- Name: vw_mr1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_mr1 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.public,
    a.appointee_name,
    a.appointee_din_pan,
    a.appointee_designation,
    a.appointee_resolution_date,
    a.appointee_appointment_date,
    a.remuneration_type,
    a.remuneration_salary,
    a.remuneration_perquisites,
    a.remuneration_others,
    a.remuneration_total,
    a.appointment_from,
    a.appointment_to,
    a.age_over_70,
    a.convicted_detained,
    a.non_resident,
    a.approval_obtained,
    a.srn_mr2,
    a.resolution_number,
    a.resolution_date,
    a.designation,
    a.officer_designation,
    a.signatory_id,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_mr1 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_mr1 OWNER TO postgres;

--
-- TOC entry 348 (class 1259 OID 221514)
-- Name: vw_msme; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_msme AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.company_pan,
    a.return_type,
    a.start_date,
    a.end_date,
    a.attachment_file,
    a.declaration_designation,
    a.declaration_membership_no,
    a.din_members,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_msme a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_msme OWNER TO postgres;

--
-- TOC entry 250 (class 1259 OID 180314)
-- Name: vw_other_auditor; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_other_auditor AS
 SELECT a.id,
    a.category,
    a.sub_category,
    a.profession,
    a.frn,
    a.firm_name,
    a.auditor_name,
    a.auditor_designation_in_firm,
    a.member_no,
    a.certificate_of_practice,
    a.auditor_mobile,
    a.auditor_email,
    a.address_of_firm_auditor,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.type,
    u.name AS ref_user_name
   FROM (public.tbl_other_auditor a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.firm_name;


ALTER VIEW public.vw_other_auditor OWNER TO postgres;

--
-- TOC entry 336 (class 1259 OID 221259)
-- Name: vw_pas3; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_pas3 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.number_of_allotments,
    a.no_of_classes_preference,
    a.no_of_classes_equity,
    a.no_of_unclassified,
    a.total_unclassified,
    a.debentures,
    a.loan_secured,
    a.others,
    a.allottees_list,
    a.another_attachment,
    a.optional_attachment,
    a.resolution_number,
    a.resolution_date,
    a.designation,
    a.signatory,
    a.category,
    a.name_of_pcs,
    a.assososiate_or_fellow,
    a.membership_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_pas3 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_pas3 OWNER TO postgres;

--
-- TOC entry 326 (class 1259 OID 205279)
-- Name: vw_pas6; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_pas6 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.from_date,
    a.to_date,
    a.securities,
    a.held_shares_cdsl,
    a.held_capitals_cdsl,
    a.held_shares_nsdl,
    a.held_capitals_nsdl,
    a.shares_held_physical_form,
    a.capital_held_physical,
    a.issued_shares,
    a.number_total,
    a.reason_physical_shares,
    a.beginning_shares,
    a.reporting_whether,
    a.shares_number,
    a.rights_number_of_shares,
    a.rights_nsdl,
    a.rights_cdsl,
    a.bonus_shares,
    a.bonus_intimate_to_nsdl,
    a.bonus_intimate_to_cdsl,
    a.private_placement_shares,
    a.private_placement_to_nsdl,
    a.private_placement_to_cdsl,
    a.shares_of_esops,
    a.esop_intimated_to_nsdl,
    a.esop_intimated_to_cdsl,
    a.shares_of_amalgamation,
    a.amalgamation_nsdl,
    a.amalgamation_cdsl,
    a.shares_of_conversion,
    a.conversion_nsdl,
    a.conversion_cdsl,
    a.shares_of_buyback,
    a.buy_nsdl,
    a.buy_cdsl,
    a.shares_of_capital_reduction,
    a.reduction_nsdl,
    a.reduction_cdsl,
    a.shares_of_forfeiture,
    a.forfeiture_nsdl,
    a.forfeiture_cdsl,
    a.any_other_shares,
    a.specify_nsdl,
    a.specify_cdsl,
    a.total_reporting_shares,
    a.promoters_of_demat,
    a.promoters_of_physical,
    a.promoters_of_total,
    a.directors_demat,
    a.directors_physical,
    a.directors_total,
    a.kmps_demat,
    a.kmps_physical,
    a.kmps_total,
    a.whether_members,
    a.update_date,
    a.confirmed_requests,
    a.confirmed_share,
    a.confirmed_delay_reasons,
    a.pending_requests,
    a.pending_share,
    a.pending_delay_reasons,
    a.whether_appointment,
    a.agency_company_name,
    a.other_details,
    a.resolution_number,
    a.resolution_date,
    a.certified_name,
    a.profession,
    a.designation,
    a.din,
    a.professional_name,
    a.professional_address,
    a.professional_email,
    a.professional_type,
    a.name_of_pcs,
    a.name_of_associate,
    a.certificate_number,
    a.optional_attachment,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_pas6 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_pas6 OWNER TO postgres;

--
-- TOC entry 300 (class 1259 OID 188257)
-- Name: vw_resolution; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_resolution AS
 SELECT id,
    created_by,
    created_on,
    updated_by,
    updated_on,
    deleted_on,
    is_active,
    number,
    title,
    agenda_text,
    meeting_text,
    resolution_text,
    category,
    subcategory
   FROM public.tbl_resolution a
  WHERE (deleted_on IS NULL);


ALTER VIEW public.vw_resolution OWNER TO postgres;

--
-- TOC entry 357 (class 1259 OID 221648)
-- Name: vw_run; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_run AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.proposed_name,
    a.proposed_second_name,
    a.application_comments,
    a.attachment_file,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_run a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL);


ALTER VIEW public.vw_run OWNER TO postgres;

--
-- TOC entry 366 (class 1259 OID 221870)
-- Name: vw_runllp; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_runllp AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.purpose,
    a.nic_code_serial,
    a.codes_nic,
    a.nic_codes_desc,
    a.proposed_name1,
    a.proposed_name2,
    a.attachment_file_name,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_runllp a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL);


ALTER VIEW public.vw_runllp OWNER TO postgres;

--
-- TOC entry 363 (class 1259 OID 221821)
-- Name: vw_sh11; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_sh11 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.srn_of_sh8,
    a.srn_of_sh9,
    a.amount_as_on,
    a.free_reserve,
    a.free_reserve_amount,
    a.free_reserve_utilized_amount,
    a.securities_premium,
    a.securities_premium_amount,
    a.securities_premium_utilized_amount,
    a.preceding_capital,
    a.proceeds_capital_amount,
    a.proceeds_capital_utilized,
    a.capital_share_date,
    a.equity_classes,
    a.preference_classes,
    a.capital_description,
    a.pre_buy_shares_auth,
    a.pre_buy_shares_issue,
    a.pre_buy_shares_subs,
    a.pre_buy_shares_paid_up,
    a.shares_eqty_auth,
    a.shares_issue,
    a.shares_subs,
    a.shares_paid_up,
    a.total_amount_auth,
    a.total_amount_issue,
    a.total_amount_subs,
    a.total_amount_paid_up,
    a.securities_auth,
    a.securities_issue,
    a.securities_subs,
    a.securities_paid_up,
    a.buy_back_price_auth,
    a.buy_back_price_issue,
    a.buy_back_price_subs,
    a.buy_back_price_paid_up,
    a.total_amount_of_buy_back_auth,
    a.total_amount_of_buy_back_issue,
    a.total_amount_of_buy_back_subs,
    a.total_amount_of_buy_back_paid_up,
    a.post_buy_back_auth,
    a.post_buy_back_issue,
    a.post_buy_back_subs,
    a.post_buy_back_paid_up,
    a.amount_shares_auth,
    a.amount_shares_issue,
    a.amount_shares_subs,
    a.amount_shares_paid_up,
    a.unclassified_capital,
    a.details_date,
    a.equity_total,
    a.capital_paid,
    a.free_reserved_capital,
    a.premium_securities,
    a.amount_total,
    a.board_director_date,
    a.srn_of_mgt_14,
    a.completion_date,
    a.opening_offer_date,
    a.closing_offer_date,
    a.buy_back_completion_date,
    a.payment_consideration_date,
    a.ratio_applicable,
    a.free_reserve_ratio,
    a.pre_buy_back_debt_and_reserve_ratio,
    a.post_buy_back_debt_and_reserve_ration,
    a.securities_held_before_date,
    a.securities_held_after_date,
    a.government_central_securities,
    a.number_of_shares_buy_back,
    a.securities_held_government_companies,
    a.securities_back_government_companies,
    a.public_financial_institution,
    a.public_financial_securities,
    a.nationalized_other_bank_securities,
    a.nationalized_other_buy_back_securities,
    a.mutual_fund_security,
    a.mutual_fund_buy_back_securities,
    a.venture_capital_securities,
    a.venture_capital_buy_back_securities,
    a.foreign_securities_before,
    a.foreign_securities_after,
    a.corporate_securities_before,
    a.corporate_securities_after,
    a.directors_back_on,
    a.directors_back_on_relatives,
    a.shareholders_back_on,
    a.shareholders_securities,
    a.others_back_on,
    a.others_securities,
    a.total_back_on,
    a.total_securities,
    a.buy_back_back_on,
    a.buy_back_securities,
    a.buy_back_details,
    a.board_resolution_copy,
    a.optional_attachment,
    a.resolution_number,
    a.application_date,
    a.designation1,
    a.director_name1,
    a.din1,
    a.designation2,
    a.director_name2,
    a.din2,
    a.certified_by,
    a.associate_or_fellow,
    a.membership_number,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_sh11 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_sh11 OWNER TO postgres;

--
-- TOC entry 290 (class 1259 OID 181075)
-- Name: vw_sh7; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_sh7 AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.form_purpose,
    a.share_type,
    a.resolution_date,
    a.srn_number,
    a.members_present,
    a.shares_held,
    a.members_voted_for,
    a.shares_voted_for,
    a.members_voted_against,
    a.shares_voted_against,
    a.members_abstained,
    a.shares_abstained,
    a.existing_members,
    a.revised_members,
    a.difference_members,
    a.max_members_excluding_employees,
    a.order_number,
    a.order_date,
    a.government_type,
    a.state,
    a.debentures,
    a.loans,
    a.order_received_date,
    a.appeal_filed,
    a.tribunal_order_date,
    a.order_receipt_date,
    a.srn_inc28,
    a.company_notice_date,
    a.impact_consolidated,
    a.impact_converted,
    a.impact_reconverted,
    a.impact_subdivided,
    a.impact_cancellation,
    a.articles_altered,
    a.memorandum_altered,
    a.stamp_state,
    a.stamp_duty_amount,
    a.stamp_details,
    a.dec_name,
    a.designation,
    a.designation2,
    a.identifier,
    a.category,
    a.pcs,
    a.membership_status,
    a.membership_number,
    u.name AS ref_user_name
   FROM (public.tbl_sh7 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_sh7 OWNER TO postgres;

--
-- TOC entry 360 (class 1259 OID 221733)
-- Name: vw_sh8; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_sh8 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.capital_date,
    a.equity_share_classes,
    a.preference_share_classes,
    a.share_description,
    a.number_of_shares_authorize_capital,
    a.number_of_shares_issued_capital,
    a.nominal_number_of_shares_issued_capital,
    a.number_of_shares_subscribed_capital,
    a.number_of_shares_paid_up,
    a.nominal_of_shares_eqty_auth,
    a.nominal_shares_subs,
    a.nominal_shares_paid_up,
    a.total_authorised,
    a.total_issued,
    a.total_subscribed,
    a.total_paid_up,
    a.unclassified_share_total,
    a.equity_capital_date,
    a.total_paid_up_equity,
    a.free_reserves_capital,
    a.premium_securities,
    a.date_of_completion,
    a.expected_proposed_date,
    a.proposed_completion_date,
    a.extinguishment_date,
    a.free_reserves,
    a.security_premium_account,
    a.other_specified_securities,
    a.amount_date,
    a.free_reserve_amount,
    a.buy_back_reserves_amount,
    a.securities_premium_amount,
    a.security_buy_back_amount,
    a.other_specified_securities_amount,
    a.other_specified_securities_buy_back,
    a.equity_shares,
    a.preference_shares,
    a.other_shares,
    a.classes_number,
    a.total_buy_back_amount,
    a.existing_holders,
    a.open_market,
    a.odd_lots_listed,
    a.employees_stock,
    a.sweat_equity,
    a.any_other_mode,
    a.specify_details,
    a.article_authorising,
    a.directors_date,
    a.resolution_date,
    a.srn,
    a.equity_shares_preceding,
    a.preference_shares_preceding,
    a.other_shares_preceding,
    a.total_shares_preceding,
    a.equity_shares_purchased,
    a.preference_shares_purchased,
    a.other_shares_purchased,
    a.total_shares_purchased,
    a.equity_shares_purchased_after_meeting,
    a.preference_shares_purchased_after_meeting,
    a.other_shares_purchased_after_meeting,
    a.total_shares_purchased_after_meeting,
    a.max_price_equity,
    a.max_price_preference,
    a.max_price_other,
    a.total_max_price,
    a.max_price_date_equity,
    a.max_price_date_preference,
    a.max_price_date_other,
    a.total_max_price_date,
    a.equity_shares_sold,
    a.preference_shares_sold,
    a.other_shares_sold,
    a.total_shares_sold,
    a.equity_shares_sold_after_meeting,
    a.preference_shares_sold_after_meeting,
    a.other_shares_sold_after_meeting,
    a.total_shares_sold_after_meeting,
    a.max_price_received_equity,
    a.max_price_received_preference,
    a.max_price_received_other,
    a.total_max_price_received,
    a.max_price_received_date_equity,
    a.max_price_received_date_preference,
    a.max_price_received_date_other,
    a.total_max_price_received_date,
    a.balance_equity_shares,
    a.balance_preference_shares,
    a.balance_other_shares,
    a.total_balance_shares,
    a.security_date,
    a.government_holders,
    a.government_companies_holders,
    a.public_financial_holder,
    a.nationalized_bank,
    a.mutual_funds,
    a.venture_capital,
    a.foreign_financial,
    a.bodies_corporate,
    a.relatives_of_directors,
    a.other_top_fifty,
    a.others,
    a.total,
    a.total_share_holder,
    a.government_ratio,
    a.board_of_resolution,
    a.reserve_debt,
    a.reserve_post,
    a.repayment_deposit,
    a.annual_return,
    a.first_designation,
    a.first_director_name,
    a.first_directors_din,
    a.second_designation,
    a.second_director_name,
    a.second_director_din,
    a.unaudited_financial_statement,
    a.auditor_declaration,
    a.statutory_approval,
    a.board_resolution_copy,
    a.optional_attachment,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_sh8 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_sh8 OWNER TO postgres;

--
-- TOC entry 339 (class 1259 OID 221366)
-- Name: vw_sh9; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_sh9 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.company_whether,
    a.resolution_directors,
    a.special_date,
    a.service_number,
    a.resolution_number,
    a.resolution_pass,
    a.approved,
    a.shares_in_words,
    a.companies_act,
    a.day_of,
    a.designation,
    a.name_director,
    a.director_din,
    a.second_directors_designation,
    a.second_director_name,
    a.second_directors_din,
    a.liabilities,
    a.report,
    a.affidavit,
    a.attachment_file,
    a.created_on,
    a.created_by,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name
   FROM (public.tbl_sh9 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.company_name;


ALTER VIEW public.vw_sh9 OWNER TO postgres;

--
-- TOC entry 248 (class 1259 OID 180300)
-- Name: vw_shareholder; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_shareholder AS
 SELECT a.id,
    a.first_name,
    a.middle_name,
    a.last_name,
    a.category,
    a.sub_category,
    a.under_sub_category,
    a.has_valid_din,
    a.director,
    a.gender,
    a.pan,
    a.dob,
    a.email,
    a.mobile,
    a.marital_status,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.type,
    a.salutation,
    a.cin_reg,
    a.unique_id,
    a.incorporation_date,
    a.company_name,
    a.passport,
    u.name AS ref_user_name
   FROM (public.tbl_shareholder a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL)
  ORDER BY a.first_name, a.middle_name, a.last_name;


ALTER VIEW public.vw_shareholder OWNER TO postgres;

--
-- TOC entry 427 (class 1259 OID 223846)
-- Name: vw_shareholder_management; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_shareholder_management AS
 SELECT a.id,
    a.company_id,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.deleted_on,
    a.ref_user,
    a.is_active,
    a.joint_shareholding,
    a.joint_shareholders_count,
    a.category,
    a.sh_list,
    a.date_of_becoming_member,
    a.shareholder_status,
    a.shareholding_mode,
    a.type_of_share,
    a.number_of_shares_subscribed,
    a.per_share_value,
    a.percentage_of_shares_held,
    a.folio_no,
    a.dp_client_id,
    a.is_bene,
    u.name AS ref_user_name
   FROM (public.tbl_shareholder_management a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  WHERE (a.deleted_on IS NULL);


ALTER VIEW public.vw_shareholder_management OWNER TO postgres;

--
-- TOC entry 318 (class 1259 OID 204686)
-- Name: vw_stk2; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_stk2 AS
 SELECT a.id,
    a.ref_user,
    a.company_id,
    a.cin,
    a.company_name,
    a.company_address,
    a.company_email,
    a.cin_corporate,
    a.office_address,
    a.notice_received,
    a.reason_for_closure,
    a.delisted_received,
    a.resolution,
    a.other,
    a.approval_date,
    a.srn_related_form,
    a.mgt_resolution,
    a.srn_no_mgt14,
    a.description_of_moa,
    a.director_manager,
    a.litigations,
    a.litigation_pending_act,
    a.name_of_authority,
    a.case_number,
    a.subject_matter,
    a.declarant_name,
    a.declarant_parent_name,
    a.declarant_company,
    a.declarant_resolution_number,
    a.declaration_date,
    a.attachment_file,
    a.member_name,
    a.member_designation,
    a.membership_number,
    a.indemnity_attachment_file,
    a.optional_attachment_file,
    a.director,
    a.director_din,
    a.accountant_type,
    a.company_secretary,
    a.whether_associate_or_fellow,
    a.certificate_number,
    a.created_by,
    a.created_on,
    a.updated_by,
    a.updated_on,
    a.is_active,
    a.deleted_on,
    u.name AS ref_user_name,
    a.regulator,
    a.regulated_activities
   FROM (public.tbl_stk2 a
     LEFT JOIN public.tbl_user u ON ((a.ref_user = u.id)))
  ORDER BY a.company_name;


ALTER VIEW public.vw_stk2 OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 163082)
-- Name: vw_user; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.vw_user AS
 SELECT id,
    name,
    email,
    mobile,
    password,
    email_verified,
    mobile_verified,
    role,
    image_path,
    created_on,
    updated_by,
    updated_on,
    is_active,
    deleted_on,
    created_by
   FROM public.tbl_user
  WHERE (deleted_on IS NULL)
  ORDER BY name;


ALTER VIEW public.vw_user OWNER TO postgres;

--
-- TOC entry 5526 (class 2604 OID 230307)
-- Name: tbl_action_address_change id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_address_change ALTER COLUMN id SET DEFAULT nextval('public.tbl_action_address_change_id_seq'::regclass);


--
-- TOC entry 5548 (class 2604 OID 231926)
-- Name: tbl_action_director_appointment id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_director_appointment ALTER COLUMN id SET DEFAULT nextval('public.tbl_director_appointment_id_seq'::regclass);


--
-- TOC entry 5546 (class 2604 OID 231276)
-- Name: tbl_action_general id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_general ALTER COLUMN id SET DEFAULT nextval('public.tbl_action_general_id_seq'::regclass);


--
-- TOC entry 5520 (class 2604 OID 223672)
-- Name: tbl_adt1 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_adt1 ALTER COLUMN id SET DEFAULT nextval('public.tbl_adt1_id_seq'::regclass);


--
-- TOC entry 5521 (class 2604 OID 223748)
-- Name: tbl_adt3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_adt3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_adt3_id_seq'::regclass);


--
-- TOC entry 5544 (class 2604 OID 230916)
-- Name: tbl_aoc4 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc4 ALTER COLUMN id SET DEFAULT nextval('public.tbl_aoc4_id_seq'::regclass);


--
-- TOC entry 5541 (class 2604 OID 230650)
-- Name: tbl_aoc4cfs id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc4cfs ALTER COLUMN id SET DEFAULT nextval('public.tbl_aoc4cfs_id_seq'::regclass);


--
-- TOC entry 5498 (class 2604 OID 221567)
-- Name: tbl_aoc5 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc5 ALTER COLUMN id SET DEFAULT nextval('public.tbl_aoc5_id_seq'::regclass);


--
-- TOC entry 5509 (class 2604 OID 222379)
-- Name: tbl_aoccuntnsolvencyform id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoccuntnsolvencyform ALTER COLUMN id SET DEFAULT nextval('public.tbl_aoccuntnsolvencyform_id_seq'::regclass);


--
-- TOC entry 5455 (class 2604 OID 163728)
-- Name: tbl_api_log id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_api_log ALTER COLUMN id SET DEFAULT nextval('public.tbl_api_log_id_seq'::regclass);


--
-- TOC entry 5460 (class 2604 OID 180245)
-- Name: tbl_auditor id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_auditor ALTER COLUMN id SET DEFAULT nextval('public.tbl_auditor_id_seq'::regclass);


--
-- TOC entry 5461 (class 2604 OID 180254)
-- Name: tbl_auditor_partner id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_auditor_partner ALTER COLUMN id SET DEFAULT nextval('public.tbl_auditor_partner_id_seq'::regclass);


--
-- TOC entry 5495 (class 2604 OID 221459)
-- Name: tbl_ben2 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_ben2 ALTER COLUMN id SET DEFAULT nextval('public.tbl_ben2_id_seq'::regclass);


--
-- TOC entry 5542 (class 2604 OID 230768)
-- Name: tbl_boardreport id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_boardreport ALTER COLUMN id SET DEFAULT nextval('public.tbl_boardreport_id_seq'::regclass);


--
-- TOC entry 5538 (class 2604 OID 230589)
-- Name: tbl_cag id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_cag ALTER COLUMN id SET DEFAULT nextval('public.tbl_cag_id_seq'::regclass);


--
-- TOC entry 5503 (class 2604 OID 221880)
-- Name: tbl_capital id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_capital ALTER COLUMN id SET DEFAULT nextval('public.tbl_capital_id_seq'::regclass);


--
-- TOC entry 5504 (class 2604 OID 221894)
-- Name: tbl_capital_child id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_capital_child ALTER COLUMN id SET DEFAULT nextval('public.tbl_capital_child_id_seq'::regclass);


--
-- TOC entry 5515 (class 2604 OID 223287)
-- Name: tbl_charge id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_charge ALTER COLUMN id SET DEFAULT nextval('public.tbl_charge_id_seq'::regclass);


--
-- TOC entry 5525 (class 2604 OID 230260)
-- Name: tbl_chg1 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg1 ALTER COLUMN id SET DEFAULT nextval('public.tbl_chg1_id_seq'::regclass);


--
-- TOC entry 5540 (class 2604 OID 230636)
-- Name: tbl_chg4 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg4 ALTER COLUMN id SET DEFAULT nextval('public.tbl_chg4_id_seq'::regclass);


--
-- TOC entry 5464 (class 2604 OID 180574)
-- Name: tbl_chg6 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg6 ALTER COLUMN id SET DEFAULT nextval('public.tbl_chg6_id_seq'::regclass);


--
-- TOC entry 5465 (class 2604 OID 180595)
-- Name: tbl_chg8 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg8 ALTER COLUMN id SET DEFAULT nextval('public.tbl_chg8_id_seq'::regclass);


--
-- TOC entry 5466 (class 2604 OID 180622)
-- Name: tbl_chg9 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg9 ALTER COLUMN id SET DEFAULT nextval('public.tbl_chg9_id_seq'::regclass);


--
-- TOC entry 5449 (class 2604 OID 162992)
-- Name: tbl_company id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_id_seq'::regclass);


--
-- TOC entry 5451 (class 2604 OID 163010)
-- Name: tbl_company_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_details_id_seq'::regclass);


--
-- TOC entry 5543 (class 2604 OID 230821)
-- Name: tbl_company_director id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_director ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_director_id_seq'::regclass);


--
-- TOC entry 5452 (class 2604 OID 163019)
-- Name: tbl_company_financial_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_financial_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_financial_details_id_seq'::regclass);


--
-- TOC entry 5550 (class 2604 OID 231972)
-- Name: tbl_company_ioc id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_ioc ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_ioc_id_seq'::regclass);


--
-- TOC entry 5480 (class 2604 OID 196518)
-- Name: tbl_company_notice id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_notice ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_notice_id_seq'::regclass);


--
-- TOC entry 5453 (class 2604 OID 163028)
-- Name: tbl_company_other_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_other_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_other_details_id_seq'::regclass);


--
-- TOC entry 5536 (class 2604 OID 230539)
-- Name: tbl_company_otp id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_otp ALTER COLUMN id SET DEFAULT nextval('public.tbl_company_otp_id_seq'::regclass);


--
-- TOC entry 5458 (class 2604 OID 180095)
-- Name: tbl_debenture id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_debenture ALTER COLUMN id SET DEFAULT nextval('public.tbl_debenture_id_seq'::regclass);


--
-- TOC entry 5459 (class 2604 OID 180104)
-- Name: tbl_debenture_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_debenture_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_debenture_details_id_seq'::regclass);


--
-- TOC entry 5472 (class 2604 OID 180821)
-- Name: tbl_dir11 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir11 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir11_id_seq'::regclass);


--
-- TOC entry 5473 (class 2604 OID 180850)
-- Name: tbl_dir12 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir12 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir12_id_seq'::regclass);


--
-- TOC entry 5468 (class 2604 OID 180727)
-- Name: tbl_dir3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir3_id_seq'::regclass);


--
-- TOC entry 5469 (class 2604 OID 180742)
-- Name: tbl_dir5 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir5 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir5_id_seq'::regclass);


--
-- TOC entry 5470 (class 2604 OID 180769)
-- Name: tbl_dir6 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir6 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir6_id_seq'::regclass);


--
-- TOC entry 5471 (class 2604 OID 180807)
-- Name: tbl_dir9 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir9 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dir9_id_seq'::regclass);


--
-- TOC entry 5450 (class 2604 OID 163001)
-- Name: tbl_director id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_director ALTER COLUMN id SET DEFAULT nextval('public.tbl_director_id_seq'::regclass);


--
-- TOC entry 5454 (class 2604 OID 163037)
-- Name: tbl_director_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_director_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_director_details_id_seq'::regclass);


--
-- TOC entry 5535 (class 2604 OID 230468)
-- Name: tbl_dms id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dms ALTER COLUMN id SET DEFAULT nextval('public.tbl_dms_id_seq'::regclass);


--
-- TOC entry 5467 (class 2604 OID 180713)
-- Name: tbl_dpt3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dpt3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dpt3_id_seq'::regclass);


--
-- TOC entry 5463 (class 2604 OID 180442)
-- Name: tbl_dpt4 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dpt4 ALTER COLUMN id SET DEFAULT nextval('public.tbl_dpt4_id_seq'::regclass);


--
-- TOC entry 5511 (class 2604 OID 222785)
-- Name: tbl_form11 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form11 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form11_id_seq'::regclass);


--
-- TOC entry 5513 (class 2604 OID 222882)
-- Name: tbl_form12 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form12 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form12_id_seq'::regclass);


--
-- TOC entry 5514 (class 2604 OID 223162)
-- Name: tbl_form15 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form15 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form15_id_seq'::regclass);


--
-- TOC entry 5518 (class 2604 OID 223442)
-- Name: tbl_form22 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form22 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form22_id_seq'::regclass);


--
-- TOC entry 5516 (class 2604 OID 223314)
-- Name: tbl_form23 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form23 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form23_id_seq'::regclass);


--
-- TOC entry 5517 (class 2604 OID 223418)
-- Name: tbl_form24 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form24 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form24_id_seq'::regclass);


--
-- TOC entry 5505 (class 2604 OID 221984)
-- Name: tbl_form3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form3_id_seq'::regclass);


--
-- TOC entry 5497 (class 2604 OID 221525)
-- Name: tbl_form4 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form4 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form4_id_seq'::regclass);


--
-- TOC entry 5507 (class 2604 OID 222131)
-- Name: tbl_form5 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form5 ALTER COLUMN id SET DEFAULT nextval('public.tbl_form5_id_seq'::regclass);


--
-- TOC entry 5522 (class 2604 OID 223827)
-- Name: tbl_gnl1 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl1 ALTER COLUMN id SET DEFAULT nextval('public.tbl_gnl1_id_seq'::regclass);


--
-- TOC entry 5490 (class 2604 OID 221124)
-- Name: tbl_gnl2 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl2 ALTER COLUMN id SET DEFAULT nextval('public.tbl_gnl2_id_seq'::regclass);


--
-- TOC entry 5491 (class 2604 OID 221165)
-- Name: tbl_gnl3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_gnl3_id_seq'::regclass);


--
-- TOC entry 5512 (class 2604 OID 222814)
-- Name: tbl_iepf2 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_iepf2 ALTER COLUMN id SET DEFAULT nextval('public.tbl_iepf2_id_seq'::regclass);


--
-- TOC entry 5506 (class 2604 OID 222050)
-- Name: tbl_iepf5 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_iepf5 ALTER COLUMN id SET DEFAULT nextval('public.tbl_iepf5_id_seq'::regclass);


--
-- TOC entry 5510 (class 2604 OID 222494)
-- Name: tbl_inc12 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc12 ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc12_id_seq'::regclass);


--
-- TOC entry 5481 (class 2604 OID 196622)
-- Name: tbl_inc20a id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc20a ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc20a_id_seq'::regclass);


--
-- TOC entry 5474 (class 2604 OID 180950)
-- Name: tbl_inc22 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc22 ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc22_id_seq'::regclass);


--
-- TOC entry 5508 (class 2604 OID 222350)
-- Name: tbl_inc23 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc23 ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc23_id_seq'::regclass);


--
-- TOC entry 5482 (class 2604 OID 196719)
-- Name: tbl_inc28 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc28 ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc28_id_seq'::regclass);


--
-- TOC entry 5519 (class 2604 OID 223591)
-- Name: tbl_inc4 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc4 ALTER COLUMN id SET DEFAULT nextval('public.tbl_inc4_id_seq'::regclass);


--
-- TOC entry 5549 (class 2604 OID 231959)
-- Name: tbl_litigation id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_litigation ALTER COLUMN id SET DEFAULT nextval('public.tbl_litigation_id_seq'::regclass);


--
-- TOC entry 5487 (class 2604 OID 204784)
-- Name: tbl_meeting id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting ALTER COLUMN id SET DEFAULT nextval('public.tbl_meeting_id_seq'::regclass);


--
-- TOC entry 5484 (class 2604 OID 197010)
-- Name: tbl_meeting_circulation id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_circulation ALTER COLUMN id SET DEFAULT nextval('public.tbl_meeting_circulation_id_seq'::regclass);


--
-- TOC entry 5485 (class 2604 OID 197019)
-- Name: tbl_meeting_communicate_comment id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_communicate_comment ALTER COLUMN id SET DEFAULT nextval('public.tbl_meeting_communicate_comment_id_seq'::regclass);


--
-- TOC entry 5527 (class 2604 OID 230320)
-- Name: tbl_meeting_resolution id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_resolution ALTER COLUMN id SET DEFAULT nextval('public.tbl_meeting_resolution_id_seq'::regclass);


--
-- TOC entry 5483 (class 2604 OID 197001)
-- Name: tbl_meeting_special_invitee id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_special_invitee ALTER COLUMN id SET DEFAULT nextval('public.tbl_meeting_special_invitee_id_seq'::regclass);


--
-- TOC entry 5488 (class 2604 OID 205001)
-- Name: tbl_mgt14 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt14 ALTER COLUMN id SET DEFAULT nextval('public.tbl_mgt14_id_seq'::regclass);


--
-- TOC entry 5494 (class 2604 OID 221391)
-- Name: tbl_mgt6 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt6 ALTER COLUMN id SET DEFAULT nextval('public.tbl_mgt6_id_seq'::regclass);


--
-- TOC entry 5547 (class 2604 OID 231857)
-- Name: tbl_mgt7a id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt7a ALTER COLUMN id SET DEFAULT nextval('public.tbl_mgt7a_id_seq'::regclass);


--
-- TOC entry 5534 (class 2604 OID 230434)
-- Name: tbl_mgt8 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt8 ALTER COLUMN id SET DEFAULT nextval('public.tbl_mgt8_id_seq'::regclass);


--
-- TOC entry 5528 (class 2604 OID 230419)
-- Name: tbl_mgt9 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt9 ALTER COLUMN id SET DEFAULT nextval('public.tbl_mgt9_id_seq'::regclass);


--
-- TOC entry 5478 (class 2604 OID 181136)
-- Name: tbl_mr1 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mr1 ALTER COLUMN id SET DEFAULT nextval('public.tbl_mr1_id_seq'::regclass);


--
-- TOC entry 5496 (class 2604 OID 221509)
-- Name: tbl_msme id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_msme ALTER COLUMN id SET DEFAULT nextval('public.tbl_msme_id_seq'::regclass);


--
-- TOC entry 5462 (class 2604 OID 180306)
-- Name: tbl_other_auditor id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_other_auditor ALTER COLUMN id SET DEFAULT nextval('public.tbl_other_auditor_id_seq'::regclass);


--
-- TOC entry 5492 (class 2604 OID 221254)
-- Name: tbl_pas3 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_pas3 ALTER COLUMN id SET DEFAULT nextval('public.tbl_pas3_id_seq'::regclass);


--
-- TOC entry 5489 (class 2604 OID 205273)
-- Name: tbl_pas6 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_pas6 ALTER COLUMN id SET DEFAULT nextval('public.tbl_pas6_id_seq'::regclass);


--
-- TOC entry 5539 (class 2604 OID 230598)
-- Name: tbl_reservation id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_reservation ALTER COLUMN id SET DEFAULT nextval('public.tbl_reservation_id_seq'::regclass);


--
-- TOC entry 5479 (class 2604 OID 188252)
-- Name: tbl_resolution id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_resolution ALTER COLUMN id SET DEFAULT nextval('public.tbl_resolution_id_seq'::regclass);


--
-- TOC entry 5499 (class 2604 OID 221643)
-- Name: tbl_run id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_run ALTER COLUMN id SET DEFAULT nextval('public.tbl_run_id_seq'::regclass);


--
-- TOC entry 5502 (class 2604 OID 221865)
-- Name: tbl_runllp id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_runllp ALTER COLUMN id SET DEFAULT nextval('public.tbl_runllp_id_seq'::regclass);


--
-- TOC entry 5501 (class 2604 OID 221815)
-- Name: tbl_sh11 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh11 ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh11_id_seq'::regclass);


--
-- TOC entry 5475 (class 2604 OID 181069)
-- Name: tbl_sh7 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7 ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh7_id_seq'::regclass);


--
-- TOC entry 5476 (class 2604 OID 181096)
-- Name: tbl_sh7_share id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7_share ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh7_share_id_seq'::regclass);


--
-- TOC entry 5477 (class 2604 OID 181105)
-- Name: tbl_sh7_structure id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7_structure ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh7_structure_id_seq'::regclass);


--
-- TOC entry 5500 (class 2604 OID 221728)
-- Name: tbl_sh8 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh8 ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh8_id_seq'::regclass);


--
-- TOC entry 5493 (class 2604 OID 221361)
-- Name: tbl_sh9 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh9 ALTER COLUMN id SET DEFAULT nextval('public.tbl_sh9_id_seq'::regclass);


--
-- TOC entry 5456 (class 2604 OID 180060)
-- Name: tbl_shareholder id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder ALTER COLUMN id SET DEFAULT nextval('public.tbl_shareholder_id_seq'::regclass);


--
-- TOC entry 5457 (class 2604 OID 180069)
-- Name: tbl_shareholder_details id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_details ALTER COLUMN id SET DEFAULT nextval('public.tbl_shareholder_detail_id_seq'::regclass);


--
-- TOC entry 5523 (class 2604 OID 223841)
-- Name: tbl_shareholder_management id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_management ALTER COLUMN id SET DEFAULT nextval('public.tbl_shareholder_management_id_seq'::regclass);


--
-- TOC entry 5524 (class 2604 OID 223855)
-- Name: tbl_shareholder_management_owner id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_management_owner ALTER COLUMN id SET DEFAULT nextval('public.tbl_shareholder_management_owner_id_seq'::regclass);


--
-- TOC entry 5486 (class 2604 OID 204676)
-- Name: tbl_stk2 id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_stk2 ALTER COLUMN id SET DEFAULT nextval('public.tbl_stk2_id_seq'::regclass);


--
-- TOC entry 5537 (class 2604 OID 230548)
-- Name: tbl_subsidiary id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_subsidiary ALTER COLUMN id SET DEFAULT nextval('public.tbl_subsidiary_id_seq'::regclass);


--
-- TOC entry 5448 (class 2604 OID 162927)
-- Name: tbl_user id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_user ALTER COLUMN id SET DEFAULT nextval('public.tbl_user_id_seq'::regclass);


--
-- TOC entry 6113 (class 0 OID 230304)
-- Dependencies: 434
-- Data for Name: tbl_action_address_change; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_action_address_change VALUES (1, 2, 'withinLocalLimits', '2025-03-01', '123 Old Street, Old City, OC 12345', '456 New Street', 'Suite 789', 'New City', 'New State', 'District 9', 'Countryland', '98765', NULL, 'RegistrarOfCompaniesAP', 'New City Police Station', '789 Police Road', 'Near Central Park', 'New City', 'New State', '98766', 'gasBill', 'AGM', 'No', '2025-04-10', '10:00', NULL, NULL, 'No', '2025-04-05', '14:00', NULL, 'Mokshank Dilipbhai Savla (Director)', 'Mokshank Dilipbhai Savla (Director)', 'XYZ1234567', 'Managing Director', 'Res-1001', '2025-03-15', 'Chartered accountant(in whole time practice)', 'Michael Brown', 'LM987654', 'P123456', 'Associate', true, -1, '2025-03-24 13:49:39.579347', -1, '2025-03-24 13:49:39.579349', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (2, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-25 13:33:10.887785', -1, '2025-03-25 13:33:10.887818', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (3, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-25 13:39:53.000602', -1, '2025-03-25 13:39:53.000605', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (4, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-25 13:40:21.266122', -1, '2025-03-25 13:40:21.266125', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (5, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-25 13:41:00.462366', -1, '2025-03-25 13:41:00.462369', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (6, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-25 13:41:20.505698', -1, '2025-03-25 13:41:20.5057', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (8, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-03-26 11:21:41.529378', -1, '2025-03-26 11:21:41.529383', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (9, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-04-04 14:46:57.683295', -1, '2025-04-04 14:46:57.683296', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (10, 2, 'withinLocalLimits', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-04-06 16:09:13.883857', -1, '2025-04-06 16:09:13.883969', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (7, 2, 'withinLocalLimits', '2025-04-08', 'Andheri', 'Line 1', 'Line 2', 'Mumbai', 'Maharashtra', 'Mumbai', 'India', '400001', '', 'RegistrarOfCompaniesAP', '', '', '', '', '', '', '', NULL, NULL, NULL, NULL, '', '', NULL, NULL, NULL, '', '', '', '', '', '', NULL, 'Company secretary(in whole time practice)', '', '', '', NULL, true, -1, '2025-03-25 13:41:53.908938', -1, '2025-04-08 12:41:19.260314', NULL, NULL);
INSERT INTO public.tbl_action_address_change VALUES (11, 2, 'Appoint as Individual Director', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, true, -1, '2025-04-09 13:22:57.124733', -1, '2025-04-09 13:22:57.124742', NULL, NULL);


--
-- TOC entry 6145 (class 0 OID 231923)
-- Dependencies: 473
-- Data for Name: tbl_action_director_appointment; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_action_director_appointment VALUES (1, 2, NULL, NULL, 'Additional Independent Director', 'Professional', 'Executive Director', 'vijay saroj', 'vijay saroj', 'employee', '1234567890', '2025-04-17 00:00:00', 'mumbai', 'Circular Resolution', 'Yes', '96935', '2025-04-18 00:00:00', '22:06', '2025-04-18 00:00:00', '06750234', 'EGM', 'Yes', '', '6166', '2025-04-25 00:00:00', '21:06', '0987654321', 'vijay saroj', 'ramesh', 'Male', '2025-04-08 00:00:00', 'lbs marg', 'vijaysaroj4527@gmail.com', '8070807044', '1234567890', 'indian', 'employee', '2025-04-01 00:00:00', '2025-04-04 00:00:00', 'mumbai', 'Yes', 'Yes', 'vijay', 1234567890, 1234567890, '2025-04-01 00:00:00', 'mumbai', '2025-04-01 00:00:00', 'kurla', -1, '2025-04-09 19:07:41.841948', -1, '2025-04-09 19:24:52.515937', NULL, NULL, true);
INSERT INTO public.tbl_action_director_appointment VALUES (2, 2, NULL, NULL, '', '', NULL, '', '', '', '', NULL, '', NULL, 'Yes', '96935', NULL, NULL, NULL, '', NULL, NULL, '', '', NULL, NULL, '', '', '', '', NULL, '', '', '', '', '', '', NULL, NULL, '', '', NULL, '', NULL, NULL, NULL, '', NULL, '', -1, '2025-04-10 12:31:15.84113', -1, '2025-04-10 12:31:15.841152', NULL, NULL, true);
INSERT INTO public.tbl_action_director_appointment VALUES (3, 2, NULL, NULL, 'Additional Director', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2025-04-10 16:43:33.360857', -1, '2025-04-10 16:43:33.360868', NULL, NULL, true);


--
-- TOC entry 6141 (class 0 OID 231273)
-- Dependencies: 468
-- Data for Name: tbl_action_general; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_action_general VALUES (1, 2, 'Appoint as Individual Director', '{"director":"07691455","term":"6 months"}', true, -1, '2025-04-09 13:41:16.502469', -1, '2025-04-09 17:31:53.842374', NULL, NULL);


--
-- TOC entry 6101 (class 0 OID 223669)
-- Dependencies: 417
-- Data for Name: tbl_adt1; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_adt1 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'NO', 'FABD', 'NO', 1234, 'YES', '2025-02-26 00:00:00', '2025-02-24 00:00:00', 'NO', '1234567', 'AFRM', '2025-02-27 00:00:00', 'reason', 1, true, '19170223', '1234567890', '2025-02-25 00:00:00', '09475141', 'SECR', '0987654321', '2025-03-17 14:13:02.850321', -1, -1, '2025-03-17 14:17:57.885109', true, NULL);
INSERT INTO public.tbl_adt1 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, 'AACV', 'NO', 1, 'NO', NULL, '2025-03-11 00:00:00', 'NO', '', 'INDI', NULL, '', 1, true, '191702', '1234567890', '2025-02-25 00:00:00', '09475141', 'MANG', '0987654321', '2025-03-19 13:45:41.661271', -1, -1, '2025-03-19 13:45:41.661275', true, NULL);
INSERT INTO public.tbl_adt1 VALUES (3, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'YES', 'FABD', 'YES', 123456789, NULL, '2025-03-21 00:00:00', '2025-03-12 00:00:00', 'NO', '', NULL, NULL, '', 1, true, '191702', '1234567890', '2025-02-24 00:00:00', '09475141', 'SECR', '1234567890', '2025-03-27 12:31:46.781853', -1, -1, '2025-03-27 12:32:00.530774', true, NULL);


--
-- TOC entry 6103 (class 0 OID 223745)
-- Dependencies: 420
-- Data for Name: tbl_adt3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_adt3 VALUES (1, NULL, 0, 'U74999MH2017PTC289529', '', '', '', '', 'Resignation', 'Due to pre-occupation in other assignment', 'mumbai', 'Other Reason', '2025-03-05 00:00:00', '2025-02-26 00:00:00', 'mumbai', 'vijay', 'self', '2025-03-22 00:00:00', 'mumbai', 'FIRM', '1234567890', 'vijay', '1234567890987654', 'kurla', 'Ahmednagar', 'GJ', 400070, NULL, '2025-02-26 00:00:00', '2025-03-06 00:00:00', 'Reasons for resignation and any other facts relevant to the resignation', 'ADTR', 'FW', 1234567890, '2025-03-17 17:08:18.534304', -1, -1, '2025-03-17 17:08:18.534308', true, NULL);
INSERT INTO public.tbl_adt3 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', '', '', '', '', 'Death', 'Due to pre-occupation in other assignment', 'mumbai', 'Other Reason', '2025-02-26 00:00:00', '2025-02-27 00:00:00', 'mumbai', 'vijay', 'self', '2025-03-06 00:00:00', 'mumbai', 'FIRM', '1234567890', 'vijay saroj', '1234567890', 'lbs marg', 'Aizawl', 'MH', 400070, NULL, '2025-03-07 00:00:00', '2025-02-25 00:00:00', 'Reasons for resignation and any other facts relevant to the resignation', 'PART', 'ASS', 1234567890, '2025-03-17 17:10:55.324567', -1, -1, '2025-03-19 13:47:29.505591', true, NULL);


--
-- TOC entry 6139 (class 0 OID 230913)
-- Dependencies: 465
-- Data for Name: tbl_aoc4; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_aoc4 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', NULL, NULL, NULL, NULL, 'OAFS', 'NA', 'NA', 'Both', NULL, '', '', 'Yes', NULL, NULL, 'No', NULL, true, true, NULL, NULL, NULL, false, false, NULL, NULL, NULL, 'No', 'No', 'Select Provision', false, '191702', '', NULL, '', NULL, NULL, '', '', '', '', '', '', NULL, NULL, '', '', '', NULL, '', NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 21312312, 31231231, NULL, 2312312, 3123123, NULL, 1231231, 23123, NULL, 1312, 3123123123, NULL, 123123, 0, NULL, 312312312, 3123123, NULL, 123123, 213123123, NULL, 3123123, 12312312, NULL, 123123, 123123, NULL, NULL, NULL, NULL, 123123122, 131231, 23123123, 12312312, 312312, 13132, 1231233, 123123, 1231231, 231231, 131312, 31231, 12312312, 312312, 3123123, 234324, 23423423, 423423423, 423423, 253453434, 4353245, 234234, 2234545, 3453453, 445324325, 5235234, 24234, 2342342, 4234234, 3453435, 34534535, 434353, 35343, 33434, 2423, 43543, 346346, 546346435, 3453, 345353, 34535345, 'No', 3213121, 634634, 4334, 34634, 3434654, 4565346, 53434, 4335, 34344, 352354234, 423423423, 234234, 23423423, 32432423, 423423423, 423423, 5425423, 3453534, 3434, 34343434, 3534, 43345, 345345345, NULL, NULL, 435345, 34534534, NULL, NULL, 232355345, 5635634, NULL, NULL, 4234, 3534534535, NULL, NULL, 345345, 34534, 32353, 353434, 5345345, 34534534, 435345, 3443, 34345345, 534534534, 3534, 34345345, 34345, 356356, 34346, 3453, 345345, 34, NULL, NULL, NULL, NULL, 3534, 46545, 32544, 643, 2354, 342, 23434, 334, NULL, NULL, NULL, NULL, 345345, 343434, 353434, 34345, 53453, 345345345, 345345, 345345, 3534, 4621543831, 343434, 3453455, 34534, 34534, 343434, 343434, NULL, NULL, NULL, NULL, 343453, 3453534, 34534534, 34, NULL, NULL, NULL, NULL, 35345, 34534, 5345345, 3434345, 2342334534, 5345345345, 53453, 3453, 34, 35345, NULL, 3453434534, 3534534, 534, 3434, 3434, 345345, NULL, 35345345, 343434, 4345, 53453, 534535, 34534534534, 53434, 53434, 2342342, 423423, 4234233, 423423423, 2423423, 53, 34345, 43453, 234234, 2342342, NULL, NULL, 242342, 3423432, NULL, NULL, NULL, NULL, 34223434, 34343, 23423, 2342342, 25343245, 'Yes', 12312312, 3534634, 1231, 1231, 1231, NULL, 312312, 3123123, 13123, 123123, 123123, NULL, NULL, 13123123, 123123123, 'Give Details (name,address and email address) of implenting agency(ies)', 'Suitable implenting agencies not found', 'Give Details (name,address and email address) of implenting agency(ies)', 'Yes', 'YES', 'If yes, Central Excise Tariff Act Heading in which the product/ service is covered

', 'YES', 'If yes, Central Excise Tariff ActHeading in which the product/ service is covered

', NULL, NULL, NULL, 'UNFO', 'UNFO', 'FAVO', 'UNFO', 'CNTA', 'DISO', 'UNFO', 'CNTA', 'DISO', 'No', 'Yes', '1234567890', '2025-04-30', '09475141', 'MANG', '12313234234', '', '265', 'FW', '12345678', '1232321312312', '2025-04-08 17:22:37.726136', -1, -1, '2025-04-09 12:40:49.022285', true, NULL);


--
-- TOC entry 6133 (class 0 OID 230647)
-- Dependencies: 457
-- Data for Name: tbl_aoc4cfs; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_aoc4cfs VALUES (1, NULL, 0, '', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '1234567890', '2025-04-10 00:00:00', '2025-04-21 00:00:00', '2025-04-13 00:00:00', '2025-04-04 00:00:00', true, '2025-04-08 00:00:00', true, '2025-04-16 00:00:00', true, '2025-04-24 00:00:00', true, '2025-04-29 00:00:00', NULL, true, '191702', '0987654321', true, '191702', '1234567890', NULL, NULL, 'POWR', NULL, 'NO', 'YES', 'YES', NULL, 'FAVO', 'UNFO', 'DISO', 'CNTA', 'FAVO', 'UNFO', 'DISO', 'CNTA', 'FAVO', 'YES', 'NO', 1234567890, '2025-04-15 00:00:00', '09475141', 'MANG', '1234567890', 'COA', '265', 'ASS', '1234567890 ', '1234567890', '2025-04-02 17:23:40.906152', -1, -1, '2025-04-02 17:23:40.906156', true, NULL);
INSERT INTO public.tbl_aoc4cfs VALUES (2, NULL, 0, '', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '1234567890', '2025-03-31 00:00:00', '2025-04-08 00:00:00', '2025-04-13 00:00:00', '2025-04-03 00:00:00', true, '2025-04-22 00:00:00', true, '2025-04-24 00:00:00', true, '2025-04-28 00:00:00', true, '2025-04-15 00:00:00', '2025-04-11 00:00:00', true, '191702', '1234567890', true, '191702', '898765432', NULL, 'YES', 'POWR', NULL, 'YES', 'YES', 'YES', 'YES', 'FAVO', 'UNFO', 'UNFO', 'UNFO', 'DISO', 'DISO', 'CNTA', 'CNTA', 'CNTA', 'NO', 'YES', 1234567890, '2025-04-13 00:00:00', '09475141', 'CEO', '1234567890', 'CA', '265', 'ASS', '1234567890', '0987654321', '2025-04-02 17:29:34.025215', -1, -1, '2025-04-02 17:29:34.025219', true, NULL);
INSERT INTO public.tbl_aoc4cfs VALUES (3, NULL, 0, '', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '1234567890', '2025-04-23 00:00:00', '2025-03-31 00:00:00', '2025-04-26 00:00:00', '2025-05-04 00:00:00', true, '2025-04-22 00:00:00', true, '2025-04-23 00:00:00', true, '2025-04-30 00:00:00', true, '2025-04-09 00:00:00', '2025-04-14 00:00:00', true, '191702', '1234567890', true, '191702', '0987654321', NULL, 'YES', 'POWR', NULL, NULL, 'YES', 'YES', 'YES', 'FAVO', 'UNFO', 'DISO', 'DISO', 'CNTA', 'DISO', 'CNTA', 'FAVO', 'UNFO', NULL, NULL, 1234567890, '2025-04-04 00:00:00', '09475141', 'CEO', '1234567890', 'CA', '265', 'ASS', '1234567890', '0987654321', '2025-04-02 17:36:41.29988', -1, -1, '2025-04-02 17:36:41.299884', true, NULL);


--
-- TOC entry 6057 (class 0 OID 221564)
-- Dependencies: 353
-- Data for Name: tbl_aoc5; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_aoc5 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', '2025-02-28 00:00:00', 'mannat apartment', 'kurla', '122', '123', 'India', '400070', '', 'mumbai', 'Kurla', 'Maharashtra', 'Kurla Police Station', 'lbs marg', 'mannat apartment', 'India', '400070', '', 'mumbai', 'Kurla ', 'Maharashtra', '', '', '', '', '12345678', NULL, 'Manager', '', '2025-03-02 10:17:24.038029', -1, -1, '2025-03-02 10:24:36.507591', true, NULL);


--
-- TOC entry 6079 (class 0 OID 222376)
-- Dependencies: 384
-- Data for Name: tbl_aoccuntnsolvencyform; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_aoccuntnsolvencyform VALUES (1, NULL, 4, '', '', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Statement of Account and Solvency', '2025-03-11 00:00:00', '2025-03-20 00:00:00', NULL, 'BANDRA HOSPITALITY LLP', 'Bandra West', '100,000', true, 'BANDRA HOSPITALITY LLP', 'is not', true, NULL, NULL, NULL, true, 'exceeds 40 lakh rupees', true, 'does not exceed', true, true, NULL, NULL, 'Ssssaasda', true, 'AssaAS', 'Y', '', 'sadasd', 'dasdasd', 'sadasd', '0dsada', 'dsadas', 'dasdasd', 'dasd', '', 'dasdas', '0dasdasd', 'asdasd', 'asdd0', '', 'dasdasd', 'asdsdasdd', 'asasd', 'adsasdad0', 'adsad', '0adasd', 'dasdasd', 'dasd', 'sadsdads', 'saddas0', '', '100000', 'sdadas', '0asdasd', 'sdasd', 'adasd0', '', '0', 'dadasd', 'dasa0', 'sdad', '0dasdasd', 'dsasad', 'sdd0', 'asdds', '0sadasd', 'asdad', '100dasd000', 'sad', 'dsadas', '', '100000', 'sadasd', '2025-03-05 00:00:00', '2025-03-18 00:00:00', NULL, '2025-03-20 00:00:00', 'sdadasd', '0asdasd', 'asdasd', '0asdasdasd', '0.00', '0.00', 'dasdasd', '0asdasd', 'asdasd', 'asdasd0', 'sdasd', '', 'dasdas', '0dasda', 'sdasda', 'dasd', 'adsa', '', 'dasdasd', '0dasdasd', 'asddads', '', '', '0', 'dsadas', 'asdasd0', 'dasdasd', '0asdasd', 'asdasd', 'asdasd0', 'dasdas', '0adsasd', 'dasd', 'dsasa0', 'dasda', 'dasdas0', 'dasd', '', 'dadas', '0dasda', 'dsdasd', 'adsasd0', 'asdd', 'adasd0', 'asdasd', '0sdaasd', 'dsa', 'dasdasd0', '', '0', '', '0', 'sad', 'asdasdasd', '', '', 'sadad', '0fddffds', '', '0', 'asdads', 'adsdasd', 'asdasd', 'LLP Administrator', 'dasdad', 'Auditor', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'Denmark', 'dasdasd', '', 'asdsad', 'sadsd', 'asdsad', 'sadasd', 'asdsadd', 'dsad', 'BANDRA HOSPITALITY LLP', 'Company Secretary in whole time practice', '265', 'Fellow', 'dasdasd', '', '2025-03-08 17:08:45.261243', -1, -1, '2025-03-08 17:08:45.261245', true, NULL);
INSERT INTO public.tbl_aoccuntnsolvencyform VALUES (2, NULL, 2, '', '', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Statement of Account and Solvency', NULL, NULL, NULL, 'BANDRA HOSPITALITY LLP', 'Bandra West', '100,000', false, 'BANDRA HOSPITALITY LLP', NULL, false, NULL, NULL, NULL, false, NULL, false, 'does not exceed', false, false, NULL, NULL, '', false, '', NULL, '', '', '100000', '', '0', '', '0', '', '', '', '0', '', '0', '', '', '0', '', '0', '', '0', '', '0', '', '0', '', '100000', '', '0', '', '0', '', '0', '', '0', '', '0', '', '0', '', '0', '', '100000', '', '', '', '100000', '', '2025-04-16 00:00:00', '2025-04-03 00:00:00', NULL, '2025-04-05 00:00:00', '324', '423230', '234324', '3242340', '0.00', '0.00', '3234', '232340', '4234', '2342340', '234234', '', '2342', '2343240', '3242', '23420', '2342', '', '234', '2340', '234', '', '', '0', '34234', '234230', '23', '230', '32', '320', '234', '230', '23', '0234', '324', '230', '3223', '', '23', '0', '', '0', '', '0', '', '0', '', '0', '', '0', '', '0', '', '0', '', '', '', '0', '', '0', '', '', '', '', '', NULL, '', '', '', '', '', '', '', '', '', '', '', '', '', 'BANDRA HOSPITALITY LLP', NULL, '', NULL, '', '', '2025-04-08 19:07:27.3849', -1, -1, '2025-04-08 19:07:27.384904', true, NULL);


--
-- TOC entry 5971 (class 0 OID 163725)
-- Dependencies: 232
-- Data for Name: tbl_api_log; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_api_log VALUES (8, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"priya express"}', '{"data": {"client_id": "corporate_name_list_pdhsaCjtXeNnbqNduadc", "company_name_search": "priya express", "company_list": [{"cin_number": "U74999MH2017PTC289529", "company_name": "PRIYA EXPRESS PRIVATE LIMITED", "company_type": "pvt_ltd"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (10, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"captable solutions"}', '{"data": {"client_id": "corporate_name_list_myJtryftcHWrXmktncha", "company_name_search": "captable solutions", "company_list": [{"cin_number": "U63999MH2024PTC435028", "company_name": "CAPTABLE SOLUTIONS PRIVATE LIMITED", "company_type": "pvt_ltd"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (15, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"l17110mh1973plc019786"}', '{"data": {"client_id": "company_xanjvalobHPcfTHShwbN", "company_id": "L17110MH1973PLC019786", "company_type": "Company", "company_name": "RELIANCE INDUSTRIES LIMITED", "details": {"company_info": {"cin": "L17110MH1973PLC019786", "roc_code": "RoC-Mumbai", "registration_number": "019786", "company_category": "Company limited by Shares", "class_of_company": "Public", "company_sub_category": "Non-govt company", "authorized_capital": "500000000000", "paid_up_capital": "135323728980", "number_of_members": "0", "date_of_incorporation": "1973-05-08", "registered_address": "3 RD FLOORMAKER CHAMBER IV 222 NARIMAN POINT NA MUMBAI MH 400021 IN", "address_other_than_ro": "-", "email_id": "savithri.parekh@ril.com", "listed_status": "Listed", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "2024-08-29", "last_bs_date": "2024-03-31", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "00001620", "director_name": "NIKHIL RASIKLAL MESWANI", "start_date": "2008-07-01", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "00001623", "director_name": "HITAL RASIKLAL MESWANI", "start_date": "2010-08-04", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "00001695", "director_name": "MUKESH DHIRUBHAI AMBANI", "start_date": "1977-04-01", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "AABPV2193C", "director_name": "SRIKANTH VENKATACHARI", "start_date": "2014-04-18", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "00005290", "director_name": "HAIGREVE KHAITAN", "start_date": "2024-04-01", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "00012144", "director_name": "MADHUSUDANA SIVAPRASAD PANDA", "start_date": "2009-08-21", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "00043501", "director_name": "KUNDAPUR KAMATH", "start_date": "2023-01-20", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "AEMPP1916N", "director_name": "SAVITHRI PAREKH", "start_date": "2019-03-29", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "02011213", "director_name": "ARUNDHATI BHATTACHARYA", "start_date": "2018-10-17", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "02787784", "director_name": "SHUMEET BANERJI", "start_date": "2017-07-21", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "06984175", "director_name": "ISHA MUKESH AMBANI", "start_date": "2023-10-27", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "06984194", "director_name": "AKASH MUKESH AMBANI", "start_date": "2023-10-27", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "07175393", "director_name": "RAMINDER SINGH GUJRAL", "start_date": "2015-06-12", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "07945702", "director_name": "ANANT MUKESH AMBANI", "start_date": "2023-10-27", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "08485334", "director_name": "VEERAYYA CHOWDARY KOSARAJU", "start_date": "2019-10-18", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "09245977", "director_name": "YASIR OTHMAN H ALRUMAYYAN", "start_date": "2021-07-19", "end_date": "1800-01-01", "surrendered_din": null}], "charges": [{"assets_under_charge": null, "charge_amount": "20200000000", "date_of_creation": "2007-07-23", "date_of_modification": "2007-11-20", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "90000000000", "date_of_creation": "2007-04-09", "date_of_modification": "2007-11-20", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "80000000", "date_of_creation": "1986-03-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "53000000", "date_of_creation": "1996-03-27", "date_of_modification": "1996-05-24", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-03-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "4125000", "date_of_creation": "1979-08-27", "date_of_modification": "1979-08-27", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-05-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1992-01-28", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1995-01-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "2000000000", "date_of_creation": "1998-05-06", "date_of_modification": "2005-06-22", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "41800000", "date_of_creation": "1980-02-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1995-02-22", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-01-14", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "877560716", "date_of_creation": "1994-09-03", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "1141351000", "date_of_creation": "2006-10-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-12-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1986-08-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-06-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "900000", "date_of_creation": "1967-03-01", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "5000000", "date_of_creation": "1972-08-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Floating charge; Movable property (not being pledge)", "charge_amount": "20200000000", "date_of_creation": "2007-07-23", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-02-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-08-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1989-09-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "233000000", "date_of_creation": "1977-12-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-09-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "140000000", "date_of_creation": "1994-02-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "24500000", "date_of_creation": "1987-02-23", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1990-02-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-02-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "50400000", "date_of_creation": "1993-12-01", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "3600000", "date_of_creation": "1984-12-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "662500000", "date_of_creation": "1988-01-14", "date_of_modification": "1996-01-04", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2000000000", "date_of_creation": "1998-11-06", "date_of_modification": "1999-05-17", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1997-02-20", "date_of_modification": "1994-01-12", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "5000000000", "date_of_creation": "2009-02-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-10-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "3080700000", "date_of_creation": "2003-03-29", "date_of_modification": "2004-08-28", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-12-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000", "date_of_creation": "1987-04-09", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1984-09-25", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-12-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "0", "date_of_creation": "1984-12-19", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "430000000", "date_of_creation": "1985-05-30", "date_of_modification": "1985-12-07", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "200000", "date_of_creation": "1970-01-22", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "61800000", "date_of_creation": "1981-08-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "4999997300", "date_of_creation": "1987-02-18", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "5000000", "date_of_creation": "1980-03-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "510000000", "date_of_creation": "2000-10-20", "date_of_modification": "2005-08-30", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "60000000", "date_of_creation": "2004-05-18", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "5450000000", "date_of_creation": "1998-03-31", "date_of_modification": "2005-06-22", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "11060000", "date_of_creation": "1980-07-18", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1986-06-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1997-03-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "7500000", "date_of_creation": "1970-08-01", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "0", "date_of_creation": "1983-01-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-07-01", "date_of_modification": "1999-04-05", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "33200000", "date_of_creation": "1990-05-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "5000000000", "date_of_creation": "2010-08-18", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "100000000", "date_of_creation": "1993-06-15", "date_of_modification": "1994-07-04", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "510000000", "date_of_creation": "2006-10-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "35000000", "date_of_creation": "1978-10-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Floating charge; Movable property (not being pledge)", "charge_amount": "34875000000", "date_of_creation": "2007-11-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "7600000", "date_of_creation": "1980-02-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1986-03-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "0", "date_of_creation": "2003-07-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "13350000000", "date_of_creation": "2001-04-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "13800000", "date_of_creation": "1988-03-16", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1250000000", "date_of_creation": "2002-09-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "70000000", "date_of_creation": "1992-10-01", "date_of_modification": "1993-02-25", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-08-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-01-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "510000000", "date_of_creation": "2006-10-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1979-04-27", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2000000", "date_of_creation": "1971-04-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "5000000", "date_of_creation": "1980-08-11", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "150000000", "date_of_creation": "1984-05-30", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "426500000", "date_of_creation": "1988-01-30", "date_of_modification": "1989-08-16", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "52360000", "date_of_creation": "1989-04-28", "date_of_modification": "1989-05-23", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "473", "date_of_creation": "2001-09-13", "date_of_modification": "2005-06-22", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-12-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "1250000000", "date_of_creation": "2004-06-17", "date_of_modification": "2006-04-24", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1989-10-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "10000000", "date_of_creation": "1976-05-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "20156571", "date_of_creation": "1978-11-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-10-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "0", "date_of_creation": "1999-01-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "12900000000", "date_of_creation": "2006-06-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Book debts; Floating charge; Movable property (not being pledge)", "charge_amount": "126500000000", "date_of_creation": "2007-12-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "5750000000", "date_of_creation": "1996-09-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "4000000", "date_of_creation": "1980-01-02", "date_of_modification": "1980-01-02", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "200000000", "date_of_creation": "2006-03-29", "date_of_modification": "2006-04-24", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-07-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "355000000", "date_of_creation": "1996-01-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "22500000", "date_of_creation": "1992-05-29", "date_of_modification": "1992-09-12", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "40000000", "date_of_creation": "1973-08-11", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-12-03", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "126500000000", "date_of_creation": "2007-12-20", "date_of_modification": "2010-12-30", "status": "OPEN"}, {"assets_under_charge": " Immovable property or any interest therein; Book debts; Movable property (not being pledge)", "charge_amount": "2371336800", "date_of_creation": "1985-12-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-01-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "150000000", "date_of_creation": "1984-05-10", "date_of_modification": "1995-10-06", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "30000000", "date_of_creation": "1992-05-15", "date_of_modification": "1992-09-12", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "1996000", "date_of_creation": "1973-06-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "3500000", "date_of_creation": "1979-08-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "122266485.5", "date_of_creation": "1989-03-23", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-10-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2000000000", "date_of_creation": "2001-04-27", "date_of_modification": "2005-10-28", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "5500000", "date_of_creation": "1980-07-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "60000000", "date_of_creation": "2004-05-18", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2700000000", "date_of_creation": "1985-08-16", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "3300000", "date_of_creation": "1979-09-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-01-25", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-07-05", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "587188807", "date_of_creation": "2006-10-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000", "date_of_creation": "1988-04-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "1095000000", "date_of_creation": "1996-03-27", "date_of_modification": "1996-06-04", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "4750000000", "date_of_creation": "1999-02-03", "date_of_modification": "2005-10-28", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "4500000", "date_of_creation": "1973-01-22", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "6000000", "date_of_creation": "1979-08-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "37788800", "date_of_creation": "1989-11-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Floating charge; Movable property (not being pledge)", "charge_amount": "22500000000", "date_of_creation": "2008-08-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-03-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1500000000", "date_of_creation": "1994-10-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-08-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "8000000", "date_of_creation": "1980-06-19", "date_of_modification": "1985-12-07", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "21453000", "date_of_creation": "1969-10-05", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-10-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1995-05-05", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "500000000", "date_of_creation": "1998-02-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000", "date_of_creation": "1987-08-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-12-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "18300000000", "date_of_creation": "1999-09-20", "date_of_modification": "1999-09-20", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "264000000000", "date_of_creation": "1996-12-27", "date_of_modification": "2008-12-30", "status": "OPEN"}, {"assets_under_charge": null, "charge_amount": "29100000", "date_of_creation": "1991-07-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "137750000000", "date_of_creation": "2022-10-12", "date_of_modification": "2023-03-27", "status": "Closed"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "1111", "date_of_creation": "2001-07-16", "date_of_modification": "2005-12-26", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "5469000000", "date_of_creation": "1993-02-20", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "800000000", "date_of_creation": "1998-03-31", "date_of_modification": "2005-06-22", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1997-02-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "10000000", "date_of_creation": "1980-04-18", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1984-08-17", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "0", "date_of_creation": "1989-11-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-10-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "80000000", "date_of_creation": "1991-09-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "65306000", "date_of_creation": "1985-06-07", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "3000000000", "date_of_creation": "2000-08-09", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "9000000", "date_of_creation": "1978-02-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "52245000", "date_of_creation": "1985-06-07", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "500000000", "date_of_creation": "2007-06-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "26076000", "date_of_creation": "1985-07-17", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "60000000", "date_of_creation": "1987-10-01", "date_of_modification": "1988-05-30", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "29500000", "date_of_creation": "1986-04-02", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "302493920", "date_of_creation": "1985-10-15", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "430000000", "date_of_creation": "1985-05-30", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "80000000", "date_of_creation": "1987-02-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2069000", "date_of_creation": "1991-09-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "4000000", "date_of_creation": "1983-12-30", "date_of_modification": "1983-12-30", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "14000000", "date_of_creation": "1982-05-16", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-03-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "61500000", "date_of_creation": "1985-11-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "30000000", "date_of_creation": "1988-05-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "52360000", "date_of_creation": "1989-04-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "10000000000", "date_of_creation": "2009-02-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "5250000000", "date_of_creation": "1995-11-22", "date_of_modification": "2005-10-28", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "9000000000", "date_of_creation": "2003-06-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-08-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20156571", "date_of_creation": "1979-08-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "14500000", "date_of_creation": "1984-08-13", "date_of_modification": "1985-06-28", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2800000", "date_of_creation": "1986-08-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "128500000", "date_of_creation": "1992-07-14", "date_of_modification": "1992-11-17", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Book debts; Movable property (not being pledge)", "charge_amount": "57500000", "date_of_creation": "1997-01-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-09-23", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-10-11", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "250000000", "date_of_creation": "1996-10-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "217800000", "date_of_creation": "1989-07-05", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1989-01-16", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1994-07-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "20000000", "date_of_creation": "1976-05-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1979-04-27", "date_of_modification": "1985-12-07", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "11060000", "date_of_creation": "1979-08-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-01-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "3966000000", "date_of_creation": "1993-02-20", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "446300000", "date_of_creation": "1987-06-19", "date_of_modification": "1991-03-11", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "1141351000", "date_of_creation": "2006-10-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "173000000", "date_of_creation": "1978-05-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1993-10-09", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-11-06", "date_of_modification": "2000-03-11", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "8400000000", "date_of_creation": "1999-02-10", "date_of_modification": "2000-08-03", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1990-03-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "500000000", "date_of_creation": "2001-12-29", "date_of_modification": "2005-12-26", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1250000000", "date_of_creation": "2002-09-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-09-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1083500000", "date_of_creation": "1986-05-19", "date_of_modification": "1995-01-12", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "600000000", "date_of_creation": "1997-02-06", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "185000000", "date_of_creation": "1975-08-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-03-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1986-07-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "50000000000", "date_of_creation": "2009-03-03", "date_of_modification": "2009-08-24", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "12900000000", "date_of_creation": "2006-06-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-05-28", "date_of_modification": "1999-08-23", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1981-07-30", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "11413510", "date_of_creation": "2002-03-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "587188807", "date_of_creation": "2006-10-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "4250000000", "date_of_creation": "1998-08-18", "date_of_modification": "2005-10-28", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "60000000", "date_of_creation": "1991-09-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-12-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "10000000", "date_of_creation": "1985-04-23", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "33120716", "date_of_creation": "1991-11-08", "date_of_modification": "1992-10-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1999-01-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1997-01-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "139200000", "date_of_creation": "1988-02-18", "date_of_modification": "1988-02-18", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000", "date_of_creation": "1992-12-03", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "52360000", "date_of_creation": "1989-04-21", "date_of_modification": "1995-10-06", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "100000000", "date_of_creation": "1996-10-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "28200000", "date_of_creation": "1987-12-14", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-12-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts; Movable property (not being pledge)", "charge_amount": "1245000000", "date_of_creation": "2005-09-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "500000000", "date_of_creation": "2007-06-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "10000000000", "date_of_creation": "2009-02-12", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "50000000", "date_of_creation": "1990-08-21", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "450973700", "date_of_creation": "2006-10-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "6000000", "date_of_creation": "1982-07-15", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-08-14", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "1000000000", "date_of_creation": "1999-11-22", "date_of_modification": "2005-06-22", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "50000000", "date_of_creation": "1986-12-11", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "17320000000", "date_of_creation": "2000-04-19", "date_of_modification": "2005-12-26", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "221900000", "date_of_creation": "1989-04-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "550000", "date_of_creation": "1974-11-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1983-01-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "3500000", "date_of_creation": "1980-02-05", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts", "charge_amount": "5000000", "date_of_creation": "1981-05-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "500000000", "date_of_creation": "2000-10-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "5000000", "date_of_creation": "1972-09-16", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "57500000", "date_of_creation": "1990-02-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "9250000000", "date_of_creation": "1995-02-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "40000000", "date_of_creation": "1987-10-16", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1990-03-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1985-10-15", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "11000000", "date_of_creation": "1991-10-03", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "2200000000", "date_of_creation": "2006-06-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-07-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1990-03-17", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-04-10", "date_of_modification": "1996-06-04", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "30500000", "date_of_creation": "1986-04-02", "date_of_modification": "1988-02-25", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "22000000", "date_of_creation": "1978-10-03", "date_of_modification": "1978-10-03", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "222000000", "date_of_creation": "1989-04-28", "date_of_modification": "1995-10-06", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "17900000000", "date_of_creation": "2002-11-13", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-03-19", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1982-06-07", "date_of_modification": "1986-05-15", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1998-01-22", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1986-09-29", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "3740000000", "date_of_creation": "1993-09-20", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1991-08-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein; Movable property (not being pledge)", "charge_amount": "450973700", "date_of_creation": "2006-10-26", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "8000000000", "date_of_creation": "2004-02-17", "date_of_modification": "2014-11-20", "status": "CLOSED"}, {"assets_under_charge": " Goodwill", "charge_amount": "12575000", "date_of_creation": "1988-01-28", "date_of_modification": "1994-10-17", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1996-12-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "6000000", "date_of_creation": "1980-03-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "35000000", "date_of_creation": "1994-08-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "30500000", "date_of_creation": "1985-05-27", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "219000000", "date_of_creation": "1992-11-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1985-10-15", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts; Movable property (not being pledge)", "charge_amount": "1245000000", "date_of_creation": "2005-09-28", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1989-11-10", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "541000000", "date_of_creation": "2003-03-29", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Floating charge; Movable property (not being pledge)", "charge_amount": "90000000000", "date_of_creation": "2007-04-09", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "1000000000", "date_of_creation": "1997-01-04", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "4400000000", "date_of_creation": "1996-01-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1978-12-24", "date_of_modification": "1985-12-07", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "20000000", "date_of_creation": "1980-02-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "5000000000", "date_of_creation": "2009-02-12", "date_of_modification": "2014-11-21", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "1680000", "date_of_creation": "1967-03-31", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "3000000", "date_of_creation": "1976-08-07", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1044800000", "date_of_creation": "1990-11-20", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "1000000000", "date_of_creation": "1998-02-26", "date_of_modification": "1999-02-26", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "0", "date_of_creation": "1990-05-31", "date_of_modification": "1995-10-09", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "15660000000", "date_of_creation": "2020-06-24", "date_of_modification": "2023-05-08", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "10000000000", "date_of_creation": "2020-06-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000000", "date_of_creation": "2020-06-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "20000000000", "date_of_creation": "2020-06-24", "date_of_modification": "2024-01-03", "status": "Open"}, {"assets_under_charge": null, "charge_amount": "20000000000", "date_of_creation": "2020-06-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "15000000000", "date_of_creation": "2020-06-24", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "42500000000", "date_of_creation": "2022-03-23", "date_of_modification": "2024-09-23", "status": "Open"}, {"assets_under_charge": null, "charge_amount": "15310000000", "date_of_creation": "2020-06-24", "date_of_modification": "2023-05-08", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "10000000000", "date_of_creation": "2023-03-14", "date_of_modification": "2024-01-10", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "23750000000", "date_of_creation": "2022-09-09", "date_of_modification": "1800-01-01", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "45000000000", "date_of_creation": "2022-09-02", "date_of_modification": "2022-11-30", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "2000000000", "date_of_creation": "2020-05-20", "date_of_modification": "2022-05-31", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "67500000000", "date_of_creation": "2022-08-06", "date_of_modification": "2023-03-27", "status": "Closed"}, {"assets_under_charge": null, "charge_amount": "200000000000", "date_of_creation": "2023-11-10", "date_of_modification": "1800-01-01", "status": "Open"}]}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (1, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"u15209mh2024ptc429590"}', '{"data": {"client_id": "company_HIkovjZWwceyYiakeeal", "company_id": "U15209MH2024PTC429590", "company_type": "Company", "company_name": "NITYANIKAR VENTURES PRIVATE LIMITED", "details": {"company_info": {"cin": "U15209MH2024PTC429590", "roc_code": "RoC-Mumbai", "registration_number": "429590", "company_category": "Company limited by Shares", "class_of_company": "Private", "company_sub_category": "Non-govt company", "authorized_capital": "1500000", "paid_up_capital": "1000000", "number_of_members": "0", "date_of_incorporation": "2024-07-27", "registered_address": "Vikas Apt, Flat-5, Janki Kutir, Vile Parle W Juhu Mumbai Mumbai MH 400049 IN", "address_other_than_ro": "-", "email_id": "contact@nityanikar.com", "listed_status": "Unlisted", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "1800-01-01", "last_bs_date": "1800-01-01", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "06750200", "director_name": "ANJALI CHATURVEDI .", "start_date": "2024-07-27", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "06750234", "director_name": "NIRBHAY CHATURVEDI NANDKISHORE", "start_date": "2024-07-27", "end_date": "1800-01-01", "surrendered_din": null}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (2, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"priya express private limited"}', '{"data": {"client_id": "corporate_name_list_WNhkUdmttPshrFnrbmfA", "company_name_search": "PRIYA EXPRESS PRIVATE LIMITED", "company_list": [{"cin_number": "U74999MH2017PTC289529", "company_name": "PRIYA EXPRESS PRIVATE LIMITED", "company_type": "pvt_ltd"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (3, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"priya express"}', '{"data": {"client_id": "corporate_name_list_KmcWhaNuglqAMXtBLWnz", "company_name_search": "priya express", "company_list": [{"cin_number": "U74999MH2017PTC289529", "company_name": "PRIYA EXPRESS PRIVATE LIMITED", "company_type": "pvt_ltd"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (4, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"sateri icon"}', '{"data": {"client_id": "corporate_name_list_hfyEZYkqlaPMvRMlAbLM", "company_name_search": "sateri icon", "company_list": [{"cin_number": "ACK-3583", "company_name": "SATERI ICON LLP", "company_type": "llp"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (5, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"ack-3583"}', '{"data": {"client_id": "company_bqXwuxnBVncPCNffVIAJ", "company_id": "ACK-3583", "company_type": "LLP", "company_name": "SATERI ICON LLP", "details": {"company_info": {"llpin": "ACK-3583", "number_of_partners": "0", "number_of_designated_partners": "4", "roc_code": "ROC Mumbai", "date_of_incorporation": "2024-11-17", "registered_address": "Room No 15, Chawl No 10, Mahakali Shivshankar NagarNew Agari Pada, Mahakali MandirSantacruz(East)MumbaiMumbaiMaharashtra400055India", "email_id": "dineshnivendikar@gmail.com", "previous_company_details": "", "total_obligation_of_contribution": "100000", "main_division_of_business_activity_in_india": "43", "description_of_main_division": "CONSTRUCTION", "statement_of_accounts_and_solvency_filed_date": "1800-01-01", "annual_return_filed_date": "1800-01-01", "llp_status": "Active"}, "directors": [{"din_number": "10815548", "director_name": "DINESHBABANNIVENDIKAR", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816000", "director_name": "MITHUNSHRIKANTSARODE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816412", "director_name": "PARSHURAMGOPALTANAWDE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816527", "director_name": "SANDESHRAGHUNATHMORE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (6, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"ack-3583"}', '{"data": {"client_id": "company_eZetzhdmLGeFkXJzpzXB", "company_id": "ACK-3583", "company_type": "LLP", "company_name": "SATERI ICON LLP", "details": {"company_info": {"llpin": "ACK-3583", "number_of_partners": "0", "number_of_designated_partners": "4", "roc_code": "ROC Mumbai", "date_of_incorporation": "2024-11-17", "registered_address": "Room No 15, Chawl No 10, Mahakali Shivshankar NagarNew Agari Pada, Mahakali MandirSantacruz(East)MumbaiMumbaiMaharashtra400055India", "email_id": "dineshnivendikar@gmail.com", "previous_company_details": "", "total_obligation_of_contribution": "100000", "main_division_of_business_activity_in_india": "43", "description_of_main_division": "CONSTRUCTION", "statement_of_accounts_and_solvency_filed_date": "1800-01-01", "annual_return_filed_date": "1800-01-01", "llp_status": "Active"}, "directors": [{"din_number": "10815548", "director_name": "DINESHBABANNIVENDIKAR", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816000", "director_name": "MITHUNSHRIKANTSARODE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816412", "director_name": "PARSHURAMGOPALTANAWDE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816527", "director_name": "SANDESHRAGHUNATHMORE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (7, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"ack-3583"}', '{"data": {"client_id": "company_IXwkyVvuIwyaDrzNptnV", "company_id": "ACK-3583", "company_type": "LLP", "company_name": "SATERI ICON LLP", "details": {"company_info": {"llpin": "ACK-3583", "number_of_partners": "0", "number_of_designated_partners": "4", "roc_code": "ROC Mumbai", "date_of_incorporation": "2024-11-17", "registered_address": "Room No 15, Chawl No 10, Mahakali Shivshankar NagarNew Agari Pada, Mahakali MandirSantacruz(East)MumbaiMumbaiMaharashtra400055India", "email_id": "dineshnivendikar@gmail.com", "previous_company_details": "", "total_obligation_of_contribution": "100000", "main_division_of_business_activity_in_india": "43", "description_of_main_division": "CONSTRUCTION", "statement_of_accounts_and_solvency_filed_date": "1800-01-01", "annual_return_filed_date": "1800-01-01", "llp_status": "Active"}, "directors": [{"din_number": "10815548", "director_name": "DINESHBABANNIVENDIKAR", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816000", "director_name": "MITHUNSHRIKANTSARODE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816412", "director_name": "PARSHURAMGOPALTANAWDE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}, {"din_number": "10816527", "director_name": "SANDESHRAGHUNATHMORE", "start_date": "2024-11-17", "end_date": "1800-01-01", "surrendered_din": "No"}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (9, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"u74999mh2017ptc289529"}', '{"data": {"client_id": "company_iuyleqkZSlmYCRwowNpq", "company_id": "U74999MH2017PTC289529", "company_type": "Company", "company_name": "PRIYA EXPRESS PRIVATE LIMITED", "details": {"company_info": {"cin": "U74999MH2017PTC289529", "roc_code": "RoC-Mumbai", "registration_number": "289529", "company_category": "Company limited by Shares", "class_of_company": "Private", "company_sub_category": "Non-govt company", "authorized_capital": "100000", "paid_up_capital": "100000", "number_of_members": "0", "date_of_incorporation": "2017-01-13", "registered_address": "SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN", "address_other_than_ro": "-", "email_id": "pakshal.shah2003@gmail.com", "listed_status": "Unlisted", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "2024-09-30", "last_bs_date": "2024-03-31", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "07691455", "director_name": "PAKSHAL KIRAN SHAH", "start_date": "2017-01-13", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "07693548", "director_name": "KIRAN PREMCHAND SHAH", "start_date": "2017-01-13", "end_date": "1800-01-01", "surrendered_din": null}], "charges": [{"assets_under_charge": " Book debts", "charge_amount": "1500000", "date_of_creation": "2018-08-31", "date_of_modification": "2020-02-13", "status": "OPEN"}]}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (11, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"u63999mh2024ptc435028"}', '{"data": {"client_id": "company_mtcfBYwIaMWNqxJkewuT", "company_id": "U63999MH2024PTC435028", "company_type": "Company", "company_name": "CAPTABLE SOLUTIONS PRIVATE LIMITED", "details": {"company_info": {"cin": "U63999MH2024PTC435028", "roc_code": "RoC-Mumbai", "registration_number": "435028", "company_category": "Company limited by Shares", "class_of_company": "Private", "company_sub_category": "Non-govt company", "authorized_capital": "1500000", "paid_up_capital": "100000", "number_of_members": "0", "date_of_incorporation": "2024-11-19", "registered_address": "Shop No 5 Shiv Krupa CHS Old Nagardas Rd Andheri E Nagardas Road Mumbai Mumbai MH 400069 IN", "address_other_than_ro": "-", "email_id": "compycrafter@gmail.com", "listed_status": "Unlisted", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "1800-01-01", "last_bs_date": "1800-01-01", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "07693548", "director_name": "KIRAN PREMCHAND SHAH", "start_date": "2024-11-19", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "07900169", "director_name": "SIDDHARTH RAVI PRAKASH SINGH", "start_date": "2024-11-19", "end_date": "1800-01-01", "surrendered_din": null}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (12, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"khatri dyeing"}', '{"data": {"client_id": "corporate_name_list_ZSLPfAuaghXiveyREkdV", "company_name_search": "khatri dyeing", "company_list": [{"cin_number": "U24299MH2001PTC133129", "company_name": "KHATRI DYEING PRIVATE LIMITED", "company_type": "pvt_ltd"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (13, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"u24299mh2001ptc133129"}', '{"data": {"client_id": "company_kzxLtlHaOEwGXsGItqXB", "company_id": "U24299MH2001PTC133129", "company_type": "Company", "company_name": "KHATRI DYEING PRIVATE LIMITED", "details": {"company_info": {"cin": "U24299MH2001PTC133129", "roc_code": "RoC-Mumbai", "registration_number": "133129", "company_category": "Company limited by Shares", "class_of_company": "Private", "company_sub_category": "Non-govt company", "authorized_capital": "20000000", "paid_up_capital": "10150000", "number_of_members": "0", "date_of_incorporation": "2001-08-23", "registered_address": "Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN", "address_other_than_ro": "-", "email_id": "msekhatri@gmail.com", "listed_status": "Unlisted", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "2024-09-30", "last_bs_date": "2024-03-31", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "02296418", "director_name": "ABDUL QADER EBRAHIM KHATRI", "start_date": "2002-12-02", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "03158651", "director_name": "MOHAMMED SALIM EBRAHIM KHATRI", "start_date": "2002-12-02", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "03312797", "director_name": "ABDUL REHMAN MOHAMMED SALIM KHATRI", "start_date": "2010-12-10", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "03342236", "director_name": "AHMED ABDUL QADER KHATRI", "start_date": "2010-12-10", "end_date": "1800-01-01", "surrendered_din": null}, {"din_number": "06595621", "director_name": "OZAIR MOHAMMED SALIM KHATRI", "start_date": "2013-06-01", "end_date": "1800-01-01", "surrendered_din": null}], "charges": [{"assets_under_charge": " Movable property (not being pledge)", "charge_amount": "12500000", "date_of_creation": "2007-03-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "5000000", "date_of_creation": "2004-10-08", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Book debts; Movable property (not being pledge)", "charge_amount": "5270000", "date_of_creation": "2009-05-11", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": null, "charge_amount": "6000000", "date_of_creation": "2004-01-12", "date_of_modification": "2007-03-16", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "29978388", "date_of_creation": "2018-08-02", "date_of_modification": "1800-01-01", "status": "CLOSED"}, {"assets_under_charge": " Immovable property or any interest therein", "charge_amount": "46000000", "date_of_creation": "2019-03-29", "date_of_modification": "1800-01-01", "status": "OPEN"}, {"assets_under_charge": null, "charge_amount": "52000000", "date_of_creation": "2021-12-14", "date_of_modification": "1800-01-01", "status": "Closed"}, {"assets_under_charge": " Motor Vehicle (Hypothecation)", "charge_amount": "281726", "date_of_creation": "2022-03-04", "date_of_modification": "1800-01-01", "status": "OPEN"}]}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (14, 'https://sandbox.surepass.io/api/v1/corporate/din', '{"id_number":"06750200"}', '{"data": {"client_id": "corporate_din_sOGrTBPymLgfsGELbUgw", "din_number": "06750200", "father_name": "OMPRAKASH CHATURVEDI ", "full_name": "ANJALI CHATURVEDI .", "dob": "1984-09-21", "nationality": "IN", "present_address": "", "permanent_address": "", "email": "", "pan_number": null, "companies_associated": [], "status": "success"}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (16, 'https://sandbox.surepass.io/api/v1/corporate/name-to-cin-list', '{"company_name_search":"saptrang"}', '{"data": {"client_id": "corporate_name_list_TNMlFwcxBiGllEMnnewq", "company_name_search": "saptrang", "company_list": [{"cin_number": "AAD-9902", "company_name": "SAPTRANGA EVENT MANAGEMENT LLP", "company_type": "llp"}, {"cin_number": "U18102MH2019PTC333123", "company_name": "SAPTRANG APPARELS PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U51900MH1994PTC159767", "company_name": "SAPTRANG COMMODEAL PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U51109WB1994PTC066647", "company_name": "SAPTRANG COMMODEAL PVT. LTD.", "company_type": "other"}, {"cin_number": "U40106MH2022PTC384004", "company_name": "SAPTRANG ENERGY PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U01110KA2017PTC108044", "company_name": "SAPTRANG EXIM TECH PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U01400MH2020PTC338587", "company_name": "SAPTRANG FARMERS PRODUCER COMPANY LIMITED", "company_type": "ltd"}, {"cin_number": "U85100MH2022PTC390537", "company_name": "SAPTRANG HEALTH CARE PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U36900DL2007PLC305811", "company_name": "SAPTRANGI CRAFT LIMITED", "company_type": "ltd"}, {"cin_number": "U45203MH2021OPC368682", "company_name": "SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED", "company_type": "opc"}, {"cin_number": "U63090PN2018PTC176560", "company_name": "SAPTRANG INNOVATIONS PRIVATE LIMITED", "company_type": "pvt_ltd"}, {"cin_number": "U51109WB1994PTC066618", "company_name": "SAPTRANG TIE-UP PVT. LTD.", "company_type": "other"}]}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);
INSERT INTO public.tbl_api_log VALUES (17, 'https://sandbox.surepass.io/api/v1/corporate/company-details', '{"id_number":"u45203mh2021opc368682"}', '{"data": {"client_id": "company_rIXgrMtjlUkFukUBdlox", "company_id": "U45203MH2021OPC368682", "company_type": "Company", "company_name": "SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED", "details": {"company_info": {"cin": "U45203MH2021OPC368682", "roc_code": "RoC-Mumbai", "registration_number": "368682", "company_category": "Company limited by Shares", "class_of_company": "Private(One Person Company)", "company_sub_category": "Non-govt company", "authorized_capital": "100000", "paid_up_capital": "10000", "number_of_members": "0", "date_of_incorporation": "2021-10-01", "registered_address": "SHOP NO.12, SURYA HOUSE,C.T.S. NO.-464/A KIROL, RD NO.7, VIDYAVIHAR EAST ,KURLA MUMBAI Mumbai City MH 400077 IN", "address_other_than_ro": "-", "email_id": "SPKSTAR4U@GMAIL.COM", "listed_status": "Unlisted", "active_compliance": null, "suspended_at_stock_exchange": "-", "last_agm_date": "1800-01-01", "last_bs_date": "2024-03-31", "company_status": "Active", "status_under_cirp": null}, "directors": [{"din_number": "09343689", "director_name": "SHITALAPRASAD ORIRAM KORI", "start_date": "2021-10-01", "end_date": "1800-01-01", "surrendered_din": null}], "charges": []}}, "status_code": 200, "success": true, "message": null, "message_code": "success"}
', 'POST', NULL);


--
-- TOC entry 5981 (class 0 OID 180242)
-- Dependencies: 243
-- Data for Name: tbl_auditor; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_auditor VALUES (1, 'category  1', 'frn', 'Auditor 1', 'string', 'firmEmail', 'address', 'string', 'string', 'string', 'string', 1, '2024-11-28 15:55:56.408947', -1, '2024-11-28 15:57:12.543729', NULL, NULL, true);
INSERT INTO public.tbl_auditor VALUES (3, 'Auditors Firm', 'fk frn', 'Fk Firm', 'Fk Pan', 'fkemail@gmail.com', 'fk address', 'fkcountry', 'fkstate', 'fkcity', 'fkpincode', -1, '2024-11-28 17:37:55.707779', -1, '2024-11-28 18:26:01.475544', NULL, 1, true);
INSERT INTO public.tbl_auditor VALUES (2, 'category 2', 'frn 2', 'Auditor 2', 'pan 2', 'firmEmai 2l', 'address 2', 'string', 'string', 'string', 'string', 1, '2024-11-28 15:56:22.894427', -1, '2024-11-28 15:56:22.89443', NULL, NULL, true);


--
-- TOC entry 5983 (class 0 OID 180251)
-- Dependencies: 245
-- Data for Name: tbl_auditor_partner; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_auditor_partner VALUES (1, 1, 'partners', 'partners 1 name', 'partners 1 mobile', 'partners 1 email', 'partners');
INSERT INTO public.tbl_auditor_partner VALUES (2, 2, 'partners', 'partners 2  name', 'partners 2  mobile', 'partners 2 email', 'partners');
INSERT INTO public.tbl_auditor_partner VALUES (3, 1, 'partners', 'partners 3  name', 'partners 3  mobile', 'partners 3 email', 'partners');
INSERT INTO public.tbl_auditor_partner VALUES (4, 3, 'fkproprieto member number', 'fk proprieto name', 'fk proprieto number', 'fk@proprieto.number', 'fk proprieto designation');


--
-- TOC entry 6051 (class 0 OID 221456)
-- Dependencies: 344
-- Data for Name: tbl_ben2; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_ben2 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', false, false, false, false, false, 1234567890, '', 13, '', '', 1234567890, NULL, 'CEO', 'alpha', '1234567890', 'Company secretary (in whole-time practice)', '265', 'Associate', 987654321, '2025-03-01 13:30:24.786514', -1, -1, '2025-03-01 13:30:24.786516', true, NULL);
INSERT INTO public.tbl_ben2 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', true, true, true, true, false, 1234567890, '', 12, '', '', 1234567890, NULL, 'Director', 'alpha', '1234567890', 'Company secretary (in whole-time practice)', '439', 'Fellow', NULL, '2025-03-01 13:31:32.378354', -1, -1, '2025-03-01 13:31:32.378357', true, NULL);
INSERT INTO public.tbl_ben2 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', true, true, true, true, true, 1234567890, '', 101, '', '', 1234567890, '2025-02-27 00:00:00', 'Manager', 'alpha', '1234567890', 'Company secretary (in whole-time practice)', '265', NULL, 1234567890, '2025-03-01 13:11:30.34776', -1, -1, '2025-03-01 16:03:18.840915', true, NULL);


--
-- TOC entry 6135 (class 0 OID 230765)
-- Dependencies: 460
-- Data for Name: tbl_boardreport; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_boardreport VALUES (7, NULL, 4, '', '', '', '', '2023-24', 'Lakhs', 'Abridged', '2025-04-25 00:00:00', '2025-04-23 00:00:00', '2025-04-26 00:00:00', '00:00', 2432, '104324', 64324, '', '2025-04-10 00:00:00', 3242342, 43243, '', '2025-05-22 00:00:00', 224, 432432, '3', '2025-04-12 00:00:00', 24, 432, '4', '2025-04-18 00:00:00', 25436, 2545, '5', '2025-04-25 00:00:00', 2656, 56562, '6', '2025-04-18 00:00:00', 244, 442, 133, '1', 'AGM', '2025-04-11 00:00:00', 564, 564, 'on', 'dfsfds', 'cvxxc', 'cxvx', 'xcvv', 'cxxvc', 'cvx', 'cxvxc', 'cxvxcv', 'xcvxcv', 'vxcvxc', 'vcxvxc', 'cvxvcx', 'cvxcv', 'vcxv', 'fsdfss', 'dsffds', 'sdfsfd', 'fdsfsdfsdsd', 'ds', 'dsfsdf', 'sfd', 'sdfsdf', 'dsfsdf', 'fdsfsdf', 'dsfsdf', 'on', 'Not Applicable', 'on', 45435, 'Not Applicable', 'on', 'sdadsa', '2025-04-08 00:00:00', 'Individual', 'dsdsads', '2025-05-01', '2025-04-24 00:00:00', 'on', 'Not Applicable', 'dsadasd', '2025-04-17 00:00:00', NULL, 'dsadasdx', 'Not Applicable', 'dsadasd', '2025-04-29 00:00:00', NULL, 'dsadsadasd', 'on', 'sdsad', 'There were no loans, guarantees, or investments made by the Company under Section 186 of the Companies Act, 2013 during the year under review and hence the said provision is not applicable.
', 'on', NULL, 'dsad', NULL, 435, NULL, 534, 'on', 'During the period under review, the Company has not changed its line of business in such a way that amounts to commencement of any new business or discontinuance, sale or disposal of any of its existing businesses or hiving off any segment or division.
', 'on', 'yes', 543, 'yes', 'fds', 'yes', 'vcxv', 'vcvx', 'sasaSas', 'xzXZ', 'dsadasd', 'yes', 'dsad', 'asdasd', 'sadsad', 'yes', 'sadasdsad', 'dasd', 'sadsadas', 'yes', 'dsadasd', 'asdasda', 'sdasd', 'yes', 'dsad', 'sadsad', 'sdasd', 'no', 'asdasdad', 'yes', 'Inadequate profits', 'yes', 'dsadasdds', 'dsadasd', 'xzxzX', 'adas', 'yes', 'asd', 'sdasdasdasd', 'dsada', 'dasdasd', 'no', 'ddasdasd', 'on', 'asdadsa', 'on', 'on', '', 'on', 'dsad', 'dsadasd', 'asdas', 'sadsad', 'dasda', 'asdd', 'sdasd', 'asdas', 'asdasd', 'asd', NULL, 'xzXz', 'xzxzXz', 'Cessation', '2025-04-22 00:00:00', NULL, 'on', 'on', 'xzXZXZX', 'xz', 'xzXZX', 'yes', 'zxZ', 'XZX', 'ZXZX', 'xZX', 'xzxxX', 'Not Applicable', 'xZXZX', 'Not Applicable', 'on', 'xzXX', 'zxzX', 'zxZX', 'xZX', 'on', 'xZXzX', 'Not Applicable', 'on', 'Not Applicable', '', 'Not Applicable', 'zXz', 'scdsds', 'xxzcd', 'ZXZX', 'on', 'cxzc', 'xzczx', 'czczxc', 'on', NULL, '
                            ', 'on', 'on', 'Not Applicable', 'Annexure 3', '
                            ', 'zxczxc', 'xzc', 'xzc', 'zxcz', 'czx', '2025-04-25 00:00:00', 'zxczx', 'czxcc', 'xczczxc', 'czxczxc', 'Not applicable', 'Not applicable', 'Mumbai', NULL, 'Mokshank Dilipbhai Savla', '09475141', 'Director', 'Rakshit Dilip Savla', '09473752', 'Director', 'cxzcxzc', '2025-04-07 13:01:30.093633', -1, -1, '2025-04-07 16:20:05.652386', true, NULL);


--
-- TOC entry 6127 (class 0 OID 230586)
-- Dependencies: 450
-- Data for Name: tbl_cag; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_cag VALUES (1, 2, 'Provide details of comment(s) or supplement(s) received from CAG of India 1', 'Board of Director''s reply(ies) on comments received from CAG of India 1', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_cag VALUES (2, 2, 'Provide details of comment(s) or supplement(s) received from CAG of India 2', 'Board of Director''s reply(ies) on comments received from CAG of India 2', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_cag VALUES (3, 2, 'Provide details of comment(s) or supplement(s) received from CAG of India 3', 'Board of Director''s reply(ies) on comments received from CAG of India 3', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_cag VALUES (4, 3, 'Provide details of comment(s) or supplement(s) received from CAG of India 1', 'Board of Director''s reply(ies) on comments received from CAG of India 1', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_cag VALUES (5, 3, 'Provide details of comment(s) or supplement(s) received from CAG of India 2', 'Board of Director''s reply(ies) on comments received from CAG of India 2', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_cag VALUES (6, 3, 'Provide details of comment(s) or supplement(s) received from CAG of India 3', 'Board of Director''s reply(ies) on comments received from CAG of India 3', NULL, NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 6067 (class 0 OID 221877)
-- Dependencies: 368
-- Data for Name: tbl_capital; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_capital VALUES (2, 2, -1, '2025-03-06 18:16:29.702407', -1, '2025-03-06 18:16:29.70241', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Issued', '2025-03-07 00:00:00', NULL, 3999, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (1, 2, -1, '2025-03-05 23:12:58.537333', -1, '2025-03-08 15:45:54.937103', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Authorized', '2025-03-06 00:00:00', 5, 1015, 'No', '2025-03-07 00:00:00', '14:15', '30/09/2022', 'Rakshit Dilip Savla', 'EGM', 'No', '2025-03-08 00:00:00', '16:17', '30/09/2024', '30/09/2023', 'No');
INSERT INTO public.tbl_capital VALUES (3, 2, -1, '2025-03-08 16:18:55.001675', -1, '2025-03-08 16:18:55.001678', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Authorized', '2025-03-13 00:00:00', 10000, 30000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (5, 2, -1, '2025-03-08 16:25:26.125507', -1, '2025-03-08 16:25:26.12551', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Issued', NULL, NULL, 20000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (6, 2, -1, '2025-03-08 16:26:08.274505', -1, '2025-03-08 16:27:17.275449', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Issued', '2025-03-21 00:00:00', NULL, 20000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (7, 2, -1, '2025-03-08 16:28:18.623809', -1, '2025-03-08 16:28:18.623813', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Subscribed', '2025-03-20 00:00:00', NULL, 20000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (8, 2, -1, '2025-03-08 16:28:48.988247', -1, '2025-03-08 16:28:48.988249', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Subscribed', '2025-03-14 00:00:00', NULL, 20000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (4, 2, -1, '2025-03-08 16:20:53.584861', -1, '2025-03-08 16:35:14.759109', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Authorized', '2025-03-14 00:00:00', 0, 20000, NULL, NULL, NULL, '', '', NULL, NULL, NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_capital VALUES (9, 2, -1, '2025-04-04 14:44:57.61395', -1, '2025-04-04 14:44:57.613951', NULL, NULL, true, NULL, NULL, NULL, NULL, 'Authorized', NULL, NULL, 0, 'No', '2025-04-03 00:00:00', '11:00', '30/09/2024', 'Mokshank Dilipbhai Savla', 'EGM', 'Yes', NULL, NULL, '', '', 'Yes');


--
-- TOC entry 6069 (class 0 OID 221891)
-- Dependencies: 370
-- Data for Name: tbl_capital_child; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_capital_child VALUES (2, 1, 'e', 20, 20, 400, 'Speed post', 'By Hand', '', '2025-03-05 23:32:13.914925');
INSERT INTO public.tbl_capital_child VALUES (15, 5, 'e', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (4, 1, 'p', 2, 2, 4, 'Speed post', 'By Hand', '', '2025-03-05 23:32:13.950701');
INSERT INTO public.tbl_capital_child VALUES (16, 5, 'p', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (17, 6, 'e', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (18, 6, 'p', 1000, 10, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (19, 7, 'e', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (20, 7, 'p', 1000, 10, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (21, 8, 'e', 10, 1000, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (22, 8, 'p', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (13, 4, 'e', 1000, 10, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (14, 4, 'p', 1000, 10, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (23, 9, 'e', 1, NULL, 0, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (24, 9, 'p', NULL, NULL, 0, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (7, 2, 'e', 9, 9, 81, 'By Hand', '', 'With Voting Rights', NULL);
INSERT INTO public.tbl_capital_child VALUES (8, 2, 'e', 8, 8, 64, 'Speed post', '', 'With Differential Voting Rights', NULL);
INSERT INTO public.tbl_capital_child VALUES (9, 2, 'p', 90, 90, 810, 'Speed post', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (10, 2, 'p', 80, 80, 640, 'By Hand', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (1, 1, 'e', 10, 10, 100, 'By Hand', 'Speed post', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (5, 1, 'e', 30, 30, 900, 'Speed post', 'By Hand', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (3, 1, 'p', 1, 1, 1, 'By Hand', 'Speed post', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (6, 1, 'p', 3, 3, 9, 'Speed post', 'By Hand', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (11, 3, 'e', 100, 100, 10000, '', '', '', NULL);
INSERT INTO public.tbl_capital_child VALUES (12, 3, 'p', 100, 100, 10000, '', '', '', NULL);


--
-- TOC entry 6091 (class 0 OID 223284)
-- Dependencies: 402
-- Data for Name: tbl_charge; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_charge VALUES (1, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Charge', 'kurla', 'Creation of charge', '', 'N', 'N', true, 'If others, please specify', 'N', 'vijay', 'N', 12, 'N', 'CEO', 'If others, please specify', 'DHANLAXMI BANK LIMITED', '1234567890', 'vijay', 'kurla', 'mannat apartment', 'Austria', '400070', '', 'Mumbai', 'Mumbai', 'Maharashtra', '', 'kurla', 'lbs233', 'N', '234689', 'Nature or description of instrument(s) creating or modifying the charge', '2025-02-26 00:00:00', NULL, '2025-02-25 00:00:00', '2025-02-25 00:00:00', 'N', '2025-03-04 00:00:00', '12312213', '', '', '2025-03-04 00:00:00', '123132434654756', '2', '21', '2', '21', '2025-03-04 00:00:00', '12232', '121232', '12', '12312', '2025-02-25 00:00:00', '2025-02-26 00:00:00', '1234567890', '12312312', '213123', '123123', 'Dwelling Interest', '12312', '123123', '123123', '', '1231', '123', 'mannat', '2134', '21312', '400070', '213', 'kurla', '', 'Select Locality', 'Mumbai', 'Maharashtra', 12, 123, '234', '', '213', '123', '12123', '213', 'N', '213123', '123123', '', '2025-03-05 00:00:00', '1231', '07356321', '', '434343', '54523432', 'BANDRA HOSPITALITY LLP', 'Company Secretary in whole time practice', '439', 'Fellow', '21312312312', '', '', '', '2025-03-12 16:51:51.729266', -1, -1, '2025-03-12 16:51:51.729273', true, NULL);


--
-- TOC entry 6111 (class 0 OID 230257)
-- Dependencies: 431
-- Data for Name: tbl_chg1; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_chg1 VALUES (1, 2, -1, '2025-03-22 10:56:52.960789', -1, '2025-04-04 21:24:58.880903', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'pakshal.shah2003@gmail.com', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'modification', '12345', 'chargeholder', '2025-03-08 00:00:00', 'Yes', 'Nature, description and brief particulars of the instrument creating or modifying the charge', true, false, false, false, false, false, false, false, false, false, false, false, false, false, NULL, false, false, false, false, false, false, false, true, true, 'yes', 'vijay', 'Yes', '12', 'no3', 'Co-operative bank', 'DENA BANK', '1234567890', 'vijay saroj', 'lbs marg', 'mannat apartment', 'India', '400070', 'Select Locality', 'mumbai', 'Kurla', 'Maharashtra', 'vijaysaroj34@gmail.com', '123456789', 'true', '12345678', '2113', 3123123, '2025-03-22 00:00:00', '23123123', '21', 12, '211321', '21312', '2025-03-04 00:00:00', '123123', '3123', '3123', '3123', '2025-03-04', 'Description of the instrument creating or evidencing the charge', '2025-03-13 00:00:00', '213213123', 3212, '3123', '23123', '21312312', 'Yes', '23123123', '312312312', '23123123', true, '1234567890', '2025-03-04 00:00:00', true, 'IRP', '1234567890', true, true, '123123', '21321312312', 'Cost accountant (in whole-time practice)', '', 'Associate', '', '12312312312');


--
-- TOC entry 6131 (class 0 OID 230633)
-- Dependencies: 454
-- Data for Name: tbl_chg4; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_chg4 VALUES (1, 2, -1, '2025-04-02 15:29:24.623709', -1, '2025-04-02 15:29:24.623713', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2025-04-21 00:00:00', '12345', 'pakshal.shah2003@gmail.com', 'no', '', 'on', 'Chargeholder', 'unsatisfied', 'vijay saroj', 'U72900KA23PTC654321', 'vijay saroj', 'vijaysaroj4527@gmail.com', 'lbs marg', '2025-04-13 00:00:00', '2025-04-07 00:00:00', 20000, '15000', 'wdqwd', true, '1234567890', '2025-04-09 00:00:00', true, 'IRP', '1234567890', true, true, '', '21321312312', 'manager', '12345', 'vijaysaroj4527@gmail.com', '1234', 'Company secretary (in whole-time practice)', 'Fellow', '265', '', '', '');


--
-- TOC entry 5989 (class 0 OID 180571)
-- Dependencies: 256
-- Data for Name: tbl_chg6; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_chg6 VALUES (2, 2, -1, '2024-12-24 22:03:17.803308', -1, '2024-12-24 22:03:17.803312', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, '', '', '', '', '', NULL, 'Select Locality', '', '', '', NULL, NULL, '', '');
INSERT INTO public.tbl_chg6 VALUES (3, 4, -1, '2025-03-10 16:56:13.026533', -1, '2025-03-10 16:56:13.026535', NULL, NULL, true, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, NULL, '', '', '', '', '', NULL, 'Select Locality', '', '', '', NULL, NULL, '', '');
INSERT INTO public.tbl_chg6 VALUES (1, 2, -1, '2024-12-24 16:01:49.910835', -1, '2025-03-22 13:39:58.087683', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'person_appointing_receiver_or_manager', 'cessation', ' Income tax permanent account number (PAN)', 'Name', 'Address of receiver or manager Line 1', 'Address Line 2', 'Argentina ', 434242, 'Select Locality', 'City', 'District', 'State', '2024-12-24 00:00:00', 'orderOfCourt', '5', 'PAN of the receiver or manager');


--
-- TOC entry 5991 (class 0 OID 180592)
-- Dependencies: 259
-- Data for Name: tbl_chg8; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_chg8 VALUES (2, 2, -1, '2024-12-24 18:30:22.810197', -1, '2024-12-24 18:30:22.810199', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, NULL, NULL, '', '', NULL, '', '', '', '', '', '', NULL, '', '');
INSERT INTO public.tbl_chg8 VALUES (3, 2, -1, '2024-12-24 18:32:44.476621', -1, '2024-12-24 18:33:19.704283', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'delayInRegistration', 'modificationOfCharge', 'company', 'chg4', 'SRN of the form selected above', '6. Charge Identification Number(ID)', '2024-12-24 00:00:00', '7. (b) Amount of charge created / modified / satisfied:', '7. (c) Name(s) of the charge holder(s)', '7.(d) Particulars of the property or asset(s) charged (including complete address and location of the property)', '8. Reasons for delay/ omission/ mis-statement in filing and details of omission / mis-statement and the relief required', 'Dec name', 'resolution no', '2024-12-19 00:00:00', 'Manager', 'MAnager');
INSERT INTO public.tbl_chg8 VALUES (1, 2, -1, '2024-12-24 18:30:03.668548', -1, '2025-01-11 18:43:08.733757', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'rectificationOmission', 'satisfactionOfCharge', 'otherPerson', 'chg9', '', '', NULL, '', '', '', '', '', '', NULL, '', '');


--
-- TOC entry 5993 (class 0 OID 180619)
-- Dependencies: 262
-- Data for Name: tbl_chg9; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_chg9 VALUES (2, 2, -1, '2024-12-24 20:09:50.3891', -1, '2024-12-24 20:09:50.389162', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, '', NULL, '', '', '', '', '', '', '', NULL, NULL);
INSERT INTO public.tbl_chg9 VALUES (1, 2, -1, '2024-12-24 20:03:19.861057', -1, '2025-03-24 16:50:41.05669', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'modificationOfCharge', 'chargeholderOrTrustee', 'resolution no', '2024-12-24 00:00:00', 'Manager', 'MAnager', 'panChargeHolder', 'PAN of ARC/Assignee', 'Designation', 'PAN', 'fqwfqw@gmwfowfw.com', 'Cost accountant (in whole-time practice)', 'Fellow');


--
-- TOC entry 5959 (class 0 OID 162989)
-- Dependencies: 218
-- Data for Name: tbl_company; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company VALUES (3, 'CAPTABLE SOLUTIONS PRIVATE LIMITED', 'U63999MH2024PTC435028', '2024-11-20 19:25:23.10486', '2024-11-19 00:00:00', '9769279733', 'compycrafter@gmail.com', 'Shop No 5 Shiv Krupa CHS Old Nagardas Rd Andheri E Nagardas Road Mumbai Mumbai MH 400069 IN', 'Company', 'AAICP9297R', '', 'https://dev.complycrafter.com/Home/Company/Add/3', -1, '2024-11-20 19:25:23.111082', -1, '2025-04-11 16:31:24.081181', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (12, 'AKSHAY GRAPHICS PRIVATE LIMITED', 'U22219MH2022PTC375586', '2025-04-11 17:13:05.878836', '2022-01-28 00:00:00', NULL, 'AKSHAyGraphics69@gmail.com', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-11 17:13:05.903746', -1, '2025-04-11 17:13:05.903747', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (14, 'PICKPA SERVICES PRIVATE LIMITED', 'U93000MH2019PTC332581', '2025-04-11 17:33:46.984045', '2019-11-05 00:00:00', NULL, 'contact@pickpa.com', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-11 17:33:46.998665', -1, '2025-04-11 17:33:46.998667', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (13, 'MICROHIND NETWORKS AND TECHNOLOGIES PRIVATE LIMITED', 'U74999MH2020PTC352765', '2025-04-11 17:31:10.500244', '2020-12-30 00:00:00', NULL, 'contact@microhind.com', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-11 17:31:10.522192', -1, '2025-04-11 17:31:10.522194', '2025-04-12 11:51:40.447824', NULL, true);
INSERT INTO public.tbl_company VALUES (6, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', 'U45203MH2021OPC368682', '2024-12-05 11:59:47.034837', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', 'SHOP NO.12, SURYA HOUSE,C.T.S. NO.-464/A KIROL, RD NO.7, VIDYAVIHAR EAST ,KURLA MUMBAI Mumbai City MH 400077 IN', 'Private(One Person Company)', NULL, NULL, NULL, -1, '2024-12-05 11:59:47.034869', -1, '2024-12-05 11:59:47.034869', '2025-04-07 13:58:05.527769', NULL, true);
INSERT INTO public.tbl_company VALUES (5, 'RELIANCE INDUSTRIES LIMITED', 'L17110MH1973PLC019786', '2024-12-05 11:58:10.130396', '1973-05-08 00:00:00', NULL, 'savithri.parekh@ril.com', '3 RD FLOORMAKER CHAMBER IV 222 NARIMAN POINT NA MUMBAI MH 400021 IN', 'Public', NULL, NULL, NULL, -1, '2024-12-05 11:58:10.138411', -1, '2024-12-05 11:58:10.138413', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (4, 'KHATRI DYEING PRIVATE LIMITED', 'U24299MH2001PTC133129', '2024-11-26 16:16:21.096632', '2001-08-23 00:00:00', '9820072649', 'msekhatri@gmail.com', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'Private', '', '', 'https://khatrigroup.com', -1, '2024-11-26 16:16:21.112659', -1, '2024-11-26 16:16:55.620565', '2025-04-07 13:58:09.476813', NULL, true);
INSERT INTO public.tbl_company VALUES (7, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', NULL, '2025-04-07 14:01:32.645607', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-07 14:01:32.713011', -1, '2025-04-07 14:01:32.713017', '2025-04-07 14:41:37.924169', NULL, true);
INSERT INTO public.tbl_company VALUES (8, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', 'U45203MH2021OPC368682', '2025-04-07 14:45:21.228336', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-07 14:45:21.255362', -1, '2025-04-07 14:45:21.255364', '2025-04-07 14:49:44.489267', NULL, true);
INSERT INTO public.tbl_company VALUES (9, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', 'U45203MH2021OPC368682', '2025-04-07 14:51:09.233104', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-07 14:51:27.91166', -1, '2025-04-07 14:51:27.911662', '2025-04-07 14:53:32.127337', NULL, true);
INSERT INTO public.tbl_company VALUES (10, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', 'U45203MH2021OPC368682', '2025-04-07 14:54:25.909695', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-07 14:54:25.928797', -1, '2025-04-07 14:54:25.928798', '2025-04-07 15:04:12.541341', NULL, true);
INSERT INTO public.tbl_company VALUES (15, 'MICROHIND NETWORKS AND TECHNOLOGIES PRIVATE LIMITED', 'U74999MH2020PTC352765', '2025-04-12 11:53:46.81933', '2020-12-30 00:00:00', NULL, 'contact@microhind.com', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-12 11:53:46.852227', -1, '2025-04-12 12:17:56.466107', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (11, 'SAPTRANG INFRASTRUCTURE (OPC) PRIVATE LIMITED', 'U45203MH2021OPC368682', '2025-04-07 15:05:13.629028', '2021-10-01 00:00:00', NULL, 'SPKSTAR4U@GMAIL.COM', NULL, 'Company', NULL, NULL, NULL, -1, '2025-04-07 15:05:13.643097', -1, '2025-04-07 15:05:13.643099', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (1, 'NITYANIKAR VENTURES PRIVATE LIMITED', 'U15209MH2024PTC429590', '2024-11-19 17:41:20.316742', '2024-07-27 00:00:00', NULL, 'contact@nityanikar.com', 'Vikas Apt, Flat-5, Janki Kutir, Vile Parle W Juhu Mumbai Mumbai MH 400049 IN', 'Company', NULL, NULL, NULL, -1, '2024-11-19 17:41:20.323438', -1, '2025-04-08 14:35:33.741133', NULL, NULL, true);
INSERT INTO public.tbl_company VALUES (2, 'PRIYA EXPRESS PRIVATE LIMITED', 'U74999MH2017PTC289529', '2024-11-19 21:18:06.260967', '2017-01-13 00:00:00', '9999999991', 'pakshal.shah2003@gmail.com', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'Company', '', '', 'https://mintingminds.com', -1, '2024-11-19 21:18:06.267145', -1, '2025-04-12 14:44:37.737083', NULL, NULL, true);


--
-- TOC entry 5963 (class 0 OID 163007)
-- Dependencies: 222
-- Data for Name: tbl_company_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_details VALUES (15, 15, 500000, 100000, 'Private', 352765, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (4, 4, 20000000, 10150000, 'Private', 133129, 'Company limited by Shares', 'Non-govt company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'RoC-Mumbai', '', '', '', '');
INSERT INTO public.tbl_company_details VALUES (5, 5, 500000000000, 135323728980, 'Public', 19786, 'Company limited by Shares', 'Non-govt company', '2024-03-31 00:00:00', '2024-08-29 00:00:00', 'Listed', 'RoC-Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (6, 6, 100000, 10000, 'Private(One Person Company)', 368682, 'Company limited by Shares', 'Non-govt company', '2024-03-31 00:00:00', '1800-01-01 00:00:00', 'Unlisted', 'RoC-Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (2, 2, 100000, 100000, 'Private', 289529, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'ROC Mumbai', '', '', '', '');
INSERT INTO public.tbl_company_details VALUES (7, 7, 100000, 10000, 'One Person Company', 368682, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (8, 8, 100000, 10000, 'One Person Company', 368682, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (9, 9, 100000, 10000, 'One Person Company', 368682, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (10, 10, 100000, 10000, 'One Person Company', 368682, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (11, 11, 100000, 10000, 'One Person Company', 368682, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (1, 1, 1500000, 1500000, 'Private', 429590, 'Company limited by shares', 'Non-government company', NULL, NULL, 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (3, 3, 1500000, 125600, 'Private', 435028, 'Company limited by shares', 'Non-government company', NULL, NULL, 'Unlisted', 'ROC Mumbai', '', '', '', '');
INSERT INTO public.tbl_company_details VALUES (12, 12, 1000000, 1000000, 'Private', 375586, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (13, 13, 500000, 100000, 'Private', 352765, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_details VALUES (14, 14, 100000, 100000, 'Private', 332581, 'Company limited by shares', 'Non-government company', '2024-03-31 00:00:00', '2024-09-30 00:00:00', 'Unlisted', 'ROC Mumbai', NULL, NULL, NULL, NULL);


--
-- TOC entry 6137 (class 0 OID 230818)
-- Dependencies: 463
-- Data for Name: tbl_company_director; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_director VALUES (0, 9, 2010, NULL, NULL);
INSERT INTO public.tbl_company_director VALUES (1, 10, 9, '2021-10-01', NULL);
INSERT INTO public.tbl_company_director VALUES (2, 10, 10, '2021-10-01', NULL);
INSERT INTO public.tbl_company_director VALUES (3, 11, 9, '2021-10-01', '2025-04-07 15:05:14.629974');
INSERT INTO public.tbl_company_director VALUES (4, 11, 10, '2021-10-01', '2025-04-07 15:05:14.629974');
INSERT INTO public.tbl_company_director VALUES (5, 1, 11, '2024-07-27', '2025-04-08 14:35:35.127392');
INSERT INTO public.tbl_company_director VALUES (6, 1, 2, '2024-07-27', '2025-04-08 14:35:35.127392');
INSERT INTO public.tbl_company_director VALUES (7, 1, 11, '2024-09-04', '2025-04-08 14:35:35.127392');
INSERT INTO public.tbl_company_director VALUES (10, 3, 14, '2025-04-07', '2025-04-11 16:31:25.533547');
INSERT INTO public.tbl_company_director VALUES (11, 3, 7, '2024-11-19', '2025-04-11 16:31:25.533547');
INSERT INTO public.tbl_company_director VALUES (12, 3, 8, '2024-11-19', '2025-04-11 16:31:25.533547');
INSERT INTO public.tbl_company_director VALUES (13, 12, 16, '2022-01-28', '2025-04-11 17:13:05.930618');
INSERT INTO public.tbl_company_director VALUES (14, 12, 17, '2022-01-28', '2025-04-11 17:13:05.930618');
INSERT INTO public.tbl_company_director VALUES (15, 13, 18, '2020-12-30', '2025-04-11 17:31:10.539909');
INSERT INTO public.tbl_company_director VALUES (16, 13, 8, '2020-12-30', '2025-04-11 17:31:10.539909');
INSERT INTO public.tbl_company_director VALUES (17, 13, 8, '2023-01-30', '2025-04-11 17:31:10.539909');
INSERT INTO public.tbl_company_director VALUES (18, 13, 18, '2025-02-07', '2025-04-11 17:31:10.539909');
INSERT INTO public.tbl_company_director VALUES (19, 13, 19, '2025-02-07', '2025-04-11 17:31:10.539909');
INSERT INTO public.tbl_company_director VALUES (20, 14, 18, '2019-11-05', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (21, 14, 8, '2019-11-05', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (22, 14, 20, '2019-11-05', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (23, 14, 8, '2023-01-30', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (24, 14, 21, '2025-04-07', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (25, 14, 22, '2025-04-07', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (26, 14, 18, '2025-02-07', '2025-04-11 17:33:47.00535');
INSERT INTO public.tbl_company_director VALUES (47, 15, 18, '2020-12-30', '2025-04-12 12:17:55.229961');
INSERT INTO public.tbl_company_director VALUES (48, 15, 8, '2020-12-30', '2025-04-12 12:17:55.229961');
INSERT INTO public.tbl_company_director VALUES (49, 15, 8, '2023-01-30', '2025-04-12 12:17:55.229961');
INSERT INTO public.tbl_company_director VALUES (50, 15, 18, '2025-02-07', '2025-04-12 12:17:55.229961');
INSERT INTO public.tbl_company_director VALUES (51, 15, 19, '2025-02-07', '2025-04-12 12:17:55.229961');
INSERT INTO public.tbl_company_director VALUES (58, 2, 15, '2017-01-13', '2025-04-12 14:44:36.499915');
INSERT INTO public.tbl_company_director VALUES (59, 2, 7, '2017-01-13', '2025-04-12 14:44:36.499915');


--
-- TOC entry 5965 (class 0 OID 163016)
-- Dependencies: 224
-- Data for Name: tbl_company_financial_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_financial_details VALUES (4, 4, '', NULL, NULL, '', '', '', NULL, NULL, '', NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (5, 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (6, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (7, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (8, 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (9, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (10, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (11, 11, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (3, 3, '', NULL, NULL, '', '', '', NULL, NULL, '', NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (12, 12, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (13, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (14, 14, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (15, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_financial_details VALUES (2, 2, '', NULL, NULL, '', '', '', NULL, NULL, '', NULL, NULL);


--
-- TOC entry 6149 (class 0 OID 231969)
-- Dependencies: 478
-- Data for Name: tbl_company_ioc; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_ioc VALUES (2, 2, 'R33472655', '100205551', 'The Saraswat Co-operative Bank Limited', 'Open', 'Others', 1500000, '2018-08-31', '2020-02-13', 'Saraswat Bank Bhavan, 953 Appasaheb Marathe Marg,', 'Prabhadevi,   Mumbai Maharashtra India - 400025');


--
-- TOC entry 6021 (class 0 OID 196515)
-- Dependencies: 302
-- Data for Name: tbl_company_notice; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_notice VALUES (1, 2, -1, '2025-01-13 12:18:01.365962', -1, '2025-01-15 18:15:39.106057', NULL, true, '2025-01-13 00:00:00', '2025-01-13 00:00:00', 'AGM', '[{"resolutionId":"1","Existing_Address":"Existing Address","New_Address":"New Address"}]');
INSERT INTO public.tbl_company_notice VALUES (2, 2, -1, '2025-01-13 16:32:53.158961', -1, '2025-01-16 16:58:21.034811', NULL, true, '2025-01-15 00:00:00', '2025-01-08 00:00:00', 'SGM', '[{"resolutionId":"4","Name_of_Appointee":"Name of Appointee","his/her":"his/her","he/she":"he/she"},{"resolutionId":"2","Existing_Address":"Existing Address 123","New_Address":"New Address"}]');


--
-- TOC entry 5967 (class 0 OID 163025)
-- Dependencies: 226
-- Data for Name: tbl_company_other_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_other_details VALUES (4, 4, '', '', '', '', '', '', '');
INSERT INTO public.tbl_company_other_details VALUES (5, 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (6, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (7, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (8, 8, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (9, 9, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (10, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (11, 11, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (3, 3, 'MUMP37680G', 'SDVASDG', 'ASDFDAGAGD', 'ASDF', 'AAICP9297R', 'ASDFA', 'ADSADS');
INSERT INTO public.tbl_company_other_details VALUES (12, 12, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (13, 13, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (14, 14, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (15, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_company_other_details VALUES (2, 2, '', '', '', '', '', '', '');


--
-- TOC entry 6123 (class 0 OID 230536)
-- Dependencies: 446
-- Data for Name: tbl_company_otp; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_company_otp VALUES (1, 3, 1, '6526', '2025-04-02 12:46:20.831079', false, '9769279733', false);
INSERT INTO public.tbl_company_otp VALUES (2, 3, 1, '9733', '2025-04-02 12:50:31.434642', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (4, 3, 1, '9733', '2025-04-02 13:11:47.505307', false, '9769279733', false);
INSERT INTO public.tbl_company_otp VALUES (3, 3, 1, '9733', '2025-04-02 13:08:00.614043', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (5, 3, 1, '279733', '2025-04-02 13:13:54.010299', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (6, 3, 1, '279733', '2025-04-02 13:29:41.747238', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (7, 3, 1, '279733', '2025-04-02 13:32:11.72198', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (8, 3, 1, '279733', '2025-04-02 13:32:55.425583', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (9, 3, 1, '279733', '2025-04-02 13:34:01.665461', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (10, 3, 1, '279733', '2025-04-02 13:41:41.829629', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (11, 3, 1, '279733', '2025-04-02 14:09:46.461504', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (12, 3, 1, '6033', '2025-04-02 20:23:29.030367', false, '9769279733', false);
INSERT INTO public.tbl_company_otp VALUES (13, 3, 1, '1347', '2025-04-02 20:25:27.061464', false, '9769279733', false);
INSERT INTO public.tbl_company_otp VALUES (14, 3, 1, '279733', '2025-04-02 20:26:32.198299', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (15, 3, 1, '279733', '2025-04-02 20:32:53.699988', false, '9769279733', true);
INSERT INTO public.tbl_company_otp VALUES (16, 3, 1, '279733', '2025-04-02 20:33:21.441491', false, '9769279733', true);


--
-- TOC entry 5976 (class 0 OID 180080)
-- Dependencies: 237
-- Data for Name: tbl_debenture; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_debenture VALUES ('Shareholder', 'string', 'string', 'Foreign', 'Non Institutions', 'Minor', NULL, NULL, 'Female', 'pan', '2024-11-25', 'stringemail@gmail.com', '9000000434', 'Unmarried', 'gaurdian', 'CIN/LLPIN', '2024-11-27', -1, '2024-11-27 17:49:05.117994', -1, '2024-12-09 22:01:48.428458', NULL, 0, true, 'Shareholder', 1, 2, 'Mr', 'passport');
INSERT INTO public.tbl_debenture VALUES ('Shareholder', 'string', 'string', 'Indian', 'Institutions', 'Government Company', NULL, 1, 'Female', 'pan', '2024-11-25', 'stringemail@gmail.com', '9000000434', 'Unmarried', 'gaurdian', 'CIN/LLPIN', '2024-11-27', -1, '2024-11-25 19:12:25.179142', -1, '2025-04-04 15:35:58.97097', NULL, 0, true, 'None', 1, 1, 'Mr', 'passport');


--
-- TOC entry 5977 (class 0 OID 180087)
-- Dependencies: 238
-- Data for Name: tbl_debenture_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_debenture_details VALUES (2, 'Address Line 1', 'Mumbai', 'Mahrashtra', 'India', 'Mumbai', 'Father', 'Mother', 'nationality', 'Voter', 'Aadhar', 'Occupation', 'Spouse', '', '', 2);
INSERT INTO public.tbl_debenture_details VALUES (1, 'Address Line 1', 'Mumbai', 'Mahrashtra', 'India', 'Mumbai', 'Father', 'Mother', 'nationality', 'Voter', 'Aadhar', 'Occupation', 'Spouse', '', '', 1);


--
-- TOC entry 6005 (class 0 OID 180818)
-- Dependencies: 280
-- Data for Name: tbl_dir11; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir11 VALUES (1, 2, -1, '2025-01-07 13:15:26.294047', -1, '2025-01-07 13:19:52.701017', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 1, 'Farhan  Director M Kazi', 'IN', NULL, 'Director', 'Professional', '2025-01-16 00:00:00', '2025-01-17 00:00:00', 'Other', '5(b) Details (applicable in case "Other" is selected)', 'No', 'Farhan  Director M Kazi', '2637872');


--
-- TOC entry 6007 (class 0 OID 180847)
-- Dependencies: 283
-- Data for Name: tbl_dir12; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir12 VALUES (1, 2, -1, '2025-01-07 15:58:14.040311', -1, '2025-01-07 16:00:18.821139', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 2, 2, '6. SRN of form INC-28', 'Company Secretary', 'qwdqwdqd', 'qQWDQWD', 'DFEFDDDEEF', '2025-01-18 00:00:00', 'costAccountant', '265', 'fellow', 'QWDQWDQ');
INSERT INTO public.tbl_dir12 VALUES (2, 2, -1, '2025-02-06 12:43:35.894759', -1, '2025-02-06 12:43:35.895267', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 1, NULL, '', '', '', '', '', NULL, NULL, '', NULL, '');


--
-- TOC entry 5997 (class 0 OID 180724)
-- Dependencies: 268
-- Data for Name: tbl_dir3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir3 VALUES (1, 2, -1, '2025-01-03 11:49:17.465685', -1, '2025-03-25 13:06:00.842978', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', 'no', '', 'First Name', 'Middle Name', '*Last Name', 'F First Name', 'f Middle Name', 'f *Last Name', 'Aruba', 'yes', 'Professional', 'Master degree', '2025-01-03 00:00:00', 'male', '43f34r134f34', '', 'no', '32352523523', '', '234412412412', '', '1241411e1', '', 'r3223d23d2', '', 'Address Line 1', 'Address Line 2', 'Australia', '400070', 'Area/Locality', 'City', 'District', '', '*Jurisdiction of Police Station', '7718949544', 'dqdqwdqd', 'qdwq@dqwdq.qwd', 'yes', '', '', 'Afghanistan', '', '', '', '', '', '', '121121421421', '*Address Line 1', 'name ', ' son/daughte', '2025-01-03 00:00:00', 'wqdqwdqwd', 'required', 'Manager', 'manager', NULL);


--
-- TOC entry 5999 (class 0 OID 180739)
-- Dependencies: 271
-- Data for Name: tbl_dir5; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir5 VALUES (1, 2, -1, '2025-01-03 18:52:25.062945', -1, '2025-03-26 15:42:08.751113', NULL, NULL, true, NULL, NULL, NULL, NULL, 'death', 'no', '(b) Mention the DIN to be retained', 'First anem', 'middle ', 'last ', 'f nam', 'f Middle Name', 'f *Last Name', '2025-01-03 00:00:00', 'dwefwe32', 32, 'no', 'effewf32', 'dfwef', 'wefwef23', 'companySecretary', '265', 'associate', '23f2fq');


--
-- TOC entry 6001 (class 0 OID 180766)
-- Dependencies: 274
-- Data for Name: tbl_dir6; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir6 VALUES (1, 2, -1, '2025-01-04 12:46:35.84073', -1, '2025-01-04 12:54:11.527136', NULL, NULL, true, '09475141', 'Mokshank Dilipbhai Savla', '', 'yes', '(a) *First Name', '(a) *First Name', '(a) *First Name', 'Father''s Name ', 'Father''s Name ', 'Father''s Name ', 'Armenia', 'yes', NULL, 'male', ' Income tax permanent account number (PAN)', '', '32352523523', '', '234412412412', '', '1241411e1', '', 'r3223d23d2', '', '*Address Line 1', '*Address Line 1', 'Australia', '*Address Line 1', '*Address Line 1', '*Address Line 1', '*Address Line 1', '*Address Line 1', '*Address Line 1', '*Address Line 1', '*Address Line 1', 'yes', 'Present Residential Address', 'Present Residential Address', 'Australia', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'Present Residential Address', 'companySecretary', '265', 'fellow', '23f2fq');


--
-- TOC entry 6003 (class 0 OID 180804)
-- Dependencies: 277
-- Data for Name: tbl_dir9; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dir9 VALUES (1, 2, -1, '2025-01-07 11:47:04.761042', -1, '2025-01-07 12:03:27.247028', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'yes', '164(1)', 3, true, '2025-01-17 00:00:00', '2026-01-17 00:00:00', true, '2025-01-07 00:00:00', '2026-01-07 00:00:00', true, '2025-01-18 00:00:00', '2026-01-18 00:00:00', false, '2025-01-23 00:00:00', '2026-01-23 00:00:00', false, '2025-01-10 00:00:00', '2026-01-10 00:00:00', '2025-01-18 00:00:00', 'Manager', 'Signatory', 'DIN / PAN');


--
-- TOC entry 5961 (class 0 OID 162998)
-- Dependencies: 220
-- Data for Name: tbl_director; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_director VALUES (2, 'ANJALI', 'CHATURVEDI', '.', '06750200', '*****1858R', '*******081', '*****0224060', '', NULL, '', 'Filed', -1, '2024-11-26 17:46:02.160249', -1, '2025-04-05 17:07:46.940554', NULL, NULL, true, '2024-11-26 17:45:50.56597', NULL, '');
INSERT INTO public.tbl_director VALUES (5, 'KIRAN', 'PREMCHAND', 'SHAH', '07693548', NULL, '*******282', NULL, '*****p@dtdc.com', NULL, NULL, NULL, 0, NULL, 0, NULL, '2025-04-05 17:29:14.702697', NULL, false, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (6, 'SIDDHARTH', 'RAVI PRAKASH', 'SINGH', '07900169', NULL, '*******663', NULL, '*****siddharth92.ss@gmail.com', NULL, NULL, NULL, 0, NULL, 0, NULL, '2025-04-05 17:29:17.187066', NULL, false, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (1, 'Farhan ', 'Director M', 'Kazi', '2637872', 'string', '8787878987', 'string', 'farhan@gmail.com', '2024-10-30 00:00:00', 'string', 'string', 1, '2024-10-30 17:33:55.586061', -1, '2025-04-05 21:27:42.821924', NULL, 1, true, '2024-11-25 19:06:49.831453', NULL, 'Mr');
INSERT INTO public.tbl_director VALUES (9, 'DEEN', '', 'DAYAL', '', NULL, '*******174', NULL, '*****NG130@GMAIL.COM', NULL, NULL, NULL, 0, '2025-04-07 14:01:32.655961', 0, '2025-04-07 14:01:32.655963', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (10, 'SHITALAPRASAD', 'ORIRAM', 'KORI', '09343689', NULL, '*******764', NULL, '*****ar4u@gmail.com', NULL, NULL, NULL, 0, '2025-04-07 14:01:32.696865', 0, '2025-04-07 14:01:32.696867', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (11, 'NIRBHAY', 'CHATURVEDI', 'NANDKISHORE', '06750234', NULL, '*******080', NULL, '*****ay23@hotmail.com', NULL, NULL, NULL, -1, '2025-04-08 14:35:33.708215', -1, '2025-04-08 14:35:33.708218', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (12, 'AJIT', '', 'VISHWAKARMA', NULL, '*****6975J', '*******297', '*****4476752', NULL, NULL, NULL, 'Filed', -1, '2025-04-08 15:08:36.935002', -1, '2025-04-08 15:08:36.935008', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (14, 'AJIT', 'MUNNALAL', 'VISHWAKARMA', '08072027', '*****5382P', '8879577879', '*****9753792', '', NULL, '', 'Filed', -1, '2025-04-09 12:02:54.343796', -1, '2025-04-09 12:03:37.945993', NULL, NULL, true, NULL, NULL, '');
INSERT INTO public.tbl_director VALUES (13, 'AJIT', '', 'VISHWAKARMA', '08437392', '*****6975J', '*******297', '*****4476752', NULL, NULL, NULL, 'Filed', -1, '2025-04-08 15:17:25.722089', -1, '2025-04-11 16:42:37.764828', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (16, 'MOKSHANK', 'DILIPBHAI', 'SAVLA', '09475141', NULL, '*******533', NULL, '*****mokshank@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:13:05.881509', 0, '2025-04-11 17:13:05.88151', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (17, 'RAKSHIT', 'DILIP', 'SAVLA', '09473752', NULL, '*******090', NULL, '*****.rakshit95@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:13:05.897781', 0, '2025-04-11 17:13:05.897783', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (20, 'SHREY', 'JAYANTI', 'VELANI', '07241017', NULL, '*******690', NULL, '*****velani@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:33:46.986092', 0, '2025-04-11 17:33:46.986093', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (21, 'RANJIT', 'BABASAHEB', 'SURVE', '08460970', NULL, '*******255', NULL, '*****anjit@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:33:46.993149', 0, '2025-04-11 17:33:46.993149', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (22, 'KIRAN', 'RANJIT', 'SURVE', '08460971', NULL, '*******016', NULL, '*****ve90@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:33:46.995476', 0, '2025-04-11 17:33:46.995478', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (8, 'SIDDHARTH', 'RAVI PRAKASH', 'SINGH', '07900169', NULL, '*******663', NULL, '*****SIDDHARTH92.SS@GMAIL.COM', NULL, NULL, NULL, -1, '2025-04-05 17:30:31.611799', -1, '2025-04-12 12:17:56.422934', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (19, 'AFSAR ALI', 'AKBAR ALI', 'KHAN', '10911329', NULL, '*******212', NULL, '*****saralikhan@gmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:31:10.512558', -1, '2025-04-12 12:17:56.456621', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (18, 'AKHTAR ALI', 'AKBAR ALI', 'KHAN', '08578833', NULL, '*******221', NULL, '*****r_alikhan@hotmail.com', NULL, NULL, NULL, 0, '2025-04-11 17:21:28.362491', -1, '2025-04-12 12:18:42.35953', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (4, 'string', NULL, NULL, 'wefwef', NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-05 13:17:58.631063', -1, '2024-12-05 13:17:58.631085', '2024-12-05 15:23:36.671318', NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-05 13:14:54.293247', -1, '2024-12-05 13:14:54.293279', '2025-01-07 13:16:40.098762', NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (15, 'PAKSHAL', 'KIRAN', 'SHAH', '07691455', NULL, '*******733', NULL, '*****al.shah2003@gmail.com', NULL, NULL, NULL, -1, '2025-04-09 14:55:19.897495', -1, '2025-04-12 14:44:37.692742', NULL, NULL, true, NULL, NULL, NULL);
INSERT INTO public.tbl_director VALUES (7, 'KIRAN', 'PREMCHAND', 'SHAH', '07693548', NULL, '*******282', NULL, '*****p@dtdc.com', NULL, NULL, NULL, -1, '2025-04-05 17:30:31.577888', -1, '2025-04-12 14:44:37.72396', NULL, NULL, true, NULL, NULL, NULL);


--
-- TOC entry 5969 (class 0 OID 163034)
-- Dependencies: 228
-- Data for Name: tbl_director_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_director_details VALUES (3, 3, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (4, 4, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (2, 2, '', '', '', '', 0, 'OMPRAKASH CHATURVEDI ', '1984-09-21 00:00:00', 'House Wife', 'Female', 'India', 'Resident', 'Married', 'MBA', '', '', NULL, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (5, 5, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (6, 6, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (1, 1, 'string', 'string', 'string', 'string', 0, 'string', '2024-10-30 00:00:00', 'string', 'Male', 'IN', 'Resident', 'Unmarried', 'string', 'string', 'string', '2024-10-30 00:00:00', 'string', 'string', 'https://fama.b-cdn.net/ComplyCrafter/dev/Director/1_20241114145537_fk.jpg', 'https://fama.b-cdn.net/ComplyCrafter/dev/Director/1_20241114151301_fk.jpg', 'https://fama.b-cdn.net/ComplyCrafter/dev/Director/1_20241114150313_fk sign.jpg', 'https://fama.b-cdn.net/ComplyCrafter/dev/Director/1_20241114151200_fk sign.jpg', 'https://fama.b-cdn.net/ComplyCrafter/dev/Director/1_20241114145555_Minting Minds HR Policies.pdf');
INSERT INTO public.tbl_director_details VALUES (9, 9, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (10, 10, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (11, 11, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (12, 12, NULL, NULL, NULL, NULL, 0, NULL, NULL, 'Business', 'Male', 'India', 'Resident', NULL, 'PGDM', NULL, '*****6576069', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (14, 14, '', '', '', '', 0, NULL, NULL, '', 'Male', 'India', 'Resident', 'Married', '', '', '', NULL, '', '', NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (13, 13, NULL, NULL, NULL, NULL, 0, NULL, NULL, 'Business', 'Male', 'India', 'Resident', NULL, 'PGDM', NULL, '*****6576069', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (16, 16, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (17, 17, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (20, 20, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (21, 21, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (22, 22, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (8, 8, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (19, 19, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (18, 18, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (15, 15, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_director_details VALUES (7, 7, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 6121 (class 0 OID 230465)
-- Dependencies: 444
-- Data for Name: tbl_dms; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dms VALUES (1, 0, -1, '2025-03-28 15:52:57.991283', -1, '2025-03-28 15:52:57.991286', NULL, NULL, true, '', 'ADJ', '2025-03-28', 2024, 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/1/form_original/20250328155259.pdf', '', 'C:\fakepath\mca-soma.pdf', '');
INSERT INTO public.tbl_dms VALUES (2, 1, -1, '2025-03-28 15:54:19.374679', -1, '2025-03-28 15:54:19.374682', NULL, NULL, true, '', 'ADJ', '2025-03-28', 2024, 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/2/form_original/20250328155420.pdf', '', 'C:\fakepath\mca-soma.pdf', '');
INSERT INTO public.tbl_dms VALUES (3, 1, -1, '2025-04-02 13:35:08.968778', -1, '2025-04-02 13:35:08.968782', NULL, NULL, true, '', 'ADJ', '2025-05-01', 2025, 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/3/form_original/20250402133510.pdf', '', 'C:\fakepath\mca-soma.pdf', '');
INSERT INTO public.tbl_dms VALUES (4, 3, -1, '2025-04-02 13:35:41.096228', -1, '2025-04-02 13:35:41.09623', NULL, NULL, true, '', 'ADJ', '2025-05-01', 2025, 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/4/form_original/20250402134840.pdf', 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/4/form_client/20250402202946.pdf', 'C:\fakepath\mca-soma.pdf', 'https://fama.b-cdn.net/ComplyCrafter/dev/DMS/4/challan_client/20250402203028.pdf');


--
-- TOC entry 5995 (class 0 OID 180710)
-- Dependencies: 265
-- Data for Name: tbl_dpt3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dpt3 VALUES (1, 2, -1, '2025-01-02 15:38:00.41531', -1, '2025-01-11 18:46:38.976248', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Private', 'Return of Deposit', 'true', ' Objects of the company', 'no', '2025-01-02 00:00:00', '2025-01-02 00:00:00', '2025-01-02 00:00:00', 1000, 1000, 1000, 100, 100, 100, 100, 100, 2500, 875, 1, 20, 30, 40, -2, 2, 3, 4, 5, 6, 7, 8, 9, 1, 5, 5, 14, 515, 'From (Name of the agency)', ' Rating', '2025-01-23 00:00:00', 'SRN of GNL form in which DPT-1 is filed', 'Name', 'Chartered Accountant', 'Membership Number/ Certificate of Practice Numbe', 'resolution no.', '2025-01-17 00:00:00', 'Company Secretary', 'DIN of the director; PAN of the manager or CEO or CFO or IRP/RP/Liquidator or Authorised representative; or membership number of company secretary');


--
-- TOC entry 5987 (class 0 OID 180439)
-- Dependencies: 253
-- Data for Name: tbl_dpt4; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_dpt4 VALUES (1, 1, 'U15209MH2024PTC429590', 'NITYANIKAR VENTURES PRIVATE LIMITED', 'Vikas Apt, Flat-5, Janki Kutir, Vile Parle W Juhu Mumbai Mumbai MH 400049 IN', 'contact@nityanikar.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-16 18:55:51.105277', -1, '2024-12-16 18:55:51.105376', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (2, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-17 11:30:31.393447', -1, '2024-12-17 11:30:31.393468', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (3, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Private', 'true', '', '', '', '', '', '', '', '', '', -1, '2024-12-17 11:31:54.81437', -1, '2024-12-17 12:46:26.846965', NULL, NULL, true, '', NULL);
INSERT INTO public.tbl_dpt4 VALUES (4, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-18 12:38:05.602648', -1, '2024-12-18 12:38:05.602715', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (5, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-18 16:34:28.889425', -1, '2024-12-18 16:34:28.889502', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (6, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-18 18:06:50.314719', -1, '2024-12-18 18:06:50.314748', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (7, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Private', 'true', 'ASASAS', 'ASASAS', 'ASA', 'ASAS', 'ASAS', 'ASSS', 'ASA', 'AASSA', 'AASA', -1, '2024-12-18 18:06:57.797211', -1, '2024-12-19 12:04:57.377607', NULL, NULL, true, '', NULL);
INSERT INTO public.tbl_dpt4 VALUES (8, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, -1, '2024-12-19 16:18:13.027075', -1, '2024-12-19 16:18:13.027077', NULL, NULL, true, NULL, NULL);
INSERT INTO public.tbl_dpt4 VALUES (9, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, '', '', '', '', '', '', '', '', '', -1, '2024-12-24 22:10:36.85793', -1, '2024-12-24 22:10:36.857949', NULL, NULL, true, '', NULL);
INSERT INTO public.tbl_dpt4 VALUES (10, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, NULL, '', '', '', '', '', '', '', '', '', -1, '2024-12-24 22:11:03.913212', -1, '2024-12-24 22:11:03.913214', NULL, NULL, true, '', NULL);
INSERT INTO public.tbl_dpt4 VALUES (11, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Private', NULL, '500000', '100000', '', '', '', '', '', '', '', -1, '2025-01-11 18:48:12.828092', -1, '2025-01-11 18:48:12.828094', NULL, NULL, true, '', NULL);


--
-- TOC entry 6083 (class 0 OID 222782)
-- Dependencies: 390
-- Data for Name: tbl_form11; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form11 VALUES (8, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', '2025-03-12 00:00:00', '2025-03-20 00:00:00', '2025-03-20 00:00:00', NULL, 'asdfnhhhas', 'fgjssdsdf', 'Service', 'sadfj', 'sxfghj', 'azsxdcfvgh', 'wvndddsf', 'asdfghj', '', '', 'sxdcfvgbhnjmk', NULL, 'fdfghjk', 'sdfas', 'asdf', 'asdfg', 'sdfg', 'asdfg', 'sdfg', 'sadfgh', 'asdf', 'asfdg', 'fdgfcg', 'asdfg', 'asdfg', 'asdfgn', 'xcvn', 'asdf', 'asdfg', 'wertyn', 'asdfgh', 'asdfg', 'asdfgh', 'asdfg', 'asdfh', 'xcvas', 'zsxdcfg', 'zxercvtyb', ' zwxecv', 'wecvb', 'wzxerctvy', 'awse', 'excvgbh', 'asdfg', 'adfghjk', 'zxcvb', 'zxcvbnm', 'asdfg', '', 'sdtg', 'zxcv', NULL, 'zxcvb', 'asdfg', 'zxcv', 'asdfhjk', 'asdfg', 'sdfghjk', NULL, 'N', '', 'AMARJEET KARNAIL SINGH GADHRI', 'Interim Resolution', '123456789', false, '', true, '234567', '123456', NULL, '2025-03-11 14:53:35.362735', -1, -1, '2025-03-12 13:14:38.590236', true, NULL);


--
-- TOC entry 6087 (class 0 OID 222879)
-- Dependencies: 396
-- Data for Name: tbl_form12; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form12 VALUES (1, NULL, 4, 'U24299MH2001PTC133129', '', '', 'msekhatri@gmail.com', 'dz', 'dsadas', 'dasd', 'dsadasasd', 'Bahrain', 'sadd', '', 'dasdasd', 'asdasdasd', 'adsasd', 'dsadasd', 'dasdas', 'dsadsa', 'dasd', 'dasd', 'With consent of all partners', 'dasdasd', 'sadsad', '2025-03-27 00:00:00', true, true, '07727600', 'sdfgjhkl;', 'ddzczcx', 'Chartered Accountant in whole time practice', '439', 'Associate', 32342, '', '', '', '', '2025-03-11 16:39:57.163727', -1, -1, '2025-03-11 16:39:57.163731', true, NULL);


--
-- TOC entry 6089 (class 0 OID 223159)
-- Dependencies: 399
-- Data for Name: tbl_form15; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form15 VALUES (3, NULL, 4, 'U24299MH2001PTC133129', '', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', '', 'Bandra West', NULL, '', '', '', '', NULL, '', '', '', '', '', '', NULL, 1, '', '', '', '', '', NULL, '', NULL, NULL, '', '', '', NULL, NULL, '', '', NULL, NULL, true, false, true, '', 'BANDRA HOSPITALITY LLP', 'Company Secretary in whole time practice', '', 'Fellow', '1', '', '', '', '', '', '2025-03-12 14:33:13.536931', -1, -1, '2025-03-12 14:33:13.536935', true, NULL);


--
-- TOC entry 6097 (class 0 OID 223439)
-- Dependencies: 411
-- Data for Name: tbl_form22; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form22 VALUES (1, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Bandra West', 'Central Government', '12', 'Mumbai', 'gfdg', 'fdgfdg', 'dfgdfg', '2025-04-03', 'LLP Act 2008', 'For amalgamated / inactive LLP / FLLP to Active', '33-Order of Liquidation', 'gfdgf', 'fdgdgdfg', 'gfdgdf', '2025-03-28 00:00:00', '2025-03-27 00:00:00', '2025-03-08', 'gfdg', 'dgdg', 'dgdfgfd', 'gdfgdg', 'gdgdfgdf', 'Y', 'dfgfdgf', 'gfdg', 'dfgdfgdfgd', 'dfgdgfd', '', 'gfd', 'gdgfd', 'gdgfg', 'gfdgd', 'gfdg', '', 'gdf', 'gdfg', 'fdgdg', '', true, true, 'Authorised Representative', 'fsdfds', '07727600', 'aAa', 'a', '2025-03-13 17:09:18.010267', -1, -1, '2025-03-13 17:49:05.546655', true, NULL);


--
-- TOC entry 6093 (class 0 OID 223311)
-- Dependencies: 405
-- Data for Name: tbl_form23; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form23 VALUES (1, NULL, 0, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, 'mannat apartment', 'India', '400050', '', 'MUMBAI', 'Mumbai City', 'Maharashtra', 'Maharashtra', '1234567890', '8070807040', '123456', 'company', 'company@gmail.com', 'lbs marg', 'noen', true, false, true, 'Managing Director', '', '123456789', '', '', '2025-03-12 18:06:19.880944', -1, -1, '2025-03-12 18:06:19.880948', true, NULL);
INSERT INTO public.tbl_form23 VALUES (2, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, 'mannat apartment', 'India', '400070', '', 'MUMBAI', 'Mumbai City', 'Maharashtra', 'kurla', '1234567890', '8070807040', '1234567890', 'none', 'alphadigitall123@gmail.com', 'mannat apartment , kurla west mumbai -400070', 'none', false, false, false, 'Director', '', '1234567890', '', '', '2025-03-13 11:14:26.403072', -1, -1, '2025-03-13 12:09:39.228873', true, NULL);
INSERT INTO public.tbl_form23 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', NULL, 'mannat apartment', 'India', '400050', '', 'MUMBAI', 'Mumbai City', 'Maharashtra', 'kurla', '1234567890', '8070807040', '1234567890', 'alpha', 'alphadigitall@gmail.com', 'gokul pawar chawl buddha colony', 'none', true, false, true, 'Designated Partner', '', '1234567890', '', '', '2025-03-13 15:25:02.614629', -1, -1, '2025-03-13 15:26:00.669612', true, NULL);


--
-- TOC entry 6095 (class 0 OID 223415)
-- Dependencies: 408
-- Data for Name: tbl_form24; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form24 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Reasons for making the application', 'false', 'No', '2025-02-26 00:00:00', 'N', 'alpha', '2025-03-04 00:00:00', 'N', 123, '2025-02-27 00:00:00', 21312400000000, 343435000, 6546550000, 6546460000, 4645650000, 4564560000, 445646000, 645646000, 45643500, 34533500, 34534500, 344334, 1234240000, 4354570000, 5464560000, 456546000, 546456000, 4564560000012, 4645650000, 45345300, 3434530000, 34534500, 3434340000, 'vijay saroj', 'kurla', 'Chartered Accountant', '0987654321', '07727600', '1234567890', false, true, true, '', '', '', '', '', '', '', '2025-03-13 15:52:04.182959', -1, -1, '2025-03-19 14:07:44.77377', true, NULL);


--
-- TOC entry 6071 (class 0 OID 221981)
-- Dependencies: 372
-- Data for Name: tbl_form3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form3 VALUES (1, NULL, 4, '', '', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Filing information with regard to initial LLP Agreement', 32424, 'BANDRA HOSPITALITY LLP', 'sadasd', 'Goa', NULL, '43234', '', 'sdadads', 'dasdd', 'asdad', 'dasda', 'dasda', 'daasd', 'dasda', 'dasd', 'asdasd', 'asdasd', 'dasd', 'dasda', 'sdas', 'dasdad', 'asdads', 'adsd', 'dsadd', NULL, 'dasda', 'dsasd', '2025-03-25 00:00:00', 342423, 'true', 'sasd', 'true', 'true', 'true', 'true', 'true', 'dasdasd', NULL, 'sdasdad', 'adsadsa', '', 'dasd', 'dasd', 'dasd', 'dasd', 'asdsd', 'dasdad', 'Y', '', '', 4242, '234', '234', '423', 432, 234, 423, '3424', 'sadasd', 'dasdasd', 'dad', 'ada', 'asdd', 'adsad', 'ads', 'dasdas', 'dasdasd', 'asdasd', 'sdadadsad', 'dssadasd', 'adasd', 'dasdasd', 'daasd', 'asdasd', 'asddas', 'dsaasd', '', 'dasd', '', '', '', '', '', NULL, '', NULL, '', '', NULL, '2025-03-06 18:00:35.414061', -1, -1, '2025-03-06 18:00:35.414064', true, NULL);
INSERT INTO public.tbl_form3 VALUES (2, NULL, 4, '', '', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Filing information with regard to initial LLP Agreement', 11, 'BANDRA HOSPITALITY LLP', 'ans', 'Dadra and Nagar Haveli', NULL, '321', '', 'sada', 'xZxZX', 'xzXZX', 'xZX', 'xZxx', 'ZXZXdsad', 'dsd', 'sdds', 'dssdsd', 'fsdfsdf', 'sdsdf', 'fsdfsfd', 'fdsfsfd', 'fsdfdsf', 'fsdffsd', 'fsdfds', 'dfsdfsd', NULL, 'sfdfsdf', 'sdfsdsd', '2025-03-20 00:00:00', 43242, 'true', 'fsdf', 'true', 'true', 'true', 'true', 'true', 'fsdfsf', NULL, 'sfsfsdf', 'fsdfsdf', '', 'sdfsfdd', 'fsdfsdf', 'sdfsfs', 'sdfdsf', 'fdsfsdf', 'fsdfsfd', 'Y', '', '', 4324, '0324', '042323', '432', 434, 434, 344, '434', 'gddf', 'gdfgdg', 'dfgdfg', 'dgdfg', 'dgdg', 'dfgdg', 'gdfdfg', 'gdgdg', 'dgdgd', 'gdgdg', 'gdfgd', 'gdgdgf', 'gdgdg', 'dgdgd', 'gdgdg', 'gdgdg', 'etr', 'gdgreter', '', 'werwerfd', '', '', '', '', '', NULL, '', NULL, '', '', NULL, '2025-03-07 12:25:24.517944', -1, -1, '2025-03-07 12:25:24.517947', true, NULL);


--
-- TOC entry 6055 (class 0 OID 221522)
-- Dependencies: 350
-- Data for Name: tbl_form4; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form4 VALUES (1, 4, -1, '2025-03-01 19:30:58.034977', -1, '2025-03-02 12:20:32.030754', NULL, NULL, true, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 1, 1, 1, 1, 4, '07727600', '1', 'Company Secretary', '265', 'Fellow', '1');
INSERT INTO public.tbl_form4 VALUES (2, 4, -1, '2025-03-06 14:59:21.331775', -1, '2025-03-06 14:59:21.331998', NULL, NULL, true, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', NULL, NULL, NULL, NULL, NULL, '', '', NULL, '', NULL, '');


--
-- TOC entry 6075 (class 0 OID 222128)
-- Dependencies: 378
-- Data for Name: tbl_form5; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_form5 VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2025-03-07 15:11:43.578856', -1, -1, '2025-03-07 15:11:43.57886', true, NULL);
INSERT INTO public.tbl_form5 VALUES (2, NULL, 4, '', '', '', 'msekhatri@gmail.com', 'AAN-1801', 'BANDRA HOSPITALITY LLP', '32123', '', 'Bandra West', 'Y', 'dsad', true, true, true, true, 'dsad', 'sadd', '2025-03-11', false, false, '07356321', 'sdadasd', 'Chartered Accountant (in whole-time practice)', '265', 'Fellow', 'dasda', '', '', '', '', '', '', 'dsadas', '2025-03-07 15:13:25.798413', -1, -1, '2025-03-07 15:13:25.798435', true, NULL);


--
-- TOC entry 6105 (class 0 OID 223824)
-- Dependencies: 423
-- Data for Name: tbl_gnl1; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_gnl1 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Company', '', 'vijay saroj', 'lbs marg', 'mannat apartment', 'mumbai', 'Maharashtra', '91', '', 400070, 'vijaysaroj4527@gmail.com', 'Compounding of offences', ' If Others, then specify', 'Details of application', true, true, false, false, 1234, 'Suo-motu', 12133, '22342', 'Brief particulars as to how the default has been made good', '2025-02-25 00:00:00', '12345678', '2025-03-06 00:00:00', '2025-04-03 00:00:00', 12312, false, '12345678', '2025-03-03 00:00:00', true, 'Managing Director', '', '0987654321', 'Company secretary (in whole-time practice)', '265', 'Fellow', 987654321, '1234567890', '2025-03-18 12:52:42.098209', -1, -1, '2025-03-19 13:46:34.530416', true, NULL);


--
-- TOC entry 6041 (class 0 OID 221121)
-- Dependencies: 328
-- Data for Name: tbl_gnl2; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_gnl2 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '15', NULL, NULL, NULL, 'If others, then specify', 'Companies Act, 2013', 'Section 8', 1234567890, '2025-02-16', '2025-02-01', NULL, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'CEO', '2025-02-10 00:00:00', '', '27', '0987654321', '2025-02-19 18:43:15.297437', -1, -1, '2025-02-19 18:43:33.414804', true, NULL);


--
-- TOC entry 6043 (class 0 OID 221162)
-- Dependencies: 331
-- Data for Name: tbl_gnl3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_gnl3 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 12, NULL, '2025-02-14 00:00:00', '2025-02-13 00:00:00', '', '', 'assadas', '2025-02-10 00:00:00', false, '12346789', 'Manager', '0987654321', 'Company secretary (in whole-time practice)', NULL, '265', 'Associate', 987654321, '2025-02-20 15:27:17.225642', -1, -1, '2025-02-20 16:00:14.993614', true, NULL);


--
-- TOC entry 6085 (class 0 OID 222811)
-- Dependencies: 393
-- Data for Name: tbl_iepf2; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_iepf2 VALUES (1, NULL, 0, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Statement of unclaimed and unpaid amounts', 'Appointment', NULL, '1223323', '', 'vijay ', 'ramesh', 'saroj', 'ramesh', '', 'saroj', '2025-03-05 00:00:00', '12345', 'employee', 'male', 'buddha colony', 'kurla', '', '400070', '', 'Mumbai', 'Mumbai', 'Maharashtra', '1234567890', '8976216167', 'vijaysaroj4527@gmail.com', '2025-02-25 00:00:00', 23, 52, 43, '2025-02-27 00:00:00', '2025-02-24 00:00:00', 'Y', 34, 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 12, 12, '', '', '', '1234567890', '2025-02-25 00:00:00', '', '', '', '2025-03-11 16:31:54.871738', -1, -1, '2025-03-11 16:31:54.871741', true, NULL);
INSERT INTO public.tbl_iepf2 VALUES (2, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Statement of unclaimed and unpaid amounts', 'Appointment', NULL, '123324', '', 'vijay ', 'ramesh', 'saroj', 'ramesh', 'harilal', 'saroj', '2000-07-02 00:00:00', '12345', 'CEO', 'male', 'buddha colony', 'kurla', '', '400070', '', 'Mumbai', 'Mumbai', 'Maharashtra', '1234567890', '8976216167', 'vijaysaroj4527@gmail.com', '2025-02-26 00:00:00', 1221, 121, 320, '2025-02-26 00:00:00', '2025-02-24 00:00:00', 'Y', 23234, 232120, 1, 2, 3, 4, 5, 6, 7, 28, 8, 9, 10, 11, 12, 13, 14, 77, 15, 16, 17, 18, 19, 20, 21, 126, 22, 23, 24, 25, 26, 27, 0, 147, 28, 29, 30, 31, 32, 33, 35, 218, 35, 36, 37, 38, 39, 40, 41, 266, 42, 43, 44, 45, 46, 47, 48, 315, 49, 50, 51, 52, 53, 54, 55, 364, 56, 56, 57, 58, 59, 60, 61, 407, '', '', '', '', '', '', '', '0', 62, 63, 64, 65, 66, 67, 68, 455, 69, 70, 72, 73, 74, 75, 76, 509, 77, 78, 79, 80, 81, 82, 83, 560, 84, 85, 86, 87, 88, 89, 90, 609, 91, 92, 93, 94, 95, 96, 97, 658, 98, 99, 100, 101, 102, 103, 104, 707, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1231, 123, '', '', '', '1234567890', '2025-02-26 00:00:00', '', '', '', '2025-03-11 16:35:43.874214', -1, -1, '2025-03-11 16:58:26.153346', true, NULL);


--
-- TOC entry 6073 (class 0 OID 222047)
-- Dependencies: 374
-- Data for Name: tbl_iepf5; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_iepf5 VALUES (1, NULL, 2, 'Entity', '', '', '', '', '', '', NULL, 'Company', '123456789', 'alpha', '2025-03-07 00:00:00', 'kurla', '08070807040', '', NULL, 'vijaysaroj4527@gmail.com', '', '123456789098', '', '123456786543', '', '1234567876', '876543234565432', '', '', '', 'Y', 'sadas', 'asdasd', '67', '', '', '', '', '', NULL, '12', '21', '123456789765432', 'bob', '6543', 'kurla', '1234567890', '', '', '', '', false, '2025-03-06 18:25:44.638028', -1, -1, '2025-03-06 18:25:44.638031', true, NULL);
INSERT INTO public.tbl_iepf5 VALUES (2, NULL, 2, 'Individual', 'vijay', 'ramesh', 'saroj', 'vijay', 'harilal', 'saroj', '2025-03-08 00:00:00', '', '', '', NULL, 'kurla', '08070807044', '', NULL, 'vijaysaroj45@gmail.com', '', '123456789', '', '123456789', '', '', '', '', '', '', NULL, '', '', '', '', '', '', '', '', NULL, '', '', '', '', '', '', '', '', '', '', '', false, '2025-03-06 18:27:38.026749', -1, -1, '2025-03-06 18:27:38.026753', true, NULL);
INSERT INTO public.tbl_iepf5 VALUES (3, NULL, 2, 'Individual', 'vijay', 'ramesh', 'saroj', 'ramesh', 'harilal', 'saroj', '2000-07-02 00:00:00', '', '', '', NULL, 'kurla', '08070807044', '', NULL, 'vijaysaroj45@gmail.com', '', '1234567890', '', '23455343', '', '232dsfds', '2345678890987654', '', '', '', 'Y', 'vijay', 'self', '98', '', '', '', '', '', 'Amount', '12', '21', '123456789098765432', 'bob', '6543', 'kurla', '1234567890', '', '', '', '', true, '2025-03-07 10:37:38.212168', -1, -1, '2025-03-07 10:37:38.212172', true, NULL);


--
-- TOC entry 6081 (class 0 OID 222491)
-- Dependencies: 387
-- Data for Name: tbl_inc12; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc12 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'private', 'model', 'model', 'Yes', '1000', '22219', 'Description of the main division', '', 'Description of the main division of industrial activity of the company being proposed to be pursued after the proposed conversion', 'Grounds on which application is made', '', '', '', '', 'alpha', '123456789000', '2025-02-26 00:00:00', 'alpha', '1234567890', '12345678', true, true, false, true, true, 'Chartered Accountant (in whole-time practice)', 'Associate', 'Manager', '265', '1234567890', 'Managing director', '1234567890', 'vijay', 'alphadigitall', 'Whole-time director', '9876543210', 'alpha', 'alphadigitall', '1234567', 'N', NULL, 'Year 1', '1', '2', '', 'Remarks (Source of Income, Objects of Expenditure)', 'Year 2', '3', '4', '', 'Remarks (Source of Income, Objects of Expenditure)', 'Year 3', '5', '6', '', 'Remarks (Source of Income, Objects of Expenditure)', 'General Meeting', '2025-02-27 00:00:00', '*Mode of Resolution', '223', '1234', '12345678', '2025-03-10 15:04:42.187495', -1, -1, '2025-03-10 15:05:35.391186', true, NULL);


--
-- TOC entry 6023 (class 0 OID 196619)
-- Dependencies: 305
-- Data for Name: tbl_inc20a; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc20a VALUES (1, 2, -1, '2025-01-17 16:19:46.68752', -1, '2025-01-17 16:23:35.587773', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 212.21321321, 0.32432423, 'Y', 'RBI', '', 'adwqdq', '2025-01-07 00:00:00', 212, 21, '2025-01-07 00:00:00', NULL, 'SASX', 'charteredAccountant', '265', 'associate', 'xAX');


--
-- TOC entry 6009 (class 0 OID 180947)
-- Dependencies: 286
-- Data for Name: tbl_inc22; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc22 VALUES (1, 2, -1, '2025-01-08 12:57:07.250526', -1, '2025-01-08 12:58:02.357733', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Change outside the local limit of city, town or village', '2025-01-21 00:00:00', 'Address Line 1', 'Address Line 2', 'Aruba', '400070', 'Area/Locality', 'City', 'District', 'State', '323223', '32.23234234', 'name', 'desig', 'Manager', 'resoluiton no', '2025-01-22 00:00:00', '09473752', 'ein', 'costAccountant', '265', 'fellow', 'QWDQWDQ');


--
-- TOC entry 6077 (class 0 OID 222347)
-- Dependencies: 381
-- Data for Name: tbl_inc23; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc23 VALUES (1, 4, -1, '2025-03-08 16:13:36.026018', -1, '2025-03-08 16:19:53.166663', NULL, NULL, true, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Change in State within the jurisdiction of existing ROC', 'Y', '123456789098765', 'Maharashtra', '', 'Reasons for shifting the Registered Office, along with facts of the case (provide a conclse statement of facts in a chronological order, each paragraph containing as nearly as possible a separate issue, fact or otherwise.)', 'objectionNotRecieved', '2025-02-26 00:00:00', '2025-02-25 00:00:00', ' Brief details of the objections received in response to the advertisement', 'Pending', 'give brief details of the prosecution', true, true, true, ' give brief details of the inquiry, inspection, investigation', 'N', '2025-02-26 00:00:00', 'false', 'specify the details of such pending application', '', '', '', '031234543', '12/06/2024', false, false, false, false, false, true, false, 'Manager', 'alphadigitall', '123456787654');
INSERT INTO public.tbl_inc23 VALUES (2, 2, -1, '2025-03-09 11:06:42.085047', -1, '2025-03-10 15:19:02.332846', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Change in State within the jurisdiction of existing ROC', 'N', '1234567890987654', 'Andhra Pradhesh', '', 'shifting the Registered Office, along with facts of the case (provide a conclse statement of facts in a chronological order, each paragraph containing as nearly as possible a separate issue, fact or otherwise.)', 'objectionNotRecieved', '2025-02-27 00:00:00', '2025-02-26 00:00:00', 'details of the objections received in response to the advertisement', 'Pending', 'give brief details of the prosecution', true, true, false, 'give brief details of the inquiry, inspection, investigation', 'N', '2025-02-26 00:00:00', 'true', 'specify the details of such pending application', '', '', '', '123456789000', '12/06/2024', true, true, true, true, true, true, true, 'Company Secretary', 'alphadigitall', '1234567890987');


--
-- TOC entry 6025 (class 0 OID 196716)
-- Dependencies: 308
-- Data for Name: tbl_inc28; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc28 VALUES (2, 2, -1, '2025-02-01 11:54:01.189139', -1, '2025-02-01 11:54:01.189161', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '', '', '', '', '', '', '', '', NULL, '', '', NULL, NULL, NULL, '', NULL, '', '', NULL, '', NULL, '');


--
-- TOC entry 6099 (class 0 OID 223588)
-- Dependencies: 414
-- Data for Name: tbl_inc4; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_inc4 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Notice of withdrawal of consent by the nominee of OPC', 'alphadigitall', 'vijay', '2025-02-26 00:00:00', 'vijay', 'AKSHAY GRAPHICS PRIVATE LIMITED', 'vijay', 'ramesh', 'saroj', '2025-02-26 00:00:00', 'mumbai', 'vijay', 'AKSHAY GRAPHICS PRIVATE LIMITED', '2025-02-25 00:00:00', 'Change in ownership', 'vijay', 'ramesg', 'saroj', 'his/her nominee', 'vijay', 'member', 'AKSHAY GRAPHICS PRIVATE LIMITED', 'vijay', 'ramesh', 'saroj', NULL, '1234567890', 'vijay', 'ramesh', 'saroj', 'ramesh', NULL, 'saroj', '', '2025-03-06 00:00:00', '', '1234567890', 'Maharashtra', '', 'Teaching', 'Primary education', 'lbs marg', 'mannat apartment', 'India', '400070', '', '', '', '', '08070807044', '08070807044', '1234567890', 'vijaysaroj34@gmail.com', 'N', 'lbs marg', 'mannat apartment', 'India', '400070', '', '', '', '', '2', '4', 'Driving License', '1234567890', '', 'Mobile bill', '1345', '', 'vijay', 'AKSHAY GRAPHICS PRIVATE LIMITED', 'none', '', '123456789098765', 'Manager', 'alphadigitall', '0987654321', '2025-03-17 11:16:03.6873', -1, -1, '2025-03-17 13:08:21.68129', true, NULL);


--
-- TOC entry 6147 (class 0 OID 231956)
-- Dependencies: 476
-- Data for Name: tbl_litigation; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_litigation VALUES (2, 2, '321', 'alphadigitall', '654321', 'fraud', NULL, NULL, NULL, NULL, NULL, '2025-04-12 13:33:56.107183');
INSERT INTO public.tbl_litigation VALUES (3, 2, '12312312', 'alphadigitall', '1231231', 'fraud', NULL, NULL, NULL, NULL, NULL, '2025-04-12 13:38:10.057981');
INSERT INTO public.tbl_litigation VALUES (1, 2, '1235', 'alpha', '123456', 'fraud', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_litigation VALUES (4, 2, '12355', 'alphadigitall', '123456', 'fraud', NULL, NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 6035 (class 0 OID 204781)
-- Dependencies: 320
-- Data for Name: tbl_meeting; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_meeting VALUES (2, 2, -1, '2025-03-01 16:31:19.520926', -1, '2025-03-01 16:32:26.44146', NULL, NULL, true, 'bm', '23', 2321, 'Yes', '2025-02-14 00:00:00', '2025-02-13 00:00:00', '21:30', '21:30', 342, '08578833', 'wefewf', 'Physical', 'Yes', 'dvsv', 'dvsdvs', 'Female', '2025-02-18 00:00:00', '323442', 'csd@ff.dd', '2025-02-21 00:00:00', 'vsdvsdv', 'vsdvs', 'dsvds', 'dvsdv', '3353', '09473752', 'fwvwevw', '2025-02-15', 'ewefwef', '2025-02-21 00:00:00', '21:31', 'wewe@sdfd.vds', 'Yes', 'Yes', 'Yes', 'EGM', '16974', '8117', '2025-02-28 00:00:00', '21:29', NULL, 'fewf', '09475141', '09473752', '08578833', '', '08578833', 'elected', 'Member', '14:29', '2025-02-19 00:00:00', 'dvsd', '2025-02-14 00:00:00', 'wevwe', '2025-02-01 00:00:00', 'Applicable', 'fwefwef', 'Yes', 'Yes', 'Yes', '', '', '', '', '', '', '', '');
INSERT INTO public.tbl_meeting VALUES (3, 2, -1, '2025-03-01 16:32:44.756514', -1, '2025-03-01 16:32:44.756515', NULL, NULL, true, 'bm', '23', 2321, 'Yes', '2025-02-14 00:00:00', '2025-02-13 00:00:00', '21:30', '21:30', 342, '08578833', 'wefewf', 'Physical', 'Yes', 'dvsv', 'dvsdvs', 'Female', '2025-02-18 00:00:00', '323442', 'csd@ff.dd', '2025-02-21 00:00:00', 'vsdvsdv', 'vsdvs', 'dsvds', 'dvsdv', '3353', '09473752', 'fwvwevw', '2025-02-15', 'ewefwef', '2025-02-21 00:00:00', '21:31', 'wewe@sdfd.vds', 'Yes', 'Yes', 'Yes', 'EGM', '16974', '8117', '2025-02-28 00:00:00', '21:29', NULL, 'fewf', '09475141', '09473752', '08578833', '', '08578833', 'elected', 'Member', '14:29', '2025-02-19 00:00:00', 'dvsd', '2025-02-14 00:00:00', 'wevwe', '2025-02-01 00:00:00', 'Applicable', 'fwefwef', 'Yes', 'Yes', 'Yes', '', '', '', '', '', '', '', '');
INSERT INTO public.tbl_meeting VALUES (4, 2, -1, '2025-03-01 16:32:58.036384', -1, '2025-03-01 16:32:58.036386', NULL, NULL, true, 'bm', '23', 2321, 'Yes', '2025-02-14 00:00:00', '2025-02-13 00:00:00', '21:30', '21:30', 342, '08578833', 'wefewf', 'Physical', 'Yes', 'dvsv', 'dvsdvs', 'Female', '2025-02-18 00:00:00', '323442', 'csd@ff.dd', '2025-02-21 00:00:00', 'vsdvsdv', 'vsdvs', 'dsvds', 'dvsdv', '3353', '09473752', 'fwvwevw', '2025-02-15', 'ewefwef', '2025-02-21 00:00:00', '21:31', 'wewe@sdfd.vds', 'Yes', 'Yes', 'Yes', 'EGM', '16974', '8117', '2025-02-28 00:00:00', '21:29', NULL, 'fewf', '09475141', '09473752', '08578833', '', '08578833', 'elected', 'Member', '14:29', '2025-02-19 00:00:00', 'dvsd', '2025-02-14 00:00:00', 'wevwe', '2025-02-01 00:00:00', 'Applicable', 'fwefwef', 'Yes', 'Yes', 'Yes', '', '', '', '', '', '', '', '');
INSERT INTO public.tbl_meeting VALUES (5, 2, -1, '2025-03-15 17:50:34.281008', -1, '2025-03-15 17:50:34.281086', NULL, NULL, true, 'bm', '', NULL, NULL, '2025-03-01 00:00:00', '2025-03-13 00:00:00', '17:00', '17:00', 1, '08578833', 'Mumbai', 'Physical', 'Yes', '', '', '', NULL, '', '', NULL, '', '', '', '', '', '', '', NULL, '', NULL, NULL, '', 'No', 'No', 'Yes', 'EGM', '', '8117', NULL, NULL, NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, '', NULL, '', NULL, 'Applicable', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_meeting VALUES (6, 2, -1, '2025-04-04 14:46:20.658894', -1, '2025-04-04 14:47:00.587514', NULL, NULL, true, 'bm', '', NULL, NULL, '2025-04-01 00:00:00', '2025-04-03 00:00:00', '11:00', '11:00', 1, '08578833', 'Mumbai', 'Physical', 'Yes', '', '', '', NULL, '', '', NULL, '', '', '', '', '', '', '', NULL, '', NULL, NULL, '', 'No', 'No', 'Yes', 'EGM', '', '8117', NULL, NULL, NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, '', NULL, '', NULL, 'Applicable', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_meeting VALUES (7, 2, -1, '2025-04-04 14:54:54.631376', -1, '2025-04-04 14:54:54.631377', NULL, NULL, true, 'agm', '23', 2, NULL, '2024-09-01 00:00:00', '2024-09-30 00:00:00', '16:00', '16:00', 2, '08578833', 'Mumbai', 'Physical', 'Yes', '', '', '', NULL, '', '', NULL, '', '', '', '', '', '', '', NULL, '', NULL, NULL, '', NULL, NULL, NULL, NULL, '', '', NULL, NULL, NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, '', NULL, '', NULL, 'Applicable', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_meeting VALUES (1, 2, -1, '2025-02-12 21:20:20.012415', -1, '2025-02-23 00:29:08.436063', NULL, NULL, true, 'bm', '23', 2321, 'Yes', '2025-02-14 00:00:00', '2025-02-13 00:00:00', '21:30', '21:30', 342, '08578833', 'wefewf', 'Physical', 'Yes', 'dvsv', 'dvsdvs', 'Female', '2025-02-18 00:00:00', '323442', 'csd@ff.dd', '2025-02-21 00:00:00', 'vsdvsdv', 'vsdvs', 'dsvds', 'dvsdv', '3353', '09473752', 'fwvwevw', '2025-02-15', 'ewefwef', '2025-02-21 00:00:00', '21:31', 'wewe@sdfd.vds', 'Yes', 'Yes', 'Yes', 'EGM', '16974', '8117', '2025-02-28 00:00:00', '21:29', NULL, 'fewf', '09475141', '09473752', '08578833', '', '08578833', 'elected', 'Member', '14:29', '2025-02-19 00:00:00', 'dvsd', '2025-02-14 00:00:00', 'wevwe', '2025-02-01 00:00:00', 'Applicable', 'fwefwef', 'Yes', 'Yes', 'Yes', 'https://fama.b-cdn.net/ComplyCrafter/dev/Meeting/1_20250223002602_ackDraft (4).pdf', 'https://fama.b-cdn.net/ComplyCrafter/dev/Meeting/1_20250223002657_ackDraft.pdf', NULL, 'https://fama.b-cdn.net/ComplyCrafter/dev/Meeting/1_20250223002658_ackDraft (3).doc', NULL, 'https://fama.b-cdn.net/ComplyCrafter/dev/Meeting/1_20250223002908_Minutes.pdf', NULL, NULL);


--
-- TOC entry 6029 (class 0 OID 197007)
-- Dependencies: 313
-- Data for Name: tbl_meeting_circulation; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_meeting_circulation VALUES (1, 1, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (3, 1, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (2, 1, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (4, 1, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (7, 2, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (6, 2, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (5, 2, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (8, 3, 'cNotice', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (9, 3, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (10, 3, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (11, 4, 'cNotice', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (12, 4, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (13, 4, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (14, 5, 'cNotice', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (15, 5, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (16, 5, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (19, 6, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (18, 6, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (17, 6, 'cSigned', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (20, 7, 'cNotice', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (21, 7, 'cDraft', '', NULL, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_circulation VALUES (22, 7, 'cSigned', '', NULL, NULL, '', '', NULL);


--
-- TOC entry 6031 (class 0 OID 197016)
-- Dependencies: 315
-- Data for Name: tbl_meeting_communicate_comment; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_meeting_communicate_comment VALUES (1, 2, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_communicate_comment VALUES (2, 3, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_communicate_comment VALUES (3, 4, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_communicate_comment VALUES (4, 5, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_communicate_comment VALUES (5, 6, NULL, '', '', NULL);
INSERT INTO public.tbl_meeting_communicate_comment VALUES (6, 7, NULL, '', '', NULL);


--
-- TOC entry 6115 (class 0 OID 230317)
-- Dependencies: 436
-- Data for Name: tbl_meeting_resolution; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_meeting_resolution VALUES (3, 6, 1, 9, 1);
INSERT INTO public.tbl_meeting_resolution VALUES (4, 5, 1, 10, 1);
INSERT INTO public.tbl_meeting_resolution VALUES (6, 2, 6, 1, 1);
INSERT INTO public.tbl_meeting_resolution VALUES (7, 2, 4, 3, 2);


--
-- TOC entry 6027 (class 0 OID 196998)
-- Dependencies: 311
-- Data for Name: tbl_meeting_special_invitee; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_meeting_special_invitee VALUES (1, 1, '1 Any special invitee', '1 desig', 'org', NULL);
INSERT INTO public.tbl_meeting_special_invitee VALUES (2, 1, '2 Any special invitee', '2 desig', 'og', NULL);
INSERT INTO public.tbl_meeting_special_invitee VALUES (3, 2, '', '', '', NULL);
INSERT INTO public.tbl_meeting_special_invitee VALUES (4, 3, '', '', '', NULL);
INSERT INTO public.tbl_meeting_special_invitee VALUES (5, 4, '', '', '', NULL);


--
-- TOC entry 6037 (class 0 OID 204998)
-- Dependencies: 322
-- Data for Name: tbl_mgt14; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mgt14 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', NULL, NULL, 'pakshal.shah2003@gmail.com', 'Manager', '0987654321', 1234567890, '2025-02-08 00:00:00', 'Chartered Accountant (in whole-time practice)', '265', NULL, 987654321, '', '', true, false, true, '2025-02-13 00:00:00', '2025-02-04 00:00:00', '2025-02-02 00:00:00', '2025-02-11 00:00:00', 23, '2025-02-12 00:00:00', '2025-02-12', 'no agreement is entered', 'matter of the agreement', 'Board of Directors', '1234567890', 'Entrenchment of Articles,Change of address of the registered office,Change of address of registered office resulting in change in RoC within the same State,Change of address of registered office resulting in change in State within the jurisdiction of same RoC or outside the jurisdiction of existing RoC,Alteration in Memorandum of Association except in case of change in name, registered office, object clause or change in authorized share capital,Alteration in authorized share capital,Alteration in memorandum for change in name,Alteration in object clause,Alteration of Articles,Conversion of public company into private company,Conversion of private company into public company,Conversion of company limited by guarantee into a company limited by shares,Conversion of Unlimited Liability Company into a Company Limited by shares,Conversion of Unlimited Liability Company into a Company Limited by guarantee,Allotment of Securities,Approval of scheme for providing financial assistance for purchase of its own shares,Buyback of shares or specified securities,Appointment of more than Fifteen Directors,Reappointment of Independent Director after a term of 5 consecutive years,Restricting the number of Directorship which can be held by the Company''s Director,To fix remuneration payable to directors including managing director or whole time director or manager,Appointment of MD, WTD or Manager,Agreement relating to appointment, reappointment or renewal of appointment or variation of terms of appointment of a managing director,Application to Registrar to remove name of company from register of companies,To adopt table F in schedule,Application to Registrar for obtaining the status of Dormant company,Variation in terms of Contract referred to in the prospectus or objects for which the prospectus was issued,Registers and returns to be kept at a place other than where registered office is situated,Removal of auditor before the expiry of his term,Resolutions passed in pursuance of exercise of powers of Board of Directors,Sell, lease or otherwise disposal of the whole, or substantially the whole, of the undertaking,Loans to Director or any person in whom Director is interested,Inter corporate loans and investments or guarantee or security in excess of the prescribed limits,Authorization for related party transactions,To request the Government to investigate the affairs of the company and to appoint inspectors,Change in objects of the company in case company has unutilized amount of money raised through issue of prospectus,Issue of Global Depository Receipts in any foreign country,Removal of retiring auditor not to be reappointed at Annual General Meeting,Remit or give time for repayment of any debt due from a director,Invest otherwise in trust securities the amount of compensation received by it as a result of any merger or amalgamation,Invest otherwise in trust securities the amount of compensation received by it as a result of any merger or amalgamation,Investigation into the affairs of the company by Serious Fraud Investigation Office,Others under Companies Act,2013,Waiver of amount recoverable from Director,Conversion from Section 8 company to any other kind (before RD approval in INC-18),Conversion from Section 8 company to any other kind (after RD approval in INC-18),Conversion from Section 8 company to any other kind (after RD approval in INC-18),Conversion to Section 8 company,Conversion of OPC into Private Company,Conversion of OPC into Public Company,Conversion of Private Company into OPC,Variation of shareholders rights,Reduction of share capital,Acceptance of Deposits from Members,Removal of Director before expiry of term,Loans or investments by company exceeding prescribed limits,Acquisition by Nidhi Company of another company by purchase of securities or controlling the composition of the Board of Directors of any other company or entering into any arrangement for the change of its management,Voluntary liquidation,Others under Insolvency and Bankruptcy Code, 2016', '2025-02-14 16:20:50.288102', -1, -1, '2025-02-14 16:31:19.347503', true, NULL);
INSERT INTO public.tbl_mgt14 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Director', '0987654321', 1234567890, '2025-02-13 00:00:00', 'Chartered Accountant (in whole-time practice)', '265', 'Associate', 987654321, '', '', true, false, true, '2025-02-07 00:00:00', '2025-02-08 00:00:00', '2025-02-09 00:00:00', '2025-02-10 00:00:00', 4, '2025-02-11 00:00:00', '2025-02-11', 'agreement is entered', 'matter of the agreement', 'Board of Directors', '1234567890', 'Entrenchment of Articles,Change of address of the registered office,Change of address of registered office resulting in change in RoC within the same State', '2025-02-14 16:44:23.066213', -1, -1, '2025-02-14 16:44:23.066217', true, NULL);
INSERT INTO public.tbl_mgt14 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Manager', '0987654321', 1234567890, '2025-02-13 00:00:00', 'Chartered Accountant (in whole-time practice)', '265', 'Associate', 987654321, '', '', true, true, true, '2025-02-06 00:00:00', '2025-02-07 00:00:00', '2025-02-09 00:00:00', '2025-02-10 00:00:00', 5, '2025-02-11 00:00:00', '2025-02-12', 'which the agreement is entered', 'matter of the agreement', 'Board of Directors', '1234567890', '1,2,31,32', '2025-02-14 17:36:52.838128', -1, -1, '2025-02-14 17:36:52.838133', true, NULL);


--
-- TOC entry 6049 (class 0 OID 221388)
-- Dependencies: 341
-- Data for Name: tbl_mgt6; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mgt6 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 123, '', '', '', '', '2025-01-28 00:00:00', 'CEO', 'alphadigitall', '', '2025-02-28 17:03:42.588129', -1, -1, '2025-03-11 13:31:49.932094', true, NULL);


--
-- TOC entry 6143 (class 0 OID 231854)
-- Dependencies: 470
-- Data for Name: tbl_mgt7a; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mgt7a VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '1234567890', '123456789098765', '2025-04-03 00:00:00', 'Website', '123456789', 'OPC', 'ULCM', 'STGM', 'NO', 'OPC', '2025-04-11', '2025-04-04', 'Yes', '2025-04-01 00:00:00', '2025-04-05 00:00:00', 'Yes', '', '2025-04-03 00:00:00', 'Specify the reasons for not holding the same
', '1123123', '826401', 1231231, 123123123, 123213123, 123123, 23112312, 234123123123, 4234234, 23423423, 21212, 1321312312, 234234, 2342342, 23423, 4234234, 2545, 53434, 24234234, 5432, 21312324, 234234234, 2352523523423, 4234234, 234324, 42342342342, 234234234234, 234234, 23423, 423423423, 42344543, 2424, 235325, 343434255, 234234234, 23423423, 4234235, 13434, 23423423, 234234234, 23423, 52354, 323244325, 324234, 234234, 234234234, 2342342423, 423, 543224123, 3253434, 424234, 24234, 23423532, 2424324, 3535, 344, 325234, 23534, 42342423, 234234, 23423, 4234234, 324234234, 'NA', 4234234, 235325, 343434, 353434, 3252342, 342344, 235535, 424233, 24234, 234324, 234234234, 23235, 3242423, 4235235, 324234, 234234, 32423, 2353253, 5345, 235234234, 'NA', 3242323, 5334, 2423423, 423423423423, 423423, 423534, 3434, 4563434, 3242343, 5343434, 3453443, 3434, 234235, 4234234234, 23423423, 34324, 343434, 34523423, 423423, 423532434, 3434, 3242342, 3423543, 325234, 'NA', 23423, 234234, 234234, 4353423232, 23423, 423423, 423543, 434, 345354234, 235345, 345634534, 3434, 23423412, 34234234, 3434, 34, 31231, 312312, 2423423, 532432, 'NA', 124423, 425, 4534, 343434, 12312312, 243234234, 34534342, 412214, true, 'YES', 'YES', '2025-04-11 00:00:00', 2132312, 13123123, 0, 423423, 23423423, 0, 5324534, 34345342234423, 0, 0, 0, 0, 423423, 234234, 213423423, 0, 42352352345, 23423423, 4234234, 0, 325234234, 20324, 23423423, 0, 233443, 100, 23234234, 0, 24234234, 0, 4234234, 0, 4324234, 0, 23423423423, 0, 1231230, 0, 123123130, 0, 12312310, 0, 3123230, 0, 324234230, 0, 4242323234, 0, 23423423, 0, 23423423, 0, 123123130, 0, 1231231230, 0, 2131231230, 0, 21120, 0, 121231230, 0, 12312310, 0, 1231230, 0, 1231230, 0, 12312310, 0, 1212231230, 0, 123123120, 0, 12312312, 0, 1231231230, 0, 112320, 0, 100000, 100, 0, 0, 2231123, 2131231230, 0, 2131231230, 0, 12312, 0, 12312, 0, 123123, 0, 123123, 0, 1231230, 0, 234234320, 0, 23420, 0, 23423, 0, 4350, 0, 535340, 0, 3440, 0, 64324230, 0, 34340, 0, 4353530, 0, 345350, 0, 322420, 0, 242320, 0, 353430, 0, 3435350, 0, 345340, 0, 43340, 0, 433530, 0, 34340, 0, 3534340, 0, 345340, 0, 3434340, 0, 100000, 100, 0, 0, 2433534, 12312321312, 31234, 23423423423, 23424, 434234, 23545345, 'NO', 'If No, give reasons/observations', '23423410', '2025-04-06 00:00:00', '09473752', '09475141', '2025-04-09 15:34:07.127114', -1, -1, '2025-04-09 15:45:45.347123', true, NULL);


--
-- TOC entry 6119 (class 0 OID 230431)
-- Dependencies: 440
-- Data for Name: tbl_mgt8; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mgt8 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2012-13', '280', '265', '1234567890', '212347', 'manager', '123123123123', '2025-03-24 00:00:00', 'mumbai', 'Without', true, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, '2025-03-27 18:02:12.15693', -1, -1, '2025-03-27 18:03:00.284419', true, NULL);


--
-- TOC entry 6117 (class 0 OID 230416)
-- Dependencies: 438
-- Data for Name: tbl_mgt9; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mgt9 VALUES (1, NULL, 0, '', '', '', '', '', 'no', 'vijay saroj', 'lbs marg', '08070807044', '', 23, 324, 2323423, 23423432, 2342, 234234, 23234, 0, 0, NULL, 234234, 324234, 234234, 32324, 23234, 2342, 23234, 2332, 34234, 0, 234234, 23234, 323423, 0, 234234, 23423, 123213, 23123, 312312, 123123, 21312321, 213123, 112312, 12312, 312, 23423, 234324, 23423423, 23432, 32423, 423, 324234, 0, 0, 0, 0, 'Not Applicable', 234, 'Not Applicable', 0, 0, '234234', 'Not Applicable', '', 32423423, 234234, 234324, 234324, 234234, 234234, 234324, 0, 234234, '', 2423432, 23423423, 23423423, 42342, 23423, 234234, 234234, 234234, 234324, '', 32423423, 234234, 234234, 23423423, 23423, 234, 234, 234, 234234, 'Not Applicable', '234234', '234234', 234234, '234', '23423423', '234234', '234234', 23423423, '42342', '32342342323', '423423', '4234234', 23234, '23234324', '23423423', '234234', '534534', 34, '3534', '344', '3434', '3434', 3434, '433434', '34453', '3434', '3453434', 343434, '34', '34', '3434', '3434', 56546, '546456', '4565464', '456456', '544564', 546, '54645', '345', '234234', '2423423', 234324, '3434', '34', '2025-03-28 13:01:36.6002', -1, -1, '2025-03-28 13:01:36.600251', true, NULL);
INSERT INTO public.tbl_mgt9 VALUES (2, NULL, 2, '', '', '', '', '2001-02', 'no', 'vijay saroj', 'lbs marg', '08070807044', 'vijaysaroj4527@gmail.com', 23, 324, 2323423, 23423432, 2342, 234234, 23234, 1223, 2324, 324234, 234234, 324234, 234234, 32324, 23234, 2342, 23234, 2332, 34234, 12, 234234, 23234, 323423, 34, 234234, 23423, 123213, 23123, 312312, 123123, 21312321, 213123, 112312, 12312, 312, 23423, 234324, 23423423, 23432, 32423, 423, 324234, 123324, 213123, 12312, 123123, 'not applicable', 234, 'Not Applicable', 12, 23, '234234', 'Not Applicable', 'vijay saroj', 32423423, 12, 1313, 213123, 123123, 123123, 123123, 0, 213123123, 'vijay saroj', 2423432, 23423423, 23423423, 42342, 23423, 234234, 234234, 234234, 234324, 'vijay saroj', 32423423, 234234, 234234, 23423423, 23423, 234, 234, 234, 234234, 'Not Applicable', '234234', '234234', 234234, '234', '23423423', '234234', '234234', 23423423, '42342', '32342342323', '423423', '4234234', 23234, '23234324', '23423423', '234234', '534534', 34, '3534', '344', '3434', '3434', 3434, '433434', '34453', '3434', '3453434', 343434, '34', '34', '3434', '3434', 56546, '546456', '4565464', '456456', '544564', 546, '54645', '345', '234234', '2423423', 234324, '3434', '34', '2025-03-28 13:15:00.45118', -1, -1, '2025-03-28 13:41:40.244261', true, NULL);


--
-- TOC entry 6017 (class 0 OID 181133)
-- Dependencies: 296
-- Data for Name: tbl_mr1; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_mr1 VALUES (1, 2, -1, '2025-01-10 13:44:20.244065', -1, '2025-01-10 13:46:04.170569', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Y', 'name', '(b) *Director Identification number (DIN) or income-tax permanent account number (PAN) or membership number', '(c) *Designation', '2025-01-19 00:00:00', '2025-01-22 00:00:00', 'month', 412, 4234, 432, 323545, '2025-01-18 00:00:00', '2025-01-16 00:00:00', 'no', 'no', 'yes', 'yes', 'qqdqfqfqqqw', 'resoluiton no', '2025-01-07 00:00:00', 'Company Secretary', 'Signatory', 'DIN of the director; or DIN or PAN of the manager or CEO or CFO; or Membership number of the Company secretary', 'costAccountant', '265', 'fellow', '23f2fq');


--
-- TOC entry 6053 (class 0 OID 221506)
-- Dependencies: 347
-- Data for Name: tbl_msme; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_msme VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', '', 'AAWCA4389D', 'Periodic Half-yearly return', '2025-02-27 00:00:00', '2025-01-31 00:00:00', '', 'Director', 'alphadigitall', '', '2025-03-01 17:26:22.169505', -1, -1, '2025-03-01 17:26:39.746826', true, NULL);


--
-- TOC entry 5984 (class 0 OID 180282)
-- Dependencies: 247
-- Data for Name: tbl_other_auditor; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_other_auditor VALUES ('Individual', NULL, 'string', 'string', 'string', 'string', 'string', 'string', 'string', 'string', 'string', 'string', -1, '2024-11-28 19:04:51.230617', -1, '2024-11-28 20:13:50.767925', NULL, NULL, true, 'cost', 1);
INSERT INTO public.tbl_other_auditor VALUES ('Individual', 'Any Other Professional', 'proffesion', 'fwewe', 'efwef', 'wefwe', 'fwee', 'fewef', 'wfefw', 'fwefw', 'fwef', 'wefwefw', -1, '2024-11-28 20:14:19.033953', -1, '2024-11-28 20:14:19.033955', NULL, 0, true, 'internal', 2);
INSERT INTO public.tbl_other_auditor VALUES ('Individual', '', '', 'fwefwe', 'efwefwe', 'wefwef', 'wefwef', 'fwefwe', 'fewf', 'yytf', 'ytfyf@ff.dd', 'ytfytf', -1, '2024-11-28 20:23:39.993459', -1, '2024-11-28 20:23:39.993463', NULL, 0, true, 'secretarial', 5);
INSERT INTO public.tbl_other_auditor VALUES ('', '', '', '', '', '', '', '', '', '', '', '', -1, '2024-11-28 20:18:29.032665', -1, '2024-11-28 20:18:29.032669', '2024-11-28 20:23:46.628239', 0, true, 'secretarial', 3);
INSERT INTO public.tbl_other_auditor VALUES ('', '', '', '', '', '', '', '', '', '', '', '', -1, '2024-11-28 20:20:52.972817', -1, '2024-11-28 20:20:52.972818', '2024-11-28 20:23:49.848012', 0, true, 'secretarial', 4);


--
-- TOC entry 6045 (class 0 OID 221251)
-- Dependencies: 335
-- Data for Name: tbl_pas3; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_pas3 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 100, NULL, 1, 101, 102, 103, 104, 105, '', '', '', '1234567890', '2025-02-05 00:00:00', 'Secretary', 'alphadigitall', 'Company Secretary (in whole-time practice)', '265', 'Fellow', 987654321, '2025-02-24 12:21:10.934269', -1, -1, '2025-02-24 12:30:59.157716', true, NULL);
INSERT INTO public.tbl_pas3 VALUES (2, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 12, NULL, 1, 3, 4, 23, 23, 23, '', '', '', '1234567890', '2025-02-05 00:00:00', 'Secretary', 'alphadigitall', 'Company Secretary (in whole-time practice)', '265', 'Associate', NULL, '2025-02-28 15:34:06.281519', -1, -1, '2025-02-28 15:34:06.281523', true, NULL);


--
-- TOC entry 6039 (class 0 OID 205270)
-- Dependencies: 325
-- Data for Name: tbl_pas6; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_pas6 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2025-02-02 00:00:00', NULL, 25, 400, 50, 200, 25, 200, 25, 800, 100, '', 10, '', NULL, 20, 'Yes', 'Yes', 30, 'No', 'No', 40, 'Yes', 'No', 50, 'No', 'Yes', 60, 'Yes', 'No', 70, 'No', 'Yes', 80, 'No', 'Yes', 90, 'Yes', 'No', 100, 'No', 'Yes', 110, 'No', 'No', 660, 100, 150, 250, 100, 25, 125, 100, 25, 125, 'No', '2025-02-05', 25, 25, 'Reasons for delay', 24, 23, 'Reasons for delay', 'true', 'alpha', 'other detail that the professional signing this form may like to provide', NULL, '2025-02-05 00:00:00', NULL, 'Chartered Accountant', 'Director', 987654321, '', 'kurla', 'vijaysaroj45@gmail.com', 'Company Secretary (in whole-time practice)', '439', 'Associate', 1234567890, '', '2025-02-18 16:36:32.985179', -1, -1, '2025-02-18 16:36:32.985183', true, NULL);
INSERT INTO public.tbl_pas6 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2025-02-01 00:00:00', NULL, 40, 500, 50, 400, 40, 100, 10, 1000, 100, NULL, 100, '', NULL, 200, 'Yes', 'Yes', 300, 'No', 'No', 400, 'Yes', 'Yes', 500, 'No', 'No', 600, 'Yes', 'Yes', 700, 'No', 'No', 800, 'Yes', 'Yes', 900, 'No', 'No', 1000, 'Yes', 'Yes', 1100, 'No', 'No', 6600, 100, 20, 120, 100, 20, 120, NULL, 60, 160, 'Yes', NULL, 25, 25, 'Reasons for delay', 24, 23, 'Reasons for delay', 'true', 'alpha', 'other detail that the professional signing this form may like to provide', 1234567890, '2025-02-13 00:00:00', NULL, 'Company Secretary', '', 987654321, '', 'kurla', 'vijaysaroj45@gmail.com', 'Company Secretary (in whole-time practice)', '265', 'Associate', 1234567890, '', '2025-02-18 17:40:27.45812', -1, -1, '2025-02-18 19:09:25.577378', true, NULL);
INSERT INTO public.tbl_pas6 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2025-02-05 00:00:00', NULL, 25, 400, 50, 200, 25, 200, 25, 800, 100, NULL, 10, '', NULL, 20, 'Yes', 'Yes', 30, 'No', 'No', 40, 'Yes', 'Yes', 50, 'Yes', 'No', 60, 'No', 'Yes', 70, 'Yes', 'Yes', 80, 'Yes', 'No', 90, 'No', 'No', 100, 'Yes', 'Yes', 110, 'No', 'NA', 660, 100, 150, 250, 100, 25, 125, 100, 12, 112, 'No', '2025-02-07', 25, 25, 'Reasons for delay', 24, 23, 'Reasons for delay', 'true', 'alpha', 'other detail that the professional signing this form may like to provide', 325, NULL, 'tst', 'Chartered Accountant', 'Director', 987654321, '', 'kurla', 'vijaysaroj45@gmail.com', 'Chartered Accountant (in wholetime practice)', '', NULL, NULL, '', '2025-02-18 17:07:12.696142', -1, -1, '2025-02-18 19:12:41.190853', true, NULL);


--
-- TOC entry 6129 (class 0 OID 230595)
-- Dependencies: 452
-- Data for Name: tbl_reservation; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_reservation VALUES (1, 3, 'Auditor''s Qualification,reservations or adverse remarks 1', 'Director''s Comments 1', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_reservation VALUES (2, 3, 'Auditor''s Qualification,reservations or adverse remarks 2', 'Director''s Comments 2', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_reservation VALUES (3, 3, 'Auditor''s Qualification,reservations or adverse remarks 3', 'Director''s Comments 3', NULL, NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 6019 (class 0 OID 188249)
-- Dependencies: 299
-- Data for Name: tbl_resolution; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_resolution VALUES (1, -1, '2025-01-10 16:19:23.399527', -1, '2025-01-10 16:19:23.399559', NULL, true, '1', 'To shift the registered office of the company within local limits', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore, is proposing that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address} within the same city, town or village. For this purpose, the following resolution will be passed with or without modifications:', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore proposed that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address} within the same city, town or village. For this purpose, the following resolution will be passed unanimously:', '<p>"<b>RESOLVED THAT</b> pursuant to the provisions of Section 12 of the Companies Act, 2013 read with Companies (Incorporation) Rules, 2014 and any other provisions applicable, if any, the consent of the Board of Directors ("the Board") of the Company be and is hereby accorded to shift the registered office of the Company from {Existing Address} to {New Address} under the jurisdiction of {name of policestation} with effect from {Effective Date}, which is within the local limits of the city where the registered office is at present located."</p>
<p>"RESOLVED FURTHER THAT any of the Directors of the Company be and are hereby authorized to take necessary steps and to shift the registered office address of the Company including but not limited to filing of the necessary e-forms with Ministry of Corporate Affairs."</p>
<p>"RESOLVED FURTHER THAT change in the place of registered office of the Company be made in the nameplates or board affixed at the registered office as also in the letterheads, official’s publications, documents, etc., pursuant to the provisions contained in Section 12(3)(a) of the Companies Act, 2013."</p>
<p>"RESOLVED FURTHER THAT the Board be and are hereby authorized severally to communicate the said change to banks, customers, vendors, and all others as may be required."</p>', 'Corporate Compliance', 'Registered office');
INSERT INTO public.tbl_resolution VALUES (2, -1, '2025-01-10 16:23:09.223875', -1, '2025-01-10 16:23:09.223878', NULL, true, '2', 'To shift the Registered office outside the local limits', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore, is proposing that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address}, subject to the members'' approval. For this purpose, the following resolution will be passed with or without modifications:', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore, is proposing that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address}, subject to the members'' approval. The Board passed the following resolution unanimously:', 'RESOLVED THAT pursuant to the provisions of Section 12 of the Companies Act, 2013 and any other provisions applicable, if any, and subject to the approval of shareholders of the Company, the consent of the board of directors of the company be and is hereby accorded to shift the registered office of the company from {Existing Registered Office} to {New Registered Office} w.e.f. {Effective Date}.

RESOLVED FURTHER THAT pursuant to the provisions of Section 12 of the Companies Act, 2013, the address of the registered office of the Company mentioned in all the official documents, papers be replaced with the new address and all the offices/premises occupied by the Company should display the new registered office address of the Company.

RESOLVED FURTHER THAT any of the Directors of the Company be and are hereby authorised to do all acts, deeds, matters and things as deemed necessary, proper or desirable and to sign and execute all necessary documents, applications and returns, for the purpose of giving effect to the above said resolution including but not limited to filing of forms with the Registrar of Companies.', 'Business Management', 'Registrations');
INSERT INTO public.tbl_resolution VALUES (3, -1, '2025-01-10 16:24:33.807987', -1, '2025-01-10 16:24:33.807989', NULL, true, '3', 'To authorise for migration to GST', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore, is proposing that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address}, subject to the members'' approval. For this purpose, the following resolution will be passed with or without modifications:', 'The registered office of the Company is presently situated at {Existing Address}. The Board is of the view that it would be more viable and economical for the Company to have its registered office at {New Address}. The Board, therefore, is proposing that the Company should, for the efficient conduct of business and for administrative convenience, shift its registered office from {Existing Address} to {New Address}, subject to the members'' approval. The Board passed the following resolution unanimously:', 'RESOLVED THAT pursuant to the provisions of Section 12 of the Companies Act, 2013 and any other provisions applicable, if any, and subject to the approval of shareholders of the Company, the consent of the board of directors of the company be and is hereby accorded to shift the registered office of the company from [Existing Registered Office] to [New Registered Office] w.e.f. [Effective Date].

RESOLVED FURTHER THAT pursuant to the provisions of Section 12 of the Companies Act, 2013, the address of the registered office of the Company mentioned in all the official documents, papers be replaced with the new address and all the offices/premises occupied by the Company should display the new registered office address of the Company.

RESOLVED FURTHER THAT any of the Directors of the Company be and are hereby authorised to do all acts, deeds, matters and things as deemed necessary, proper or desirable and to sign and execute all necessary documents, applications and returns, for the purpose of giving effect to the above said resolution including but not limited to filing of forms with the Registrar of Companies.', 'Director & KMP', 'Appointment');
INSERT INTO public.tbl_resolution VALUES (4, -1, '2025-01-10 16:28:49.633972', -1, '2025-01-10 16:28:49.633976', NULL, true, '4', 'To Appoint as an Additional Director', 'It is proposed to appoint {Name of Appointee}, as an Additional Director who will hold the office up to the date of the ensuing Annual General Meeting. The Company has received {his/her} consent in Form DIR-2 and declaration in Form DIR-8 that {he/she} is not disqualified to be appointed as Director in accordance with the provisions of Section 164 of the Companies Act, 2013. It is proposed to pass the following resolution with or without modification:', 'It was proposed to appoint {Name of Appointee}, as an Additional Director who shall hold the office up to the date of the ensuing Annual General Meeting. The Chairperson further informed that the Company had received {his/her} consent to act as an Additional Director in Form DIR-2 and declaration in Form DIR-8 that {he/she} was not disqualified to be appointed as Additional Director in accordance with the provisions of Section 164 of the Companies Act, 2013. The Board discussed the matter and thereafter passed the following resolution unanimously in this regard:', 'RESOLVED THAT pursuant to Section 161(1) of the Companies Act, 2013 read with Rule 8 & Rule 18 of the Companies (Appointment and Qualification of Directors) Rules, 2014 and applicable provisions of the Articles of Association of the Company, {Name of Appointee}, be and is hereby appointed as an Additional Director on the Board of Directors of the Company with effect from {Date of Appointment} to hold office up to the next Annual General Meeting of the Company.

RESOLVED FURTHER THAT any of the Directors of the Company be and are hereby authorised to do all acts, deeds, matters and things as deemed necessary, proper or desirable and to sign and execute all necessary documents, applications and returns, for the purpose of giving effect to the above said resolution including but not limited to filing of forms with the Registrar of Companies.', 'Corporate Compliance', 'Registered office');
INSERT INTO public.tbl_resolution VALUES (5, -1, '2025-04-09 00:00:00', -1, '2025-04-09 00:00:00', NULL, NULL, '6', 'To Appoint [Name of Appointee] as an Independent Director', 'It is informed to the Board that as per the provisions of Section 149 of the Companies Act, 2013 read with the Companies (Appointment and Qualification of Directors) Rules, 2014, the Company has to appoint an Independent Directors on the Board of the Company.

In order to comply with the provisions of Section 149(4) of the Companies Act, 2013, it is being proposed to appoint [Name of Appointee] as an Independent Director of the Company. [Name of Appointee] fulfills the conditions specified in the Act and the Rules framed thereunder for appointment as Independent Director and [he-she] is independent of the management.

The Board may discuss the matter and if thought fit, pass the following resolutions in this regard:', 'The Chairperson informed the Board that as per the provisions of Section 149 of the Companies Act, 2013 read with the Companies (Appointment and Qualification of Directors) Rules, 2014, the company has to appoint an Independent Director on the board of the Company.

In order to comply with the provisions of Section 149(4) of the Companies Act, 2013, it was proposed to appoint [Name of Appointee] as an Independent Director of the Company. The Board was informed that [Name of Appointee] fulfills the conditions specified in the Act and the Rules framed thereunder for appointment as Independent Director and [he-she] is independent of the management. The consent in DIR-2, intimation in DIR-8, and certificate of independence were placed before the Board.

The Board discussed the matter and passed the following resolutions in this regard:', 'RESOLVED THAT pursuant to the provision of Section 149 of Companies Act, 2013 and all other applicable provisions, if any, read with rules made thereunder and subject to the approval of the shareholders of the Company, the consent of the Board be and is hereby accorded to the appointment of [Name of Appointee] as an Independent Director of the Company for the period of [Term], not liable to retire by rotation.

RESOLVED FURTHER THAT the draft appointment letter for the independent director as placed before the Board be and is hereby approved and all the directors of the Company be and are hereby severally authorized to issue the same and take necessary steps in relation to the above and file necessary e-forms and other documents as may be required for the aforesaid purpose.

RESOLVED FURTHER THAT a certified true copy of this resolution signed by any of the Directors of the company be provided to anyone concerned or interested in the matter.', NULL, NULL);


--
-- TOC entry 6059 (class 0 OID 221640)
-- Dependencies: 356
-- Data for Name: tbl_run; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_run VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'alphadigitall', 'alpha', 'comments', '', '2025-03-02 17:20:40.002877', -1, -1, '2025-03-04 13:50:00.01265', true, NULL);


--
-- TOC entry 6065 (class 0 OID 221862)
-- Dependencies: 365
-- Data for Name: tbl_runllp; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_runllp VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'Conversion of private company/unlisted public company into LLP', '96904', '96904, 96903', 'Coin-operated personal service machines such as photo booths, weighing machines, blood pressure checking machines etc.', 'alphadigitall', 'ozair', '', '2025-03-05 12:42:27.529971', -1, -1, '2025-03-05 13:40:14.547687', true, NULL);
INSERT INTO public.tbl_runllp VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'Conversion of private company/unlisted public company into LLP', '98200', '98200', 'Undifferentiated service-producing activities of private households for own use', 'alphadigitall', 'ozair', '', '2025-03-05 12:37:19.918134', -1, -1, '2025-03-08 13:26:40.956374', true, NULL);


--
-- TOC entry 6063 (class 0 OID 221812)
-- Dependencies: 362
-- Data for Name: tbl_sh11; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh11 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 0, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:08:58.243483', -1, -1, '2025-03-04 13:08:58.243486', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 0, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:10:41.769257', -1, -1, '2025-03-04 13:10:41.76926', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (3, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 0, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:21:46.805071', -1, -1, '2025-03-04 13:21:46.805073', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (4, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:23:55.513102', -1, -1, '2025-03-04 13:23:55.513104', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (5, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:24:47.220701', -1, -1, '2025-03-04 13:24:47.220708', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (6, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:26:53.4469', -1, -1, '2025-03-04 13:26:53.446903', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (7, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', false, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:33:09.534386', -1, -1, '2025-03-04 13:33:09.534392', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (8, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', true, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:45:51.70066', -1, -1, '2025-03-04 13:45:51.700664', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (9, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '', '', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', true, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 13:46:18.375944', -1, -1, '2025-03-04 13:46:18.375945', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (10, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '234567890', '9876543', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', true, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 17:00:04.821219', -1, -1, '2025-03-04 17:00:04.821222', true, NULL);
INSERT INTO public.tbl_sh11 VALUES (11, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', '', '', '234567890', '9876543', '2025-02-25 00:00:00', true, '1', '2', true, '3', '4', true, '5', '6', '2025-02-28 00:00:00', 199, 299, 'Description of share capital ', 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 189, '2025-02-26 00:00:00', NULL, 0, NULL, NULL, 0, '2025-02-25 00:00:00', '', '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', NULL, '2025-02-24 00:00:00', 'Y', '2:1', '', '', '2025-03-03 00:00:00', '2025-02-24 00:00:00', 31, 32, 33, 33, 35, 36, 37, 38, 39, 40, 42, 42, 43, 44, 45, 46, 47, 48, 49, NULL, 51, 52, 53, 54, 55, 56, '', '', '', '1234567890', NULL, 'Director', 'anas', '9098765432', 'Managing Director', 'vijay', '1234567890', 'Company Secretary in practice', 'Associate', '098765', '2025-03-04 17:04:06.046935', -1, -1, '2025-03-04 17:04:06.046937', true, NULL);


--
-- TOC entry 6011 (class 0 OID 181066)
-- Dependencies: 289
-- Data for Name: tbl_sh7; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh7 VALUES (2, 2, -1, '2025-01-09 16:52:58.018369', -1, '2025-01-09 16:52:58.018373', '2025-01-09 16:52:58.018373', NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Increase in share capital with Central Government order', 'Equity', '2025-01-10 00:00:00', '(b) Service request number (SRN) of related Form MGT-14', 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 'f2f231', '2025-01-14 00:00:00', 'State', 'Himachal Pradesh', true, true, '2025-01-14 00:00:00', 'no', '2025-01-14 00:00:00', '2025-01-17 00:00:00', '(d) SRN of INC-28 in which the order of Central Government / Tribunal is filed', '2025-01-18 00:00:00', true, true, true, true, true, 'No', 'Yes', '3223', 3232, '2ff32few', 'ewfwef', 'Manager', 'Manager', '*DIN of the director; or DIN or PAN of the manager or CEO or CFO; or Membership number of the Company secretary', 'costAccountant', '265', 'fellow', 'QWDQWDQ');
INSERT INTO public.tbl_sh7 VALUES (3, 2, -1, '2025-01-09 16:54:47.554399', -1, '2025-01-09 16:54:47.554403', '2025-01-09 16:52:58.018373', NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Increase in share capital with Central Government order', '', '2025-01-10 00:00:00', '(b) Service request number (SRN) of related Form MGT-14', 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 'f2f231', '2025-01-14 00:00:00', 'State', 'Himachal Pradesh', true, true, '2025-01-14 00:00:00', 'no', '2025-01-14 00:00:00', '2025-01-17 00:00:00', '(d) SRN of INC-28 in which the order of Central Government / Tribunal is filed', '2025-01-18 00:00:00', true, true, true, true, true, 'No', 'Yes', '3223', 3232, '2ff32few', 'ewfwef', 'Manager', 'Manager', '*DIN of the director; or DIN or PAN of the manager or CEO or CFO; or Membership number of the Company secretary', 'costAccountant', '265', 'fellow', 'QWDQWDQ');
INSERT INTO public.tbl_sh7 VALUES (1, 2, -1, '2025-01-09 12:45:48.992855', -1, '2025-04-12 10:39:10.032599', NULL, NULL, true, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Increase in share capital with Central Government order', 'Special', '2025-01-10 00:00:00', '(b) Service request number (SRN) of related Form MGT-14', 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 'f2f231', '2025-01-14 00:00:00', 'State', 'Himachal Pradesh', true, true, '2025-01-14 00:00:00', 'no', '2025-01-14 00:00:00', '2025-01-17 00:00:00', '(d) SRN of INC-28 in which the order of Central Government / Tribunal is filed', '2025-01-18 00:00:00', true, true, true, true, true, 'No', 'Yes', '3223', 3232, '2ff32few', 'ewfwef', 'Manager', 'Manager', '*DIN of the director; or DIN or PAN of the manager or CEO or CFO; or Membership number of the Company secretary', 'costAccountant', '265', 'fellow', 'QWDQWDQ');


--
-- TOC entry 6013 (class 0 OID 181093)
-- Dependencies: 292
-- Data for Name: tbl_sh7_share; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh7_share VALUES (2, 1, 'Preference', 'share 2', 11, 22, 'No', 33, 44, 55, 66, 77, 'share 2 brief', '2025-01-09 15:24:05.166581');
INSERT INTO public.tbl_sh7_share VALUES (4, 2, 'Equity', 'share 1 ', 1, 2, 'Yes', 3, 4, 5, 6, 7, 'share 1 brief', NULL);
INSERT INTO public.tbl_sh7_share VALUES (5, 2, '', 'share 3', 31, 32, 'No', 33, 34, 45, 36, 37, 'share 3 brief', NULL);
INSERT INTO public.tbl_sh7_share VALUES (6, 3, 'Equity', 'share 1 ', 1, 2, 'Yes', 3, 4, 5, 6, 7, 'share 1 brief', NULL);
INSERT INTO public.tbl_sh7_share VALUES (7, 3, '', 'share 3', 31, 32, 'No', 33, 34, 45, 36, 37, 'share 3 brief', NULL);
INSERT INTO public.tbl_sh7_share VALUES (3, 1, '', 'share 3', 31, 32, 'No', 33, 34, 45, 36, 37, 'share 3 brief', '2025-04-12 10:39:10.072017');
INSERT INTO public.tbl_sh7_share VALUES (1, 1, 'Equity', 'share 1 ', 1, 2, 'Yes', 3, 4, 5, 6, 7, 'share 1 brief', NULL);
INSERT INTO public.tbl_sh7_share VALUES (8, 1, '', 'share 2', 3, 3, 'Yes', 4, 4, 4, 43, 2, 'share 3 brief', NULL);


--
-- TOC entry 6015 (class 0 OID 181102)
-- Dependencies: 294
-- Data for Name: tbl_sh7_structure; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh7_structure VALUES (2, 1, 'existing', 'Preference', 'share 2 existing', 675, 765, 65, 46, 645, 76, 675, 675, 67, 76, 7, 675, '2025-01-09 17:38:15.528366');
INSERT INTO public.tbl_sh7_structure VALUES (4, 1, 'revised', 'Preference', 'share 1 reised', 675, 897, 857, 543, NULL, 342, 423, 767, 67, 78, 456, 276, '2025-01-09 17:38:15.54458');
INSERT INTO public.tbl_sh7_structure VALUES (1, 1, 'existing', 'Equity', 'share 1 existing', 12, 45, 64, 64, 64, 3, 324, 75, 68, 86, 86, 86, NULL);
INSERT INTO public.tbl_sh7_structure VALUES (5, 1, 'existing', 'Unclassified', 'share 3 existing', 675, 578, 87, 87, 85, 857, 875, 875, 875, 875, 875, 85, NULL);
INSERT INTO public.tbl_sh7_structure VALUES (3, 1, 'revised', 'Equity', 'share 1 revised', 66, 46, 7, 876, 786, 786, 564, 654, 53, 67, 67, 3, NULL);
INSERT INTO public.tbl_sh7_structure VALUES (6, 1, 'revised', 'Unclassified', 'share 3 reised', 7858, 587, 875, 875, 65, 3534, 64, 785, 78, 87, 67, 76, NULL);


--
-- TOC entry 6061 (class 0 OID 221725)
-- Dependencies: 359
-- Data for Name: tbl_sh8; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh8 VALUES (1, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', '2025-02-25 00:00:00', 100, 50, 'Description of share capital', 1, 2, 6, 3, 4, 5, 7, 8, 5, 12, 21, 32, 180, '2025-02-25 00:00:00', 150, 130, 120, '2025-02-28 00:00:00', '2025-02-27 00:00:00', '2025-02-25 00:00:00', '2025-02-25 00:00:00', true, true, true, '2025-02-25 00:00:00', 1, 4, 2, 5, 3, 6, false, NULL, false, 34, 43, true, false, false, false, true, true, ' If any other mode, please specify the details', '123', '2025-02-26 00:00:00', '2025-02-24 00:00:00', '1234567890', 11, 12, 13, NULL, 14, 15, 16, 0, 17, 18, 19, NULL, 20, 21, 22, NULL, '2025-02-26 00:00:00', '2025-02-26 00:00:00', '2025-02-25 00:00:00', '', 23, 24, 25, NULL, 26, 27, 28, NULL, 29, 30, 31, NULL, '2025-03-02 00:00:00', '2025-02-24 00:00:00', '2025-02-25 00:00:00', '', NULL, NULL, NULL, NULL, '2025-03-05 00:00:00', '33', '33', '34', '35', '36', '37', '38', '39', '40', '41', '42', '43', '44', 'Y', '2:1', '12', '21', 'true', 'Y', 'Managing Director', 'vijay', '09876543', 'Managing Director', 'anas', '1234567', '', '', '', '', '', '2025-03-03 18:09:07.320648', -1, -1, '2025-03-04 17:47:42.589532', true, NULL);


--
-- TOC entry 6047 (class 0 OID 221358)
-- Dependencies: 338
-- Data for Name: tbl_sh9; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_sh9 VALUES (1, NULL, 4, 'U24299MH2001PTC133129', 'KHATRI DYEING PRIVATE LIMITED', 'Room No.10,1st Floor,Lotus Building, 59,Mohammed Ali Road, Mumbai Mumbai City MH 400003 IN', 'msekhatri@gmail.com', 'Y', '2025-02-05', '2025-01-27 00:00:00', 1234567890, 0, '2025-01-31', '123456789', '', '', '', '', 'vijay', '12345678', 'Managing Director', 'anas qureshi', '09876543', '', '', '', '', '2025-02-28 13:49:34.937026', -1, -1, '2025-02-28 14:13:50.213649', true, NULL);
INSERT INTO public.tbl_sh9 VALUES (2, NULL, 2, 'U74999MH2017PTC289529', 'PRIYA EXPRESS PRIVATE LIMITED', 'SHOP NO 5 SHIV KRUPA CHS OLD NAGARDAS ROAD ANDHERI EAST MUMBAI Mumbai City MH 400069 IN', 'pakshal.shah2003@gmail.com', 'Y', '2025-03-06', '2025-02-27 00:00:00', 123456789, 0, NULL, '123', '', '', '', '', 'vijay', '12345678', 'Director', 'anas', '12345678', '', '', '', '', '2025-03-01 17:29:05.054973', -1, -1, '2025-03-01 17:29:05.054975', true, NULL);


--
-- TOC entry 5973 (class 0 OID 180057)
-- Dependencies: 234
-- Data for Name: tbl_shareholder; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_shareholder VALUES (2, 'Director', 'string', 'string', 'Indian', 'Non Institutions', 'Minor', true, 1, 'Male', 'string', '2024-10-30', 'farhan@gmail.com', '8787878987', 'Unmarried', -1, '2024-11-27 15:03:15.507208', -1, '2024-11-27 15:03:15.507213', NULL, 0, true, 'Preference', 'string', 'CIN/LLPIN', '', NULL, '', 'string');
INSERT INTO public.tbl_shareholder VALUES (1, 'Shareholder', 'string', 'string', 'Foreign', 'Non Institutions', 'HUF', true, 2, 'Female', 'pan', '2024-11-25', 'stringemail@gmail.com', '9000000434', 'Unmarried', -1, '2024-11-25 13:02:31.397004', -1, '2024-11-27 14:19:19.597922', NULL, 1, true, 'Equity', 'Mr', 'CIN/LLPIN', 'Unique Identification No./Registration No.', '2024-11-27 00:00:00', 'Name of Body Corporate', 'passport');
INSERT INTO public.tbl_shareholder VALUES (3, 'Farhan ', 'Director M', 'Kazi', 'Indian', 'Non Institutions', 'Individual', true, 1, 'Male', 'string', '2024-10-30', 'farhan@gmail.com', '8787878987', 'Unmarried', -1, '2025-04-04 14:40:38.432018', -1, '2025-04-04 14:41:12.688673', NULL, 0, true, 'Equity', '', '', '', NULL, '', 'string');


--
-- TOC entry 5975 (class 0 OID 180066)
-- Dependencies: 236
-- Data for Name: tbl_shareholder_details; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_shareholder_details VALUES (1, 1, 'Address Line 1', 'Mumbai', 'Mahrashtra', 'India', '400070', 'Father', 'Mother', 'nationality', 'Voter', 'Aadhar', 'Occupation', 'Spouse', 'https://fama.b-cdn.net/ComplyCrafter/dev/Shareholder/1_20241125162452_fk.jpg', 'https://fama.b-cdn.net/ComplyCrafter/dev/Shareholder/1_20241125162452_fk sign.jpg', 'gaurdian');
INSERT INTO public.tbl_shareholder_details VALUES (2, 2, 'string', 'string', 'string', 'string', 'string', 'string', '', 'string', 'Voter', 'string', 'string', 'Spouse', '', '', 'gaurdian');
INSERT INTO public.tbl_shareholder_details VALUES (3, 3, 'stringvdasvas', 'stringvasvas', 'stringasvasvdas', 'stringvasvasdv', 'stringasdvasdvas', 'stringvasv', 'vas', 'INvasv', 'vasvs', 'stringasvas', 'stringasvasvas', 'dasvsa', 'https://fama.b-cdn.net/ComplyCrafter/dev/Shareholder/3_20250404144112_Checklist_Conversion of LLP to Private Limited Company.pdf', 'https://fama.b-cdn.net/ComplyCrafter/dev/Shareholder/3_20250404144113_Resolution Format.doc', '');


--
-- TOC entry 6107 (class 0 OID 223838)
-- Dependencies: 426
-- Data for Name: tbl_shareholder_management; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_shareholder_management VALUES (1, 2, -1, '2025-03-18 21:13:32.578022', -1, '2025-04-04 14:42:29.374228', NULL, NULL, true, 'yes', 1, 'MOA_subscriber', '["2"]', '2025-03-13 00:00:00', 'Director & Promoter', 'Physical', 'Equity Shares with Voting Rights', 1, 2, 3, '4', '5', 'Yes');
INSERT INTO public.tbl_shareholder_management VALUES (3, 3, -1, '2025-04-04 15:37:02.344019', -1, '2025-04-04 15:37:02.344023', NULL, NULL, true, NULL, NULL, NULL, '[]', NULL, '', '', '', NULL, NULL, NULL, '', '', NULL);


--
-- TOC entry 6109 (class 0 OID 223852)
-- Dependencies: 429
-- Data for Name: tbl_shareholder_management_owner; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_shareholder_management_owner VALUES (2, 1, 'bene 2', 'add 2', '2025-03-14', '2025-03-18 22:12:43.111276');
INSERT INTO public.tbl_shareholder_management_owner VALUES (1, 1, 'bene 1', 'add 1 up', '2025-03-20', NULL);
INSERT INTO public.tbl_shareholder_management_owner VALUES (3, 1, 'bene3', 'add 3', '2025-03-21', NULL);


--
-- TOC entry 6033 (class 0 OID 204673)
-- Dependencies: 317
-- Data for Name: tbl_stk2; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_stk2 VALUES (2, NULL, 2, '', 'PRIYA EXPRESS PRIVATE LIMITED', '', NULL, NULL, '', 'noticeRecieved', 'Not carrying on any business or operation for a period of two immediately preceding financial years and has not made any application within such period for obtaining the status of a dormant company under section 455', 'delistedCompany', 'resolutionPassed', '', '', 'q1234567890', 'mgtResolutionPassed', '1234567890', '', 12, 'yes', '123', 'vijay saroj', '2', 'fraud', 'Vijay', 'Ramesh saroj', 'AKSHAY GRAPHICS PRIVATE LIMITED', '1234567890', '2025-04-10', '', 'vijay', 'Chartered Accountant', '0987654321', '', '', '09475141', '', 'Cost accountant (in whole-time practice)', '', 'Associate', '1234567890', -1, '2025-04-12 12:33:13.056244', -1, '2025-04-12 13:38:31.009508', true, NULL, 'notRegulatedActivities', '');
INSERT INTO public.tbl_stk2 VALUES (1, NULL, 4, '', 'KHATRI DYEING PRIVATE LIMITED', '', NULL, NULL, '', 'noticeRecieved', 'Failed to commence business within one year of incorporation', 'delistedCompany', 'resolutionPassed', 'alpha@gmail.com', '25/09/20256', 'q1234567890', 'mgtResolutionPassed', '1234567890', '', 1234567890, 'yes', '1', 'Alpha', '2', '2', 'alpha ', 'alphadigitall', 'AKSHAY GRAPHICS PRIVATE LIMITED', '1234567890', '2025-02-11', '', 'vijay', 'Chartered Accountant', '1234567890', '', '', '09475141', '', 'Chartered accountant (in whole-time practice)', '265', 'Associate', '1234567890', -1, '2025-02-12 13:13:59.701024', -1, '2025-02-12 15:45:43.031758', true, NULL, 'regulatedActivities', 'Insurance Regulatory and Development Authority');


--
-- TOC entry 6125 (class 0 OID 230545)
-- Dependencies: 448
-- Data for Name: tbl_subsidiary; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_subsidiary VALUES (1, 1, 'subsidiary', '1234567890', 'PRIYA EXPRESS PRIVATE LIMITED', 'S2871', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (2, 1, 'subsidiary', '0987654321', 'VIJAY EXPRESS PRIVATE LIMITED', 'S2872', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (3, 1, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (4, 1, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (5, 2, 'subsidiary', '1234567890', 'PRIYA EXPRESS PRIVATE LIMITED', 'S2871', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (6, 2, 'subsidiary', '98765432', 'VIJAY EXPRESS PRIVATE LIMITED', 'S2872', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (7, 2, 'subsidiary', '123456789', 'ANAS EXPRESS PRIVATE LIMITED', 'S2871', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (8, 2, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (9, 2, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (10, 3, 'subsidiary', '1234567890', 'PRIYA EXPRESS PRIVATE LIMITED', 'S2871', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (11, 3, 'subsidiary', '098765432', 'VIJAY EXPRESS PRIVATE LIMITED', 'S2872', NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (12, 3, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO public.tbl_subsidiary VALUES (13, 3, 'associate', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);


--
-- TOC entry 5957 (class 0 OID 162924)
-- Dependencies: 216
-- Data for Name: tbl_user; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tbl_user VALUES (1, 'Farhan', 'farhan@gmail.com', '1234567890', 'c775e7b757ede630cd0aa1113bd102661ab38829ca52a6422ab782862f268646', true, true, 1, NULL, '2024-10-30 00:00:00', 1, '2024-10-30 00:00:00', true, NULL, 1);
INSERT INTO public.tbl_user VALUES (2, 'Pakshal', 'pakshal07@gmail.com', '9769279733', 'c775e7b757ede630cd0aa1113bd102661ab38829ca52a6422ab782862f268646', true, true, 1, NULL, '2024-11-16 15:35:36.460381', 1, '2024-11-16 15:35:36.460386', true, NULL, 1);


--
-- TOC entry 6266 (class 0 OID 0)
-- Dependencies: 433
-- Name: tbl_action_address_change_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_action_address_change_id_seq', 11, true);


--
-- TOC entry 6267 (class 0 OID 0)
-- Dependencies: 467
-- Name: tbl_action_general_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_action_general_id_seq', 1, true);


--
-- TOC entry 6268 (class 0 OID 0)
-- Dependencies: 416
-- Name: tbl_adt1_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_adt1_id_seq', 3, true);


--
-- TOC entry 6269 (class 0 OID 0)
-- Dependencies: 419
-- Name: tbl_adt3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_adt3_id_seq', 2, true);


--
-- TOC entry 6270 (class 0 OID 0)
-- Dependencies: 464
-- Name: tbl_aoc4_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_aoc4_id_seq', 1, true);


--
-- TOC entry 6271 (class 0 OID 0)
-- Dependencies: 456
-- Name: tbl_aoc4cfs_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_aoc4cfs_id_seq', 3, true);


--
-- TOC entry 6272 (class 0 OID 0)
-- Dependencies: 352
-- Name: tbl_aoc5_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_aoc5_id_seq', 1, true);


--
-- TOC entry 6273 (class 0 OID 0)
-- Dependencies: 383
-- Name: tbl_aoccuntnsolvencyform_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_aoccuntnsolvencyform_id_seq', 2, true);


--
-- TOC entry 6274 (class 0 OID 0)
-- Dependencies: 231
-- Name: tbl_api_log_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_api_log_id_seq', 17, true);


--
-- TOC entry 6275 (class 0 OID 0)
-- Dependencies: 242
-- Name: tbl_auditor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_auditor_id_seq', 3, true);


--
-- TOC entry 6276 (class 0 OID 0)
-- Dependencies: 244
-- Name: tbl_auditor_partner_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_auditor_partner_id_seq', 4, true);


--
-- TOC entry 6277 (class 0 OID 0)
-- Dependencies: 343
-- Name: tbl_ben2_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_ben2_id_seq', 3, true);


--
-- TOC entry 6278 (class 0 OID 0)
-- Dependencies: 459
-- Name: tbl_boardreport_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_boardreport_id_seq', 7, true);


--
-- TOC entry 6279 (class 0 OID 0)
-- Dependencies: 449
-- Name: tbl_cag_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_cag_id_seq', 6, true);


--
-- TOC entry 6280 (class 0 OID 0)
-- Dependencies: 369
-- Name: tbl_capital_child_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_capital_child_id_seq', 24, true);


--
-- TOC entry 6281 (class 0 OID 0)
-- Dependencies: 367
-- Name: tbl_capital_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_capital_id_seq', 9, true);


--
-- TOC entry 6282 (class 0 OID 0)
-- Dependencies: 401
-- Name: tbl_charge_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_charge_id_seq', 1, true);


--
-- TOC entry 6283 (class 0 OID 0)
-- Dependencies: 430
-- Name: tbl_chg1_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_chg1_id_seq', 1, true);


--
-- TOC entry 6284 (class 0 OID 0)
-- Dependencies: 453
-- Name: tbl_chg4_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_chg4_id_seq', 1, true);


--
-- TOC entry 6285 (class 0 OID 0)
-- Dependencies: 255
-- Name: tbl_chg6_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_chg6_id_seq', 3, true);


--
-- TOC entry 6286 (class 0 OID 0)
-- Dependencies: 258
-- Name: tbl_chg8_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_chg8_id_seq', 3, true);


--
-- TOC entry 6287 (class 0 OID 0)
-- Dependencies: 261
-- Name: tbl_chg9_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_chg9_id_seq', 2, true);


--
-- TOC entry 6288 (class 0 OID 0)
-- Dependencies: 221
-- Name: tbl_company_details_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_details_id_seq', 15, true);


--
-- TOC entry 6289 (class 0 OID 0)
-- Dependencies: 462
-- Name: tbl_company_director_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_director_id_seq', 59, true);


--
-- TOC entry 6290 (class 0 OID 0)
-- Dependencies: 223
-- Name: tbl_company_financial_details_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_financial_details_id_seq', 15, true);


--
-- TOC entry 6291 (class 0 OID 0)
-- Dependencies: 217
-- Name: tbl_company_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_id_seq', 15, true);


--
-- TOC entry 6292 (class 0 OID 0)
-- Dependencies: 477
-- Name: tbl_company_ioc_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_ioc_id_seq', 2, true);


--
-- TOC entry 6293 (class 0 OID 0)
-- Dependencies: 301
-- Name: tbl_company_notice_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_notice_id_seq', 2, true);


--
-- TOC entry 6294 (class 0 OID 0)
-- Dependencies: 225
-- Name: tbl_company_other_details_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_other_details_id_seq', 15, true);


--
-- TOC entry 6295 (class 0 OID 0)
-- Dependencies: 445
-- Name: tbl_company_otp_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_company_otp_id_seq', 16, true);


--
-- TOC entry 6296 (class 0 OID 0)
-- Dependencies: 240
-- Name: tbl_debenture_details_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_debenture_details_id_seq', 2, true);


--
-- TOC entry 6297 (class 0 OID 0)
-- Dependencies: 239
-- Name: tbl_debenture_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_debenture_id_seq', 2, true);


--
-- TOC entry 6298 (class 0 OID 0)
-- Dependencies: 279
-- Name: tbl_dir11_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir11_id_seq', 1, true);


--
-- TOC entry 6299 (class 0 OID 0)
-- Dependencies: 282
-- Name: tbl_dir12_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir12_id_seq', 2, true);


--
-- TOC entry 6300 (class 0 OID 0)
-- Dependencies: 267
-- Name: tbl_dir3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir3_id_seq', 1, true);


--
-- TOC entry 6301 (class 0 OID 0)
-- Dependencies: 270
-- Name: tbl_dir5_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir5_id_seq', 1, true);


--
-- TOC entry 6302 (class 0 OID 0)
-- Dependencies: 273
-- Name: tbl_dir6_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir6_id_seq', 1, true);


--
-- TOC entry 6303 (class 0 OID 0)
-- Dependencies: 276
-- Name: tbl_dir9_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dir9_id_seq', 1, true);


--
-- TOC entry 6304 (class 0 OID 0)
-- Dependencies: 472
-- Name: tbl_director_appointment_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_director_appointment_id_seq', 3, true);


--
-- TOC entry 6305 (class 0 OID 0)
-- Dependencies: 227
-- Name: tbl_director_details_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_director_details_id_seq', 22, true);


--
-- TOC entry 6306 (class 0 OID 0)
-- Dependencies: 219
-- Name: tbl_director_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_director_id_seq', 22, true);


--
-- TOC entry 6307 (class 0 OID 0)
-- Dependencies: 443
-- Name: tbl_dms_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dms_id_seq', 4, true);


--
-- TOC entry 6308 (class 0 OID 0)
-- Dependencies: 264
-- Name: tbl_dpt3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dpt3_id_seq', 1, true);


--
-- TOC entry 6309 (class 0 OID 0)
-- Dependencies: 252
-- Name: tbl_dpt4_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_dpt4_id_seq', 11, true);


--
-- TOC entry 6310 (class 0 OID 0)
-- Dependencies: 389
-- Name: tbl_form11_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form11_id_seq', 8, true);


--
-- TOC entry 6311 (class 0 OID 0)
-- Dependencies: 395
-- Name: tbl_form12_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form12_id_seq', 1, true);


--
-- TOC entry 6312 (class 0 OID 0)
-- Dependencies: 398
-- Name: tbl_form15_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form15_id_seq', 3, true);


--
-- TOC entry 6313 (class 0 OID 0)
-- Dependencies: 410
-- Name: tbl_form22_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form22_id_seq', 1, true);


--
-- TOC entry 6314 (class 0 OID 0)
-- Dependencies: 404
-- Name: tbl_form23_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form23_id_seq', 3, true);


--
-- TOC entry 6315 (class 0 OID 0)
-- Dependencies: 407
-- Name: tbl_form24_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form24_id_seq', 1, true);


--
-- TOC entry 6316 (class 0 OID 0)
-- Dependencies: 371
-- Name: tbl_form3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form3_id_seq', 2, true);


--
-- TOC entry 6317 (class 0 OID 0)
-- Dependencies: 349
-- Name: tbl_form4_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form4_id_seq', 2, true);


--
-- TOC entry 6318 (class 0 OID 0)
-- Dependencies: 377
-- Name: tbl_form5_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_form5_id_seq', 2, true);


--
-- TOC entry 6319 (class 0 OID 0)
-- Dependencies: 422
-- Name: tbl_gnl1_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_gnl1_id_seq', 1, true);


--
-- TOC entry 6320 (class 0 OID 0)
-- Dependencies: 327
-- Name: tbl_gnl2_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_gnl2_id_seq', 1, true);


--
-- TOC entry 6321 (class 0 OID 0)
-- Dependencies: 330
-- Name: tbl_gnl3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_gnl3_id_seq', 3, true);


--
-- TOC entry 6322 (class 0 OID 0)
-- Dependencies: 392
-- Name: tbl_iepf2_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_iepf2_id_seq', 2, true);


--
-- TOC entry 6323 (class 0 OID 0)
-- Dependencies: 373
-- Name: tbl_iepf5_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_iepf5_id_seq', 3, true);


--
-- TOC entry 6324 (class 0 OID 0)
-- Dependencies: 386
-- Name: tbl_inc12_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc12_id_seq', 1, true);


--
-- TOC entry 6325 (class 0 OID 0)
-- Dependencies: 304
-- Name: tbl_inc20a_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc20a_id_seq', 1, true);


--
-- TOC entry 6326 (class 0 OID 0)
-- Dependencies: 285
-- Name: tbl_inc22_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc22_id_seq', 1, true);


--
-- TOC entry 6327 (class 0 OID 0)
-- Dependencies: 380
-- Name: tbl_inc23_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc23_id_seq', 2, true);


--
-- TOC entry 6328 (class 0 OID 0)
-- Dependencies: 307
-- Name: tbl_inc28_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc28_id_seq', 2, true);


--
-- TOC entry 6329 (class 0 OID 0)
-- Dependencies: 413
-- Name: tbl_inc4_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_inc4_id_seq', 1, true);


--
-- TOC entry 6330 (class 0 OID 0)
-- Dependencies: 475
-- Name: tbl_litigation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_litigation_id_seq', 4, true);


--
-- TOC entry 6331 (class 0 OID 0)
-- Dependencies: 312
-- Name: tbl_meeting_circulation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_meeting_circulation_id_seq', 22, true);


--
-- TOC entry 6332 (class 0 OID 0)
-- Dependencies: 314
-- Name: tbl_meeting_communicate_comment_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_meeting_communicate_comment_id_seq', 6, true);


--
-- TOC entry 6333 (class 0 OID 0)
-- Dependencies: 319
-- Name: tbl_meeting_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_meeting_id_seq', 7, true);


--
-- TOC entry 6334 (class 0 OID 0)
-- Dependencies: 435
-- Name: tbl_meeting_resolution_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_meeting_resolution_id_seq', 7, true);


--
-- TOC entry 6335 (class 0 OID 0)
-- Dependencies: 310
-- Name: tbl_meeting_special_invitee_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_meeting_special_invitee_id_seq', 5, true);


--
-- TOC entry 6336 (class 0 OID 0)
-- Dependencies: 321
-- Name: tbl_mgt14_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mgt14_id_seq', 3, true);


--
-- TOC entry 6337 (class 0 OID 0)
-- Dependencies: 340
-- Name: tbl_mgt6_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mgt6_id_seq', 1, true);


--
-- TOC entry 6338 (class 0 OID 0)
-- Dependencies: 469
-- Name: tbl_mgt7a_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mgt7a_id_seq', 1, true);


--
-- TOC entry 6339 (class 0 OID 0)
-- Dependencies: 439
-- Name: tbl_mgt8_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mgt8_id_seq', 1, true);


--
-- TOC entry 6340 (class 0 OID 0)
-- Dependencies: 437
-- Name: tbl_mgt9_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mgt9_id_seq', 2, true);


--
-- TOC entry 6341 (class 0 OID 0)
-- Dependencies: 295
-- Name: tbl_mr1_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_mr1_id_seq', 1, true);


--
-- TOC entry 6342 (class 0 OID 0)
-- Dependencies: 346
-- Name: tbl_msme_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_msme_id_seq', 2, true);


--
-- TOC entry 6343 (class 0 OID 0)
-- Dependencies: 249
-- Name: tbl_other_auditor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_other_auditor_id_seq', 5, true);


--
-- TOC entry 6344 (class 0 OID 0)
-- Dependencies: 334
-- Name: tbl_pas3_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_pas3_id_seq', 2, true);


--
-- TOC entry 6345 (class 0 OID 0)
-- Dependencies: 324
-- Name: tbl_pas6_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_pas6_id_seq', 3, true);


--
-- TOC entry 6346 (class 0 OID 0)
-- Dependencies: 451
-- Name: tbl_reservation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_reservation_id_seq', 3, true);


--
-- TOC entry 6347 (class 0 OID 0)
-- Dependencies: 298
-- Name: tbl_resolution_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_resolution_id_seq', 5, true);


--
-- TOC entry 6348 (class 0 OID 0)
-- Dependencies: 355
-- Name: tbl_run_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_run_id_seq', 1, true);


--
-- TOC entry 6349 (class 0 OID 0)
-- Dependencies: 364
-- Name: tbl_runllp_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_runllp_id_seq', 2, true);


--
-- TOC entry 6350 (class 0 OID 0)
-- Dependencies: 361
-- Name: tbl_sh11_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh11_id_seq', 11, true);


--
-- TOC entry 6351 (class 0 OID 0)
-- Dependencies: 288
-- Name: tbl_sh7_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh7_id_seq', 3, true);


--
-- TOC entry 6352 (class 0 OID 0)
-- Dependencies: 291
-- Name: tbl_sh7_share_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh7_share_id_seq', 8, true);


--
-- TOC entry 6353 (class 0 OID 0)
-- Dependencies: 293
-- Name: tbl_sh7_structure_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh7_structure_id_seq', 6, true);


--
-- TOC entry 6354 (class 0 OID 0)
-- Dependencies: 358
-- Name: tbl_sh8_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh8_id_seq', 1, true);


--
-- TOC entry 6355 (class 0 OID 0)
-- Dependencies: 337
-- Name: tbl_sh9_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_sh9_id_seq', 2, true);


--
-- TOC entry 6356 (class 0 OID 0)
-- Dependencies: 235
-- Name: tbl_shareholder_detail_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_shareholder_detail_id_seq', 3, true);


--
-- TOC entry 6357 (class 0 OID 0)
-- Dependencies: 233
-- Name: tbl_shareholder_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_shareholder_id_seq', 3, true);


--
-- TOC entry 6358 (class 0 OID 0)
-- Dependencies: 425
-- Name: tbl_shareholder_management_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_shareholder_management_id_seq', 3, true);


--
-- TOC entry 6359 (class 0 OID 0)
-- Dependencies: 428
-- Name: tbl_shareholder_management_owner_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_shareholder_management_owner_id_seq', 3, true);


--
-- TOC entry 6360 (class 0 OID 0)
-- Dependencies: 316
-- Name: tbl_stk2_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_stk2_id_seq', 2, true);


--
-- TOC entry 6361 (class 0 OID 0)
-- Dependencies: 447
-- Name: tbl_subsidiary_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_subsidiary_id_seq', 13, true);


--
-- TOC entry 6362 (class 0 OID 0)
-- Dependencies: 215
-- Name: tbl_user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_user_id_seq', 2, true);


--
-- TOC entry 5708 (class 2606 OID 230311)
-- Name: tbl_action_address_change tbl_action_address_change_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_address_change
    ADD CONSTRAINT tbl_action_address_change_pkey PRIMARY KEY (id);


--
-- TOC entry 5734 (class 2606 OID 231280)
-- Name: tbl_action_general tbl_action_general_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_general
    ADD CONSTRAINT tbl_action_general_pkey PRIMARY KEY (id);


--
-- TOC entry 5696 (class 2606 OID 223676)
-- Name: tbl_adt1 tbl_adt1_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_adt1
    ADD CONSTRAINT tbl_adt1_pkey PRIMARY KEY (id);


--
-- TOC entry 5698 (class 2606 OID 223752)
-- Name: tbl_adt3 tbl_adt3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_adt3
    ADD CONSTRAINT tbl_adt3_pkey PRIMARY KEY (id);


--
-- TOC entry 5732 (class 2606 OID 230921)
-- Name: tbl_aoc4 tbl_aoc4_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc4
    ADD CONSTRAINT tbl_aoc4_pkey PRIMARY KEY (id);


--
-- TOC entry 5728 (class 2606 OID 230654)
-- Name: tbl_aoc4cfs tbl_aoc4cfs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc4cfs
    ADD CONSTRAINT tbl_aoc4cfs_pkey PRIMARY KEY (id);


--
-- TOC entry 5652 (class 2606 OID 221571)
-- Name: tbl_aoc5 tbl_aoc5_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoc5
    ADD CONSTRAINT tbl_aoc5_pkey PRIMARY KEY (id);


--
-- TOC entry 5674 (class 2606 OID 222383)
-- Name: tbl_aoccuntnsolvencyform tbl_aoccuntnsolvencyform_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_aoccuntnsolvencyform
    ADD CONSTRAINT tbl_aoccuntnsolvencyform_pkey PRIMARY KEY (id);


--
-- TOC entry 5566 (class 2606 OID 163732)
-- Name: tbl_api_log tbl_api_log_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_api_log
    ADD CONSTRAINT tbl_api_log_pkey PRIMARY KEY (id);


--
-- TOC entry 5578 (class 2606 OID 180258)
-- Name: tbl_auditor_partner tbl_auditor_partner_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_auditor_partner
    ADD CONSTRAINT tbl_auditor_partner_pkey PRIMARY KEY (id);


--
-- TOC entry 5576 (class 2606 OID 180249)
-- Name: tbl_auditor tbl_auditor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_auditor
    ADD CONSTRAINT tbl_auditor_pkey PRIMARY KEY (id);


--
-- TOC entry 5646 (class 2606 OID 221463)
-- Name: tbl_ben2 tbl_ben2_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_ben2
    ADD CONSTRAINT tbl_ben2_pkey PRIMARY KEY (id);


--
-- TOC entry 5730 (class 2606 OID 230772)
-- Name: tbl_boardreport tbl_boardreport_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_boardreport
    ADD CONSTRAINT tbl_boardreport_pkey PRIMARY KEY (id);


--
-- TOC entry 5722 (class 2606 OID 230593)
-- Name: tbl_cag tbl_cag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_cag
    ADD CONSTRAINT tbl_cag_pkey PRIMARY KEY (id);


--
-- TOC entry 5664 (class 2606 OID 221898)
-- Name: tbl_capital_child tbl_capital_child_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_capital_child
    ADD CONSTRAINT tbl_capital_child_pkey PRIMARY KEY (id);


--
-- TOC entry 5662 (class 2606 OID 221884)
-- Name: tbl_capital tbl_capital_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_capital
    ADD CONSTRAINT tbl_capital_pkey PRIMARY KEY (id);


--
-- TOC entry 5686 (class 2606 OID 223291)
-- Name: tbl_charge tbl_charge_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_charge
    ADD CONSTRAINT tbl_charge_pkey PRIMARY KEY (id);


--
-- TOC entry 5706 (class 2606 OID 230264)
-- Name: tbl_chg1 tbl_chg1_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg1
    ADD CONSTRAINT tbl_chg1_pkey PRIMARY KEY (id);


--
-- TOC entry 5726 (class 2606 OID 230640)
-- Name: tbl_chg4 tbl_chg4_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg4
    ADD CONSTRAINT tbl_chg4_pkey PRIMARY KEY (id);


--
-- TOC entry 5584 (class 2606 OID 180578)
-- Name: tbl_chg6 tbl_chg6_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg6
    ADD CONSTRAINT tbl_chg6_pkey PRIMARY KEY (id);


--
-- TOC entry 5586 (class 2606 OID 180599)
-- Name: tbl_chg8 tbl_chg8_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg8
    ADD CONSTRAINT tbl_chg8_pkey PRIMARY KEY (id);


--
-- TOC entry 5588 (class 2606 OID 180626)
-- Name: tbl_chg9 tbl_chg9_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_chg9
    ADD CONSTRAINT tbl_chg9_pkey PRIMARY KEY (id);


--
-- TOC entry 5558 (class 2606 OID 163014)
-- Name: tbl_company_details tbl_company_details_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_details
    ADD CONSTRAINT tbl_company_details_pkey PRIMARY KEY (id);


--
-- TOC entry 5560 (class 2606 OID 163023)
-- Name: tbl_company_financial_details tbl_company_financial_details_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_financial_details
    ADD CONSTRAINT tbl_company_financial_details_pkey PRIMARY KEY (id);


--
-- TOC entry 5742 (class 2606 OID 231976)
-- Name: tbl_company_ioc tbl_company_ioc_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_ioc
    ADD CONSTRAINT tbl_company_ioc_pkey PRIMARY KEY (id);


--
-- TOC entry 5616 (class 2606 OID 196522)
-- Name: tbl_company_notice tbl_company_notice_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_notice
    ADD CONSTRAINT tbl_company_notice_pkey PRIMARY KEY (id);


--
-- TOC entry 5562 (class 2606 OID 163032)
-- Name: tbl_company_other_details tbl_company_other_details_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_other_details
    ADD CONSTRAINT tbl_company_other_details_pkey PRIMARY KEY (id);


--
-- TOC entry 5718 (class 2606 OID 230543)
-- Name: tbl_company_otp tbl_company_otp_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company_otp
    ADD CONSTRAINT tbl_company_otp_pkey PRIMARY KEY (id);


--
-- TOC entry 5554 (class 2606 OID 162996)
-- Name: tbl_company tbl_company_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_company
    ADD CONSTRAINT tbl_company_pkey PRIMARY KEY (id);


--
-- TOC entry 5574 (class 2606 OID 180111)
-- Name: tbl_debenture_details tbl_debenture_details_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_debenture_details
    ADD CONSTRAINT tbl_debenture_details_pkey PRIMARY KEY (id);


--
-- TOC entry 5572 (class 2606 OID 180102)
-- Name: tbl_debenture tbl_debenture_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_debenture
    ADD CONSTRAINT tbl_debenture_pkey PRIMARY KEY (id);


--
-- TOC entry 5600 (class 2606 OID 180825)
-- Name: tbl_dir11 tbl_dir11_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir11
    ADD CONSTRAINT tbl_dir11_pkey PRIMARY KEY (id);


--
-- TOC entry 5602 (class 2606 OID 180854)
-- Name: tbl_dir12 tbl_dir12_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir12
    ADD CONSTRAINT tbl_dir12_pkey PRIMARY KEY (id);


--
-- TOC entry 5592 (class 2606 OID 180731)
-- Name: tbl_dir3 tbl_dir3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir3
    ADD CONSTRAINT tbl_dir3_pkey PRIMARY KEY (id);


--
-- TOC entry 5594 (class 2606 OID 180746)
-- Name: tbl_dir5 tbl_dir5_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir5
    ADD CONSTRAINT tbl_dir5_pkey PRIMARY KEY (id);


--
-- TOC entry 5596 (class 2606 OID 180773)
-- Name: tbl_dir6 tbl_dir6_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir6
    ADD CONSTRAINT tbl_dir6_pkey PRIMARY KEY (id);


--
-- TOC entry 5598 (class 2606 OID 180811)
-- Name: tbl_dir9 tbl_dir9_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dir9
    ADD CONSTRAINT tbl_dir9_pkey PRIMARY KEY (id);


--
-- TOC entry 5738 (class 2606 OID 231930)
-- Name: tbl_action_director_appointment tbl_director_appointment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_action_director_appointment
    ADD CONSTRAINT tbl_director_appointment_pkey PRIMARY KEY (id);


--
-- TOC entry 5564 (class 2606 OID 163041)
-- Name: tbl_director_details tbl_director_details_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_director_details
    ADD CONSTRAINT tbl_director_details_pkey PRIMARY KEY (id);


--
-- TOC entry 5556 (class 2606 OID 163005)
-- Name: tbl_director tbl_director_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_director
    ADD CONSTRAINT tbl_director_pkey PRIMARY KEY (id);


--
-- TOC entry 5716 (class 2606 OID 230472)
-- Name: tbl_dms tbl_dms_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dms
    ADD CONSTRAINT tbl_dms_pkey PRIMARY KEY (id);


--
-- TOC entry 5590 (class 2606 OID 180717)
-- Name: tbl_dpt3 tbl_dpt3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dpt3
    ADD CONSTRAINT tbl_dpt3_pkey PRIMARY KEY (id);


--
-- TOC entry 5582 (class 2606 OID 180446)
-- Name: tbl_dpt4 tbl_dpt4_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_dpt4
    ADD CONSTRAINT tbl_dpt4_pkey PRIMARY KEY (id);


--
-- TOC entry 5682 (class 2606 OID 222886)
-- Name: tbl_form12 tbl_form12_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form12
    ADD CONSTRAINT tbl_form12_pkey PRIMARY KEY (id);


--
-- TOC entry 5684 (class 2606 OID 223166)
-- Name: tbl_form15 tbl_form15_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form15
    ADD CONSTRAINT tbl_form15_pkey PRIMARY KEY (id);


--
-- TOC entry 5692 (class 2606 OID 223446)
-- Name: tbl_form22 tbl_form22_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form22
    ADD CONSTRAINT tbl_form22_pkey PRIMARY KEY (id);


--
-- TOC entry 5688 (class 2606 OID 223318)
-- Name: tbl_form23 tbl_form23_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form23
    ADD CONSTRAINT tbl_form23_pkey PRIMARY KEY (id);


--
-- TOC entry 5690 (class 2606 OID 223422)
-- Name: tbl_form24 tbl_form24_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form24
    ADD CONSTRAINT tbl_form24_pkey PRIMARY KEY (id);


--
-- TOC entry 5666 (class 2606 OID 221988)
-- Name: tbl_form3 tbl_form3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form3
    ADD CONSTRAINT tbl_form3_pkey PRIMARY KEY (id);


--
-- TOC entry 5650 (class 2606 OID 221529)
-- Name: tbl_form4 tbl_form4_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form4
    ADD CONSTRAINT tbl_form4_pkey PRIMARY KEY (id);


--
-- TOC entry 5670 (class 2606 OID 222135)
-- Name: tbl_form5 tbl_form5_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form5
    ADD CONSTRAINT tbl_form5_pkey PRIMARY KEY (id);


--
-- TOC entry 5700 (class 2606 OID 223831)
-- Name: tbl_gnl1 tbl_gnl1_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl1
    ADD CONSTRAINT tbl_gnl1_pkey PRIMARY KEY (id);


--
-- TOC entry 5636 (class 2606 OID 221128)
-- Name: tbl_gnl2 tbl_gnl2_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl2
    ADD CONSTRAINT tbl_gnl2_pkey PRIMARY KEY (id);


--
-- TOC entry 5638 (class 2606 OID 221169)
-- Name: tbl_gnl3 tbl_gnl3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gnl3
    ADD CONSTRAINT tbl_gnl3_pkey PRIMARY KEY (id);


--
-- TOC entry 5680 (class 2606 OID 222818)
-- Name: tbl_iepf2 tbl_iepf2_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_iepf2
    ADD CONSTRAINT tbl_iepf2_pkey PRIMARY KEY (id);


--
-- TOC entry 5668 (class 2606 OID 222054)
-- Name: tbl_iepf5 tbl_iepf5_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_iepf5
    ADD CONSTRAINT tbl_iepf5_pkey PRIMARY KEY (id);


--
-- TOC entry 5676 (class 2606 OID 222498)
-- Name: tbl_inc12 tbl_inc12_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc12
    ADD CONSTRAINT tbl_inc12_pkey PRIMARY KEY (id);


--
-- TOC entry 5618 (class 2606 OID 196626)
-- Name: tbl_inc20a tbl_inc20a_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc20a
    ADD CONSTRAINT tbl_inc20a_pkey PRIMARY KEY (id);


--
-- TOC entry 5604 (class 2606 OID 180954)
-- Name: tbl_inc22 tbl_inc22_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc22
    ADD CONSTRAINT tbl_inc22_pkey PRIMARY KEY (id);


--
-- TOC entry 5672 (class 2606 OID 222354)
-- Name: tbl_inc23 tbl_inc23_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc23
    ADD CONSTRAINT tbl_inc23_pkey PRIMARY KEY (id);


--
-- TOC entry 5678 (class 2606 OID 222789)
-- Name: tbl_form11 tbl_inc24_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_form11
    ADD CONSTRAINT tbl_inc24_pkey PRIMARY KEY (id);


--
-- TOC entry 5620 (class 2606 OID 196723)
-- Name: tbl_inc28 tbl_inc28_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc28
    ADD CONSTRAINT tbl_inc28_pkey PRIMARY KEY (id);


--
-- TOC entry 5694 (class 2606 OID 223595)
-- Name: tbl_inc4 tbl_inc4_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_inc4
    ADD CONSTRAINT tbl_inc4_pkey PRIMARY KEY (id);


--
-- TOC entry 5740 (class 2606 OID 231963)
-- Name: tbl_litigation tbl_litigation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_litigation
    ADD CONSTRAINT tbl_litigation_pkey PRIMARY KEY (id);


--
-- TOC entry 5624 (class 2606 OID 197014)
-- Name: tbl_meeting_circulation tbl_meeting_circulation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_circulation
    ADD CONSTRAINT tbl_meeting_circulation_pkey PRIMARY KEY (id);


--
-- TOC entry 5626 (class 2606 OID 197023)
-- Name: tbl_meeting_communicate_comment tbl_meeting_communicate_comment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_communicate_comment
    ADD CONSTRAINT tbl_meeting_communicate_comment_pkey PRIMARY KEY (id);


--
-- TOC entry 5630 (class 2606 OID 204788)
-- Name: tbl_meeting tbl_meeting_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting
    ADD CONSTRAINT tbl_meeting_pkey PRIMARY KEY (id);


--
-- TOC entry 5710 (class 2606 OID 230322)
-- Name: tbl_meeting_resolution tbl_meeting_resolution_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_resolution
    ADD CONSTRAINT tbl_meeting_resolution_pkey PRIMARY KEY (id);


--
-- TOC entry 5622 (class 2606 OID 197005)
-- Name: tbl_meeting_special_invitee tbl_meeting_special_invitee_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_meeting_special_invitee
    ADD CONSTRAINT tbl_meeting_special_invitee_pkey PRIMARY KEY (id);


--
-- TOC entry 5632 (class 2606 OID 205005)
-- Name: tbl_mgt14 tbl_mgt14_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt14
    ADD CONSTRAINT tbl_mgt14_pkey PRIMARY KEY (id);


--
-- TOC entry 5644 (class 2606 OID 221395)
-- Name: tbl_mgt6 tbl_mgt6_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt6
    ADD CONSTRAINT tbl_mgt6_pkey PRIMARY KEY (id);


--
-- TOC entry 5736 (class 2606 OID 231861)
-- Name: tbl_mgt7a tbl_mgt7a_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt7a
    ADD CONSTRAINT tbl_mgt7a_pkey PRIMARY KEY (id);


--
-- TOC entry 5714 (class 2606 OID 230438)
-- Name: tbl_mgt8 tbl_mgt8_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt8
    ADD CONSTRAINT tbl_mgt8_pkey PRIMARY KEY (id);


--
-- TOC entry 5712 (class 2606 OID 230428)
-- Name: tbl_mgt9 tbl_mgt9_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mgt9
    ADD CONSTRAINT tbl_mgt9_pkey PRIMARY KEY (id);


--
-- TOC entry 5612 (class 2606 OID 181140)
-- Name: tbl_mr1 tbl_mr1_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_mr1
    ADD CONSTRAINT tbl_mr1_pkey PRIMARY KEY (id);


--
-- TOC entry 5648 (class 2606 OID 221513)
-- Name: tbl_msme tbl_msme_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_msme
    ADD CONSTRAINT tbl_msme_pkey PRIMARY KEY (id);


--
-- TOC entry 5580 (class 2606 OID 180313)
-- Name: tbl_other_auditor tbl_other_auditor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_other_auditor
    ADD CONSTRAINT tbl_other_auditor_pkey PRIMARY KEY (id);


--
-- TOC entry 5640 (class 2606 OID 221258)
-- Name: tbl_pas3 tbl_pas3_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_pas3
    ADD CONSTRAINT tbl_pas3_pkey PRIMARY KEY (id);


--
-- TOC entry 5634 (class 2606 OID 205277)
-- Name: tbl_pas6 tbl_ps6_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_pas6
    ADD CONSTRAINT tbl_ps6_pkey PRIMARY KEY (id);


--
-- TOC entry 5724 (class 2606 OID 230602)
-- Name: tbl_reservation tbl_reservation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_reservation
    ADD CONSTRAINT tbl_reservation_pkey PRIMARY KEY (id);


--
-- TOC entry 5614 (class 2606 OID 188256)
-- Name: tbl_resolution tbl_resolution_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_resolution
    ADD CONSTRAINT tbl_resolution_pkey PRIMARY KEY (id);


--
-- TOC entry 5654 (class 2606 OID 221647)
-- Name: tbl_run tbl_run_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_run
    ADD CONSTRAINT tbl_run_pkey PRIMARY KEY (id);


--
-- TOC entry 5660 (class 2606 OID 221869)
-- Name: tbl_runllp tbl_runllp_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_runllp
    ADD CONSTRAINT tbl_runllp_pkey PRIMARY KEY (id);


--
-- TOC entry 5658 (class 2606 OID 221819)
-- Name: tbl_sh11 tbl_sh11_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh11
    ADD CONSTRAINT tbl_sh11_pkey PRIMARY KEY (id);


--
-- TOC entry 5606 (class 2606 OID 181073)
-- Name: tbl_sh7 tbl_sh7_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7
    ADD CONSTRAINT tbl_sh7_pkey PRIMARY KEY (id);


--
-- TOC entry 5608 (class 2606 OID 181100)
-- Name: tbl_sh7_share tbl_sh7_share_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7_share
    ADD CONSTRAINT tbl_sh7_share_pkey PRIMARY KEY (id);


--
-- TOC entry 5610 (class 2606 OID 181109)
-- Name: tbl_sh7_structure tbl_sh7_structure_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh7_structure
    ADD CONSTRAINT tbl_sh7_structure_pkey PRIMARY KEY (id);


--
-- TOC entry 5656 (class 2606 OID 221732)
-- Name: tbl_sh8 tbl_sh8_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh8
    ADD CONSTRAINT tbl_sh8_pkey PRIMARY KEY (id);


--
-- TOC entry 5642 (class 2606 OID 221365)
-- Name: tbl_sh9 tbl_sh9_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_sh9
    ADD CONSTRAINT tbl_sh9_pkey PRIMARY KEY (id);


--
-- TOC entry 5570 (class 2606 OID 180073)
-- Name: tbl_shareholder_details tbl_shareholder_detail_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_details
    ADD CONSTRAINT tbl_shareholder_detail_pkey PRIMARY KEY (id);


--
-- TOC entry 5704 (class 2606 OID 223859)
-- Name: tbl_shareholder_management_owner tbl_shareholder_management_owner_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_management_owner
    ADD CONSTRAINT tbl_shareholder_management_owner_pkey PRIMARY KEY (id);


--
-- TOC entry 5702 (class 2606 OID 223845)
-- Name: tbl_shareholder_management tbl_shareholder_management_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder_management
    ADD CONSTRAINT tbl_shareholder_management_pkey PRIMARY KEY (id);


--
-- TOC entry 5568 (class 2606 OID 180064)
-- Name: tbl_shareholder tbl_shareholder_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_shareholder
    ADD CONSTRAINT tbl_shareholder_pkey PRIMARY KEY (id);


--
-- TOC entry 5628 (class 2606 OID 204680)
-- Name: tbl_stk2 tbl_stk2_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_stk2
    ADD CONSTRAINT tbl_stk2_pkey PRIMARY KEY (id);


--
-- TOC entry 5720 (class 2606 OID 230552)
-- Name: tbl_subsidiary tbl_subsidiary_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_subsidiary
    ADD CONSTRAINT tbl_subsidiary_pkey PRIMARY KEY (id);


--
-- TOC entry 5552 (class 2606 OID 162931)
-- Name: tbl_user tbl_user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_user
    ADD CONSTRAINT tbl_user_pkey PRIMARY KEY (id);


--
-- TOC entry 6155 (class 0 OID 0)
-- Dependencies: 434
-- Name: TABLE tbl_action_address_change; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_action_address_change TO postgres;


--
-- TOC entry 6157 (class 0 OID 0)
-- Dependencies: 433
-- Name: SEQUENCE tbl_action_address_change_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_action_address_change_id_seq TO postgres;


--
-- TOC entry 6158 (class 0 OID 0)
-- Dependencies: 468
-- Name: TABLE tbl_action_general; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_action_general TO postgres;


--
-- TOC entry 6160 (class 0 OID 0)
-- Dependencies: 467
-- Name: SEQUENCE tbl_action_general_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_action_general_id_seq TO postgres;


--
-- TOC entry 6182 (class 0 OID 0)
-- Dependencies: 463
-- Name: TABLE tbl_company_director; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_company_director TO postgres;


--
-- TOC entry 6184 (class 0 OID 0)
-- Dependencies: 462
-- Name: SEQUENCE tbl_company_director_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_company_director_id_seq TO postgres;


--
-- TOC entry 6187 (class 0 OID 0)
-- Dependencies: 478
-- Name: TABLE tbl_company_ioc; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_company_ioc TO postgres;


--
-- TOC entry 6189 (class 0 OID 0)
-- Dependencies: 477
-- Name: SEQUENCE tbl_company_ioc_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_company_ioc_id_seq TO postgres;


--
-- TOC entry 6192 (class 0 OID 0)
-- Dependencies: 446
-- Name: TABLE tbl_company_otp; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_company_otp TO postgres;


--
-- TOC entry 6194 (class 0 OID 0)
-- Dependencies: 445
-- Name: SEQUENCE tbl_company_otp_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_company_otp_id_seq TO postgres;


--
-- TOC entry 6206 (class 0 OID 0)
-- Dependencies: 444
-- Name: TABLE tbl_dms; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_dms TO postgres;


--
-- TOC entry 6208 (class 0 OID 0)
-- Dependencies: 443
-- Name: SEQUENCE tbl_dms_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_dms_id_seq TO postgres;


--
-- TOC entry 6235 (class 0 OID 0)
-- Dependencies: 436
-- Name: TABLE tbl_meeting_resolution; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,REFERENCES,DELETE,TRIGGER,TRUNCATE,UPDATE ON TABLE public.tbl_meeting_resolution TO postgres;


--
-- TOC entry 6237 (class 0 OID 0)
-- Dependencies: 435
-- Name: SEQUENCE tbl_meeting_resolution_id_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public.tbl_meeting_resolution_id_seq TO postgres;


-- Completed on 2025-04-12 16:42:07

--
-- PostgreSQL database dump complete
--




-- =====================================================================
-- ADDITIONS: Authentication & Login Tracking schema (fixed 2025-11-21)
-- This section creates/repairs the objects used by Comply Crafter API:
--   - tbl_user_details
--   - vw_user_details
--   - tbl_login_tracker
-- Run on a new database OR an existing one (uses IF NOT EXISTS).
-- =====================================================================

-- 1) Core user table ---------------------------------------------------
CREATE TABLE IF NOT EXISTS public.tbl_user_details (
    id SERIAL PRIMARY KEY
);

ALTER TABLE public.tbl_user_details
    ADD COLUMN IF NOT EXISTS full_name                   VARCHAR(255),
    ADD COLUMN IF NOT EXISTS first_name                  VARCHAR(150),
    ADD COLUMN IF NOT EXISTS last_name                   VARCHAR(150),
    ADD COLUMN IF NOT EXISTS display_name                VARCHAR(255),
    ADD COLUMN IF NOT EXISTS email_id                    VARCHAR(255),
    ADD COLUMN IF NOT EXISTS is_email_verified           BOOLEAN DEFAULT FALSE,
    ADD COLUMN IF NOT EXISTS mobile_number               VARCHAR(20),
    ADD COLUMN IF NOT EXISTS is_mobile_verified          BOOLEAN DEFAULT FALSE,
    ADD COLUMN IF NOT EXISTS alternate_number            VARCHAR(20),
    ADD COLUMN IF NOT EXISTS firm_name                   VARCHAR(255),
    ADD COLUMN IF NOT EXISTS profession                  VARCHAR(100),
    ADD COLUMN IF NOT EXISTS profession_other            VARCHAR(100),
    ADD COLUMN IF NOT EXISTS is_ccpinset                 BOOLEAN DEFAULT FALSE,
    ADD COLUMN IF NOT EXISTS ccpin                       VARCHAR(10),
    ADD COLUMN IF NOT EXISTS parent_user_id              INTEGER DEFAULT 0,
    ADD COLUMN IF NOT EXISTS is_sub_user                 BOOLEAN DEFAULT FALSE,
    ADD COLUMN IF NOT EXISTS password                    VARCHAR(500),
    ADD COLUMN IF NOT EXISTS last_password_changed_date  TIMESTAMP,
    ADD COLUMN IF NOT EXISTS last_ccpin_changed_date     TIMESTAMP,
    ADD COLUMN IF NOT EXISTS signup_by                   VARCHAR(50),
    ADD COLUMN IF NOT EXISTS role                        INTEGER DEFAULT 1,
    ADD COLUMN IF NOT EXISTS created_by                  INTEGER DEFAULT 0,
    ADD COLUMN IF NOT EXISTS created_on                  TIMESTAMP DEFAULT NOW(),
    ADD COLUMN IF NOT EXISTS updated_by                  INTEGER DEFAULT 0,
    ADD COLUMN IF NOT EXISTS updated_on                  TIMESTAMP DEFAULT NOW(),
    ADD COLUMN IF NOT EXISTS is_deleted                  BOOLEAN DEFAULT FALSE,
    ADD COLUMN IF NOT EXISTS deleted_on                  TIMESTAMP,
    ADD COLUMN IF NOT EXISTS is_active                   BOOLEAN DEFAULT TRUE;

-- Unique index for email (if not already present)
DO $$
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM pg_class c
        JOIN pg_namespace n ON n.oid = c.relnamespace
        WHERE c.relkind = 'i'
          AND c.relname = 'ux_tbl_user_details_email_id'
          AND n.nspname = 'public'
    ) THEN
        CREATE UNIQUE INDEX ux_tbl_user_details_email_id
            ON public.tbl_user_details (email_id);
    END IF;
END$$;

-- 2) View used by UserRepository (vw_user_details) ---------------------
CREATE OR REPLACE VIEW public.vw_user_details AS
SELECT
    id,
    full_name,
    first_name,
    last_name,
    display_name,
    email_id,
    mobile_number,
    password,
    ccpin,
    role,
    parent_user_id,
    is_sub_user,
    is_active,
    is_deleted,
    is_ccpinset,
    is_email_verified,
    is_mobile_verified,
    created_on,
    updated_on
FROM public.tbl_user_details;

-- 3) Login tracker table -----------------------------------------------
CREATE TABLE IF NOT EXISTS public.tbl_login_tracker (
    id          SERIAL PRIMARY KEY,
    user_id     INTEGER NOT NULL,
    email_id    VARCHAR(255) DEFAULT '',
    broswer_id  TEXT,
    session_id  TEXT,
    is_valid    BOOLEAN NOT NULL DEFAULT TRUE,
    created_on  TIMESTAMP NOT NULL DEFAULT NOW(),
    updated_on  TIMESTAMP NOT NULL DEFAULT NOW()
);

-- Optional FK to user table (safe-guarded)
DO $$
BEGIN
    IF NOT EXISTS (
        SELECT 1
        FROM   pg_constraint
        WHERE  conname = 'fk_login_tracker_user'
    ) THEN
        ALTER TABLE public.tbl_login_tracker
        ADD CONSTRAINT fk_login_tracker_user
        FOREIGN KEY (user_id)
        REFERENCES public.tbl_user_details(id)
        ON DELETE CASCADE;
    END IF;
END$$;

-- =====================================================================
-- END OF AUTHENTICATION & LOGIN TRACKING PATCH
-- =====================================================================

