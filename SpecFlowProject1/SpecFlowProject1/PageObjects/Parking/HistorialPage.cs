using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class HistorialPage
    {
        //---------------------------
        //Elementos Historial de Pago
        //---------------------------
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        private IWebElement tituloHistorialDePagos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup")]
        private List<IWebElement> listaDePagos;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.view.ViewGroup[*]")]
        private List<IWebElement> listaDeNumerosDePagina;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonIrAPagar;

        //---------------------------
        //Elementos Historial de Pago: Detalle del pago
        //---------------------------
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[7]")]
        private IWebElement montoTotal;
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

        public bool MuestraPagosRechazados()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(listaDePagos[0]));
            return listaDePagos.Exists(item => item.Text.Contains("Rechazado"));
        }

        public bool MuestraTituloHistorial()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonDescargarComprobante));
            return tituloHistorialDePagos.Displayed;
        }
    }
}
