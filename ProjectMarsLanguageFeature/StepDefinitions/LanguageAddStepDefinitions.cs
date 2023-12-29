using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.StepDefinitions
{
    [Binding]
    public class LanguageAddStepDefinitions : CommonDriver
    {
        LanguagesPage languagesPageObj = new LanguagesPage();
        [When(@"I click on Add New buttons")]
        public void WhenIClickOnAddNewButtons()
        {
            languagesPageObj.AddLanguage(driver);
        }

        [When(@"I give input '([^']*)','([^']*)' of language")]
        public void WhenIGiveInputOfLanguage(string language, string level)
        {
            languagesPageObj.InputLanguage(driver, language, level);
        }

        [Then(@"New languages should be added with add message")]
        public void ThenNewLanguagesShouldBeAddedWithAddMessage()
        {
            Console.WriteLine("Language is added successfully");
        }
    }
}
