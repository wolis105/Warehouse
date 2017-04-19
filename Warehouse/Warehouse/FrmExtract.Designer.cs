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
            this.components = new System.ComponentModel.Container();
            this.lblGdName = new System.Windows.Forms.Label();
            this.cboGdName = new System.Windows.Forms.ComboBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblShName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.errMistake = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblWHouse = new System.Windows.Forms.Label();
            this.cboShName = new System.Windows.Forms.ComboBox();
            this.cboWhName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errMistake)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGdName
            // 
            this.lblGdName.AutoSize = true;
            this.lblGdName.Location = new System.Drawing.Point(41, 43);
            this.lblGdName.Name = "lblGdName";
            this.lblGdName.Size = new System.Drawing.Size(41, 12);
            this.lblGdName.TabIndex = 0;
            this.lblGdName.Text = "商品名";
            // 
            // cboGdName
            // 
            this.cboGdName.FormattingEnabled = true;
            this.cboGdName.Location = new System.Drawing.Point(135, 35);
            this.cboGdName.Name = "cboGdName";
            this.cboGdName.Size = new System.Drawing.Size(200, 20);
            this.cboGdName.TabIndex = 5;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(260, 419);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 10;
            this.btnExtract.Text = "提货";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(43, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShName
            // 
            this.lblShName.AutoSize = true;
            this.lblShName.Location = new System.Drawing.Point(41, 114);
            this.lblShName.Name = "lblShName";
            this.lblShName.Size = new System.Drawing.Size(53, 12);
            this.lblShName.TabIndex = 12;
            this.lblShName.Text = "提货店面";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(41, 195);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "提货日期";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(135, 186);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 21);
            this.dtpTime.TabIndex = 15;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(41, 280);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 12);
            this.lblNumber.TabIndex = 16;
            this.lblNumber.Text = "提货数量";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(135, 271);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 21);
            this.txtNumber.TabIndex = 17;
            // 
            // errMistake
            // 
            this.errMistake.ContainerControl = this;
            // 
            // lblWHouse
            // 
            this.lblWHouse.AutoSize = true;
            this.lblWHouse.Location = new System.Drawing.Point(41, 360);
            this.lblWHouse.Name = "lblWHouse";
            this.lblWHouse.Size = new System.Drawing.Size(53, 12);
            this.lblWHouse.TabIndex = 18;
            this.lblWHouse.Text = "提货仓库";
            // 
            // cboShName
            // 
            this.cboShName.FormattingEnabled = true;
            this.cboShName.Location = new System.Drawing.Point(135, 106);
            this.cboShName.Name = "cboShName";
            this.cboShName.Size = new System.Drawing.Size(200, 20);
            this.cboShName.TabIndex = 19;
            // 
            // cboWhName
            // 
            this.cboWhName.FormattingEnabled = true;
            this.cboWhName.Location = new System.Drawing.Point(135, 352);
            this.cboWhName.Name = "cboWhName";
            this.cboWhName.Size = new System.Drawing.Size(200, 20);
            this.cboWhName.TabIndex = 20;
            // 
            // FrmExtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 561);
            this.Controls.Add(this.cboWhName);
            this.Controls.Add(this.cboShName);
            this.Controls.Add(this.lblWHouse);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblShName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.cboGdName);
            this.Controls.Add(this.lblGdName);
            this.Name = "FrmExtract";
            this.Text = "提货单界面";
            this.Load += new System.EventHandler(this.FrmExtract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMistake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGdName;
        private System.Windows.Forms.ComboBox cboGdName;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblShName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ErrorProvider errMistake;
        private System.Windows.Forms.Label lblWHouse;
        private System.Windows.Forms.ComboBox cboWhName;
        private System.Windows.Forms.ComboBox cboShName;
    }
}