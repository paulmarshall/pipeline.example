using System.Collections.Generic;

namespace Shop.Service
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}
