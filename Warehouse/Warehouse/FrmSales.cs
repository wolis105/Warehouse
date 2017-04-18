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
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }
        public FrmSales(string a)
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
            this.errorProvider1.Clear();
            if (this.cboGdName.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboGdName, "未选择销售商品！");
                return;
            }
            if (this.txtNumber.Text.Trim() == "" || this.txtNumber.Text.Trim() == "0")
            {
                this.errorProvider1.SetError(this.txtNumber, "销售数量不能为零或空！");
                return;
            }
            else
            {
                if (!Regex.IsMatch(this.txtNumber.Text, @"^\d+$"))
                {
                    this.errorProvider1.SetError(this.txtNumber, "请输入数字格式！");
                    return;
                }
            }
            if (this.cboClient.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboClient, "客户姓名不能为空！");
                return;
            }
            if (this.txtPhone.Text.Trim() != "")
            {
                if (!Regex.IsMatch(this.txtPhone.Text, @"^\d+$"))
                {
                    this.errorProvider1.SetError(this.txtPhone, "请输入数字格式！");
                    return;
                }
            }

            string slID= Guid.NewGuid().ToString();
            string sDID= Guid.NewGuid().ToString();
            string ceID = null;
            string gdName = this.cboGdName.Text.Trim();
            string slnumber=this.txtNumber.Text.Trim();
            DateTime slDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
            string ceName=this.cboClient.Text.Trim();
            string cePhone = this.txtPhone.Text.Trim() == "" ? ("未填写") : (this.txtPhone.Text.Trim());
            string ceAddress = this.txtAddress.Text.Trim() == "" ? ("未填写") : (this.txtAddress.Text.Trim());
            string gdID = null;
            string shID = null;

            using (SqlConnection con = new SqlConnection(strCon))
            {
                //商品ID
                string strSQL1 = "select GdID from Goods where GdName=@GdName";
                con.Open();
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@GdName", gdName);
                object obj1 = cmd1.ExecuteScalar();
                if (obj1 != null)
                {
                    gdID = obj1.ToString();
                }
                //客户ID
                string strSQL2 = "select CeID from Client where CeName=@CeName";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@CeName", this.cboClient.Text.Trim());
                object obj2 = cmd2.ExecuteScalar();
                if (obj2 != null) //该客户存在
                {
                    ceID = obj2.ToString();
                }
                else  //该客户不存在
                {
                   ceID = Guid.NewGuid().ToString();
                    string strSQL4 = "insert into Client(CeID,CeName,CeAddress,CePhone) values(@CeID,@CeName,@CeAddress,@CePhone)";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@CeID",ceID);
                    cmd4.Parameters.AddWithValue("@CeName",ceName);
                    cmd4.Parameters.AddWithValue("@CeAddress", ceAddress);
                    cmd4.Parameters.AddWithValue("@CePhone", cePhone);
                    object obj4 = cmd4.ExecuteNonQuery();
                    if (obj4 != null)
                    {
                        if (Convert.ToInt32(obj4) == 1)
                        {
                            MessageBox.Show("新增客户成功！","提示");
                        }
                        else
                        {
                            MessageBox.Show("新增客户失败！", "提示");
                        }
                    }
                }
                //店面ID
                string strSQL3 = "select ShID from Clerk  where ClLoginID = @id";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@id", id);
                object obj3 = cmd3.ExecuteScalar();
                if (obj3 != null)
                {
                    shID = obj3.ToString();
                }

                string strSQLe = "insert into Sales(SlID,SlRecordListDate,ShID,CeID) values(@SlID,@SlRecordListDate,@ShID,@CeID)";
                SqlCommand cmde = new SqlCommand(strSQLe, con);
                cmde.Parameters.AddWithValue("@SlID", slID);
                cmde.Parameters.AddWithValue("@SlRecordListDate", slDate);
                cmde.Parameters.AddWithValue("@ShID", shID);
                cmde.Parameters.AddWithValue("@CeID", ceID);
                object obje = cmde.ExecuteNonQuery();

                string strSQLd = "insert into SalesDetail(SDID,SDCount,GdID,SlID) values(@SDID,@SDCount,@GdID,@SlID)";
                SqlCommand cmdd = new SqlCommand(strSQLd, con);
                cmdd.Parameters.AddWithValue("@SDID", sDID);
                cmdd.Parameters.AddWithValue("@SDCount", slnumber);
                cmdd.Parameters.AddWithValue("@GdID", gdID);
                cmdd.Parameters.AddWithValue("@SlID", slID);
                object objd = cmdd.ExecuteNonQuery();

                if (obje != null && objd != null)
                {
                    if (Convert.ToInt32(obje) == 1 && Convert.ToInt32(objd) == 1)
                    {
                        MessageBox.Show("打印成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("打印成功！", "提示");
                    }
                }
                con.Close();
            }
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            string strSQL = "select distinct CeName from Client";
            string strSQL2 = "select  GdName from Goods";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.cboClient.Items.Add(reader.GetString(reader.GetOrdinal("CeName")));
                }
                reader.Close();

                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    this.cboGdName.Items.Add(reader2.GetString(reader2.GetOrdinal("GdName")));
                }
                reader2.Close();
                con.Close();
            }
        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL = "select CeAddress,CePhone from Client where CeName=@CeName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                cmd.Parameters.AddWithValue("@CeName", this.cboClient.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.txtAddress.Text=(reader.GetString(reader.GetOrdinal("CeAddress")));
                    this.txtPhone.Text = (reader.GetString(reader.GetOrdinal("CePhone")));
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
