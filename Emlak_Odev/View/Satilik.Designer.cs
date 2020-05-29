namespace EmlakWinForm.View
{
    partial class Satilik
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
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.labelUcret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Location = new System.Drawing.Point(45, 5);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(93, 20);
            this.textBoxUcret.TabIndex = 3;
            this.textBoxUcret.TextChanged += new System.EventHandler(this.textBoxUcret_TextChanged);
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Location = new System.Drawing.Point(3, 8);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(36, 13);
            this.labelUcret.TabIndex = 2;
            this.labelUcret.Text = "Ücret:";
            // 
            // Satilik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxUcret);
            this.Controls.Add(this.labelUcret);
            this.Name = "Satilik";
            this.Size = new System.Drawing.Size(280, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.Label labelUcret;
    }
}
