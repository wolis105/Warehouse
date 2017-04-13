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
    public partial class FrmAddDetail : Form
    {
        public FrmAddDetail()
        {
            InitializeComponent();
        }

        private void FrmAddDetail_Load(object sender, EventArgs e)
        {
            string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select GdName,PcDate,PDCount,PDID from PurchaseDetail p inner join Goods c on p.GdID=c.GdID inner join Purchase u on p.RID=u.RID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

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
            FrmAddLook frm = new FrmAddLook(str, str1, str2,rid);
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
