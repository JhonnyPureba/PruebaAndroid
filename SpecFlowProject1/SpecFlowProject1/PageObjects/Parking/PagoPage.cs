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
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View")]
        private IWebElement modalPago;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView[1]")]
        private IWebElement radioButtonTarjetaDeCredito;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView[1]")]
        private IWebElement botonContinuar;
        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Recuerda activar las compras')]")]
        private IWebElement formularioTarjeta;
        [FindsBy(How = How.Id, Using = "number")]
        private IWebElement campoTextoTarjeta;
        [FindsBy(How = How.Id, Using = "expiry")]
        private IWebElement campoTextoVencimiento;
        [FindsBy(How = How.Id, Using = "cvc")]
        private IWebElement campoTextoCVC;
        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement campoTextoNombre;
        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement campoTextoApellido;
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement campoTextoEmail;
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Pagar S/')]")]
        private IWebElement botonPagar;
        [FindsBy(How = How.XPath, Using = "//*[contains(@text,'Pago exitoso')]")]
        private IWebElement mensajePagoExitoso;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text,'somos nosotros')]")]
        private IWebElement mensajeUpsNoEresTu;

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

        internal bool MuestraModalEligeUnMedioDePago()
        {
            _wait.Until(d => { return modalPago.Displayed; });
            return modalPago.Displayed;
        }

        internal void ClickEnTarjetaDeCredito()
        {
            _wait.Until(d => { return radioButtonTarjetaDeCredito.Displayed; });
            radioButtonTarjetaDeCredito.Click();
        }

        internal void ClickEnContinuar()
        {
            _wait.Until(d => { return botonContinuar.Displayed; });
            botonContinuar.Click();
        }

        internal bool? MuestraFormularioPagoTarjeta()
        {
            _wait.Until(d => { return formularioTarjeta.Displayed; });
            return formularioTarjeta.Displayed;
        }

        internal void LlenarFormularioTarjetaCorrecta()
        {
            campoTextoTarjeta.SendKeys("5115422225052734");
            campoTextoVencimiento.SendKeys("09/23");
            campoTextoCVC.SendKeys("111");
            campoTextoNombre.SendKeys("Kalin");
            campoTextoApellido.SendKeys("Osorio");
            campoTextoEmail.SendKeys("kalinosorio18@gmail.com");
        }

        internal void ClickPagarMonto()
        {
            _wait.Until(d => { return botonPagar.Displayed; });
            botonPagar.Click();
        }

        internal bool? MuestraPantallaPagoExitoso()
        {
            _wait.Until(d => { return mensajePagoExitoso.Displayed; });
            return mensajePagoExitoso.Displayed;
        }

        internal bool? MuestraPantallaEnchufeTransaccion()
        {
            _wait.Until(d => { return mensajeUpsNoEresTu.Displayed; });
            return mensajeUpsNoEresTu.Displayed;
        }
    }
}
