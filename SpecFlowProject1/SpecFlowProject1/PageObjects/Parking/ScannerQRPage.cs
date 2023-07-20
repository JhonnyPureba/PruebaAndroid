using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class ScannerQRPage
    {
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_one_time_button")]
        private IWebElement botonOnlyThisTime;
        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[contains(@content-desc,'QR_UAT_Correcto1')]")]
        private IWebElement qrCorrecto;
        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[contains(@content-desc,'QR_UAT_Correcto2')]")]
        private IWebElement qrCorrecto2;
        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[contains(@content-desc,'QR_UAT_Correcto3')]")]
        private IWebElement qrCorrecto3;
        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[contains(@content-desc,'QR_Incorrecto')]")]
        private IWebElement qrIncorrecto;
        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc='Mostrar raíces']")]
        private IWebElement botonMostrarRaiz;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[2]")]
        private IWebElement botonImagenes;
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.google.android.documentsui:id/dir_list']//android.widget.TextView[@text='ParkingQR']")]
        private IWebElement botonCarpetaParkingQR;


        //MOBILE JHONNY CARPETAS DE SELECCION IMAGENES
        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc='Mostrar raíces']")]
        private IWebElement SeleccionDesplegable;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[4]/android.widget.LinearLayout/android.widget.TextView\r\n")]
        private IWebElement SeleccionarCarpetaPadre;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/androidx.cardview.widget.CardView[9]/androidx.cardview.widget.CardView/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarCarpetaImagenes;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[6]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenVoucher;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenDescuento;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenError;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenErrorTicketCompra;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[8]/android.widget.LinearLayout/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarImagenTicketCompra;


        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;
        private readonly ITouchAction action;

        public ScannerQRPage(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            action = new TouchAction(driver);
            PageFactory.InitElements(driver, this);
        }

        public void ClickImagenVoucher()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarImagenVoucher));
            SeleccionarImagenVoucher.Click();
        }
        public void ClickImagenDescuento()
        {
            SeleccionarImagenDescuento.Click();
        }
        public void ClickImagenError()
        {
            SeleccionarImagenError.Click();
        } 

        public void ClickImagenTicketCompraError()
        {
            SeleccionarImagenErrorTicketCompra.Click();
        }

        public void ClickImagenTicketCompra()
        {
            SeleccionarImagenTicketCompra.Click();
        }
        

        internal void SeleccionarQRIncorrecto()
        {
            _wait.Until(d => { return botonMostrarRaiz.Displayed; });
            botonMostrarRaiz.Click();
            Thread.Sleep(500);
            _wait.Until(d => { return botonImagenes.Displayed; });
            botonImagenes.Click();
            _wait.Until(d => { return botonCarpetaParkingQR.Displayed; });
            botonCarpetaParkingQR.Click();
            _wait.Until(d => { return qrIncorrecto.Displayed; });
            qrIncorrecto.Click();
        }

        internal void SeleccionarQRCorrecto()
        {
            _wait.Until(d => { return botonMostrarRaiz.Displayed; });
            botonMostrarRaiz.Click();
            Thread.Sleep(500);
            _wait.Until(d => { return botonImagenes.Displayed; });
            botonImagenes.Click();
            _wait.Until(d => { return botonCarpetaParkingQR.Displayed; });
            botonCarpetaParkingQR.Click();
            _wait.Until(d => { return qrCorrecto.Displayed; });
            qrCorrecto.Click();
            Thread.Sleep(5000);
        }

        internal void SeleccionarQRCorrecto2()
        {
            _wait.Until(d => { return botonMostrarRaiz.Displayed; });
            botonMostrarRaiz.Click();
            Thread.Sleep(500);
            _wait.Until(d => { return botonImagenes.Displayed; });
            botonImagenes.Click();
            _wait.Until(d => { return botonCarpetaParkingQR.Displayed; });
            botonCarpetaParkingQR.Click();
            _wait.Until(d => { return qrCorrecto2.Displayed; });
            qrCorrecto2.Click();
            Thread.Sleep(5000);
        }
        internal void SeleccionarQRCorrecto3()
        {
            _wait.Until(d => { return botonMostrarRaiz.Displayed; });
            botonMostrarRaiz.Click();
            Thread.Sleep(500);
            _wait.Until(d => { return botonImagenes.Displayed; });
            botonImagenes.Click();
            _wait.Until(d => { return botonCarpetaParkingQR.Displayed; });
            botonCarpetaParkingQR.Click();
            _wait.Until(d => { return qrCorrecto3.Displayed; });
            qrCorrecto3.Click();
            Thread.Sleep(5000);
        }
    }
}
