using System;
using System.Collections.Generic;
using System.Linq;
using OGameEngine.Core;
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
        }

        public void GoTo(string url)
        {
            Current.Url = url;
        }

        public string GetValue(string xpath) => Current.FindElement(By.XPath(xpath)).Text;

        public IEnumerable<Planet> GetPlanets()
        {
            var planetList = Current.FindElement(By.XPath("//*[@id=\"planetList\"]"));
            var planets = planetList.FindElements(By.XPath("//*[contains(@id, 'planet-')]"));

            return planets
                .Select(planet => planet.Text.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None))
                .Select(values => new Planet {Name = values[0], Location = values[1]})
                .ToList();
        }
    }
}
