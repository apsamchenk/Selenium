using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class TyposTests : BaseTest
    {
        [Test, Category("TyposTest"), Description("Check text")]
        [Retry(5)]
        public void CheckText()
        {
            driver.FindElement(By.LinkText("Typos")).Click();

            var expected = "Sometimes you'll see a typo, other times you won't.";
            var atualText = driver.FindElement(By.XPath("(//p)[2]"));

            Assert.That(atualText.Text, Is.EqualTo(expected));
        }
    }
}
