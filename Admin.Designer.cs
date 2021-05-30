
namespace Odev
{
    partial class Admin
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
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.cbxOnay = new System.Windows.Forms.ComboBox();
            this.lblOnay = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(310, 218);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(286, 46);
            this.btnTamamla.TabIndex = 13;
            this.btnTamamla.Text = "İşlemi Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(759, 34);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtFiyat.TabIndex = 12;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(473, 36);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(233, 17);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Satmak istediğiniz ürün fiyatını girin:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(310, 100);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 22);
            this.txtMiktar.TabIndex = 10;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(23, 103);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(155, 17);
            this.lblMiktar.TabIndex = 9;
            this.lblMiktar.Text = "Ürün miktarını girin(kg):";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(23, 39);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(209, 17);
            this.lblUrun.TabIndex = 8;
            this.lblUrun.Text = "Eklemek istediğiniz ürünü seçin:";
            // 
            // cbxUrun
            // 
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Items.AddRange(new object[] {
            "Buğday",
            "Arpa",
            "Yulaf",
            "Patates",
            "Pamuk"});
            this.cbxUrun.Location = new System.Drawing.Point(310, 36);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(121, 24);
            this.cbxUrun.TabIndex = 7;
            // 
            // cbxOnay
            // 
            this.cbxOnay.FormattingEnabled = true;
            this.cbxOnay.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxOnay.Location = new System.Drawing.Point(759, 166);
            this.cbxOnay.Name = "cbxOnay";
            this.cbxOnay.Size = new System.Drawing.Size(121, 24);
            this.cbxOnay.TabIndex = 14;
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Location = new System.Drawing.Point(473, 169);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(263, 17);
            this.lblOnay.TabIndex = 15;
            this.lblOnay.Text = "Ürünün eklenmesini onaylıyor musunuz?";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(23, 169);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(110, 17);
            this.lblUserId.TabIndex = 16;
            this.lblUserId.Text = "Kullanıcı id girin:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(310, 166);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(121, 22);
            this.txtUserId.TabIndex = 17;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(473, 103);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(84, 17);
            this.lblItemId.TabIndex = 18;
            this.lblItemId.Text = "Item id girin:";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(759, 100);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(121, 22);
            this.txtItemId.TabIndex = 19;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(892, 276);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.cbxOnay);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.cbxUrun);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.ComboBox cbxOnay;
        private System.Windows.Forms.Label lblOnay;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.TextBox txtItemId;
    }
}