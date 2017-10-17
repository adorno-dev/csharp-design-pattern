using System;

namespace Solid.OCP
{
    public class DebitInvestment : DebitAccount
    {
        public override Guid? Debit(decimal value, string account)
        {
            // taxes
            return Guid.NewGuid();
        }
    }
}