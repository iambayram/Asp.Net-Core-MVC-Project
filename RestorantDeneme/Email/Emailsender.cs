using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace RestorantDeneme.Email
{
    public class Emailsender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}
