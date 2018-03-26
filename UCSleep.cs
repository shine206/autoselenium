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
        public int time
        {
            get { return int.Parse(txtTime.Text); }
            set { txtTime.Text = value.ToString(); }
        }
    }
}
