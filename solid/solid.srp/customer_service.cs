namespace Solid.SRP
{
    public class CustomerService
    {
        public bool InsertCustomer(Customer instance)
        {
            if (!instance.IsValid)
                return false;
            
            var repository = new CustomerRepository();
            repository.InsertCustomer(instance);

            return MailService.Welcome(instance.Mail);
        }
    }
}