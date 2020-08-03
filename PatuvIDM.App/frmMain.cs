using System;
using System.Windows.Forms;

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
    }
}