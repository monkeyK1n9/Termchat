namespace Termchat;

abstract public class User
{
    public int UserId { get; private set; }
    public string Username { get; set; }

    public User()
    {
        Username = GenerateRandomUsername();
    }
    public User(string username)
    {
        Username = username;
    }

    abstract public void SendMessage();

    private string GenerateRandomUsername()
    {
        Guid guid = Guid.NewGuid();
        string username = guid.ToString()[0..8];

        return username;
    }
}
