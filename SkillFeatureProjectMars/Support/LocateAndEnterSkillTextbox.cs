using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFeature_Mars.Support
{
    public class LocateAndEnterSkillTextbox
    {

        //Locating and sending input to Language textbox
        public void LocateEnterSkillText(IWebDriver driver, string language)
        {
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys(language);
        }
    }
}
