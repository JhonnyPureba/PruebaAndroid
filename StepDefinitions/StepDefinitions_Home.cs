using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;

namespace WorkFlowMarketplaceMobile.StepDefinitions
{
    [Binding]
    public sealed class StepDefinitions_Home
    {

        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions_Home(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"El usuario selecciona opcion registrarme")]
        public void GivenSelectRegistration()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().
                FindElementByAndroidUIAutomator("new UiSelector().text(\"REGISTRARME\")").Click();
        }

        [Given(@"El usuario selecciona opcion iniciar sesion")]
        public void GivenSelectStartSession()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().
                FindElementByAndroidUIAutomator("new UiSelector().text(\"INICIAR SESIÓN\")").Click();
        }

        [Given(@"El usuario selecciona opcion seguir como invitado")]
        public void GivenSelectFollowAsGuest()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().
                FindElementByAndroidUIAutomator("new UiSelector().text(\"Seguir como invitado\")").Click();
        }

    }
}