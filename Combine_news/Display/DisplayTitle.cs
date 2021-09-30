/*Project = Ycombinator project headlines
 * created on 27-09-2021
 * created by SIVA RANJANI B
 */
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
            //object creation
            list1 = new List<int>();
        }
     
        //Display the Headlines separately
        public void Display_Title()
        {
            Console.WriteLine("************DisplayTitle * ***********************");
            //Product items
            IList<IWebElement> news = driver.FindElements(By.CssSelector("a.storylink"));

            foreach (IWebElement topic in news)
            {
                string headLines = topic.Text;
                Console.WriteLine(headLines);
            }
        }
        //Display the score separately
        public void Display_Score()
        {
            //display the score 
            Console.WriteLine("************Score*************************");

            //Product items
            IList<IWebElement> score = driver.FindElements(By.XPath("//span[@class='score']"));

            foreach (IWebElement topic in score)
            {
                string points = topic.Text;
                //   Console.WriteLine(points);
                string input = points;
                //using regex to separate the integer
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
        //Display the score and headlines 
        public void Display_Records()
        {
            Console.WriteLine("************Title and Points***********************");
            //display records both records and points
            //Product items
            IList<IWebElement> records = driver.FindElements(By.XPath("//span[@class='score']|//td[@class='title']"));

            foreach (IWebElement topic in records)
            {
                string headlinescore = topic.Text;
                Console.WriteLine(headlinescore);

            }
        }
        //Display the highest points
        public void Display_Sort()
        {
            Console.WriteLine("************Higest Points***********************");
            foreach (var score in driver.FindElements(By.XPath("//*[@class='score']")))
            {
                string records = score.Text;
                string input = records;
                //Separating the interger using regex
                string[] numbers = Regex.Split(records, @"\D+");
                foreach (string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        int i = int.Parse(value);
                        list1.Add(i);
                        Console.WriteLine("Headline points: {0}", i);
                    }
                }
            }

            HighestData();

        }
        public void HighestData()
        {
            var res = list1.OrderByDescending(g => g).Take(1);
            foreach (var g in res)
            {
                Console.WriteLine("Highest value:{0}", g);
            }
        }
        //Display the  Frequently occured words
        public void frequentword()
        {
            Console.WriteLine("************Frequency***********************");
            IList<IWebElement> news = driver.FindElements(By.CssSelector("a.storylink"));

            foreach (IWebElement topic in news)
            {
               
                string headLines = topic.Text;
               //Split the word using the space 
                var ele = headLines.Split(' ').ToList();
                string[] arr = ele.ToArray();
                int n = arr.Length;
                
                //comparing the words
                for(int i =0;i<n;i++)
                {
                    int count = 0;
                    for(int j= 0; j<n;j++)
                    {
                        if (arr[i] == arr[j])
                            count = count + 1;
                    }
                    if (count > 1)
                    {
                        Console.WriteLine("\t\n" + arr[i] + "  Occurs:" + count);
                    }
                                     
                }
            }
        }
    }
}

    

