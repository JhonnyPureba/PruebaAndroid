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

        [Given(@"El usuario ingresa al app")]
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
            //parkingPage.ClickPermitirUbicacion();
            //parkingPage.ClickSalaverry();
            parkingPage.ClickContinuarParking();
        }

        [Given(@"Aplicar Codigo de Error ""([^""]*)""")]
        public void GivenAplicarCodigoDeError(string codigo)
        {
            homePage.ClickContactanos();
            homePage.ClickModoDesarrollador();
            homePage.CerrarVentanaContactanos();
            homePage.EnviarCodigoError(codigo);
        }


        [When(@"el usuario selecciona imagen de voucher")]
        public void WhenElUsuarioSeleccionaImagen()
        {
            parkingPage.ClicPermitirCamara();
            parkingPage.ClickGaleria();
            parkingPage.ClickImagenVoucher();
        }

        [When(@"el usuario selecciona imagen Erronea de voucher")]
        public void WhenElUsuarioSeleccionaImagenErroneaDeVoucher()
        {
            parkingPage.ClicPermitirCamara();
            parkingPage.ClickGaleria();
            parkingPage.ClickImagenError();
        }

        [When(@"seleccionar aplicar descuento")]
        public void WhenSeleccionarAplicarDescuento()
        {
            parkingPage.ClicBotonDescuento();
        }
        

        [Then(@"Verificar el monto y boton de descuento")]
        public void ThenVerificarElMontoYBotonDeDescuento()
        {
            parkingPage.VerificarBotonDescuento();
            parkingPage.VerificarMontoPagar();
        }

        [Then(@"Verificar modal con imagen")]
        public void ThenVerificarModalSinImagen()
        {
            parkingPage.VerificarModalAplicarDescuento();
        }

        [When(@"el usuario selecciona boton pagar")]
        public void WhenElUsuarioSeleccionaBotonPagar()
        {
            parkingPage.ClicBotonPagar();
        }
        
        [Then(@"Verificar que el boton de pagar este deshabilitado")]
        public void ThenVerificarQueElBotonDePagarEsteDeshabilitado()
        {
            parkingPage.VerificarBotonPagarDeshabilitado();
        }

        [When(@"el usuario aceptar terminos y condiciones")]
        public void WhenElUsuarioAceptarTerminosYCondiciones()
        {
            parkingPage.ClicTerminosCondiciones();
        }

        [Then(@"Verificar que el boton de pagar este habilitado")]
        public void ThenVerificarQueElBotonDePagarEsteHabilitado()
        {
            parkingPage.VerificarBotonPagarHabilitado();
        }

        [When(@"el usuario selecciona aplicar un descuento")]
        public void WhenElUsuarioSeleccionaAplicarUnDescuento()
        {
            parkingPage.ClicBotonDescuento();
        }

        [When(@"el usuario selecciona aplicar descuento")]
        public void WhenElUsuarioSeleccionaAplicarDescuento()
        {
            parkingPage.ClickBotonAplicarDescuento();
        }

        [Then(@"Verificar que el descuento se aplique")]
        public void ThenVerificarQueElDescuentoSeAplique()
        {
            parkingPage.VerificarDescuentoAplicado();
            parkingPage.VerificarMontoAhorrado();
        }

        [Then(@"Verificar error de pantalla")]
        public void ThenVerificarErrorDePantalla()
        {
            parkingPage.VerificarPantallaErrorPagoDescuento();
        }


    }
}
