using Funq;
using ServiceStack.WebHost.Endpoints;

namespace Shop.Service.Host.Web
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Shop REST API", typeof(CustomerService).Assembly) { }

        public override void Configure(Container container)
        {
            container.Register<ICustomerRepository>(new CustomerRepository());
        }
    }
}