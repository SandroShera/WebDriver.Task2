using Newtonsoft.Json.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task2.Tests
{
    public class PasteBinMainPageTests
    {
        private IWebDriver browser;
        private WebDriverWait driverWait;
        private PasteBinMainPage pasteBinMainPage;
        private const string pasteText = "git config --global user.name\"New Sheriff in Town\"\r\ngit reset $(git commit-tree HEAD^{tree} -m\"Legacy code\")\r\ngit push origin master --force\r\n";
        private const string nameTitle = "how to gain dominance among developers";

        //Creating new paste is ommited because I exceeded 10 pastes and now I have to log in to create another one
        //but website checks if I am human and it is not possible to log in via webDriver.
        [SetUp]
        public void SetUp()
        {
            browser = new ChromeDriver();
            driverWait = new (browser, TimeSpan.FromSeconds(100));
            browser.Manage().Window.Maximize();
            pasteBinMainPage = new PasteBinMainPage(browser, driverWait);

            pasteBinMainPage.Navigate();

            pasteBinMainPage.EnterTextInPaste(pasteText);
            pasteBinMainPage.ChooseSyntaxHighLightingBash();
            pasteBinMainPage.ExpandPasteExpirationDropDown();
            pasteBinMainPage.ChoosePasteExpiration10Minutes();
            pasteBinMainPage.EnterNameTitle(nameTitle);
            pasteBinMainPage.CreateNewPaste();
        }

        [Test]
        public void NameTitleFieldHasCorrectInput()
        {
            var expected = nameTitle;

            PasteBinCreatedPastePage paste = new(driverWait);

            var actual = paste.GetPasteTitle();
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void SyntaxHighLightingValueIsCorrect()
        {
            var expected = "bash";

            PasteBinCreatedPastePage paste = new(driverWait);

            var actual = paste.GetSyntaxHighlightingText();

            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void PasteCodeValueIsCorrect()
        {
            var expected = pasteText;

            PasteBinCreatedPastePage paste = new(driverWait);

            var actual = paste.GetPasteCode();

            Assert.IsTrue(expected.Equals(actual));
        }

        [TearDown]
        public void TearDown()
        {
            browser.Close();
            browser.Quit();
        }
    }
}
