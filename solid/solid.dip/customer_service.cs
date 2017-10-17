using Solid.DIP.Interfaces;

namespace Solid.DIP
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository = null;
        private readonly IMailService _service = null;

        public CustomerService(ICustomerRepository repository, IMailService service)
        {
            _repository = repository;
            _service = service;
        }

        public bool InsertCustomer(Customer instance)
        {
            if (!instance.IsValid)
                return false;
            
            _repository.InsertCustomer(instance);

            return _service.Welcome(instance.Mail);
        }
    }
}