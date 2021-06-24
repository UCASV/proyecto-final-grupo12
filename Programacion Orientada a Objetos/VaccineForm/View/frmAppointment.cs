using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using VaccineForm.ProjectContext;
namespace VaccineForm.View
{
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

     

        private void btnVaccinate_Click(object sender, EventArgs e)
        {
            var context = new VaccinationContext();
            string Dui = txtDUI.Text;
            var listCitizen = context.Citizens.OrderBy(c => c.Dui).ToList();

            var results = listCitizen.Where(c => c.Dui.Equals(Dui)
                && c.IdInstitution > 1 && c.Age > 60 || (c.Age > 18 && c.IdDisease != 8)).ToList();

            DateTime date1 = DateTime.Now;
            
            //id de cabina donde se aplico la vacuna
            int cabinref = int.Parse(cmbCabin.SelectedValue.ToString());

            // Variables para la cita de segunda dosis del ciudadano
            DateTime startDateTime = DateTime.Now;
            Random gen = new();
            var range = (DateTime.Today - startDateTime.AddDays(42)).Days;

            if (results.Any())
            {
                MessageBox.Show($"DUI: {Dui} has been vaccinated ", "COVID-19: Vaccinate",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                tabAppointment.SelectedTab = tabPAppointment;

                DateTime ramDateTime()
                {
                    return startDateTime.AddDays(gen.Next(range));
                }

                string date2 = ramDateTime().ToString("dd-MM-yy//hh:mm");
                lblProxDose.Text = date2;

                //Agregando datos y actualizando base de datos

                Appointment appointmentN = new Appointment()
                {
                    IdCitizen = Dui,
                    DateVaccination1 = date1,
                    IdCabin = cabinref,
                    DateVaccination2 = ramDateTime()
                };
                
                context.Add(appointmentN);
                context.SaveChanges();

            }
            else
                MessageBox.Show($"DUI: {Dui} does not belong to the priority groups ", "COVID-19: Vaccinate",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            //mostrando cmb 
            var db = new VaccinationContext();
            cmbCabin.DataSource = db.Cabins.ToList();
            cmbCabin.DisplayMember = "CabinAddress";
            cmbCabin.ValueMember = "Id";

            //mostrando cmb de efectos secundarios

            cmbSideEffects.DataSource = db.SideEffects.ToList();
            cmbSideEffects.DisplayMember = "SecondaryEffect";
            cmbSideEffects.ValueMember = "Id";

        }

        private void btnAddApoint_Click(object sender, EventArgs e)
        {
            string Dui = txtDUI.Text;
            var context = new VaccinationContext();
            var sideEffc = int.Parse(cmbSideEffects.SelectedValue.ToString());

            // Validando que el usuario exista
            var listCitizen = context.Citizens.OrderBy(c => c.Dui).ToList();
            var result = listCitizen.Where(x => x.Dui.Equals(Dui)).ToList();


            if (result.Any())
            {
                // Añadiendo un efecto secundario al ciudadano
                var query = (from ct in context.Citizens
                    where ct.Dui == Dui
                    select ct).Single();
                
                query.IdSecEffect = sideEffc;
                
                context.SaveChanges();

                MessageBox.Show("Successful appointment!", "COVID-19: Appointments",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

    }
}
