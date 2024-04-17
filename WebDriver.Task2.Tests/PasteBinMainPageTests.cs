using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task2.Tests
{
    public class PasteBinMainPageTests
    {
        private IWebDriver browser;
        private WebDriverWait driverWait;

        [SetUp]
        public void SetUp()
        {
            browser = new ChromeDriver();
            driverWait = new (browser, TimeSpan.FromSeconds(100));
            browser.Manage().Window.Maximize();
            PasteBinMainPage pasteBinMainPage = new PasteBinMainPage(browser, driverWait);

            pasteBinMainPage.Navigate();
            pasteBinMainPage.LoginButtonClick();
            pasteBinMainPage.EnterTextInPaste("git config --global user.name\"New Sheriff in Town\"\r\ngit reset $(git commit-tree HEAD^{tree} -m\"Legacy code\")\r\ngit push origin master --force\r\n");
            pasteBinMainPage.ChooseSyntaxHighLightingBash();
            pasteBinMainPage.ExpandPasteExpirationDropDown();
            pasteBinMainPage.ChoosePasteExpiration10Minutes();
            pasteBinMainPage.EnterNameTitle("how to gain dominance among developers");
            pasteBinMainPage.CreateNewPaste();
        }

        [Test]
        public void Test()
        {
            Task.Delay(5000).Wait();
            Assert.IsTrue(true);
        }

        [TearDown]
        public void TearDown()
        {
            browser.Close();
            browser.Quit();
        }
    }
}
