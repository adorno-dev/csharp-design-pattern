using System;

namespace Solid.OCP
{
    public class DebitChecking : DebitAccount
    {
        public override Guid? Debit(decimal value, string account)
        {
            return Guid.NewGuid();
        }
    }
}