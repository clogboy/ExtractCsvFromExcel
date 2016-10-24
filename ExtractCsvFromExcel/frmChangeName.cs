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
    public partial class frmChangeName : Form
    {
        public string fittingType;
        string oldName;

        public frmChangeName()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fittingType = textBox1.Text;
        }

        private void frmChangeName_Load(object sender, EventArgs e)
        {
            lblVeranderNaam.Text = "Kies een nieuwe naam voor " + fittingType;

            textBox1.SelectedText = fittingType;
            oldName = fittingType;
        }
    }
}
