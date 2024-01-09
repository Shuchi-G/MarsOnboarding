using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFeature_Mars.Support;

namespace SkillFeature_Mars.Pages
{
    public class SignInPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //Launch Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(3000);

            //Identify Sign in button and click
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinButton.Click();
            Wait.WaitForClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 3);

            //Identify Email address textbox and enter valid email
            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("mailtoshuchigupta@gmail.com");

            //Identify Password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("w123elcome");

            //Identify Login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(3000);

            //Navigating to Skill Page
            IWebElement skillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();

        }
    }
}
