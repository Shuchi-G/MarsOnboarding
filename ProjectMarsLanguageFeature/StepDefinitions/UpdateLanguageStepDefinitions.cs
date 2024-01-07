using NUnit.Framework;
using OpenQA.Selenium;
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
            Thread.Sleep(2000);
            IWebElement languageRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(languageRead.Text, Is.EqualTo("Gujrati"), "language is not Updated");
        }


    }
}
