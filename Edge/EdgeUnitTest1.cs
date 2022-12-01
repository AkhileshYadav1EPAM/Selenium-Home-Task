using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace Edge
{
        public class EdgeTests
        {
            IWebDriver driver;
            [SetUp]
            public void Setup()
            {
                driver = new EdgeDriver();
            }

            [Test]
            public void Test1()
            {
                driver.Navigate().GoToUrl("https://demoqa.com/");
                driver.Manage().Window.Maximize();

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,350)", "");

                IWebElement ElementsBox = driver.FindElement(By.XPath("//*[@id=\"app\"]//h5[contains(text(),'Elements')]"));
                ElementsBox.Click();

                js.ExecuteScript("window.scrollBy(0,550)", "");

                IWebElement Form = driver.FindElement(By.XPath("(//*[@id=\"app\"]//div[@class='header-text'])[2]"));
                Form.Click();

                
                IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='firstName']"));
                FirstName.SendKeys("Akhilesh Kumar Yadav");
                Assert.Pass();
            }

            [TearDown]
            public void EndTest()
            {
                driver.Close();
            }
        }
}