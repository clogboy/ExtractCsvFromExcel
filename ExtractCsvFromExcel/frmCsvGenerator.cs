using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;


namespace ExtractCsvFromExcel
{
    public partial class CsvGenerator : Form
    {
        public string excelFile;
        public static int rijOffset = 0;
        public static List<string> headers;
        public static TreeView treeView;
        public static List<DataRij> xlData;
        public static Data data;
        string xmlBestandsNaam;
        UpdateExcelData updateData;
        bool originalState;
        frmWebDocumentatie webDoc;

        public CsvGenerator()
        {
            InitializeComponent();
        }

        private void mnuKoppelExcel_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                if (data.hasChanged)
                {
                    DialogResult dr = MessageBox.Show("De gegevens zijn gewijzigd. Wilt u de veranderingen opslaan?",
                        "Wilt u de wijzigingen bewaren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            {
                                return;
                            }

                        case DialogResult.Yes:
                            {
                                mnuMaakProject_Click(sender, e);
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
            }

            if (treeView != null)
            treeView.Nodes.Clear();
            dgrExcelData.Rows.Clear();
            dgrExcelData.Columns.Clear();

            if (ofdOpenExcel.ShowDialog() == DialogResult.OK)
            {
                MetadataHandler.descriptionIndex = 0;
                rijOffset = 0;

                excelFile = ofdOpenExcel.FileName;
                ofdOpenExcel.Dispose();
                lblWerkblad.Text = "Openen: " + excelFile + "...";
                try
                {
                    xlData = ReadFromExcel.LeesWerkbladen(excelFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lblWerkblad.Text = "";
                }
                finally
                {
                    lblWerkblad.Text = "Geopend: " + excelFile + " -- " + MetadataHandler.productRange;

                    InitializeWorkspace();

                    MetadataHandler.parameters = new List<Parameter>();
                    MetadataHandler.features = new List<Feature>();

                    data = new Data();
                    CsvGenerator.data.hasChanged = true;
                }
            }

        }

        void VulTabel(string vulMethode, string filter)
        {
            dgrExcelData.Columns.Clear();
            dgrExcelData.Rows.Clear();

            int kolommen = xlData[0].data.Count;

            if (rijOffset == 0)
            {
                while (xlData[rijOffset].data[kolommen - 1] == "" || xlData[rijOffset].data[kolommen - 1] == null || xlData[rijOffset].data[kolommen - 1] == " ")
                    rijOffset++;
            }

            headers = xlData[rijOffset].data;

            for (int c = 0; c < headers.Count; c++)
                dgrExcelData.Columns.Add(headers[c].ToString(), headers[c].ToString());

            switch (vulMethode)
            {
                case "fittingtype":
                    {
                        for (int i = rijOffset + 1; i < xlData.Count; i++)
                        {
                            if (xlData[i].fittingType == filter)
                            {
                                dgrExcelData.Rows.Add(xlData[i].data.ToArray());
                                dgrExcelData.Rows[dgrExcelData.Rows.Count - 1].HeaderCell.Value = dgrExcelData.Rows.Count.ToString();
                            }
                        }
                        break;
                    }

                case "status":
                    {
                        for (int i = rijOffset + 1; i < xlData.Count; i++)
                        {
                            if (xlData[i].status == filter)
                            {
                                dgrExcelData.Rows.Add(xlData[i].data.ToArray());
                                dgrExcelData.Rows[dgrExcelData.Rows.Count - 1].HeaderCell.Value = dgrExcelData.Rows.Count.ToString();
                            }
                        }
                        break;
                    }

                case "search":
                    {
                        for (int r = rijOffset + 1; r < xlData.Count; r++)
                        {
                            bool result = false;
                            for (int i = 0; i < xlData[r].data.Count; i++)
                            {
                                if (xlData[r].data[i].Contains(filter))
                                {
                                    result = true;
                                }
                            }
                            if (result == true)
                            {
                                dgrExcelData.Rows.Add(xlData[r].data.ToArray());
                                dgrExcelData.Rows[dgrExcelData.Rows.Count - 1].HeaderCell.Value = dgrExcelData.Rows.Count.ToString();
                            }
                        }

                        for(int r=0; r<dgrExcelData.Rows.Count; r++)
                        {
                            for(int c = 0; c<dgrExcelData.Columns.Count; c++)
                            {
                                if (dgrExcelData[c, r].FormattedValue.ToString().Contains(filter))
                                {
                                    dgrExcelData[c, r].Style.BackColor = Color.LightGreen;
                                }
                            }
                        }
                        break;
                    }

                default:
                    {
                        for (int r = rijOffset + 1; r < xlData.Count; r++)
                        {
                            dgrExcelData.Rows.Add(xlData[r].data.ToArray());
                            dgrExcelData.Rows[dgrExcelData.Rows.Count - 1].HeaderCell.Value = dgrExcelData.Rows.Count.ToString();
                        }
                        break;
                    }
            }

            dgrExcelData.AutoResizeColumns();
            dgrExcelData.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgrExcelData.ClipboardCopyMode =
                DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

            if (treeView.Nodes != null && treeView.SelectedNode != null && !trvProductModelTypes.Nodes[0].IsSelected
                && vulMethode != "status")
            {
                //Haalt een lijst op met booleans om te zien welke kolommen leeg zijn
                List<bool> columnHasData = new List<bool>();
                columnHasData = MetadataHandler.ColumnHasData(headers, filter);

                //Verwijdert de lege kolommen uit de Datagridview
                for (int i = 0; i < columnHasData.Count; i++)
                {
                    if (columnHasData[i] == false)
                    {
                        dgrExcelData.Columns.Remove(headers[i].ToString());
                    }
                }
            }

            BtnState();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            rijOffset++;
            VulTabel("", "");
            CsvGenerator.data.hasChanged = true;

            BuildTree(true);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            rijOffset--;
            VulTabel("", "");
            CsvGenerator.data.hasChanged = true;

            BuildTree(true);
        }

        private void BtnState()
        {
            btnUp.Enabled = (rijOffset > 0);
            btnDown.Enabled = (rijOffset < xlData.Count);
            tboSearch.Enabled = true;
        }

        private void btnAnalyseerTabel_Click(object sender, EventArgs e)
        {
            frmAnalyseerData analyseerData = new frmAnalyseerData(rijOffset, xlData);

            foreach (object header in headers)
                analyseerData.AddHeaders(header);

            analyseerData.ShowDialog();

            BuildTree(false);
        }

        public void BuildTree(bool overwrite)
        {
            treeView.Nodes.Clear();

            treeView.Nodes.Add(MetadataHandler.productRange);

            List<string> status = MetadataHandler.status();

            foreach(string werkstatus in status)
            {
                treeView.Nodes[0].Nodes.Add(werkstatus);
            }

            List<string> pmtList = MetadataHandler.ProductModelTypes(rijOffset, overwrite);

            for (int n = 0; n < pmtList.Count; n++)
            {
                int s = 0;

                for(int d = 0; d < xlData.Count; d++)
                {
                    if(xlData[d].fittingType == pmtList[n])
                    {
                        s = status.IndexOf(xlData[d].status);
                        break;
                    }
                }
                treeView.Nodes[0].Nodes[s].Nodes.Add(pmtList[n]);
                if (MetadataHandler.commentaar != null)
                    foreach (Commentaar opmerking in MetadataHandler.commentaar.Where(c => c.fittingType == pmtList[n]))
                    {
                        treeView.Nodes[0].Nodes[s].Nodes[treeView.Nodes[0].Nodes[s].Nodes.Count - 1].ToolTipText = opmerking.commentaar;
                        treeView.Nodes[0].Nodes[s].Nodes[treeView.Nodes[0].Nodes[s].Nodes.Count - 1].StateImageIndex = 0;
                    }
                

            }

            for (int i = 0; i < treeView.Nodes[0].Nodes.Count; i++)
            {
                for(int j = 0; j < treeView.Nodes[0].Nodes[i].Nodes.Count; j++)
                {
                    treeView.Nodes[0].Nodes[i].Nodes[j].ContextMenuStrip = contextMenuStrip1;
                }
            }

            treeView.Nodes[0].Expand();

            foreach (TreeNode node in treeView.Nodes[0].Nodes)
            {
                node.Expand();
            }

        }

        private void trvProductModelTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvProductModelTypes.SelectedNode != trvProductModelTypes.Nodes[0])
            {
                if (e.Node.Parent == treeView.Nodes[0])
                {
                    VulTabel("status", e.Node.Text);
                }
                else
                {
                    VulTabel("fittingtype", e.Node.Text);
                }
                tboSearch.Clear();
                tboSearch.Enabled = false;
            }
            else
            {
                VulTabel("", "");
                tboSearch.Enabled = true;
            }
        }

        private void trvProductModelTypes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == treeView.Nodes[0] || e.Node.Parent == treeView.Nodes[0])
            {
                return;
            }
            frmLinkParameters linkParameters = new frmLinkParameters(e.Node.Text, headers);
            linkParameters.Show();
        }

        private void dgrExcelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellContent = dgrExcelData.CurrentCell.Value.ToString();
            if (cellContent.Contains("http") || cellContent.Contains("www"))
            {
                if (webDoc == null)
                    webDoc = new frmWebDocumentatie();

                webDoc.Navigate(cellContent.ToString());
                webDoc.Show();
                webDoc.Focus();
            }
        }

        private void mnuMaakProject_Click(object sender, EventArgs e)
        {
            data.descriptionIndex = MetadataHandler.descriptionIndex;
            data.features = MetadataHandler.features;
            data.productRange = MetadataHandler.productRange;
            data.ExcelData = CsvGenerator.xlData;
            data.parameters = MetadataHandler.parameters;
            data.rijOffset = rijOffset;
            data.headers = headers;
            data.commentaar = MetadataHandler.commentaar;

            sfdSaveData.FileName = MetadataHandler.productRange + ".XML";

            XmlSerializer writer = new XmlSerializer(typeof(Data));

            if (xmlBestandsNaam == null)
            {
                if (sfdSaveData.ShowDialog() == DialogResult.OK)
                {
                    var path = sfdSaveData.FileName;
                    FileStream file = File.Create(path);
                    xmlBestandsNaam = sfdSaveData.FileName;
                    writer.Serialize(file, data);
                    file.Close();
                }
            }
            else
            {
                var path = xmlBestandsNaam;
                FileStream file = File.Create(path);
                writer.Serialize(file, data);
                file.Close();
            }

            data.hasChanged = false;

            lblWerkblad.Text = "De gegevens zijn opgeslagen.";
        }

        private void mnuOpenProject_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                if (data.hasChanged)
                {
                    DialogResult dr = MessageBox.Show("De gegevens zijn gewijzigd. Wilt u de veranderingen opslaan?",
                        "Wilt u de wijzigingen bewaren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            {
                                return;
                            }

                        case DialogResult.Yes:
                            {
                                mnuMaakProject_Click(sender, e);
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
            }

            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));

                StreamReader reader = new StreamReader(ofdOpenData.FileName);
                data = new Data();
                data = (Data)serializer.Deserialize(reader);

                reader.Close();

                MetadataHandler.productRange = data.productRange;
                MetadataHandler.descriptionIndex = data.descriptionIndex;
                MetadataHandler.features = data.features == null ? new List<Feature>() : data.features;
                xlData = data.ExcelData;
                rijOffset = data.rijOffset;
                headers = data.headers;
                MetadataHandler.parameters = data.parameters;
                MetadataHandler.commentaar = data.commentaar;

                xmlBestandsNaam = ofdOpenData.FileName;

                InitializeWorkspace();
                lblWerkblad.Text = "Geopend: " + ofdOpenData.FileName;

                CsvGenerator.data.hasChanged = false;
            }
        }
        public void InitializeWorkspace()
        {
            treeView = trvProductModelTypes;

            VulTabel("", "");
            BuildTree(false);
            btnDown.Enabled = true;
            mnuBewerkSubsets.Enabled = true;
            mnuMaakProject.Enabled = true;
            mnuUpdateData.Enabled = true;
            webDoc = new frmWebDocumentatie();
        }

        private void CsvGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (data != null)
            {
                if (data.hasChanged)
                {
                    DialogResult dr = MessageBox.Show("De gegevens zijn gewijzigd. Wilt u de veranderingen opslaan?",
                        "Wilt u de wijzigingen bewaren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (dr)
                    {
                        case DialogResult.Cancel:
                            {
                                e.Cancel = true;
                                return;
                            }

                        case DialogResult.Yes:
                            {
                                mnuMaakProject_Click(sender, e);
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
            }
        }

        private void wijzigingenTerugdraaienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateData.RecoverProjectData();
            InitializeWorkspace();
            lblWerkblad.Text = "Voorgaande staat is hersteld";
            mnuHerstellen.Enabled = false;

            CsvGenerator.data.hasChanged = (!originalState);
        }

        private void mnuSelecteerBestand_Click(object sender, EventArgs e)
        {
            if (ofdOpenExcel.ShowDialog() == DialogResult.OK)
            {
                originalState = (!data.hasChanged);

                lblWerkblad.Text = "Updaten: " + ofdOpenExcel.FileName + "...";

                updateData = new UpdateExcelData();
                try
                {
                    updateData.Main(ofdOpenExcel.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    lblWerkblad.Text = "Update voltooid";

                    InitializeWorkspace();

                    mnuHerstellen.Enabled = true;

                    CsvGenerator.data.hasChanged = true;
                }
            }
        }

        private void tboSearch_TextChanged(object sender, EventArgs e)
        {
            if (tboSearch.Text != "")
                VulTabel("search", tboSearch.Text);

            else
                VulTabel("", "");
        }

        private void veranderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmStatus status = new frmStatus();
                status.fittingType = treeView.SelectedNode.Text;
                if (status.ShowDialog() == DialogResult.OK)
                    BuildTree(false);
            }
            catch
            {
                MessageBox.Show("U heeft geen product geselecteerd.");
            }
        }

        private void trvProductModelTypes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;
        }

        private void veranderNaamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeName changeName = new frmChangeName();
            changeName.fittingType = treeView.SelectedNode.Text;
            string oldName = treeView.SelectedNode.Text;

            if (changeName.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRij dataRij in xlData.Where(d => d.fittingType == changeName.fittingType))
                {
                    if (changeName.fittingType != oldName)
                    {
                        MessageBox.Show("Deze naam bestaat al, kies een andere naam.");
                        veranderNaamToolStripMenuItem_Click(sender, e);
                    }

                    return;
                }

                foreach (DataRij dataRij in xlData.Where(d => d.fittingType == oldName))
                {
                    dataRij.fittingType = changeName.fittingType;
                }
                data.hasChanged = true;

                BuildTree(false);
            }
        }

        private void mnuAddComment_Click(object sender, EventArgs e)
        {
            frmComment comment = new frmComment();
            if(comment.ShowDialog() == DialogResult.OK)
            {
                if (comment.comment != null)
                {
                    int commentaarIndex = -1;
                    foreach (Commentaar opmerking in MetadataHandler.commentaar.Where(c => c.fittingType == treeView.SelectedNode.Text))
                        commentaarIndex = MetadataHandler.commentaar.IndexOf(opmerking);

                    if(commentaarIndex != -1)
                        MetadataHandler.commentaar.Remove(MetadataHandler.commentaar[commentaarIndex]);

                    Commentaar commentaar = new Commentaar();

                    commentaar.fittingType = treeView.SelectedNode.Text;
                    commentaar.commentaar = comment.comment;
                    MetadataHandler.commentaar.Add(commentaar);

                    data.hasChanged = true;
                    BuildTree(false);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool hasComment = false;
            foreach (Commentaar opmerking in MetadataHandler.commentaar.Where(c => c.fittingType == treeView.SelectedNode.Text))
                hasComment = true;

            mnuRemoveComment.Enabled = (hasComment);
        }

        private void mnuRemoveComment_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Commentaar opmerking in MetadataHandler.commentaar.Where(c => c.fittingType == treeView.SelectedNode.Text))
                i = MetadataHandler.commentaar.IndexOf(opmerking);

            MetadataHandler.commentaar.Remove(MetadataHandler.commentaar[i]);
            data.hasChanged = true;

            BuildTree(false);
        }
    }
}