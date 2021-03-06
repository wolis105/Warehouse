﻿using System;
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
    public partial class FrmWarehouseAdd : Form
    {
        public FrmWarehouseAdd()
        {
            InitializeComponent();
        }
        private DBHelper db = new DBHelper();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string WhID = Guid.NewGuid().ToString();

            string WhName = this.txtName.Text.Trim();
            if(this.txtName.Text=="")
            {
                this.errorProvider1.SetError(txtName,"仓库姓名不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WhAddress = this.txtAddress.Text.Trim();
            if(this.txtAddress.Text=="")
            {
                this.errorProvider1.SetError(txtAddress,"仓库位置不能为空！");
                return;
            }
            else
            {
                this.errorProvider1.Clear();
            }

            string WhExplain = this.txtExplain.Text;

            string strSQL = "sp_WarehouseInsert";
            int rows = db.ExecuteNonQuery(strSQL,CommandType.StoredProcedure,
                new SqlParameter("WhID", WhID),
                new SqlParameter("WhName", WhName),
                new SqlParameter("WhAdress", WhAddress),
                new SqlParameter("WhExplain", WhExplain));
            if(rows>0)
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
