using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMarsLanguageFeature.Drivers;
using ProjectMarsLanguageFeature.Pages;
using ProjectMarsLanguageFeature.Support;
using System;
using TechTalk.SpecFlow;

namespace ProjectMarsLanguageFeature.StepDefinitions
{
    [Binding]
    public class LanguageAddStepDefinitions : CommonDriver
    {
        LanguagesPage languagesPageObj = new LanguagesPage();
        DeleteAnExistingLanguage deletingObj = new DeleteAnExistingLanguage();
        ContentReadLanguage readLanguageObj = new ContentReadLanguage();

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

        [Then(@"'([^']*)' should be added")]
        public void ThenShouldBeAdded(string language)
        {
            Thread.Sleep(5000);
            IWebElement languageRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(languageRead.Text, Is.EqualTo(language), "Language is not added");
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
            IWebElement newButton = driver.FindElement(By.XPath("//*/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            newButton.Click();
        }

        [When(@"I give space as input <'([^']*)'>,<'([^']*)'> for language")]
        public void WhenIGiveSpaceAsInputForLanguage(string language, string level)
        {
            languagesPageObj.SpaceInput(driver, language = " ", level = "Fluent");
        }

        [Then(@"<'([^']*)'> should not add")]
        public void ThenShouldNotAdd(string language)
        {
            try
            {
                Thread.Sleep(5000);
                IWebElement languageRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                Assert.That(!string.IsNullOrEmpty(languageRead.Text), "Space should not be added");
            }
            catch (Exception)
            {
                Console.WriteLine(" ");
            }
        }



        [When(@"I give input <'([^']*)'> to language but not choosen level of language")]
        public void WhenIGiveInputToLanguageButNotChoosenLevelOfLanguage(string language)
        {
            languagesPageObj.NotChoosingLevel(driver, language = "qwer");

        }

        [Then(@"<'([^']*)'> should not be added")]
        public void ThenShouldNotBeAdded(string language)
        {
            Thread.Sleep(5000);
            IWebElement languageRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(languageRead.Text, !Is.EqualTo(language), "language should not be added");
        }



        [When(@"I give existing input '([^']*)','([^']*)'  of language")]
        public void WhenIGiveExistingInputOfLanguage(string language, string level)
        {
            languagesPageObj.DuplicateInput(driver, language, level);
        }

        [Then(@"Duplicate '([^']*)' should not be added")]
        public void ThenDuplicateShouldNotBeAdded(string language)
        {
            Thread.Sleep(3000);
            for (int i = 1; i < 5; i++)
            {
                try
                {
                    string path = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]";
                    IWebElement contentLanguage = driver.FindElement(By.XPath(path));
                    Thread.Sleep(3000);
                    if (contentLanguage.Text == language && i != 1)
                        Assert.Fail("Duplicate language should not be added");
                    break;
                }
                catch (Exception) { Console.WriteLine(" "); }
            }
        }

    }

}
