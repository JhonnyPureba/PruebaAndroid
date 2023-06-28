using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utils;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using System.Reflection;
using Castle.Core;
using SpecFlowProject1.PageObjects;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AppiumTestParkingStepDefinitions
    {
        TestContextSetup testContextSetup;
        AppiumTestStepDefinitions appiumTestStep;

        HomePage homepage;
        PagoEstacionamiento pagoEstacionamiento;
        ScannerQR scannerQR;
        HistorialPago historialPago;

        public AppiumTestParkingStepDefinitions(ScenarioContext scenarioContext)
        {
            appiumTestStep = new AppiumTestStepDefinitions(scenarioContext);
            testContextSetup = new TestContextSetup(scenarioContext);
            homepage = testContextSetup.pageObjectManager.GetHomePage();
            pagoEstacionamiento = testContextSetup.pageObjectManager.GetPagoEstacionamiento();
            scannerQR = testContextSetup.pageObjectManager.GetScannerQR();
            historialPago = testContextSetup.pageObjectManager.GetHistorialPago();
        }

        [Given(@"Selecciona opcion parking")]
        public void GivenSeleccionaOpcionParking()
        {
            homepage.ClickCloseModal();
            homepage.ClickOptionParking();
        }

        [Given(@"Selecciona opcion pago de estacionamiento")]
        public void GivenSeleccionaOpcionPagoEstacionamiento()
        {
            pagoEstacionamiento.ClickContinuar();
        }

        [When(@"Escanea qr")]
        public void WhenEscaneaQR()
        {
            scannerQR.ClickbotonQRGaleria();
            scannerQR.ClickOnlyThisTime();
            scannerQR.ClickBuscarRuta();
            scannerQR.ClickRutaDownloand();
            scannerQR.ClickImagenQR_999_19();
        }

        [When(@"Selecciona Modal aplicar descuento")]
        public void WhenSeleccionaModalAplicarDescuento()
        {

        }

        [When(@"Selecciona link terminos y condiciones")]
        public void WhenSeleccionaLinkTerminosYCondiciones()
        {

        }

        [When(@"Selecciona opcion aplicar descuento")]
        public void WhenSeleccionaOpcionAplicarDescuentoo()
        {

        }


        [When(@"Selecciona check terminos y condiciones")]
        public void WhenSeleccionaCheckTerminosYCondiciones()
        {

        }

        [When(@"Selecciona opcion pagar")]
        public void WhenSeleccionaOpcionPagar()
        {

        }

        [When(@"Completa datos de tarjeta")]
        public void WhenCompletaDatosDeTarjeta()
        {

        }

        [When(@"Visualiza modal de establecimientos validos")]
        public void WhenVisualizaModalDeEstablecimientosValidos()
        {

        }

        [Then(@"No Visualiza el boton de pagar")]
        public void ThenNoVisualizaBotonDePagar()
        {

        }

        [Then(@"Visualiza titulo Modal de Terminos y condiciones")]
        public void ThenVisualizaTituloModalDeTerminosYCondiciones()
        {

        }

        [Then(@"Visualiza mensaje de felicitaciones")]
        public void ThenVisualizaMensajeDeFelicitaciones()
        {

        }

        [Then(@"Visualiza titulo pantalla de pago exitoso")]
        public void ThenVisualizaTituloPantallaDePagoExitoso()
        {

        }

        [Then(@"Visualiza titulo Modal de Aplicar Descuento")]
        public void ThenVisualizaTituloModalDeAplicarDescuento()
        {

        }

        [Then(@"Visualiza mensaje lo sentimos no se ah podido aplicar la promo")]
        public void ThenVisualizaMensajeLoSentimosNoAplicarPromo()
        {

        }

        [Then(@"Visualiza mensaje de ups se agoto la promocion")]
        public void ThenVisualizaMensajeDeUpsSeAgotoLaPromocion()
        {

        }

        [Then(@"Visualiza titulo pantalla de monto a pagar y monto ahorrado")]
        public void ThenVisualizaTituloPantallaDeMontoAPagarYMontoAhorrado()
        {

        }

        [Then(@"Visualiza titulo pantalla de datos de tarjeta")]
        public void ThenVisualizaTituloPantallaDeDatosDeTarjeta()
        {

        }

        [Then(@"Visualiza titulo pantalla de error de conexion")]
        public void ThenVisualizaTituloPantallaDeErrorDeConexion()
        {

        }

        [Then(@"Visualiza titulo modal de establecimientos validos")]
        public void ThenVisualizaTituloModalDeEstablecimientosValidos()
        {

        }

        [Then(@"Visualiza titulo pantalla de escanear qr o subir qr desde galeria")]
        public void ThenVisualizaTituloPantallaDeScanearYSubirQRDesdeGaleria()
        {

        }

        [Then(@"Visualiza mensaje de validacion exitosa")]
        public void ThenVisualizaMensajeDeValidacionExitosa()
        {

        }

        [Then(@"Visualiza mensaje de qr invalido")]
        public void ThenVisualizaMensajeQRInvalido()
        {

        }

    }
}
