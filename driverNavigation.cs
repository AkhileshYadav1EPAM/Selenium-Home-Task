using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Using_console_app_and_class_library
{
    internal class driverNavigation
    {
        public void Navigate(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement SearchTextBox = driver.FindElement(By.XPath("//input[@title='Search']"));
            SearchTextBox.SendKeys("EPAM Systems");
            IWebElement SearchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));
            SearchButton.Click();
        }
    }
}
