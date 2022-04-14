using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace ProyectoCodigoLimpioClient.Interfaces
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" && textBoxContraseña.Text == "" && textBoxRepetirContraseña.Text == "")
            {
                MessageBox.Show("Los campos de usuario y/o contraseña están vacíos", "LLena todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
            else if (textBoxContraseña.Text == textBoxRepetirContraseña.Text)
            {
                //Aquí implementar el envío de datos a MongoDB

                insertLoggedUser


                textBoxUsername.Text = "";
                textBoxContraseña.Text = "";
                textBoxRepetirContraseña.Text = "";
                
                MessageBox.Show("Se ha creado correctamente tu cuenta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son las mismas, por favor vuelva a ingresarlas", "Contraseñas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Text = "";
                textBoxRepetirContraseña.Text = "";
                textBoxContraseña.Focus();
            }
        }

        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarContraseña.Checked)
            {
                textBoxContraseña.PasswordChar = '\0';
                textBoxRepetirContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '•';
                textBoxRepetirContraseña.PasswordChar = '•';
            }
        }

        private void buttonVolverAlInicio_Click(object sender, EventArgs e)
        {
            new InicioSesionForm().Show();
            this.Hide();
        }
    }
}
