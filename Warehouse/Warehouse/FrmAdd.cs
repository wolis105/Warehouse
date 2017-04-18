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

        private string str = null;

        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private bool flag = false;
        private bool flag1 = false;

        public void stu(string str1)
        {
            str = str1;
        }

        /// <summary>
        /// 商品入库到仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (str != null)
            {
                //string strSQL2 = "select sum(DlCount) from Deliver"
                //               + "where GdID = (select GdID from Goods where GdName = @GdName)"
                //               + "union"
                //               + "select sum(PDCount) from PurchaseDetail"
                //               + "where GdID = (select GdID from Goods where GdName = @GdName)";

                string strSQL2 = " select sum(PDCount),(select sum(DlCount) from Deliver " 
                               + "where GdID = (select GdID from Goods where GdName = @GdName)) from PurchaseDetail "
                               + "where GdID = (select GdID from Goods where GdName = @GdName)";

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL2, con);
                    cmd.Parameters.AddWithValue("@GdName", goodsName);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int pDCount = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        int dlCount = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        if (Convert.ToInt32(number) > dlCount - pDCount)
                        {
                            MessageBox.Show($"货物供应不足,请联系供应商！！剩余{dlCount - pDCount}");
                            return;
                        }
                    }
                    reader.Close();

                    con.Close();
                }


                string pdID = Guid.NewGuid().ToString();
                DateTime birthday = DateTime.Now;

                string strSQL = "insert into PurchaseDetail(PDID,PDCount,RID,GdID)"
                    + "values(@PDID,@PDCount,@RID,(select GdID from Goods where GdName=@GdName))";

                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@PDID", pdID);
                    cmd.Parameters.AddWithValue("@PDCount", number);
                    cmd.Parameters.AddWithValue("@RID", str);
                    cmd.Parameters.AddWithValue("@GdName", goodsName);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("入库成功！");
                        flag1 = true;
                    }
                    else
                    {
                        MessageBox.Show("入库失败！");
                    }

                    con.Close();
                }

                if (flag1)
                {
                    string strSQL1 = "update Purchase set PcDate=@PcDate where RID=@RID";

                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        SqlCommand cmd = new SqlCommand(strSQL1, con);
                        cmd.Parameters.AddWithValue("@PcDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@RID", str);

                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("请先建立入库单！！！");
            }
        }

        /// <summary>
        /// 提取供应商提供所有商品的商品名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                reader.Close();

                con.Close();
            }
        }

        /// <summary>
        /// 查找该仓库中是否存在相同的商品名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGoodsName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.cboGoodsName.Items.Count; i++)
            {
                if (this.cboGoodsName.Items[i].ToString() == this.cboGoodsName.Text.Trim())
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
        }

        private void 货物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGoodsSelect frm = new FrmGoodsSelect();
            frm.Size = this.Size;
            frm.Location = this.Location;
            this.Hide();
            frm.ShowDialog();
            frm.Activate();
            this.Location = frm.Location;
            this.Show();
        }

        /// <summary>
        /// 查看货物入库明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 入库明细ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddDetail frm = new FrmAddDetail();
            frm.Size = this.Size;
            frm.Location = this.Location;
            this.Hide();
            frm.ShowDialog();
            frm.Activate();
            this.Location = frm.Location;
            this.Show();
        }

        private void 新建入库单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurchase frm = new FrmPurchase();
            frm.Location = this.Location;
            this.Hide();
            frm.ShowDialog(this);
            frm.Activate();
            this.Location = frm.Location;
            this.Show();
        }

        private void 入库单查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPurchaseSelect frm = new FrmPurchaseSelect();
            frm.Location = this.Location;
            this.Hide();
            frm.ShowDialog(this);
            frm.Activate();
            this.Location = frm.Location;
            this.Show();
        }
    }
}
