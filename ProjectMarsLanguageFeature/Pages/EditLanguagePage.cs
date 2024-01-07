﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsLanguageFeature.Pages
{
    public class EditLanguagePage
    {

        public void EditLanguage(IWebDriver driver)
        {

            //Locate Pencil icon button and click
            
            IWebElement pencilButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            pencilButton.Click();
            Thread.Sleep(3000);
        }
        public void InputEditLanguage(IWebDriver driver)

        {

            //Locate existing language, remove it and add new language
            IWebElement updateLanguageTextbox = driver.FindElement(By.Name("name"));
           // IWebElement updateLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            updateLanguageTextbox.Clear();
            updateLanguageTextbox.SendKeys("Gujrati");

            //Locate Update level dropdown, click and choose fluent
            IWebElement updateLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            updateLanguageTextbox.Click();
            IWebElement chooseOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            chooseOption.Click();

            //Locate Update button and click
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();

        }
    }
}

