using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_1___Using_console_app_and_class_library 
{
    internal class Chrome : driverNavigation
    {
        IWebDriver driver;
        public void ChromeCreate()
        {
            driver = new ChromeDriver();
        }

        public void ChromeNavigate()
        {
            Navigate(driver);
            /*driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@title='Search']"));
            SearchTextBox.SendKeys("EPAM Systems");
            IWebElement SearchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));
            SearchButton.Click();*/
    }

        public void ChromeClose()
        {
            driver.Close();
        }
    }
}
