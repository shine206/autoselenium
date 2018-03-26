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
    public partial class UCSend : UserControl
    {
        public string byElement
        {
            get { return cbbBy.Text; }
            set { cbbBy.Text = value; }
        }
        public string element
        {
            get { return txtElement.Text; }
            set { txtElement.Text = value; }
        }
        public string key
        {
            get { return txtKey.Text; }
            set { txtKey.Text = value; }
        }
        public UCSend()
        {
            InitializeComponent();
        }

        private void UCSend_Load(object sender, EventArgs e)
        {
            cbbBy.SelectedIndex = 0;
        }
    }
}
