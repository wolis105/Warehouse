namespace Warehouse
{
    partial class FrmAddGoods
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(59, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "商品名字：";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(59, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(82, 15);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "商品类型：";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(59, 141);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(82, 15);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "商品规格：";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(59, 182);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(82, 15);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "商品单位：";
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(135, 59);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(141, 23);
            this.cboName.TabIndex = 4;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            this.cboName.TextChanged += new System.EventHandler(this.cboName_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(135, 98);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(141, 25);
            this.txtType.TabIndex = 5;
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(135, 138);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(141, 25);
            this.txtSpecification.TabIndex = 6;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(135, 179);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(141, 25);
            this.txtUnit.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(62, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 32);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtSpecification);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "FrmAddGoods";
            this.Text = "添加商品";
            this.Load += new System.EventHandler(this.FrmAddGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}