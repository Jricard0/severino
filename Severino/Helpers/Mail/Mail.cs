using System;
using System.Net;
using System.Net.Mail;
using Severino.Validators.Env;

namespace Severino.Helpers.Mail
{
	public class Mail : IMail
	{
        private string DEFAULT_EMAIL = Environment.GetEnvironmentVariable("SEVERINO_APP_DEFAULT_SMTP_EMAIL");
        private string DEFAULT_PASSWORD = Environment.GetEnvironmentVariable("SEVERINO_DEFAULT_SMTP_PASSWORD");
        private string DEFAULT_SMTP_HOST = Environment.GetEnvironmentVariable("SEVERINO_DEFAULT_SMTP_HOST");
        private int DEFAULT_SMTP_PORT = Convert.ToInt32(Environment.GetEnvironmentVariable("SEVERINO_DEFAULT_SMTP_PORT"));
        private bool SMTP_ENABLE_SSL = Convert.ToBoolean(Environment.GetEnvironmentVariable("SEVERINO_DEFAULT_SMTP_ENABLE_SSL"));
        private readonly MailAddress _sender;


        public Mail()
        {
            EnvironmentVarsValidator.AreEnvironmentVariablesDefined(new List<string>()
            {
                "SEVERINO_APP_DEFAULT_SMTP_EMAIL",
                "SEVERINO_DEFAULT_SMTP_PASSWORD",
                "SEVERINO_DEFAULT_SMTP_HOST",
                "SEVERINO_DEFAULT_SMTP_PORT",
                "SEVERINO_DEFAULT_SMTP_ENABLE_SSL",
            });
            _sender = new MailAddress(DEFAULT_EMAIL);
        }

        public async Task<bool> Send(MailAddress receiver, string subject, string body, bool isBodyHTML = true)
        {
            SmtpClient _client = new SmtpClient()
            {
                Host = DEFAULT_SMTP_HOST,
                Port = DEFAULT_SMTP_PORT,
                EnableSsl = SMTP_ENABLE_SSL,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(DEFAULT_EMAIL, DEFAULT_PASSWORD)
            };

            using (var message = new MailMessage(_sender, receiver)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = isBodyHTML
            })
            {
                var messageSent = await Task.Run(() =>  _client.SendMailAsync(message).IsCompletedSuccessfully);
                return messageSent;
            }
        }
    }
}

