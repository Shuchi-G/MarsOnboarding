using NUnit.Framework;
using OpenQA.Selenium;
using SkillFeature_Mars.Drivers;
using SkillFeature_Mars.Pages;
using System;
using TechTalk.SpecFlow;

namespace SkillFeature_Mars.StepDefinitions
{
    [Binding]
    public class EditSkillStepDefinitions : CommonDriver
    {
        EditSkillPage editSkillPageObj = new EditSkillPage();
        [When(@"I click on Pencil icon buttons")]
        public void WhenIClickOnPencilIconButtons()
        {
            editSkillPageObj.EditSkill(driver);
        }

        [When(@"I update skill and level of skill")]
        public void WhenIUpdateSkillAndLevelOfSkill()
        {
            editSkillPageObj.InputEditSkill(driver);
        }

        [Then(@"skill and level should be updated")]
        public void ThenSkillAndLevelShouldBeUpdated()
        {
            Thread.Sleep(3000);
            IWebElement skillRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(skillRead.Text, Is.EqualTo("Selenium"), "Skill is not Updated");
        }
    }
}
