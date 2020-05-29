namespace EmlakWinForm.View
{
    partial class Emlakci
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAdi = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(25, 7);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(25, 13);
            this.labelAdi.TabIndex = 0;
            this.labelAdi.Text = "Adı:";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(56, 4);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(92, 20);
            this.textBoxAdi.TabIndex = 1;
            this.textBoxAdi.TextChanged += new System.EventHandler(this.textBoxAdi_TextChanged);
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Location = new System.Drawing.Point(8, 29);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(42, 13);
            this.labelSoyadi.TabIndex = 2;
            this.labelSoyadi.Text = "Soyadi:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(154, 7);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(56, 26);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(92, 20);
            this.textBoxSoyadi.TabIndex = 4;
            this.textBoxSoyadi.TextChanged += new System.EventHandler(this.textBoxSoyadi_TextChanged);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(157, 25);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(127, 20);
            this.textBoxTelefon.TabIndex = 5;
            this.textBoxTelefon.TextChanged += new System.EventHandler(this.textBoxTelefon_TextChanged);
            // 
            // Emlakci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelSoyadi);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.labelAdi);
            this.Name = "Emlakci";
            this.Size = new System.Drawing.Size(287, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxTelefon;
    }
}
