using OpenQA.Selenium;
using System;

namespace OGameEngine.Core
{
    public class Ogame
    {
        public Resources Resources;
        public Facilities Facilities;
        public Research Research;
        public Shipyard Shipyard;
        public Defense Defense;
        public Fleet Fleet;
        public Galaxy Galaxy;

        public Ogame()
        {
            Resources = new Resources();
            Facilities = new Facilities();
            Research = new Research();
            Shipyard = new Shipyard();
            Defense = new Defense();
            Fleet = new Fleet();
            Galaxy = new Galaxy();
        }

        public void Login(IWebDriver driver)
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
