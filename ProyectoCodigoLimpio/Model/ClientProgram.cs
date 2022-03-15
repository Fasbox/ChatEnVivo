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
        public void SendMessageToserver(string Message)
        {
            PacketBuilder messagePacket = new PacketBuilder();
            messagePacket.WriteOpCode(5);
            messagePacket.WriteString(Message);
            _Client.Client.Send(messagePacket.GetPacketBytes());
        }
    }
}
