using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace ComplyCrafter_UI.Controllers
{
    public class Resolutions : Controller
    {
        public IActionResult To_cancel_the_existing_certificate_and_issue_renewed_certificate()
        {
            return View();
        }

        public IActionResult To_authorize_printing_of_Certificates_and_correspondence_with_depositories_if_any()
        {
            return View();
        }


        public IActionResult To_authorize_the_issuance_of_certificates_to_the_subscribers_to_the_Memorandum_and_Article_of_Association()
        {
            return View();
        } 
        
        
        public IActionResult To_approve_splitting_of_certificate()
        {
            return View();
        }
        
        
        public IActionResult To_approve_issuance_of_duplicate_()
        {
            return View();
        } 
        
        public IActionResult To_approve_splitting_of_certificates()
        {
            return View();
        }


        public IActionResult To_approve_the_consolidation_of_()
        {
            return View();
        }
        
        
        public IActionResult To_recommend_reappointment_of_as_of_the_Company()
        {
            return View();
        }

        public IActionResult To_recommend_appointment_of_as_of_the_Company()
        {
            return View();
        }

        public IActionResult To_reappoint_as_of_the_Company()
        {
            return View();
        } 
        public IActionResult To_discuss_and_consider_the_appointment_of_as_company_secretary_of_the_company()
        {
            return View();
        }
         public IActionResult To_Appoint_as_an_Additional_Director()
        { 
            return View();
        }

        public IActionResult Particulars_of_Share_Certificate()
        {
            return View();
        }
        
        
        public IActionResult To_appoint_of_the_company_subject_to_the_approval_of_members_in_General_Meeting()
        {
            return View();
        }
        
        public IActionResult To_propose_appointment_of_as_()
        {
            return View();
        }


        public IActionResult To_note_the_First_s_of_the_company()
        {
            return View();
        }
        
        public IActionResult To_approve_appointment_of_Women_()
        {
            return View();
        }


        public IActionResult To_approve_appointment_of_as_an_Alternate_director()
        {
            return View();
        }
         public IActionResult To_appoint_as_Nominee_Director()
        {
            return View();
        }
        
        public IActionResult To_approve_appointment_of_to_fill_the_casual_vacancy()
        {
            return View();
        }
        public IActionResult To_appoint_as_Chief_Financial_Officer_of_the_Company()
        {
            return View();
        }
        public IActionResult To_reappoint_the_retiring_by_rotation()
        {
            return View();
        }   
        
        public IActionResult To_Appoint_as_of_the_Company()
        {
            return View();
        }
        public IActionResult To_Reappoint_as_Managing_Director_of_the_Company()
        {
            return View();
        }
         public IActionResult To_reappoint_as_Whole_time_Director_of_the_Company()
        {
            return View();
        }
          public IActionResult To_take_note_of_disclosure_of_interest_by_newly_appointed_()
        {
            return View();
        } 
        
        public IActionResult To_take_note_of_declaration_of_nondisqualification_us_164_by_newly_appointed_()
        {
            return View();
        }
        
        public IActionResult To_appoint_as_Chief_Executive_Officer_of_the_Company()
        {
            return View();
        }
         public IActionResult To_Appoint_as_an_Independent_Director()
        {
            return View();
        }
         public IActionResult To_reappoint_as_an_Independent_Director()
        {
            return View();
        }
         public IActionResult To_alter_the_share_capital_clause_of_the_Memorandum_of_Association_of_the_company()
        {
            return View();
        }
         public IActionResult To_recommend_reclassification_of_authorised_share_capital_and_consequent_amendment_to_Memorandum_of_Association_of_the_company()
        {
            return View();
        }



        public IActionResult To_consider_and_approve_Allotment_of_Equity_shares_on_right_issue_basis()
        {
            return View();
        }
        
        public IActionResult To_approve_the_offer_and_further_issue_of_shares_on_right_basis()
        {
            return View();
        }
        public IActionResult To_Convert_loan_into_Equity_Shares()
        {
            return View();
        }
        
        
        public IActionResult To_consider_and_approve_raising_of_External_Commercial_Borrowing_under_loan_agreement_including_a_right_of_conversion_thereof()
        {
            return View();
        }
        public IActionResult To_Issue_Bonus_Share()
        {
            return View();
        }
         public IActionResult To_issue_on_Private_Placement_Basis()
        {
            return View();
        }
         public IActionResult To_approve_ESOP_scheme()
        {
            return View();
        }
           public IActionResult To_approve_the_conversion_of_into_of_the_Company()
        {
            return View();
        }  
        
        public IActionResult To_approve_issuance_of_on_conversion_of_()
        {
            return View();
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [HttpGet("[controller]/ViewResolution/{view}/{mode}/{meeting}/{resolnId}")]
        public IActionResult ViewResolution(string view, string mode, string meeting, string resolnId)
        {
            ViewBag.Mode = mode;
            ViewBag.Meeting = meeting;
            ViewBag.ResolnId = resolnId;
            ViewBag.UseLayout = true;
            return View(view);
        }

        [HttpGet("[controller]/LoadResolution/{view}/{mode}/{meeting}/{resolnId}")]
        public IActionResult LoadResolution(string view, string mode, string meeting, string resolnId)
        {
            ViewBag.Mode = mode;
            ViewBag.Meeting = meeting;
            ViewBag.ResolnId = resolnId;
            ViewBag.UseLayout = false;
            return PartialView(view);
        }

    }
}
