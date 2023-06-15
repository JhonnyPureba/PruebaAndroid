using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using Dynamitey.DynamicObjects;
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using OpenQA.Selenium.Appium.PageObjects.Attributes;

namespace SpecFlowProject1.PageObjects
{
    public class StartPage
    {
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]")]
        private IWebElement botonRegistrarme;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]")]
        private IWebElement botonIniciarSesion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView")]
        private IWebElement botonInvitado;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait Wait;

        public StartPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(driver, this);
        }

        public void ClickRegistrarme()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(botonRegistrarme));
            botonRegistrarme.Click();
        }

        public void ClickIniciarSesion()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(botonIniciarSesion));
            botonIniciarSesion.Click();
        }

        public void ClickSeguirComoInvitado()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(botonInvitado));
            botonInvitado.Click();
        }
    }
}
