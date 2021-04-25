using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Regisoft;
using System.Net;
using System.Net.Mail;

namespace MyResume
{
    public class Email
    {
        public static void Enviar(string emailDestinatario, string titulo, string corpo)
        {
            if (emailDestinatario == null || emailDestinatario == string.Empty)
                throw new ExceptionRS("Please enter the recipient's email.");
            if (!stringf.ValidaEmail(emailDestinatario))
                throw new ExceptionRS("The recipient's email is invalid.");
            if (titulo == null || titulo == string.Empty)
                throw new ExceptionRS("Enter the email subject.");
            if (corpo == null || corpo == string.Empty)
                throw new ExceptionRS("Enter the email body.");

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress("reginaldo.rsj@gmail.com","Reginaldo R. S. Júnior");
            msg.To.Add(new MailAddress(emailDestinatario));
            msg.Subject = titulo;
            msg.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            msg.Body = corpo;
            msg.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("reginaldo.rsj@gmail.com", "XXXXXXXX");
            client.Port = 587; //ou 465           
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(msg);
        }
    }
}