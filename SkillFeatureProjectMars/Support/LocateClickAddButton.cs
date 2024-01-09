using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFeature_Mars.Support
{
    public class LocateClickAddButton
    {

        //Locating and clicking Add button
        public void ClickAddButton(IWebDriver driver)
        {

            IWebElement addButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();

        }
    }
}
