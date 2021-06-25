
namespace VaccineForm.View
{
    partial class frmAppointment
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
            this.tabAppointment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCabin = new System.Windows.Forms.Label();
            this.cmbCabin = new System.Windows.Forms.ComboBox();
            this.btnVaccinate = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.tabPAppointment = new System.Windows.Forms.TabPage();
            this.cmbSideEffects = new System.Windows.Forms.ComboBox();
            this.btnAddApoint = new System.Windows.Forms.Button();
            this.lblProx = new System.Windows.Forms.Label();
            this.lblEffects = new System.Windows.Forms.Label();
            this.tabAppointment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAppointment
            // 
            this.tabAppointment.Controls.Add(this.tabPage1);
            this.tabAppointment.Controls.Add(this.tabPAppointment);
            this.tabAppointment.Location = new System.Drawing.Point(-3, -38);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.SelectedIndex = 0;
            this.tabAppointment.Size = new System.Drawing.Size(479, 343);
            this.tabAppointment.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCabin);
            this.tabPage1.Controls.Add(this.cmbCabin);
            this.tabPage1.Controls.Add(this.btnVaccinate);
            this.tabPage1.Controls.Add(this.txtDUI);
            this.tabPage1.Controls.Add(this.lblDUI);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vaccination";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCabin
            // 
            this.lblCabin.AutoSize = true;
            this.lblCabin.Location = new System.Drawing.Point(37, 123);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(95, 42);
            this.lblCabin.TabIndex = 4;
            this.lblCabin.Text = "Select the \r\ncabin:";
            // 
            // cmbCabin
            // 
            this.cmbCabin.FormattingEnabled = true;
            this.cmbCabin.Location = new System.Drawing.Point(152, 123);
            this.cmbCabin.Name = "cmbCabin";
            this.cmbCabin.Size = new System.Drawing.Size(280, 29);
            this.cmbCabin.TabIndex = 3;
            // 
            // btnVaccinate
            // 
            this.btnVaccinate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnVaccinate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaccinate.Location = new System.Drawing.Point(130, 201);
            this.btnVaccinate.Name = "btnVaccinate";
            this.btnVaccinate.Size = new System.Drawing.Size(211, 77);
            this.btnVaccinate.TabIndex = 2;
            this.btnVaccinate.Text = "Vaccinate";
            this.btnVaccinate.UseVisualStyleBackColor = false;
            this.btnVaccinate.Click += new System.EventHandler(this.btnVaccinate_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(152, 55);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(280, 28);
            this.txtDUI.TabIndex = 1;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(39, 58);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(93, 21);
            this.lblDUI.TabIndex = 0;
            this.lblDUI.Text = "Enter DUI:";
            // 
            // tabPAppointment
            // 
            this.tabPAppointment.Controls.Add(this.cmbSideEffects);
            this.tabPAppointment.Controls.Add(this.btnAddApoint);
            this.tabPAppointment.Controls.Add(this.lblProx);
            this.tabPAppointment.Controls.Add(this.lblEffects);
            this.tabPAppointment.Location = new System.Drawing.Point(4, 30);
            this.tabPAppointment.Name = "tabPAppointment";
            this.tabPAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAppointment.Size = new System.Drawing.Size(471, 309);
            this.tabPAppointment.TabIndex = 1;
            this.tabPAppointment.Text = "Appointment";
            this.tabPAppointment.UseVisualStyleBackColor = true;
            // 
            // cmbSideEffects
            // 
            this.cmbSideEffects.FormattingEnabled = true;
            this.cmbSideEffects.Location = new System.Drawing.Point(178, 103);
            this.cmbSideEffects.Name = "cmbSideEffects";
            this.cmbSideEffects.Size = new System.Drawing.Size(266, 29);
            this.cmbSideEffects.TabIndex = 6;
            // 
            // btnAddApoint
            // 
            this.btnAddApoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnAddApoint.Location = new System.Drawing.Point(122, 179);
            this.btnAddApoint.Name = "btnAddApoint";
            this.btnAddApoint.Size = new System.Drawing.Size(227, 85);
            this.btnAddApoint.TabIndex = 5;
            this.btnAddApoint.Text = "Add Apointment";
            this.btnAddApoint.UseVisualStyleBackColor = false;
            this.btnAddApoint.Click += new System.EventHandler(this.btnAddApoint_Click);
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.Location = new System.Drawing.Point(200, 211);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(0, 21);
            this.lblProx.TabIndex = 3;
            // 
            // lblEffects
            // 
            this.lblEffects.AutoSize = true;
            this.lblEffects.Location = new System.Drawing.Point(11, 106);
            this.lblEffects.Name = "lblEffects";
            this.lblEffects.Size = new System.Drawing.Size(161, 21);
            this.lblEffects.TabIndex = 0;
            this.lblEffects.Text = "Select side effects:";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 299);
            this.Controls.Add(this.tabAppointment);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmAppointment";
            this.Text = "COVID19: Appointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.tabAppointment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPAppointment.ResumeLayout(false);
            this.tabPAppointment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAppointment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPAppointment;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnVaccinate;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.ComboBox cmbCabin;
        private System.Windows.Forms.Label lblEffects;
        private System.Windows.Forms.Label lblProx;
        private System.Windows.Forms.Button btnAddApoint;
        private System.Windows.Forms.ComboBox cmbSideEffects;
    }
}