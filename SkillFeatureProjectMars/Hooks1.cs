using OpenQA.Selenium.Chrome;
using SkillFeature_Mars.Drivers;
using SkillFeature_Mars.Pages;
using TechTalk.SpecFlow;

namespace SkillFeature_Mars
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