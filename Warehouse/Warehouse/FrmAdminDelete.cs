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
    public partial class FrmAdminDelete : Form
    {
        public FrmAdminDelete()
        {
            InitializeComponent();
        }
        public FrmAdminDelete(string WAID)
        {
            this.WAID = WAID;
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private string WAID = null;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WAID))
            {
                string strSQL = "sp_AdminDelete";
                int row = db.ExecuteNonQuery(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAID", WAID));
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

        private void FrmAdminDelete_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WAID))
            {

                string strSQL = "sp_AdminUpdateLoad";
                using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAID", WAID)))
                {
                    while (reader.Read())
                    {
                        string WALojinID = reader.GetString(reader.GetOrdinal("WALojinID"));
                        string WAName = reader.GetString(reader.GetOrdinal("WAName"));
                        string WACardID = reader.GetString(reader.GetOrdinal("WACardID"));
                        string WASex = reader.GetString(reader.GetOrdinal("WASex"));
                        string WAphone = reader.GetString(reader.GetOrdinal("WAphone"));
                        string WhName = reader.GetString(reader.GetOrdinal("WhName"));


                        this.lblLogin.Text = WALojinID;
                        this.lblAdminnName.Text = WAName;
                        this.lblAdminCardID.Text = WACardID;
                        this.lblAdminSex.Text = WASex;
                        this.lblAdminPhonenumber.Text = WAphone;
                        this.lblAdminnWarehouseName.Text = WhName;
                    }
                    reader.Close();
                }
            }
        }
    }
}
