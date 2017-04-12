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
    public partial class FrmWarehouseUpdate : Form
    {
        public FrmWarehouseUpdate()
        {
            InitializeComponent();
        }
        public FrmWarehouseUpdate(string whID)
        {
            this.whID = whID;
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private string whID = null;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string WhID = this.whID;

            string WhName = this.txtName.Text.Trim();
            if(this.txtName.Text=="")
            {
                this.errorProvider1.SetError(txtName,"要修改的仓库名称不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WhAddress = this.txtAddress.Text.Trim();
            if (this.txtAddress.Text == "")
            {
                this.errorProvider1.SetError(txtAddress, "要修改的仓库位置不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
            string WhExplain = this.txtExplain.Text;
            string strSQL = "sp_WarehouseUpdate";
            int rows = db.ExecuteNonQuery(strSQL,CommandType.StoredProcedure,
                new SqlParameter("@WhID", WhID),
                new SqlParameter("@WhName", WhName),
                new SqlParameter("@WhAdress", WhAddress),
                new SqlParameter("@WhExplain", WhExplain));
            if(rows>0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void FrmWarehouseUpdate_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(whID))
            {

                string strSQL = "sp_UpdateLoad";
                using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WhID", whID)))
                {
                    while (reader.Read())
                    {
                        string WhName = reader.GetString(reader.GetOrdinal("WhName"));
                        string WhAddress = reader.GetString(reader.GetOrdinal("WhAdress"));
                        string WhExplain = reader.GetString(reader.GetOrdinal("WhExplain"));


                        this.txtName.Text = WhName;
                        this.txtAddress.Text = WhAddress;
                        this.txtExplain.Text = WhExplain;
                    }

                    reader.Close();
                }
            }
        }

    }
}
