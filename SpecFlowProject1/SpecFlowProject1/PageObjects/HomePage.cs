﻿using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Drawing;
using System;
using static System.Collections.Specialized.BitVector32;
using OpenQA.Selenium.Appium.Interfaces;
using Newtonsoft.Json.Linq;
using Gherkin.CucumberMessages.Types;

namespace SpecFlowMarketplaceMobileProject.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]")]
        private IWebElement botonRegistrarme;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]")]
        private IWebElement botonIniciarSesion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView")]
        private IWebElement botonInvitado;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView\r\n")]
        private IWebElement botonParking;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup")]
        private IWebElement bannerPromo;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup[2]/android.widget.TextView\r\n")]
        private IWebElement Contactanos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement BotonModoError;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement CerrarContactanos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.widget.EditText\r\n")]
        private IWebElement IngresarCodigoError;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup\r\n")]
        private IWebElement GuardarCodigoError;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;
        private readonly TouchAction act;
        private readonly Size dimensions;
        private readonly IJavaScriptExecutor jse;

        public HomePage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            dimensions = driver.Manage().Window.Size;
            jse = (IJavaScriptExecutor)driver;
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            PageFactory.InitElements(driver, this);
        }

        public bool IsBannerPromo()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(bannerPromo));
            return bannerPromo.Displayed;
        }
        public void ClickParking()
        {
            if (IsBannerPromo())
            {
                bannerPromo.Click();
            }
            Thread.Sleep(5000);
            action.LongPress(0,1000).MoveTo(0,500).Release().Perform();
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonParking));
            botonParking.Click();
        }

        public void ClickContactanos()
        {
            if (IsBannerPromo())
            {
                bannerPromo.Click();
            }
            Thread.Sleep(5000);
            action.LongPress(0, 2180).MoveTo(0, 0).Release().Perform();
            _wait.Until(ExpectedConditions.ElementToBeClickable(Contactanos));
            Contactanos.Click();
        }

        public void ClickModoDesarrollador()
        {
            Thread.Sleep(5000);
            action.LongPress(0, 1800).MoveTo(0, 1000).Release().Perform();
            _wait.Until(ExpectedConditions.ElementToBeClickable(BotonModoError));
            for (int i = 0; i < 8; i++)
            {
                BotonModoError.Click();
            }
        }

        public void CerrarVentanaContactanos()
        {
            Driver.PressKeyCode(AndroidKeyCode.Back);
            Thread.Sleep(5000);
            action.LongPress(0, 1800).MoveTo(0, 1000).Release().Perform();
        }

        public void SubirAParking()
        {
            Thread.Sleep(5000);
            //action.LongPress(500, -1500).MoveTo(500, 2000).Release().Perform();
            //action.MoveTo(botonParking);
            //action.Perform();
            //jse.ExecuteScript("ventana.scrollBy(0,250)", "");
            jse.ExecuteScript("Window.scrollBy(0, 500)");
            Driver.PressKeyCode(AndroidKeyCode.ActionUp);

        }

        public void EnviarCodigoError(String codigo)
        {
            IngresarCodigoError.SendKeys(codigo);
            GuardarCodigoError.Click();
            

        }
    }
}
