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
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void tmsiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Deliver d left join Goods g on d.GdID=g.GdID where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL,con);
                //差一个参数
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    cboName.Items.Add(gName);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string   strSQL = "select * from Deliver d left join Goods g on d.GdID=g.GdID where (charIndex('@GdName',@GdName)>0 or len(@GdName)=0 )and SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                //差一行参数
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    int count = reader.GetInt32(reader.GetOrdinal("DlCount"));
                    string id = reader.GetString(reader.GetOrdinal("DlID"));
                    ListViewItem list = new ListViewItem(gName);
                    list.SubItems.Add(count.ToString());
                    list.Tag = id;
                    lvwShow.Items.Add(list);
                   
                }
                reader.Close();
                con.Close();
            }
        }
        private string listItems = null;

        private void tmsiUpdate_Click(object sender, EventArgs e)
        {
            if (this.lvwShow.SelectedItems.Count > 0)
            {
                listItems = lvwShow.SelectedItems[0].Tag.ToString();
                if (listItems != null)
                {
                    FrmUpdateDl frm = new FrmUpdateDl(listItems);
                    frm.ShowDialog();
                }
                this.btnOK.PerformClick();
            }
            else
            {
                MessageBox.Show("没有选择信息");
            }
        }
    }
}
