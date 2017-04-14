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
        }
    }
}
