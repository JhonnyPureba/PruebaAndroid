using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Drawing;

namespace MKPMobileProject.PageObjects.MiCuenta
{
    public class MiCuentaPage
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Mi cuenta']")]
        private IWebElement tituloMiCuenta;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Mis pagos de estacionamiento']")]
        private IWebElement botonMisPagosDeEstacionamiento;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;
        private readonly Actions actions;
        private Size dimensions;

        public MiCuentaPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            actions = new Actions(driver);
            dimensions = driver.Manage().Window.Size;
            PageFactory.InitElements(driver, this);
        }

        internal bool MuestraTituloMimCuenta()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(tituloMiCuenta));
            return tituloMiCuenta.Displayed;
        }

        internal void ClickMisPagosDeEstacionamiento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonMisPagosDeEstacionamiento));
            botonMisPagosDeEstacionamiento.Click();
        }
    }
}
