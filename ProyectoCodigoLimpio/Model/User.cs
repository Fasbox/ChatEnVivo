using ProyectoCodigoLimpioClient.Net.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Model
{
    public class User
    {
        public string UserName { get; set; }

        public Guid UserId { get; set; }

        private PacketReader _PacketReader;
        public TcpClient ClientSocket { get; set;}
       public User(TcpClient client)
        {
            ClientSocket = client;
            UserId = Guid.NewGuid();
            _PacketReader = new PacketReader(ClientSocket.GetStream());
            var opCode = _PacketReader.ReadByte();
            UserName = _PacketReader.ReadMessage();
            Console.WriteLine($"[{DateTime.Now}]: Client has connected with the username: {UserName}");

            Task.Run(() =>process());   
        }

        void process()
        {
            while (true)
            {
                try
                {
                    var opcode = _PacketReader.ReadByte();
                    switch (opcode)
                    {
                        case 5:
                              var msg = _PacketReader.ReadMessage();
                              Console.WriteLine($"[{DateTime.Now}]: Message Received! {msg}");
                              ServerProgram.BroadcastMessage($"[{DateTime.Now}]: {msg}");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine($"[{UserId.ToString()}]: Disconnected!");
                    ServerProgram.BroadcastDisconnect(UserId.ToString());
                    ClientSocket.Close();
                    break;
                }
            }
        }

    }
}
