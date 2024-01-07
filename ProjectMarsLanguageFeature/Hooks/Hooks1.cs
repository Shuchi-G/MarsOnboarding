using OpenQA.Selenium.Chrome;
using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Utilities;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.Hooks
{
    [Binding]
    public sealed class Hooks1 : CommonDriver
    {
        
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

            driver = new ChromeDriver();
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.LoginActions(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}