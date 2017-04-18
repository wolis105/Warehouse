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
    public partial class FrmPurchaseDetailSelect : Form
    {
        public FrmPurchaseDetailSelect()
        {
            InitializeComponent();
        }

        public FrmPurchaseDetailSelect(string rid)
        {
            InitializeComponent();
            this.rid = rid;
        }
        private string rid = null;
        private void FrmPurchaseDetailSelect_Load(object sender, EventArgs e)
        {
            string strCon = "server=SC-201608292202;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select GdName,PcDate,PDCount,PDID from PurchaseDetail p inner join Goods c on p.GdID=c.GdID inner join Purchase u on p.RID=u.RID where p.RID=@RID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@RID",rid);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    DateTime pcDate = reader.GetDateTime(reader.GetOrdinal("PcDate"));
                    int pDCount = reader.GetInt32(reader.GetOrdinal("PDCount"));

                    ListViewItem item = new ListViewItem(gdName);
                    item.SubItems.Add(pcDate.ToString());
                    item.SubItems.Add(pDCount.ToString());
                    item.Tag = reader.GetString(reader.GetOrdinal("PDID"));

                    this.listView1.Items.Add(item);
                }
                reader.Close();

                con.Close();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string str = this.listView1.SelectedItems[0].Text;
            string str1 = this.listView1.SelectedItems[0].SubItems[2].Text;
            string str2 = this.listView1.SelectedItems[0].SubItems[1].Text;
            string rid = Convert.ToString(this.listView1.SelectedItems[0].Tag);
            FrmAddLook frm = new FrmAddLook(str, str1, rid, str2);
            frm.Size = this.Size;
            frm.Location = this.Location;
            this.Hide();
            frm.ShowDialog();
            frm.Activate();
            this.Location = frm.Location;
            this.Show();
        }
    }
}
