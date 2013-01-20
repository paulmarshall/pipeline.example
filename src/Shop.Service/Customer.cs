using ServiceStack.ServiceHost;

namespace Shop.Service
{
    public class Customer : IReturn<Customer>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
