using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Net.IO
{
    public class PacketBuilder
    {
        MemoryStream _MStream;
        public PacketBuilder()
        {
            _MStream = new MemoryStream();    
        }
        public void WriteOpCode(byte opCode)
        {
            _MStream.WriteByte(opCode);
        }

        public void WriteString(string message)
        {
            int messageLength = message.Length;
            _MStream.Write(BitConverter.GetBytes(messageLength));
            _MStream.Write(Encoding.UTF8.GetBytes(message));
        }
        public byte[] GetPacketBytes()
        {
            return _MStream.ToArray();
        }
    }
}
