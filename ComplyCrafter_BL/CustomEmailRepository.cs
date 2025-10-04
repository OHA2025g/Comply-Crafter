using System.Net.Mail;
using System.Net;
using ComplyCrafter_Data;
using AlphaUtil.Core;
using System.Reflection;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface ICustomEmail
    {
        IEnumerable<EmailConfig> Get();
        EmailConfig? GetById(int id);
        EmailTracker? GetTrackerById(string secretkey);
        EmailTracker? SaveTracker(EmailTracker obj);
        string SendEmail(EmailConfig _Email);
        EmailTracker? GetByUserId(int id); // to get director otp
        //bool SaveEmailVerified(int id);
        //bool SaveMobileVerified(int id);
    }

    public class CustomEmailRepository : ICustomEmail
    {
        private const string TABLE_NAME = "tbl_email_config";
        private const string TRACKER_TABLE_NAME = "tbl_email_tracker";
        private const string VIEW_NAME = "vw_email_config";
        public IEnumerable<EmailConfig> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME}", ThrowError: true)
                .ParseList<EmailConfig>();
            return dt;
        }
        public EmailConfig? GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<EmailConfig>().FirstOrDefault();
            return dt;
        }
        public EmailTracker? GetTrackerById(string secretkey)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TRACKER_TABLE_NAME} where secret_id = @secret_key and is_valid = true order by 1 desc",
               new Dictionary<string, object>
               {
                    { "@secret_key", secretkey},
               }, ThrowError: true)
               .ParseList<EmailTracker>().FirstOrDefault();
            return dt;
        }

        //public bool SaveEmailVerified(int id)
        //{
        //    return NpgSQL.NonQuery(R.ConnectionString, $@"update tbl_user_details set is_email_verified = true where id = @id", new Dictionary<string, object> {
        //        { "@id", id }
        //    }) > 0;
        //}

        //public bool SaveMobileVerified(int id)
        //{
        //    return NpgSQL.NonQuery(R.ConnectionString, $@"update tbl_user_details set is_mobile_verified = true where id = @id", new Dictionary<string, object> {
        //        { "@id", id }
        //    }) > 0;
        //}

        public EmailTracker? SaveTracker(EmailTracker obj)
        {
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TRACKER_TABLE_NAME, "id");
                if (obj.Id > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TRACKER_TABLE_NAME, "id", obj.Id);
            return obj;
        }



        public string SendEmail(EmailConfig _Email)
        {
            try
            {
                if (_Email != null)
                {
                    //R.AppSet("EmailConfig:FromEmail")

                    MailMessage mail = new MailMessage();

                    //set the addresses 
                    mail.From = new MailAddress(_Email.FromEmail, _Email.DisplayName);

                    //Environment
                    if (R.AppSet("Environment:Env") == "Dev")
                    {
                        mail.To.Add(R.AppSet("Email:ToEmail"));
                        if (!string.IsNullOrEmpty(R.AppSet("Email:CCEmail"))) mail.CC.Add(R.AppSet("Email:CCEmail"));
                    }
                    else
                    {
                        mail.To.Add(_Email.ToEmail);
                        if (!string.IsNullOrEmpty(_Email.CCEmail)) mail.CC.Add(_Email.CCEmail);
                        if (!string.IsNullOrEmpty(_Email.BCCEmail)) mail.CC.Add(_Email.BCCEmail);
                    }

                    //set the content 
                    mail.Subject = _Email.EmailSubject;
                    mail.Body = _Email.EmailBody;
                    mail.IsBodyHtml = true;
                    //send the message 
                    SmtpClient smtp = new SmtpClient(_Email.SMTP);

                    //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
                    NetworkCredential Credentials = new NetworkCredential(_Email.FromEmail, _Email.EmailPassword);
                    smtp.Credentials = Credentials;
                    smtp.EnableSsl = _Email.EnableSSL;
                    smtp.Port = _Email.PortNumber;
                    smtp.Send(mail);

                    return "Email send successfully.";
                }
                return "Model is empty.";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public EmailTracker? GetByUserId(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TRACKER_TABLE_NAME} where user_id = 1 and email_config_id=6 and is_valid = true  order by 1 desc limit 1",
               new Dictionary<string, object>
               {
                    { "@id", id},
               }, ThrowError: true)
               .ParseList<EmailTracker>().FirstOrDefault();
            return dt;
        }
    }
}
