using Solid.DIP.Interfaces;

namespace Solid.DIP
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool InsertCustomer(Customer instance)
        {
            return true;
        }
    }
}