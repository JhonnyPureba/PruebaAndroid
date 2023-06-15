using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    internal class InitializeHook
    {
        private readonly ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
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
