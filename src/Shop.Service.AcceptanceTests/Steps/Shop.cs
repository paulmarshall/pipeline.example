using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ServiceStack.ServiceClient.Web;
using NUnit.Framework;

namespace Shop.Service.AcceptanceTests.Steps
{
    [Binding]
    public class Shop
    {
        [Given(@"I have customers")]
        public void GivenIHaveCustomers()
        {
        }

        [When(@"I request a list of customers")]
        public void WhenIRequestAListOfCustomers()
        {
            var restClient = new JsonServiceClient(BaseUri);
            var customers = restClient.Get(new Customers());
            ScenarioContext.Current.Add("Customers", customers);
        }

        [Then(@"I should be given a list of customers")]
        public void ThenIShouldBeGivenAListOfCustomers()
        {
            var customers = ScenarioContext.Current["Customers"] as IEnumerable<Customer>;
            Assert.IsNotEmpty(customers);
        }

        [Then(@"I should get a response back")]
        public void ThenIShouldGetAResponseBack()
        {
            var customers = ScenarioContext.Current["Customers"] as IEnumerable<Customer>;
            Assert.IsNotNull(customers);
        }

        private string BaseUri
        { 
            get
            {
                return ScenarioContext.Current["BaseUri"] as string;     
            }
        }
    }
}
