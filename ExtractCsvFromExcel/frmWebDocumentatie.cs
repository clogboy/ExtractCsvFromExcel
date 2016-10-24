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
    public partial class frmWebDocumentatie : Form
    {
        public string url;

        public frmWebDocumentatie()
        {
            InitializeComponent();
        }

        public void Navigate(string url)
        {
            wbrDocumentatie.Navigate(url);

            this.Text = url;
        }

        private void frmWebDocumentatie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            return;
        }
    }
}
