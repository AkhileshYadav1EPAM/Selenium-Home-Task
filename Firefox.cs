using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_1___Using_console_app_and_class_library
{
    internal class Firefox : driverNavigation
    {
        IWebDriver driver;
        public void FirefoxCreate()
        {
            driver = new FirefoxDriver();
        }

        public void FirefoxNavigate()
        {
            Navigate(driver);
            /*driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@title='Search']"));
            SearchTextBox.SendKeys("EPAM Systems");
            IWebElement SearchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));
            SearchButton.Click();*/
        }

        public void FirefoxClose()
        {
            driver.Close();
        }
    }
}
