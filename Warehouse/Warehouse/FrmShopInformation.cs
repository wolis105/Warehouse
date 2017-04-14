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
    public partial class FrmShopInformation : Form
    {
        public FrmShopInformation()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmShopInformation_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Shop";
            using (SqlConnection con=new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.lblName.Text = reader.GetString(reader.GetOrdinal("ShName"));
                   this.lblAddress.Text = reader.GetString(reader.GetOrdinal("ShAdress"));
                    this.lblMannagerName.Text = reader.GetString(reader.GetOrdinal("ShManagerName"));
                    this.lblPhone.Text = reader.GetString(reader.GetOrdinal("ShPhone"));
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
