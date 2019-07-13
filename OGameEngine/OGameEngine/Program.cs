using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace OGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
            MainActions.Login(driver);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//*[@id=\"menuTable\"]/li[2]/a/span")).Click();
            var message = driver.FindElement(By.XPath("//*[@id=\"message-wrapper\"]/a[1]/span")).Text;
            //if ().Any())
            //{
            //    Console.WriteLine("You have messages");

            //}
            //else
            //{
            //    Console.WriteLine("You dont have messages");
            //}
            Console.WriteLine("You dont have messages");
        }


    }
}
