namespace Salesforce.CORE
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public UserModel(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
