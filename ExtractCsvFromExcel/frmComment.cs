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
    public partial class frmComment : Form
    {
        public string comment;

        public frmComment()
        {
            InitializeComponent();
        }

        private void tboComment_TextChanged(object sender, EventArgs e)
        {
            comment = tboComment.Text;
        }

        private void frmComment_Load(object sender, EventArgs e)
        {
        }
    }
}
