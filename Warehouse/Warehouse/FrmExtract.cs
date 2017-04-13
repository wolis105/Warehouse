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
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExtract_Load(object sender, EventArgs e)
        {
            string strSQL = "select ShName from Shop";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string shName = reader.GetString(reader.GetOrdinal("ShName"));
                    this.cboShName.Items.Add(shName);
                }
                reader.Close();

                con.Close();
            }
            strSQL = "select GdName from Goods";
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
            strSQL = "select WhName from Warehouse";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string whName = reader.GetString(reader.GetOrdinal("WhName"));
                    this.cboWhName.Items.Add(whName);
                }
                reader.Close();

                con.Close();
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string str = this.txtNumber.Text.Trim();
            if (Regex.IsMatch(str, "^[\\d]+$") == false || str == "")
            {
                errMistake.SetError(txtNumber, "货品数量只能输数字且不能为空！");
                return;
            }

            string etID = Guid.NewGuid().ToString();
            DateTime etDate =Convert.ToDateTime( this.dtpTime.Text.Trim());
            string whName = this.cboWhName.Text.Trim();
            string shName = this.cboShName.Text.Trim();
            string edID = Guid.NewGuid().ToString();
            int edCount =Convert.ToInt32(this.txtNumber.Text.Trim());
            string gdName = this.cboGdName.Text.Trim();
            string esID = etID;
            string strSQL = "sp_Insert";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EtID", etID);
                cmd.Parameters.AddWithValue("@EtDate", etDate);
                cmd.Parameters.AddWithValue("@WhName", whName);
                cmd.Parameters.AddWithValue("@ShName", shName);
                cmd.Parameters.AddWithValue("@EDID", edID);
                cmd.Parameters.AddWithValue("@EDCount", edCount);
                cmd.Parameters.AddWithValue("@ESID", esID);
                cmd.Parameters.AddWithValue("@GdName", gdName);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("增加成功！");
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
            }
            this.Close();

        }
    }
}
