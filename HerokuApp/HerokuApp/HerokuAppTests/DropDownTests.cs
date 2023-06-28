using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class DropDownTests : BaseTest
    {
        [Test, Category("DropdownTest"), Description("Check all options")]
        public void CheckAllOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();

            List<IWebElement> options = driver.FindElements(By.TagName("option")).ToList();

            Assert.That(options.Count, Is.EqualTo(3));
        }

        [Test, Category("DropdownTest"), Description("Check first option is selected")]
        public void SelectFirstOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(1);

            Assert.IsTrue((driver.FindElement(By.CssSelector("option[value='1']")).Selected));
        }

        [Test, Category("DropdownTest"), Description("Check second option is selected")]
        public void SelectSecondOptions()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(2);

            Assert.IsTrue((driver.FindElement(By.CssSelector("option[value='2']")).Selected));
        }
    }
}
