using System;
using Solid.DIP.Interfaces;

namespace Solid.DIP
{
    public class Customer
    {
        private readonly IMailService _mailService = null;
        private readonly IHashCodeService _hashCodeService = null;

        public Guid? SignatureKey { get; set; }
        public DateTime MemberSince { get; set; }
        public string HashCode { get; set; }
        public string NickName { get; set; }
        public string Mail { get; set; }

        public Customer(IMailService mailService, IHashCodeService hashcodeService)
        {
            _mailService = mailService;
            _hashCodeService = hashcodeService;
        }

        public bool IsValid => _mailService.IsValid(this.Mail) && _hashCodeService.IsValid(this.HashCode);
    }
}