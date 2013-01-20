using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace Shop.Service
{
    [Route("/customers")]
    public class Customers : IReturn<List<Customer>>
    {
    }
}
