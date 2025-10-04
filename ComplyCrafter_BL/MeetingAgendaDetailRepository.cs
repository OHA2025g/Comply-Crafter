using AlphaUtil.Core;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface IMeetingAgendaDetail : BaseInterface<MeetingAgendaDetail, MeetingAgendaDetail>
    {
        MeetingAgendaDetail GetMeetingAgendaDetail(int meeting, int resolution);
        bool DeleteMeetingAgendaDetail(int meeting, int resolution);
    }
    public class MeetingAgendaDetailRepository : BaseRepository<MeetingAgendaDetail, MeetingAgendaDetail>, IMeetingAgendaDetail
    {
        const string APPOINTMENT_DETAILS_TABLE_NAME = "tbl_meeting_appointment_details";
        const string AUTHORIZATION_DETAILS_TABLE_NAME = "tbl_meeting_authorization_details";
        const string AGENDA_DETAILS_TABLE_NAME = "tbl_meeting_agenda_details";
        const string RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME = "tbl_meeting_resolution_for_notice_certificate_details";
        const string RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME = "tbl_meeting_resolution_for_minutes_certificate_details";
        const string RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME = "tbl_meeting_resolution_signature_details";
        const string SUBSCRIBER_DETAILS_TABLE_NAME = "tbl_meeting_subscriber_details";
        const string KMP_DETAILS_TABLE_NAME = "tbl_meeting_kmp_details";
        const string APPROVAL_CERTIFICATE_CONSOLIDATION_DETAILS_TABLE_NAME = "tbl_meeting_approval_certificate_consolidaton_details";
        const string PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME = "tbl_meeting_perticulars_of_certificates_details";
        const string DIRECTOR_DETAILS_TABLE_NAME = "tbl_meeting_director_details";
        const string INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME = "tbl_meeting_interest_in_other_entities_details";

        public new IEnumerable<MeetingAgendaDetail> Get()
        {
            var dt = new List<MeetingAgendaDetail>();
            return dt;
        }

        public new MeetingAgendaDetail GetById(int id = 0)
        {
            var dt = new MeetingAgendaDetail();
            return dt;
        }

        public new bool Delete(MeetingAgendaDetail obj)
        {
            return false;
        }

        public new MeetingAgendaDetail Save(MeetingAgendaDetail obj)
        {
            var existingAppointmentDetails = GetAppointmentDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            if (obj.AppointmentDetails != null)
            {
                obj.AppointmentDetails.MeetingId = obj.MeetingId;
                obj.AppointmentDetails.ResolutionId = obj.ResolutionId;
                if (existingAppointmentDetails == null)
                {
                    obj.AppointmentDetails.Id = obj.AppointmentDetails.InsertIntoDBOutIdentity(R.ConnectionString, APPOINTMENT_DETAILS_TABLE_NAME, "id");
                }
                else
                {
                    obj.AppointmentDetails.Id = existingAppointmentDetails.Id;
                    obj.AppointmentDetails.UpdateIntoDB(R.ConnectionString, APPOINTMENT_DETAILS_TABLE_NAME, "id", obj.AppointmentDetails.Id);
                }
            }

            var existingAuthorizationDetails = GetAuthorizationDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var authorizationDetailsTodelete = existingAuthorizationDetails.Where(d => (obj.AuthorizationDetails == null || !obj.AuthorizationDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            authorizationDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteAuthorizationDetailsById(child.Id);
            });
            obj.AuthorizationDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, AUTHORIZATION_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, AUTHORIZATION_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingAgendaDetails = GetAgendaDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            if (obj.MeetingAgendaDetails != null)
            {
                obj.MeetingAgendaDetails.MeetingId = obj.MeetingId;
                obj.MeetingAgendaDetails.ResolutionId = obj.ResolutionId;
                if (existingAgendaDetails == null)
                {
                    obj.MeetingAgendaDetails.Id = obj.MeetingAgendaDetails.InsertIntoDBOutIdentity(R.ConnectionString, AGENDA_DETAILS_TABLE_NAME, "id");
                }
                else
                {
                    obj.MeetingAgendaDetails.Id = existingAgendaDetails.Id;
                    obj.MeetingAgendaDetails.UpdateIntoDB(R.ConnectionString, AGENDA_DETAILS_TABLE_NAME, "id", obj.MeetingAgendaDetails.Id);
                }
            }

            var existingResolutionForNoticeCertificateDetails = GetResolutionForNoticeCertificateDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var resolutionForNoticeCertificateDetailsTodelete = existingResolutionForNoticeCertificateDetails.Where(d => (obj.MeetingResolutionForNoticeCertificateDetails == null || !obj.MeetingResolutionForNoticeCertificateDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            resolutionForNoticeCertificateDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteResolutionForNoticeCertificateDetailsById(child.Id);
            });
            obj.MeetingResolutionForNoticeCertificateDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingResolutionForMinutesCertificateDetails = GetResolutionForMinutesCertificateDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var resolutionForMinutesCertificateDetailsTodelete = existingResolutionForMinutesCertificateDetails.Where(d => (obj.MeetingResolutionForMinutesCertificateDetails == null || !obj.MeetingResolutionForMinutesCertificateDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            resolutionForMinutesCertificateDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteResolutionForMinutesCertificateDetailsById(child.Id);
            });
            obj.MeetingResolutionForMinutesCertificateDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingResolutionSignatureDetails = GetResolutionSignatureDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var resolutionSignatureDetailsTodelete = existingResolutionSignatureDetails.Where(d => (obj.MeetingResolutionSignatureDetails == null || !obj.MeetingResolutionSignatureDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            resolutionSignatureDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteResolutionSignatureDetailsById(child.Id);
            });
            obj.MeetingResolutionSignatureDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingSubscriberDetails = GetSubscriberDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var subscriberDetailsTodelete = existingSubscriberDetails.Where(d => (obj.MeetingSubscriberDetails == null || !obj.MeetingSubscriberDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            subscriberDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteSubscriberDetailsById(child.Id);
            });
            obj.MeetingSubscriberDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, SUBSCRIBER_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SUBSCRIBER_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingKMPDetails = GetKMPDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            if (obj.MeetingKMPDetails != null)
            {
                obj.MeetingKMPDetails.MeetingId = obj.MeetingId;
                obj.MeetingKMPDetails.ResolutionId = obj.ResolutionId;
                if (existingKMPDetails == null)
                {
                    obj.MeetingKMPDetails.Id = obj.MeetingKMPDetails.InsertIntoDBOutIdentity(R.ConnectionString, KMP_DETAILS_TABLE_NAME, "id");
                }
                else
                {
                    obj.MeetingKMPDetails.Id = existingKMPDetails.Id;
                    obj.MeetingKMPDetails.UpdateIntoDB(R.ConnectionString, KMP_DETAILS_TABLE_NAME, "id", obj.MeetingKMPDetails.Id);
                }
            }

            var existingApprovalCertificateConsolidationDetails = GetApprovalCertificateConsolidationDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            if (obj.MeetingApprovalCertificateConsolidationDetails != null)
            {
                obj.MeetingApprovalCertificateConsolidationDetails.MeetingId = obj.MeetingId;
                obj.MeetingApprovalCertificateConsolidationDetails.ResolutionId = obj.ResolutionId;
                if (existingApprovalCertificateConsolidationDetails == null)
                {
                    obj.MeetingApprovalCertificateConsolidationDetails.Id = obj.MeetingApprovalCertificateConsolidationDetails.InsertIntoDBOutIdentity(R.ConnectionString, APPROVAL_CERTIFICATE_CONSOLIDATION_DETAILS_TABLE_NAME, "id");
                }
                else
                {
                    obj.MeetingApprovalCertificateConsolidationDetails.Id = existingApprovalCertificateConsolidationDetails.Id;
                    obj.MeetingApprovalCertificateConsolidationDetails.UpdateIntoDB(R.ConnectionString, APPROVAL_CERTIFICATE_CONSOLIDATION_DETAILS_TABLE_NAME, "id", obj.MeetingApprovalCertificateConsolidationDetails.Id);
                }
            }

            var existingPerticularsOfCertificatesDetails = GetPerticularsOfCertificatesDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var perticularsOfCertificatesDetailsTodelete = existingPerticularsOfCertificatesDetails.Where(d => (obj.MeetingPerticularsOfCertificatesDetails == null || !obj.MeetingPerticularsOfCertificatesDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            perticularsOfCertificatesDetailsTodelete?.ToList().ForEach(child =>
            {
                DeletePerticularsOfCertificatesDetailsById(child.Id);
            });
            obj.MeetingPerticularsOfCertificatesDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME, "id");
                }
            });

            var existingDirectorDetails = GetDirectorDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            if (obj.MeetingDirectorDetails != null)
            {
                obj.MeetingDirectorDetails.MeetingId = obj.MeetingId;
                obj.MeetingDirectorDetails.ResolutionId = obj.ResolutionId;
                if (existingDirectorDetails == null)
                {
                    obj.MeetingDirectorDetails.Id = obj.MeetingDirectorDetails.InsertIntoDBOutIdentity(R.ConnectionString, DIRECTOR_DETAILS_TABLE_NAME, "id");
                }
                else
                {
                    obj.MeetingDirectorDetails.Id = existingDirectorDetails.Id;
                    obj.MeetingDirectorDetails.UpdateIntoDB(R.ConnectionString, DIRECTOR_DETAILS_TABLE_NAME, "id", obj.MeetingDirectorDetails.Id);
                }
            }

            var existingInterestInOtherEntitiesDetails = GetInterestInOtherEntitiesDetails(obj.MeetingId.Value, obj.ResolutionId.Value);
            var interestInOtherEntitiesDetailsTodelete = existingInterestInOtherEntitiesDetails.Where(d => (obj.MeetingInterestInOtherEntitiesDetails == null || !obj.MeetingInterestInOtherEntitiesDetails.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
            interestInOtherEntitiesDetailsTodelete?.ToList().ForEach(child =>
            {
                DeleteInterestInOtherEntitiesDetailsById(child.Id);
            });
            obj.MeetingInterestInOtherEntitiesDetails?.ToList().ForEach(child =>
            {
                child.MeetingId = obj.MeetingId;
                child.ResolutionId = obj.ResolutionId;
                if (child.Id > 0)
                {
                    child.UpdateIntoDB(R.ConnectionString, INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME, "id", child.Id);
                }
                else
                {
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME, "id");
                }
            });

            return obj;
        }

        public MeetingAppointmentDetails GetAppointmentDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {APPOINTMENT_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingAppointmentDetails>().FirstOrDefault();
            return dt;
        }

        public bool DeleteAppointmentDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {APPOINTMENT_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public IEnumerable<MeetingAuthorizationDetails> GetAuthorizationDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {AUTHORIZATION_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingAuthorizationDetails>();
            return dt;
        }

        public bool DeleteAuthorizationDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {AUTHORIZATION_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeleteAuthorizationDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {AUTHORIZATION_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public MeetingAgendaDetails GetAgendaDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {AGENDA_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingAgendaDetails>().FirstOrDefault();
            return dt;
        }

        public bool DeleteAgendaDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {AGENDA_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public IEnumerable<MeetingResolutionForNoticeCertificateDetails> GetResolutionForNoticeCertificateDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingResolutionForNoticeCertificateDetails>();
            return dt;
        }

        public bool DeleteResolutionForNoticeCertificateDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }
        
        public bool DeleteResolutionForNoticeCertificateDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_FOR_NOTICE_CERTIFICATE_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public IEnumerable<MeetingResolutionForMinutesCertificateDetails> GetResolutionForMinutesCertificateDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingResolutionForMinutesCertificateDetails>();
            return dt;
        }

        public bool DeleteResolutionForMinutesCertificateDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeleteResolutionForMinutesCertificateDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_FOR_MINUTES_CERTIFICATE_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public IEnumerable<MeetingResolutionSignatureDetails> GetResolutionSignatureDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingResolutionSignatureDetails>();
            return dt;
        }

        public bool DeleteResolutionSignatureDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeleteResolutionSignatureDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {RESOLUTION_SIGNATURE_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public IEnumerable<MeetingSubscriberDetails> GetSubscriberDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {SUBSCRIBER_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingSubscriberDetails>();
            return dt;
        }

        public bool DeleteSubscriberDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {SUBSCRIBER_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeleteSubscriberDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {SUBSCRIBER_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public MeetingKMPDetails GetKMPDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {KMP_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingKMPDetails>().FirstOrDefault();
            return dt;
        }

        public bool DeleteKMPDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {KMP_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public MeetingApprovalCertificateConsolidationDetails GetApprovalCertificateConsolidationDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {APPROVAL_CERTIFICATE_CONSOLIDATION_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingApprovalCertificateConsolidationDetails>().FirstOrDefault();
            return dt;
        }

        public bool DeleteApprovalCertificateConsolidationDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {APPROVAL_CERTIFICATE_CONSOLIDATION_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public IEnumerable<MeetingPerticularsOfCertificatesDetails> GetPerticularsOfCertificatesDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingPerticularsOfCertificatesDetails>();
            return dt;
        }

        public bool DeletePerticularsOfCertificatesDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeletePerticularsOfCertificatesDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {PERTICULARS_OF_CERTIFICATES_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public MeetingDirectorDetails GetDirectorDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {DIRECTOR_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingDirectorDetails>().FirstOrDefault();
            return dt;
        }

        public bool DeleteDirectorDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {DIRECTOR_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public IEnumerable<MeetingInterestInOtherEntitiesDetails> GetInterestInOtherEntitiesDetails(int meeting = 0, int resolution = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
               })
               .ParseList<MeetingInterestInOtherEntitiesDetails>();
            return dt;
        }

        public bool DeleteInterestInOtherEntitiesDetails(int meeting = 0, int resolution = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME} where meeting_id = @meeting and resolution_id = @resolution",
                new Dictionary<string, object>
                {
                    { "@meeting", meeting },
                    { "@resolution", resolution },
                }) > 0;
        }

        public bool DeleteInterestInOtherEntitiesDetailsById(int id = 0)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {INTEREST_IN_OTHER_ENTITIES_DETAILS_TABLE_NAME} where id = @id",
                new Dictionary<string, object>
                {
                    { "@id", id },
                }) > 0;
        }

        public bool DeleteMeetingAgendaDetail(int meeting, int resolution)
        {
            return DeleteAppointmentDetails(meeting, resolution) ||
                   DeleteAuthorizationDetails(meeting, resolution) ||
                   DeleteAgendaDetails(meeting, resolution) ||
                   DeleteResolutionForNoticeCertificateDetails(meeting, resolution) ||
                   DeleteResolutionForMinutesCertificateDetails(meeting, resolution) ||
                   DeleteResolutionSignatureDetails(meeting, resolution) ||
                   DeleteSubscriberDetails(meeting, resolution) ||
                   DeleteKMPDetails(meeting, resolution) ||
                   DeleteApprovalCertificateConsolidationDetails(meeting, resolution) ||
                   DeletePerticularsOfCertificatesDetails(meeting, resolution) ||
                   DeleteDirectorDetails(meeting, resolution) ||
                   DeleteInterestInOtherEntitiesDetails(meeting, resolution);
        }

        MeetingAgendaDetail IMeetingAgendaDetail.GetMeetingAgendaDetail(int meeting, int resolution)
        {
            var dt = new MeetingAgendaDetail();
            dt.AppointmentDetails = GetAppointmentDetails(meeting, resolution);
            dt.AuthorizationDetails = GetAuthorizationDetails(meeting, resolution);
            dt.MeetingAgendaDetails = GetAgendaDetails(meeting, resolution);
            dt.MeetingResolutionForNoticeCertificateDetails = GetResolutionForNoticeCertificateDetails(meeting, resolution);
            dt.MeetingResolutionForMinutesCertificateDetails = GetResolutionForMinutesCertificateDetails(meeting, resolution);
            dt.MeetingResolutionSignatureDetails = GetResolutionSignatureDetails(meeting, resolution);
            dt.MeetingSubscriberDetails = GetSubscriberDetails(meeting, resolution);
            dt.MeetingKMPDetails = GetKMPDetails(meeting, resolution);
            dt.MeetingApprovalCertificateConsolidationDetails = GetApprovalCertificateConsolidationDetails(meeting, resolution);
            dt.MeetingPerticularsOfCertificatesDetails = GetPerticularsOfCertificatesDetails(meeting, resolution);
            dt.MeetingDirectorDetails = GetDirectorDetails(meeting, resolution);
            dt.MeetingInterestInOtherEntitiesDetails = GetInterestInOtherEntitiesDetails(meeting, resolution);
            return dt;
        }
    }
}
