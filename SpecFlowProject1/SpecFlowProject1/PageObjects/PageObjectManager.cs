using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecFlowMarketplaceMobileProject.PageObjects.Parking;

namespace SpecFlowProject1.PageObjects
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
    }
}