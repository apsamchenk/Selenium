using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class AddRemoveElementTests : BaseTest
    {
        [Test, Category("AddRemoveElementTest"), Description("Open window test")]
        public void OpenWindowTest()
        {
            var expectedUrl = "http://the-internet.herokuapp.com/add_remove_elements/";

            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();

            Assert.That(driver.Url, Is.EqualTo(expectedUrl));
        }

        [Test, Category("AddRemoveElementTest"), Description("Add/Remove element test")]
        public void AddRemoveElementTest()
        {
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();

            var addButton = driver.FindElement(By.XPath("//button[text()='Add Element']"));
            addButton.Click();
            addButton.Click();

            List<IWebElement> deleteButtons = driver.FindElements(By.XPath("//button[text()='Delete']")).ToList();

            Assert.That(deleteButtons.Count(), Is.EqualTo(2));

            driver.FindElement(By.XPath("//button[text()='Delete']")).Click();

            Assert.IsNotEmpty(driver.FindElements(By.XPath("//button[text()='Delete']")));
        }
    }
}
