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

        //Boton parking Cuando hay banner
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")]
        //Boton parking Cuando no hay banner
        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup")]
        private IWebElement botonParking;
                
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]")]
        private IWebElement elementoBajoParking;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup")]
        private IWebElement bannerPromo;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Contáctanos']")]
        private IWebElement Contactanos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement BotonModoError;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.widget.TextView")]
        private IWebElement iconoBichito;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement CerrarContactanos;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText")]
        private IWebElement IngresarCodigoError;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Guardar']")]
        private IWebElement GuardarCodigoError;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.Button[4]")]
        private IWebElement miCuenta;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;
        private readonly Actions actions;
        private Size dimensions;

        public HomePage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            actions = new Actions(driver);
            dimensions = driver.Manage().Window.Size;
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
                Thread.Sleep(1500);
            }else 

            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0))" + ".scrollIntoView(new UiSelector()" + ".textMatches(\"" + "Descubre Real Plaza" + "\").instance(0))");

            _wait.Until(d =>
            {
                return botonParking.Displayed;
            });
            botonParking.Click();
        }
        public void ClickParkingDirect()
        {
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0))" + ".scrollIntoView(new UiSelector()" + ".textMatches(\"" + "Descubre Real Plaza" + "\").instance(0))");

            _wait.Until(d =>    {    return botonParking.Displayed;     });
            botonParking.Click();
        }

        public void ClickContactanos()
        {
            if (IsBannerPromo())
            {
                bannerPromo.Click();
            }
            Thread.Sleep(5000);  
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0))"+".scrollIntoView(new UiSelector()"+".textMatches(\"" + "Contáctanos"+ "\").instance(0))");
            //_wait.Until(ExpectedConditions.ElementToBeClickable(Contactanos));
            _wait.Until(d => { return Contactanos.Displayed; });
             Contactanos.Click();
        }

        public void ClickModoDesarrollador()
        {
            Thread.Sleep(5000);
            action.LongPress(0, 1500).MoveTo(0, 700).Release().Perform();
            _wait.Until(d => { return BotonModoError.Displayed; });
            Thread.Sleep(1000);
            while (true)
            {

                for (int i = 0; i < 6; i++)
                {
                    BotonModoError.Click();
                }
                Thread.Sleep(1000);
                try { if (iconoBichito.Displayed) { break; } } 
                catch (Exception e) { }
            }
            Thread.Sleep(1000);
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
            Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0))" + ".scrollIntoView(new UiSelector()" + ".textMatches(\"" + "Descubre Real Plaza" + "\").instance(0))");
        }

        public void EnviarCodigoError(String codigo)
        {
            Thread.Sleep(5000);
            IngresarCodigoError.SendKeys(codigo);
            GuardarCodigoError.Click();
        }

        internal void ClickMiCuenta()
        {
            if (IsBannerPromo())
            {
                bannerPromo.Click();
                Thread.Sleep(1500);
            }
            _wait.Until(ExpectedConditions.ElementToBeClickable(miCuenta));
            miCuenta.Click();
        }
        public void ClickMiCuentaDirect()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(miCuenta));
            miCuenta.Click();
        }

    }
    }



