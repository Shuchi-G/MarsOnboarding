using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        [Given(@"Language Tab is selected in Profile Page/")]
        public void GivenLanguageTabIsSelectedInProfilePage()
        {
            Console.WriteLine("Mars portal is Starting");
        }

        [When(@"I click on Cross icon buttons")]
        public void WhenIClickOnCrossIconButtons()
        {
            LanguagesPage languagesPageObj = new LanguagesPage();
            languagesPageObj.DeleteLanguage(driver);

        }

        [Then(@"Existing languages deleted with delete message")]
        public void ThenExistingLanguagesDeletedWithDeleteMessage()
        {
            Console.WriteLine("Delete is successful");
        }
    }
}
