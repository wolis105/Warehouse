namespace Warehouse
{
    partial class FrmAdminUpdatePassword
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
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPasssword = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(22, 62);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(67, 15);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "旧密码：";
            // 
            // lblNewPasssword
            // 
            this.lblNewPasssword.AutoSize = true;
            this.lblNewPasssword.Location = new System.Drawing.Point(22, 114);
            this.lblNewPasssword.Name = "lblNewPasssword";
            this.lblNewPasssword.Size = new System.Drawing.Size(67, 15);
            this.lblNewPasssword.TabIndex = 1;
            this.lblNewPasssword.Text = "新密码：";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(22, 167);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(97, 15);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "确认新密码：";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(134, 52);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(100, 25);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(134, 111);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 25);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(134, 167);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 25);
            this.txtSure.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(35, 293);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(118, 49);
            this.btnSure.TabIndex = 6;
            this.btnSure.Text = "确认修改密码";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // FrmAdminUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 377);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblNewPasssword);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "FrmAdminUpdatePassword";
            this.Text = "FrmAdminUpdatePassword";
            this.Load += new System.EventHandler(this.FrmAdminUpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPasssword;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSure;
    }
}