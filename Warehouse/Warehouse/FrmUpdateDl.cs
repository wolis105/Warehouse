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
    public partial class FrmUpdateDl : Form
    {
        public FrmUpdateDl()
        {
            InitializeComponent();
        }
        public FrmUpdateDl(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private string id = null;
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strSQL = "update Deliver  set DlID=@DlID,DlCount=@DlCount  where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                //差一行参数
               
                con.Close();
            }
        }

        private void FrmUpdateDl_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Deliver d left join Goods g on d.GdID=g.GdID where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
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
    }
}
