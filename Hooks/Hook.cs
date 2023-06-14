using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using WorkFlowMarketplaceMobile.Drivers;
using Microsoft.Extensions.Configuration;
using WorkFlowMarketplaceMobile.Variables;

namespace WorkFlowMarketplaceMobile.Hooks
{
    [Binding]
    class Hook
    {
        private readonly ScenarioContext _scenarioContext;

        static string configVariables = System.IO.Directory.GetParent(@"../../../").FullName +
                Path.DirectorySeparatorChar + "Variables/variables.json";

        public static ConfigVariables variables;

        public Hook(ScenarioContext scenarioContext) {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void ReadConfigVariables()
        {
            variables = new ConfigVariables();

            ConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.AddJsonFile(configVariables);

            IConfigurationRoot configRoot = configBuilder.Build();
            configRoot.Bind(variables);
        }

        [BeforeScenario]
        public void Initialize() {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }

        [AfterScenario]
        public void Finalize() {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().Quit();

        }
    }
}
