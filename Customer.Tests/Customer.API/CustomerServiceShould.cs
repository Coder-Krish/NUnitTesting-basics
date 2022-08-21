using Customer.API.Services;
using Customer.Application.DTOs;
using Customer.Domain.Entities;

namespace Customer.Tests.Customer.API
{
    public class CustomerServiceShould
    {
        CustomerService _customerService;
        [SetUp]
        public void SetUp()
        {
            _customerService = new CustomerService();
        }

        [Test]
        public void HaveAddCustomerMethod()
        {
            Assert.IsNotNull(
                typeof(CustomerService).GetMethod("AddCustomer")
            );
        }

        [Test]
        public void HaveAddCustomerMethodThatExpectsCustomerModel()
        {
            Assert.Throws<ArgumentNullException>(() =>
            _customerService.AddCustomer(null)
            );
        }

        [Test]
        public void HaveAddCustomerMethodThatAddCustomerToCustomer()
        {
            //Arrange
            Customers customer = new Customers();
            customer.CustomerName = "Krishna";
            customer.Address = "Dhangadhi";
            customer.Email = "invincible.impervious@gmail.com";

            //Act
            _customerService.AddCustomer(customer);

            //Assert
            Assert.That(_customerService.Customers[0], Is.EqualTo(customer));
        }

        [Test]
        public void HaveAddCustomerMethodThatThrowsExceptionWhenAnyPropertyIsNull()
        {
            //Arrange
            Customers customer = new Customers();
            customer.CustomerName = null;
            customer.Address = "Dhangadhi";
            customer.Email = "invincible.impervious@gmail.com";


            //Assert
            Assert.Throws<InvalidOperationException>(() =>
                _customerService.AddCustomer(customer)
            );
        }

    }
}
