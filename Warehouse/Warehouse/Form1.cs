﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 注册供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin f = new FrmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
