using OGameEngine.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace OGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
            var ogame = new Ogame();
            ogame.Login(driver);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//*[@id=\"menuTable\"]/li[2]/a/span")).Click();
            var message = driver.FindElement(By.XPath("//*[@id=\"message-wrapper\"]/a[1]/span")).Text;
            
            Console.WriteLine("You dont have messages");
        }


    }
}
