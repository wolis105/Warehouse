﻿namespace Warehouse
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册仓库管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册店员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新仓库信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新店面信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员",
            "店员",
            "供应商"});
            this.comboBox1.Location = new System.Drawing.Point(82, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 21);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册用户ToolStripMenuItem,
            this.添加新仓库信息ToolStripMenuItem,
            this.添加新店面信息ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 注册用户ToolStripMenuItem
            // 
            this.注册用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册仓库管理员ToolStripMenuItem,
            this.注册店员ToolStripMenuItem,
            this.注册供应商ToolStripMenuItem});
            this.注册用户ToolStripMenuItem.Name = "注册用户ToolStripMenuItem";
            this.注册用户ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.注册用户ToolStripMenuItem.Text = "注册用户";
            // 
            // 注册仓库管理员ToolStripMenuItem
            // 
            this.注册仓库管理员ToolStripMenuItem.Name = "注册仓库管理员ToolStripMenuItem";
            this.注册仓库管理员ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.注册仓库管理员ToolStripMenuItem.Text = "注册仓库管理员";
            // 
            // 注册店员ToolStripMenuItem
            // 
            this.注册店员ToolStripMenuItem.Name = "注册店员ToolStripMenuItem";
            this.注册店员ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.注册店员ToolStripMenuItem.Text = "注册店员";
            // 
            // 注册供应商ToolStripMenuItem
            // 
            this.注册供应商ToolStripMenuItem.Name = "注册供应商ToolStripMenuItem";
            this.注册供应商ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.注册供应商ToolStripMenuItem.Text = "注册供应商";
            this.注册供应商ToolStripMenuItem.Click += new System.EventHandler(this.注册供应商ToolStripMenuItem_Click);
            // 
            // 添加新仓库信息ToolStripMenuItem
            // 
            this.添加新仓库信息ToolStripMenuItem.Name = "添加新仓库信息ToolStripMenuItem";
            this.添加新仓库信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加新仓库信息ToolStripMenuItem.Text = "添加新仓库信息";
            // 
            // 添加新店面信息ToolStripMenuItem
            // 
            this.添加新店面信息ToolStripMenuItem.Name = "添加新店面信息ToolStripMenuItem";
            this.添加新店面信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加新店面信息ToolStripMenuItem.Text = "添加新店面信息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册仓库管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册店员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新仓库信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新店面信息ToolStripMenuItem;
    }
}

