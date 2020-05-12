namespace EmlakWinForm.View
{
    partial class Daire
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
            this.labelSalonAdeti = new System.Windows.Forms.Label();
            this.labelOdaAdeti = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSalonAdeti = new System.Windows.Forms.TextBox();
            this.textBoxOdaAdeti = new System.Windows.Forms.TextBox();
            this.textBoxBalkonAdeti = new System.Windows.Forms.TextBox();
            this.checkBoxTuvaletVarmi = new System.Windows.Forms.CheckBox();
            this.checkBoxBanyoVarMi = new System.Windows.Forms.CheckBox();
            this.textBoxMetrekare = new System.Windows.Forms.TextBox();
            this.labelMetrekare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSalonAdeti
            // 
            this.labelSalonAdeti.AutoSize = true;
            this.labelSalonAdeti.Location = new System.Drawing.Point(10, 29);
            this.labelSalonAdeti.Name = "labelSalonAdeti";
            this.labelSalonAdeti.Size = new System.Drawing.Size(64, 13);
            this.labelSalonAdeti.TabIndex = 0;
            this.labelSalonAdeti.Text = "Salon Adeti:";
            // 
            // labelOdaAdeti
            // 
            this.labelOdaAdeti.AutoSize = true;
            this.labelOdaAdeti.Location = new System.Drawing.Point(17, 52);
            this.labelOdaAdeti.Name = "labelOdaAdeti";
            this.labelOdaAdeti.Size = new System.Drawing.Size(57, 13);
            this.labelOdaAdeti.TabIndex = 1;
            this.labelOdaAdeti.Text = "Oda Adeti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balkon Adeti:";
            // 
            // textBoxSalonAdeti
            // 
            this.textBoxSalonAdeti.Location = new System.Drawing.Point(80, 26);
            this.textBoxSalonAdeti.Name = "textBoxSalonAdeti";
            this.textBoxSalonAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxSalonAdeti.TabIndex = 3;
            this.textBoxSalonAdeti.TextChanged += new System.EventHandler(this.textBoxSalonAdeti_TextChanged);
            // 
            // textBoxOdaAdeti
            // 
            this.textBoxOdaAdeti.Location = new System.Drawing.Point(80, 49);
            this.textBoxOdaAdeti.Name = "textBoxOdaAdeti";
            this.textBoxOdaAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxOdaAdeti.TabIndex = 4;
            this.textBoxOdaAdeti.TextChanged += new System.EventHandler(this.textBoxOdaAdeti_TextChanged);
            // 
            // textBoxBalkonAdeti
            // 
            this.textBoxBalkonAdeti.Location = new System.Drawing.Point(80, 71);
            this.textBoxBalkonAdeti.Name = "textBoxBalkonAdeti";
            this.textBoxBalkonAdeti.Size = new System.Drawing.Size(197, 20);
            this.textBoxBalkonAdeti.TabIndex = 5;
            this.textBoxBalkonAdeti.TextChanged += new System.EventHandler(this.textBoxBalkonAdeti_TextChanged);
            // 
            // checkBoxTuvaletVarmi
            // 
            this.checkBoxTuvaletVarmi.AutoSize = true;
            this.checkBoxTuvaletVarmi.Location = new System.Drawing.Point(79, 97);
            this.checkBoxTuvaletVarmi.Name = "checkBoxTuvaletVarmi";
            this.checkBoxTuvaletVarmi.Size = new System.Drawing.Size(99, 17);
            this.checkBoxTuvaletVarmi.TabIndex = 6;
            this.checkBoxTuvaletVarmi.Text = "Tuvalet var mı?";
            this.checkBoxTuvaletVarmi.UseVisualStyleBackColor = true;
            this.checkBoxTuvaletVarmi.CheckedChanged += new System.EventHandler(this.checkBoxTuvaletVarmi_CheckedChanged);
            // 
            // checkBoxBanyoVarMi
            // 
            this.checkBoxBanyoVarMi.AutoSize = true;
            this.checkBoxBanyoVarMi.Location = new System.Drawing.Point(184, 97);
            this.checkBoxBanyoVarMi.Name = "checkBoxBanyoVarMi";
            this.checkBoxBanyoVarMi.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBanyoVarMi.TabIndex = 7;
            this.checkBoxBanyoVarMi.Text = "Banyo var mı?";
            this.checkBoxBanyoVarMi.UseVisualStyleBackColor = true;
            this.checkBoxBanyoVarMi.CheckedChanged += new System.EventHandler(this.checkBoxBanyoVarMi_CheckedChanged);
            // 
            // textBoxMetrekare
            // 
            this.textBoxMetrekare.Location = new System.Drawing.Point(79, 3);
            this.textBoxMetrekare.Name = "textBoxMetrekare";
            this.textBoxMetrekare.Size = new System.Drawing.Size(197, 20);
            this.textBoxMetrekare.TabIndex = 25;
            this.textBoxMetrekare.TextChanged += new System.EventHandler(this.textBoxMetrekare_TextChanged);
            // 
            // labelMetrekare
            // 
            this.labelMetrekare.AutoSize = true;
            this.labelMetrekare.Location = new System.Drawing.Point(15, 6);
            this.labelMetrekare.Name = "labelMetrekare";
            this.labelMetrekare.Size = new System.Drawing.Size(58, 13);
            this.labelMetrekare.TabIndex = 24;
            this.labelMetrekare.Text = "Metrekare:";
            // 
            // Daire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMetrekare);
            this.Controls.Add(this.labelMetrekare);
            this.Controls.Add(this.checkBoxBanyoVarMi);
            this.Controls.Add(this.checkBoxTuvaletVarmi);
            this.Controls.Add(this.textBoxBalkonAdeti);
            this.Controls.Add(this.textBoxOdaAdeti);
            this.Controls.Add(this.textBoxSalonAdeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOdaAdeti);
            this.Controls.Add(this.labelSalonAdeti);
            this.Name = "Daire";
            this.Size = new System.Drawing.Size(280, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalonAdeti;
        private System.Windows.Forms.Label labelOdaAdeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSalonAdeti;
        private System.Windows.Forms.TextBox textBoxOdaAdeti;
        private System.Windows.Forms.TextBox textBoxBalkonAdeti;
        private System.Windows.Forms.CheckBox checkBoxTuvaletVarmi;
        private System.Windows.Forms.CheckBox checkBoxBanyoVarMi;
        private System.Windows.Forms.TextBox textBoxMetrekare;
        private System.Windows.Forms.Label labelMetrekare;
    }
}
