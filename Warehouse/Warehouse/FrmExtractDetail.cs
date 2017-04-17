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
    public partial class FrmExtractDetail : Form
    {
        public FrmExtractDetail()
        {
            InitializeComponent();
        }
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void btnExtract_Click(object sender, EventArgs e)
        {
            FrmExtract f = new FrmExtract();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FrmExtractDetail_Load(object sender, EventArgs e)
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
                    this.cboGdName.Items.Add(gdName);
                }
                reader.Close();

                con.Close();
            }

        }
        
        //将商品表，销售店面表，提货表，提货明细表，仓库表五表进行连接。查出listView表里的各列
        private void btnQuery_Click(object sender, EventArgs e)
        {
                string goodsName = this.cboGdName.Text;
                if (goodsName == "查询所有")
                {
                    goodsName = "";
                }
                this.lvwSelectlist.Items.Clear();
                string strSQL = "sp_SelectAll";
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GdName", goodsName);
                con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string edID = reader.GetString(reader.GetOrdinal("EDID"));
                        DateTime etDate = reader.GetDateTime(reader.GetOrdinal("EtDate"));
                        int eDCount = reader.GetInt32(reader.GetOrdinal("EDCount"));
                        string gdName = reader.GetString(reader.GetOrdinal("GdName"));
                        string gdType = reader.GetString(reader.GetOrdinal("GdType"));
                        string gdSpecification = reader.GetString(reader.GetOrdinal("GdSpecification"));
                        string shName = reader.GetString(reader.GetOrdinal("ShName"));
                        string whName = reader.GetString(reader.GetOrdinal("WhName"));


                        ListViewItem item = new ListViewItem(edID);
                        item.SubItems.Add(eDCount.ToString());
                        item.SubItems.Add(etDate.ToString());
                        item.SubItems.Add(gdName);
                        item.SubItems.Add(shName);
                        item.SubItems.Add(gdType);
                        item.SubItems.Add(gdSpecification);
                        item.SubItems.Add(whName);

                        this.lvwSelectlist.Items.Add(item);
                    }
                    con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
