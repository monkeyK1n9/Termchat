namespace Termchat;

public class GroupMember : User
{
    public GroupMember(string username) : base(username)
    {

    }
    public override void SendMessage()
    {
        throw new NotImplementedException();
    }
}
