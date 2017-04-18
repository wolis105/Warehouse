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
    public partial class FrmExtract : Form
    {
        public FrmExtract()
        {
            InitializeComponent();
        }
        public FrmExtract(string a)
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

        private void FrmExtract_Load(object sender, EventArgs e)
        {
            string strSQL = "select distinct WhName from Warehouse";
            string strSQL2 = "select  GdName from Goods";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.cboWarehouse.Items.Add(reader.GetString(reader.GetOrdinal("WhName")));
                }
                reader.Close();

                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    this.cboGoods.Items.Add(reader2.GetString(reader2.GetOrdinal("GdName")));
                }
                reader2.Close();
                con.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.cboGoods.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboGoods, "未选择进货商品！");
                return;
            }
            if (this.txtNumber.Text.Trim() == ""|| this.txtNumber.Text.Trim()=="0")
            {
                this.errorProvider1.SetError(this.txtNumber, "进货数量不能为零或空！");
                return;
            }
            else
            {
                if (!Regex.IsMatch(this.txtNumber.Text, @"^\d+$") )
                {
                    this.errorProvider1.SetError(this.txtNumber, "请输入数字格式！");
                    return;
                }
            }
            if (this.cboWarehouse.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboGoods, "未选择供货仓库！");
                return;
            }

            string etID = Guid.NewGuid().ToString();
            string edID = Guid.NewGuid().ToString();
            DateTime etDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
            string gdName= this.cboGoods.Text.Trim();
            string edcount=this.txtNumber.Text.Trim();
            string whName = this.cboWarehouse.Text.Trim();
            string gdID = null;
            string whID = null;
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
                //仓库ID
                string strSQL2 = "select WhID from Warehouse where WhName=@WhName";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@WhName", whName);
                object obj2 = cmd2.ExecuteScalar();
                if (obj2 != null)
                {
                     whID = obj2.ToString();
                   // MessageBox.Show(whID);
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

                string strSQLe = "insert into Extract(EtID,EtDate,WhID,ShID) values(@EtID,@EtDate,@WhID,@ShID)";          
                SqlCommand cmde = new SqlCommand(strSQLe, con);
                cmde.Parameters.AddWithValue("@EtID", etID);
                cmde.Parameters.AddWithValue("@EtDate", etDate);
                cmde.Parameters.AddWithValue("@WhID", whID);
                cmde.Parameters.AddWithValue("@ShID", shID);
                object obje = cmde.ExecuteNonQuery();

                string strSQLd = "insert into ExtractDetail(EDID,EDCount,EtID,GdID) values(@EDID,@EDCount,@EtID,@GdID)";
                SqlCommand cmdd = new SqlCommand(strSQLd, con);
                cmdd.Parameters.AddWithValue("@EDID", edID);
                cmdd.Parameters.AddWithValue("@EDCount", edcount);
                cmdd.Parameters.AddWithValue("@EtID", etID);
                cmdd.Parameters.AddWithValue("@GdID", gdID);         
                object objd = cmdd.ExecuteNonQuery();

                if (obje != null && objd != null)
                {
                    if(Convert.ToInt32(obje)==1&& Convert.ToInt32(objd) == 1)
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
    }
}
