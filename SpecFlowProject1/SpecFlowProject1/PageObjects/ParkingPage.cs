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

        //MOBILE JHONNY CARPETAS DE SELECCION IMAGENES
        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc=\"Mostrar raíces\"]\r\n")]
        private IWebElement SeleccionDesplegable;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[4]/android.widget.LinearLayout/android.widget.TextView\r\n")]
        private IWebElement SeleccionarCarpetaPadre;
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/androidx.cardview.widget.CardView[9]/androidx.cardview.widget.CardView/android.widget.LinearLayout\r\n")]
        private IWebElement SeleccionarCarpetaImagenes;
        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[@content-desc=\"Prueba.jpg, 9.32 KB, 21 jun\"]\r\n")]
        private IWebElement SeleccionarImagenVoucher;
        


        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;

        public ParkingPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
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
        public void SeleccionarImagen()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionDesplegable));
            SeleccionDesplegable.Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaPadre));
            SeleccionarCarpetaPadre.Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarCarpetaImagenes));
            SeleccionarCarpetaImagenes.Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(SeleccionarImagenVoucher));
            SeleccionarImagenVoucher.Click();
            }
        }

    }

