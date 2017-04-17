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

        private void 注册供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin f = new FrmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        string id = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim()=="供应商")
            {
                string strSQL = "select * from Supplier where  SpLoginID=@SpLoginID";
                using (SqlConnection con =new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL,con);
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
                        FrmSupplier f = new Warehouse.FrmSupplier(id);
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
    }
}
