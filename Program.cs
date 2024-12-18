using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            // Step 2: Navigate to a URL
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(10000);

           



            //// Locate the CAPTCHA image using XPath
            //IWebElement captchaImage = driver.FindElement(By.XPath("//div[@class='a-row a-text-center']//img"));

            //// Capture the source URL of the CAPTCHA image
            //string captchaImageUrl = captchaImage.GetAttribute("src");

            //// Output the CAPTCHA image URL
            //Console.WriteLine("Captcha Image URL: " + captchaImageUrl);
            //System.Threading.Thread.Sleep(5000);
            Console.WriteLine(driver.Title);

            driver.Quit();
        }
    }
}
