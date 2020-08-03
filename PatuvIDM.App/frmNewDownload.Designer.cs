using System.ComponentModel;

namespace PatuvIDM.App
{
    partial class frmNewDownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblDownlaodLink = new System.Windows.Forms.Label();
            this.txtDownloadLink = new System.Windows.Forms.TextBox();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.lblSaveIn = new System.Windows.Forms.Label();
            this.txtSaveIn = new System.Windows.Forms.TextBox();
            this.btnSaveIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkDownlaodLater = new System.Windows.Forms.CheckBox();
            this.numConnections = new System.Windows.Forms.NumericUpDown();
            this.lblConnections = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDownlaodLink
            // 
            this.lblDownlaodLink.Location = new System.Drawing.Point(12, 9);
            this.lblDownlaodLink.Name = "lblDownlaodLink";
            this.lblDownlaodLink.Size = new System.Drawing.Size(78, 25);
            this.lblDownlaodLink.TabIndex = 0;
            this.lblDownlaodLink.Text = "لینک دانلود :";
            // 
            // txtDownloadLink
            // 
            this.txtDownloadLink.Location = new System.Drawing.Point(96, 9);
            this.txtDownloadLink.Name = "txtDownloadLink";
            this.txtDownloadLink.Size = new System.Drawing.Size(657, 25);
            this.txtDownloadLink.TabIndex = 1;
            this.txtDownloadLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(12, 226);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(741, 25);
            this.btnStartDownload.TabIndex = 5;
            this.btnStartDownload.Text = "شروع دانلود";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // lblSaveIn
            // 
            this.lblSaveIn.Location = new System.Drawing.Point(12, 51);
            this.lblSaveIn.Name = "lblSaveIn";
            this.lblSaveIn.Size = new System.Drawing.Size(78, 25);
            this.lblSaveIn.TabIndex = 3;
            this.lblSaveIn.Text = "ذخیره در :";
            // 
            // txtSaveIn
            // 
            this.txtSaveIn.Location = new System.Drawing.Point(188, 52);
            this.txtSaveIn.Name = "txtSaveIn";
            this.txtSaveIn.Size = new System.Drawing.Size(565, 25);
            this.txtSaveIn.TabIndex = 2;
            this.txtSaveIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaveIn
            // 
            this.btnSaveIn.Location = new System.Drawing.Point(96, 51);
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.Size = new System.Drawing.Size(86, 26);
            this.btnSaveIn.TabIndex = 5;
            this.btnSaveIn.Text = "جستجو";
            this.btnSaveIn.UseVisualStyleBackColor = true;
            this.btnSaveIn.Click += new System.EventHandler(this.btnSaveIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.chkDownlaodLater);
            this.groupBox1.Controls.Add(this.numConnections);
            this.groupBox1.Controls.Add(this.lblConnections);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(6, 78);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(308, 25);
            this.txtTime.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(375, 78);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(302, 25);
            this.txtDate.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(320, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 25);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "زمان : ";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(673, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "تاریخ : ";
            // 
            // chkDownlaodLater
            // 
            this.chkDownlaodLater.Location = new System.Drawing.Point(339, 33);
            this.chkDownlaodLater.Name = "chkDownlaodLater";
            this.chkDownlaodLater.Size = new System.Drawing.Size(125, 24);
            this.chkDownlaodLater.TabIndex = 4;
            this.chkDownlaodLater.Text = "بعد دانلود شود";
            this.chkDownlaodLater.UseVisualStyleBackColor = true;
            this.chkDownlaodLater.CheckedChanged += new System.EventHandler(this.chkDownlaodLater_CheckedChanged);
            // 
            // numConnections
            // 
            this.numConnections.Location = new System.Drawing.Point(492, 30);
            this.numConnections.Name = "numConnections";
            this.numConnections.Size = new System.Drawing.Size(120, 25);
            this.numConnections.TabIndex = 3;
            this.numConnections.Value = new decimal(new int[] {8, 0, 0, 0});
            // 
            // lblConnections
            // 
            this.lblConnections.Location = new System.Drawing.Point(618, 32);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(104, 25);
            this.lblConnections.TabIndex = 4;
            this.lblConnections.Text = "تعداد اتصال ها :";
            // 
            // frmNewDownload
            // 
            this.AcceptButton = this.btnStartDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveIn);
            this.Controls.Add(this.txtSaveIn);
            this.Controls.Add(this.lblSaveIn);
            this.Controls.Add(this.btnStartDownload);
            this.Controls.Add(this.txtDownloadLink);
            this.Controls.Add(this.lblDownlaodLink);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmNewDownload";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ایجاد دانلود جدید";
            this.Load += new System.EventHandler(this.frmNewDownload_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSaveIn;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.CheckBox chkDownlaodLater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDownlaodLink;
        private System.Windows.Forms.Label lblSaveIn;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown numConnections;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDownloadLink;
        private System.Windows.Forms.TextBox txtSaveIn;
        private System.Windows.Forms.TextBox txtTime;

        #endregion
    }
}