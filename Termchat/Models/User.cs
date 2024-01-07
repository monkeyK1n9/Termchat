namespace Termchat;

abstract public class User
{
    public string Username { get; set; }

    public User(string username)
    {
        Username = username;
    }

    abstract public void SendMessage();
}
