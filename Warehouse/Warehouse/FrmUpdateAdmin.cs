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
    public partial class FrmUpdateAdmin : Form
    {
        public FrmUpdateAdmin()
        {
            InitializeComponent();
        }
        public FrmUpdateAdmin(string id )
        {
            InitializeComponent();
            this.id = id;
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private  string id = null;
        private void FrmUpdateAdmin_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Supplier where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SpID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string loginID = reader.GetString(reader.GetOrdinal("SpLoginID"));
                    string name = reader.GetString(reader.GetOrdinal("SpName"));
                    string contact = reader.GetString(reader.GetOrdinal("SpContact"));
                    string phone = reader.GetString(reader.GetOrdinal("SpPhone"));
                    txtLoginId.Text = loginID;
                    txtName.Text = name;
                    txtPhone.Text = phone;
                    txtContact.Text = contact;
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string strSQL = "update Supplier set SpLoginID=@SpLoginID,SpName=@SpName,SpContact=@SpContact,SpPhone=@SpPhone  where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SpID", id);
                cmd.Parameters.AddWithValue("@SpLoginID", txtLoginId.Text);
                cmd.Parameters.AddWithValue("@SpName", txtName.Text);
                cmd.Parameters.AddWithValue("@SpContact", txtContact.Text);
                cmd.Parameters.AddWithValue("@SpPhone", txtPhone.Text);
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
              
                con.Close();
            }
        }
    }
}
