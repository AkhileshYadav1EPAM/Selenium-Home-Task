namespace Task_1___Using_console_app_and_class_library
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            
            Firefox firefox= new Firefox();
            firefox.FirefoxCreate();
            firefox.FirefoxNavigate();
            firefox.FirefoxClose();
            Edge edge= new Edge();
            edge.EdgeCreate();
            edge.EdgeNavigate();
            edge.EdgeClose();
            Chrome chrome = new Chrome();
            chrome.ChromeCreate();
            chrome.ChromeNavigate();
            chrome.ChromeClose();
            
        }
        
    }
}