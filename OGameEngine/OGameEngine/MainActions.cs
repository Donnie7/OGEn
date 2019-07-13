using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OGameEngine
{
    public class MainActions
    {
        public static void Login(IWebDriver driver)
        {
            driver.FindElement(By.XPath(Path.Login.SessionTab)).Click();
            driver.FindElement(By.XPath(Path.Login.UsernameForm)).SendKeys("alt.mail.16@gmail.com");
            driver.FindElement(By.XPath(Path.Login.PasswordForm)).SendKeys("naosei_534");
            driver.FindElement(By.XPath(Path.Login.LoginButton)).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath(Path.Login.LastPlayedButton)).Click();
        }
    }
}
