namespace Warehouse
{
    partial class FrmSelectAdmin
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lvwSelect = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiDelete,
            this.tsmiUpdatePassword});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(160, 22);
            this.tsmiUpdate.Text = "修改管理员信息";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(160, 22);
            this.tsmiDelete.Text = "删除管理员信息";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiUpdatePassword
            // 
            this.tsmiUpdatePassword.Name = "tsmiUpdatePassword";
            this.tsmiUpdatePassword.Size = new System.Drawing.Size(160, 22);
            this.tsmiUpdatePassword.Text = "修改密码";
            this.tsmiUpdatePassword.Click += new System.EventHandler(this.tsmiUpdatePassword_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(426, 45);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 18);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(406, 99);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(92, 18);
            this.btnAddAdmin.TabIndex = 2;
            this.btnAddAdmin.Text = "新增管理员";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "请输入你要查询的姓名：";
            // 
            // lvwSelect
            // 
            this.lvwSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwSelect.FullRowSelect = true;
            this.lvwSelect.GridLines = true;
            this.lvwSelect.Location = new System.Drawing.Point(-2, 153);
            this.lvwSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwSelect.Name = "lvwSelect";
            this.lvwSelect.Size = new System.Drawing.Size(524, 292);
            this.lvwSelect.TabIndex = 4;
            this.lvwSelect.UseCompatibleStateImageBehavior = false;
            this.lvwSelect.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "管理员的姓名";
            this.columnHeader2.Width = 198;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "管理员身份证";
            this.columnHeader3.Width = 244;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "管理员性别";
            this.columnHeader4.Width = 219;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "管理员电话";
            this.columnHeader5.Width = 189;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "管理的仓库";
            this.columnHeader6.Width = 158;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 21);
            this.txtName.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSelectAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 447);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvwSelect);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.btnSelect);
            this.Name = "FrmSelectAdmin";
            this.Text = "管理员增删查改界面";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePassword;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lvwSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}