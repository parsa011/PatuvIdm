using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace PatuvIDM.App
{
    public partial class frmNewDownload : Form
    {
        public bool ForLater;

        public frmNewDownload()
        {
            InitializeComponent();
        }

        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog {Title = @"لطفا محل ذخیره سازی فایل را انتخاب کنید"};
            saveFile.FileName = Path.GetFileName(txtDownloadLink.Text);
            saveFile.ShowDialog();
            txtSaveIn.Text = saveFile.FileName;
        }

        private void chkDownlaodLater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDownlaodLater.Checked)
            {
                txtTime.Enabled = true;
                txtDate.Enabled = true;
                ForLater = true;
                btnStartDownload.Text = @"اضافه به لیست";
            }
            else
            {
                txtTime.Enabled = false;
                txtDate.Enabled = false;
                ForLater = false;
                btnStartDownload.Text = @"شروع دانلود";
            }
        }

        private void frmNewDownload_Load(object sender, EventArgs e)
        {
            if (ForLater) chkDownlaodLater.Checked = true;
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
            txtTime.Text = DateTime.Now.Date.ToShortTimeString();
        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            var downloadLink = txtDownloadLink.Text;
            var path = txtSaveIn.Text;
            if (!string.IsNullOrEmpty(downloadLink))
            {
                if (!string.IsNullOrEmpty(path))
                {
                    new frmDownloading(downloadLink, path).Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("خطا", "محل ذخیره سازی را وارد فرمایید",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("خطا", "لینک دانلود را وارد فرمایید",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}