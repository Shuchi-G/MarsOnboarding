using NUnit.Framework;
using OpenQA.Selenium;
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

        [Then(@"Existing languages deleted successfully")]
        public void ThenExistingLanguagesDeletedSuccessfully()
        {
            try
            {
                driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (NoSuchElementException)
            {
                Assert.Pass("All languages are deleted");

            }
        }

    }
}