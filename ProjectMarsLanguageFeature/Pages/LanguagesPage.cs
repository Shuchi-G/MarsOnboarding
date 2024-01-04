using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMarsLanguageFeature.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsLanguageFeature.Pages
{
    public class LanguagesPage
            {
        LanguageLevelOptions levelOptionObj = new LanguageLevelOptions();
        LocateAndClickAddNew locateCickObj = new LocateAndClickAddNew();
        LocateAndEnterLanguageTextbox locateEnterTextObj = new LocateAndEnterLanguageTextbox();
        LocateClickAddButton clickAddButtonObj = new LocateClickAddButton();

        //Locate Add new button and click
        public void AddLanguage(IWebDriver driver)
        {
            locateCickObj.LocateClickAddNew(driver); 
        }

        //Add 4 languages including speacial character,numbers,long characters at different levels
        public void InputLanguage(IWebDriver driver, string language, string level)
        {
            locateEnterTextObj.LocateEnterLangText(driver, language); //Locate Language textbox and enter language
            levelOptionObj.LevelOptions(driver, level); //Locate and click Choose level dropdown,also locate and click option value
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }

        //Giving space as input to language textbox
        public void SpaceInput(IWebDriver driver, string language,string level)
        {
            locateEnterTextObj.LocateEnterLangText(driver, language);
            levelOptionObj.LevelOptions(driver, level);  //Locate Choose level dropdown and click
            clickAddButtonObj.ClickAddButton(driver);//Locate Add button and click
        }

        //Giving valid input to language textbox but not choosing language level
        public void NotChoosingLevel(IWebDriver driver,string language) 
        {
            locateEnterTextObj.LocateEnterLangText(driver, language); //Locate language textbox and enter data
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }

        //Giving duplicate input to language textbox 
        public void DuplicateInput(IWebDriver driver,string language,string level)
        {
            locateEnterTextObj.LocateEnterLangText(driver, language); //Locate language textbox and enter data
            levelOptionObj.LevelOptions(driver, level); //Locate Choose level dropdown and click
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
        }
    }
}

      