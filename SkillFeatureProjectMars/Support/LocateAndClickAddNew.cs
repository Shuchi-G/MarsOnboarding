using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFeature_Mars.Support
{
    public class LocateAndClickAddNew
    {
        //Locating and clicking Add New button
        public void LocateClickAddNew(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
        }
    }
}
