using Funq;
using ServiceStack.WebHost.Endpoints;

namespace Shop.Service
{
    public class ConsoleAppHost : AppHostHttpListenerBase
    {
        public ConsoleAppHost() : base("Shop REST API", typeof(CustomerService).Assembly) { }

        public override void Configure(Container container)
        {
            container.Register<ICustomerRepository>(new CustomerRepository());
        }
    }
}
