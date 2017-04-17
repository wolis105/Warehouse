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
        public FrmSupplier(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        string id = null;
        private void tmsiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Deliver d left join Goods g on d.GdID=g.GdID where d.SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL,con);
                //差一个参数
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                cmd.Parameters.AddWithValue("@SpID", id);
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
            this.lvwShow.Items.Clear();
            string   strSQL = "select GdName,DlCount,DlID from Deliver d inner join Goods g on (d.GdID=g.GdID) where (charIndex(@GdName,GdName)>0 or len(@GdName)=0 )and (d.SpID=@SpID)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                cmd.Parameters.AddWithValue("@SpID", id);
                //差一行参数

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    int count = reader.GetInt32(reader.GetOrdinal("DlCount"));
                    string Dlid= reader.GetString(reader.GetOrdinal("DlID"));
                    ListViewItem list = new ListViewItem(gName);
                    list.SubItems.Add(count.ToString());
                    list.Tag = Dlid;
                    lvwShow.Items.Add(list);
                }
                reader.Close();
                con.Close();
            }
        }
        string listItems = null;
        private void tmsiUpdate_Click(object sender, EventArgs e)
        {
            if (this.lvwShow.SelectedItems.Count > 0)
            {
                listItems = lvwShow.SelectedItems[0].Tag.ToString();
                if (listItems != null)
                {
                    FrmUpdateDl frm = new FrmUpdateDl(listItems);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();

                }
                this.btnOK.PerformClick();
            }
            else
            {
                MessageBox.Show("没有选择信息");
            }
        }

        private void tsmiUpdateMsg_Click(object sender, EventArgs e)
        {
            FrmUpdateAdmin f = new FrmUpdateAdmin(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsmiUpdatePw_Click(object sender, EventArgs e)
        {
            FrmUpdateAdminPw f = new FrmUpdateAdminPw(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
