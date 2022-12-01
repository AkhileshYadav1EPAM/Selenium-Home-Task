using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Edge;

namespace _Edge_Task5_Flipkart_NUnit
{
    public class EdgeFlipkartNUnitTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void ValidationForPopUpClose()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");

            IWebElement closeLoginPopUp = driver.FindElement(By.XPath("//button[@class=\"_2KpZ6l _2doB4z\"]"));
            closeLoginPopUp.Click();
            Thread.Sleep(2000);
        }

        [Test]
        public void ValidatinForTabExists()
        {
            ValidationForPopUpClose();

            bool tabForMobilesDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Mobiles\")]")).Displayed;
            Assert.IsTrue(tabForMobilesDisplayed, "Mobiles tab is displayed");

            bool tabForFashionDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Fashion\")]")).Displayed;
            Assert.IsTrue(tabForFashionDisplayed, "Fashion tab is displayed");

            bool tabForElectronicsDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Electronics\")]")).Displayed;
            Assert.IsTrue(tabForElectronicsDisplayed, "Electronics tab is displayed");

            bool tabForHomeDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Home\")]")).Displayed;
            Assert.IsTrue(tabForHomeDisplayed, "Home tab is displayed");

            bool tabForTravelDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Travel\")]")).Displayed;
            Assert.IsTrue(tabForTravelDisplayed, "Travel tab is displayed");


            bool tabForAppliancesDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Appliances\")]")).Displayed;
            Assert.IsTrue(tabForAppliancesDisplayed, "Appliances tab is displayed");

            bool tabForBeautyAndToysDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Beauty, Toys & More\")]")).Displayed;
            Assert.IsTrue(tabForBeautyAndToysDisplayed, "Beauty, Toys & More tab is displayed");

            bool tabForGroceryDisplayed = driver.FindElement(By.XPath("//div[contains(text(), \"Grocery\")]")).Displayed;
            Assert.IsTrue(tabForGroceryDisplayed, "Grocery tab is displayed");
        }

        [Test]
        public void ValidationForSplitAC()
        {
            ValidationForPopUpClose();

            Actions action = new Actions(driver);
            IWebElement tabForElectronics = driver.FindElement(By.XPath("//div[contains(text(), \"Electronics\")]"));
            action.MoveToElement(tabForElectronics).Build().Perform();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Audio")));
            IWebElement buttonForAudio = driver.FindElement(By.LinkText("Audio"));
            buttonForAudio.Click();
            Thread.Sleep(5000);

            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("TVs & Appliances")));



            IWebElement tabForTVsAndAppliances = driver.FindElement(By.XPath("//span[contains(text(), \"TVs & Appliances\")]"));
            action.MoveToElement(tabForTVsAndAppliances).Build().Perform();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Split ACs")));
            IWebElement buttonForSplitACs = driver.FindElement(By.LinkText("Split ACs"));
            buttonForSplitACs.Click();


            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//h1[contains(text(), \"Split Air Conditioners\")]")));
            bool resultDisplayed = driver.FindElement(By.XPath("//h1[contains(text(), \"Split Air Conditioners\")]")).Displayed;
            Assert.IsTrue(resultDisplayed, "Showing the split ACs result is displayed");


            IWebElement firstResult = driver.FindElement(By.XPath("//div[contains(text(), \"Whirlpool 4 in 1 Convertible Cooling 1.5 Ton 5 Star Split Inverter AC  - White\")]"));
            String beforePrice = driver.FindElement(By.XPath("//div[contains(text(), \"₹37,590\")]")).Text;
            firstResult.Click();
            string parentWindowHandle = driver.CurrentWindowHandle;
            List<string> windowHandles = driver.WindowHandles.ToList();
            string afterPrice = "";

            foreach (string windowHandle in windowHandles)
            {
                driver.SwitchTo().Window(windowHandle);
                if (parentWindowHandle != windowHandle)
                {
                    afterPrice = driver.FindElement(By.XPath("//div[contains(text(), \"₹37,590\")]")).Text;
                    driver.Close();
                }
            }

            driver.SwitchTo().Window(parentWindowHandle);
            Assert.That(beforePrice, Is.EqualTo(afterPrice));



            Thread.Sleep(5000);
        }

        [TearDown]
        public void TestTearDown()
        {
            driver.Close();
        }
    }
}