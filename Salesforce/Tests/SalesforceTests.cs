using NUnit.Framework;
using Salesforce.CORE;
using Salesforce.Pages;

namespace Salesforce.Tests
{
    public class SalesforceTests
    {
        [Test]
        public void CreateAccount()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage().OpenPage().Login(user).OpenNewAccountModal().CreateAccount("FirstUser", "Prospect");

            Assert.That(new NewAccountModal().GetMessage, Is.EqualTo("Account \"FirstUser\" was created."));
        }

        [Test]
        public void CreateContact()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage().OpenPage().Login(user).OpenNewContactModal().CreateContact("Last Name", "79221765656", "FirstUser");

            Assert.That(new NewContactModal().GetMessage, Is.EqualTo("Contact \"Last Name\" was created."));
        }
    }
}
