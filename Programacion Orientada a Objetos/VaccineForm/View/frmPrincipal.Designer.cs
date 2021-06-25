
namespace VaccineForm.View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnCreateCitizen = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnShowAppointments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateCitizen
            // 
            this.btnCreateCitizen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.btnCreateCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateCitizen.Location = new System.Drawing.Point(12, 137);
            this.btnCreateCitizen.Name = "btnCreateCitizen";
            this.btnCreateCitizen.Size = new System.Drawing.Size(207, 96);
            this.btnCreateCitizen.TabIndex = 0;
            this.btnCreateCitizen.Text = "Add citizen";
            this.btnCreateCitizen.UseVisualStyleBackColor = false;
            this.btnCreateCitizen.Click += new System.EventHandler(this.btnCreateCitizen_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(225, 137);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.Size = new System.Drawing.Size(852, 580);
            this.dgvData.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(115, 696);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(46, 17);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "label1";
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAppointment.Location = new System.Drawing.Point(12, 239);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(207, 96);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "Add appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnShowAppointments
            // 
            this.btnShowAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.btnShowAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAppointments.Location = new System.Drawing.Point(12, 341);
            this.btnShowAppointments.Name = "btnShowAppointments";
            this.btnShowAppointments.Size = new System.Drawing.Size(207, 96);
            this.btnShowAppointments.TabIndex = 4;
            this.btnShowAppointments.Text = "Change Info";
            this.btnShowAppointments.UseVisualStyleBackColor = false;
            this.btnShowAppointments.Click += new System.EventHandler(this.btnShowAppointments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login time:";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Pink;
            this.btnPdf.Location = new System.Drawing.Point(12, 443);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(207, 92);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "Export to PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1085, 729);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAppointments);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnCreateCitizen);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal | COVID-19";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCreateCitizen;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPdf;
    }
}