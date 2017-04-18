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
    public partial class FrmQuery_Shop : Form
    {
        public FrmQuery_Shop()
        {
            InitializeComponent();
        }
        private string listType = null;
        private string gdName = null;
        private string gdNumber = null;
        private string dateList = null;
        private string whName = null;
        private string ceName = null;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lvShow.Items.Clear();
            this.errorProvider1.Clear();
            if (this.cboList.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.cboList, "未选择印单类型！");
                return;
            }



            if (this.cboList.Text == "销售单")
            {
                Sales();
            }
            else if (this.cboList.Text == "进货单")
            {
                Extract();
            }
            else
            {
                Sales();
                Extract();
            }
        }

        private void FrmQuery_Shop_Load(object sender, EventArgs e)
        {
            //string strSQL2 = "select  GdName from Goods";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            //    con.Open();
            //    SqlDataReader reader2 = cmd2.ExecuteReader();
            //    while (reader2.Read())
            //    {
            //        this.cboGdName.Items.Add(reader2.GetString(reader2.GetOrdinal("GdName")));
            //    }
            //    reader2.Close();
            //    con.Close();
            //}
        }
        private void Sales()
        {
            whName = "————";
            listType = "销售单";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strSQL = "select g.GdName,d.SDCount,l.SlRecordListDate,c.CeName from Sales l inner join SalesDetail d on d.SlID = l.SlID inner join Client c on c.CeID = l.CeID inner join Goods g on g.GdID = d.GdID";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    gdNumber = reader.GetInt32(reader.GetOrdinal("SDCount")).ToString();
                    dateList = reader.GetDateTime(reader.GetOrdinal("SlRecordListDate")).ToString();
                    ceName = reader.GetString(reader.GetOrdinal("CeName"));
                }
                reader.Close();
                ListViewItem item = new ListViewItem(listType);
                item.SubItems.Add(gdName);
                item.SubItems.Add(gdNumber);
                item.SubItems.Add(dateList);
                item.SubItems.Add(whName);
                item.SubItems.Add(ceName);
                this.lvShow.Items.Add(item);
                con.Close();
            }
        }
        private void Extract()
        {
            ceName = "————";
            listType = "进货单";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                string strSQL = "select g.GdName,d.EDCount,l.EtDate,c.WhName from Extract l inner join ExtractDetail d on d.EtID = l.EtID inner join Warehouse c on c.WhID = l.WhID inner join Goods g on g.GdID = d.GdID";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    gdNumber = reader.GetInt32(reader.GetOrdinal("EDCount")).ToString();
                    dateList = reader.GetDateTime(reader.GetOrdinal("EtDate")).ToString();
                    whName = reader.GetString(reader.GetOrdinal("WhName"));
                }
                reader.Close();
                ListViewItem item = new ListViewItem(listType);
                item.SubItems.Add(gdName);
                item.SubItems.Add(gdNumber);
                item.SubItems.Add(dateList);
                item.SubItems.Add(whName);
                item.SubItems.Add(ceName);
                this.lvShow.Items.Add(item);
                con.Close();
            }
        }
    }
}
