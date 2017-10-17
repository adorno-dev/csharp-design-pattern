using System;

namespace Solid.OCP
{
    public class DebitSaving : DebitAccount
    {
        public override Guid? Debit(decimal value, string account)
        {
            // taxes
            // birthday
            
            return Guid.NewGuid();
        }        
    }
}