
namespace Odev
{
    partial class Alici
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
            this.btnTamamla = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnTL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(32, 244);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(107, 45);
            this.btnTamamla.TabIndex = 13;
            this.btnTamamla.Text = "Dolar Yükle";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(209, 40);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(207, 22);
            this.txtFiyat.TabIndex = 12;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(26, 43);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(156, 17);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Toplam bakiyenizi girin:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(29, 99);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(110, 17);
            this.lblUserId.TabIndex = 14;
            this.lblUserId.Text = "Kullanıcı id girin:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(209, 93);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(207, 22);
            this.txtUserId.TabIndex = 15;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(29, 155);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(82, 17);
            this.lblTarih.TabIndex = 16;
            this.lblTarih.Text = "Tarih seçin:";
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.Color.LightGreen;
            this.btnEuro.Location = new System.Drawing.Point(171, 244);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(107, 45);
            this.btnEuro.TabIndex = 18;
            this.btnEuro.Text = "Euro Yükle";
            this.btnEuro.UseVisualStyleBackColor = false;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.BackColor = System.Drawing.Color.LightGreen;
            this.btnDolar.Location = new System.Drawing.Point(309, 244);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(107, 45);
            this.btnDolar.TabIndex = 19;
            this.btnDolar.Text = "Sterlin Yükle";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(209, 149);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(207, 22);
            this.dtpTarih.TabIndex = 17;
            // 
            // btnTL
            // 
            this.btnTL.BackColor = System.Drawing.Color.LightGreen;
            this.btnTL.Location = new System.Drawing.Point(171, 308);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(107, 45);
            this.btnTL.TabIndex = 20;
            this.btnTL.Text = "TL Yükle";
            this.btnTL.UseVisualStyleBackColor = false;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(457, 368);
            this.Controls.Add(this.btnTL);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Name = "Alici";
            this.Text = "Alici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnTL;
    }
}