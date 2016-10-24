using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtractCsvFromExcel
{
    public partial class frmSelectWorksheet : Form
    {
        public List<string> werkbladen;
        public int werkbladIndex;

        public frmSelectWorksheet(List<string> Werkbladen)
        {
            werkbladen = Werkbladen;
            InitializeComponent();
        }

        private void formSelectWorksheet_Load(object sender, EventArgs e)
        {
            foreach (string werkblad in werkbladen)
            {
                cmbWorksheet.Items.Add(werkblad);
            }
            cmbWorksheet.SelectedIndex = 0;
        }

        private void cmbWorksheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            werkbladIndex = cmbWorksheet.SelectedIndex + 1;
        }
    }
}
