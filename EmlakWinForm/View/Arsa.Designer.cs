namespace EmlakWinForm.View
{
    partial class Arsa
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
            this.labelMetrekare = new System.Windows.Forms.Label();
            this.textBoxMetrekare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMetrekare
            // 
            this.labelMetrekare.AutoSize = true;
            this.labelMetrekare.Location = new System.Drawing.Point(4, 9);
            this.labelMetrekare.Name = "labelMetrekare";
            this.labelMetrekare.Size = new System.Drawing.Size(64, 13);
            this.labelMetrekare.TabIndex = 0;
            this.labelMetrekare.Text = "Metrekare : ";
            // 
            // textBoxMetrekare
            // 
            this.textBoxMetrekare.Location = new System.Drawing.Point(70, 6);
            this.textBoxMetrekare.Name = "textBoxMetrekare";
            this.textBoxMetrekare.Size = new System.Drawing.Size(207, 20);
            this.textBoxMetrekare.TabIndex = 1;
            this.textBoxMetrekare.TextChanged += new System.EventHandler(this.textBoxMetrekare_TextChanged);
            // 
            // Arsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMetrekare);
            this.Controls.Add(this.labelMetrekare);
            this.Name = "Arsa";
            this.Size = new System.Drawing.Size(280, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMetrekare;
        private System.Windows.Forms.TextBox textBoxMetrekare;
    }
}
