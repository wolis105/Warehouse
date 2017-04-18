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
    public partial class FrmDeleteGoods : Form
    {
        public FrmDeleteGoods()
        {
            InitializeComponent();
        }
        public FrmDeleteGoods(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private string id = null;
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void FrmDeleteGoods_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods  where GdID=@GdID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("GdName"));
                    string type = reader.GetString(reader.GetOrdinal("GdType"));
                    string sp = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string unit = reader.GetString(reader.GetOrdinal("GdUnit"));

                    lblName.Text = name;
                    lblType.Text = type;
                    lblsp.Text = unit;
                    lblUnit.Text = sp;
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from Goods  where GdID=@GdID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", id);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

                con.Close();
            }
        }
    }
}
