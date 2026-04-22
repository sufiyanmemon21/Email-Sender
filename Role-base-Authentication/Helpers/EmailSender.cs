using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Role_base_Authentication.Models;

namespace Role_base_Authentication.Helpers
{
    public class EmailSender : IEmailSender
    {
        private readonly SmtpSettings _smtpSettings;

        public EmailSender(IOptions<SmtpSettings>options)
        {
            _smtpSettings = options.Value;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
        }
    }
}
