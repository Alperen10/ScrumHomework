
namespace Odev
{
    partial class Form1
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.txtUserTcNumber = new System.Windows.Forms.TextBox();
            this.lblUserSurname = new System.Windows.Forms.Label();
            this.lblUserTcNumber = new System.Windows.Forms.Label();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(37, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(191, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(112, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(191, 95);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(112, 22);
            this.txtUserSurname.TabIndex = 4;
            // 
            // txtUserTcNumber
            // 
            this.txtUserTcNumber.Location = new System.Drawing.Point(191, 161);
            this.txtUserTcNumber.Name = "txtUserTcNumber";
            this.txtUserTcNumber.Size = new System.Drawing.Size(112, 22);
            this.txtUserTcNumber.TabIndex = 5;
            // 
            // lblUserSurname
            // 
            this.lblUserSurname.AutoSize = true;
            this.lblUserSurname.Location = new System.Drawing.Point(37, 98);
            this.lblUserSurname.Name = "lblUserSurname";
            this.lblUserSurname.Size = new System.Drawing.Size(103, 17);
            this.lblUserSurname.TabIndex = 6;
            this.lblUserSurname.Text = "User Surname:";
            // 
            // lblUserTcNumber
            // 
            this.lblUserTcNumber.AutoSize = true;
            this.lblUserTcNumber.Location = new System.Drawing.Point(37, 164);
            this.lblUserTcNumber.Name = "lblUserTcNumber";
            this.lblUserTcNumber.Size = new System.Drawing.Size(118, 17);
            this.lblUserTcNumber.TabIndex = 7;
            this.lblUserTcNumber.Text = "User TC Number:";
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(406, 31);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(86, 17);
            this.lblTelNumber.TabIndex = 8;
            this.lblTelNumber.Text = "Tel Number:";
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(539, 28);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(112, 22);
            this.txtTelNumber.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(406, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(539, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(112, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(406, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(539, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(389, 224);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(112, 50);
            this.btnTamamla.TabIndex = 14;
            this.btnTamamla.Text = "Kaydı Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightGreen;
            this.btnGiris.Location = new System.Drawing.Point(238, 224);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(111, 50);
            this.btnGiris.TabIndex = 15;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(711, 295);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtTelNumber);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.lblUserTcNumber);
            this.Controls.Add(this.lblUserSurname);
            this.Controls.Add(this.txtUserTcNumber);
            this.Controls.Add(this.txtUserSurname);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.TextBox txtUserTcNumber;
        private System.Windows.Forms.Label lblUserSurname;
        private System.Windows.Forms.Label lblUserTcNumber;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnGiris;
    }
}

