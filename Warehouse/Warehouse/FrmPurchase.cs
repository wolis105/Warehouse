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
    public partial class FrmPurchase : Form
    {
        public FrmPurchase()
        {
            InitializeComponent();
        }
       
        private string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";
        public string rid = null;
        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            string strSQL = "select WhName from Warehouse";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string whName = reader.GetString(reader.GetOrdinal("WhName"));
                    this.comboBox1.Items.Add(whName);
                }
                reader.Close();

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rid = Guid.NewGuid().ToString();
            DateTime PcDate = DateTime.Now;

            string whName = this.comboBox1.Text;
            if (whName == "")
            {
                errorProvider1.SetError(comboBox1, "请选择仓库！");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            string strSQL = "insert into Purchase(RID,PcDate,WhID)"
                + "values(@RID,@PcDate,(select WhID from Warehouse where WhName=@WhName))";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@RID", rid);
                cmd.Parameters.AddWithValue("@PcDate", PcDate);
                cmd.Parameters.AddWithValue("@WhName", whName);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("添加入库单成功！");
                    FrmAdd frm1 = (FrmAdd)this.Owner;
                    //注意 如果textBox1是放在panel1中的 则先找panel1 再找textBox1
                    //((TextBox)frm1.Controls["textBox1"]).Text = rid;
                    frm1.stu(rid);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加入库单失败！");
                }

                con.Close();
            }
        }
    }
}
