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
    public partial class FrmAddLook : Form
    {
        public FrmAddLook()
        {
            InitializeComponent();
        }

        public FrmAddLook(string gdName, string number,string time,string rid)
        {
            InitializeComponent();
            this.gdName = gdName;
            this.number = number;
            this.time = time;
            this.rid = rid;
        }

        private string gdName = null;
        private string number = null;
        private string time = null;
        private string rid = null;

        private void FrmAddLook_Load(object sender, EventArgs e)
        {
            this.lblNumber.Text = number;
            this.label4.Text = "入库";
            this.label6.Text = gdName;
            this.label8.Text = time;
            this.label10.Text = rid;
        }
    }
}
