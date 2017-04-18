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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        string id = null;
        private void tsmiWarehouse_Click(object sender, EventArgs e)
        {
            FrmWarehouseAdd f = new FrmWarehouseAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)
        {
            FrmAdminAdd f = new FrmAdminAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "管理员")
            {
                string adminLoginID = this.textBox1.Text.Trim();

                string adminLoginPassword = this.textBox2.Text.Trim();

                bool isValid = false;
                if (this.textBox1.Text == "")
                {
                    this.errorProvider1.SetError(textBox1, "内容不能为空！");
                }
                if (this.textBox2.Text == "")
                {
                    this.errorProvider1.SetError(textBox2, "内容不能为空！");

                }

                string strSQL = "sp_AdminLogin";
                object obj = db.ExecuteScalar(strSQL, CommandType.StoredProcedure, new SqlParameter("@WALojinID", adminLoginID));
                if (obj != null)
                {
                    string count = Convert.ToString(obj);
                    if (count.Trim() == this.textBox2.Text.Trim())
                    {
                        isValid = true;
                    }
                }
                if (isValid)
                {
                    FrmSelectAdmin f = new FrmSelectAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码不正确！");
                }
            }
                if (comboBox1.Text.Trim() == "供应商")
                {
                    string strSQL = "select * from Supplier where  SpLoginID=@SpLoginID";
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SpLoginID", textBox1.Text.Trim());
                        string pw = null;
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            pw = reader.GetString(reader.GetOrdinal("SpPassword"));
                            id = reader.GetString(reader.GetOrdinal("SpID"));
                        }
                        if (pw == textBox2.Text.Trim())
                        {
                            MessageBox.Show("登录成功！");
                            FrmSupplier f = new FrmSupplier(id);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();

                        }
                        else
                        {
                            MessageBox.Show("登录失败！");
                        }
                        con.Close();
                    }
               
            }
        }

        private void 注册供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin f = new FrmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        
        
    }
}
