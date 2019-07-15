using OGameEngine.Webdriver.Resources;
using OpenQA.Selenium;

namespace OGameEngine.Webdriver.OgameEntities
{
    public class Resources
    {
        public MetalMine MetalMine;
        public string Path = "//*[@id=\"menuTable\"]/li[2]/a/span";

        public Resources()
        {
            MetalMine = new MetalMine();
        }

        public void Navigate()
        {
            var element = Driver.Current.FindElement(By.XPath(Path));
            element.Click();
        }
    }
}
