namespace Solid.SRP
{
    public class HashCodeService
    {
        public static bool IsValid(string hashCode) => hashCode.Length == 11;
    }
}