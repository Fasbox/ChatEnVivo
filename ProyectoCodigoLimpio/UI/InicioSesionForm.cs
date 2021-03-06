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
using ProyectoCodigoLimpioClient.Net.DataBase;
using ProyectoCodigoLimpioClient.Interfaces;  

namespace ProyectoCodigoLimpioClient.Interfaces
{
    public partial class InicioSesionForm : Form
    {
        private IDatabaseService _ClientDatabaseService;
        public InicioSesionForm()
        {
            InitializeComponent();
            _ClientDatabaseService = new MongoDBService();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string contraseña = textBoxContraseña.Text;
            string nickName = textBoxUsername.Text;
            //Implementar conectar el botón con la base de datos MongoDB
            if (nickName != "" && contraseña != "")
            {
                if (_ClientDatabaseService.LoggedUserExist(nickName))
                {
                    LoggedUser usuario = _ClientDatabaseService.ObtenerloggedUser(contraseña, nickName);
                    if(usuario != null)
                    {
                        new Chat(usuario).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("contraseña incorrecta, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxContraseña.Text = "";
                        textBoxContraseña.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Username  incorrecto, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxUsername.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Username o contraseña no pueden estar vacias, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);

        }

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
