using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OGameEngine.Webdriver
{
    public class Driver : IDriver
    {
        public  IWebDriver Current { get; }
        public IResearches Researches { get; }
        
        public Driver()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            options.DebuggerAddress = "127.0.0.1:9222";
            Current = new ChromeDriver("c:\\", options);
            Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Researches = new Researches(this);
        }

        public bool ConnectToOgame()
        {
            foreach (var tab in Current.WindowHandles)
            {
                Current.SwitchTo().Window(tab);
                if (Current.Title.Contains("Hyperion"))
                {
                    return true;
                }
            }

            return false;
            // Current.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
            // Current.FindElement(By.XPath(Path.Login.SessionTab)).Click();
            // Current.FindElement(By.XPath(Path.Login.UsernameForm)).SendKeys("alt.mail.16@gmail.com");
            // Current.FindElement(By.XPath(Path.Login.PasswordForm)).SendKeys("naosei_534");
            // Current.FindElement(By.XPath(Path.Login.LoginButton)).Click();
            // Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Current.FindElement(By.XPath(Path.Login.LastPlayedButton)).Click();
            // Current.SwitchTo().Window(Current.WindowHandles[1]);
        }

        public void GoTo(string url)
        {
            Current.Url = url;
        }

        public string GetValue(string xpath) => Current.FindElement(By.XPath(xpath)).Text;

        public IWebDriver CurrentDriver() => Current;
    }
    
    public interface IDriver
    {
        bool ConnectToOgame();
        void GoTo(string url);

        string GetValue(string xpath);

        IResearches Researches { get; }
    }
}
