using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Chat_Application_For_PC
{
    public partial class Chat : Form
    {
        #region Variables
        string username;
        private Socket clientSocket;
        private EndPoint epServer;
        private byte[] dataStream = new byte[1024];
        DateTime currentDateTime;

        private delegate void DisplayMessageDelegate(string message);
        private DisplayMessageDelegate displayMessageDelegate = null;
        #endregion

        #region Constructor
        public Chat(string user)
        {
            InitializeComponent();
            this.username = user;
            usernameLabel.Text += user;
            ConnectClient();
            this.currentDateTime = DateTime.Now;
            chatBox.Text += currentDateTime.ToString("yyyy/MM/dd")+"\n";
        }

        #endregion

        #region Connection
        private void ConnectClient()
        {
            try
            {
                // Initialise a packet object to store data that will be send
                Packet sendData = new Packet();
                sendData.ChatName = this.username;
                sendData.ChatMessage = null;
                sendData.ChatDataIdentifier = DataIdentifier.LogIn;

                // Initialise client socket
                this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Getting server IP
                string IP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == AddressFamily.InterNetwork).First().ToString();
                IPAddress serverIP = IPAddress.Parse(IP);

                // Initialise the IPEndPoint for server with port 30000
                IPEndPoint server = new IPEndPoint(serverIP, 30000);

                // Initialise EndPoint for server
                epServer = (EndPoint)server;

                // Get packet as byte array
                byte[] data = sendData.GetDataStream();

                // Send data to server
                clientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback(this.SendData), null);

                //Initialise data stream
                this.dataStream = new byte[1024];

                // Begin listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(this.ReceiveData), null);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connection Error: " + ex.ToString());
            }
        }
        #endregion

        #region Send and Receive Data
        private void SendData(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Send Data: " + ex.ToString());
            }
        }

        private void ReceiveData(IAsyncResult ar)
        {
            try
            {
                this.clientSocket.EndReceive(ar);
                Packet receiveData = new Packet(this.dataStream);

                if (receiveData.ChatMessage != null) this.Invoke(this.displayMessageDelegate, new object[] { receiveData.ChatMessage });
                
                this.dataStream = new byte[1024];

                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(this.ReceiveData), null);
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                Debug.WriteLine("Receive Data: " + ex.ToString());
            }
        }

        #endregion

        #region Events
        private void ChatBox_TextChanged(object sender, EventArgs e)
        {
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.currentDateTime = DateTime.Now;
                Packet sendData = new Packet();
                sendData.ChatName = this.username;
                if (!chatBox.Text.Contains(currentDateTime.ToString("yyyy/MM/dd"))) chatBox.Text += currentDateTime.ToString("yyyy/MM/dd") + "\n";
                sendData.ChatMessage = messageBox.Text.Trim();
                sendData.ChatDataIdentifier = DataIdentifier.Message;

                byte[] byteData = sendData.GetDataStream();

                clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(this.SendData), null);
                messageBox.Clear();
                messageBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Send Error: " + ex.ToString());
            }

        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift) e.SuppressKeyPress = false;
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendButton_Click(sender, e);
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            this.displayMessageDelegate = new DisplayMessageDelegate(this.DisplayMessage);
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(this.clientSocket!= null)
                {
                    Packet sendData = new Packet();
                    sendData.ChatDataIdentifier = DataIdentifier.LogOut;
                    sendData.ChatName = this.username;
                    sendData.ChatMessage = null;

                    byte[] byteData = sendData.GetDataStream();
                    this.clientSocket.SendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer);
                    this.clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Clossing error: " + ex.ToString());
            }
        }
        #endregion

        #region Other
        private void DisplayMessage(string message)
        {
            chatBox.Text += message + "\n";
        }
        #endregion
    }
}
