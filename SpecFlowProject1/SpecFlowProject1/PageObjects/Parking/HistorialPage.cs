using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using NUnit.Framework;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class HistorialPage
    {
        //---------------------------
        //Elementos Historial de Pago
        //---------------------------
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.widget.ImageView\r\n")]
        private IWebElement ImagenHistorialPagos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView\r\n")]
        private IWebElement tituloHistorialDePagos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[*]/android.widget.TextView[2]")]
        private IList<IWebElement> listaDePagos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.view.ViewGroup[*]")]
        private IList<IWebElement> listaDeNumerosDePagina;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonIrAPagar;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='¡Ups! Sin conexión a internet']")]
        private IWebElement mensajeUpsSinConexion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.view.ViewGroup[4]/android.widget.TextView\r\n")]
        private IWebElement botonSiguientePaginacion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[1]\r\n")]
        private IWebElement MessageErrorServicesHistorialPago;

        //---------------------------
        //Elementos Historial de Pago: Detalle del pago
        //---------------------------
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[7]")]
        private IWebElement montoTotal;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Detalle del pago']")]
        private IWebElement tituloDetalleDelPago;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajePagoExitoso;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonDescargarComprobante;

        //---------------------------
        //Elementos Historial de Pago: Pago
        //---------------------------
        //[FindsBy(How = How.XPath, Using = "")]
        //private IWebElement montoTotal;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[7]")]
        private IWebElement mensajeValidacionExitosa;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajePagoRechazado;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement MensajeLaTransaccionFueRechazada;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;

        public HistorialPage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            PageFactory.InitElements(driver, this);
        }

        public void ClickIrAPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonIrAPagar));
            botonIrAPagar.Click();
        }

        public void ClickDescargarComprobante()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonDescargarComprobante));
            botonDescargarComprobante.Click();
        }
        public bool MuestraTituloHistorial()
        {
            _wait.Until(driver =>
            {
                return tituloHistorialDePagos.Displayed;
            });
            Console.WriteLine("LLEGO ACA");
            return tituloHistorialDePagos.Displayed;
        }

        public bool MuestraPagosRechazados()
        {
            Console.WriteLine("LLEGO ACA 2");
            _wait.Until(d =>
            {
                return listaDePagos[0].Displayed;
            });
            Console.WriteLine(listaDePagos[0].Text);
            return listaDePagos.Any(item => item.Text.Contains("Rechazado"));
        }

        public void ClickEnUnPagoConPrecio()
        {
            Console.WriteLine("LLEGO ACA 3");
            _wait.Until(d =>
            {
                return listaDePagos[0].Displayed;
            });
            listaDePagos[0].Click();
        }

        internal bool MuestraDetalleDelPago()
        {
            _wait.Until(d =>
            {
                return tituloDetalleDelPago.Displayed;
            });
            return tituloDetalleDelPago.Displayed;
        }

        internal bool? MuestraMensajeUpsSinConexion()
        {
            _wait.Until(d =>
            {
                return mensajeUpsSinConexion.Displayed;
            });
            return mensajeUpsSinConexion.Displayed;
        }
        public void VerificarFuncionamientoPaginacion()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonSiguientePaginacion));
            botonSiguientePaginacion.Click();
        }
        public void VisualizarErrorHistorialPago()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(MessageErrorServicesHistorialPago));
            Assert.AreEqual(MessageErrorServicesHistorialPago.Text, "¡Ups! No eres tú, somos nosotros ");
        }
    }
}
