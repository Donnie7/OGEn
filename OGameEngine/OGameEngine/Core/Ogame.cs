using OGameEngine.Webdriver;
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

        private readonly IWebDriver webDriver;

        public Ogame()
        {
            Resources = new Resources();
            Facilities = new Facilities();
            Research = new Research();
            Shipyard = new Shipyard();
            Defense = new Defense();
            Fleet = new Fleet();
            Galaxy = new Galaxy();
            webDriver = new Driver().Current;
        }

        public void Login()
        {
            webDriver.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
            webDriver.FindElement(By.XPath(Path.Login.SessionTab)).Click();
            webDriver.FindElement(By.XPath(Path.Login.UsernameForm)).SendKeys("alt.mail.16@gmail.com");
            webDriver.FindElement(By.XPath(Path.Login.PasswordForm)).SendKeys("naosei_534");
            webDriver.FindElement(By.XPath(Path.Login.LoginButton)).Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.FindElement(By.XPath(Path.Login.LastPlayedButton)).Click();
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
        }
    }
}
