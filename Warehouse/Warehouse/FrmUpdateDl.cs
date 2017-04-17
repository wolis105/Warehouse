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
    public partial class FrmUpdateDl : Form
    {
        public FrmUpdateDl()
        {
            InitializeComponent();
        }
        public FrmUpdateDl(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private string id = null;
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from  Goods where GdName=@GdName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                string msg=null;
                if (reader.Read())
                {
                     msg = reader.GetString(reader.GetOrdinal("GdID"));
                    MessageBox.Show(msg);
                }
                reader.Close();
                if (msg != null)
                {
                    strSQL = "update Deliver  set GdID=@GdID,DlCount=@DlCount  where DlID=@DlID";
                    using (SqlCommand cmd1 = new SqlCommand(strSQL, con))
                    {
                        cmd1.Parameters.AddWithValue("@DlCount", txtNum);
                        cmd1.Parameters.AddWithValue("@GdID", msg);
                        cmd1.Parameters.AddWithValue("@DlID", id);
                        int index = cmd.ExecuteNonQuery();
                        if (index > 0)
                        {
                            MessageBox.Show("修改成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！","1");
                            MessageBox.Show(msg);
                            MessageBox.Show(id);
                            MessageBox.Show(index.ToString());
                        }
                        //差一行参数


                    }
                }
                else
                {
                    MessageBox.Show("修改失败！", "2");
                }
                con.Close();
            }

            
        }

        private void FrmUpdateDl_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Deliver d left join Goods g on d.GdID=g.GdID where DlID=@DlID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DlID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string gName = reader.GetString(reader.GetOrdinal("GdName"));
                    int num = reader.GetInt32(reader.GetOrdinal("DlCount"));
                    cboName.Items.Add(gName);
                    txtNum.Text = num.ToString() ;
                    cboName.Text = cboName.Items[0].ToString();
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
