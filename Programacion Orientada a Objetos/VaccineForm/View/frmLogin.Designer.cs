
namespace VaccineForm.View
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsesion = new System.Windows.Forms.Label();
            this.cmbCabin = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtManagerid = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.6087F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.69565F));
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picLock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picLog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblsesion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCabin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtManagerid, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUser.Location = new System.Drawing.Point(133, 175);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(354, 32);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "Username";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // picLock
            // 
            this.picLock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLock.Image = global::VaccineForm.Properties.Resources.lock_icon;
            this.picLock.Location = new System.Drawing.Point(4, 236);
            this.picLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(121, 71);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLock.TabIndex = 3;
            this.picLock.TabStop = false;
            // 
            // picLog
            // 
            this.picLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLog.Image = global::VaccineForm.Properties.Resources.login_icon;
            this.picLog.Location = new System.Drawing.Point(4, 153);
            this.picLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(121, 77);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLog.TabIndex = 2;
            this.picLog.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(133, 255);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 32);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(133, 376);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(354, 103);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccineForm.Properties.Resources.loginTitle;
            this.pictureBox1.Location = new System.Drawing.Point(133, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblsesion
            // 
            this.lblsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsesion.AutoSize = true;
            this.lblsesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsesion.Location = new System.Drawing.Point(494, 0);
            this.lblsesion.Name = "lblsesion";
            this.lblsesion.Size = new System.Drawing.Size(193, 150);
            this.lblsesion.TabIndex = 8;
            this.lblsesion.Text = "Cabin";
            this.lblsesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCabin
            // 
            this.cmbCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCabin.FormattingEnabled = true;
            this.cmbCabin.Location = new System.Drawing.Point(494, 153);
            this.cmbCabin.Name = "cmbCabin";
            this.cmbCabin.Size = new System.Drawing.Size(182, 33);
            this.cmbCabin.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(494, 233);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(193, 77);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Type your id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtManagerid
            // 
            this.txtManagerid.Location = new System.Drawing.Point(494, 313);
            this.txtManagerid.Multiline = true;
            this.txtManagerid.Name = "txtManagerid";
            this.txtManagerid.Size = new System.Drawing.Size(182, 46);
            this.txtManagerid.TabIndex = 11;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::VaccineForm.Properties.Resources.clinic_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | COVID-19";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblsesion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbCabin;
        private System.Windows.Forms.TextBox txtManagerid;
    }
}

