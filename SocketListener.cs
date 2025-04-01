using System.Net;
using System.Net.Sockets;

namespace ListenPacket
{
    public class SocketListener
    {
        IPAddress address = IPAddress.Parse(AllConst.localIP);
        public Socket socket;
        public int port;


        public SocketListener(int p)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            port = p;
        }

        public void StartServer()
        {
            socket.Bind(new  IPEndPoint(address, port));
            socket.Listen(0);
            socket.BeginAccept(Callback, null);
            Console.WriteLine("Currently listening to {0} on Port {1}", ((IPEndPoint)socket.LocalEndPoint).Address, ((IPEndPoint)socket.LocalEndPoint).Port);
        }
        
        public void Disconnect()
        {
            socket.Close();
            socket.Dispose();
        }

        void Callback(IAsyncResult ar) 
        {
            try
            {
                Socket s = socket.EndAccept(ar);

                if (ListenerSocket != null)
                {
                    ListenerSocket(s);
                }

                socket.BeginAccept(Callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Action<Socket> ListenerSocket;

        
    }
}