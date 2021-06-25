using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private bool _showData = false;
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
            var window = MessageBox.Show("Are you sure you want to leave?", "COVID-19: ",
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

            var mappedDS = new List<CitizenVm>();

            newDS.ForEach(e => mappedDS.Add(ProjectContextMapper.MapCitizenToCitizenVm(e)));

            dgvData.DataSource = mappedDS;

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment feAppointment = new();
            feAppointment.ShowDialog();
        }

        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            //1. Nullificar

            dgvData.DataSource = null;

                if (!_showData)
                {
                    // Cargando usuarios (dgv por defecto)
                    using (var context = new VaccinationContext())
                    {
                        var newDS = context.Citizens.ToList();

                        var mappedDS = new List<CitizenVm>();

                        newDS.ForEach(e => mappedDS.Add(ProjectContextMapper.MapCitizenToCitizenVm(e)));

                        dgvData.DataSource = mappedDS;
                    }
                }
                else
                {
                    using (var context = new VaccinationContext())
                    {
                        var newDS = context.Appointments.ToList();

                        var mappedDS = new List<AppointmentVm>();

                        newDS.ForEach(a => mappedDS.Add(ProjectContextMapper.MapAppointmentToAppointmentVm(a)));

                        dgvData.DataSource = mappedDS;
                    }
                }

                _showData = !_showData;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            
                //Exporting citizen information to PDF

                if (dgvData.Rows.Count > 0)

                {

                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "Result.pdf";

                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)

                    {

                        if (File.Exists(save.FileName))

                        {

                            try

                            {

                                File.Delete(save.FileName);

                            }

                            catch (Exception ex)

                            {

                                ErrorMessage = true;

                                MessageBox.Show("Unable to wride data in disk" + ex.Message);

                            }

                        }

                        if (!ErrorMessage)

                        {

                            try

                            {

                                PdfPTable pTable = new PdfPTable(dgvData.Columns.Count);

                                pTable.DefaultCell.Padding = 2;

                                pTable.WidthPercentage = 100;

                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in dgvData.Columns)

                                {

                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                    pTable.AddCell(pCell);

                                }

                                foreach (DataGridViewRow viewRow in dgvData.Rows)

                                {

                                    foreach (DataGridViewCell dcell in viewRow.Cells)

                                    {

                                        pTable.AddCell(dcell.Value.ToString());

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

                                    document.Add(pTable);

                                    document.Close();

                                    fileStream.Close();

                                }

                                MessageBox.Show("Data Export Successfully", "info");

                            }

                            catch (Exception ex)

                            {

                                MessageBox.Show("Error while exporting Data" + ex.Message);

                            }

                        }

                    }

                }

                else

                {

                    MessageBox.Show("No Record Found", "Info");

                }

            
            
        }
    }
}
