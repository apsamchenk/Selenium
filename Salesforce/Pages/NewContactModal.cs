using OpenQA.Selenium;
using Salesforce.Elements;

namespace Salesforce.Pages
{
    public class NewContactModal
    {
        Input lastName = new("Last Name");
        Input accontName = new("Account Name");
        Input mobile = new("Mobile");
        Button saveButton = new(By.XPath("//*[@title='Save']//button"));
        Message message = new(By.ClassName("toastMessage"));
        
        internal void CreateContact(string name, string phone, string listOption)
        {
            lastName.GetElement().SendKeys(name);
            mobile.GetElement().SendKeys(phone);
            accontName.Select(listOption);
            saveButton.GetElement().Click();
        }

        internal string GetMessage()
        {
            return message.GetElement().Text;
        }
    }
}
