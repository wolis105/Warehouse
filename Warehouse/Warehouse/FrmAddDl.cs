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
    public partial class FrmAddDl : Form
    {
        public FrmAddDl()
        {
            InitializeComponent();
        }
        public FrmAddDl(string id1)
        {
            InitializeComponent();
            this.id1 = id1;
        }
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private string id1 = null;

        private string id = null;
        private void FrmAddDl_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("GdName"));
                    comboBox1.Items.Add(name);
                }
                reader.Close();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            string name = comboBox1.Text.Trim();
            int count = Convert.ToInt32(textBox1.Text.Trim());

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(comboBox1, "不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(count.ToString()))
            {
                errorProvider1.SetError(textBox1, "不能为空");
                return;
            }
            string strSQL = "select * from Goods where GdName=@GdName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", name);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetString(reader.GetOrdinal("GdID"));
                }

                con.Close();
            }

            strSQL = "insert into Deliver(DlID,DlCount,SpID,GdID) values (@DlID,@DlCount,@SpID,@GdID)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", id);
                cmd.Parameters.AddWithValue("@DlID", guid);
                cmd.Parameters.AddWithValue("@DlCount", count);
                cmd.Parameters.AddWithValue("@SpID", id1);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("录入成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("录入失败");

                }

                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
