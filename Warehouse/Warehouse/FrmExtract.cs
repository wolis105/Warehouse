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

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string str = this.txtNumber.Text.Trim();
            if (Regex.IsMatch(str, "^[\\d]+$") == false || str == "")
            {
                errMistake.SetError(txtNumber, "货品数量只能输数字且不能为空！");
                return;
            }
            string strSQL1 = "sp_Count";
            object obj = null;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@GdName", this.cboGdName.Text.Trim());

                con.Open();
                obj = cmd1.ExecuteScalar();
                MessageBox.Show(obj.ToString());
                con.Close();
            }
            if (obj.ToString().Length>0)
            {

                string etID = Guid.NewGuid().ToString();
                DateTime etDate = Convert.ToDateTime(this.dtpTime.Text.Trim());
                string whName = this.cboWhName.Text.Trim();
                string shName = this.cboShName.Text.Trim();
                string edID = Guid.NewGuid().ToString();
                int edCount = Convert.ToInt32(this.txtNumber.Text.Trim());
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
                        MessageBox.Show("提货成功！");
                    }
                    else
                    {
                        MessageBox.Show("提货失败！");
                    }
                }

            }
            else
            {
                MessageBox.Show("对不起！没有该货品！");
            }
            this.Close();
        }

    private void cboGdName_TextChanged(object sender, EventArgs e)
    {
        this.cboShName.Items.Clear();
        string strSQL = "sp_SelectOne";
        using (SqlConnection con = new SqlConnection(strCon))
        {
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GdName", this.cboGdName.Text.Trim());
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string shName = reader.GetString(reader.GetOrdinal("ShName"));

                //cboShName.Text = shName;
                cboShName.Items.Add(shName);
            }
            if (cboShName.Items != null)
            {
                cboShName.Text = cboShName.Items[0].ToString();
            }
            reader.Close();
            con.Close();
        }
        this.cboWhName.Items.Clear();
        strSQL = "sp_SelectOnly";
        using (SqlConnection con = new SqlConnection(strCon))
        {
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GdName", this.cboGdName.Text.Trim());
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string whName = reader.GetString(reader.GetOrdinal("WhName"));

                //cboWhName.Text= whName;
                cboWhName.Items.Add(whName);
            }
            if (cboWhName.Items != null)
            {
                cboWhName.Text = cboWhName.Items[0].ToString();
            }
            reader.Close();
            con.Close();
        }
    }
}
}
