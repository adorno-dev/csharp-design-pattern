using System;

namespace Solid.ISP
{
    public interface ICustomerPersistence
    {
        void Validate();
        void Commit();
        void Send();
    }
}