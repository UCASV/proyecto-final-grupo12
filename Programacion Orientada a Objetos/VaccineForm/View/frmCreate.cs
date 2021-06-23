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

        private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            frmPrincipal frmPrincipal = new();
            frmPrincipal.ShowDialog();
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

            Disease dref = (Disease)cmbDisease.SelectedItem;
            Disease ddb = db.Set<Disease>()
                .SingleOrDefault(s => s.Id == dref.Id);

            Institution iref = (Institution)cmbInstitution.SelectedItem;
            Institution idb = db.Set<Institution>()
                .SingleOrDefault(s => s.Id == iref.Id);

            //declarando variables de referencia para que se puedan guardar los id de los cmb
            int diseaseref = int.Parse(cmbDisease.SelectedValue.ToString());
            int institutionref = int.Parse(cmbInstitution.SelectedValue.ToString());

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
            //guardando datos
            db.Add(Acitizen);
            db.SaveChanges();
            //notificando al usuario
            MessageBox.Show("Succesful appointment!", "COVID-19: El Salvador", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
