namespace Customer.Domain.Entities
{
    public class Customers
    {
        public Guid CustomerId { get; private set; }
        public string CustomerName { get; private set; }

        public string Address { get; private set; }

        public string Email { get; private set; }
    }
}
