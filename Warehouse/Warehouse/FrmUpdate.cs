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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }
        public FrmUpdate(string WAID)
        {
            this.WAID = WAID;
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private string WAID = null;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string WAID = this.WAID;

            string WALojinID = this.txtLoginID.Text.Trim();
            if (this.txtLoginID.Text == "")
            {
                this.errorProvider1.SetError(txtLoginID, "用户名不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

           

            string WAName = this.txtName.Text.Trim();
            if (this.txtName.Text == "")
            {
                this.errorProvider1.SetError(txtName, "管理员姓名不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WACardID = this.txtCardID.Text.Trim();
            if (this.txtCardID.Text == "")
            {
                this.errorProvider1.SetError(txtCardID, "管理员密码不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WASex = this.txtSex.Text.Trim();
            if (this.txtSex.Text == "")
            {
                this.errorProvider1.SetError(txtSex, "管理员性别不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WAphone = this.txtPhonenumber.Text.Trim();

            string WhName = this.cboWarehouseName.Text.Trim();
            if (this.cboWarehouseName.Text == "")
            {
                this.errorProvider1.SetError(cboWarehouseName, "管理员所管理的仓库名称不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string strSQL = "sp_AdminUpdate";
            int rows = db.ExecuteNonQuery(strSQL, CommandType.StoredProcedure,
                new SqlParameter("@WALojinID", WALojinID),
                new SqlParameter("@WAName", WAName),
                new SqlParameter("@WACardID", WACardID),
                new SqlParameter("@WASex", WASex),
                new SqlParameter("@WAphone", WAphone),
                new SqlParameter("@WhName", WhName));
            if (rows > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }

        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(WAID))
            {
                string strSQL = "sp_AdminUpdateLoad";
                using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure,new SqlParameter("@WAID", WAID)))
            {
                    while (reader.Read())
                    {
                        string WALojinID = reader.GetString(reader.GetOrdinal("WALojinID"));
                        string WAName = reader.GetString(reader.GetOrdinal("WAName"));
                        string WACardID = reader.GetString(reader.GetOrdinal("WACardID"));
                        string WASex = reader.GetString(reader.GetOrdinal("WASex"));
                        string WAphone = reader.GetString(reader.GetOrdinal("WAphone"));
                        string WhName = reader.GetString(reader.GetOrdinal("WhName"));

                        this.txtLoginID.Text = WALojinID;
                        this.txtName.Text = WAName;
                        this.txtCardID.Text = WACardID;
                        this.txtSex.Text = WASex;
                        this.txtPhonenumber.Text = WAphone;
                        this.cboWarehouseName.Text = WhName;
                    }
                    reader.Close();
                }
            }
        }
    }
}
