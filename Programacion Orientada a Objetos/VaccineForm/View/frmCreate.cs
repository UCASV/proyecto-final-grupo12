using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            // Declarando expresiones regulares para evitar datos erroneos
            var expression = @"\d{8}-\d{1}";
            var phone = @"\d{8}";

            Regex myRegex = new Regex(expression);
            Regex mRegex = new(phone);

            Disease dref = (Disease)cmbDisease.SelectedItem;
            Disease ddb = db.Set<Disease>()
                .SingleOrDefault(s => s.Id == dref.Id);

            Institution iref = (Institution)cmbInstitution.SelectedItem;
            Institution idb = db.Set<Institution>()
                .SingleOrDefault(s => s.Id == iref.Id);

            int age = Convert.ToInt32(txtAge.Text);
            //declarando variables de referencia para que se puedan guardar los id de los cmb
            int diseaseref = int.Parse(cmbDisease.SelectedValue.ToString());
            int institutionref = int.Parse(cmbInstitution.SelectedValue.ToString());

            bool validations = Regex.IsMatch(txtDUI.Text, expression) &&
                Regex.IsMatch(txtPhoneNumber.Text, phone) && age > 0 || age <= 120;

            if (validations)

            {
                Citizen Acitizen = new Citizen() //constructor 
                {
                    Dui = txtDUI.Text,
                    FullName = txtName.Text,
                    CitizenAddress = txtAdress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    Age = age,
                    IdDisease = diseaseref,
                    IdInstitution = institutionref
                };
                //guardando datos
                db.Add(Acitizen);
                db.SaveChanges();
            }
            else
                MessageBox.Show("Enter the data correctly", "COVID-19: El Salvador", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            
            //notificando al usuario
            MessageBox.Show("The citizen has been registered!", "COVID-19: El Salvador", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Hide();
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
