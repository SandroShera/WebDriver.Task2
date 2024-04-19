using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriver.Task2
{
    public class PasteBinCreatedPastePageElementMap
    {
        private readonly WebDriverWait wait;

        public PasteBinCreatedPastePageElementMap(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement PasteTitle
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/h1")));
            }
        }

        public IWebElement SyntaxHighlightingTag
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/div[1]/a[1]")));
            }
        }

        public IWebElement PasteCode
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/ol/li/div")));
            }
        }
    }
}
