using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ExtractCsvFromExcel
{
    public partial class frmMaakParameter : Form
    {
        public string parNaam;
        public string parType;
        public bool bepaaltConfig;

        public frmMaakParameter()
        {
            InitializeComponent();
        }

        private void frmMaakParameter_Load(object sender, EventArgs e)
        {
            cboParType.SelectedIndex = 0;
            parType = cboParType.SelectedItem.ToString();
        }

        private void cboParType_SelectedIndexChanged(object sender, EventArgs e)
        {
            parType = cboParType.SelectedItem.ToString();
        }

        private void tboParNaam_TextChanged(object sender, EventArgs e)
        {
            parNaam = tboParNaam.Text;
        }

        private void chbConfig_CheckedChanged(object sender, EventArgs e)
        {
            bepaaltConfig = chbConfig.Checked;
        }
    }
}
