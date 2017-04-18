namespace Warehouse
{
    partial class FrmGoods
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
            this.lvwShow = new System.Windows.Forms.ListView();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwShow
            // 
            this.lvwShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwShow.Location = new System.Drawing.Point(1, 119);
            this.lvwShow.Name = "lvwShow";
            this.lvwShow.Size = new System.Drawing.Size(484, 406);
            this.lvwShow.TabIndex = 0;
            this.lvwShow.UseCompatibleStateImageBehavior = false;
            this.lvwShow.UseWaitCursor = true;
            this.lvwShow.View = System.Windows.Forms.View.Details;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(350, 30);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(88, 26);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "添加商品";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(350, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 27);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名字";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品类型";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品规格";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品单位";
            this.columnHeader4.Width = 81;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(116, 44);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 23);
            this.cboName.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(28, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 15);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "商品名字：";
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 520);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lvwShow);
            this.Name = "FrmGoods";
            this.Text = "商品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwShow;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lbl1;
    }
}