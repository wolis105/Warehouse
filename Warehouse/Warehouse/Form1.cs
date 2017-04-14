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
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void 注册供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "店员")
            {
                string strSQL = "select count(*) from Clerk where CILojinID=@CILojinID and CIPassword=@CIPassword";
                using (SqlConnection con=new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CILojinID", this.textBox1.Text);
                    cmd.Parameters.AddWithValue("@CIPassword", this.textBox2.Text);
                    con.Open();
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        int count = Convert.ToInt32(obj);
                        if (count == 1)
                        {
                            this.textBox2.Text = "";
                            FrmShop f = new FrmShop(this.textBox1.Text);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("账号密码错误！","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
