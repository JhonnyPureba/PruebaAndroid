using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Dynamitey.Internal.Optimization;
using OpenQA.Selenium.Appium.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects
{
    public class ParkingPage
    {
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView")]
        private IWebElement selectSalaverry;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.Button[2]")]
        private IWebElement selectUbicacion;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.TextView")]
        private IWebElement selectclickContinuar;
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_one_time_button")]
        private IWebElement selectpermitirCamara;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[15]/android.view.ViewGroup\r\n")]
        private IWebElement selectGalery;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView\r\n")]
        private IWebElement MontoPagar;    
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView\r\n")]
        private IWebElement selectContentButonDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]\r\n")]
        private IWebElement selectButonDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView\r\n")]
        private IWebElement ModalTextDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup\r\n")]
        private IWebElement selectButonAplicarDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup\r\n")]
        private IWebElement selectBotonPagar;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup\r\n")]
        private IWebElement selectBotonPagarSegundaVista;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.CheckBox\r\n")]
        private IWebElement selectTyCPagar;
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement ModalTextPantallaErrorPagoDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.TextView\r\n")]
        private IWebElement TextFelicidadesDescuentoAplicado;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.TextView[2]\r\n")]
        private IWebElement TextMontoAhorradoDescuento;


        //MOBILE JHONNY CARPETAS DE SELECCION IMAGENES
        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc=\"Mostrar raíces\"]\r\n")]
        private IWebElement SeleccionDesplegable;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[4]/android.widget.LinearLayout/android.widget.TextView\r\n")]
        private IWebElement SeleccionarCarpetaPadre;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/androidx.cardview.widget.CardView[9]/androidx.cardview.widget.CardView/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarCarpetaImagenes;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenVoucher;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenError;


        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;

        public ParkingPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public void ClickSalaverry()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectSalaverry));
            selectSalaverry.Click();
        }

        public void ClickPermitirUbicacion()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectUbicacion));
            selectUbicacion.Click();
        }

        public void ClickContinuarParking()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectclickContinuar));
            selectclickContinuar.Click();
        }

        public void ClicPermitirCamara()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectpermitirCamara));
            selectpermitirCamara.Click();
        }

        public void ClickGaleria()
        {
            selectGalery.Click();
        }
        public void ClickImagenVoucher()
        {
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionDesplegable));
            //SeleccionDesplegable.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaPadre));
            //SeleccionarCarpetaPadre.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaImagenes));
            //SeleccionarCarpetaImagenes.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarImagenVoucher));
            SeleccionarImagenVoucher.Click();
        }
        public void ClickImagenDescuento()
        {
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionDesplegable));
            //SeleccionDesplegable.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaPadre));
            //SeleccionarCarpetaPadre.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaImagenes));
            //SeleccionarCarpetaImagenes.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarImagenVoucher));
            SeleccionarImagenDescuento.Click();
        }
        public void ClickImagenError()
        {
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionDesplegable));
            //SeleccionDesplegable.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaPadre));
            //SeleccionarCarpetaPadre.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaImagenes));
            //SeleccionarCarpetaImagenes.Click();
            //_wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarImagenVoucher));
            SeleccionarImagenError.Click();
        }
        public void VerificarMontoPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(MontoPagar));
            Assert.AreEqual(MontoPagar.Text, "S/0.35");
            
        }

        public void VerificarBotonDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectContentButonDescuento));
            Assert.AreEqual(selectContentButonDescuento.Text, "");
        }
        
        public void ClicBotonDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectButonDescuento));
            selectButonDescuento.Click();
        }

        public void VerificarModalAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextDescuento));
            Assert.AreEqual(ModalTextDescuento.Text, "Obtendrás un descuento especial en tu monto a pagar.");
        }

        public void ClickBotonAplicarDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectButonAplicarDescuento));
            selectButonAplicarDescuento.Click();
        }

        public void VerificarDescuentoAplicado()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TextFelicidadesDescuentoAplicado));
            Assert.AreEqual(TextFelicidadesDescuentoAplicado.Text, "¡Felicitaciones, se aplicó el descuento exitosamente!");   
        }

        public void VerificarMontoAhorrado()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(TextMontoAhorradoDescuento));
            Assert.AreEqual(TextMontoAhorradoDescuento.Text, "Ahorraste S/1.00 en tu pago de estacionamiento");
            
        }

        public void ClicBotonPagar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectBotonPagar));
            selectBotonPagar.Click();
        }

        public void ClicBotonPagarSegundaVista()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectBotonPagarSegundaVista));
            selectBotonPagarSegundaVista.Click();
        }

        public bool CheckTerminosCondiciones()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectBotonPagarSegundaVista));
            return selectBotonPagarSegundaVista.Displayed;
        }

        public void VerificarBotonPagarDeshabilitado()
        {
            if (CheckTerminosCondiciones())
            {
                System.Console.WriteLine("BOTON DESHABILITADO");
            }else
            System.Console.WriteLine("BOTON HABILITADO");
        }

        public void ClicTerminosCondiciones()
        {
            selectTyCPagar.Click();
        }

        public void VerificarBotonPagarHabilitado()
        {
            if (CheckTerminosCondiciones())
            {
                System.Console.WriteLine("BOTON HABILITADO");
                ClicBotonPagarSegundaVista();
            }else
            System.Console.WriteLine("BOTON DESHABILITADO");
        }

        public void VerificarPantallaErrorPagoDescuento()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(ModalTextPantallaErrorPagoDescuento));
            Assert.AreEqual(ModalTextPantallaErrorPagoDescuento.Text, "TEXTO QUE CONTENGA EL ERROR");
        }
        
    }
}
    

