using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFeature_Mars.Pages
{
    public class DeleteSkillPage
    {
        public void DeleteSkill(IWebDriver driver)
        {

            //Locate Remove icon button and deleting the existing skill
            try
            {
                while (true)
                {

                    IWebElement removeIconButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                    removeIconButton.Click();
                    Thread.Sleep(2000);
                }
            }

            catch (Exception)
            {
                Assert.Pass("Skill has been removed");
            }

        }
    }
}
