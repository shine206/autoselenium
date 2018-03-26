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
        private UCOpenSelenium ucOpen = new UCOpenSelenium();
        private UCGotoURL ucURL = new UCGotoURL();
        private UCClick ucClick = new UCClick();
        private UCSend ucSend = new UCSend();
        private Function fn = new Function();
        private UCSleep ucSleep = new UCSleep();
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
                case 0:
                    grbAction.Controls.Clear();
                    ucOpen.Left = 6;
                    ucOpen.Top = 18;
                    grbAction.Height = ucOpen.Height + 30;
                    grbAction.Controls.Add(ucOpen);
                    break;
                case 1:
                    grbAction.Controls.Clear();
                    ucURL.Left = 6;
                    ucURL.Top = 18;
                    grbAction.Height = ucURL.Height + 30;
                    grbAction.Controls.Add(ucURL);
                    break;
                case 2:
                    grbAction.Controls.Clear();
                    ucClick.Left = 6;
                    ucClick.Top = 18;
                    grbAction.Height = ucClick.Height + 30;
                    grbAction.Controls.Add(ucClick);
                    break;
                case 3:
                    grbAction.Controls.Clear();
                    ucSend.Left = 6;
                    ucSend.Top = 18;
                    grbAction.Height = ucSend.Height + 30;
                    grbAction.Controls.Add(ucSend);
                    break;
                case 4:
                    grbAction.Controls.Clear();
                    ucSleep.Left = 6;
                    ucSleep.Top = 18;
                    grbAction.Height = ucSleep.Height + 30;
                    grbAction.Controls.Add(ucSleep);
                    break;
                case 6:
                    grbAction.Controls.Clear();
                    break;
                default:
                    MessageBox.Show("Chưa có user control");
                    break;
            }
        }

        private void btnAddToSrcipt_Click(object sender, EventArgs e)
        {
            string action = cbbAction.Text;
            if (action.ToLower().Contains("open selenium"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action,"",ucOpen.browser);
                lvScript.Items.Add(fn.AddScipt(id, action,script));
            }
            else if (action.ToLower().Contains("go to url"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action, ucURL.URL);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucURL.URL = "";
            }
            else if (action.ToLower().Contains("click"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action,"",ucClick.byElement,ucClick.element);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucClick.byElement = "";
                ucClick.element = "";
            }
            else if (action.ToLower().Contains("send"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action,"", ucSend.byElement, ucSend.element, ucSend.key);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucSend.byElement = "";
                ucSend.element = "";
                ucSend.key = "";
            }
            else if (action.ToLower().Contains("sleep"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action, ucClick.byElement, ucClick.element);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
            }
            else if (action.ToLower().Contains("wait element"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action, ucClick.byElement, ucClick.element);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
            }
            else if (action.ToLower().Contains("close selenium"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
            }

            
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            actionScript.dataScript(lvScript);
            actionScript.runScript();
            
        }
    }
}
