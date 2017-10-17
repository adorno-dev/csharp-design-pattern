using System;

namespace Solid.OCP
{
    public abstract class DebitAccount
    {
        public Guid? TransactionKey { get; set; }

        public abstract Guid? Debit(decimal value, string account);
    }
}