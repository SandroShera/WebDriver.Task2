using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task2
{
    public class PasteBinMainPageElementMap
    {
        private readonly WebDriverWait wait;

        public PasteBinMainPageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement PasteTextArea
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.Id("postform-text")));
            }
        }

        public IWebElement PasteExpiration
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.Id("select2-postform-expiration-container")));
            }
        }

        public IWebElement PasteExpirationChoice10Minutes
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(@id, \"10M\")]")));
            }
        }

        public IWebElement PasteNameTitleInput
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@id=\"postform-name\"]")));
            }
        }

        public IWebElement CreateNewPasteButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button")));
            }
        }

        public IWebElement SyntaxHighlighting
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"select2-postform-format-container\"]")));
            }
        }

        public IWebElement SyntaxHighLightingBash
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/span[2]/span/span[2]/ul/li[2]/ul/li[1]")));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div/a[1]")));
            }
        }
    }
}

