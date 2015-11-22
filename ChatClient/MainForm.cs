using System;
using System.Net.Http;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;

namespace JonasWallander.ChatClient
{
    public partial class MainForm : Form
    {
        private IDisposable Server { get; set; }

        public MainForm()
        {
            InitializeComponent();

            var instanceNumber = CountNumberOfRunningChatClients();

            MessageDispatcher.Instance.MessageReceived += MessageDispatcherOnMessageReceived;

            // ReSharper disable once LocalizableElement
            uxRemoteUrl.Text = "http://localhost";
            uxLocalPort.Text = (9090 + instanceNumber).ToString();
            uxConnect.Enabled = false;
            uxSend.Enabled = false;
        }

        private void MessageDispatcherOnMessageReceived(object sender, MessageReceivedEventArgs messageReceivedEventArgs)
        {
            var message = messageReceivedEventArgs.Message;
            Invoke((MethodInvoker)delegate
                {
                    MessageToChat(message);
                });
        }

        private void OnUxConnectClick(object sender, EventArgs e)
        {
            var baseAddress = $"http://localhost:{uxLocalPort.Text}/";

            Server = WebApp.Start<ChatServer>(baseAddress);

            uxConnect.Enabled = false;
            uxSend.Enabled = true;
        }

        private void OnUxChatMessageClick(object sender, EventArgs e)
        {
            var message = new Message { Text = uxChatMessage.Text, Name = uxName.Text };

            var client = new HttpClient();
            client.PostAsJsonAsync($"{uxRemoteUrl.Text}:{uxRemotePort.Text}/api/messages", message);

            MessageToChat(message);

            uxChatMessage.Text = string.Empty;
        }

        private void MessageToChat(Message message)
        {
            uxChat.Text = uxChat.Text + $"{message.Name}: {message.Text}" + Environment.NewLine + Environment.NewLine;
        }

        private static int CountNumberOfRunningChatClients()
        {
            return System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Length;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Server?.Dispose();
        }

        private void ValidateConnect(object sender, EventArgs e)
        {
            if (!uxRemotePort.Text.Equals(string.Empty) && !uxName.Text.Equals(string.Empty))
            {
                uxConnect.Enabled = true;
            }
            else
            {
                uxConnect.Enabled = false;
            }
        }
    }
}
