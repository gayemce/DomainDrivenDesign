using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1.Entity.DDD.Entity.Infrastructure;

public interface ICustomerRepository
{
    void Add(Customer customer);
    Customer GetById(Guid customerId);
    void Update(Customer customer);
}

public class CustomerRepository : ICustomerRepository
{
    private readonly List<Customer> _customers = new List<Customer>();

    public void Add(Customer customer)
    {
        _customers.Add(customer);
    }

    public Customer GetById(Guid customerId)
    {
        return _customers.SingleOrDefault(c => c.CustomerId == customerId);
    }

    public void Update(Customer customer)
    {
        var existingCustomer = _customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
        if (existingCustomer != null)
        {
            existingCustomer = customer;
        }
    }
}
