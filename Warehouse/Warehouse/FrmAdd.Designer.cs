﻿namespace Warehouse
{
    partial class FrmAdd
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
            this.cboGoodsName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.入库明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库明细ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建入库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库单查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.货物信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboGoodsName
            // 
            this.cboGoodsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsName.FormattingEnabled = true;
            this.cboGoodsName.Location = new System.Drawing.Point(164, 66);
            this.cboGoodsName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGoodsName.Name = "cboGoodsName";
            this.cboGoodsName.Size = new System.Drawing.Size(160, 23);
            this.cboGoodsName.TabIndex = 0;
            this.cboGoodsName.TextChanged += new System.EventHandler(this.cboGoodsName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "商 品 名：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(164, 132);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(160, 25);
            this.txtNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品数量：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 206);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "入库";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库明细ToolStripMenuItem,
            this.货物信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(356, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 入库明细ToolStripMenuItem
            // 
            this.入库明细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库明细ToolStripMenuItem1,
            this.新建入库单ToolStripMenuItem,
            this.入库单查询ToolStripMenuItem1});
            this.入库明细ToolStripMenuItem.Name = "入库明细ToolStripMenuItem";
            this.入库明细ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.入库明细ToolStripMenuItem.Text = "菜单";
            // 
            // 入库明细ToolStripMenuItem1
            // 
            this.入库明细ToolStripMenuItem1.Name = "入库明细ToolStripMenuItem1";
            this.入库明细ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.入库明细ToolStripMenuItem1.Text = "所有入库明细";
            this.入库明细ToolStripMenuItem1.Click += new System.EventHandler(this.入库明细ToolStripMenuItem1_Click);
            // 
            // 新建入库单ToolStripMenuItem
            // 
            this.新建入库单ToolStripMenuItem.Name = "新建入库单ToolStripMenuItem";
            this.新建入库单ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.新建入库单ToolStripMenuItem.Text = "新建入库单";
            this.新建入库单ToolStripMenuItem.Click += new System.EventHandler(this.新建入库单ToolStripMenuItem_Click);
            // 
            // 入库单查询ToolStripMenuItem1
            // 
            this.入库单查询ToolStripMenuItem1.Name = "入库单查询ToolStripMenuItem1";
            this.入库单查询ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.入库单查询ToolStripMenuItem1.Text = "入库单查询";
            this.入库单查询ToolStripMenuItem1.Click += new System.EventHandler(this.入库单查询ToolStripMenuItem1_Click);
            // 
            // 货物信息ToolStripMenuItem
            // 
            this.货物信息ToolStripMenuItem.Name = "货物信息ToolStripMenuItem";
            this.货物信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.货物信息ToolStripMenuItem.Text = "供货信息";
            this.货物信息ToolStripMenuItem.Click += new System.EventHandler(this.货物信息ToolStripMenuItem_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 328);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGoodsName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdd";
            this.Text = "商品入库";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGoodsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 入库明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货物信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库明细ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建入库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库单查询ToolStripMenuItem1;
    }
}