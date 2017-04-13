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

        private void FrmExtractDetail_Load(object sender, EventArgs e)
        {
            string goodsName = this.cboGdName.Text;
            if(goodsName=="查询所有")
            {
                goodsName = "";
            }
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            if(this.lvwSelectlist.SelectedItems.Count>0)
            {
                string guid = this.lvwSelectlist.SelectedItems[0].Text;
                FrmRemove f = new FrmRemove(guid);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("您还没有选择！");
            }
        }
    }
}
