using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecFlowProject1.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

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
