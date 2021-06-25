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


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Are you sure you want to leave?", "COVID-19: El Salvador",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            e.Cancel = (window == DialogResult.No);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            bool exp = true;
            do
            {
                try
                {
                    string textPass = txtPassword.Text;
                    string textEmail = txtUser.Text;
                    string textManager = txtManagerid.Text;
                    var db = new VaccinationContext();

                    //variables de referencia que estan en else
                    var cabinref = int.Parse(cmbCabin.SelectedValue.ToString());
                    var employeeref = int.Parse(txtManagerid.Text);

                    int type = 2; //variable que se usara para que se haga la verificacion del id-tipo_empleado

                    //Lista de empleados
                    var employeeslist = db.Employees.OrderBy(c => c.Id).ToList();

                    // Validando datos
                    var result = employeeslist.Where(u => u.InstitutionalEmail.Equals(txtUser.Text)
                                                          && u.Password.Equals(txtPassword.Text) && u.IdType.Equals(type)
                                                          && u.Id.Equals(employeeref)).ToList();

                    // Hora de inicio de sesion en la plataforma
                    DateTime dh = DateTime.Now;

                    if (result.Count == 0)
                    {
                        var message = MessageBox.Show("User not found", "COVID-19: Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if(message == DialogResult.OK)
                            return;
                    }
                    else
                    {
                        MessageBox.Show($"Welcome {textEmail}", "COVID-19: Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Sesion Asesion = new Sesion()
                        {
                            IdCabin = cabinref,
                            IdEmployee = employeeref,
                            DateHour = dh

                        };
                        //guardando datos
                        db.Add(Asesion);
                        db.SaveChanges();
                        //-----------------------
                        frmPrincipal frmPrincipal = new();
                        frmPrincipal.ShowDialog();
                        this.Hide();
                        exp = false;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter all the requested data", "COVID-19: Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } while (exp);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //mostrando cmb 
            var db = new VaccinationContext();
            cmbCabin.DataSource = db.Cabins.ToList();
            cmbCabin.DisplayMember = "CabinAddress";
            cmbCabin.ValueMember = "Id";
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';

            }
        }
    }
}
