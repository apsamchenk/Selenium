using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class CheckBoxesTests : BaseTest
    {
        [Test, Category("CheckBoxTest"), Description("Select checkBox")]
        public void SelectCheckBox()
        {
            driver.FindElement(By.LinkText("Checkboxes")).Click();

            List<IWebElement> checkBoxes = driver.FindElements(By.CssSelector("[type=checkbox]")).ToList();
            Assert.IsNotEmpty(checkBoxes);

            var checkBoxFirst = checkBoxes[0];
            var checkBoxSecond = checkBoxes[1];

            SetCheckBoxState(checkBoxFirst, false);
            Assert.IsFalse(checkBoxFirst.Selected);

            checkBoxFirst.Click();
            Assert.IsTrue(checkBoxFirst.Selected);

            SetCheckBoxState(checkBoxSecond, true);
            Assert.IsTrue(checkBoxSecond.Selected);

            checkBoxSecond.Click();
            Assert.IsFalse(checkBoxSecond.Selected);
        }

        public void SetCheckBoxState(IWebElement element, bool flag)
        {
            var selected = element.Selected;
            bool.TryParse(element.GetAttribute("checked"), out bool selectedByAttribute);

            if ((selected || selectedByAttribute) != flag)
            {
                element.Click();
            }
        }
    }
}
