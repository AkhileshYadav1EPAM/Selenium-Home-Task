using Chrome;
using Edge;
using Firefox;

namespace Class_library_for_task_2
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            FirefoxTests firefox = new FirefoxTests();
            firefox.Setup();
            firefox.Test1();
            firefox.EndTest();
            /*EdgeTests edge = new EdgeTests();
            edge.Setup();
            edge.Test1();
            edge.EndTest();
            ChromeTests chrome = new ChromeTests();
            chrome.Setup();
            chrome.Test1();
            chrome.EndTest();*/

        }
    }
}