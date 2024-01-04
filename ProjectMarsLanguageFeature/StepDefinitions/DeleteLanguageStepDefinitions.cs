using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        DeletePage deletePageObj = new DeletePage();

        [Given(@"Language Tab is selected in Profile Page/")]
        public void GivenLanguageTabIsSelectedInProfilePage()
        {
            Console.WriteLine("Mars portal is Starting");
        }

        [When(@"I click on Cross icon buttons")]
        public void WhenIClickOnCrossIconButtons()
        {
            deletePageObj.DeleteLanguage(driver);
        }

        [Then(@"Existing languages deleted with delete message")]
        public void ThenExistingLanguagesDeletedWithDeleteMessage()
        {
            Console.WriteLine("Delete is successful");
        }

    }
}