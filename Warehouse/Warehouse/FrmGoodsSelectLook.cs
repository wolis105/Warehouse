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
    public partial class FrmGoodsSelectLook : Form
    {
        public FrmGoodsSelectLook()
        {
            InitializeComponent();
        }

        public FrmGoodsSelectLook(string gdID, string gdName, string gdType, string gdSpecification, string gdUnit)
        {
            InitializeComponent();
            this.gdID = gdID;
            this.gdName = gdName;
            this.gdType = gdType;
            this.gdSpecification = gdSpecification;
            this.gdUnit = gdUnit;
        }
        private string gdID = null;
        private string gdName = null;
        private string gdType = null;
        private string gdSpecification = null;
        private string gdUnit = null;

        private void FrmGoodsSelectLook_Load(object sender, EventArgs e)
        {
            string strCon = "server=SC-201608292202;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select sum(DlCount) from Deliver where GdID=@GdID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", gdID);

                con.Open();

                int dlCount = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                this.label2.Text = "0";                         //供货数量
                this.label4.Text = "供货";                      //类型（供货）
                this.label6.Text = gdName;                      //显示商品名
                this.label8.Text = gdType;                      //显示商品类别
                this.label10.Text = gdSpecification;            //显示商品规格
                this.label12.Text = gdUnit;                     //计量单位
                this.label14.Text = dlCount.ToString();         //剩余数量
                //this.label16.Text = pDCount.ToString();         //供应商
            }
        }
    }
}
