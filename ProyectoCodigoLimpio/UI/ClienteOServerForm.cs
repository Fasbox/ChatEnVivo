using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoCodigoLimpioClient.Interfaces
{

    public partial class ClienteOServerForm : Form
    {
        public ClienteOServerForm()
        {
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            new InicioSesionForm().Show();
            this.Hide();
        }

        private void buttonIrServidor_Click(object sender, EventArgs e)
        {
            new ServidorForm().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void ClienteOServerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
