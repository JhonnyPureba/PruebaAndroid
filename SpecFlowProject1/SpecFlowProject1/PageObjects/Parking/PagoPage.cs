using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class PagoPage
    {
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement modalPago;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoTarjeta;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoVencimiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoCVC;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoNombre;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoApellido;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement campoTextoEmail;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonPagar;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;

        public PagoPage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            PageFactory.InitElements(driver, this);
        }

        internal bool MuestraModalPagoConTarjeta()
        {
            return modalPago.Displayed;
        }
    }
}
