﻿using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.AppCode.Services
{
    public class EmailService
    {
        private readonly EmailServiceOptions options;

        public EmailService(IOptions<EmailServiceOptions> options)
        {
            this.options = options.Value;
        }
        public async Task<bool> SendEmailAsync(string toEmail,string subject,string messageText)
        {
            try
            {



                SmtpClient client = new SmtpClient(options.SmtpServer, options.SmtpPort);
                client.Credentials = new NetworkCredential(options.UserName, options.Password);
                client.EnableSsl = options.EnableSsl;

                MailAddress from = new MailAddress(options.UserName, options.DisplayName);
                MailAddress to = new MailAddress(toEmail);
                MailMessage message = new MailMessage(from, to);
                message.Subject = subject;
                message.Body = messageText;
                message.IsBodyHtml = true;
                 await client.SendMailAsync(message);
                
                return true;

            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
    public class EmailServiceOptions
    {
        public string DisplayName { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public bool EnableSsl { get; set; }
        public string UserName { get; set; }
        public string AccountPassword { get; set; }
        public string Password { get; set; }
        public string Cc { get; set; }






    }
}
