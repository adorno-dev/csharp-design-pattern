using Solid.DIP.Interfaces;

namespace Solid.DIP
{
    public class MailService : IMailService
    {
        private static readonly string WELCOME_FROM = "welcome@solid.srp";
        private static readonly string WELCOME_SUBJECT = "Welcome";
        private static readonly string WELCOME_BODY = "Congratulations!!";

        public bool Send(string from, string to, string subject, string body) { return true; }

        public bool Welcome(string to)
        {
            return Send(WELCOME_FROM, to, WELCOME_SUBJECT, WELCOME_BODY);
        }

        public bool IsValid(string mail) => string.IsNullOrEmpty(mail);
    }
}