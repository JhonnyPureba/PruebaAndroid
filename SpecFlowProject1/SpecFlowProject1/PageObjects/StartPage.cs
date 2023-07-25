using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpecFlowMarketplaceMobileProject.PageObjects
{
    public class StartPage
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='REGISTRARME']")]
        private IWebElement botonRegistrarme;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='INICIAR SESIÓN']")]
        private IWebElement botonIniciarSesion;
        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Seguir como invitado']")]
        private IWebElement botonInvitado;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;

        public StartPage(AndroidDriver<AppiumWebElement> driver)
        {
            this.Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(10);
            PageFactory.InitElements(driver, this);
        }

        public void ClickRegistrarme()
        {
            _wait.Until(d => { return botonRegistrarme.Displayed; });
            botonRegistrarme.Click();
        }

        public void ClickIniciarSesion()
        {
            _wait.Until(d => { return botonIniciarSesion.Displayed; });
            botonIniciarSesion.Click();
        }

        public void ClickSeguirComoInvitado()
        {
            _wait.Until(d => { return botonInvitado.Displayed; });
            botonInvitado.Click();
        }
    }
}
