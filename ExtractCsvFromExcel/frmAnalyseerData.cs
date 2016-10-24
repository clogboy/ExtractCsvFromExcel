using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtractCsvFromExcel
{
    public partial class frmAnalyseerData : Form
    {
        public int rijOffset;
        public List<int> filteredItems;
        private int lastSelected;
        static List<DataRij> xlData;

        public frmAnalyseerData(int RijOffset, List<DataRij> XlData)
        {
            rijOffset = RijOffset;
            xlData = XlData;
            InitializeComponent();
        }

        public void AddHeaders(object header)
        {
            //Vult een combobox met kolomnamen
            cmbKolomnamen.Items.Add(header.ToString());
        }

        private void cmbKolomnamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try {
                PopulateList();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void PopulateList()
        {
            //Als de lijst met subsets leeg is, word hij gevuld met subsets die door MetadataHandler verzameld worden.
            if (cmbCompatibleSets.Items.Count == 0)
            {
                foreach(string pmtName in MetadataHandler.ProductModelTypes(rijOffset, false))
                {
                    cmbCompatibleSets.Items.Add(pmtName);
                }
            }

            //Bereidt de lijst met omschrijvingen voor op data uit subsets.
            lboOmschrijvingen.Items.Clear();
            filteredItems = new List<int>();

            //Vult lijst met omschrijvingen met data uit de geselecteerde subset.
            for (int i = rijOffset + 1; i< xlData.Count; i++)
            {
                DataRij dataRij = xlData[i];

                //Wanneer er een subset is geselecteerd, filter data
                if (cmbCompatibleSets.SelectedItem != null)
                {
                    if (dataRij.compatibleHash == (string)cmbCompatibleSets.SelectedItem ||
                        dataRij.fittingType == (string)cmbCompatibleSets.SelectedItem)
                    {
                        lboOmschrijvingen.Items.Add(dataRij.data[cmbKolomnamen.SelectedIndex].ToString());
                        filteredItems.Add(i);
                    }
                }

                //anders, laat alles zien
                else
                    lboOmschrijvingen.Items.Add(dataRij.data[cmbKolomnamen.SelectedIndex].ToString());
            }
            chbOmschrijvend.Checked = (cmbKolomnamen.SelectedIndex == MetadataHandler.descriptionIndex);
            chbOmschrijvend.Enabled = (!chbOmschrijvend.Checked);

        }

        private void btnVeranderProductnaam_Click(object sender, EventArgs e)
        {
            //Leest geselecteerde omschrijvingen, en wijst de geselecteerde items toe aan de ingevoerde subset
            if (txtProductnaam.Text != "" && txtProductnaam.Text != null)
            {
                foreach (int index in lboOmschrijvingen.SelectedIndices)
                {
                    int item = filteredItems.Count == 0 ? index + rijOffset + 1 : filteredItems[index];
                    xlData[item].fittingType = txtProductnaam.Text;
                    xlData[item].status = "Toegewezen";
                }

                CsvGenerator.data.hasChanged = true;

                //Onthoudt welke subset het laatst geselecteerd was
                lastSelected = cmbCompatibleSets.SelectedIndex;

                //Ververst het venster met de nieuwe data
                cmbCompatibleSets.Items.Clear();
                try
                {
                    PopulateList();
                    //Selecteert de laatst gekozen subset
                    cmbCompatibleSets.SelectedIndex =
                        cmbCompatibleSets.Items.Count == lastSelected ?
                        lastSelected - 1 : lastSelected;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAnalyseerData_Load(object sender, EventArgs e)
        {
            //Leest welke kolom het laatst is geselecteerd als omschrijving
            cmbKolomnamen.SelectedIndex = MetadataHandler.descriptionIndex;
        }

        private void chbOmschrijvend_CheckedChanged(object sender, EventArgs e)
        {
            MetadataHandler.descriptionIndex = cmbKolomnamen.SelectedIndex;
            CsvGenerator.data.hasChanged = true;
        }
    }
}
