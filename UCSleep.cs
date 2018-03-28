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
    public partial class UCSleep : UserControl
    {
        public UCSleep()
        {
            InitializeComponent();
        }
        public string time
        {
            get { return txtTime.Text; }
            set { txtTime.Text = value; }
        }

        private void UCSleep_Load(object sender, EventArgs e)
        {

        }
    }
}
