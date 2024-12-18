using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonSelenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Brand = new Program();
            Brand.BrandName("Apple");
            Brand.BrandName("POCO");
            Brand.BrandName("OnePlus");

        }
        public void BrandName(string Bname)
        {
            IWebDriver driver = new ChromeDriver();
            // Step 2: Navigate to a URL
            driver.Navigate().GoToUrl("http://www.amazon.in");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.LinkText("Mobiles"));
            element.Click();
            System.Threading.Thread.Sleep(5000);
            IWebElement Element = driver.FindElement(By.XPath($"//span[text()='{Bname}']/preceding::input[@aria-labelledby='{Bname}']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", Element);
            IWebElement Element3 = driver.FindElement(By.XPath("(//span[text()='Samsung']/preceding::input)[last()]"));
            js.ExecuteScript("arguments[0].click();", Element3);
            //IWebElement Element2 = driver.FindElement(By.XPath("//span[text()='Samsung']/preceding::input[@aria-labelledby='Samsung']"));
            //js.ExecuteScript("arguments[0].click();", Element2);}

        }
    }
}
