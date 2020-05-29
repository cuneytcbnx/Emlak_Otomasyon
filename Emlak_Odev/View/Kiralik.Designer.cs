namespace EmlakWinForm.View
{
    partial class Kiralik
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
            this.labelUcret = new System.Windows.Forms.Label();
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.textBoxSure = new System.Windows.Forms.TextBox();
            this.labelSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Location = new System.Drawing.Point(4, 8);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(36, 13);
            this.labelUcret.TabIndex = 0;
            this.labelUcret.Text = "Ücret:";
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Location = new System.Drawing.Point(46, 5);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(93, 20);
            this.textBoxUcret.TabIndex = 1;
            this.textBoxUcret.TextChanged += new System.EventHandler(this.textBoxUcret_TextChanged);
            // 
            // textBoxSure
            // 
            this.textBoxSure.Location = new System.Drawing.Point(184, 5);
            this.textBoxSure.Name = "textBoxSure";
            this.textBoxSure.Size = new System.Drawing.Size(93, 20);
            this.textBoxSure.TabIndex = 3;
            this.textBoxSure.TextChanged += new System.EventHandler(this.textBoxSure_TextChanged);
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Location = new System.Drawing.Point(142, 8);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(32, 13);
            this.labelSure.TabIndex = 2;
            this.labelSure.Text = "Süre:";
            // 
            // Kiralik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSure);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.textBoxUcret);
            this.Controls.Add(this.labelUcret);
            this.Name = "Kiralik";
            this.Size = new System.Drawing.Size(280, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.TextBox textBoxSure;
        private System.Windows.Forms.Label labelSure;
    }
}
