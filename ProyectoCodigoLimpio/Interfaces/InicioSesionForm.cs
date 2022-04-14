using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using TrackerUI;

namespace ProyectoCodigoLimpioClient.Interfaces
{
    public partial class InicioSesionForm : Form
    {
        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            //Implementar conectar el botón con la base de datos MongoDB
            if ()
            {
                new Chat().Show();
                //new ServidorConsola().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username o contraseña incorrecta, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Text = "";
                textBoxContraseña.Focus();
            }
        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarContraseña.Checked)
            {
                textBoxContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '•';
            }
        }

        private void buttonIrAlRegistro_Click(object sender, EventArgs e)
        {
            new RegistroForm().Show();
            this.Hide();
        }
    }
}
