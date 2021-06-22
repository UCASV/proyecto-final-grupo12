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
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Debe ser cambiado, aca debe ir la ventana principal, donde
            // estaran los datos de los ciudadanos, hacer citas, etc...
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
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

    }
}
