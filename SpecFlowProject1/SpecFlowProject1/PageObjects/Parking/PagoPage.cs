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
using NUnit.Framework;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class PagoPage
    {
        [FindsBy(How = How.XPath, Using = "//android.view.View[@text='Elige un medio de pago']")]
        private IWebElement modalPago;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Tarjeta de crédito y débito']")]
        private IWebElement radioButtonTarjetaDeCredito;
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@text='Continuar']")]
        private IWebElement botonContinuar;
        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Recuerda activar las compras')]")]
        private IWebElement formularioTarjeta;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='number']")]
        private IWebElement campoTextoTarjeta;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='expiry']")]
        private IWebElement campoTextoVencimiento;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='cvc']")]
        private IWebElement campoTextoCVC;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='name']")]
        private IWebElement campoTextoNombre;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='lastname']")]
        private IWebElement campoTextoApellido;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='email']")]
        private IWebElement campoTextoEmail;
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Pagar S/')]")]
        private IWebElement botonPagar;
        [FindsBy(How = How.XPath, Using = "//*[contains(@text,'Pago exitoso')]")]
        private IWebElement mensajePagoExitoso;
        [FindsBy(How = How.XPath, Using = "//*[contains(@text,'Pago rechazado')]")]
        private IWebElement mensajePagoRechazado;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text,'somos nosotros')]")]
        private IWebElement mensajeUpsNoEresTu;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text,'error en la confirmación de pago')]")]
        private IWebElement mensajeUpsErrorConfirmacionPago;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Ir a inicio']")]
        private IWebElement irAInicio;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Ver mi historial de pagos']")]
        private IWebElement botonVerMiHistorial;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[contains(@text,'S/')]")]
        private IWebElement montoPagado;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView[1]\r\n")]
        private IWebElement CheckTarjetaCreditoDebito;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.widget.Button\r\n")]
        private IWebElement Continuar;

        //COMPROBANTE 

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[3]/android.widget.TextView\r\n")]
        private IWebElement PagoexitosoVoucher;


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

        public void SeleccionarMetodoPagoTarjetaCreditoDebito()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(CheckTarjetaCreditoDebito));
            CheckTarjetaCreditoDebito.Click();
        }

        public void ClickContinuar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(Continuar));
            Continuar.Click();
        }

        public void IngresarNumeroTarjeta(string numtarjeta)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoTarjeta));
            campoTextoTarjeta.SendKeys(numtarjeta);
        }
        public void IngresarFechaVencimiento(string fechavencimiento)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoVencimiento));
            campoTextoVencimiento.SendKeys(fechavencimiento);
        }
        public void IngresarCVV(string CVV)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoCVC));
            campoTextoCVC.SendKeys(CVV);
        }
        public void IngresarNombres(string nombres)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoNombre));
            campoTextoNombre.SendKeys(nombres);
        }
        public void IngresarApellido(string apellido)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoApellido));
            campoTextoApellido.SendKeys(apellido);
        }
        public void IngresarEmail(string email)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(campoTextoEmail));
            campoTextoEmail.SendKeys(email);
        }
        public void ClickPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagar));
            botonPagar.Click();
        }
        public void VisualizarPagoExitoso()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(PagoexitosoVoucher));
            Assert.AreEqual(PagoexitosoVoucher.Text, "Pago exitoso");
        }

        //CAMBIOS DE KALIN DE ACA PA ABAJO

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
            Thread.Sleep(2000);
            return formularioTarjeta.Displayed;
        }

        internal void LlenarFormularioTarjetaCorrecta()
        {
            campoTextoTarjeta.SendKeys("5455460920094260");
            campoTextoVencimiento.SendKeys("03/28");
            campoTextoCVC.SendKeys("111");
            campoTextoNombre.SendKeys("Kalin");
            campoTextoApellido.SendKeys("Osorio");
            campoTextoEmail.SendKeys("kalinosorio18@gmail.com");
        }

        internal void LlenarFormularioTarjetaSinFondos()
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

        internal bool? MuestraPantallaPagoRechazado()
        {
            _wait.Until(d => { return mensajePagoRechazado.Displayed; });
            return mensajePagoRechazado.Displayed;
        }

        internal bool? MuestraPantallaEnchufeTransaccion()
        {
            _wait.Until(d => { return mensajeUpsNoEresTu.Displayed; });
            return mensajeUpsNoEresTu.Displayed;
        }

        internal void ClickIrAInicio()
        {
            _wait.Until(d => { return irAInicio.Displayed; });
            irAInicio.Click();
        }

        internal void BajarHastaVerMiHistorialDePagos()
        {
            action.Press(200, 1200).Wait(200).MoveTo(200, 900).Release().Perform();
        }

        internal double GetMontoPagado()
        {
            _wait.Until(d => { return montoPagado.Displayed; });
            return double.Parse(montoPagado.Text.Remove(0, 2));
        }

        internal bool MuestraMensajeUpsErrorCconfirmacionDelPago()
        {
            _wait.Until(d => { return mensajeUpsErrorConfirmacionPago.Displayed; });
            return mensajeUpsErrorConfirmacionPago.Displayed;
        }
    }
}
