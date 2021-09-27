using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_news.Base
{
   public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            try
            {
                ChromeOptions option = new ChromeOptions();
                option.AddArgument("headless");
                driver = new ChromeDriver(option);
                //To maximize the window
                driver.Manage().Window.Maximize();
                driver.Url = "https://news.ycombinator.com/news";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
