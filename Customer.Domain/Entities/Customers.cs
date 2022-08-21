namespace Customer.Domain.Entities
{
    public class Customers
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

       
    }
}
