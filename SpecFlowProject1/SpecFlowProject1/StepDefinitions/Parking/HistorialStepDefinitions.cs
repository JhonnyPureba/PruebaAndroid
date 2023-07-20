using NUnit.Framework;
using SpecFlowMarketplaceMobileProject.PageObjects;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using SpecFlowProject1.Utils;

namespace SpecFlowMarketplaceMobileProject.StepDefinitions.Parking
{
    [Binding]
    public class HistorialStepDefinitions
    {
        TestContextSetup testContextSetup;
        HistorialPage historialPage;
        ScenarioContext _scenarioContext;

        public HistorialStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            _scenarioContext = scenarioContext;
            historialPage = testContextSetup.pageObjectManager.GetHistorialPage();

        }

        [Then(@"Visualiza Historial de pagos")]
        public void ThenVisualizaHistorialDePagos()
        {
            Assert.IsTrue(historialPage.MuestraTituloHistorial());
        }

        [Then(@"Visualiza que el ultimo monto pagado sea correcto")]
        public void ThenVerificaQueElUltimoMontoPagadoSeaCorrecto()
        {
            Assert.AreEqual(historialPage.GetUltimoMontoPagado(), _scenarioContext.Get<double>("ultimoMontoPagadoEnParking"));
        }

        [Then(@"Visualiza pagos rechazado en color rojito")]
        public void ThenVisualizaPagosRechazadoEnColorRojito()
        {
            Assert.IsTrue(historialPage.MuestraPagosRechazados());
        }

        [Then(@"Verificar la paginacion en historial de pagos")]
        public void ThenVerificarLaPaginacionEnHistorialDePagos()
        {
            historialPage.VerificarFuncionamientoPaginacion();
        }

        [When(@"Selecciona un pago")]
        public void WhenSeleccionaUnPago()
        {
            historialPage.ClickEnUnPagoConPrecio();
        }

        [Then(@"Visualiza detalle del pago")]
        public void ThenVisualizaDetalleDelPago()
        {
            Assert.IsTrue(historialPage.MuestraDetalleDelPago());
        }

        [Then(@"Visualiza Error en el Historial de pagos")]
        public void ThenVisualizaErrorEnElHistorialDePagos()
        {
            Assert.AreEqual(historialPage.VisualizarErrorHistorialPago(), "¡Ups! No eres tú, somos nosotros ");
        }

        [Then(@"Visualiza ultimo pago de S/0.00")]
        public void ThenVisualizaUltimoPagoDe0soles()
        {
            Assert.AreEqual(historialPage.GetUltimoMontoPagado(), 0.00);
        }
    }
}
