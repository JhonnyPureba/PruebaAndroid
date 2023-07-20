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
    public class StartPageStepDefinitions
    {
        TestContextSetup testContextSetup;
        StartPage startPage;

        public StartPageStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            startPage = testContextSetup.pageObjectManager.GetStartPage();            
        }

        [Given(@"El usuario ingresa como invitado")]
        public void GivenElUsuarioIngresaComoInvitado()
        {
            startPage.ClickSeguirComoInvitado();
        }

    }
}