namespace Warehouse
{
    partial class FrmExtractDetail
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
            this.components = new System.ComponentModel.Container();
            this.btnExtract = new System.Windows.Forms.Button();
            this.cboGdName = new System.Windows.Forms.ComboBox();
            this.lblGdName = new System.Windows.Forms.Label();
            this.lvwSelectlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(379, 30);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 29);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "提货";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // cboGdName
            // 
            this.cboGdName.FormattingEnabled = true;
            this.cboGdName.Items.AddRange(new object[] {
            "查询所有"});
            this.cboGdName.Location = new System.Drawing.Point(117, 35);
            this.cboGdName.Name = "cboGdName";
            this.cboGdName.Size = new System.Drawing.Size(121, 20);
            this.cboGdName.TabIndex = 1;
            // 
            // lblGdName
            // 
            this.lblGdName.AutoSize = true;
            this.lblGdName.Location = new System.Drawing.Point(12, 38);
            this.lblGdName.Name = "lblGdName";
            this.lblGdName.Size = new System.Drawing.Size(89, 12);
            this.lblGdName.TabIndex = 2;
            this.lblGdName.Text = "按商品名查询：";
            // 
            // lvwSelectlist
            // 
            this.lvwSelectlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwSelectlist.ContextMenuStrip = this.cmsControl;
            this.lvwSelectlist.FullRowSelect = true;
            this.lvwSelectlist.GridLines = true;
            this.lvwSelectlist.Location = new System.Drawing.Point(12, 159);
            this.lvwSelectlist.Name = "lvwSelectlist";
            this.lvwSelectlist.Size = new System.Drawing.Size(442, 299);
            this.lvwSelectlist.TabIndex = 3;
            this.lvwSelectlist.UseCompatibleStateImageBehavior = false;
            this.lvwSelectlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "提货单编号";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "提货数量";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "提货时间";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品名";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "提货店面";
            // 
            // cmsControl
            // 
            this.cmsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove});
            this.cmsControl.Name = "cmsControl";
            this.cmsControl.Size = new System.Drawing.Size(137, 26);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(152, 22);
            this.tsmiRemove.Text = "删除提货单";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(379, 98);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 29);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "商品类型";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "商品规格";
            // 
            // FrmExtractDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 470);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lvwSelectlist);
            this.Controls.Add(this.lblGdName);
            this.Controls.Add(this.cboGdName);
            this.Controls.Add(this.btnExtract);
            this.Name = "FrmExtractDetail";
            this.Text = "提货界面";
            this.Load += new System.EventHandler(this.FrmExtractDetail_Load);
            this.cmsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.ComboBox cboGdName;
        private System.Windows.Forms.Label lblGdName;
        private System.Windows.Forms.ListView lvwSelectlist;
        private System.Windows.Forms.ContextMenuStrip cmsControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}