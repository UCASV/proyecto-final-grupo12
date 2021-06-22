using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineForm.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.ForeColor = Color.Black;
                txtUser.Text = "";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';

            }
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure you want to leave?", "COVID-19: El Salvador",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // falta validacion directa de base de datos y validaciones propias de la aplicacion
            
            string textPass = txtPassword.Text;
            string textEmail = txtUser.Text;

            // poner condicionales
            frmPrincipal frmPrincipal = new();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
