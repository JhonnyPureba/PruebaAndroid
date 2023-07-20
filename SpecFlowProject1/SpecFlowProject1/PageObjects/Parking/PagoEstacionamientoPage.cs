using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using Dynamitey.DynamicObjects;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class PagoEstacionamientoPage
    {
        //---------------------------
        //Elementos Guia de Pago de Estacionamiento
        //---------------------------

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Continuar']")]
        private IWebElement botonContinuar;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Ver mi historial de pagos']")]
        private IWebElement botonVerMiHistorial;

        //--------------------------
        //Elementos para dar permisos
        //--------------------------
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_foreground_only_button")]
        private IWebElement botonWhileUseApp;
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_one_time_button")]
        private IWebElement botonOnlyThisTime;
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_deny_button")]
        private IWebElement botonDontAllow;

        //---------------------------
        //Elementos de Pago de Estacionamiento: Escanear QR ticket de estacionamiento
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[15]/android.view.ViewGroup")]
        private IWebElement botonSubirCodigoQRDesdeGaleria;

        //---------------------------
        //Elementos de Pago de Estacionamiento: Monto a Pagar
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        private IWebElement montoAPagar;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Validar ticket de compra']")]
        private IWebElement botonValidarticketDecompra;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Aplicar un descuento']")]
        private IWebElement botonAplicarUnDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView")]
        private IWebElement mensajeFelicitacionesSeAplicoElDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView")]
        private IWebElement montoAPagarConDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[2]")]
        private IWebElement mensajeAhorrasteEnTuPagoDeEstacionamiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajeLoSentimosNoSeHaPodidoAplicarElDescuento;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Pagar estacionamiento']")]
        private IWebElement botonPagarEstacionamiento;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Establecimientos válidos']")]
        private IWebElement establecimientosValidos;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonContinuarEstablecimientosValidos;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement alertaValidacionExitosa;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.CheckBox")]
        private IWebElement checkBoxTyC;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Pagar']/../..")]
        private IWebElement botonPagar;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup")]
        private IWebElement botonPagarLuegoDePagoEstacionamiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonContinuarImportante;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView")]
        private IWebElement TextFelicidadesDescuentoAplicado;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[2]")]
        private IWebElement TextMontoAhorradoDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView[2]\r\n")]
        private IWebElement ModalTextPantallaErrorPagoDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView\r\n")]
        private IWebElement selectContentButonDescuento;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Importante']")]
        private IWebElement modalImportante;

        //---------------------------
        //Elementos de Pago de Estacionamiento: Monto a Pagar: Aplicar un descuento
        //---------------------------

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Aplicar un descuento']")]
        private IWebElement modalAplicarUnDescuento;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Conoce los términos y condiciones']")]
        private IWebElement linkConoceLosTyC;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Términos y Condiciones']")]
        private IWebElement modalTyC;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement imagenObtenDescuento;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Aplicar descuento']")]
        private IWebElement botonAplicarDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement tituloTyC;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement ModalTextDescuento;



        //---------------------------
        //Elementos de Pago de Estacionamiento: ¡Ups! Sin conexion a internet, ¡Ups! Error de imagen, ¡Ups! No eres tu, somos nosotros
        //---------------------------

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Volver a escanear']")]
        private IWebElement botonVolverAEscanear;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Ir al inicio']")]
        private IWebElement linIrAlInicio;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='¡Ups! Sin conexión a internet']")]
        private IWebElement mensajeUpsSinConexion;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='¡Ups! Tenemos problemas al escanear tu ticket de estacionamiento']")]
        private IWebElement mensajeUpsTenemosProblemasAlEscanear;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajeUpsNoEresTu;


        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;

        public PagoEstacionamientoPage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            PageFactory.InitElements(driver, this);
        }
        public void ClickContinuar()
        {
            _wait.Until(d => { return botonContinuar.Displayed; }); 
            botonContinuar.Click();
        }
        public void ClickVerMiHistorial()
        {
            _wait.Until(d => { return botonVerMiHistorial.Displayed; });
            //Driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0))" + ".scrollIntoView(new UiSelector()" + ".textMatches('Ver mi historial de pagos').instance(0))");
            botonVerMiHistorial.Click(); 
        }

        public bool NecesitaPermiso()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonOnlyThisTime));
            return botonOnlyThisTime.Displayed;
        }

        public void DarPermiso()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonOnlyThisTime));
           botonOnlyThisTime.Click();
        }

        public void ClickBotonSubirQR()
        {
            //_wait.Until(d => { return botonSubirCodigoQRDesdeGaleria.Displayed; });
            Thread.Sleep(2000);
            //int l = botonSubirCodigoQRDesdeGaleria.Size.Width;
            //int h = botonSubirCodigoQRDesdeGaleria.Size.Height;
            //Point point = botonSubirCodigoQRDesdeGaleria.Location;
            //int getX = point.X;
            //int getY = point.Y;
            //int middleX = (int)(getX + l * 0.5);
            //int middleY = (int)(getY + h * 0.5);
            action.Tap(360, 1452).Perform();
            //action.Tap(middleX, middleY).Perform();
            //botonSubirCodigoQRDesdeGaleria.Click();
        }

        public void VerificarMontoPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(montoAPagar));
            Assert.AreEqual(montoAPagar.Text, "S/0.35");

        }

        public void VerificarBotonDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectContentButonDescuento));
            Assert.AreEqual(selectContentButonDescuento.Text, "");
        }

        public void VerificarModalAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextDescuento));
            Assert.AreEqual(ModalTextDescuento.Text, "Obtendrás un descuento especial en tu monto a pagar.");
        }

        public void VerificarDescuentoAplicado()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TextFelicidadesDescuentoAplicado));
            Assert.AreEqual(TextFelicidadesDescuentoAplicado.Text, "¡Felicitaciones, se aplicó el descuento exitosamente!");
        }

        public void VerificarMontoAhorrado()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TextMontoAhorradoDescuento));
            Assert.AreEqual(TextMontoAhorradoDescuento.Text, "Ahorraste S/1.00 en tu pago de estacionamiento");

        }

        public bool MuestraMontoAPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(montoAPagar));
            return montoAPagar.Displayed;
        }

        public void VerificarPantallaErrorPagoDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextPantallaErrorPagoDescuento));
            Assert.AreEqual(ModalTextPantallaErrorPagoDescuento.Text, "Lo sentimos, no se ha podido aplicar el\r\ndescuento");
        }
        public bool MuestraBotonAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonAplicarUnDescuento));
            return botonAplicarUnDescuento.Displayed;
        }

        public void ClickAplicarUnDescuento()
        {
            _wait.Until(d => { return botonAplicarUnDescuento.Displayed; });
            botonAplicarUnDescuento.Click();
        }

        public bool MuestraModalAplicarUnDescuento()
        {
            _wait.Until(d => { return modalAplicarUnDescuento.Displayed; });
            return modalAplicarUnDescuento.Displayed;
        }

        public void ClickconoceLosTyC()
        {
            _wait.Until(d => { return linkConoceLosTyC.Displayed; }); 
            linkConoceLosTyC.Click();
        }

        public bool MuestraModalTerminosYCondiciones()
        {
            _wait.Until(d => { return modalTyC.Displayed; });
            return modalTyC.Displayed;
        }

        public bool MuestraMontoAPagarConDescuento()
        {
            _wait.Until(d => { return montoAPagarConDescuento.Displayed; }); 
            return montoAPagarConDescuento.Displayed;
        }

        public bool CheckEstadohabilitadoBotonPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagarLuegoDePagoEstacionamiento));
            return botonPagarLuegoDePagoEstacionamiento.Displayed;
        }

        public void ClicBotonPagarLuegoDePagarEstacionamiento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagarLuegoDePagoEstacionamiento));
            botonPagarLuegoDePagoEstacionamiento.Click();
        }

        public void VerificarBotonPagarHabilitado()
        {
            if (CheckEstadohabilitadoBotonPagar())
            {
                System.Console.WriteLine("BOTON HABILITADO");
                ClicBotonPagarLuegoDePagarEstacionamiento();
            }
            else
                System.Console.WriteLine("BOTON DESHABILITADO");
        }


        public void VerificarBotonPagarDeshabilitado()
        {
            if (CheckEstadohabilitadoBotonPagar())
            {
                System.Console.WriteLine("BOTON DESHABILITADO");
            }
            else
                System.Console.WriteLine("BOTON HABILITADO");
        }

        public bool BotonPagarHabilitado()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagar));
            botonPagar.Click();
            Thread.Sleep(3000);
            try
            {
                return botonPagar.Displayed;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool ValidarBotonVerMiHistorialdePagos()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonVerMiHistorial));
            return botonVerMiHistorial.Displayed;
        }

        public bool BotonPagarHabilitadoLuegoDePagarEstacionaminto()
        {
            botonPagarLuegoDePagoEstacionamiento.Click();
            Thread.Sleep(3000);
            return !botonPagar.Displayed;
        }

        public bool MuestraCheckBoxTyC()
        {
            _wait.Until(d => { return checkBoxTyC.Displayed; }); 
            return checkBoxTyC.Displayed;
        }

        public void clickAplicarDescuento()
        {
            _wait.Until(d => { return botonAplicarDescuento.Displayed; });
            botonAplicarDescuento.Click();
        }

        public void ClickCheckBoxTyC()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxTyC));
            checkBoxTyC.Click();
        }

        public void ClickBotonPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagar));
            botonPagar.Click();
        }

        public void ClickBotonPagarEstacionamiento()
        {
            _wait.Until(d => { return botonPagarEstacionamiento.Displayed; });
            Thread.Sleep(2000);
            botonPagarEstacionamiento.Click();
        }

        public bool MuestraMensajeLoSentimos()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(mensajeLoSentimosNoSeHaPodidoAplicarElDescuento));
            return mensajeLoSentimosNoSeHaPodidoAplicarElDescuento.Displayed;
        }

        public bool MuestraBotonValidarTicketDeCompra()
        {
            _wait.Until(d => { return botonValidarticketDecompra.Displayed; });
            return botonValidarticketDecompra.Displayed;
        }

        public void ClickBotonValidarTicketDeCompra()
        {
            _wait.Until(d => { return botonValidarticketDecompra.Displayed; });
            botonValidarticketDecompra.Click();
        }

        public bool MuestraMensajeErrorDeImagen()
        {
            _wait.Until(d => { return mensajeUpsTenemosProblemasAlEscanear.Displayed;});
            return mensajeUpsTenemosProblemasAlEscanear.Displayed;
        }

        public bool MuestraMensajeErrorDeConexion()
        {
            _wait.Until(d => { return mensajeUpsSinConexion.Displayed; });
            return mensajeUpsSinConexion.Displayed;
        }

        public bool MuestraSubirQR()
        {

            //if (NecesitaPermiso())
            //{
            //    botonOnlyThisTime.Click();
            //}
            DarPermiso();
            _wait.Until(d => { return botonSubirCodigoQRDesdeGaleria.Displayed; });
            return botonSubirCodigoQRDesdeGaleria.Displayed;
        }

        internal bool? MuestraMensajeFelicitacionesSeAplicoDescuento()
        {
            _wait.Until(d => { return mensajeFelicitacionesSeAplicoElDescuento.Displayed; });
            return mensajeFelicitacionesSeAplicoElDescuento.Displayed;
        }

        internal bool? MuestraModalImportante()
        {
            _wait.Until(d => { return modalImportante.Displayed; });
            return modalImportante.Displayed;
        }

        internal bool MuestraEstacionamientosValidos()
        {
            _wait.Until(d => { return establecimientosValidos.Displayed; });
            return establecimientosValidos.Displayed;
        }
    }
}
