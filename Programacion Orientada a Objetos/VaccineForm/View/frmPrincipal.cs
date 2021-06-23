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
            MessageBox.Show("Are you sure you want to leave?", "COVID-19: El Salvador",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DateTime Asesion = DateTime.Today;
            lbldate.Text = Asesion.ToString();
        }
    }
}
