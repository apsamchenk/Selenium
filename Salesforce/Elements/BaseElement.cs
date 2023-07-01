using OpenQA.Selenium;
using Salesforce.CORE;

namespace Salesforce.Elements
{
    public class BaseElement
    {
        public IWebDriver WebDriver => Browser.Instance.Driver;
        public IWebElement GetElement() => WebDriver.FindElement(locator);
        public By locator;

        public BaseElement(By locator)
        {
            this.locator = locator;
        }

        public BaseElement(string xpath)
        {
            this.locator = By.XPath(xpath);
        }
    }
}
