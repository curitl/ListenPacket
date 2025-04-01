using System.Net;
using System.Net.Sockets;

namespace ListenPacket
{
    public class Server
    {
        IPAddress address;
        public int port;
        public Socket cSocket;
        TCPConnectedClient connectedClient;


        public Server(TCPConnectedClient cc, IPAddress a, int p)
        {
            cSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connectedClient = cc;
            address = a;
            port = p;
        }

        public void StartClient()
        {
            cSocket.Connect(address, port);
            cSocket.BeginReceive(new byte[] {0}, 0, 0, SocketFlags.None, RevceiveCallback, null);
        }

        public void Close()
        {
            cSocket.Close();
            cSocket.Dispose();
        }

        void RevceiveCallback(IAsyncResult ar)
        {
            try
            {
                cSocket.EndReceive(ar);                

                byte[] recBytes = new byte[AllConst.bufferSize];
                int byteSize = cSocket.Receive(recBytes, recBytes.Length, 0);

                if (byteSize <= 0)
                {
                    Close();
                    //return;
                }
                Array.Resize(ref recBytes, byteSize);

                ServerToClient(connectedClient, recBytes);

                cSocket.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, RevceiveCallback, null);
                            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public Action<TCPConnectedClient, byte[]> ServerToClient;

    }
}
