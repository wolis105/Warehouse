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
    public partial class FrmRemove : Form
    {
        public FrmRemove(string guid)
        {
            this.guid = guid;
            InitializeComponent();
        }
        private string guid = null;
        private string strCon = @"server=.\SQL2014;database=Warehouse_New;uid=sa;password=123;";
        private void FrmRemove_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guid))
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string strSQL = "update CargoManagement set CargoQuantity-=@cargoQuantity where CargoName=@cargoName";
                    SqlCommand cmd2 = new SqlCommand(strSQL, con);
                    cmd2.Parameters.AddWithValue("@cargoQuantity", Convert.ToInt32(this.textBox1.Text));
                    cmd2.Parameters.AddWithValue("@cargoName", this.comboBox1.Text.Trim());

                    int row = cmd2.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("出库成功！");
                    }
                    else
                    {
                        MessageBox.Show("出库失败！");
                    }
                    this.textBox1.Clear();
                    con.Close();
                }
            }




                //string strSQL = "sp_Modify";
                //using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure,
                //    new SqlParameter("@StudentGuid", guid)))
                //{
                //    while (reader.Read())
                //    {
                //        string loginId = reader.GetString(reader.GetOrdinal("LoginId"));
                //        int userStateId = reader.GetInt32(reader.GetOrdinal("UserStateId"));
                //        string className = reader.GetString(reader.GetOrdinal("ClassName"));
                //        string studentName = reader.GetString(reader.GetOrdinal("StudentName"));
                //        string sex = reader.GetString(reader.GetOrdinal("Sex"));
                //        string address = reader.GetString(reader.GetOrdinal("Address"));


                //        this.lblLodinID.Text = loginId;
                //        this.lblName.Text = studentName;
                //        this.lblAdress.Text = address;
                //        this.lblSex.Text = sex;

                //        this.lblState.Text = userStateId == 1 ? "有效" : "无效";
                //        this.lblClassName.Text = className;
                //    }
                //    reader.Close();
                //}
        }
    }
}
