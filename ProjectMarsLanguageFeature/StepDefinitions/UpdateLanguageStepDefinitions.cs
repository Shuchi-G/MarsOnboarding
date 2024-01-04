using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.StepDefinitions
{
    [Binding]
    public class UpdateLanguageStepDefinitions : CommonDriver
    {
        EditLanguagePage editLanguagePageObj = new EditLanguagePage();
        [When(@"I click on Pencil icon buttons")]
        public void WhenIClickOnPencilIconButtons()
        {
            editLanguagePageObj.EditLanguage(driver);
        }

        [When(@"I update language and level of language")]
        public void WhenIUpdateLanguageAndLevelOfLanguage()
        {
            editLanguagePageObj.InputEditLanguage(driver);
        }

        [Then(@"Language and level should be updated")]
        public void ThenLanguageAndLevelShouldBeUpdated()
        {
            Console.WriteLine("Language is updated");
        }


    }
}
