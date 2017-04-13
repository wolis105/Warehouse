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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";

        private void btnDetermine_Click_1(object sender, EventArgs e)
        {
            string spID = Guid.NewGuid().ToString();
           
            string loginid =this . txtLoginId.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txtLoginId.Text))
            {
                this.errorProvider1.SetError(txtLoginId,"账号不能为空");
            }
            string password = this.txtPassword.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                this.errorProvider1.SetError(txtPassword, "密码不能为空");
            }
            string name = this.txtName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                this.errorProvider1.SetError(txtName, "供应商姓名不能为空");
            }
            string contact = this.txtContact.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txtContact.Text))
            {
                this.errorProvider1.SetError(txtContact, "联系人不能为空");
            }
            string phone = "未填写！";
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                 phone = this.txtPhone.Text.Trim();
            }
           


            string strSQL = @"insert into Supplier (SpID,SpLoginID,SpPassword,SpName,SpContact,SpPhone) values (@SpID,@SpLoginID,@SpPassword,@SpName,@SpContact,@SpPhone)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL,con);
                cmd.Parameters.AddWithValue("@SpID",spID);
                cmd.Parameters.AddWithValue("@SpLoginID", loginid);
                cmd.Parameters.AddWithValue("@SpPassword", password);
                cmd.Parameters.AddWithValue("@SpName", name);
                cmd.Parameters.AddWithValue("@SpContact", contact);
                cmd.Parameters.AddWithValue("@SpPhone", phone);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("注册成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
