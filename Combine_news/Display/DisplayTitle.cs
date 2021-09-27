using MathNet.Numerics;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Combine_news.Display
{
    public class DisplayTitle : Base.BaseClass
    {
        List<int> list1;
        public DisplayTitle()
        {
            list1 = new List<int>();
        }

        public void Display_Title()
        {

            //Product items
            IList<IWebElement> news = driver.FindElements(By.CssSelector("a.storylink"));

            foreach (IWebElement topic in news)
            {
                string headLines = topic.Text;
                Console.WriteLine(headLines);
            }
        }
        public void Display_Score()
        {

            //Product items
            IList<IWebElement> score = driver.FindElements(By.XPath("//span[@class='score']"));

            foreach (IWebElement topic in score)
            {
                string points = topic.Text;
             //   Console.WriteLine(points);
                string input = points;
                string[] numbers = Regex.Split(input, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        List<int> list1 = new List<int>();
                        list1.Add(i);
                        list1.Reverse();
                        foreach (int b in list1)
                        {
                            Console.WriteLine(b);
                        }
                    }
                }
            }

        }
        public  void Display_Records()
        {

            //Product items
            IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));

            foreach (IWebElement topic in records)
            {
                string headlinescore = topic.Text;
                // Console.WriteLine(headlinescore);
             
            }
        }
    
        public  void Display_Sort()
        {
          
           foreach(var score in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string records = score.Text;
                string input = records;
                string[] numbers = Regex.Split(records, @"\D+");
                foreach(string value in numbers)
                {
                    if(!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                      list1.Add(i);
                        Console.WriteLine("Headline points: {0}" , i);
                    }
                }
            }

            HighestData();

        }
        public  void HighestData()
        {
            var res = list1.OrderByDescending(g => g).Take(1);
            foreach(var g in res)
            {
                Console.WriteLine("Highest value:{0}", g);
            }
        }
    }
}
