namespace DesignPatters.PatternsEstrutural.Proxy.Model
{
    public class User
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}