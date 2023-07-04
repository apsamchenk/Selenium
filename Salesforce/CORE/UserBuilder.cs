using NUnit.Framework;

namespace Salesforce.CORE
{
    public class UserBuilder
    {
        public static UserModel GetSalesForceUser()
        {
            return new UserModel(TestContext.Parameters.Get("SalesForceUserName"), TestContext.Parameters.Get("SalesForceUserPassword"));
        }
    }
}
