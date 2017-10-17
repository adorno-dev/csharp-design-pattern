namespace Solid.SRP
{
    public class MailService
    {
        private static readonly string WELCOME_FROM = "welcome@solid.srp";
        private static readonly string WELCOME_SUBJECT = "Welcome";
        private static readonly string WELCOME_BODY = "Congratulations!!";

        public static bool Send(string from, string to, string subject, string body) { return true; }

        public static bool Welcome(string to)
        {
            return Send(WELCOME_FROM, to, WELCOME_SUBJECT, WELCOME_BODY);
        }

        public static bool IsValid(string mail) => string.IsNullOrEmpty(mail);
    }
}