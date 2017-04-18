namespace Warehouse
{
    partial class FrmAdminAdd
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
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.cboWarehouseName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Location = new System.Drawing.Point(79, 38);
            this.lblLoginID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(53, 12);
            this.lblLoginID.TabIndex = 0;
            this.lblLoginID.Text = "用户名：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(90, 76);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码：";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(56, 111);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(77, 12);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "管理员姓名：";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(79, 143);
            this.lblCardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(53, 12);
            this.lblCardID.TabIndex = 3;
            this.lblCardID.Text = "身份证：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(90, 178);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别：";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(68, 206);
            this.lblPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(65, 12);
            this.lblPhonenumber.TabIndex = 5;
            this.lblPhonenumber.Text = "联系方式：";
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Location = new System.Drawing.Point(22, 250);
            this.lblWarehouseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(113, 12);
            this.lblWarehouseName.TabIndex = 6;
            this.lblWarehouseName.Text = "所管理的仓库名称：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 304);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 18);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(149, 38);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(92, 21);
            this.txtLoginID.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(92, 21);
            this.txtPassword.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 21);
            this.txtName.TabIndex = 10;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(149, 135);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(92, 21);
            this.txtCardID.TabIndex = 11;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(149, 170);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(92, 21);
            this.txtSex.TabIndex = 12;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(149, 198);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(92, 21);
            this.txtPhonenumber.TabIndex = 13;
            // 
            // cboWarehouseName
            // 
            this.cboWarehouseName.FormattingEnabled = true;
            this.cboWarehouseName.Location = new System.Drawing.Point(149, 243);
            this.cboWarehouseName.Margin = new System.Windows.Forms.Padding(2);
            this.cboWarehouseName.Name = "cboWarehouseName";
            this.cboWarehouseName.Size = new System.Drawing.Size(92, 20);
            this.cboWarehouseName.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.cboWarehouseName);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLoginID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdminAdd";
            this.Text = "FrmAdminAdd";
            this.Load += new System.EventHandler(this.FrmAdminAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.ComboBox cboWarehouseName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}