using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
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
        AppiumTestStepDefinitions appiumTestStep;


        PagoEstacionamiento pagoEstacionamiento;

        public AppiumTestParkingStepDefinitions(ScenarioContext scenarioContext)
        {
            appiumTestStep = new AppiumTestStepDefinitions(scenarioContext);
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

    }
}
