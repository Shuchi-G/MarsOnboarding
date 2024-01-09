using NUnit.Framework;
using OpenQA.Selenium;
using SkillFeature_Mars.Drivers;
using SkillFeature_Mars.Pages;
using SkillFeature_Mars.Support;
using System;
using System.IO;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace SkillFeature_Mars.StepDefinitions
{
    [Binding]
    public class AddSkillStepDefinitions : CommonDriver
    {
        AddSkillPage skillPageObj = new AddSkillPage();
        ContentReadSkill readLanguageObj = new ContentReadSkill();
        LocateAndClickAddNew addButtonObj = new LocateAndClickAddNew();

        [When(@"I click on Add New buttons")]
        public void WhenIClickOnAddNewButtons()
        {
            skillPageObj.AddSkill(driver);
        }

        [When(@"I give input '([^']*)','([^']*)' of skill")]
        public void WhenIGiveInputOfSkill(string skill, string level)
        {
            skillPageObj.InputSkill(driver, skill, level);
        }

        [Then(@"'([^']*)' should be added")]
        public void ThenShouldBeAdded(string skill)
        {
            Thread.Sleep(5000);
            IWebElement skillRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(skillRead.Text, Is.EqualTo(skill), "Skill is not added");
        }



        [When(@"I click on Add New buttons to give invalid input")]
        public void WhenIClickOnAddNewButtonsToGiveInvalidInput()
        {
            addButtonObj.LocateClickAddNew(driver);

        }

        [When(@"I give space as input <'([^']*)'>,<'([^']*)'> for skill")]
        public void WhenIGiveSpaceAsInputForSkill(string skill, string level)
        {
            skillPageObj.SpaceInput(driver, skill = " ", level = "Expert");
        }

        [Then(@"<'([^']*)'> should not add")]
        public void ThenShouldNotAdd(string skill)
        {

            try
            {
                Thread.Sleep(5000);
                IWebElement skillRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                Assert.That(!string.IsNullOrEmpty(skillRead.Text), "Space should not be added");
            }
            catch (Exception)
            {
                Console.WriteLine(" ");
            }
        }

        [When(@"I give input <'([^']*)'> to skill but not choosen level of skill")]
        public void WhenIGiveInputToSkillButNotChoosenLevelOfSkill(string skill)
        {
            skillPageObj.NotChoosingLevel(driver, skill = "qwer");
        }

        [Then(@"<'([^']*)'> should not be added")]
        public void ThenShouldNotBeAdded(string skill)
        {
            Thread.Sleep(5000);
            IWebElement skillRead = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(skillRead.Text, !Is.EqualTo(skill), "skill should not be added");
        }

        [When(@"I give existing input '([^']*)','([^']*)'  of skill")]
        public void WhenIGiveExistingInputOfSkill(string skill, string level)
        {
            skillPageObj.DuplicateInput(driver, skill, level);
        }

        [Then(@"Duplicate '([^']*)' should not be added")]
        public void ThenDuplicateShouldNotBeAdded(string skill)
        {
            Thread.Sleep(3000);

            int i = 1;
            while (true)
            {

                try
                {
                    string path = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]";
                    IWebElement contentLanguage = driver.FindElement(By.XPath(path));
                    Thread.Sleep(3000);
                    if (string.IsNullOrEmpty(contentLanguage.Text))
                        break;
                    if (contentLanguage.Text == skill && i != 1)
                        Assert.Fail("Duplicate language should not be added");
                    break;

                    i = i + 1;
                }
                catch (Exception) { Console.WriteLine(" "); }
            }
        }
    }
}
