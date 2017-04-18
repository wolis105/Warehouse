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
    public partial class FrmAdd_Shop : Form
    {
        public FrmAdd_Shop()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.txtName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtName, "店面名称不能为空！");
                return;
            }
            if (this.txtAddress.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtAddress, "店面地址不能为空！");
                return;
            }
            if (this.txtManagerName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtManagerName, "店长姓名不能为空！");
                return;
            }
            if (this.txtPhone.Text.Trim() != "")
            {
                if (Regex.IsMatch(this.txtPhone.Text.Trim(), @"^\d+$") == false)
                {
                    this.errorProvider1.SetError(this.txtPhone, "请输入数字格式！");
                    return;
                }
            }

            string shID = Guid.NewGuid().ToString();
            string shName = this.txtName.Text.Trim();
            string shAddress = this.txtAddress.Text.Trim();
            string shManegerName = this.txtManagerName.Text.Trim();
            string shPhone = this.txtPhone.Text.Trim() == "" ? ("未填写") : (this.txtPhone.Text.Trim());
            string strSQL = "insert into Shop(ShID,ShName,ShAdress,ShManagerName,ShPhone) values(@ShID,@ShName,@ShAdress,@ShManagerName,@ShPhone)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();       
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ShID", shID);
                cmd.Parameters.AddWithValue("@ShName", shName);
                cmd.Parameters.AddWithValue("@ShAdress", shAddress);
                cmd.Parameters.AddWithValue("@ShManagerName", shManegerName);
                cmd.Parameters.AddWithValue("@ShPhone", shPhone);
                object obj = cmd.ExecuteNonQuery();
                if (obj != null)
                {
                    int count = Convert.ToInt32(obj);
                    if (count == 1)
                    {
                        MessageBox.Show("添加成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示");
                    }
                }
                con.Close();
            }
        }

        private void FrmAdd_Shop_Load(object sender, EventArgs e)
        {

        }
    }
}