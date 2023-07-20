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
    public class RegisterPageStepDefinitions
    {
        TestContextSetup testContextSetup;
        RegisterPage registerPage;

        public RegisterPageStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            registerPage = testContextSetup.pageObjectManager.GetRegisterPage();
        }



        [Then(@"Visualiza pantalla Registro")]
        public void ThenVisualizaPantallaRegistro()
        {
            Assert.IsTrue(registerPage.MuestraPantallaDeRegistro());
        }


    }
}