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

        /// <summary>
        /// Funcion para pasar el codigo de operacion por el memory stream
        /// </summary>
        /// <param name="opCode"></param>
        public void WriteOpCode(byte opCode)
        {
            _MStream.WriteByte(opCode);
        }

        /// <summary>
        /// Funcion para convertir el mensaje que entra en paramentro en un paquete de bytes
        /// </summary>
        /// <param name="message"></param>
        /// 
        public void WriteString(string message)
        {
            int messageLength = message.Length;
            _MStream.Write(BitConverter.GetBytes(messageLength));
            _MStream.Write(Encoding.ASCII.GetBytes(message));
        }
        /// <summary>
        /// Funcion para obtener el array de bytes que estan guardados en el memoryStream
        /// </summary>
        /// <returns></returns>
        public byte[] GetPacketBytes()
        {
            return _MStream.ToArray();
        }
    }
}
