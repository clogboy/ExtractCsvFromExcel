using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractCsvFromExcel
{
    public partial class frmStatus : Form
    {
        public string fittingType;
        string currentStatus;

        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            List<string> status = MetadataHandler.status();
            foreach (string werkstatus in status)
                cmbStatus.Items.Add(werkstatus);

            foreach (DataRij dataRij in CsvGenerator.xlData.Where(d => d.fittingType == fittingType))
                currentStatus = dataRij.status;

            cmbStatus.Text = currentStatus;

            lblMessage.Text = "Verander de status voor " + fittingType;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text != "" && cmbStatus.Text != currentStatus)
            {
                foreach (DataRij dataRij in CsvGenerator.xlData.Where(d => d.fittingType == fittingType))
                    dataRij.status = cmbStatus.Text;
            }

            CsvGenerator.data.hasChanged = true;
        }
    }
}
