using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSelenium
{
    public partial class UCOpenSelenium : UserControl
    {
        public UCOpenSelenium()
        {
            InitializeComponent();
        }
        public string browser
        {
            get { return cbbBrowser.Text;}
            set { cbbBrowser.Text = value; }
        }
        public string proxy
        {
            get { return txtProxy.Text; }
            set { txtProxy.Text = value; }
        }
        public string port
        {
            get { return txtPort.Text; }
            set { txtPort.Text = value; }
        }
        private void UCOpenSelenium_Load(object sender, EventArgs e)
        {
            cbbBrowser.SelectedIndex = 0;
        }
    }
}
