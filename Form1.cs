using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ListenPacket
{
    public partial class Form1 : Form
    {
        private SocketListener serverListener;
        private TCPConnectedClient clientGame = null;
        byte[] byteArrayA;
        byte[] byteArrayB;
        Regex regex = new Regex("^[0-9]*$");
        string lastValidText = "";
        int port;
        IPAddress address;
        bool btnState = false; //Listener haven't start yet = false; Listener started = true

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        public Form1()
        {
            InitializeComponent();

            AllocConsole();
        }

        private void SocketAccepted(Socket s)
        {
            if (clientGame == null)
            {
                clientGame = new TCPConnectedClient(s, address, port);
                clientGame.GameDisconnect += clientDisconnected;
                clientGame.ClientToServer += SendtoServerT;
                clientGame.Start();
                clientGame.server.ServerToClient += SendtoGameClient;
            }
        }

        void SendtoGameClient(TCPConnectedClient client, byte[] bytes)
        {
            client.socket.Send(bytes);
            byteArrayA = (byte[])bytes.Clone();

            if (!slCheckBox.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(DateTime.Now.ToString("[HH:mm:ss.fff]"));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" From Server : ");
                Console.ResetColor();
                Console.WriteLine(Util.ByteArrayToString(Util.Encryption(bytes)) + " (Byte Size : {0})", bytes.Length);

                this.Invoke((MethodInvoker)delegate
                {
                    clientTB.AppendText(Util.ByteArrayToString(Util.Encryption(byteArrayA)) + Environment.NewLine);
                });
            }

        }
        void SendtoServerT(TCPConnectedClient client, byte[] bytes)
        {
            client.server.cSocket.Send(bytes);
            byteArrayB = (byte[])bytes.Clone();

            if (!slCheckBox.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(DateTime.Now.ToString("[HH:mm:ss.fff]"));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" From Client : ");
                Console.ResetColor();
                Console.WriteLine(Util.ByteArrayToString(Util.Encryption(bytes)) + " (Byte Size : {0})", bytes.Length);

                this.Invoke((MethodInvoker)delegate
                {
                    serverTB.AppendText(Util.ByteArrayToString(Util.Encryption(byteArrayB)) + Environment.NewLine);
                });
            }

        }

        void clientDisconnected(TCPConnectedClient g)
        {
            clientGame = null;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            string pkText = cPacketTB.Text;
            pkText = pkText.Replace(" ", "").Replace("-", "").Replace("\r\n", "");

            byte[] bytes = Convert.FromHexString(pkText);
            clientGame.socket.Send(Util.Encryption(bytes));
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            string pkText = cPacketTB.Text;
            pkText = pkText.Replace(" ", "").Replace("-", "").Replace("\r\n", "");

            byte[] bytes = Convert.FromHexString(pkText);
            clientGame.server.cSocket.Send(Util.Encryption(bytes));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!btnState)
            {
                try
                {
                    Console.WriteLine(IPAddress.Parse(ipTB.Text));
                    address = IPAddress.Parse(ipTB.Text);

                    if (regex.IsMatch(portTB.Text))
                    {
                        port = Convert.ToInt32(portTB.Text);

                        serverListener = new SocketListener(port);
                        serverListener.ListenerSocket += SocketAccepted;
                        serverListener.StartServer();

                        resultLbl.ForeColor = Color.Black;
                        resultLbl.Text = "Server is connected to " + address.ToString() + ":" + portTB.Text;

                        btnState = true;
                        button1.Text = "Stop";
                    }
                }
                catch (Exception ex)
                {
                    resultLbl.ForeColor = Color.Red;
                    Console.WriteLine(ex.Message);
                    resultLbl.Text = ex.Message;
                }
            } else
            {
                resultLbl.ForeColor = Color.Black;
                resultLbl.Text = "Data Packets are still logging until the client or this software is turned off";

                serverListener.Disconnect();
                btnState = false;
                button1.Text = "Start";
            }
            
        }

        private void portTB_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(portTB.Text) || portTB.Text == "")
            {
                // Update last valid text if input is valid
                lastValidText = portTB.Text;
            }
            else
            {
                // Revert to last valid text and restore cursor position
                int cursorPos = portTB.SelectionStart;
                portTB.Text = lastValidText;
                portTB.SelectionStart = Math.Max(0, cursorPos - 1);
            }
        }
    }
}
