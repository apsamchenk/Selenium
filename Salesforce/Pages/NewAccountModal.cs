using OpenQA.Selenium;
using Salesforce.Elements;

namespace Salesforce.Pages
{
    public class NewAccountModal
    {
        Input accountName = new("Account Name");
        DropDown typeDropDown = new("Type");
        Button saveButton = new(By.XPath("//*[@title='Save']//button"));
        Message message = new(By.ClassName("toastMessage"));

        internal void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select(listOption);
            saveButton.GetElement().Click();
        }

        internal string GetMessage()
        {
            return message.GetElement().Text;
        }
    }
}
