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
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
