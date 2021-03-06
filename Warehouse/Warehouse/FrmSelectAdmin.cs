﻿using System;
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
    public partial class FrmSelectAdmin : Form
    {
        public FrmSelectAdmin()
        {
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminAdd f = new FrmAdminAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string WAName = this.txtName.Text.Trim();
            if (this.txtName.Text == "")
            {
                this.errorProvider1.SetError(txtName, "要查询的名字不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            this.lvwSelect.Items.Clear();
            string strSQL = "sp_SelectAdmin";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAName", this.txtName.Text.Trim())))
            {
                while (reader.Read())
                {
                    string WALojinID = reader.GetString(reader.GetOrdinal("WALojinID"));
                    WAName = reader.GetString(reader.GetOrdinal("WAName"));
                    string WASex = reader.GetString(reader.GetOrdinal("WASex"));
                    string WACardID = reader.GetString(reader.GetOrdinal("WACardID"));
                    string WAphone = reader.GetString(reader.GetOrdinal("WAphone"));
                    string WhName = reader.GetString(reader.GetOrdinal("WhName"));


                    ListViewItem item = new ListViewItem(WALojinID);
                    item.SubItems.Add(WAName);
                    item.SubItems.Add(WASex);
                    item.SubItems.Add(WACardID);
                    item.SubItems.Add(WAphone);
                    item.SubItems.Add(WhName);

                    this.lvwSelect.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            string strSQL = "sp_SelectWAID";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAName", this.lvwSelect.SelectedItems[0].Text)))
            {
                while (reader.Read())
                {
                    if (this.lvwSelect.SelectedItems.Count > 0)
                    {

                        string WAID = reader.GetString(reader.GetOrdinal("WAID"));
                        FrmUpdate f = new FrmUpdate(WAID);
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
                reader.Close();
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            string strSQL = "sp_SelectWAID";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAName", this.lvwSelect.SelectedItems[0].Text)))
            {
                while (reader.Read())
                {
                    if (this.lvwSelect.SelectedItems.Count > 0)
                    {
                        string WAID = reader.GetString(reader.GetOrdinal("WAID"));

                        string loginId = Convert.ToString(this.lvwSelect.SelectedItems[0].Tag);

                        DialogResult dr = MessageBox.Show("您确认要删除用户" + WAID + "吗？", "确认", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            FrmAdminDelete f = new FrmAdminDelete(WAID);
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
                reader.Close();
            }
        }

        private void tsmiUpdatePassword_Click(object sender, EventArgs e)
        {
            string strSQL = "sp_SelectWAID";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAName", this.lvwSelect.SelectedItems[0].Text)))
            {
                while (reader.Read())
                {
                    if (this.lvwSelect.SelectedItems.Count > 0)
                    {
                        string WAID = reader.GetString(reader.GetOrdinal("WAID"));
                        FrmAdminUpdatePassword f = new FrmAdminUpdatePassword(WAID);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                }
            }
              
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            FrmWarehouse f = new FrmWarehouse();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
