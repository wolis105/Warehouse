using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FrmExtractDetail : Form
    {
        public FrmExtractDetail()
        {
            InitializeComponent();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            FrmExtract f = new FrmExtract();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
