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
using System.Text.RegularExpressions;

namespace Warehouse
{
    public partial class FrmAdd_Clerk1 : Form
    {
        public FrmAdd_Clerk1()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void button1_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.txtName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtName,"姓名不能为空！");
                return;
            }
            if (this.txtSex.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtSex, "性别不能为空！");
                return;
            }
            if (this.txtIdentity.Text.Trim().Length != 18)
            {
                this.errorProvider1.SetError(this.txtIdentity, "请输入18位的身份证号！");
                return;
            }
            if (this.cboShName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboShName, "未选择所在店面！");
                return;
            }
            if (this.txtPhone.Text.Trim() != "")
            {
                if (Regex.IsMatch(this.txtPhone.Text.Trim(), @"^\d$") == false)
                {
                    this.errorProvider1.SetError(this.txtPhone, "请输入数字格式！");
                    return; 
                }
            }

            string clName = this.txtName.Text.Trim();
            string clSex = this.txtSex.Text.Trim();
            string clIdentity = this.txtIdentity.Text.Trim();
            string clPhone = this.txtPhone.Text.Trim()==""?("未填写"):(this.txtPhone.Text.Trim());
            string shName = this.cboShName.Text.Trim();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strSQL3 = "select ShID from Shop where ShName=@ShName";
                con.Open();
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@ShName", shName);
                object obj3 = cmd3.ExecuteScalar();
                if (obj3 != null)
                {
                    string shID = obj3.ToString();
                    string strSQL = "select count(*) from Clerk where ClIdentity=@ClIdentity";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ClIdentity", clIdentity);
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        int count = Convert.ToInt32(obj);
                        if (count == 1)
                        {
                            this.errorProvider1.SetError(this.txtIdentity, "此身份证已存在！");
                            return;
                        }
                        else
                        {
                            FrmAdd_Clerk2 f = new FrmAdd_Clerk2(clName, clSex, clIdentity, clPhone, shID);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                    }
                }
                con.Close();
            }
        }

        private void FrmAdd_Clerk1_Load(object sender, EventArgs e)
        {
            string strSQL = "select distinct ShName from Shop";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.cboShName.Items.Add(reader.GetString(reader.GetOrdinal("ShName")));
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
