using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Chrome
{
    public class ChromeTests
    {
        IWebDriver driver;

        public object ExpectedConditions { get; private set; }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            IWebElement signin = driver.FindElement(By.XPath("//a[@class='gb_2 gb_3 gb_9d gb_9c']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

           /* WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            object value = wait.Until(drv => drv.FindElement(By.XPath("//a[@class='gb_2 gb_3 gb_9d gb_9c']")) );*/

            //IWebElement signin = driver.FindElement(By.XPath("//a[@class='gb_2 gb_3 gb_9d gb_9c']"));
            signin.Click();


            String Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page " + Title);
            Console.WriteLine("Length of the Title " + TitleLength);
            String PageURL = driver.Url;
            int URLLength = PageURL.Length;
            Console.WriteLine("URL of the page is " + PageURL);
            Console.WriteLine("Length of the URL is " + URLLength);
            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            //Console.WriteLine("Page Source of the page is " + PageSource);
            Console.WriteLine("Length of the Page Source is " + PageSourceLength);
            //Assert.Pass();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}