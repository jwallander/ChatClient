namespace JonasWallander.ChatClient
{
    public interface IMessageDispatcher
    {
        event MessageDispatcher.MessageReceivedEventHandler MessageReceived;

        void Dispatch(Message message);
    }
}