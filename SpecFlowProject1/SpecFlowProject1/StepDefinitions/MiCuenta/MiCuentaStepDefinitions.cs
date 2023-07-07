using NUnit.Framework;
using SpecFlowMarketplaceMobileProject.PageObjects;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;
using SpecFlowProject1.Utils;
using MKPMobileProject.PageObjects.MiCuenta;
using MKPMobileProject.PageObjects;

namespace MKPMobileProject.StepDefinitions.MiCuenta
{
    [Binding]
    public class MiCuentaStepDefinitions
    {
        TestContextSetup testContextSetup;
        HistorialPage historialPage;
        MiCuentaPage miCuentaPage;

        public MiCuentaStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            miCuentaPage = testContextSetup.pageObjectManager.GetMiCuentaPage();
            historialPage = testContextSetup.pageObjectManager.GetHistorialPage();  
        }

        [Then(@"Visualiza modulo MiCuenta")]
        public void ThenVisualizaModuloMiCuenta()
        {
            Assert.IsTrue(miCuentaPage.MuestraTituloMimCuenta());
        }

        [When(@"Selecciona Mis pagos de estacionamiento")]
        public void WhenSeleccionaMisPagosDeEstacionamiento()
        {
            miCuentaPage.ClickMisPagosDeEstacionamiento();
        }

        [Then(@"Visualiza mensaje Ups Sin conexion a internet")]
        public void ThenVisualizaMensajeUpsSinConexionAInternet()
        {
            Assert.IsTrue(historialPage.MuestraMensajeUpsSinConexion());
        }

    }
}