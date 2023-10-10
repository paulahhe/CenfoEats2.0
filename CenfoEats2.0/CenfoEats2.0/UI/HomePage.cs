using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CenfoEats2._0.UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string type = null;
            if (rbClient.Checked)
            {
                type = "Cliente";
            }
            if (rbDriver.Checked)
            {
                type = "Repartidor";
            }
            if (email == null || name == null || phoneNumber == null || password == null || type == null)
            {
                MessageBox.Show("Por favor completar el formulario.");
                return;
            }
            else
            { 
            string msg = $"Usuario creado \nEmail: {email}, Nombre: {name}, Teléfono: {phoneNumber},tipo: {type}";
            MessageBox.Show(msg);
            var fabricaUsuarios = new Gestor();
            fabricaUsuarios.nuevoUsuario(name, email, phoneNumber, type, password);
            ResetForm();
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                rbDriver.Checked = false; 
            }
        }

        private void rbDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDriver.Checked)
            {
                rbClient.Checked = false; 
            }
        }

        private void ResetForm()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtPassword.Text= "";
            rbClient.Checked = false; 
            rbDriver.Checked = false ;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
