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
    public partial class FrmUpdateGoods : Form
    {
        public FrmUpdateGoods()
        {
            InitializeComponent();
        }
        public FrmUpdateGoods(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private string id = null;

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = cboName.Text.Trim();
            string type = txtType.Text.Trim();
            string sp = txtSpecification.Text.Trim();
            string unit = txtUnit.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(cboName, "不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                errorProvider1.SetError(txtType, "不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(sp))
            {
                errorProvider1.SetError(txtSpecification, "不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(unit))
            {
                errorProvider1.SetError(txtUnit, "不能为空"); return;
            }
            string strSQL = "update Goods set GdType=@GdType,GdSpecification=@GdSpecification,GdUnit=@GdUnit where GdID=@GdID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", id);
                cmd.Parameters.AddWithValue("@GdType", type);
                cmd.Parameters.AddWithValue("@GdSpecification", sp);
                cmd.Parameters.AddWithValue("@GdUnit", unit);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }

                con.Close();
            }
        }
        string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdateGoods_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods  where GdID=@GdID";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID",id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("GdName"));
                    string type = reader.GetString(reader.GetOrdinal("GdType"));
                    string sp = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string unit = reader.GetString(reader.GetOrdinal("GdUnit"));

                    cboName.Text = name;
                    txtType.Text = type;
                    txtUnit.Text = unit;
                    txtSpecification.Text = sp;
                    cboName.Enabled = false;
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
