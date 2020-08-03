using System;
using System.Drawing.Printing;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace PatuvIDM.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewDownload_Click(object sender, EventArgs e)
        {
            new frmNewDownload().ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var listView = new ListView();
            listView.Columns.AddRange(new [] {
                new ColumnHeader {Text = "لینک دانلود", Width = 388},
                new ColumnHeader {Text = "آدرس فایل", Width = 365},
                new ColumnHeader {Text = "حجم فایل", Width = 85},
                new ColumnHeader {Text = "حجم دانلود شده", Width = 108},
                new ColumnHeader {Text = "سرعت دانلود", Width = 87},
                new ColumnHeader {Text = "وضعیت دانلود", Width = 83}});
            listView.Dock = DockStyle.Fill;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Margin = new Padding(0,20,0,0);
            listView.Location = new System.Drawing.Point(0, 24);
            listView.Name = "listView1";
            listView.RightToLeft = RightToLeft.Yes;
            listView.RightToLeftLayout = true;
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            Controls.Add(listView);
        }
    }
}