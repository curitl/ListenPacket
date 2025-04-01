using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Globalization;

namespace ListenPacket
{
    public class TCPConnectedClient
    {
        public Socket socket;
        public Server server;
        public IPAddress address;
        public int port;

        public TCPConnectedClient(Socket s, IPAddress a, int p)
        {
            socket = s;
            address = a;
            port = p;
        }

        public void Start()
        {
            socket.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, RevceiveCallback, null);
            Console.WriteLine("Client is connected to {0} on Port {1}", ((IPEndPoint)socket.RemoteEndPoint).Address, ((IPEndPoint)socket.RemoteEndPoint).Port);
            server = new Server(this, address, port);
            server.StartClient();
        }

        void RevceiveCallback(IAsyncResult ar)
        {
            try
            {
                socket.EndReceive(ar);

                byte[] recBytes = new byte[AllConst.bufferSize];
                int byteSize = socket.Receive(recBytes, recBytes.Length, 0);

                if (byteSize <= 0)
                {
                    Close();
                    return;
                }

                Array.Resize(ref recBytes, byteSize);

                ClientToServer(this, recBytes);

                socket.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, RevceiveCallback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        void Close()
        {
            if (socket != null)
            {
                socket.Close();
                socket.Dispose();
            }
            server.Close();
            GameDisconnect(this);
        }

        public Action<TCPConnectedClient, byte[]> ClientToServer;

        public Action<TCPConnectedClient> GameDisconnect;
    }
}
