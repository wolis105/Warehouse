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
    public partial class FrmAddGoods : Form
    {
        public FrmAddGoods()
        {
            InitializeComponent();
        }
       private  string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123";
        private void FrmAddGoods_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(reader.GetOrdinal("GdName"));
                    cboName.Items.Add(name);
                }
                reader.Close();
                con.Close();
            }
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string guid = Guid.NewGuid().ToString();
            string name = cboName.Text.Trim();
            string type = txtType.Text.Trim();
            string sp = txtSpecification.Text.Trim();
            string unit = txtUnit.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
           {
                errorProvider1.SetError(cboName,"不能为空");
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
            string strSQL = "insert into Goods(GdID,GdName,GdType,GdSpecification,GdUnit) values (@GdID,@GdName,@GdType,@GdSpecification,@GdUnit)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdID", guid);
                cmd.Parameters.AddWithValue("@GdName", name);
                cmd.Parameters.AddWithValue("@GdType", type);
                cmd.Parameters.AddWithValue("@GdSpecification", sp);
                cmd.Parameters.AddWithValue("@GdUnit", unit);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("录入成功");
                }
                else
                {
                    MessageBox.Show("录入失败");
                
                 }
                
                con.Close();
            }
        }

        private void cboName_TextChanged(object sender, EventArgs e)
        {
            string strSQL = "select GdType,GdSpecification,GdUnit from Goods where GdName=@GdName";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@GdName", cboName.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string type = reader.GetString(reader.GetOrdinal("GdType"));
                    string sp = reader.GetString(reader.GetOrdinal("GdSpecification"));
                    string unit = reader.GetString(reader.GetOrdinal("GdUnit"));

                    txtType.Text = type;
                    txtUnit.Text = unit;
                    txtSpecification.Text = sp;


                    txtUnit.Enabled = false;
                    txtType.Enabled = false;
                    txtSpecification.Enabled = false;
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
