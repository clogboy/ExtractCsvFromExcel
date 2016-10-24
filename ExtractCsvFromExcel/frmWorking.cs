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
    public partial class frmWorking : Form
    {
        string task;

        public frmWorking(string Task)
        {
            task = Task;

            InitializeComponent();
        }

        private void frmWorking_Load(object sender, EventArgs e)
        {
            lblWork.Text = task;
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}
