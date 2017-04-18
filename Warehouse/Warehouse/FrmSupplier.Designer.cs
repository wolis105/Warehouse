namespace Warehouse
{
    partial class FrmSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePw = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(548, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品ToolStripMenuItem,
            this.tsmiUpdateMsg,
            this.tsmiUpdatePw,
            this.tmsiClose});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem1.Text = "菜单";
            // 
            // tsmiUpdateMsg
            // 
            this.tsmiUpdateMsg.Name = "tsmiUpdateMsg";
            this.tsmiUpdateMsg.Size = new System.Drawing.Size(189, 26);
            this.tsmiUpdateMsg.Text = "修改供应商信息";
            this.tsmiUpdateMsg.Click += new System.EventHandler(this.tsmiUpdateMsg_Click);
            // 
            // tsmiUpdatePw
            // 
            this.tsmiUpdatePw.Name = "tsmiUpdatePw";
            this.tsmiUpdatePw.Size = new System.Drawing.Size(189, 26);
            this.tsmiUpdatePw.Text = "修改供应商密码";
            this.tsmiUpdatePw.Click += new System.EventHandler(this.tsmiUpdatePw_Click);
            // 
            // tmsiClose
            // 
            this.tmsiClose.Name = "tmsiClose";
            this.tmsiClose.Size = new System.Drawing.Size(189, 26);
            this.tmsiClose.Text = "退出";
            this.tmsiClose.Click += new System.EventHandler(this.tmsiClose_Click);
            // 
            // lvwShow
            // 
            this.lvwShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwShow.FullRowSelect = true;
            this.lvwShow.GridLines = true;
            this.lvwShow.Location = new System.Drawing.Point(1, 111);
            this.lvwShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwShow.Name = "lvwShow";
            this.lvwShow.Size = new System.Drawing.Size(547, 352);
            this.lvwShow.TabIndex = 1;
            this.lvwShow.UseCompatibleStateImageBehavior = false;
            this.lvwShow.View = System.Windows.Forms.View.Details;
            this.lvwShow.SelectedIndexChanged += new System.EventHandler(this.lvwShow_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名字：";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品数量：";
            this.columnHeader2.Width = 86;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(396, 49);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "查询";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "商品名字：";
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(109, 51);
            this.cboName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(160, 23);
            this.cboName.TabIndex = 4;
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.商品ToolStripMenuItem.Text = "商品";
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 456);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvwShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSupplier";
            this.Text = "供应商管理系统";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateMsg;
        private System.Windows.Forms.ToolStripMenuItem tmsiClose;
        private System.Windows.Forms.ListView lvwShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePw;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
    }
}