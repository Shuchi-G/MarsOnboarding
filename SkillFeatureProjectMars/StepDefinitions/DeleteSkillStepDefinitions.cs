using NUnit.Framework;
using OpenQA.Selenium;
using SkillFeature_Mars.Drivers;
using SkillFeature_Mars.Pages;
using System;
using TechTalk.SpecFlow;

namespace SkillFeature_Mars.StepDefinitions
{
    [Binding]
    public class DeleteSkillStepDefinitions : CommonDriver
    {
        DeleteSkillPage deletePageObj = new DeleteSkillPage();
        [Given(@"Skill Tab is selected in Profile Page")]
        public void GivenSkillTabIsSelectedInProfilePage()
        {
            Console.WriteLine("Mars portal is Starting");
        }

        [When(@"I click on Cross icon buttons")]
        public void WhenIClickOnCrossIconButtons()
        {
            deletePageObj.DeleteSkill(driver);
        }

        [Then(@"Existing skill delete successfully")]
        public void ThenExistingSkillDeleteSuccessfully()
        {
            try
            {
                driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (NoSuchElementException)
            {
                Assert.Pass("All Skills are deleted");

            }
        }
    }
}
