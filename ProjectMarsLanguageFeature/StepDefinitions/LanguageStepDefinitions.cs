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
        LanguagesPage languagesPageObj = new LanguagesPage();
        [Given(@"Language Tab is selected in Profile Page/")]
        public void GivenLanguageTabIsSelectedInProfilePage()
        {
            Console.WriteLine("Mars portal is Starting");
        }

        [When(@"I click on Cross icon buttons")]
        public void WhenIClickOnCrossIconButtons()
        {
           // LanguagesPage languagesPageObj = new LanguagesPage();
            languagesPageObj.DeleteLanguage(driver);

        }

        [Then(@"Existing languages deleted with delete message")]
        public void ThenExistingLanguagesDeletedWithDeleteMessage()
        {
            Console.WriteLine("Delete is successful");
        }

        /*
                [When(@"I click on Add New buttons")]
                public void WhenIClickOnAddNewButtons()
                {
                   languagesPageObj.AddLanguage(driver);
                }

                [When(@"I give input '([^']*)','([^']*)' of language")]
                public void WhenIGiveInputOfLanguage(string Language, string Level)
                {
                    languagesPageObj.InputLanguage(driver, Language, Level);
                }

                [Then(@"New languages should be added with add message")]
                public void ThenNewLanguagesShouldBeAddedWithAddMessage()
                {
                    Console.WriteLine("Language is added successfully");
                }

        */

       /* [When(@"I click on Add New buttons")]
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
*/

    }
}
