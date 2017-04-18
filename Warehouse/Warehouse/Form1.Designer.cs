namespace Warehouse
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.注册店员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新店面信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员",
            "店员",
            "供应商"});
            this.comboBox1.Location = new System.Drawing.Point(109, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 120);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 25);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 190);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 25);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(384, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册用户ToolStripMenuItem,
            this.tsmiWarehouse,
            this.添加新店面信息ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 注册用户ToolStripMenuItem
            // 
            this.注册用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegister,
            this.注册店员ToolStripMenuItem,
            this.注册供应商ToolStripMenuItem});
            this.注册用户ToolStripMenuItem.Name = "注册用户ToolStripMenuItem";
            this.注册用户ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.注册用户ToolStripMenuItem.Text = "注册用户";
            // 
            // tsmiRegister
            // 
            this.tsmiRegister.Name = "tsmiRegister";
            this.tsmiRegister.Size = new System.Drawing.Size(189, 26);
            this.tsmiRegister.Text = "注册仓库管理员";
            this.tsmiRegister.Click += new System.EventHandler(this.tsmiRegister_Click);
            // 
            // 注册店员ToolStripMenuItem
            // 
            this.注册店员ToolStripMenuItem.Name = "注册店员ToolStripMenuItem";
            this.注册店员ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.注册店员ToolStripMenuItem.Text = "注册店员";
            this.注册店员ToolStripMenuItem.Click += new System.EventHandler(this.注册店员ToolStripMenuItem_Click);
            // 
            // 注册供应商ToolStripMenuItem
            // 
            this.注册供应商ToolStripMenuItem.Name = "注册供应商ToolStripMenuItem";
            this.注册供应商ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.注册供应商ToolStripMenuItem.Text = "注册供应商";
            this.注册供应商ToolStripMenuItem.Click += new System.EventHandler(this.注册供应商ToolStripMenuItem_Click);
            // 
            // tsmiWarehouse
            // 
            this.tsmiWarehouse.Name = "tsmiWarehouse";
            this.tsmiWarehouse.Size = new System.Drawing.Size(189, 26);
            this.tsmiWarehouse.Text = "添加新仓库信息";
            this.tsmiWarehouse.Click += new System.EventHandler(this.tsmiWarehouse_Click);
            // 
            // 添加新店面信息ToolStripMenuItem
            // 
            this.添加新店面信息ToolStripMenuItem.Name = "添加新店面信息ToolStripMenuItem";
            this.添加新店面信息ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.添加新店面信息ToolStripMenuItem.Text = "添加新店面信息";
            this.添加新店面信息ToolStripMenuItem.Click += new System.EventHandler(this.添加新店面信息ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库管理ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.仓库管理ToolStripMenuItem.Text = "仓库管理";
            this.仓库管理ToolStripMenuItem.Click += new System.EventHandler(this.仓库管理ToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStripMenuItem 注册店员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehouse;
        private System.Windows.Forms.ToolStripMenuItem 添加新店面信息ToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库管理ToolStripMenuItem;
    }
}

