﻿using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects
{
    public class RegisterPage
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Regístrate']")]
        private IWebElement mensajeRegisrtateEnRealPlaza;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Iniciar sesión']")]
        private IWebElement linkLogin;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;

        public RegisterPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            PageFactory.InitElements(driver, this);
        }

        internal bool MuestraPantallaDeRegistro()
        {
            _wait.Until(d => { return mensajeRegisrtateEnRealPlaza.Displayed; });
            return mensajeRegisrtateEnRealPlaza.Displayed;
        }

        internal void ClickLinkLogin()
        {
            _wait.Until(d => { return linkLogin.Displayed; });
            linkLogin.Click();
        }
    }
}
