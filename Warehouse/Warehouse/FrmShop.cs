using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warehouse
{
    public partial class FrmShop : Form
    {
        public FrmShop()
        {
            InitializeComponent();
        }
        public FrmShop(string a)
        {
            InitializeComponent();
            this.id = a;
        }
        private string id;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void 销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSales f = new FrmSales(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmExtract f = new FrmExtract(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmShopInformation f = new FrmShopInformation(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmQuery_Shop f = new FrmQuery_Shop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FrmShop_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmUpdate_Pwd f = new FrmUpdate_Pwd(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
