using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

namespace Client
{
    class CryptoClient : IDisposable
    {
        private TcpClient client;
        private NetworkStream stream;

        public CryptoClient(string address, int port) 
        {
            client = new TcpClient();
            client.Connect(address, port);
        }

        public void Dispose() => client.Close();

        public void InitNetworkStream() => stream = client.GetStream();

        public void CloseNetworkStream() => stream.Close();

        public void SendData(byte[] data) => stream.Write(data, 0, data.Length);
    }
}
