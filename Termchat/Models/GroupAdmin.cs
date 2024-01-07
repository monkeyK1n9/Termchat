namespace Termchat;

public class GroupAdmin : User
{

    public GroupAdmin(string username) : base(username)
    {

    }
    public override void SendMessage()
    {
        throw new NotImplementedException();
    }
}
