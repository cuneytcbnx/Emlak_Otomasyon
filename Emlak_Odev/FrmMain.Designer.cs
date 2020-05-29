namespace EmlakWinForm
{
    partial class FrmMain
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
            EmlakWinForm.Model.Emlakci emlakci1 = new EmlakWinForm.Model.Emlakci();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxButtonlar = new System.Windows.Forms.GroupBox();
            this.labelArama = new System.Windows.Forms.Label();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.groupBoxDataTable = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelVeriEkleDuzen = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGenel = new System.Windows.Forms.GroupBox();
            this.panelGayrimenkul = new System.Windows.Forms.Panel();
            this.comboBoxGayrimenkulTuru = new System.Windows.Forms.ComboBox();
            this.labelGayrimenkulTuru = new System.Windows.Forms.Label();
            this.groupBoxSatisTuru = new System.Windows.Forms.GroupBox();
            this.emlakciPanel = new EmlakWinForm.View.Emlakci();
            this.panelSatisTuru = new System.Windows.Forms.Panel();
            this.comboBoxSatisTuru = new System.Windows.Forms.ComboBox();
            this.labelSatisTuru = new System.Windows.Forms.Label();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxButtonlar.SuspendLayout();
            this.groupBoxDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.tableLayoutPanelVeriEkleDuzen.SuspendLayout();
            this.groupBoxGenel.SuspendLayout();
            this.groupBoxSatisTuru.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.groupBoxButtonlar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxDataTable, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBoxEdit, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // groupBoxButtonlar
            // 
            this.groupBoxButtonlar.Controls.Add(this.labelArama);
            this.groupBoxButtonlar.Controls.Add(this.textBoxArama);
            this.groupBoxButtonlar.Controls.Add(this.buttonSil);
            this.groupBoxButtonlar.Controls.Add(this.buttonYeni);
            this.groupBoxButtonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtonlar.Location = new System.Drawing.Point(3, 3);
            this.groupBoxButtonlar.Name = "groupBoxButtonlar";
            this.groupBoxButtonlar.Size = new System.Drawing.Size(618, 39);
            this.groupBoxButtonlar.TabIndex = 0;
            this.groupBoxButtonlar.TabStop = false;
            // 
            // labelArama
            // 
            this.labelArama.AutoSize = true;
            this.labelArama.Location = new System.Drawing.Point(372, 15);
            this.labelArama.Name = "labelArama";
            this.labelArama.Size = new System.Drawing.Size(32, 13);
            this.labelArama.TabIndex = 4;
            this.labelArama.Text = "Ara : ";
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(413, 11);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(196, 20);
            this.textBoxArama.TabIndex = 3;
            this.textBoxArama.TextChanged += new System.EventHandler(this.textBoxArama_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(88, 10);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(7, 10);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(75, 23);
            this.buttonYeni.TabIndex = 0;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // groupBoxDataTable
            // 
            this.groupBoxDataTable.Controls.Add(this.dataGridView);
            this.groupBoxDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataTable.Location = new System.Drawing.Point(3, 48);
            this.groupBoxDataTable.Name = "groupBoxDataTable";
            this.groupBoxDataTable.Size = new System.Drawing.Size(618, 192);
            this.groupBoxDataTable.TabIndex = 1;
            this.groupBoxDataTable.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(612, 173);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.tableLayoutPanelVeriEkleDuzen);
            this.groupBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEdit.Enabled = false;
            this.groupBoxEdit.Location = new System.Drawing.Point(3, 246);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(618, 192);
            this.groupBoxEdit.TabIndex = 2;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Veri Ekle/Düzenle";
            // 
            // tableLayoutPanelVeriEkleDuzen
            // 
            this.tableLayoutPanelVeriEkleDuzen.ColumnCount = 2;
            this.tableLayoutPanelVeriEkleDuzen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeriEkleDuzen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeriEkleDuzen.Controls.Add(this.groupBoxGenel, 0, 0);
            this.tableLayoutPanelVeriEkleDuzen.Controls.Add(this.groupBoxSatisTuru, 1, 0);
            this.tableLayoutPanelVeriEkleDuzen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVeriEkleDuzen.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelVeriEkleDuzen.Name = "tableLayoutPanelVeriEkleDuzen";
            this.tableLayoutPanelVeriEkleDuzen.RowCount = 1;
            this.tableLayoutPanelVeriEkleDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeriEkleDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVeriEkleDuzen.Size = new System.Drawing.Size(612, 173);
            this.tableLayoutPanelVeriEkleDuzen.TabIndex = 0;
            // 
            // groupBoxGenel
            // 
            this.groupBoxGenel.Controls.Add(this.panelGayrimenkul);
            this.groupBoxGenel.Controls.Add(this.comboBoxGayrimenkulTuru);
            this.groupBoxGenel.Controls.Add(this.labelGayrimenkulTuru);
            this.groupBoxGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGenel.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGenel.Name = "groupBoxGenel";
            this.groupBoxGenel.Size = new System.Drawing.Size(300, 167);
            this.groupBoxGenel.TabIndex = 0;
            this.groupBoxGenel.TabStop = false;
            this.groupBoxGenel.Text = "Genel Özellikleri";
            // 
            // panelGayrimenkul
            // 
            this.panelGayrimenkul.Location = new System.Drawing.Point(7, 44);
            this.panelGayrimenkul.Name = "panelGayrimenkul";
            this.panelGayrimenkul.Size = new System.Drawing.Size(287, 117);
            this.panelGayrimenkul.TabIndex = 2;
            // 
            // comboBoxGayrimenkulTuru
            // 
            this.comboBoxGayrimenkulTuru.FormattingEnabled = true;
            this.comboBoxGayrimenkulTuru.Items.AddRange(new object[] {
            "",
            "Arsa",
            "Daire",
            "Konut",
            "Apartman"});
            this.comboBoxGayrimenkulTuru.Location = new System.Drawing.Point(109, 17);
            this.comboBoxGayrimenkulTuru.Name = "comboBoxGayrimenkulTuru";
            this.comboBoxGayrimenkulTuru.Size = new System.Drawing.Size(185, 21);
            this.comboBoxGayrimenkulTuru.TabIndex = 1;
            this.comboBoxGayrimenkulTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxGayrimenkulTuru_SelectedIndexChanged);
            // 
            // labelGayrimenkulTuru
            // 
            this.labelGayrimenkulTuru.AutoSize = true;
            this.labelGayrimenkulTuru.Location = new System.Drawing.Point(7, 20);
            this.labelGayrimenkulTuru.Name = "labelGayrimenkulTuru";
            this.labelGayrimenkulTuru.Size = new System.Drawing.Size(96, 13);
            this.labelGayrimenkulTuru.TabIndex = 0;
            this.labelGayrimenkulTuru.Text = "Gayrimenkül Türü :";
            // 
            // groupBoxSatisTuru
            // 
            this.groupBoxSatisTuru.Controls.Add(this.emlakciPanel);
            this.groupBoxSatisTuru.Controls.Add(this.panelSatisTuru);
            this.groupBoxSatisTuru.Controls.Add(this.comboBoxSatisTuru);
            this.groupBoxSatisTuru.Controls.Add(this.labelSatisTuru);
            this.groupBoxSatisTuru.Controls.Add(this.buttonIptal);
            this.groupBoxSatisTuru.Controls.Add(this.buttonKaydet);
            this.groupBoxSatisTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSatisTuru.Location = new System.Drawing.Point(309, 3);
            this.groupBoxSatisTuru.Name = "groupBoxSatisTuru";
            this.groupBoxSatisTuru.Size = new System.Drawing.Size(300, 167);
            this.groupBoxSatisTuru.TabIndex = 1;
            this.groupBoxSatisTuru.TabStop = false;
            this.groupBoxSatisTuru.Text = "Satış Türü";
            // 
            // emlakciPanel
            // 
            this.emlakciPanel.Location = new System.Drawing.Point(7, 86);
            this.emlakciPanel.Name = "emlakciPanel";
            this.emlakciPanel.Size = new System.Drawing.Size(286, 46);
            this.emlakciPanel.TabIndex = 5;
            emlakci1.Adi = null;
            emlakci1.Soyadi = null;
            emlakci1.Telefon = null;
            this.emlakciPanel.Veri = emlakci1;
            // 
            // panelSatisTuru
            // 
            this.panelSatisTuru.Location = new System.Drawing.Point(7, 44);
            this.panelSatisTuru.Name = "panelSatisTuru";
            this.panelSatisTuru.Size = new System.Drawing.Size(287, 35);
            this.panelSatisTuru.TabIndex = 4;
            // 
            // comboBoxSatisTuru
            // 
            this.comboBoxSatisTuru.FormattingEnabled = true;
            this.comboBoxSatisTuru.Items.AddRange(new object[] {
            "",
            "Satılık",
            "Kiralık"});
            this.comboBoxSatisTuru.Location = new System.Drawing.Point(76, 17);
            this.comboBoxSatisTuru.Name = "comboBoxSatisTuru";
            this.comboBoxSatisTuru.Size = new System.Drawing.Size(217, 21);
            this.comboBoxSatisTuru.TabIndex = 3;
            this.comboBoxSatisTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxSatisTuru_SelectedIndexChanged);
            // 
            // labelSatisTuru
            // 
            this.labelSatisTuru.AutoSize = true;
            this.labelSatisTuru.Location = new System.Drawing.Point(6, 20);
            this.labelSatisTuru.Name = "labelSatisTuru";
            this.labelSatisTuru.Size = new System.Drawing.Size(64, 13);
            this.labelSatisTuru.TabIndex = 2;
            this.labelSatisTuru.Text = "Satış Türü : ";
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(222, 138);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 1;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(141, 138);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 0;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Emlak V1.0";
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBoxButtonlar.ResumeLayout(false);
            this.groupBoxButtonlar.PerformLayout();
            this.groupBoxDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.tableLayoutPanelVeriEkleDuzen.ResumeLayout(false);
            this.groupBoxGenel.ResumeLayout(false);
            this.groupBoxGenel.PerformLayout();
            this.groupBoxSatisTuru.ResumeLayout(false);
            this.groupBoxSatisTuru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBoxButtonlar;
        private System.Windows.Forms.GroupBox groupBoxDataTable;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Label labelArama;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVeriEkleDuzen;
        private System.Windows.Forms.GroupBox groupBoxGenel;
        private System.Windows.Forms.GroupBox groupBoxSatisTuru;
        private System.Windows.Forms.ComboBox comboBoxGayrimenkulTuru;
        private System.Windows.Forms.Label labelGayrimenkulTuru;
        private System.Windows.Forms.Panel panelGayrimenkul;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ComboBox comboBoxSatisTuru;
        private System.Windows.Forms.Label labelSatisTuru;
        private System.Windows.Forms.Panel panelSatisTuru;
        private View.Emlakci emlakciPanel;
    }
}