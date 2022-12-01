/*using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

public void SplitACResultsAndPrice()
{
    LoginPopup();
    Actions action = new Actions(driver);
    IWebElement electronics = driver.FindElement(By.XPath("//div[contains(text(),'Electronics')]"));
    action.MoveToElement(electronics).Build().Perform();



    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Cameras & Accessories")));



    driver.FindElement(By.LinkText("Cameras & Accessories")).Click();



    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]")));
    IWebElement app = driver.FindElement(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]"));
    action.MoveToElement(app).Build().Perform();



    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Split ACs")));
    IWebElement splictAC = driver.FindElement(By.LinkText("Split ACs"));
    action.MoveToElement(splictAC).Click().Build().Perform();



    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[contains(text(),'Showing 1 – 24')]")));
    bool isSplitAcResultCountDisplayed = driver.FindElement(By.XPath("//*[contains(text(),'Showing 1 – 24')]")).Displayed; //PageSource.Contains("Showing 1 – 24");



    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@class='_1fQZEK']")));
    ReadOnlyCollection<IWebElement> splitACResults = driver.FindElements(By.XPath("//*[@class='_1fQZEK']"));
    bool isSplitACResultDisplayed = splitACResults.First().Displayed;
    bool isResultDisplayed = isSplitAcResultCountDisplayed & isSplitACResultDisplayed;



    Assert.IsTrue(isSplitAcResultCountDisplayed, "Split AC result count displayed");



    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@class='_30jeq3 _1_WHN1']")));
    string priceBefore = driver.FindElements(By.XPath("//*[@class='_30jeq3 _1_WHN1']")).First().Text;
    driver.FindElements(By.XPath("//*[@class='_30jeq3 _1_WHN1']")).First().Click();
    string parentWindowHandle = driver.CurrentWindowHandle;
    List<string> windowHandles = driver.WindowHandles.ToList();
    string priceAfter = "";



    foreach (string windowHandle in windowHandles)
    {
        driver.SwitchTo().Window(windowHandle);
        if (!parentWindowHandle.Equals(windowHandle))
        {
            priceAfter = driver.FindElement(By.XPath("//*[@class='_30jeq3 _16Jk6d']")).Text;
            driver.Close();
        }
    }
    driver.SwitchTo().Window(parentWindowHandle);
    Assert.That(priceAfter, Is.EqualTo(priceBefore));
}*/