using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuApp.HerokuAppTests
{
    public class ContextMenuTests : BaseTest
    {
        [Test, Category("ContextMenuTest"), Description("Context menu test")]
        public void ContextMenu()
        {
            driver.FindElement(By.LinkText("Context Menu")).Click();

            new Actions(driver)
                .MoveToElement(driver.FindElement(By.Id("hot-spot")))
                .ContextClick()
                .Build()
                .Perform();

            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("You selected a context menu"));

            driver.SwitchTo().Alert().Accept();
        }
    }
}
