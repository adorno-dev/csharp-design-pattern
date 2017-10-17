using System;

namespace Solid.SRP
{
    public class Customer
    {
        public Guid? SignatureKey { get; set; }
        public DateTime MemberSince { get; set; }
        public string HashCode { get; set; }
        public string NickName { get; set; }
        public string Mail { get; set; }

        public bool IsValid => MailService.IsValid(Mail) && HashCodeService.IsValid(HashCode);
    }
}