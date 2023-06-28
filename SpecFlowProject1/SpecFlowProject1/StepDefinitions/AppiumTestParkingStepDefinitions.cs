using SpecFlowProject1.Utils;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using System.Reflection;
using Castle.Core;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AppiumTestParkingStepDefinitions
    {
        TestContextSetup testContextSetup;
        PagoEstacionamiento pagoEstacionamiento;

        public AppiumTestParkingStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            pagoEstacionamiento = testContextSetup.pageObjectManager.GetPagoEstacionamiento();
        }

        [Given(@"Selecciona opcion parking")]
        public void GivenSeleccionaOpcionParking()
        {
            pagoEstacionamiento.ClickContinuar();
        }

        [Given(@"Selecciona opcion pago de estacionamiento")]
        public void GivenSeleccionaOpcionPagoEstacionamiento()
        {
           
        }

        [When(@"Escanea qr")]
        public void WhenEscaneaQR()
        {

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

        [Then(@"Visualiza opcion Aplicar un descuento")]
        public void ThenVisualizaOpcionAplicarUnDescuento()
        {
            throw new PendingStepException();
        }
        [Then(@"Visualiza monto a pagar")]
        public void ThenVisualizaMontoAPagar()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona opcion Aplicar un descuento")]
        public void WhenSeleccionaOpcionAplicarUnDescuento()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal Aplicar un descuento sin imagen")]
        public void ThenVisualizaModalAplicarUnDescuentoSinImagen()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal Aplicar un descuento con imagen")]
        public void ThenVisualizaModalAplicarUnDescuentoConImagen()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona boton Aplicar descuento")]
        public void WhenSeleccionaBotonAplicarDescuento()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza monto con descuento")]
        public void ThenVisualizaMontoConDescuento()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza checkbox de terminos y condiciones")]
        public void ThenVisualizaCheckboxDeTerminosYCondiciones()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza boton Pagar deshabilitado")]
        public void ThenVisualizaBotonPagarDeshabilitado()
        {
            throw new PendingStepException();
        }

        [When(@"Marca checkbox de terminos y condiciones")]
        public void WhenMarcaCheckboxDeTerminosYCondiciones()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza boton Pagar habilitado")]
        public void ThenVisualizaBotonPagarHabilitado()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona boton Pagar")]
        public void WhenSeleccionaBotonPagar()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal de pago con tarjeta")]
        public void ThenVisualizaModalDePagoConTarjeta()
        {
            throw new PendingStepException();
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
            throw new PendingStepException();
        }

        [When(@"Selecciona boton Pagar estacionamiento")]
        public void WhenSeleccionaBotonPagarEstacionamiento()
        {
            throw new PendingStepException();
        }

        [When(@"Se pierde conexion")]
        public void WhenSePierdeConexion()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza pantalla de error de conexion")]
        public void ThenVisualizaPantallaDeErrorDeConexion()
        {
            throw new PendingStepException();
        }

        [When(@"Selecciona opcion Validar ticket de compra")]
        public void WhenSeleccionaOpcionValidarTicketDeCompra()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal Establecimientos validos")]
        public void ThenVisualizaModalEstablecimientosValidos()
        {
            throw new PendingStepException();
        }

        [Then(@"Visualiza modal Aplicar un descuento")]
        public void ThenVisualizaModalAplicarUnDescuento()
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

        [Then(@"Visualiza Historial de pagos")]
        public void ThenVisualizaHistorialDePagos()
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

    }
}
