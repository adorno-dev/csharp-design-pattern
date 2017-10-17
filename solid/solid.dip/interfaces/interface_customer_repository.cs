using System;

namespace Solid.DIP.Interfaces
{
    public interface ICustomerRepository
    {
        bool InsertCustomer(Customer instance);
    }
}