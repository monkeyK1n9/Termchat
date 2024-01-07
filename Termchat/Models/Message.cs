namespace Termchat;

public class Message
{
    public int MessageId { get; set; }
    public string Sender { get; set; }
    public string MessageBody { get; set; }

    public Message(string sender, string messageBody)
    {
        Sender = sender;
        MessageBody = messageBody;
    }
}
