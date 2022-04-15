using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ServidorConsola.Net.IO;

namespace ServidorConsola.Model
{
    public class ServerProgram
    {
        public static List<User> _Users;

        private TcpListener Listener;
        public ServerProgram(string ip, int port)
        {
            _Users = new List<User>();
            Listener = new TcpListener(IPAddress.Parse(ip), port);
            Listener.Start();
            Console.WriteLine("Esperando conexión");
            while (true)
            {
                // ciclo infinito que constantemente espera que un cliente se conecte para crearle un usuario y añadirlo a la lista
                var newUser = new User(Listener.AcceptTcpClient());
                _Users.Add(newUser);
                BroadcastConnetion();
            }

        }

        /// <summary>
        /// Funcion para enviar un mensaje a cada usuario que pertenezca a la lista de usuarios, que un nuevo usuario ha ingresado al servidor
        /// </summary>
        public static void BroadcastConnetion()
        {
            foreach (User user in _Users)
            {
                foreach (User userIterator in _Users)
                {
                    PacketBuilder broadCastPacket = new PacketBuilder();
                    broadCastPacket.WriteOpCode(1);
                    broadCastPacket.WriteString(userIterator.UserName);
                    user.ClientSocket.Client.Send(broadCastPacket.GetPacketBytes());
                }
                BroadcastMessage($"[{_Users[_Users.Count - 1].UserName}] Connected.");
            }
        }

        /// <summary>
        /// Funcion que recibe el mensaje que envia un usuario al servidor y lo reenvia a cada usuario en la lista de usuarios
        /// </summary>
        /// <param name="message"></param>
        public static void BroadcastMessage(string message)
        {

            foreach (User user in _Users)
            {
                PacketBuilder messagePacket = new PacketBuilder();
                messagePacket.WriteOpCode(5);
                messagePacket.WriteString(message);
                user.ClientSocket?.Client.Send(messagePacket.GetPacketBytes());
            }
        }

        /// <summary>
        /// Funcion que envia un mensaje a cada usuario notificando que quien ha dejado el servidor
        /// </summary>
        /// <param name="userId"></param>
        public static void BroadcastDisconnect(string userId)
        {
            var disconnectedUser = _Users.Where(x => x.UserId.ToString() == userId).FirstOrDefault();
            _Users.Remove(disconnectedUser);

            foreach (User user in _Users)
            {
                PacketBuilder broadcastPacket = new PacketBuilder();
                broadcastPacket.WriteOpCode(10);
                broadcastPacket.WriteString(disconnectedUser.UserName);
                user.ClientSocket?.Client.Send(broadcastPacket.GetPacketBytes());
            }
            BroadcastMessage($"[{disconnectedUser.UserName}] disconnected.");
        }
    }
}
