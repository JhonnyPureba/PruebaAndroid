using Allure.Commons;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class InitializeHook
    {
        private readonly ScenarioContext _scenarioContext;
        public static AllureLifecycle allure = AllureLifecycle.Instance;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory();
        }

        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            //context injection sets the type
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }
    }
}
