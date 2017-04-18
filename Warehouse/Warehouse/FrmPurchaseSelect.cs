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
    public partial class FrmPurchaseSelect : Form
    {
        public FrmPurchaseSelect()
        {
            InitializeComponent();
        }

        private void FrmPurchaseSelect_Load(object sender, EventArgs e)
        {
            string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select * from Purchase";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string rid = reader.GetString(reader.GetOrdinal("RID"));
                    DateTime pcDate = reader.GetDateTime(reader.GetOrdinal("PcDate"));
                    string whID = reader.GetString(reader.GetOrdinal("WhID"));

                    ListViewItem item = new ListViewItem(rid);
                    item.SubItems.Add(pcDate.ToString());
                    item.SubItems.Add(whID);

                    this.listView1.Items.Add(item);
                }
                reader.Close();

                con.Close();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string rid = this.listView1.SelectedItems[0].Text;
            FrmPurchaseDetailSelect frm = new FrmPurchaseDetailSelect(rid);
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
