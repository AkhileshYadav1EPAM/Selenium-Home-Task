using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Firefox
{
    public class FirefoxTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            IWebElement FormBox = driver.FindElement(By.XPath("//*[name()='path' and contains(@d,'M17 21h-10')]"));
            FormBox.Click();
            IWebElement PracticeForm = driver.FindElement(By.XPath("//span[normalize-space()='Practice Form']"));
            PracticeForm.Click();
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