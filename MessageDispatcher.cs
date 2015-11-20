namespace JonasWallander.ChatClient
{
    public class MessageDispatcher : IMessageDispatcher
    {
        private static readonly object SyncRoot = new object();
        private static volatile IMessageDispatcher instance;

        private MessageDispatcher()
        {
        }

        public static IMessageDispatcher Instance
        {
            get
            {
                if (instance == null)
                {
                    CreateSingeltonInstance();
                }

                return instance;
            }
        }

        public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs e);

        public event MessageReceivedEventHandler MessageReceived;

        public void Dispatch(Message message)
        {
            OnMessageReceived(message);
        }

        private void OnMessageReceived(Message message)
        {
            MessageReceived?.Invoke(this, new MessageReceivedEventArgs(message));
        }

        private static void CreateSingeltonInstance()
        {
            lock (SyncRoot)
            {
                instance = new MessageDispatcher();
            }
        }
    }
}
