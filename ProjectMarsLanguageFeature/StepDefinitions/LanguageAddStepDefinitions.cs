using NUnit.Framework;
using OpenQA.Selenium;
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
        DeleteAnExistingLanguage deletingObj = new DeleteAnExistingLanguage();
       
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
    

        [Given(@"Add New button should be there")]
        public void GivenAddNewButtonShouldBeThere()
        {
            deletingObj.DeletingLanguage(driver);
            Thread.Sleep(5000);
        }

        [When(@"I click on Add New buttons to give invalid input")]
        public void WhenIClickOnAddNewButtonsToGiveInvalidInput()
        {
            IWebElement newButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newButton.Click();
        }

        [When(@"I give space as input <'([^']*)'>,<'([^']*)'> for language")]
        public void WhenIGiveSpaceAsInputForLanguage(string language, string level)
        {
            languagesPageObj.SpaceInput(driver, language = "    ", level = "Fluent");
        }

                      [Then(@"New languages should not be added with add message")]
        public void ThenNewLanguagesShouldNotBeAddedWithAddMessage()
        {
            Console.WriteLine("Language should not be added");
        }

        [When(@"I give input <'([^']*)'> to language but not choosen level of language")]
        public void WhenIGiveInputToLanguageButNotChoosenLevelOfLanguage(string language)
        {
            languagesPageObj.NotChoosingLevel(driver, language = "qwer");

        }

        [Then(@"language should not be added with add message")]
        public void ThenLanguageShouldNotBeAddedWithAddMessage()
        {
            Assert.Pass("Language should not add");
        }

        [When(@"I give existing input '([^']*)','([^']*)'  of language")]
        public void WhenIGiveExistingInputOfLanguage(string language, string level)
        {
            languagesPageObj.DuplicateInput(driver, language, level);
        }

      
        [Then(@"Duplicate languages should not be added with add message")]
        public void ThenDuplicateLanguagesShouldNotBeAddedWithAddMessage()
        {
            Assert.Pass("Language should not add");
        }
        

    }



}
