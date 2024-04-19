using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace WebDriver.Task2
{
    public class PasteBinCreatedPastePage
    {
        private readonly WebDriverWait wait;

        public PasteBinCreatedPastePage(WebDriverWait wait)
        {
            this.wait = wait;
        }

        protected PasteBinCreatedPastePageElementMap Map
        {
            get
            {
                return new PasteBinCreatedPastePageElementMap(wait);
            }
        }

        public string GetPasteTitle()
        {
            return this.Map.PasteTitle.Text;
        }

        public string GetSyntaxHighlightingText()
        {
            return this.Map.SyntaxHighlightingTag.Text;
        }

        public string GetPasteCode()
        {
            return this.Map.PasteCode.Text;
        }
    }
}
