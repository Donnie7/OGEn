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
            driver.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id=\"loginRegisterTabs\"]/ul/li[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div[1]/div/input")).SendKeys("alt.mail.16@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div[2]/div/input")).SendKeys("naosei_534");
            driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/p/button[1]/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id=\"joinGame\"]/button")).Click();
            Console.WriteLine("Hello World!");
        }
    }
}
