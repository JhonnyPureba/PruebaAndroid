using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowMarketplaceMobileProject.PageObjects;

namespace SpecFlowProject1.Utils
{
    internal class TestContextSetup
    {
        private readonly ScenarioContext _scenarioContext;
        public AndroidDriver<AppiumWebElement> driver;
        public PageObjectManager pageObjectManager;

        public TestContextSetup(ScenarioContext scenarioContext) 
        {
            _scenarioContext = scenarioContext;
            driver = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();
            pageObjectManager = new PageObjectManager(driver);
        }
    }
}
