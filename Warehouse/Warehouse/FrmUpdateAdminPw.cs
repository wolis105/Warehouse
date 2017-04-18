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
    public partial class FrmUpdateAdminPw : Form
    {
        public FrmUpdateAdminPw()
        {
            InitializeComponent();
        }
        public FrmUpdateAdminPw(string id)
        {
            InitializeComponent();
            this .id = id;
        }
        private string id = null;
        private void FrmUpdateAdminPw_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private  string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txt1.Text.Trim()))
            {
                errorProvider1.SetError(txt1, "原密码不能为空");
            }
            if (string.IsNullOrWhiteSpace(txt2.Text.Trim()))
            {
                errorProvider1.SetError(txt2, "密码不能为空");
            }
            if (string.IsNullOrWhiteSpace(txt3.Text.Trim()))
            {
                errorProvider1.SetError(txt3, "密码不能为空");
            }

            string strSQL = "select * from Supplier where SpID=@SpID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SpID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                string pw = null;
                if(reader.Read())
                {
                    pw = reader.GetString(reader.GetOrdinal("SpPassword"));
                }
                reader.Close();
                if (pw != null && pw == txt1.Text.Trim()&&txt2.Text.Trim()==txt3.Text.Trim())
                {
                    strSQL = "update Supplier set SpPassword=@SpPassword where SpID=@SpID";
                    SqlCommand cmd1 = new SqlCommand(strSQL, con);
                    cmd1.Parameters.AddWithValue("@SpPassword",txt2.Text.Trim());
                    cmd1.Parameters.AddWithValue("@SpID", id);
                    int num = cmd1.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                con.Close();
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt3.Text != txt2.Text)
            {
                errorProvider1.SetError(txt3, "两次输出的密码不一致");
            }
        }
    }
}
