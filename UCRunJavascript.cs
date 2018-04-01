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
    public partial class UCRunJavascript : UserControl
    {
        public string CodeJs
        {
            get { return rtxtCode.Text; }
            set { rtxtCode.Text = value; }
        }

        public UCRunJavascript()
        {
            InitializeComponent();
        }
    }
}
