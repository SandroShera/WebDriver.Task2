using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebDriver.Task2
{
    public class PasteBinMainPage
    {
        private readonly IWebDriver browser;
        private readonly WebDriverWait wait;
        private readonly Actions actions;
        private readonly string url = @"https://pastebin.com/";

        public PasteBinMainPage(IWebDriver browser, WebDriverWait wait)
        {
            this.browser = browser;
            this.wait = wait;
            actions = new(this.browser);
        }

        protected PasteBinMainPageElementMap Map
        {
            get
            {
                return new(this.wait);
            }
        }

        public void Navigate()
        {
            browser.Navigate().GoToUrl(url);
        }

        public void EnterTextInPaste(string text)
        {
            actions.MoveToElement(this.Map.PasteTextArea);
            actions.Perform();
            this.Map.PasteTextArea.Clear();
            this.Map.PasteTextArea.SendKeys(text);
        }

        public void ExpandPasteExpirationDropDown()
        {
            actions.MoveToElement(this.Map.PasteExpiration);
            actions.Perform();
            this.Map.PasteExpiration.Click();
        }

        public void ChoosePasteExpiration10Minutes()
        {
            this.Map.PasteExpirationChoice10Minutes.Click();
        }

        public void EnterNameTitle(string text)
        {
            actions.MoveToElement(this.Map.PasteNameTitleInput);
            actions.Perform();
            this.Map.PasteNameTitleInput.Clear();
            this.Map.PasteNameTitleInput.SendKeys(text);
        }

        public void CreateNewPaste()
        {
            actions.MoveToElement(this.Map.CreateNewPasteButton);
            actions.Perform();
            this.Map.CreateNewPasteButton.Click();
        }

        public void ChooseSyntaxHighLightingBash()
        {
            actions.MoveToElement(this.Map.SyntaxHighlighting);
            actions.Perform();
            this.Map.SyntaxHighlighting.Click();
            this.Map.SyntaxHighLightingBash.Click();
        }

        public void LoginButtonClick()
        {
            this.Map.LoginButton.Click();
        }
    }
}

