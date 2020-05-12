namespace EmlakWinForm.View
{
    partial class Konut
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
            this.textBoxBalkonAdeti = new System.Windows.Forms.TextBox();
            this.textBoxOdaAdeti = new System.Windows.Forms.TextBox();
            this.textBoxSalonAdeti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOdaAdeti = new System.Windows.Forms.Label();
            this.labelSalonAdeti = new System.Windows.Forms.Label();
            this.textBoxKatAdeti = new System.Windows.Forms.TextBox();
            this.labelKatAdeti = new System.Windows.Forms.Label();
            this.textBoxMetrekare = new System.Windows.Forms.TextBox();
            this.labelMetrekare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBalkonAdeti
            // 
            this.textBoxBalkonAdeti.Location = new System.Drawing.Point(80, 75);
            this.textBoxBalkonAdeti.Name = "textBoxBalkonAdeti";
            this.textBoxBalkonAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxBalkonAdeti.TabIndex = 11;
            this.textBoxBalkonAdeti.TextChanged += new System.EventHandler(this.textBoxBalkonAdeti_TextChanged);
            // 
            // textBoxOdaAdeti
            // 
            this.textBoxOdaAdeti.Location = new System.Drawing.Point(80, 53);
            this.textBoxOdaAdeti.Name = "textBoxOdaAdeti";
            this.textBoxOdaAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxOdaAdeti.TabIndex = 10;
            this.textBoxOdaAdeti.TextChanged += new System.EventHandler(this.textBoxOdaAdeti_TextChanged);
            // 
            // textBoxSalonAdeti
            // 
            this.textBoxSalonAdeti.Location = new System.Drawing.Point(80, 30);
            this.textBoxSalonAdeti.Name = "textBoxSalonAdeti";
            this.textBoxSalonAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxSalonAdeti.TabIndex = 9;
            this.textBoxSalonAdeti.TextChanged += new System.EventHandler(this.textBoxSalonAdeti_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Balkon Adeti:";
            // 
            // labelOdaAdeti
            // 
            this.labelOdaAdeti.AutoSize = true;
            this.labelOdaAdeti.Location = new System.Drawing.Point(17, 56);
            this.labelOdaAdeti.Name = "labelOdaAdeti";
            this.labelOdaAdeti.Size = new System.Drawing.Size(57, 13);
            this.labelOdaAdeti.TabIndex = 7;
            this.labelOdaAdeti.Text = "Oda Adeti:";
            // 
            // labelSalonAdeti
            // 
            this.labelSalonAdeti.AutoSize = true;
            this.labelSalonAdeti.Location = new System.Drawing.Point(10, 33);
            this.labelSalonAdeti.Name = "labelSalonAdeti";
            this.labelSalonAdeti.Size = new System.Drawing.Size(64, 13);
            this.labelSalonAdeti.TabIndex = 6;
            this.labelSalonAdeti.Text = "Salon Adeti:";
            // 
            // textBoxKatAdeti
            // 
            this.textBoxKatAdeti.Location = new System.Drawing.Point(80, 97);
            this.textBoxKatAdeti.Name = "textBoxKatAdeti";
            this.textBoxKatAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxKatAdeti.TabIndex = 13;
            this.textBoxKatAdeti.TextChanged += new System.EventHandler(this.textBoxKatAdeti_TextChanged);
            // 
            // labelKatAdeti
            // 
            this.labelKatAdeti.AutoSize = true;
            this.labelKatAdeti.Location = new System.Drawing.Point(21, 100);
            this.labelKatAdeti.Name = "labelKatAdeti";
            this.labelKatAdeti.Size = new System.Drawing.Size(53, 13);
            this.labelKatAdeti.TabIndex = 12;
            this.labelKatAdeti.Text = "Kat Adeti:";
            // 
            // textBoxMetrekare
            // 
            this.textBoxMetrekare.Location = new System.Drawing.Point(80, 4);
            this.textBoxMetrekare.Name = "textBoxMetrekare";
            this.textBoxMetrekare.Size = new System.Drawing.Size(197, 20);
            this.textBoxMetrekare.TabIndex = 15;
            this.textBoxMetrekare.TextChanged += new System.EventHandler(this.textBoxMetrekare_TextChanged);
            // 
            // labelMetrekare
            // 
            this.labelMetrekare.AutoSize = true;
            this.labelMetrekare.Location = new System.Drawing.Point(14, 7);
            this.labelMetrekare.Name = "labelMetrekare";
            this.labelMetrekare.Size = new System.Drawing.Size(64, 13);
            this.labelMetrekare.TabIndex = 14;
            this.labelMetrekare.Text = "Metrekare : ";
            // 
            // Konut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMetrekare);
            this.Controls.Add(this.labelMetrekare);
            this.Controls.Add(this.textBoxKatAdeti);
            this.Controls.Add(this.labelKatAdeti);
            this.Controls.Add(this.textBoxBalkonAdeti);
            this.Controls.Add(this.textBoxOdaAdeti);
            this.Controls.Add(this.textBoxSalonAdeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOdaAdeti);
            this.Controls.Add(this.labelSalonAdeti);
            this.Name = "Konut";
            this.Size = new System.Drawing.Size(280, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBalkonAdeti;
        private System.Windows.Forms.TextBox textBoxOdaAdeti;
        private System.Windows.Forms.TextBox textBoxSalonAdeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOdaAdeti;
        private System.Windows.Forms.Label labelSalonAdeti;
        private System.Windows.Forms.TextBox textBoxKatAdeti;
        private System.Windows.Forms.Label labelKatAdeti;
        private System.Windows.Forms.TextBox textBoxMetrekare;
        private System.Windows.Forms.Label labelMetrekare;
    }
}
