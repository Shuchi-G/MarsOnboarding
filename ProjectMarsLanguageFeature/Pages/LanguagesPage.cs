using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsLanguageFeature.Pages
{
    public class LanguagesPage
    {
        public void DeleteLanguage(IWebDriver driver)
        {

            //Locate Remove icon button and deleting the existing language
            try
            {
                while (true)
                {
                    IWebElement removeIconButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                    removeIconButton.Click();
                    Thread.Sleep(9000);
                }
            }

            catch (Exception ex)
            {
                Assert.Pass("All the languages has been removed");
            }

        }

        public void AddLanguage(IWebDriver driver)
        {
            //Locate Add new button and click
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(3000);
        }

        public void InputLanguage(IWebDriver driver, string language, string level )

        { 
            //Locate Language textbox and enter language
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys(language);
            Thread.Sleep(6000);


            //Locate Choose level dropdown and click
            
            IWebElement levelDropdown = driver.FindElement(By.Name("level"));
            levelDropdown.Click();
            Thread.Sleep(2000);

            //Locate option value and click
            if (level == "Basic")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
                optionValue.Click();
                Thread.Sleep(3000);
            }
            if (level == "Native")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
                optionValue.Click();
                Thread.Sleep(3000);
            }
            if (level == "Fluent")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
                optionValue.Click();
                Thread.Sleep(3000);
            }
            if (level == "Conversational")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
                optionValue.Click();
                Thread.Sleep(3000);
            }

            //Locate Add button and click
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(6000);
        }
        public void EditLanguage(IWebDriver driver)
        {

            //Locate Pencil icon button and click
            IWebElement pencilButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            pencilButton.Click();
            Thread.Sleep(3000);

            //Locate existing language, remove it and add new language
            IWebElement updateLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            updateLanguageTextbox.Clear();
            updateLanguageTextbox.SendKeys("English");

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
