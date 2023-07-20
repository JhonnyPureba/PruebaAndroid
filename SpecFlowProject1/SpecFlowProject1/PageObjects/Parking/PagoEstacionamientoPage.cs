using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class PagoEstacionamientoPage
    {
        //---------------------------
        //Elementos Guia de Pago de Estacionamiento
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]")]
        private IWebElement botonContinuar;  
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[2]")]
        private IWebElement botonVerMiHistorial;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[1]\r\n")]
        private IWebElement ModalSinServicioScanner;

        //---------------------------
        //Elementos Guia de Pago de Estacionamiento : Ticket de Compra
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup\r\n")]
        private IWebElement BotonContinuarTicketCompra;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView[2]\r\n")]
        private IWebElement MensajeTicketCompraNoValido;
        

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

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[15]")]
        private IWebElement botonSubirCodigoQRDesdeGaleria;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[15]/android.view.ViewGroup\r\n")]
        private IWebElement botonSubirCodigoQRDesdeGaleriaTicketCompra;



        //---------------------------
        //Elementos de Pago de Estacionamiento: Monto a Pagar
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        private IWebElement montoAPagar;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]")]
        private IWebElement botonValidarticketDecompra;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]")]
        private IWebElement botonAplicarUnDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView")]
        private IWebElement mensajeFelicitacionesSeAplicoElDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.widget.TextView")]
        private IWebElement montoAPagarConDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[2]")]
        private IWebElement mensajeAhorrasteEnTuPagoDeEstacionamiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajeLoSentimosNoSeHaPodidoAplicarElDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup\r\n")]
        private IWebElement botonPagarEstacionamiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement establecimientosValidos;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonContinuarEstablecimientosValidos;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement alertaValidacionExitosa;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.CheckBox")]
        private IWebElement checkBoxTyC;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[5]")]
        private IWebElement botonPagar;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup\r\n")]
        private IWebElement botonPagarLuegoDePagoEstacionamiento;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonContinuarImportante;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView\r\n")]
        private IWebElement TextFelicidadesDescuentoAplicado;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[2]\r\n")]
        private IWebElement TextMontoAhorradoDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[1]\r\n")]
        private IWebElement ModalTextPantallaErrorPagoDescuentoServicio;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView\r\n")]
        private IWebElement selectContentButonDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView[2]\r\n")]
        private IWebElement ModalTextPantallaErrorPagoDescuentoNoAplica;


        //---------------------------
        //Elementos de Pago de Estacionamiento: Monto a Pagar: Aplicar un descuento
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement modalAplicarUnDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        private IWebElement linkConoceLosTyC;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement imagenObtenDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup\r\n")]
        private IWebElement botonAplicarDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement tituloTyC;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement ModalTextDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]\r\n")]
        private IWebElement ValidarTicketCompraLuegoDeNoSeAplicoPromocion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[3]\r\n")]
        private IWebElement TextEstablecimientosValidos;

      

        //---------------------------
        //Elementos de Pago de Estacionamiento: ¡Ups! Sin conexion a internet
        //---------------------------

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonVolverAIntentarlo;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement linIrAlInicio;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajeUpsSinConexion;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement mensajeUpsNoEresTu;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement botonIrAlInicio;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[1]\r\n")]
        private IWebElement ModalUpsSinConexionScanner;


        //---------------------------
        //Elementos de Pago de Estacionamiento: Terminos y condiciones 
        //---------------------------

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement TituloLinkTerminosCondiciones;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView\r\n")]
        private IWebElement LinkTyCAplicarDescuento;

        //---------------------------
        //Elementos de Pago de Estacionamiento: pago 
        //---------------------------
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup\r\n")]
        private IWebElement ButonContinuarPago;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[1]\r\n")]
        private IWebElement MensajeErrorServicioPago;
        


        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView[2]")]
        //private By tituloMensajeValidacion;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[1]")]
        //private By descripcionMensajeValidacion;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[2]")]
        //private By subDescripcionMensajeValidacion;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.TextView")]
        //private IWebElement botonVolverIntentarlo;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView")]
        //private IWebElement linkIrAInicio;

        //[FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.widget.TextView")]
        //private By mensajeAyudaErrorQR;

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
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonContinuar));
            botonContinuar.Click();
        }
        public void ClickVerMiHistorial()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonVerMiHistorial));
            botonVerMiHistorial.Click();
        }

        public void ClickTyCAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(LinkTyCAplicarDescuento));
            LinkTyCAplicarDescuento.Click();
        }

        //public void VerificarTituloMensaje(string varTituloMensaje)
        //{
        //    _wait.Until(ExpectedConditions.ElementIsVisible(tituloMensajeValidacion));
        //    Assert.AreEqual(varTituloMensaje, Driver.FindElement(tituloMensajeValidacion).Text);
        //}
        //public void VerificarDescripcionMesaje(string varDescripcionMensaje)
        //{
        //    _wait.Until(ExpectedConditions.ElementIsVisible(descripcionMensajeValidacion));
        //    Assert.AreEqual(varDescripcionMensaje, Driver.FindElement(descripcionMensajeValidacion).Text);
        //}
        //public void VerificarSubDescripcionMensaje(string varSubDescripcionMensaje)
        //{
        //    _wait.Until(ExpectedConditions.ElementIsVisible(subDescripcionMensajeValidacion));
        //    Assert.AreEqual(varSubDescripcionMensaje, Driver.FindElement(subDescripcionMensajeValidacion).Text);

        //}
        //public void ClickVolverIntentarlo()
        //{
        //    _wait.Until(ExpectedConditions.ElementToBeClickable(botonVolverIntentarlo));
        //    botonVolverIntentarlo.Click();
        //}
        //public void ClickIrAInicio()
        //{
        //    _wait.Until(ExpectedConditions.ElementToBeClickable(linkIrAInicio));
        //    linkIrAInicio.Click();
        //}
        //public void VerificarMensajeAyudaErrorRQ(string varMensajeAyudaErrorQR)
        //{
        //    _wait.Until(ExpectedConditions.ElementIsVisible(mensajeAyudaErrorQR));
        //    Assert.AreEqual(varMensajeAyudaErrorQR, Driver.FindElement(mensajeAyudaErrorQR).Text);
        //}

        public bool NecesitaPermiso()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonOnlyThisTime));
            return botonOnlyThisTime.Displayed;
        }

        public void ClickBotonSubirQR()
        {
            if (NecesitaPermiso())
            {
                botonOnlyThisTime.Click();
            }
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonSubirCodigoQRDesdeGaleria));
            botonSubirCodigoQRDesdeGaleria.Click();
        }

        public void ClickBotonSubirQRTicketCompra()
        {

            _wait.Until(ExpectedConditions.ElementToBeClickable(botonSubirCodigoQRDesdeGaleriaTicketCompra));
            botonSubirCodigoQRDesdeGaleriaTicketCompra.Click();
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
        public void VerificarSinConexionScanner()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalUpsSinConexionScanner));
            Assert.AreEqual(ModalUpsSinConexionScanner.Text, "¡Ups! Sin conexión a internet");
        }
        public void VerificarSinServicioScanner()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalSinServicioScanner));
            Assert.AreEqual(ModalSinServicioScanner.Text, "¡Ups! No eres tú, somos nosotros ");
        }

        public void VerificarMensajeErrorTicketNoValidoTicketCompra()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(MensajeTicketCompraNoValido));
            Assert.AreEqual(MensajeTicketCompraNoValido.Text, "Ticket de compra no válido");
        }

        public void VerificarmensajeErrorPagoEstacionamiento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(MensajeErrorServicioPago));
            Assert.AreEqual(MensajeErrorServicioPago.Text, "¡Ups! No eres tú, somos nosotros ");
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

        public void VerificarPantallaErrorPagoDescuentoSERVICIO()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextPantallaErrorPagoDescuentoServicio));
            Assert.AreEqual(ModalTextPantallaErrorPagoDescuentoServicio.Text, "¡Ups! No eres tú, somos nosotros ");
        }
        public bool MuestraBotonAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonAplicarUnDescuento));
            return botonAplicarUnDescuento.Displayed;
        }

        public void VerificarPantallaErrorPagoDescuentoNoAplicaDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextPantallaErrorPagoDescuentoNoAplica));
            Assert.AreEqual(ModalTextPantallaErrorPagoDescuentoNoAplica.Text, "Lo sentimos, no se ha podido aplicar el\r\ndescuento");
        }

        public void ClickAplicarUnDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonAplicarUnDescuento)); 
            botonAplicarUnDescuento.Click();
        }
        public void ClickContinuarValidarTicketComprar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(BotonContinuarTicketCompra));
            BotonContinuarTicketCompra.Click();
        }

        
        public bool MuestraModalAplicarUnDescuento()
        {
            return modalAplicarUnDescuento.Displayed;
        }

        public bool MuestraMontoAPagarConDescuento()
        {
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
            botonPagar.Click();
            Thread.Sleep(3000);
            return !botonPagar.Displayed;
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
            return checkBoxTyC.Displayed;
        }

        public void clickAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonAplicarDescuento));
            botonAplicarDescuento.Click();
        }

        public void ClickCheckBoxTyC()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxTyC));
            checkBoxTyC.Click();
        }
        public void ClickTicketCompraLuegodeNoAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ValidarTicketCompraLuegoDeNoSeAplicoPromocion));
            ValidarTicketCompraLuegoDeNoSeAplicoPromocion.Click();
        }

        
        public void ClickBotonPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagar));
            botonPagar.Click();
        }

        internal void ClickBotonPagarEstacionamiento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonPagarEstacionamiento));
            botonPagarEstacionamiento.Click();
        }

        internal bool MuestraMensajeLoSentimos()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(mensajeLoSentimosNoSeHaPodidoAplicarElDescuento));
            return mensajeLoSentimosNoSeHaPodidoAplicarElDescuento.Displayed;
        }

        internal bool MuestraBotonValidarTicketDeCompra()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonValidarticketDecompra));
            return botonValidarticketDecompra.Displayed;
        }

        internal void ClickBotonValidarTicketDeCompra()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonValidarticketDecompra));
            botonValidarticketDecompra.Click();
        }

        public void VerificarTituloLinkTerminosCondiciones()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TituloLinkTerminosCondiciones));
            Assert.AreEqual(TituloLinkTerminosCondiciones.Text, "Términos y Condiciones");
        }
        public void VerificarTituloEstablecimientosValidos()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TextEstablecimientosValidos));
            Assert.AreEqual(TextEstablecimientosValidos.Text, "Establecimientos válidos");
        }
                
        public void ClickContinuarPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ButonContinuarPago));
            ButonContinuarPago.Click();
            Thread.Sleep(1000);
        }

    }
}
