using Solid.DIP.Interfaces;

namespace Solid.DIP
{
    public class HashCodeService : IHashCodeService
    {
        public bool IsValid(string hashCode) => hashCode.Length == 11;
    }
}