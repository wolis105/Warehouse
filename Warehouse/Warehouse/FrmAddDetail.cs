using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FrmAddDetail : Form
    {
        public FrmAddDetail()
        {
            InitializeComponent();
        }

        private void FrmAddDetail_Load(object sender, EventArgs e)
        {
            string strCon = "server=DEEP-20161031LT;database=Warehouse_New;uid=sa;password=123;";
            string strSQL = "select GdName,PcDate,PDCount from PurchaseDetail p inner join Goods c on p.GdID=c.GdID inner join Purchase u on p.RID=u.RID";
        }
    }
}
