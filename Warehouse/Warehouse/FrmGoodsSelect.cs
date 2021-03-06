﻿using System;
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
    public partial class FrmGoodsSelect : Form
    {
        public FrmGoodsSelect()
        {
            InitializeComponent();
        }

        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //string gdID = Convert.ToString(this.listView1.SelectedItems[0].Tag);
            //string gdName = this.listView1.SelectedItems[0].Text;
            //string gdType = this.listView1.SelectedItems[0].SubItems[1].Text;
            //string gdSpecification = this.listView1.SelectedItems[0].SubItems[2].Text;
            //string gdUnit = this.listView1.SelectedItems[0].SubItems[3].Text;
            
            //FrmGoodsSelectLook frm = new FrmGoodsSelectLook(gdID, gdName, gdType, gdSpecification, gdUnit);
            //frm.Size = this.Size;
            //frm.Location = this.Location;
            //this.Hide();
            //frm.ShowDialog();
            //frm.Activate();
            //this.Location = frm.Location;
            //this.Show();
        }

        private void FrmGoodsSelect_Load(object sender, EventArgs e)
        {
            string strSQL ="select GdName,GdType,GdSpecification,GdUnit,sum(DlCount)/count(distinct PDID),sum(PDCount)/count(distinct DlID) from Goods g "
                         +"left join Deliver d on g.GdID=d.GdID "
                         +"left join PurchaseDetail p on g.GdID=p.GdID "
                         +"group by GdName,GdType,GdSpecification,GdUnit";
           

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gdName = reader.GetString(reader.GetOrdinal("GdName"));
                    string gdType = reader.GetString(reader.GetOrdinal("GdType"));
                    string gdSpecification = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string gdUnit = reader.GetString(reader.GetOrdinal("GdUnit"));
                    int dlCount = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    int pDCount = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                    ListViewItem item = new ListViewItem(gdName);
                    item.SubItems.Add(gdType);
                    item.SubItems.Add(gdSpecification);
                    item.SubItems.Add(gdUnit);
                    item.SubItems.Add(dlCount - pDCount == 0 ? "0" : (dlCount- pDCount).ToString());

                    this.listView1.Items.Add(item);
                }
                reader.Close();

                con.Close();
            }
        }
    }
}
