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
    public partial class FrmAdminAdd : Form
    {
        public FrmAdminAdd()
        {
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private void FrmAdminAdd_Load(object sender, EventArgs e)
        {
            string strSQL = "sp_WarehouseName";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    string WhName = reader.GetString(reader.GetOrdinal("WhName"));
                    this.cboWarehouseName.Items.Add(WhName);
                }
                reader.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string WAID = Guid.NewGuid().ToString();

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

            string WAPassword = this.txtPassword.Text.Trim();
            if (this.txtPassword.Text == "")
            {
                this.errorProvider1.SetError(txtPassword, "用户密码不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WAName = this.txtName.Text.Trim();
            if (this.txtPassword.Text == "")
            {
                this.errorProvider1.SetError(txtPassword, "管理员姓名不能为空！");
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

            string strSQL = "sp_AdminAdd";
                int rows = db.ExecuteNonQuery(strSQL, CommandType.StoredProcedure,
                    new SqlParameter("@WAID", WAID),
                     new SqlParameter("@WALojinID", WALojinID),
                new SqlParameter("@WAPassword", WAPassword),
                new SqlParameter("@WAName", WAName),
                new SqlParameter("@WACardID", WACardID),
                new SqlParameter("@WASex", WASex),
                new SqlParameter("@WAphone", WAphone),
                new SqlParameter("@WhName", WhName));
                if (rows > 0)
                {
                    MessageBox.Show("增加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("增加失败！");
                }
        }
    }
}

