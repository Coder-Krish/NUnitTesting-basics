using Customer.Application.DTOs;
using Customer.Domain.Entities;

namespace Customer.API.Services
{
    public class CustomerService
    {
        public List<Customers> Customers = new List<Customers>();
        public void AddCustomer(Customers customer)
        {
            if (customer is null)
                throw new ArgumentNullException(nameof(customer));

            if (customer.CustomerName is null || customer.Address is null || customer.Email is null)
                throw new InvalidOperationException(nameof(customer));
            Customers.Add(customer);
        }

    }
}
