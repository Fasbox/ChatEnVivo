using Catel.MVVM;
using ProyectoCodigoLimpioClient.Model;
using ProyectoCodigoLimpioClient.Net.DataBase;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace TrackerUI
{
    public partial class Chat : Form
    {
        private string _Ip;

        private int _Port;

        private string _UserName;

        private ClientDatabaseService _ClientDatabaseService;

        private ClientProgram _Client;

        private string _Message;

        private LoggedUser _LoggedUser;

        delegate void ActualizarMensajes(String mensaje);

        delegate void ActualizarContactos(String nombre);  
        public Chat(LoggedUser loggedUser)
        {
            
            InitializeComponent();
            sendButton.Enabled = false;
            _ClientDatabaseService = new ClientDatabaseService();
            _LoggedUser = loggedUser;
            textBoxUserName.Enabled = false;
            textBoxUserName.Text = loggedUser.Nickname;
            foreach( string mensaje in loggedUser.Messages)
            {
                listBoxMessagesReceived.Items.Add(mensaje);
            }
        }   

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mouseX = 0;
        int mouseY = 0;
        int mouseinX = 0;
        int mouseinY = 0;
        bool mouseDown;
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
                                  
            textBoxIP.Enabled = false;
            textBoxPort.Enabled = false;
            _Client = new ClientProgram();
            _Client.ConnectToServer(_UserName, _Ip, _Port);
            buttonClient.Enabled = false;
            _Client.connectedEvent += UserConnected;
            _Client.messageReceivedEvent += MessageReceived;
            _Client.userDisconnectEvent += UserDisconnect;

        }

        private void UserDisconnect()
        {
           String ContactoDesconectado = _Client.PacketReader.ReadMessage();
           BorrardeListaContactos(ContactoDesconectado);
        }

        private void MessageReceived()
        {
           
           var message = _Client.PacketReader.ReadMessage();
            MostrarMensaje(message);
           
        }
        private void MostrarMensaje(String mensaje) 
        {
            if (listBoxMessagesReceived.InvokeRequired)
            {
                ActualizarMensajes delegado = new ActualizarMensajes(MostrarMensaje);
                Invoke(delegado, mensaje);
            }
            else
            {
                listBoxMessagesReceived.Items.Add(mensaje);
                _LoggedUser.Messages.Add(mensaje.ToString());
                _ClientDatabaseService.UpdateLoggedUser(_LoggedUser);
            }
        }

        private void UserConnected()
        {
            var nombre = _Client.PacketReader.ReadMessage();
            if (!ListBoxUsers.Items.Contains(nombre)) {
                AñadirListaContactos(nombre);
            }
  
        }

        private void AñadirListaContactos(String nombre) {
            if (ListBoxUsers.InvokeRequired)
            {
                ActualizarContactos delegado = new ActualizarContactos(AñadirListaContactos);
                Invoke(delegado, nombre);
            }
            else {
                ListBoxUsers.Items.Add(nombre);
            }
        }
        private void BorrardeListaContactos(String nombre)
        {
            if (ListBoxUsers.InvokeRequired)
            {
                ActualizarContactos delegado = new ActualizarContactos(BorrardeListaContactos);
                Invoke(delegado, nombre);
            }
            else
            {
                ListBoxUsers.Items.Remove(nombre);
                ListBoxUsers.Refresh();
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }
        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {
            _Ip = textBoxIP.Text;
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            _Port = Int32.Parse(textBoxPort.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _Message = textBox.Text;
            if (_Message == "") {
                sendButton.Enabled = false;
                return;
            }
            sendButton.Enabled = true;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            _Message = $"{_UserName}: " + _Message;
            _Client.SendMessageToserver(_Message);
            textBox.Text = String.Empty; 
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            _UserName = textBoxUserName.Text;
        }

        private void ListBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}