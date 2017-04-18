namespace Warehouse
{
    partial class FrmAdminDelete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAdminnName = new System.Windows.Forms.Label();
            this.lblAdminCardID = new System.Windows.Forms.Label();
            this.lblAdminSex = new System.Windows.Forms.Label();
            this.lblAdminPhonenumber = new System.Windows.Forms.Label();
            this.lblAdminnWarehouseName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "确认删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Location = new System.Drawing.Point(21, 289);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(142, 15);
            this.lblWarehouseName.TabIndex = 29;
            this.lblWarehouseName.Text = "所管理的仓库名称：";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(81, 244);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(82, 15);
            this.lblPhonenumber.TabIndex = 28;
            this.lblPhonenumber.Text = "联系方式：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(111, 196);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(52, 15);
            this.lblSex.TabIndex = 27;
            this.lblSex.Text = "性别：";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(96, 149);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(67, 15);
            this.lblCardID.TabIndex = 26;
            this.lblCardID.Text = "身份证：";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(66, 104);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(97, 15);
            this.lblAdminName.TabIndex = 25;
            this.lblAdminName.Text = "管理员姓名：";
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Location = new System.Drawing.Point(96, 62);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(67, 15);
            this.lblLoginID.TabIndex = 23;
            this.lblLoginID.Text = "用户名：";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(169, 62);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 15);
            this.lblLogin.TabIndex = 31;
            this.lblLogin.Text = "label1";
            // 
            // lblAdminnName
            // 
            this.lblAdminnName.AutoSize = true;
            this.lblAdminnName.Location = new System.Drawing.Point(169, 104);
            this.lblAdminnName.Name = "lblAdminnName";
            this.lblAdminnName.Size = new System.Drawing.Size(55, 15);
            this.lblAdminnName.TabIndex = 33;
            this.lblAdminnName.Text = "label3";
            // 
            // lblAdminCardID
            // 
            this.lblAdminCardID.AutoSize = true;
            this.lblAdminCardID.Location = new System.Drawing.Point(169, 149);
            this.lblAdminCardID.Name = "lblAdminCardID";
            this.lblAdminCardID.Size = new System.Drawing.Size(55, 15);
            this.lblAdminCardID.TabIndex = 34;
            this.lblAdminCardID.Text = "label4";
            // 
            // lblAdminSex
            // 
            this.lblAdminSex.AutoSize = true;
            this.lblAdminSex.Location = new System.Drawing.Point(169, 196);
            this.lblAdminSex.Name = "lblAdminSex";
            this.lblAdminSex.Size = new System.Drawing.Size(55, 15);
            this.lblAdminSex.TabIndex = 35;
            this.lblAdminSex.Text = "label5";
            // 
            // lblAdminPhonenumber
            // 
            this.lblAdminPhonenumber.AutoSize = true;
            this.lblAdminPhonenumber.Location = new System.Drawing.Point(169, 244);
            this.lblAdminPhonenumber.Name = "lblAdminPhonenumber";
            this.lblAdminPhonenumber.Size = new System.Drawing.Size(55, 15);
            this.lblAdminPhonenumber.TabIndex = 36;
            this.lblAdminPhonenumber.Text = "label6";
            // 
            // lblAdminnWarehouseName
            // 
            this.lblAdminnWarehouseName.AutoSize = true;
            this.lblAdminnWarehouseName.Location = new System.Drawing.Point(169, 289);
            this.lblAdminnWarehouseName.Name = "lblAdminnWarehouseName";
            this.lblAdminnWarehouseName.Size = new System.Drawing.Size(55, 15);
            this.lblAdminnWarehouseName.TabIndex = 37;
            this.lblAdminnWarehouseName.Text = "label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAdminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 475);
            this.Controls.Add(this.lblAdminnWarehouseName);
            this.Controls.Add(this.lblAdminPhonenumber);
            this.Controls.Add(this.lblAdminSex);
            this.Controls.Add(this.lblAdminCardID);
            this.Controls.Add(this.lblAdminnName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblLoginID);
            this.Name = "FrmAdminDelete";
            this.Text = "FrmAdminDelete";
            this.Load += new System.EventHandler(this.FrmAdminDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAdminnName;
        private System.Windows.Forms.Label lblAdminCardID;
        private System.Windows.Forms.Label lblAdminSex;
        private System.Windows.Forms.Label lblAdminPhonenumber;
        private System.Windows.Forms.Label lblAdminnWarehouseName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}