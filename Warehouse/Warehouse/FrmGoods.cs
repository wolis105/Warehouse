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
    public partial class FrmGoods : Form
    {
        public FrmGoods()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmAddGoods f = new Warehouse.FrmAddGoods();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lvwShow.Items.Clear();
            string name = cboName.Text.Trim();
            if (name == "查询所有")
            {
                name = "";
            }
            string strSQL = "select  GdID,GdName,GdType,GdSpecification,GdUnit from Goods where (charIndex(@GdName,GdName)>0 or len(@GdName)=0 )";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName",name);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(reader.GetOrdinal("GdID"));
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    string type= reader.GetString(reader.GetOrdinal("GdType"));
                    string sp = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string unit = reader.GetString(reader.GetOrdinal("GdUnit"));
                    ListViewItem list = new ListViewItem(gName);
                    list.SubItems.Add(type);
                    list.SubItems.Add(sp);
                    list.SubItems.Add(unit);
                    list.Tag = id;
                    lvwShow.Items.Add(list);
                }
                reader.Close();
                con.Close();
            }
        }

        private void FrmGoods_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("GdName"));
                    cboName.Items.Add(name);
                }
                reader.Close();
                con.Close();
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (lvwShow.SelectedItems.Count>0)
            {
                string s = lvwShow.SelectedItems[0].Tag.ToString();
                FrmUpdateGoods f = new FrmUpdateGoods(s);
               this.Hide();
                f.ShowDialog();
                this.Show();
                this.btnSelect.PerformClick();
            }
           
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvwShow.SelectedItems.Count > 0)
            {
                string s = lvwShow.SelectedItems[0].Tag.ToString();
                DialogResult = MessageBox.Show("是否删除所选项", "", MessageBoxButtons.YesNo);
                if (DialogResult==DialogResult.Yes)
                {
                    FrmDeleteGoods f = new FrmDeleteGoods(s);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    this.btnSelect.PerformClick();
                }
            }
        }
    }
}
