using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class InputsTests : BaseTest
    {
        [TestCase(-100)]
        [TestCase(0)]
        [TestCase(100)]
        [Category("InputTest"), Description("Enter simple numbers test")]

        public void SimpleEnterNumbers(int number)
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("Input"));

            input.SendKeys(number.ToString());

            Assert.That(input.GetAttribute("value"), Is.EqualTo(number.ToString()));
        }

        [TestCase(100), Category("InputTest"), Description("Arrow up and arrow down test")]
        public void ArrowUpArrowDown(int number)
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("Input"));

            input.SendKeys(number.ToString());
            input.SendKeys(Keys.ArrowUp + Keys.ArrowDown);

            Assert.That(input.GetAttribute("value"), Is.EqualTo(number.ToString()));
        }

        [TestCase(100), Category("InputTest"), Description("Arrow up test")]
        public void ArrowUpTest(int number)
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("Input"));

            input.SendKeys(number.ToString());
            input.SendKeys(Keys.ArrowUp);

            Assert.That(input.GetAttribute("value"), Is.EqualTo((number + 1).ToString()));
        }

        [TestCase(100), Category("InputTest"), Description("Arrow down test")]
        public void ArrowDownTest(int number)
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("Input"));

            input.SendKeys(number.ToString());
            input.SendKeys(Keys.ArrowDown);

            Assert.That(input.GetAttribute("value"), Is.EqualTo((number - 1).ToString()));
        }

        [TestCase("A123B"), Category("InputTest"), Description("Input letters and numbers test")]
        public void EnterLetters(string text)
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("Input"));

            input.SendKeys(text.ToString());

            Assert.That(input.GetAttribute("value"), Is.EqualTo("123"));
        }
    }
}
