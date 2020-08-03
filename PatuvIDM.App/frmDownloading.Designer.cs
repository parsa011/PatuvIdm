using System.ComponentModel;

namespace PatuvIDM.App
{
    partial class frmDownloading
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSaveIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransferRate = new System.Windows.Forms.Label();
            this.lblDownloadedPercent = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.lblFileLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(832, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // lblPercent
            // 
            this.lblPercent.Location = new System.Drawing.Point(325, 38);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(125, 20);
            this.lblPercent.TabIndex = 1;
            this.lblPercent.Text = "درصد دانلود شده :";
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(725, 38);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(85, 20);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "حجم فایل : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblSaveIn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTransferRate);
            this.groupBox1.Controls.Add(this.lblDownloadedPercent);
            this.groupBox1.Controls.Add(this.lblTimeLeft);
            this.groupBox1.Controls.Add(this.lblStartTime);
            this.groupBox1.Controls.Add(this.lblDownloaded);
            this.groupBox1.Controls.Add(this.lblFileLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // lblSaveIn
            // 
            this.lblSaveIn.Location = new System.Drawing.Point(6, 142);
            this.lblSaveIn.Name = "lblSaveIn";
            this.lblSaveIn.Size = new System.Drawing.Size(284, 20);
            this.lblSaveIn.TabIndex = 16;
            this.lblSaveIn.Text = "my image,png";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(325, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ذخیره در : ";
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(6, 109);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(284, 20);
            this.lblFileName.TabIndex = 14;
            this.lblFileName.Text = "my image,png";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(325, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام فایل : ";
            // 
            // lblTransferRate
            // 
            this.lblTransferRate.Location = new System.Drawing.Point(165, 74);
            this.lblTransferRate.Name = "lblTransferRate";
            this.lblTransferRate.Size = new System.Drawing.Size(125, 20);
            this.lblTransferRate.TabIndex = 12;
            this.lblTransferRate.Text = "100kb";
            // 
            // lblDownloadedPercent
            // 
            this.lblDownloadedPercent.Location = new System.Drawing.Point(165, 38);
            this.lblDownloadedPercent.Name = "lblDownloadedPercent";
            this.lblDownloadedPercent.Size = new System.Drawing.Size(125, 20);
            this.lblDownloadedPercent.TabIndex = 11;
            this.lblDownloadedPercent.Text = "20 %";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Location = new System.Drawing.Point(546, 142);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(125, 20);
            this.lblTimeLeft.TabIndex = 10;
            this.lblTimeLeft.Text = "0 : 0";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(546, 109);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(125, 20);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "12:0:0";
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.Location = new System.Drawing.Point(546, 74);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(125, 20);
            this.lblDownloaded.TabIndex = 8;
            this.lblDownloaded.Text = "10 kb";
            // 
            // lblFileLength
            // 
            this.lblFileLength.Location = new System.Drawing.Point(546, 38);
            this.lblFileLength.Name = "lblFileLength";
            this.lblFileLength.Size = new System.Drawing.Size(125, 20);
            this.lblFileLength.TabIndex = 7;
            this.lblFileLength.Text = "200 kb";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(325, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "سرعت دانلود : ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(678, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "دانلود در : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(678, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "زمان شروع : ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(678, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "مقدار دانلود شده : ";
            // 
            // frmDownloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDownloading";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دانلود فایل";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label lblDownloadedPercent;
        private System.Windows.Forms.Label lblFileLength;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblSaveIn;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblTransferRate;
        private System.Windows.Forms.ProgressBar progressBar1;

        #endregion
    }
}