using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utils;
using SpecFlowProject1.PageObjects;
using SpecFlowMarketplaceMobileProject.PageObjects;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AppiumTestStepDefinitions
    {
        TestContextSetup testContextSetup;
        StartPage startPage;
        LoginPage loginPage;
        HomePage homePage;
        ParkingPage parkingPage;

        public AppiumTestStepDefinitions(ScenarioContext scenarioContext)
        {
            testContextSetup = new TestContextSetup(scenarioContext);
            startPage = testContextSetup.pageObjectManager.GetStartPage();
            loginPage = testContextSetup.pageObjectManager.GetLoginPage();
            homePage = testContextSetup.pageObjectManager.GetHomePage();
            parkingPage = testContextSetup.pageObjectManager.GetParkingPage();
        }


        [Given(@"Probando app")]
        public void GivenProbandoApp()
        {
            //throw new PendingStepException();
            System.Console.WriteLine("HOLA MUNDO");
        }

        [Given(@"usuario inicia sesion")]
        public void GivenPruebaUsuarioIniciaSesionComoInvitado()
        {
            startPage.ClickIniciarSesion();
            loginPage.ClickIngresarConTuCorreo();
            loginPage.IngresarEmail("pradoccorajhonnyangelo@gmail.com");
            loginPage.IngresarContrasena("Manzanita17");
            loginPage.ClickCheckBoxTyC();
            loginPage.ClickIngresar();
            
        }

        [When(@"el usuario selecciona parking")]
        public void elusuarioseleccionaparking()
        {
            homePage.ClickParking();
            parkingPage.ClickPermitirUbicacion();
            parkingPage.ClickSalaverry();
            parkingPage.ClickContinuarParking();
        }

        [When(@"el usuario selecciona imagen")]
        public void WhenElUsuarioSeleccionaImagen()
        {
            parkingPage.ClicPermitirCamara();
            parkingPage.ClickGaleria();
            parkingPage.SeleccionarImagen();
        }

    }
}
