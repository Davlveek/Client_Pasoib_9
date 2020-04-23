using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

namespace Client
{
    class CryptoClient
    {
        private readonly TcpClient Client;
        private NetworkStream stream;

        public CryptoClient(string address, int port) => Client.Connect(address, port);

        ~CryptoClient() => Client.Close();

        public void InitNetworkStream() => stream = Client.GetStream();

        public void CloseNetworkStream() => stream.Close();

        public void SendData(byte[] data)
        {
            
        }
    }
}
