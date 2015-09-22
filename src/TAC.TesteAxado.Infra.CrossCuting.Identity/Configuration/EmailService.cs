using Microsoft.AspNet.Identity;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage identityMessage)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnvioEmailCriacaoConta"]))
            {
                var text = HttpUtility.HtmlEncode(identityMessage.Body);

                var msg = new MailMessage { From = new MailAddress(ConfigurationManager.AppSettings["ContaDeEmail"], "Admin do Portal Axado TAC") };

                msg.To.Add(new MailAddress(identityMessage.Destination));
                msg.Subject = identityMessage.Subject;
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Html));

                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings["ContaDeEmail"], ConfigurationManager.AppSettings["SenhaEmail"], "");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = true;
                smtpClient.Send(msg);
            }

            return Task.FromResult(0);
        }
    }
}