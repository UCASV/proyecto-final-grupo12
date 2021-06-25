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
             
            bool ex = true;

            // Lista de ciudadanos
            var listCitizen = context.Citizens.OrderBy(c => c.Dui).ToList();
            var results = listCitizen.Where( c => c.Dui.Equals(Dui) 
                                                        && c.Age >= 60
                                                        || c.IdInstitution > 1).ToList();

            var result1 = listCitizen
                .Where(c => c.Dui.Equals(Dui) && c.Age >= 18 && c.IdDisease != 8 && c.IdDisease != 1 || c.IdInstitution > 1).ToList();
            // lista que evitara ingresar una cita con el mismo ciudadano
            var listAppoint = context.Appointments.OrderBy(a => a.IdCitizen).ToList();
            var resultaAppoint = listAppoint.Where(a => a.IdCitizen.Equals(Dui)).ToList();

            DateTime date1 = DateTime.Now;
            
            //id de cabina donde se aplico la vacuna
            int cabinref = int.Parse(cmbCabin.SelectedValue.ToString());


            do
            {
                try
                {
                    // Condicional que dara como resultado si el ciudadano a sido vacunado anteriormente.
                    // Permitira no modificar citas ni efectos secundarios del ciudadano en cuestion
                    if (resultaAppoint.Any())
                    {
                        var mDialogResult = MessageBox.Show($"DUI: {Dui} has been previously vaccinated", "COVID-19: Vaccinate",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (mDialogResult == DialogResult.OK)
                            return;
                    }
                    else
                    {
                        if (results.Any() && result1.Any())
                        {

                            //Agregando datos y actualizando base de datos
                            MessageBox.Show($"DUI: {Dui} has been vaccinated ", "COVID-19: Vaccinate",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            Appointment appointmentN = new Appointment()
                            {
                                IdCitizen = Dui,
                                DateVaccination1 = date1,
                                IdCabin = cabinref,
                            };

                            context.Add(appointmentN);
                            context.SaveChanges();
                            tabAppointment.SelectedTab = tabPAppointment;
                            ex = false;
                        }
                        else
                            MessageBox.Show($"DUI: {Dui} does not belong to the priority groups ", "COVID-19: Vaccinate",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show($"CHECK DATA", "COVID-19: Vaccinate",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    return;
                }
            } while (ex);
            
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            //mostrando cmb cabina
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

            // Variables para la cita de segunda dosis del ciudadano. Generadores de una fecha aleatoria
            DateTime startDateTime = DateTime.Now;
            Random gen = new();
            var range = (startDateTime.AddDays(42) - DateTime.Today).Days;

            //Generador de fecha aleatoria
            DateTime ramDateTime()
            {
                return startDateTime.AddDays(gen.Next(range));
            }

            string date2 = ramDateTime().ToString("dd-MM-yy//hh:mm");
            lblProxDose.Text = date2;

            // Lista de ciudadanos
            var listCitizen = context.Citizens.OrderBy(c => c.Dui).ToList();
            var results = listCitizen.Where(c => c.Dui.Equals(Dui)).ToList();

            

            if (results.Any())
            {
                
                // Añadiendo un efecto secundario al ciudadano y fecha de la cita
                var query = (from ct in context.Citizens
                    where ct.Dui == Dui
                    select ct).Single();

                var query2 = (from ap in context.Appointments
                    where ap.IdCitizen == Dui
                    select ap).Single();
                
                query.IdSecEffect = sideEffc;
                query2.DateVaccination2 = ramDateTime();

                context.SaveChanges();

                MessageBox.Show("Successful appointment!", "COVID-19: Appointments",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
            }
            
        }

    }
}
