using System;

namespace Solid.DIP.Interfaces
{
    public interface ICustomerService
    {
        bool InsertCustomer(Customer instance);
    }
}