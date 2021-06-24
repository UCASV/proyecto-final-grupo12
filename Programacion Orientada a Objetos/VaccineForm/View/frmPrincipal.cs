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
using VaccineForm.ViewModels;

namespace VaccineForm.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCreateCitizen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreate frmCreate = new();
            frmCreate.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrando ventana principal
            var window = MessageBox.Show("Are you sure you want to leave?", "COVID-19: El Salvador",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            e.Cancel = (window == DialogResult.No);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //mostrando fecha para el principal
            
            lbldate.Text = DateTime.Now.ToString("HH:mm:ss");

            var people = new List<Citizen>();

            dgvData.DataSource = people;

            //-------------------------------
            dgvData.DataSource = null;
            var context = new VaccinationContext();

            var newDS = context.Citizens.ToList();

            var mappedDS = new List<CitizenVM>();

            newDS.ForEach(e => mappedDS.Add(ProjectContextMapper.MapCitizenToCitizenVM(e)));

            dgvData.DataSource = mappedDS;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment feAppointment = new();
            feAppointment.ShowDialog();
        }
    }
}
