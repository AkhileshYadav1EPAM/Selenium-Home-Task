using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Edge
{
    public class EdgeUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void ValidationForCheckout()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            Thread.Sleep(1000);

            IWebElement username = driver.FindElement(By.XPath("//input[@id=\"user-name\"]"));
            username.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.XPath("//input[@id=\"password\"]"));
            password.SendKeys("secret_sauce");
            IWebElement loginButton = driver.FindElement(By.XPath("//input[@id=\"login-button\"]"));
            Thread.Sleep(1000);
            loginButton.Click();
            Thread.Sleep(1000);
            String priceBefore = driver.FindElements(By.XPath("//div[@class=\"inventory_item_price\"]")).First().Text;
            String itemNameBefore = driver.FindElement(By.XPath("//div[contains(text(), \"Sauce Labs Backpack\")]")).Text;

            IWebElement butronForAddToCart = driver.FindElement(By.XPath("//button[@id=\"add-to-cart-sauce-labs-backpack\"]"));
            Thread.Sleep(1000);
            butronForAddToCart.Click();

            IWebElement buttonForCart = driver.FindElement(By.XPath("//a[@class=\"shopping_cart_link\"]"));
            Thread.Sleep(1000);
            buttonForCart.Click();

            String priceAfter = driver.FindElement(By.XPath("//div[@class=\"inventory_item_price\"]")).Text;

            Assert.That(priceBefore, Is.EqualTo(priceAfter));

            IWebElement checkoutButton = driver.FindElement(By.XPath("//button[@id=\"checkout\"]"));
            Thread.Sleep(1000);
            checkoutButton.Click();

            IWebElement firstName = driver.FindElement(By.XPath("//input[@id=\"first-name\"]"));
            firstName.SendKeys("Akhilesh");
            IWebElement lastName = driver.FindElement(By.XPath("//input[@id=\"last-name\"]"));
            lastName.SendKeys("Kumar");
            IWebElement postelCode = driver.FindElement(By.XPath("//input[@id=\"postal-code\"]"));
            postelCode.SendKeys("208007");
            IWebElement continueButton = driver.FindElement(By.XPath("//input[@id=\"continue\"]"));
            Thread.Sleep(1000);
            continueButton.Click();

            String itemNameAfterCheckout = driver.FindElement(By.XPath("//div[contains(text(), \"Sauce Labs Backpack\")]")).Text;
            String priceAfterCheckout = driver.FindElement(By.XPath("//div[@class=\"inventory_item_price\"]")).Text;

            Assert.That(itemNameBefore, Is.EqualTo(itemNameAfterCheckout));
            Assert.That(priceBefore, Is.EqualTo(priceAfterCheckout));

            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }
    }
}