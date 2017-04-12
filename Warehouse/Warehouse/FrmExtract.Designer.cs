namespace Warehouse
{
    partial class FrmExtract
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
            this.lblGdName = new System.Windows.Forms.Label();
            this.lblGdUnit = new System.Windows.Forms.Label();
            this.lblEDCount = new System.Windows.Forms.Label();
            this.lblGdType = new System.Windows.Forms.Label();
            this.lblGdSpecification = new System.Windows.Forms.Label();
            this.cboGdName = new System.Windows.Forms.ComboBox();
            this.txtGdUnit = new System.Windows.Forms.TextBox();
            this.txtEDCount = new System.Windows.Forms.TextBox();
            this.txtGdType = new System.Windows.Forms.TextBox();
            this.txtGdSpecification = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGdName
            // 
            this.lblGdName.AutoSize = true;
            this.lblGdName.Location = new System.Drawing.Point(67, 43);
            this.lblGdName.Name = "lblGdName";
            this.lblGdName.Size = new System.Drawing.Size(41, 12);
            this.lblGdName.TabIndex = 0;
            this.lblGdName.Text = "商品名";
            // 
            // lblGdUnit
            // 
            this.lblGdUnit.AutoSize = true;
            this.lblGdUnit.Location = new System.Drawing.Point(67, 112);
            this.lblGdUnit.Name = "lblGdUnit";
            this.lblGdUnit.Size = new System.Drawing.Size(53, 12);
            this.lblGdUnit.TabIndex = 1;
            this.lblGdUnit.Text = "商品单位";
            // 
            // lblEDCount
            // 
            this.lblEDCount.AutoSize = true;
            this.lblEDCount.Location = new System.Drawing.Point(67, 181);
            this.lblEDCount.Name = "lblEDCount";
            this.lblEDCount.Size = new System.Drawing.Size(53, 12);
            this.lblEDCount.TabIndex = 2;
            this.lblEDCount.Text = "提货数量";
            // 
            // lblGdType
            // 
            this.lblGdType.AutoSize = true;
            this.lblGdType.Location = new System.Drawing.Point(67, 250);
            this.lblGdType.Name = "lblGdType";
            this.lblGdType.Size = new System.Drawing.Size(53, 12);
            this.lblGdType.TabIndex = 3;
            this.lblGdType.Text = "商品类型";
            // 
            // lblGdSpecification
            // 
            this.lblGdSpecification.AutoSize = true;
            this.lblGdSpecification.Location = new System.Drawing.Point(67, 319);
            this.lblGdSpecification.Name = "lblGdSpecification";
            this.lblGdSpecification.Size = new System.Drawing.Size(53, 12);
            this.lblGdSpecification.TabIndex = 4;
            this.lblGdSpecification.Text = "商品规格";
            // 
            // cboGdName
            // 
            this.cboGdName.FormattingEnabled = true;
            this.cboGdName.Location = new System.Drawing.Point(142, 40);
            this.cboGdName.Name = "cboGdName";
            this.cboGdName.Size = new System.Drawing.Size(133, 20);
            this.cboGdName.TabIndex = 5;
            // 
            // txtGdUnit
            // 
            this.txtGdUnit.Location = new System.Drawing.Point(142, 103);
            this.txtGdUnit.Name = "txtGdUnit";
            this.txtGdUnit.Size = new System.Drawing.Size(133, 21);
            this.txtGdUnit.TabIndex = 6;
            // 
            // txtEDCount
            // 
            this.txtEDCount.Location = new System.Drawing.Point(142, 172);
            this.txtEDCount.Name = "txtEDCount";
            this.txtEDCount.Size = new System.Drawing.Size(133, 21);
            this.txtEDCount.TabIndex = 7;
            // 
            // txtGdType
            // 
            this.txtGdType.Location = new System.Drawing.Point(142, 241);
            this.txtGdType.Name = "txtGdType";
            this.txtGdType.Size = new System.Drawing.Size(133, 21);
            this.txtGdType.TabIndex = 8;
            // 
            // txtGdSpecification
            // 
            this.txtGdSpecification.Location = new System.Drawing.Point(142, 310);
            this.txtGdSpecification.Name = "txtGdSpecification";
            this.txtGdSpecification.Size = new System.Drawing.Size(133, 21);
            this.txtGdSpecification.TabIndex = 9;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(200, 389);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 10;
            this.btnExtract.Text = "提货";
            this.btnExtract.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(69, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtGdSpecification);
            this.Controls.Add(this.txtGdType);
            this.Controls.Add(this.txtEDCount);
            this.Controls.Add(this.txtGdUnit);
            this.Controls.Add(this.cboGdName);
            this.Controls.Add(this.lblGdSpecification);
            this.Controls.Add(this.lblGdType);
            this.Controls.Add(this.lblEDCount);
            this.Controls.Add(this.lblGdUnit);
            this.Controls.Add(this.lblGdName);
            this.Name = "FrmExtract";
            this.Text = "提货单界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGdName;
        private System.Windows.Forms.Label lblGdUnit;
        private System.Windows.Forms.Label lblEDCount;
        private System.Windows.Forms.Label lblGdType;
        private System.Windows.Forms.Label lblGdSpecification;
        private System.Windows.Forms.ComboBox cboGdName;
        private System.Windows.Forms.TextBox txtGdUnit;
        private System.Windows.Forms.TextBox txtEDCount;
        private System.Windows.Forms.TextBox txtGdType;
        private System.Windows.Forms.TextBox txtGdSpecification;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnClose;
    }
}