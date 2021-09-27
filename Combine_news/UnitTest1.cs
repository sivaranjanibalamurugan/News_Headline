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
        }
    }
       
}