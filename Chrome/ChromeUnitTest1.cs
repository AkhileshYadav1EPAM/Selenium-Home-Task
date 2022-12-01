using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Chrome
{
    public class ChromeTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");

            Thread.Sleep(3000);

            IWebElement ElementsBox = driver.FindElement(By.XPath("//div[@id='fixedban']"));
            ElementsBox.Click();
            IWebElement TextBox = driver.FindElement(By.XPath("//div[@class='element-list collapse show']//li[@id='item-0']"));
            ElementsBox.Click();
            IWebElement FullName = driver.FindElement(By.XPath("//input[@id='userName']"));
            FullName.SendKeys("Akhilesh Kumar Yadav");
            Assert.Pass();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}