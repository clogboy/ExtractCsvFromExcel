using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

namespace ExtractCsvFromExcel
{
    public partial class frmLinkParameters : Form
    {
        string m_fittingType;
        List<bool> hasData;
        List<int> selectedColumn;
        int lastSelected;
        Feature feature;
        string oldValue;
        List<int> IsColumn = new List<int>();
        List<int> IsRow = new List<int>();
        int configHeaders;
        List<string> m_headers;

        private void frmLinkParameters_Load(object sender, EventArgs e)
        {
            lblProduct.Text = "Voeg parameters toe voor " + m_fittingType;
            tboCsvNaam.Text = m_fittingType;

            hasData = MetadataHandler.ColumnHasData(m_headers, m_fittingType);

            ListParameters();
            VulTabel();
        }

        public frmLinkParameters(string fittingType, List<string> headers)
        {
            m_fittingType = fittingType;
            m_headers = headers;

            InitializeComponent();
            lboParameters.DrawMode = DrawMode.OwnerDrawFixed;
            lboParameters.DrawItem += new DrawItemEventHandler(lboParameters_DrawItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MaakParameter();
        }

        void MaakParameter()
        {
            lastSelected = lboParameters.SelectedIndex;
            List<int> ParameterCheckedToBeDeleted = new List<int>();
            foreach (Parameter parameterChecked in MetadataHandler.parameters.Where(p => p.headerIndex == selectedColumn[lastSelected]))
            {
                ParameterCheckedToBeDeleted.Add(parameterChecked.headerIndex);
            }

            foreach(int index in ParameterCheckedToBeDeleted)
            {
                Parameter parameterChecked = MetadataHandler.parameters.First(p => p.headerIndex == index);
                MetadataHandler.parameters.Remove(parameterChecked);
            }

            frmMaakParameter maakParameter = new frmMaakParameter();
            if (maakParameter.ShowDialog() == DialogResult.OK)
            {
                try { HandleResult(maakParameter.parNaam, maakParameter.parType, maakParameter.bepaaltConfig); }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }

        void HandleResult(string parNaam, string parType, bool config)
        {
            foreach (Parameter parameterNameChecked in MetadataHandler.parameters.Where
                (p => p.Header == parNaam && p.headerIndex != selectedColumn[lastSelected]))
            {
                if (MessageBox.Show("Een parameter met deze naam bestaat al. Wilt u het opnieuw proberen?",
                    "Parameter bestaat al",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    MaakParameter();
                }

                else
                {
                    return;
                }
            }

            if (parNaam != null)
            {
                Parameter parameter = new Parameter();
                parameter.Header = parNaam;
                parameter.Type = parType;
                parameter.headerIndex = selectedColumn[lboParameters.SelectedIndex];
                parameter.bepaaltConfig = config;
                MetadataHandler.parameters.Add(parameter);

                CsvGenerator.data.hasChanged = true;
            }

            ListParameters();
            lboParameters.SelectedIndex = lastSelected;
            VulTabel();
        }

        void VulTabel()
        {
            dgrCsvGegevens.Columns.Clear();
            dgrCsvGegevens.Columns.Add("Description", "");
            IsColumn.Clear();
            IsColumn.Add(-1);

            SetHeaders(true);

            foreach (Feature feature in MetadataHandler.features.Where(f => f.fittingType == m_fittingType))
            {
                dgrCsvGegevens.Columns.Add(feature.featureName, feature.featureName + "##other##");
                dgrCsvGegevens.Columns[dgrCsvGegevens.Columns.Count - 1].HeaderCell.Style.BackColor = Color.LightGreen;
                IsColumn.Add(-1);
            }

            configHeaders = dgrCsvGegevens.Columns.Count;

            SetHeaders(false);

            dgrCsvGegevens.Columns.Add("globalIndex", "globalIndex##other##");
            IsColumn.Add(-1);

            List<string> rijInhoud;

            for (int r = CsvGenerator.rijOffset + 1; r < CsvGenerator.xlData.Count; r++)
            {
                if (CsvGenerator.xlData[r].fittingType == m_fittingType)
                {
                    rijInhoud = new List<string>();
                    rijInhoud.Add(CsvGenerator.xlData[r].data[MetadataHandler.descriptionIndex].ToString());

                    RijInhoud(rijInhoud, r, true);

                    foreach (Feature feature in MetadataHandler.features.Where(f => f.fittingType == m_fittingType))
                    {
                        if (rijInhoud[0].Contains(feature.featureFilterTekst))
                        {
                            rijInhoud.Add("1");
                        }
                        else
                        {
                            rijInhoud.Add("0");
                        }
                    }


                    RijInhoud(rijInhoud, r, false);

                    rijInhoud.Add(CsvGenerator.xlData[r].globalIndex.ToString());

                    IsRow.Add(r);

                    dgrCsvGegevens.Rows.Add(rijInhoud.ToArray());
                }
            }

            if (configHeaders > 1 && dgrCsvGegevens.Rows.Count > 1)
            {
                try { CheckDoubleData(); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            for(int i = 0; i<dgrCsvGegevens.Columns.Count; i++)
            {
                dgrCsvGegevens.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        void SetHeaders(bool config)
        {
            string parHead;

            for (int p = 0; p < m_headers.Count; p++)
            {
                foreach(Parameter parameter in MetadataHandler.parameters.Where(par=>par.headerIndex == p && par.bepaaltConfig == config)) {
                    if (hasData[p])
                    {
                        string parType = parameter.Type;
                        switch (parType)
                        {
                            case "Length":
                                {
                                    parHead = parameter.Header + "##Length##Millimeters";
                                    break;
                                }

                            case "Angle":
                                {
                                    parHead = parameter.Header + "##Angle##Degrees";
                                    break;
                                }
                            case "Integer":
                                {
                                    parHead = parameter.Header + "##Other##";
                                    break;
                                }
                            default:
                                {
                                    parHead = parameter.Header + "##Other##";
                                    break;
                                }
                        }
                        dgrCsvGegevens.Columns.Add(parameter.Header, parHead);
                        IsColumn.Add(p);

                        if (parameter.bepaaltConfig == true)
                        {
                            dgrCsvGegevens.Columns[dgrCsvGegevens.Columns.Count - 1].HeaderCell.Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }

        List<string> RijInhoud(List<string> rijInhoud, int r, bool config)
        {
            for (int c = 0; c < m_headers.Count; c++)
            {
                foreach (Parameter parameter in MetadataHandler.parameters.Where(p => p.headerIndex == c && p.bepaaltConfig == config))
                {
                    if (hasData[c] == true)
                    {
                        string celInhoud = CsvGenerator.xlData[r].data[c].ToString();
                        if (celInhoud == "" || CsvGenerator.xlData[r].data[c].ToString() == null)
                            celInhoud = "0";

                        celInhoud.Replace(',', '.');

                        rijInhoud.Add(celInhoud);
                    }
                }
            }
            return rijInhoud;
        }

        void CheckDoubleData()
        {
            int duplicateCount = 0;
            for (int r = 1; r < dgrCsvGegevens.Rows.Count; r++)
            {
                for (int cr = 0; cr < r; cr++)
                {
                    bool duplicate = true;
                    for (int c = 1; c < configHeaders; c++)
                    {
                        if (dgrCsvGegevens[c, cr].FormattedValue.ToString() != dgrCsvGegevens[c, r].FormattedValue.ToString())
                        {
                            duplicate = false;
                            break;
                        }
                    }
                    if (duplicate)
                    {
                        lblDoubleData.Visible = true;
                        duplicateCount++;
                        dgrCsvGegevens.Rows[r].HeaderCell.Style.BackColor = Color.Orange;
                        dgrCsvGegevens.Rows[cr].HeaderCell.Style.BackColor = Color.Orange;
                    }
                }
            }
            if(duplicateCount == 0)
            {
                lblDoubleData.Visible = false;
            }
        }

        void ListParameters()
        {
            selectedColumn = new List<int>();
            lboParameters.Items.Clear();

            for (int i = 0; i < m_headers.Count; i++)
            {
                if (hasData[i])
                {
                    bool parameterExists = false;
                    foreach (Parameter parameter in MetadataHandler.parameters.Where(p => p.headerIndex == i))
                    {
                        //Zet de gekoppelde parameter tussen haakjes achter de kolomnaam
                        string item = m_headers[i] + " (" + parameter.Header + ")";
                        lboParameters.Items.Add(item);
                        parameterExists = true;
                    }
                    if (parameterExists == false)
                    {
                        //Zet de kolomnaam in de lijst
                        lboParameters.Items.Add(m_headers[i]);
                    }
                    selectedColumn.Add(i);
                }
            }
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lboParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMaakParameter.Enabled = true;
            lastSelected = lboParameters.SelectedIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMaakFeature maakFeature = new frmMaakFeature(m_fittingType);
            if(maakFeature.ShowDialog() == DialogResult.OK)
            {
                string featureNaam = maakFeature.featureName;
                string featureFilterTekst = maakFeature.featureFilterText;

                feature = new Feature();

                if(featureFilterTekst != null && featureFilterTekst != "")
                {
                    feature.featureName = featureNaam;
                    feature.featureFilterTekst = featureFilterTekst;
                    feature.fittingType = m_fittingType;

                    MetadataHandler.features.Add(feature);

                    CsvGenerator.data.hasChanged = true;

                    VulTabel();
                }
            }
        }

        private void lboParameters_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Font myFont;
            Brush myBrush;
            int i = e.Index;

            myFont = e.Font;
            myBrush = Brushes.SandyBrown;
            foreach (Parameter parameter in MetadataHandler.parameters.Where(p => p.headerIndex == selectedColumn[i]))
            {
                if (parameter.bepaaltConfig)
                {
                    myFont = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
                    myBrush = Brushes.Black;
                }
                else
                {
                    myFont = e.Font;
                    myBrush = Brushes.Black;
                }
            }
            e.Graphics.DrawString(lboParameters.Items[i].ToString(), myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
        }

        private void dgrCsvGegevens_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dgrCsvGegevens.CurrentCell.FormattedValue.ToString();
        }

        private void dgrCsvGegevens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newValue = dgrCsvGegevens.CurrentCell.FormattedValue.ToString();
            int row = IsRow[dgrCsvGegevens.CurrentCell.RowIndex];
            int col = IsColumn[dgrCsvGegevens.CurrentCell.ColumnIndex];
            if (newValue != oldValue && col != -1)
            {
                Actie actie = new Actie();
                actie.oldVal = oldValue;
                actie.newVal = newValue;
                actie.row = row;
                actie.col = col;
                actie.fittingType = m_fittingType;
                UndoHandler.acties.Add(actie);

                dgrCsvGegevens.CurrentCell.Style.BackColor = Color.LightGray;

                CheckDoubleData();
            }
            else
            {
                dgrCsvGegevens.CurrentCell.Value = oldValue;
            }
            btnUndo.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UndoHandler.BewaarWijzigingen();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UndoHandler.VerwijderWijzigingen();
            Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            List<Actie> acties = UndoHandler.acties;
            for(int a = UndoHandler.acties.Count - 1; a >= 0; a--)
            {
                if(acties[a].fittingType == m_fittingType)
                {
                    int col = IsColumn.IndexOf(acties[a].col);
                    int row = IsRow.IndexOf(acties[a].row);

                    dgrCsvGegevens[col, row].Value = acties[a].oldVal;
                    dgrCsvGegevens[col, row].Style.BackColor = Color.White;
                    acties.Remove(acties[a]);
                    break;
                }
            }
            CheckDoubleData();
            UndoHandler.acties = acties;
        }

        private void btnBewaarCsv_Click(object sender, EventArgs e)
        {
            sfdBewaarCsv.FileName = m_fittingType;

            if (sfdBewaarCsv.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdBewaarCsv.FileName, false, Encoding.UTF8))
                {
                    string headerText = "";
                    for (int i = 1; i < dgrCsvGegevens.Columns.Count; i++)
                    {
                        headerText = string.Concat(headerText, ", ", dgrCsvGegevens.Columns[i].HeaderText);
                    }

                    sw.WriteLine(headerText);

                    for (int r = 0; r < dgrCsvGegevens.Rows.Count; r++)
                    {
                        string newLine = (r + 1).ToString();
                        for (int c = 1; c < dgrCsvGegevens.Columns.Count; c++)
                        {
                            newLine = string.Concat(newLine, ", ", dgrCsvGegevens[c, r].FormattedValue.ToString());
                        }
                        sw.WriteLine(newLine);

                    }
                }
            }
        }
    }
}
