﻿namespace Warehouse
{
    partial class FrmUpdate
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
            this.cboWarehouseName = new System.Windows.Forms.ComboBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboWarehouseName
            // 
            this.cboWarehouseName.FormattingEnabled = true;
            this.cboWarehouseName.Location = new System.Drawing.Point(193, 255);
            this.cboWarehouseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboWarehouseName.Name = "cboWarehouseName";
            this.cboWarehouseName.Size = new System.Drawing.Size(92, 20);
            this.cboWarehouseName.TabIndex = 29;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(193, 210);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(92, 21);
            this.txtPhonenumber.TabIndex = 28;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(193, 174);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(92, 21);
            this.txtSex.TabIndex = 27;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(193, 134);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(92, 21);
            this.txtCardID.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 21);
            this.txtName.TabIndex = 25;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(193, 50);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(92, 21);
            this.txtLoginID.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 316);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 18);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "确认修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Location = new System.Drawing.Point(66, 262);
            this.lblWarehouseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(113, 12);
            this.lblWarehouseName.TabIndex = 21;
            this.lblWarehouseName.Text = "所管理的仓库名称：";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(111, 218);
            this.lblPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(65, 12);
            this.lblPhonenumber.TabIndex = 20;
            this.lblPhonenumber.Text = "联系方式：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(134, 182);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 19;
            this.lblSex.Text = "性别：";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(122, 134);
            this.lblCardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(53, 12);
            this.lblCardID.TabIndex = 18;
            this.lblCardID.Text = "身份证：";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(100, 101);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(77, 12);
            this.lblAdminName.TabIndex = 17;
            this.lblAdminName.Text = "管理员姓名：";
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Location = new System.Drawing.Point(122, 50);
            this.lblLoginID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(53, 12);
            this.lblLoginID.TabIndex = 15;
            this.lblLoginID.Text = "用户名：";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 384);
            this.Controls.Add(this.cboWarehouseName);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWarehouseName);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblLoginID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWarehouseName;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblLoginID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}