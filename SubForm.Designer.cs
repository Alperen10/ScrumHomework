
namespace Odev
{
    partial class SubForm
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
            this.btnSatim = new System.Windows.Forms.Button();
            this.btnAlimSatim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSatim
            // 
            this.btnSatim.BackColor = System.Drawing.Color.LightGreen;
            this.btnSatim.Location = new System.Drawing.Point(56, 96);
            this.btnSatim.Name = "btnSatim";
            this.btnSatim.Size = new System.Drawing.Size(155, 85);
            this.btnSatim.TabIndex = 20;
            this.btnSatim.Text = "Satıcı İşlemi";
            this.btnSatim.UseVisualStyleBackColor = false;
            this.btnSatim.Click += new System.EventHandler(this.btnSatim_Click);
            // 
            // btnAlimSatim
            // 
            this.btnAlimSatim.BackColor = System.Drawing.Color.LightGreen;
            this.btnAlimSatim.Location = new System.Drawing.Point(259, 96);
            this.btnAlimSatim.Name = "btnAlimSatim";
            this.btnAlimSatim.Size = new System.Drawing.Size(154, 85);
            this.btnAlimSatim.TabIndex = 19;
            this.btnAlimSatim.Text = "Alıcı İşlemi";
            this.btnAlimSatim.UseVisualStyleBackColor = false;
            this.btnAlimSatim.Click += new System.EventHandler(this.btnAlimSatim_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.btnSatim);
            this.Controls.Add(this.btnAlimSatim);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSatim;
        private System.Windows.Forms.Button btnAlimSatim;
    }
}