using System;
using System.Windows.Forms;

namespace IVT.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            versionLbl.Text = "Version: " + Application.ProductVersion.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}