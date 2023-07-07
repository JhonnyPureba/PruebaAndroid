using SpecFlowProject1.Utils;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using System.Reflection;
using Castle.Core;
using NUnit.Framework;
using SpecFlowMarketplaceMobileProject.PageObjects;
using MKPMobileProject.PageObjects;

namespace SpecFlowMarketplaceMobileProject.StepDefinitions
{
    [Binding]
    public class AppiumTestParkingStepDefinitions
    {
        TestContextSetup testContextSetup;
        PagoEstacionamientoPage pagoEstacionamiento;
        StartPage startPage;
        LoginPage loginPage;
        HomePage homePage;
        ScannerQRPage scannerQRPage;
        PagoPage pagoPage;
        GlobalPage globalPage;

        public AppiumTestParkingStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            pagoEstacionamiento = testContextSetup.pageObjectManager.GetPagoEstacionamiento();
            pagoPage = testContextSetup.pageObjectManager.GetPagoPage();
            startPage = testContextSetup.pageObjectManager.GetStartPage();
            loginPage = testContextSetup.pageObjectManager.GetLoginPage();
            homePage = testContextSetup.pageObjectManager.GetHomePage();
            scannerQRPage = testContextSetup.pageObjectManager.GetScannerQRPage();
            globalPage = testContextSetup.pageObjectManager.GetGlobalPage();
        }

        [Given(@"Selecciona opcion parking")]
        public void GivenSeleccionaOpcionParking()
        {
            homePage.ClickParking();
        }

        [Given(@"Selecciona opcion continuar")]
        public void GivenSeleccionaOpcionContinuar()
        {
            pagoEstacionamiento.ClickContinuar();
        }

        [Given(@"Selecciona opcion Ver mi historial de pagos")]
        public void GivenSeleccionaOpcionVerMiHistorialDePagos()
        {
            pagoEstacionamiento.ClickVerMiHistorial();
        }

        [When(@"Escanea qr")]
        public void WhenEscaneaQR()
        {
            pagoEstacionamiento.ClickBotonSubirQR();
            scannerQRPage.ClickPrimeraImagen();
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

        [When(@"Visualiza modal de establecimientos válidos")]
        public void WhenVisualizaModalDeEstablecimientosValidos()
        {

        }

        [Then(@"No Visualiza el boton de pagar")]
        public void ThenNoVisualizaBotonDePagar()
        {

        }

        [Then(@"Visualiza ""(.*)""")]
        public void ThenVisualizaTituloPantallaScanearYSubirQR(string titulo)
        {

        }

        [Then(@"Visualiza mensaje ""(.*)""")]
        public void ThenVisualizaMensajeDeFelicitaciones(string mensaje)
        {

        }

        [Then(@"Verificar que el descuento se aplique")]
        public void ThenVerificarQueElDescuentoSeAplique()
        {
            pagoEstacionamiento.VerificarDescuentoAplicado();
            pagoEstacionamiento.VerificarMontoAhorrado();
        }

        [Then(@"Verificar el monto y boton de descuento")]
        public void ThenVerificarElMontoYBotonDeDescuento()
        {
            pagoEstacionamiento.VerificarMontoPagar();
            pagoEstacionamiento.VerificarBotonDescuento();
        }


        [Then(@"Verificar error de pantalla")]
        public void ThenVerificarErrorDePantalla()
        {
            pagoEstacionamiento.VerificarPantallaErrorPagoDescuento();
        }

        [Then(@"Visualiza opcion Aplicar un descuento")]
        public void ThenVisualizaOpcionAplicarUnDescuento()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraBotonAplicarDescuento());
        }
        [Then(@"Visualiza monto a pagar")]
        public void ThenVisualizaMontoAPagar()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraMontoAPagar());
        }

        [When(@"Selecciona opcion Aplicar un descuento")]
        public void WhenSeleccionaOpcionAplicarUnDescuento()
        {
            pagoEstacionamiento.ClickAplicarUnDescuento();
        }

        [Then(@"Visualiza modal Aplicar un descuento")]
        public void ThenVisualizaModalAplicarUnDescuento()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraModalAplicarUnDescuento());
        }

        [When(@"Selecciona boton Aplicar descuento")]
        public void WhenSeleccionaBotonAplicarDescuento()
        {
            pagoEstacionamiento.clickAplicarDescuento();
        }

        [Then(@"Visualiza monto con descuento")]
        public void ThenVisualizaMontoConDescuento()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraMontoAPagarConDescuento());
        }

        [Then(@"Visualiza checkbox de terminos y condiciones")]
        public void ThenVisualizaCheckboxDeTerminosYCondiciones()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraCheckBoxTyC());
        }

        [Then(@"Visualiza boton Pagar deshabilitado")]
        public void ThenVisualizaBotonPagarDeshabilitado()
        {
            Assert.IsFalse(pagoEstacionamiento.BotonPagarHabilitado());
        }

        [Then(@"Visualiza boton Pagar deshabilitado de estacionamiento")]
        public void ThenVisualizaBotonPagarDeshabilitadoDeEstacionamiento()
        {
            pagoEstacionamiento.VerificarBotonPagarDeshabilitado();
        }

        [Given(@"Aplicar Codigo de Error ""([^""]*)""")]
        public void GivenAplicarCodigoDeError(string codigo)
        {
            homePage.ClickContactanos();
            homePage.ClickModoDesarrollador();
            homePage.CerrarVentanaContactanos();
            homePage.EnviarCodigoError(codigo);
        }

        [When(@"el usuario selecciona imagen de voucher")]
        public void WhenElUsuarioSeleccionaImagen()
        {
            pagoEstacionamiento.ClickBotonSubirQR();
            scannerQRPage.ClickImagenVoucher();
        }

        [Then(@"Verificar modal con imagen")]
        public void ThenVerificarModalSinImagen()
        {
            pagoEstacionamiento.VerificarModalAplicarDescuento();
        }

        [When(@"el usuario selecciona imagen Erronea de voucher")]
        public void WhenElUsuarioSeleccionaImagenErroneaDeVoucher()
        {
            pagoEstacionamiento.ClickBotonSubirQR();
            scannerQRPage.ClickImagenError();
        }

        [When(@"Marca checkbox de terminos y condiciones")]
        public void WhenMarcaCheckboxDeTerminosYCondiciones()
        {
            pagoEstacionamiento.ClickCheckBoxTyC();
        }

        [Then(@"Visualiza boton Pagar habilitado")]
        public void ThenVisualizaBotonPagarHabilitado()
        {
            Assert.IsTrue(pagoEstacionamiento.BotonPagarHabilitado());
        }

        [Then(@"Visualiza boton Pagar habilitado de estacionamiento")]
        public void ThenVisualizaBotonPagarHabilitadoDeEstacionamiento()
        {
            pagoEstacionamiento.VerificarBotonPagarHabilitado();
        }


        [When(@"Selecciona boton Pagar")]
        public void WhenSeleccionaBotonPagar()
        {
            pagoEstacionamiento.ClickBotonPagar();
        }

        [Then(@"Visualiza modal de pago con tarjeta")]
        public void ThenVisualizaModalDePagoConTarjeta()
        {
            Assert.IsTrue(pagoPage.MuestraModalPagoConTarjeta());
        }

        [When(@"Selecciona monto a pagar")]
        public void WhenSeleccionaMontoAPagar()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza pantalla de enchufe y numero de transaccion")]
        public void ThenVisualizaPantallaDeEnchufeYNumeroDeTransaccion()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualizar mensaje Lo sentimos, no se ha podido aplicar el descuento")]
        public void ThenVisualizarMensajeLoSentimosNoSeHaPodidoAplicarElDescuento()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraMensajeLoSentimos());
        }

        [When(@"Selecciona boton Pagar estacionamiento")]
        public void WhenSeleccionaBotonPagarEstacionamiento()
        {
            pagoEstacionamiento.ClickBotonPagarEstacionamiento();
        }

        [When(@"Se pierde conexion")]
        public void WhenSePierdeConexion()
        {
            globalPage.ApagarInternet();
        }

        [Then(@"Visualiza pantalla de error de conexion")]
        public void ThenVisualizaPantallaDeErrorDeConexion()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona opcion Validar ticket de compra")]
        public void WhenSeleccionaOpcionValidarTicketDeCompra()
        {
            pagoEstacionamiento.ClickBotonValidarTicketDeCompra();
        }

        [Then(@"Visualiza opcion Validar ticket de compra")]
        public void ThenVisualizaOpcionValidarTicketDeCompra()
        {
            Assert.IsTrue(pagoEstacionamiento.MuestraBotonValidarTicketDeCompra());
        }

        [Then(@"Visualiza modal Establecimientos validos")]
        public void ThenVisualizaModalEstablecimientosValidos()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal de descuento")]
        public void ThenVisualizaModalDeDescuento()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona boton Ver mi historial de pagos")]
        public void WhenSeleccionaBotonVerMiHistorialDePagos()
        {
            throw new PendingStepException();
        }

        [When(@"Scanea QR incorrecto")]
        public void WhenScaneaQRIncorrecto()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza mensaje de error")]
        public void ThenVisualizaMensajeDeError()
        {
            throw new PendingStepException();
        }

        [When(@"Acceder al dynamic link")]
        public void WhenAccederAlDynamicLink()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza Parking")]
        public void ThenVisualizaParking()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona link Conoce los terminos y condiciones")]
        public void WhenSeleccionaLinkConoceLosTerminosYCondiciones()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal Terminos y Condiciones")]
        public void ThenVisualizaModalTerminosYCondiciones()
        {
            throw new PendingStepException();
        }

        [When(@"Seleciona boton Aplicar descuento")]
        public void WhenSelecionaBotonAplicarDescuento()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza mensaje Felicitaciones se aplico el descuento exitosamente")]
        public void ThenVisualizaMensajeFelicitacionesSeAplicoElDescuentoExitosamente()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza pantalla de pago exitoso")]
        public void ThenVisualizaPantallaDePagoExitoso()
        {
            throw new PendingStepException();
        }

        [Given(@"El usuario se logea al app")]
        public void GivenElUsuarioSeLogeaAlApp()
        {
            startPage.ClickIniciarSesion();
            loginPage.ClickIngresarConTuCorreo();
            loginPage.IngresarEmail("pradoccorajhonnyangelo@gmail.com");
            loginPage.IngresarContrasena("Manzanita17");
            loginPage.ClickCheckBoxTyC();
            loginPage.ClickIngresar();
        }

        [Given(@"Selecciona opcion Mi cuenta")]
        public void GivenSeleccionaOpcionMiCuenta()
        {
            homePage.ClickMiCuenta();
        }
    }
}
