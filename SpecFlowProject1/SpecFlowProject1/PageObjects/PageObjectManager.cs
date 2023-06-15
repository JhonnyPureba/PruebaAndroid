using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace SpecFlowProject1.PageObjects
{
    public class PageObjectManager
    {
        public AndroidDriver<AppiumWebElement> Driver;
        private StartPage _startPage;
        private HomePage _homePage;
        private RegisterPage _registerPage;
        private LoginPage _loginPage;

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
    }
}