using Catel.MVVM;
using ProyectoCodigoLimpioClient.Model;
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

        private ClientProgram _Client;

        private string _Message;

        public ObservableCollection<string> Messages;
        
        public Chat()
        {
            InitializeComponent();
            Messages = new ObservableCollection<string>();
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
            textBoxUserName.Enabled = false;
            _Client = new ClientProgram();
            _Client.ConnectToServer(_UserName, _Ip, _Port);
            buttonClient.Enabled = false;
            _Client.connectedEvent += UserConnected;
            _Client.messageReceivedEvent += MessageReceived;
            _Client.userDisconnectEvent += UserDisconnect;

        }

        private void UserDisconnect()
        {
           //espacio para implementar que pasa cuando se desconecta un usuario
        }

        private void MessageReceived()
        {
            //espacio para implementar que sucede cuando llega un mensaje desde el servidor
           var message = _Client.PacketReader.ReadMessage();
            //listBoxMessagesReceived.Items.Add(message); 
        }

        private void UserConnected()
        {
            //espacio para implementar que pasa cuando un usario se conecta al servidor
           /*Dictionary<string,string> user = new();
            user.Add("UserName", _Client.PacketReader.ReadMessage());
            user.Add("UserId", _Client.PacketReader.ReadMessage());
            ListBoxUsers.Items.Add(user);
            ListBoxUsers.Update();*/
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
    }
}