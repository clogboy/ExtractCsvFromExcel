using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ExtractCsvFromExcel
{
    public partial class frmMaakFeature : Form
    {
        string m_fittingType;
        public string featureName;
        public string featureFilterText;
        int selectedFeature;

        public frmMaakFeature(string FittingType)
        {
            InitializeComponent();

            m_fittingType = FittingType;
            SetWorkspace();
        }

        void SetWorkspace()
        {
            lboOmschrijvingen.DrawMode = DrawMode.OwnerDrawFixed;
            lboOmschrijvingen.DrawItem += new DrawItemEventHandler(lboParameters_DrawItem);

            cmbFeatureNamen.Items.Clear();

            foreach (Feature feature in MetadataHandler.features.Where(f => f.fittingType == m_fittingType))
            {
                cmbFeatureNamen.Items.Add(feature.featureName);
            }

            tboFilterText.Clear();
            tboFilterText.Enabled = true;
            btnVerwijderFeature.Visible = false;
            btnVerwijderFeature.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTextBox();

            if(tboFeatureNaam.Text != null || tboFeatureNaam.Text == tboFilterText.Text)
            {
                tboFeatureNaam.Text = tboFilterText.Text;
            }

            tboFeatureNaam.Enabled = (tboFilterText.Text != null && tboFilterText.Text != "");
            tboFeatureNaam.Visible = (tboFilterText.Text != null && tboFilterText.Text != "");

            cmbFeatureNamen.Enabled = !tboFeatureNaam.Enabled;
            cmbFeatureNamen.Visible = !tboFeatureNaam.Visible;

            featureFilterText = tboFilterText.Text;
        }

        private void frmMaakFeature_Load(object sender, EventArgs e)
        {
            FillTextBox();
        }

        void FillTextBox()
        {
            lboOmschrijvingen.Items.Clear();
            foreach (DataRij dataRij in CsvGenerator.xlData.Where(r => r.fittingType == m_fittingType))
                lboOmschrijvingen.Items.Add(dataRij.data[MetadataHandler.descriptionIndex]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lboParameters_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Font myFont = e.Font;
            Brush myBrush = Brushes.Black;
            int i = e.Index;

            if (lboOmschrijvingen.Items[i].ToString().Contains(tboFilterText.Text) && tboFilterText.Text != "")
            {
                myFont = e.Font;
                myBrush = Brushes.Green;
            }
            e.Graphics.DrawString(lboOmschrijvingen.Items[i].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
        }

        private void tboFeatureNaam_TextChanged(object sender, EventArgs e)
        {
            featureName = tboFeatureNaam.Text;
        }

        private void cmbFeatureNamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Feature feature in MetadataHandler.features.Where(f=>f.fittingType==m_fittingType
            && f.featureName == cmbFeatureNamen.SelectedItem.ToString()))
            {
                tboFilterText.Text = feature.featureFilterTekst;
                selectedFeature = MetadataHandler.features.IndexOf(feature);
            }
            tboFilterText.Enabled = false;
            tboFeatureNaam.Enabled = false;
            tboFeatureNaam.Visible = false;
            cmbFeatureNamen.Enabled = true;
            cmbFeatureNamen.Visible = true;

            btnVerwijderFeature.Enabled = true;
            btnVerwijderFeature.Visible = true;
        }

        private void btnVerwijderFeature_Click(object sender, EventArgs e)
        {
            MetadataHandler.features.Remove(MetadataHandler.features[selectedFeature]);
            SetWorkspace();
        }
    }
}
