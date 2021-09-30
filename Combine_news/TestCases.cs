/*Project = Ycombinator project headlines
 * created on 27-09-2021
 * created by SIVA RANJANI B
 */
using NUnit.Framework;

namespace Combine_news
{
    public class Tests : Base.BaseClass
    {
        [Test]
       public void NewsHeadLines()
       {
            Display.DisplayTitle display = new Display.DisplayTitle();
            display.Display_Title();
            display.Display_Score();
            display.Display_Records();
            display.Display_Sort();
            display.frequentword();
       }
    }
       
}