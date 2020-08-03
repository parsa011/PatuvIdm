using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace PatuvIDM.App
{
    public partial class frmDownloading : Form
    {
        public frmDownloading(string downloadLink,string path)
        {
            InitializeComponent();
            var thread = new Thread(async () => { await DownLoadData(downloadLink, path);});
            thread.Start();
        }

        private async Task DownLoadData(string downloadLink,string path)
        {
            var webClient = new WebClient();
            var stream = webClient.OpenRead(downloadLink);
            var length = int.Parse(webClient.ResponseHeaders["content-length"]);
            var downloaded = 0;
            var buffer = new byte[1024];
            
            lblFileName.Invoke(new MethodInvoker(delegate { lblFileName.Text = Path.GetFileName(path); }));
            lblSaveIn.Invoke(new MethodInvoker(delegate {   lblSaveIn.Text = path; }));
            lblFileLength.Invoke(new MethodInvoker(delegate { lblFileLength.Text = (length / 1024) + " " + "کیلو بایت"; }));
            lblStartTime.Invoke(new MethodInvoker(delegate { lblStartTime.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture); }));
            
            if (stream != null)
            {
                using (var fs = new FileStream(path, FileMode.CreateNew))
                {
                    while (downloaded < length)
                    {
                        var bytes = await stream.ReadAsync(buffer, 0, 1024);
                        fs.Write(buffer, 0, bytes);
                        downloaded += bytes;
                        var downloadedFileLength = downloaded;
                        lblDownloaded.Invoke(new MethodInvoker(delegate {  lblDownloaded.Text = (downloadedFileLength / 1024) + " " + "کیلو بایت"; }));
                        var percent = ((downloaded * 100) / length);
                        lblDownloadedPercent.Invoke(new MethodInvoker(delegate { lblDownloadedPercent.Text = percent.ToString() + " %"; }));
                        progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.Value = percent; }));
                    }
                }

                MessageBox.Show("موفقیت","فایل مورد نظر با موفقیت دانلود شد",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("خظا", "در هنگام دانلود از این مسیر خطایی رخ داده است",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}