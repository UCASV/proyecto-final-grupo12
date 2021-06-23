using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineForm.ProjectContext;

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
           
            string textPass = txtPassword.Text;
            string textEmail = txtUser.Text;

            var db = new VaccinationContext();
            int type = 2; //variable que se usara para que se haga la verificacion del id-tipo_empleado
            
            var employeeslist = db.Employees.OrderBy(c => c.Id).ToList();
            var result = employeeslist.Where(u => u.InstitutionalEmail.Equals(txtUser.Text)
            /*continuacion de result*/     && u.Password.Equals(txtPassword.Text) && u.IdType.Equals(type)).ToList();
            
            
            if(result.Count == 0)
            {
                MessageBox.Show("User not found","COVID-19",
                                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Welcome dear manager", "COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal frmPrincipal = new();
                frmPrincipal.ShowDialog();
                this.Close();

                Sesion Asesion = new Sesion()
                {
                    
                };

            }

          
        }
    }
}
