using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace WorkFlowMarketplaceMobile.Drivers
{
    class AppiumDriver
    {
        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {

            AndroidDriver <AppiumWebElement> driver;
            var driverOptions = new AppiumOptions();
            
            driverOptions.AddAdditionalCapability("appium:platformName", "Android");
            driverOptions.AddAdditionalCapability("appium:deviceName", Hooks.Hook.variables.BaseDeviceName);
            driverOptions.AddAdditionalCapability("appium:automationName", "UIAutomator2");
            driverOptions.AddAdditionalCapability("appium:app", Hooks.Hook.variables.BasePathApk);
            driverOptions.AddAdditionalCapability("appium:newCommandTimeout", Hooks.Hook.variables.BaseCommandTimeout);
            driverOptions.AddAdditionalCapability("appium:ignoreUnimportantViews", true);
            driverOptions.AddAdditionalCapability("appium:normalizeTagNames", true);
            driverOptions.AddAdditionalCapability("appium:appium:appWaitForLaunch", false);

            Uri url = new Uri(Hooks.Hook.variables.BaseUriAppium);
            driver = new AndroidDriver<AppiumWebElement>(url, driverOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Hooks.Hook.variables.BaseTimeWait);
            return driver;

        }

    }

}
