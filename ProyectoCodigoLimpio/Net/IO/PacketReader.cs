using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Net.IO
{
    public class PacketReader : BinaryReader
    {
        private NetworkStream _NetWorkStream;
        public PacketReader(NetworkStream netWorkStream) : base(netWorkStream)
        {
            _NetWorkStream = netWorkStream;
        }
        public string ReadMessage()
        {
            byte[] messageBuffer;
            var length = ReadInt32();
            messageBuffer = new byte[length];
            _NetWorkStream.Read(messageBuffer, 0, length);

            string message = Encoding.UTF8.GetString(messageBuffer);
            return message;
        }
    }
}
