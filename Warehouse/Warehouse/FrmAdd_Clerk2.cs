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
    public partial class FrmAdd_Clerk2 : Form
    {
        public FrmAdd_Clerk2()
        {
            InitializeComponent();
        }
        public FrmAdd_Clerk2(string a, string b, string c, string d, string e)
        {
            InitializeComponent();
            this.clName = a;
            this.clSex = b;
            this.clIdentity = c;
            this.clPhone = d;
            this.shID = e;
        }
        string clID = Guid.NewGuid().ToString();
        string clName;
        string clSex;
        string clIdentity;
        string clPhone;
        string shID;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void FrmAdd_Clerk2_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnFinally_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.txtCount.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtCount, "账号不能为空！");
                return;
            }
            if (this.txtPwd.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtPwd, "密码不能为空！");
                return;
            }
            if (this.txtAgain.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtAgain, "确认密码不能为空！");
                return;
            }
            if (this.txtPwd.Text.Trim() != this.txtAgain.Text.Trim())
            {
                this.errorProvider1.SetError(this.txtAgain, "两次密码输入不一致！");
                return;
            }

            string clLoginID = this.txtCount.Text.Trim();
            string clLoginPwd = this.txtPwd.Text.Trim();

            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strSQL = "select count(*) from Clerk where ClLoginID=@ClLoginID";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ClLoginID", clLoginID);
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    int count = Convert.ToInt32(obj);
                    if (count == 1)
                    {
                        this.errorProvider1.SetError(this.txtCount, "此账号已存在！");
                        return;
                    }
                    else
                    {
                        string strSQL2 = "insert into Clerk(ClID,ClLoginID,ClLoginPwd,ClName,ClSex,ClIdentity,ClPhone,ShID) values (@ClID,@ClLoginID,@ClLoginPwd,@ClName,@ClSex,@ClIdentity,@ClPhone,@ShID)";
                        SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                        cmd2.Parameters.AddWithValue("@ClID", clID);
                        cmd2.Parameters.AddWithValue("@ClLoginID", clLoginID);
                        cmd2.Parameters.AddWithValue("@ClLoginPwd", clLoginPwd);
                        cmd2.Parameters.AddWithValue("@ClName", clName);
                        cmd2.Parameters.AddWithValue("@ClSex", clSex);
                        cmd2.Parameters.AddWithValue("@ClIdentity", clIdentity);
                        cmd2.Parameters.AddWithValue("@ClPhone", clPhone);
                        cmd2.Parameters.AddWithValue("@ShID", shID);
                        object obj2 = cmd2.ExecuteNonQuery();
                        if (obj2 != null)
                        {
                            int count2 = Convert.ToInt32(obj2);
                            if (count2 == 1)
                            {
                                MessageBox.Show("注册成功！", "提示");
                                btnClose_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("注册失败！", "提示");
                            }
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
