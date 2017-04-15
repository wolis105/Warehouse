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
    public partial class FrmAdminUpdatePassword : Form
    {
        public FrmAdminUpdatePassword()
        {
            InitializeComponent();
        }
        public FrmAdminUpdatePassword(string WAID)
        {
            this.WAID = WAID;
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private string WAID = null;
        private string password = null;
        private void FrmAdminUpdatePassword_Load(object sender, EventArgs e)
        {
            string strSQL = "sp_UpdatePassword";
            using (SqlDataReader reader = db.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@WAID", WAID)))
            {
                while (reader.Read())
                {
                    password = reader.GetString(reader.GetOrdinal("WAPassword"));
                }
                reader.Close();
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string oldPassword = this.txtOldPassword.Text.Trim();
            if(this.txtOldPassword.Text=="")
            {
                this.errorProvider1.SetError(txtOldPassword,"输入的旧密码不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string newPassword = this.txtNewPassword.Text.Trim();
            if(this.txtNewPassword.Text=="")
            {
                this.errorProvider1.SetError(txtNewPassword,"输入的新密码不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string surePassword = this.txtSure.Text.Trim();
           if(this.txtSure.Text!= this.txtNewPassword.Text)
            {
                this.errorProvider1.SetError(txtSure,"请保持确认密码与新密码一致！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }
           if(this.txtOldPassword.Text!= password)
            {
                MessageBox.Show("您输入的原密码不正确！");
            }
        }
    }
}
