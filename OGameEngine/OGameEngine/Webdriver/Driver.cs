using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace OGameEngine.Webdriver
{
    public class Driver
    {
        public static IWebDriver Current;
        
        public Driver()
        {
            Current = new ChromeDriver(Directory.GetCurrentDirectory());
            Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}
