using System;

namespace Solid.DIP.Interfaces
{
    public interface IMailService
    {
        bool Send(string from, string to, string subject, string body);
        bool Welcome(string to);
        bool IsValid(string mail);
    }
}