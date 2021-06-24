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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Regresando a la ventana principal de la aplicacion
            var message = MessageBox.Show("Are you sure you want to leave?", "COVID-19: El Salvador",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                this.Hide();
                frmPrincipal frmPrincipal = new();
                frmPrincipal.ShowDialog();
            }
         
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();

            // Booleano para tener el control de la excepcion
            bool ex = true;
           
            // variables para los textbox

            string Dui = txtDUI.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;

            Disease dref = (Disease)cmbDisease.SelectedItem;
            Disease ddb = db.Set<Disease>()
                .SingleOrDefault(s => s.Id == dref.Id);

            Institution iref = (Institution)cmbInstitution.SelectedItem;
            Institution idb = db.Set<Institution>()
                .SingleOrDefault(s => s.Id == iref.Id);

            //declarando variables de referencia para que se puedan guardar los id de los cmb
            int diseaseref = int.Parse(cmbDisease.SelectedValue.ToString());
            int institutionref = int.Parse(cmbInstitution.SelectedValue.ToString());

            var listCitizen = db.Citizens.OrderBy(c => c.Dui).ToList();
            var results = listCitizen.Where(c => c.Dui.Equals(txtDUI.Text)).ToList();

            do
            {
                try
                {
                    if (Dui.Length > 10)
                    {
                        var message = MessageBox.Show("The DUI must have a hyphen and it's 9 digits",
                            "COVID-19: El Salvador", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        if (message == DialogResult.OK)
                            return;
                        
                    }
                    else if (phone.Length > 8 && phone.StartsWith("1") || phone.StartsWith("3") || phone.StartsWith("4")
                             || phone.StartsWith("5") || phone.StartsWith("8") || phone.StartsWith("9"))
                    {
                        var me = MessageBox.Show("The phone must only have 8 digits (without hyphen) or 9 digits (with hyphen)",
                            "COVID-19: El Salvador", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        if (me == DialogResult.OK)
                            return;
                    }
                    else if (Convert.ToInt32(txtAge.Text) < 18 || Convert.ToInt32(txtAge.Text) > 120)
                    {
                        var me = MessageBox.Show("Must be of legal age (18 years or older) or or under 120 years",
                            "COVID-19: El Salvador", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        if (me == DialogResult.OK)
                            return;
                    }
                    else if (Dui.Length <= 10
                        && phone.Length <= 8 
                        && phone.StartsWith("7") || phone.StartsWith("6") || phone.StartsWith("2")
                        && int.Parse(txtAge.Text) >= 18 || int.Parse(txtAge.Text) <= 120)
                    {
                            if (results.Any())
                            {
                                var message= MessageBox.Show("The citizen already exists!", "COVID-19: Create citizen",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                if (message == DialogResult.OK)
                                    return;
                                
                            }
                            else
                            {
                                Citizen Acitizen = new Citizen() //constructor 
                                {
                                    Dui = txtDUI.Text,
                                    FullName = txtName.Text,
                                    CitizenAddress = txtAdress.Text,
                                    PhoneNumber = txtPhoneNumber.Text,
                                    Email = txtEmail.Text,
                                    Age = Convert.ToInt32(txtAge.Text),
                                    IdDisease = diseaseref,
                                    IdInstitution = institutionref
                                };
                                
                                //Agregando ciudadano y guardando datos en base de datos
                                db.Add(Acitizen);
                                db.SaveChanges();
                                //notificando al usuario
                                var m = MessageBox.Show("The citizen has been registered!", "COVID-19: Create citizen",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                //Finalizando ciclo de la excepcion
                                    ex = false;
                                    
                            }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR!. Check data!",
                        "COVID-19: Create citizen", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            } while (ex);
        }

        

        private void frmCreate_Load(object sender, EventArgs e)
        {
            //mostrando en los combobox las enfermades posibles e instituciones
            var db = new VaccinationContext();
            cmbDisease.DataSource = db.Diseases.ToList();
            cmbDisease.DisplayMember = "IllnessName";
            cmbDisease.ValueMember = "Id";

            cmbInstitution.DataSource = db.Institutions.ToList();
            cmbInstitution.DisplayMember = "NameInstitution";
            cmbInstitution.ValueMember = "Id";
        }

    }
}
