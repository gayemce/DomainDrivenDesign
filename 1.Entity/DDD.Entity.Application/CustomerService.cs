namespace 1.Entity.DDD.Entity.Application
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // Yeni bir müşteri oluşturuluyor
        public void CreateCustomer(string name, string email, string address)
        {
            var customer = new Customer(name, email, address);
            _customerRepository.Add(customer);
        }

        // Müşterinin adresi güncelleniyor
        public void UpdateCustomerAddress(Guid customerId, string newAddress)
        {
            var customer = _customerRepository.GetById(customerId);
            customer.UpdateAddress(newAddress);
            _customerRepository.Update(customer);
        }
    }
}