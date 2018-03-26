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
    public partial class UCGotoURL : UserControl
    {

        public string URL {
            get { return txtURL.Text; }
            set { txtURL.Text = value;  }
        }
        public UCGotoURL()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCGotoURL_Load(object sender, EventArgs e)
        {

        }
    }
}
