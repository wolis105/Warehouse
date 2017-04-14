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
    public partial class FrmUpdate_Pwd : Form
    {
        public FrmUpdate_Pwd()
        {
            InitializeComponent();
        }
        public FrmUpdate_Pwd(string a)
        {
            InitializeComponent();
            this.id = a;
        }
        private string id;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pwd);
            this.errorProvider1.Clear();
            if (this.txtOld.Text == "")
            {
                this.errorProvider1.SetError(this.txtOld, "原密码不能为空！");
            }
            else
            {
                string strSQL = "select count(*) from Clerk where CILojinID=@CILojinID and CIPassword=@CIPassword";
                object obj = null;
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CILojinID", id);
                    cmd.Parameters.AddWithValue("@CIPassword", this.txtOld.Text);
                    con.Open();
                    obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        int count = Convert.ToInt32(obj);
                        //MessageBox.Show(count.ToString());
                        //MessageBox.Show(f.txtName.Text);
                        if (count != 1)
                        {
                            this.errorProvider1.SetError(this.txtOld, "原密码错误！");
                            //MessageBox.Show("原密码错误！");
                        }
                        else
                        {
                            if (this.txtNew.Text == "")
                            {
                                this.errorProvider1.SetError(this.txtNew, "新密码不能为空！");
                            }
                            else
                            {

                                if (this.txtAgain.Text == "")
                                {
                                    this.errorProvider1.SetError(this.txtAgain, "确认密码不能为空！");
                                }
                                else
                                {
                                    if (this.txtAgain.Text != this.txtNew.Text)
                                    {
                                        this.errorProvider1.SetError(this.txtAgain, "两次密码输入不一致！");
                                    }
                                    else
                                    {
                                        DialogResult dr = MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                                        if (dr == DialogResult.OK)
                                        {
                                            string strSQL2 = "update Clerk set CIPassword=@CIPassword where CILojinID=@CILojinID";
                                            SqlCommand cmd1 = new SqlCommand(strSQL2, con);
                                            cmd1.Parameters.AddWithValue("@CILojinID", id);
                                            cmd1.Parameters.AddWithValue("@CIPassword", this.txtNew.Text);
                                            object obj1 = cmd1.ExecuteNonQuery();
                                            if (obj1 != null)
                                            {
                                                int count1 = Convert.ToInt32(obj1);
                                                MessageBox.Show(count1.ToString());
                                                MessageBox.Show(this.txtNew.Text);
                                                MessageBox.Show(id);
                                                if (count1 == 1)
                                                {
                                                    MessageBox.Show("修改成功！");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("修改失败！");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("已取消操作");
                                        }
                                    }
                                }
                            }
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}

