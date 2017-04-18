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
            string strSQL = "select GdName,GdType,GdSpecification,GdUnit from Goods where (charIndex(@GdName,GdName)>0 or len(@GdName)=0 )";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    string type= reader.GetString(reader.GetOrdinal("GdType"));
                    string sp = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string unit = reader.GetString(reader.GetOrdinal("GdUnit"));
                    ListViewItem list = new ListViewItem(gName);
                    list.SubItems.Add(type);
                    list.SubItems.Add(sp);
                    list.SubItems.Add(unit);
                    lvwShow.Items.Add(list);
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
