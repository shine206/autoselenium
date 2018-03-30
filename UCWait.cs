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
    public partial class UCWait : UserControl
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
        public string time
        {
            get { return txtTime.Text; }
            set { txtTime.Text = value; }
        }
        public UCWait()
        {
            InitializeComponent();
        }

        private void UCWait_Load(object sender, EventArgs e)
        {
            cbbBy.SelectedIndex = 0;
        }
    }
}
