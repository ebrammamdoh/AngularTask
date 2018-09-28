using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ApiTask.Models.Utilities
{
    public static class Email
    {
        public static void Send(string Email, string FullName, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ebrammamdoh5@gmail.com");
            mail.To.Add(Email);
            mail.Subject = "Task Registration";
            mail.Body = FullName + "  \n " + body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("test@emailarchitect.net", "testpassword");
            SmtpServer.EnableSsl = true;

            //SmtpServer.Send(mail);
        }
    }
}