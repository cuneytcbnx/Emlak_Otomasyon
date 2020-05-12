using EmlakWinForm.Model.Base;
using EmlakWinForm.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakWinForm
{
    public partial class FrmMain : Form
    {
        public List<Gayrimenkul> Gayrimenkuller { get; set; }

        public Gayrimenkul SecilenGayrimenkul { get; set; }

        public FrmMain()
        {
            Gayrimenkuller = new List<Gayrimenkul>();
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Türü", DataPropertyName = "GayrimenkulTuru" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Metrekare", DataPropertyName = "Metrekare" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Salon Adeti", DataPropertyName = "SalonAdeti" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Oda Adeti", DataPropertyName = "OdaAdeti" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Balkon Adeti", DataPropertyName = "BalkonAdeti" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Kat Adeti", DataPropertyName = "KatAdeti" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Daire Adeti", DataPropertyName = "DaireAdeti" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Tuvalet", DataPropertyName = "TuvaletVarMi" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Banyo", DataPropertyName = "BanyoVarMi" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Emlakçı", DataPropertyName = "Emlakci" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Satış Türü", DataPropertyName = "SatisTuru" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Maliyet", DataPropertyName = "Ucret" });
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Enabled = true;
            groupBoxButtonlar.Enabled = false;
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Enabled = true;
            groupBoxButtonlar.Enabled = false;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (SecilenGayrimenkul != null)
            {
                Gayrimenkuller.Remove(SecilenGayrimenkul);
                SecilenGayrimenkul = null;
                dataGridView.DataSource = Gayrimenkuller.CreateDataTable();
                dataGridView.Update();
                dataGridView.Refresh();
            }
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxArama.Text))
            {
                dataGridView.DataSource = Gayrimenkuller.Where(t =>
                    t.GayrimenkulTuru.ToUpper().Contains(textBoxArama.Text.ToUpper()) || 
                    t.SatisTuru.ToString().ToUpper().Contains(textBoxArama.Text.ToUpper())).ToList().CreateDataTable();
                dataGridView.Update();
                dataGridView.Refresh();
            }
            else
            {
                dataGridView.DataSource = Gayrimenkuller.CreateDataTable();
                dataGridView.Update();
                dataGridView.Refresh();
            }
        }

        private void comboBoxGayrimenkulTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secim = comboBoxGayrimenkulTuru.Items[comboBoxGayrimenkulTuru.SelectedIndex].ToString();
            switch (secim)
            {
                case "":
                    panelGayrimenkul.Controls.Clear();
                    break;
                case "Arsa":
                    panelGayrimenkul.Controls.Clear();
                    panelGayrimenkul.Controls.Add(new View.Arsa());
                    break;
                case "Daire":
                    panelGayrimenkul.Controls.Clear();
                    panelGayrimenkul.Controls.Add(new View.Daire());
                    break;
                case "Konut":
                    panelGayrimenkul.Controls.Clear();
                    panelGayrimenkul.Controls.Add(new View.Konut());
                    break;
                case "Apartman":
                    panelGayrimenkul.Controls.Clear();
                    panelGayrimenkul.Controls.Add(new View.Apartman());
                    break;
            }
        }

        private void comboBoxSatisTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secim = comboBoxSatisTuru.Items[comboBoxSatisTuru.SelectedIndex].ToString();
            switch (secim)
            {
                case "":
                    panelSatisTuru.Controls.Clear();
                    break;
                case "Kiralık":
                    panelSatisTuru.Controls.Clear();
                    panelSatisTuru.Controls.Add(new View.Kiralik());
                    break;
                case "Satılık":
                    panelSatisTuru.Controls.Clear();
                    panelSatisTuru.Controls.Add(new View.Satilik());
                    break;
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Gayrimenkul gayrimenkul = null;
            var secimGayrimenkul = comboBoxGayrimenkulTuru.Items[comboBoxGayrimenkulTuru.SelectedIndex].ToString();
            switch (secimGayrimenkul)
            {
                case "Arsa":
                    gayrimenkul = panelGayrimenkul.Controls.OfType<View.Arsa>().First().Veri;
                    break;
                case "Daire":
                    gayrimenkul = panelGayrimenkul.Controls.OfType<View.Daire>().First().Veri;
                    break;
                case "Konut":
                    gayrimenkul = panelGayrimenkul.Controls.OfType<View.Konut>().First().Veri;
                    break;
                case "Apartman":
                    gayrimenkul = panelGayrimenkul.Controls.OfType<View.Apartman>().First().Veri;

                    break;
            }


            var secimSatisTuru = comboBoxSatisTuru.Items[comboBoxSatisTuru.SelectedIndex].ToString();
            switch (secimSatisTuru)
            {
                case "Kiralık":
                    gayrimenkul.SatisTuru = panelSatisTuru.Controls.OfType<View.Kiralik>().First().Veri;
                    break;
                case "Satılık":
                    gayrimenkul.SatisTuru = panelSatisTuru.Controls.OfType<View.Satilik>().First().Veri;
                    break;
            }
            gayrimenkul.Emlakci = emlakciPanel.Veri;

            Gayrimenkuller.Add(gayrimenkul);
            dataGridView.DataSource = Gayrimenkuller.CreateDataTable();
            dataGridView.Update();
            dataGridView.Refresh();

            Temizle();

            groupBoxEdit.Enabled = false;
            groupBoxButtonlar.Enabled = true;
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            Temizle();
            groupBoxEdit.Enabled = false;
            groupBoxButtonlar.Enabled = true;
        }

        private void Temizle()
        {
            emlakciPanel.Temizle();
            comboBoxGayrimenkulTuru.SelectedIndex = 0;
            panelGayrimenkul.Controls.Clear();
            comboBoxSatisTuru.SelectedIndex = 0;
            comboBoxSatisTuru.Controls.Clear();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                SecilenGayrimenkul = Gayrimenkuller[dataGridView.SelectedRows[0].Index];
            }
            else
            {
                SecilenGayrimenkul = null;
            }
        }
    }
}
