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
    public partial class FrmWarehouse : Form
    {
        public FrmWarehouse()
        {
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string loginId = this.listView1.SelectedItems[0].Text;

                string WAID = Convert.ToString(this.listView1.SelectedItems[0].Tag);

                DialogResult dr = MessageBox.Show("您确认要删除用户" + loginId + "吗？", "确认", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    FrmWarehouseDelete f = new FrmWarehouseDelete(loginId);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                    this.btnSelect.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("对不起！您还没有选择！");
            }
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            string strSQL = "sp_WarehouseLoad";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    string WhName = reader.GetString(reader.GetOrdinal("WhName"));

                    this.cboName.Items.Add(WhName);
                }
                reader.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmWarehouseAdd f = new FrmWarehouseAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                string whID = this.listView1.SelectedItems[0].Text;
                FrmUpdate f = new FrmUpdate(whID);
                this.Hide();
                f.ShowDialog();
                this.Show();

                this.btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("对不起！您还没有选择！");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            string strSQL = "sp_SelectAllWarehouse";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    string WhID = reader.GetString(reader.GetOrdinal("WhID"));
                    string WhName = reader.GetString(reader.GetOrdinal("WhName"));
                    string WhAdress = reader.GetString(reader.GetOrdinal("WhAdress"));
                    string WhExplain = reader.GetString(reader.GetOrdinal("WhExplain"));


                    ListViewItem item = new ListViewItem(WhID);
                    item.SubItems.Add(WhName);
                    item.SubItems.Add(WhAdress);
                    item.SubItems.Add(WhExplain);

                    this.listView1.Items.Add(item);
                }
                reader.Close();
            }
        }
    }
}
