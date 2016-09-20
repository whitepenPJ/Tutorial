using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Reflection;
using System.Web;

namespace InCoze.Standard.Utilities
{
    public static class Helper
    {
        public static class UserRole
        {
            public static string Admin { get { return "admin"; } }
            public static string SuperAdmin { get { return "superadmin"; } }
            public static string Lawyer { get { return "lawyer"; } }
            public static string Person { get { return "person"; } }
        }

        //public class SendEmail
        //{
        //    public List<MailAddress> To { get; set; }
        //    public string Subject { get; set; }
        //    public string Body { get; set; }
        //    public string Email_From { get; set; }
        //    public string Name_From { get; set; }

        //    public SendEmail()
        //    {
        //        this.To = new List<MailAddress>();
        //    }
        //    public void Send()
        //    {
        //        var message = new MailMessage();
        //        foreach (MailAddress mailTo in this.To)
        //        {
        //            message.To.Add(mailTo);
        //        }

        //        if (string.IsNullOrEmpty(this.Email_From))
        //        {
        //            this.Email_From = ConfigurationManager.AppSettings["SMTP.email_address"];
        //        }

        //        if (string.IsNullOrEmpty(this.Name_From))
        //        {
        //            this.Name_From = ConfigurationManager.AppSettings["SMTP.email_name"];
        //        }

        //        message.From = new MailAddress(this.Email_From, this.Name_From);
        //        message.Subject = this.Subject;
        //        message.Body = this.Body;
        //        message.IsBodyHtml = true;
        //        try
        //        {
        //            using (var smtp = new SmtpClient())
        //            {
        //                string userName = ConfigurationManager.AppSettings["SMTP.email_username"];
        //                string password = ConfigurationManager.AppSettings["SMTP.email_password"];

        //                smtp.Host = ConfigurationManager.AppSettings["SMTP.mailserver"];
        //                smtp.Port = Int32.Parse(ConfigurationManager.AppSettings["SMTP.port"]);

        //                smtp.UseDefaultCredentials = false;
        //                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

        //                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        //                    smtp.Credentials = new NetworkCredential(userName, password);

        //                smtp.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["SMTP.enableSSL"]);

        //                if (ConfigurationManager.AppSettings["SMTP.target_name"] != "")
        //                {
        //                    smtp.TargetName = ConfigurationManager.AppSettings["SMTP.target_name"];
        //                }

        //                smtp.Send(message);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            UtilitiesHelper.WriteLog(ex.Message + "/n" + ex.StackTrace);

        //            if (ex.InnerException != null && ex.InnerException.Message != null && ex.InnerException.StackTrace != null)
        //                UtilitiesHelper.WriteLog(ex.InnerException.Message + "/n" + ex.InnerException.StackTrace);
        //        }
        //    }

        //    public void SendAsync(SendEmailParameter param = null)
        //    {
        //        ThreadPool.QueueUserWorkItem(o =>
        //        {
        //            try
        //            {

        //                SendEmailParameter options = param;

        //                if (options == null)
        //                {
        //                    options = new SendEmailParameter() { To = this.To, Subject = this.Subject, Body = this.Body, Email_From = this.Email_From, Name_From = this.Name_From };
        //                }

        //                var message = new MailMessage();
        //                foreach (MailAddress mailTo in options.To)
        //                {
        //                    message.To.Add(mailTo);
        //                }

        //                if (string.IsNullOrEmpty(options.Email_From))
        //                {
        //                    options.Email_From = ConfigurationManager.AppSettings["SMTP.email_address"];
        //                }

        //                if (string.IsNullOrEmpty(options.Name_From))
        //                {
        //                    options.Name_From = ConfigurationManager.AppSettings["SMTP.email_name"];
        //                }

        //                message.From = new MailAddress(options.Email_From, options.Name_From);
        //                message.Subject = options.Subject;
        //                message.Body = options.Body;
        //                message.IsBodyHtml = true;

        //                using (var smtp = new SmtpClient())
        //                {
        //                    string userName = ConfigurationManager.AppSettings["SMTP.email_username"];
        //                    string password = ConfigurationManager.AppSettings["SMTP.email_password"];

        //                    smtp.UseDefaultCredentials = false;
        //                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

        //                    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        //                        smtp.Credentials = new NetworkCredential(userName, password);

        //                    smtp.Port = Int32.Parse(ConfigurationManager.AppSettings["SMTP.port"]);

        //                    if (ConfigurationManager.AppSettings["SMTP.target_name"] != "")
        //                    {
        //                        smtp.TargetName = ConfigurationManager.AppSettings["SMTP.target_name"];
        //                    }

        //                    smtp.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["SMTP.enableSSL"]);
        //                    smtp.Host = ConfigurationManager.AppSettings["SMTP.mailserver"];
        //                    smtp.Send(message);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                UtilitiesHelper.WriteLog(ex.Message + "/n" + ex.StackTrace);

        //                if (ex.InnerException != null && ex.InnerException.Message != null && ex.InnerException.StackTrace != null)
        //                    UtilitiesHelper.WriteLog(ex.InnerException.Message + "/n" + ex.InnerException.StackTrace);
        //            }
        //        });

        //    }

        //    public static List<string> get_email_template_xml(string email_template_name)
        //    {
        //        string xml_patch = HttpContext.Current.Server.MapPath("~/External_Data/mail_message.xml");
        //        var xml = XDocument.Load(xml_patch);

        //        var xmlData = (from c in xml.Root.Descendants("email")
        //                       where c.Attribute("for").Value == email_template_name
        //                       select new
        //                       {
        //                           subject = c.Element("subject"),
        //                           message = c.Element("message")
        //                       }).FirstOrDefault();

        //        StringBuilder subject = new StringBuilder();
        //        StringBuilder template = new StringBuilder();

        //        foreach (XNode node in xmlData.subject.Nodes())
        //        {
        //            subject.Append(node.ToString());
        //        }

        //        foreach (XNode node in xmlData.message.Nodes())
        //        {
        //            template.Append(node.ToString());
        //        }

        //        List<string> list_email_message = new List<string>();

        //        list_email_message.Add(subject.ToString());
        //        list_email_message.Add(template.ToString());

        //        return list_email_message;
        //    }
        //}

        //public class SendEmailParameter
        //{
        //    public List<MailAddress> To { get; set; }
        //    public string Subject { get; set; }
        //    public string Body { get; set; }
        //    public string Email_From { get; set; }
        //    public string Name_From { get; set; }

        //    public SendEmailParameter()
        //    {
        //        this.To = new List<MailAddress>();
        //    }
        //}

        //public static void WriteLog(string logMessage)
        //{
        //    //sLogFormat used to create log files format :
        //    // dd/mm/yyyy hh:mm:ss AM/PM ==> Log Message
        //    string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";

        //    //this variable used to create log filename format "
        //    //for example filename : ErrorLogYYYYMMDD
        //    string sYear = DateTime.Now.Year.ToString();
        //    string sMonth = DateTime.Now.Month.ToString();
        //    string sDay = DateTime.Now.Day.ToString();
        //    string sErrorTime = sYear + sMonth + sDay;
        //    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\" + sErrorTime, true);
        //    sw.WriteLine(sLogFormat + logMessage);
        //    sw.Flush();
        //    sw.Close();
        //}
    }
}