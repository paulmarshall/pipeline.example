using TechTalk.SpecFlow;

namespace Shop.Service.AcceptanceTests.Steps
{
    [Binding]
    public class Events
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var baseUri = "http://localhost:82/";
            var appHost = new ConsoleAppHost();
            appHost.Init();
            appHost.Start(baseUri);

            ScenarioContext.Current.Add("BaseUri", baseUri);
            ScenarioContext.Current.Set<ConsoleAppHost>(appHost);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var apphost = ScenarioContext.Current.Get<ConsoleAppHost>();
            apphost.Dispose();
        }
    }
}
