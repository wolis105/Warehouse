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
    public partial class FrmWarehouseDelete : Form
    {
        public FrmWarehouseDelete()
        {
            InitializeComponent();
        }
        public FrmWarehouseDelete(string whID)
        {
            this.whID = whID;
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private string whID = null;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(whID))
            {
                string strSQL = "sp_WarehouseDelete";
                int row = db.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@WhID", whID));
                if (row > 0)
                {
                    MessageBox.Show("删除成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void FrmWarehouseDelete_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(whID))
            {

                string strSQL = "sp_UpdateLoad";
                using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WhID", whID)))
                {
                    while (reader.Read())
                    {
                        string WhName = reader.GetString(reader.GetOrdinal("WhName"));
                        string WhAdress = reader.GetString(reader.GetOrdinal("WhAdress"));
                        string WhExplain = reader.GetString(reader.GetOrdinal("WhExplain"));


                        this.label1.Text = WhName;
                        this.label2.Text = WhAdress;
                        this.label3.Text = WhExplain;
                    }
                    reader.Close();
                }
            }
        }
    }
}
