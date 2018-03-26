using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSelenium
{
    public partial class Form1 : Form
    {
        private UCGotoURL ucURL = new UCGotoURL();
        private Function fn = new Function();
        private ActionScript actionScript = new ActionScript();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbbAction.SelectedIndex = 0;
        }

        private void cbbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbAction.SelectedIndex)
            {
                case 1:
                    
                    ucURL.Left = 6;
                    ucURL.Top = 18;
                    pnAction.Height = ucURL.Height + 30;
                    pnAction.Controls.Add(ucURL);
                    break;
            }
        }

        private void btnAddToSrcipt_Click(object sender, EventArgs e)
        {
            string action = cbbAction.Text;
            string script = fn.ActionToString(action, ucURL.URL);
            MessageBox.Show(script);
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            List<Script> listScript = new List<Script>();
            for (int i = 0; i < 3; i++)
            {
                Script row = new Script();
                row.Action = "Click";
                row.By = "xxx";
                row.Key = "q23213";
                listScript.Add(row);
            }
            actionScript.arrayScript = listScript.ToArray();
            Console.WriteLine(actionScript.arrayScript.Length);
        }
    }
}
