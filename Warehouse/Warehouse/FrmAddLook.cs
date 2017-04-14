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
    public partial class FrmAddLook : Form
    {
        public FrmAddLook()
        {
            InitializeComponent();
        }
        
        public FrmAddLook(string gdName, string number, string rid)
        {
            InitializeComponent();
            this.gdName = gdName;
            this.number = number;
            this.rid = rid;
        }

        public FrmAddLook(string time)
        {
            InitializeComponent();
            this.time = time;
        }

        private string gdName = null;
        private string number = null;
        private string rid = null;
        private string time = null;

        private void FrmAddLook_Load(object sender, EventArgs e)
        {
            string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select sum(PDCount) from PurchaseDetail where GdID=(select GdID from Goods where GdName=@GdName)";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", gdName);

                con.Open();

                int pDCount = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                this.lblNumber.Text = number;                   //入库货物数量
                this.label4.Text = "入库";                      //类型（入库或出库）
                this.label6.Text = gdName;                      //显示商品名
                if (this.label8.Text == "label8")
                {
                    this.label8.Text = DateTime.Now.ToString();
                }
                     //入库的时间

                this.label10.Text = rid;                        //入库明细单单号（方便查找）
                this.label12.Text = pDCount.ToString();         //仓库货物总数量
            }
        }
    }
}
