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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string goodsName = this.cboGoodsName.Text;
            if (goodsName == "")
            {
                errorProvider1.SetError(cboGoodsName, "请选择商品名！");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            string number = this.txtNumber.Text.Trim();
            if (number == "")
            {
                errorProvider1.SetError(txtNumber, "商品数量不能为空！");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            string pdID = Guid.NewGuid().ToString();
            string rID = Guid.NewGuid().ToString();
            DateTime birthday = DateTime.Now;

            string strSQL = "insert into Purchase(RID,PcDate,WhID)"
                + "values(@RID,@PcDate,@WhID)"
                + "insert into PurchaseDetail(PDID,PDCount,RID,GdID)"
                + "values(@PDID,@PDCount,@RID,(select GdID from Goods where GdName=@GdName))";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@PDID", pdID);
                cmd.Parameters.AddWithValue("@PDCount", number);
                cmd.Parameters.AddWithValue("@RID", rID);
                cmd.Parameters.AddWithValue("@GdName", goodsName);
                cmd.Parameters.AddWithValue("@PcDate", birthday);
                cmd.Parameters.AddWithValue("@WhID", 1);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("入库成功！");
                }
                else
                {
                    MessageBox.Show("入库失败！");
                }

                con.Close();
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            string strSQL = "select GdName from Goods";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    this.cboGoodsName.Items.Add(gdName);
                }

                con.Close();
            }
        }
    }
}
