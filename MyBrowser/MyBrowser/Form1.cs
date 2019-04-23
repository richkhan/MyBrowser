using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnForward.Enabled = webBrowser1.CanGoForward;
            btnBack.Enabled = webBrowser1.CanGoBack;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Please enter a valid URL", "Invalid URL");
            }
            else {
                webBrowser1.Navigate("http://" + txtURL.Text);
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            { 
                webBrowser1.GoForward();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }
    }
}
