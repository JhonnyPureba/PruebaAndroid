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
    public class LoginPageStepDefinitions
    {
        TestContextSetup testContextSetup;
        LoginPage loginPage;

        public LoginPageStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            loginPage = testContextSetup.pageObjectManager.GetLoginPage();
        }

        [Then(@"Visualiza pantalla de Login")]
        public void ThenVisualizaPantallaDeLogin()
        {
            Assert.IsTrue(loginPage.MuestraPantallaLogin(),"No se muestra la pantalla de Login");
        }

        [When(@"Selecciona opcion Registrate")]
        public void WhenSeleccionaOpcionRegistrate()
        {
            loginPage.ClickLinkRegistrate();
        }
    }
}