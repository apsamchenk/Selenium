using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuApp.HerokuAppTests
{
    public class DynamicControlsTests : BaseTest
    {
        [Test, Category("DynamicControlsTest"), Description("Dynamic controls checkbox test")]
        public void DynamicCheckBox()
        {
            driver.FindElement(By.LinkText("Dynamic Controls")).Click();
            driver.FindElement(By.CssSelector("[type=checkbox]")).Click();
            driver.FindElement(By.XPath("//*[@id='checkbox-example']/button")).Click();

            WaitElement();

            Assert.That(driver.FindElement(By.XPath("//*[@id='message']")).Text, Is.EqualTo("It's gone!"));
            Assert.Throws<NoSuchElementException>(() => driver.FindElement(By.CssSelector("[type=checkbox]")));
        }

        [Test, Category("DynamicControlsTest"), Description("Dynamic controls input test")]
        public void DynamicInput()
        {
            driver.FindElement(By.LinkText("Dynamic Controls")).Click();

            Assert.IsFalse(driver.FindElement(By.XPath("//*[@id='input-example']/input")).Enabled);

            driver.FindElement(By.XPath("//*[@id='input-example']/button")).Click();

            WaitElement();

            Assert.That(driver.FindElement(By.XPath("//*[@id='message']")).Text, Is.EqualTo("It's enabled!"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='input-example']/input")).Enabled);
        }

        public void WaitElement()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dynamicElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.XPath("//*[@id='message']"));
            });
        }
    }
}
