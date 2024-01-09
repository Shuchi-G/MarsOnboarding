using OpenQA.Selenium;
using SkillFeature_Mars.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFeature_Mars.Pages
{
    public class AddSkillPage
    {

        SkillLevelOptions levelOptionObj = new SkillLevelOptions();
        LocateAndClickAddNew locateCickObj = new LocateAndClickAddNew();
        LocateAndEnterSkillTextbox locateEnterTextObj = new LocateAndEnterSkillTextbox();
        LocateClickAddButton clickAddButtonObj = new LocateClickAddButton();

        //Locate Add new button and click
        public void AddSkill(IWebDriver driver)
        {
            locateCickObj.LocateClickAddNew(driver);
        }

        //Add Skills including speacial character,numbers,long characters at different levels
        public void InputSkill(IWebDriver driver, string skill, string level)
        {
            locateEnterTextObj.LocateEnterSkillText(driver, skill); //Locate Skill textbox and enter skill
            levelOptionObj.LevelOptions(driver, level); //Locate and click Choose level dropdown,also locate and click option value
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }

        //Giving space as input to Skill textbox
        public void SpaceInput(IWebDriver driver, string skill, string level)
        {
            locateEnterTextObj.LocateEnterSkillText(driver, skill);
            levelOptionObj.LevelOptions(driver, level);  //Locate Choose level dropdown and click
            clickAddButtonObj.ClickAddButton(driver);//Locate Add button and click
        }

        //Giving valid input to Skill textbox but not choosing Skill level
        public void NotChoosingLevel(IWebDriver driver, string skill)
        {
            locateEnterTextObj.LocateEnterSkillText(driver, skill); //Locate Skill textbox and give input
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }

        //Giving duplicate input to Skill textbox 
        public void DuplicateInput(IWebDriver driver, string skill, string level)
        {
            locateEnterTextObj.LocateEnterSkillText(driver, skill); //Locate skill textbox and enter data
            levelOptionObj.LevelOptions(driver, level); //Locate Choose level dropdown and click
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }
    }
}
