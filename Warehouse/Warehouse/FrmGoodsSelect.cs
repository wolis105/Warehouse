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
    public partial class FrmGoodsSelect : Form
    {
        public FrmGoodsSelect()
        {
            InitializeComponent();
        }

        private string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FrmGoodsSelect_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    string gdType = reader.GetString(reader.GetOrdinal("GdType"));
                    string gdSpecification = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string gdUnit = reader.GetString(reader.GetOrdinal("GdUnit"));

                    ListViewItem item = new ListViewItem(gdName);
                    item.SubItems.Add(gdType.ToString());
                    item.SubItems.Add(gdSpecification.ToString());
                    item.SubItems.Add(gdUnit.ToString());
                    //item.Tag = reader.GetString(reader.GetOrdinal("PDID"));

                    this.listView1.Items.Add(item);
                }
                reader.Close();

                con.Close();
            }
        }
    }
}
