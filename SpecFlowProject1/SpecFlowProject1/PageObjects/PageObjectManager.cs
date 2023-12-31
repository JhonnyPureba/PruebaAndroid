﻿using MKPMobileProject.PageObjects;
using MKPMobileProject.PageObjects.MiCuenta;
using OpenQA.Selenium.Appium;using OpenQA.Selenium.Appium.Android;
using SpecFlowMarketplaceMobileProject.PageObjects;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;

namespace SpecFlowMarketplaceMobileProject.PageObjects
{
    public class PageObjectManager
    {
        public AndroidDriver<AppiumWebElement> Driver;
        private StartPage _startPage;
        private HomePage _homePage;
        private RegisterPage _registerPage;
        private LoginPage _loginPage;
        private PagoEstacionamientoPage _pagoEstacionamiento;
        private ScannerQRPage _scannerQR;
        private PagoPage _pagoPage;
        private HistorialPage _historialPage;
        private GlobalPage _globalPage;
        private MiCuentaPage _miCuentaPage;

        public PageObjectManager(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
        }

        public StartPage GetStartPage()
        {
            _startPage = new StartPage(Driver);
            return _startPage;
        }

        public HomePage GetHomePage()
        {
            _homePage = new HomePage(Driver);
            return _homePage;
        }
        public LoginPage GetLoginPage()
        {
            _loginPage = new LoginPage(Driver);
            return _loginPage;
        }

        public RegisterPage GetRegisterPage()
        {
            _registerPage = new RegisterPage(Driver);
            return _registerPage;
        }

        public PagoEstacionamientoPage GetPagoEstacionamiento()
        {
            _pagoEstacionamiento = new PagoEstacionamientoPage(Driver);
            return _pagoEstacionamiento;
        }

        public ScannerQRPage GetScannerQRPage()
        {
            _scannerQR = new ScannerQRPage(Driver);
            return _scannerQR;
        }

        public PagoPage GetPagoPage()
        {
            _pagoPage = new PagoPage(Driver);
            return _pagoPage;
        }

        public HistorialPage GetHistorialPage()
        {
            _historialPage= new HistorialPage(Driver);
            return _historialPage;
        }

        internal GlobalPage GetGlobalPage()
        {
            _globalPage = new GlobalPage(Driver);
            return _globalPage;
        }

        internal MiCuentaPage GetMiCuentaPage()
        {
            _miCuentaPage = new MiCuentaPage(Driver);
            return _miCuentaPage;
        }
    }
}