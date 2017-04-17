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
        public FrmShopInformation(string a)
        {
            InitializeComponent();
            this.id = a;
        }
        private string id;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmShopInformation_Load(object sender, EventArgs e)
        {
            string strSQL2 = "select ShName from Shop s inner join Clerk on Clerk.ShID = s.ShID where Clerk.CILojinID = @id";
            string strSQL = "select * from Shop where ShName=@ShName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                con.Open();
                cmd2.Parameters.AddWithValue("@id", id);
                object obj = cmd2.ExecuteScalar();
                if (obj != null)
                {
                    string shName = obj.ToString();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ShName", shName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.lblName.Text = reader.GetString(reader.GetOrdinal("ShName"));
                        this.lblAddress.Text = reader.GetString(reader.GetOrdinal("ShAdress"));
                        this.lblMannagerName.Text = reader.GetString(reader.GetOrdinal("ShManagerName"));
                        this.lblPhone.Text = reader.GetString(reader.GetOrdinal("ShPhone"))==null?("未填写"):(reader.GetString(reader.GetOrdinal("ShPhone")));
                    }
                    reader.Close();
                }
                con.Close();
            }
        }
    }
}
