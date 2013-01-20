using System.Collections.Generic;

namespace Shop.Service
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetAll()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = "1",
                    Name = "Paul"
                },
                new Customer
                {
                    Id = "2",
                    Name = "Simon"
                }
            };
        }
    }
}
