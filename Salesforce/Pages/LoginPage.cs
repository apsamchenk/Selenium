using OpenQA.Selenium;
using Salesforce.CORE;
using Salesforce.Elements;

namespace Salesforce.Pages
{
    public class LoginPage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Button loginButton = new("Login");

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://dfgdfsd-dev-ed.develop.my.salesforce.com/");
            return this;
        }

        public LoginPage Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://dfgdfsd-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            Browser.Instance.NavigateToUrl("https://dfgdfsd-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewContactModal();
        }
    }
}
