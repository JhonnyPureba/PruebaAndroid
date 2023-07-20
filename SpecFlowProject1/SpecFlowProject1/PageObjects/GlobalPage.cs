using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Net.NetworkInformation;

namespace MKPMobileProject.PageObjects
{
    public class GlobalPage
    {
        //Elementos Modal ¡Conexion perdida!
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Cancelar']")]
        private IWebElement botonCancelar;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;

        public GlobalPage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            PageFactory.InitElements(driver, this);
        }

        internal void ApagarInternet()
        {
            Driver.ToggleWifi();
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonCancelar));
            botonCancelar.Click();

        }
    }
}