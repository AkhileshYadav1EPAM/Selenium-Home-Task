using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Edge;

namespace Task_1___Using_console_app_and_class_library
{
    internal class Edge : driverNavigation
    {
        IWebDriver driver;
        public void EdgeCreate()
        {
            driver = new EdgeDriver();
        }

        public void EdgeNavigate()
        {
            Navigate(driver);
            /*driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@title='Search']"));
            SearchTextBox.SendKeys("EPAM Systems");
            IWebElement SearchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));
            SearchButton.Click();*/
        }

        public void EdgeClose()
        {
            driver.Close();
        }
    }
}
