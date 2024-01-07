using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsLanguageFeature.Utilities 
{
    public class LocateAndEnterLanguageTextbox
    {
        //Locating and sending input to Language textbox
        public void LocateEnterLangText(IWebDriver driver, string language)
        {
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys(language);
        }
    }
}
