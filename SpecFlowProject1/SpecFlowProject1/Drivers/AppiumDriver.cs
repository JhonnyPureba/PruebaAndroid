using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }


        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();

            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            //datos de Kalin
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "HONOR X7a");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "ANKG9X3308G01331");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\Kratos\Downloads\app-release.apk");

            //datos de Jhonny
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "b0dbb66b");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\Administrador\Downloads\app-release.apk");
            //
            driverOptions.AddAdditionalCapability("appWaitPackage", "com.realplazago.app");
            driverOptions.AddAdditionalCapability("appWaitActivity", "com.realplazago.app.MainActivity");
            //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
            //AppiumService.Start();
            return new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions);
        }
    }
}
