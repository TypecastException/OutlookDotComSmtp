using System;
using System.Net.Mail;

namespace SmtpMailConnections
{
    public class OutlookDotComMail
    {
        string _sender = "";
        string _password = "";
        public OutlookDotComMail(string sender, string password)
        {
            _sender = sender;
            _password = password;
        }


        public void SendMail(string recipient, string subject, string message)
        {
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_sender, _password);
            client.EnableSsl = true;
            client.Credentials = credentials;

            try
            {
                var mail = new MailMessage(_sender.Trim(), recipient.Trim());
                mail.Subject = subject;
                mail.Body = message;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
