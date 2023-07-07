using NUnit.Framework;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using SpecFlowProject1.Utils;

namespace SpecFlowMarketplaceMobileProject.StepDefinitions.Parking
{
    [Binding]
    public class HistorialStepDefinitions
    {
        TestContextSetup testContextSetup;
        HistorialPage historialPage;

        public HistorialStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            historialPage = testContextSetup.pageObjectManager.GetHistorialPage();

        }

        [Then(@"Visualiza Historial de pagos")]
        public void ThenVisualizaHistorialDePagos()
        {
            Assert.IsTrue(historialPage.MuestraTituloHistorial());
        }

        [Then(@"Visualiza pagos rechazado en color rojito")]
        public void ThenVisualizaPagosRechazadoEnColorRojito()
        {
            Assert.IsTrue(historialPage.MuestraPagosRechazados());
        }


    }
}
