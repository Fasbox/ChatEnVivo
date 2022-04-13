 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ProyectoCodigoLimpioClient.Net.IO;

namespace ProyectoCodigoLimpioClient.Model
{
    public class ClientProgram
    {
        private TcpClient _Client;

        public PacketReader PacketReader;

        public event Action userDisconnectEvent;

        public event Action connectedEvent;

        public event Action messageReceivedEvent;

        public ClientProgram()
        {
            _Client = new TcpClient();
        }
        /// <summary>
        /// Función que se encarga de crear la conexión con el servidor, para lo cual usamos ip y port, 
        /// envia un mensaje al servidor con el nombre de usuario para crear al usuario
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        public void ConnectToServer(string userName, string ip, int port)
        {
            if (!_Client.Connected)
            {

                _Client.Connect(ip, port);
                PacketReader = new PacketReader(_Client.GetStream());
                if (!string.IsNullOrEmpty(userName))
                {
                    var connectPacket = new PacketBuilder();
                    connectPacket.WriteOpCode(0);
                    connectPacket.WriteString(userName);
                    _Client.Client.Send(connectPacket.GetPacketBytes());
                }
                ReadPackets();
            }
        }

        /// <summary>
        /// Funcion para ver a cual codigo de operacion pertenece el mensaje que llega del servidor e invocar
        /// el evento correspondiente a dicho codigo 
        /// </summary>
        private void ReadPackets()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    var opcode = PacketReader.ReadByte();
                    switch (opcode)
                    {
                        case 1:
                            connectedEvent?.Invoke();
                            break;
                        case 5:
                            messageReceivedEvent?.Invoke();
                            break;
                        case 10:
                            userDisconnectEvent?.Invoke();
                            break;

                        default:
                            Console.WriteLine("opcode not expected");
                            break;
                    }
                }
            });
        }

        /// <summary>
        /// Funcion para codificar , formatear y enviar el mensaje del cliente al servidor
        /// </summary>
        /// <param name="Message"></param>
        public void SendMessageToserver(string Message)
        {
            PacketBuilder messagePacket = new PacketBuilder();
            messagePacket.WriteOpCode(5);
            messagePacket.WriteString(Message);
            _Client.Client.Send(messagePacket.GetPacketBytes());
        }
    }
}
