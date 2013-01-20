using System.Collections.Generic;

namespace Shop.Service
{
    public class CustomerService : ServiceStack.ServiceInterface.Service
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public object Get(Customers request)
        {
            return _repository.GetAll();
        }
    }
}
