using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utils;
using SpecFlowProject1.PageObjects;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AppiumTestStepDefinitions
    {
        TestContextSetup testContextSetup;
        StartPage startPage;

        public AppiumTestStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            startPage = testContextSetup.pageObjectManager.GetStartPage();
        }


        [Given(@"Probando app")]
        public void GivenProbandoApp()
        {
            //throw new PendingStepException();
            System.Console.WriteLine("HOLA MUNDO");
        }

        [Given(@"Prueba usuario inicia sesion como invitado")]
        public void GivenPruebaUsuarioIniciaSesionComoInvitado()
        {
            startPage.ClickSeguirComoInvitado();
        }

    }
}
