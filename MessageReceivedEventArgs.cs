namespace JonasWallander.ChatClient
{
    public class MessageReceivedEventArgs
    {
        public MessageReceivedEventArgs(Message message)
        {
            Message = message;
        }

        public Message Message { get; }
    }
}