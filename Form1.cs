using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

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
        private IWebDriver driver;
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
                string script = fn.ActionToString(action, "", ucOpen.browser);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
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
                string script = fn.ActionToString(action, "", ucClick.byElement, ucClick.element);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucClick.byElement = "";
                ucClick.element = "";
            }
            else if (action.ToLower().Contains("send"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action, "", ucSend.byElement, ucSend.element, ucSend.key);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucSend.byElement = "";
                ucSend.element = "";
                ucSend.key = "";
            }
            else if (action.ToLower().Contains("sleep"))
            {
                int id = lvScript.Items.Count + 1;
                string script = fn.ActionToString(action,"","","","",ucSleep.time.ToString());
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                ucSleep.time = "";
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

        private void btnTestScript_Click(object sender, EventArgs e)
        {
            if (lvScript.Items.Count > 0)
            {
                actionScript.dataScript(lvScript);
                actionScript.runScript();
                switch (cbbAction.Text.ToLower())
                {
                    case "open selenium":
                        if (cbbAction.Text.Contains("FireFox"))
                        {
                            driver = new FirefoxDriver();
                        }
                        else
                        {
                            driver = new ChromeDriver();
                        }
                        break;
                    case "go to url":
                        driver.Url = ucURL.URL;
                        break;
                    case "click":
                        if (ucClick.byElement.Contains("Xpath"))
                            if (driver.FindElement(By.XPath("" + ucClick.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.XPath(""+ucClick.element)).Click();
                        else if (ucClick.byElement.Contains("Class"))
                            if (driver.FindElement(By.ClassName(ucClick.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.ClassName(ucClick.element)).Click();
                        else
                            if (driver.FindElement(By.Id(ucClick.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.Id(ucClick.element)).Click();
                        break;
                    case "send":
                        if (ucSend.byElement.Contains("Xpath"))
                            if (driver.FindElement(By.XPath(ucSend.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.XPath(ucSend.element)).SendKeys(ucSend.key);
                        else if (ucSend.byElement.Contains("Class"))
                            if (driver.FindElement(By.ClassName(ucSend.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.ClassName(ucSend.element)).SendKeys(ucSend.key);
                        else
                            if (driver.FindElement(By.Id(ucSend.element)) != null)
                                MessageBox.Show("Success!");
                            else
                                MessageBox.Show("Fail!");
                        //driver.FindElement(By.Id(ucSend.element)).SendKeys(ucSend.key);
                        break;
                    case "wait element":

                        break;
                    default:
                        if (driver != null)
                        {
                            driver.Close();
                        }
                        break;


                }
            }
        }

        private void lvScript_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            Dictionary<string, string> dic = actionScript.filterScript(item.SubItems[2].Text);
            switch (dic["action"])
            {
                case "open selenium":
                    grbAction.Controls.Clear();
                    ucOpen.Left = 6;
                    ucOpen.Top = 18;
                    grbAction.Height = ucOpen.Height + 30;
                    grbAction.Controls.Add(ucOpen);
                    cbbAction.Text = dic["action"];
                    ucOpen.browser = dic["by"];
                    break;
                case "go to url":
                    grbAction.Controls.Clear();
                    ucURL.Left = 6;
                    ucURL.Top = 18;
                    grbAction.Height = ucURL.Height + 30;
                    grbAction.Controls.Add(ucURL);
                    cbbAction.Text = dic["action"];
                    ucURL.URL = dic["url"];
                    break;
                case "click":
                    grbAction.Controls.Clear();
                    ucClick.Left = 6;
                    ucClick.Top = 18;
                    grbAction.Height = ucClick.Height + 30;
                    grbAction.Controls.Add(ucClick);
                    cbbAction.Text = dic["action"];
                    ucClick.byElement = dic["by"];
                    ucClick.element = dic["element"];
                    break;
                case "send":
                     grbAction.Controls.Clear();
                    ucSend.Left = 6;
                    ucSend.Top = 18;
                    grbAction.Height = ucSend.Height + 30;
                    grbAction.Controls.Add(ucSend);
                    cbbAction.Text = dic["action"];
                    ucSend.byElement = dic["by"];
                    ucSend.element = dic["element"];
                    ucSend.key = dic["key"];
                    break;
                case "wait element":

                    break;
                case "sleep":
                    grbAction.Controls.Clear();
                    ucSleep.Left = 6;
                    ucSleep.Top = 18;
                    grbAction.Height = ucSleep.Height + 30;
                    grbAction.Controls.Add(ucSleep);
                    cbbAction.Text = dic["action"];
                    ucSleep.time = dic["sleep"];
                    break;
                default:
                    
                    break;
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lvScript.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lvScript.Items.RemoveAt(lvScript.SelectedIndices[i]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (cbbAction.Text.ToLower())
            {
                case "open selenium":
                    grbAction.Controls.Clear();
                    ucOpen.Left = 6;
                    ucOpen.Top = 18;
                    grbAction.Height = ucOpen.Height + 30;
                    grbAction.Controls.Add(ucOpen);
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = cbbAction.Text;
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = ucOpen.browser;
                    break;
                case "go to url":
                    grbAction.Controls.Clear();
                    ucURL.Left = 6;
                    ucURL.Top = 18;
                    grbAction.Height = ucURL.Height + 30;
                    grbAction.Controls.Add(ucURL);
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = cbbAction.Text;
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = ucURL.URL;
                    break;
                case "click":
                    grbAction.Controls.Clear();
                    ucClick.Left = 6;
                    ucClick.Top = 18;
                    grbAction.Height = ucClick.Height + 30;
                    grbAction.Controls.Add(ucClick);
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = cbbAction.Text;
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = ucClick.byElement;
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = ucClick.element;
                    break;
                case "send":
                     grbAction.Controls.Clear();
                    ucSend.Left = 6;
                    ucSend.Top = 18;
                    grbAction.Height = ucSend.Height + 30;
                    grbAction.Controls.Add(ucSend);
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = cbbAction.Text;
                    string by = ucSend.byElement;
                    string element = ucSend.element;
                    string key = ucSend.key;
                    break;
                case "wait element":

                    break;
                case "sleep":
                    grbAction.Controls.Clear();
                    ucSleep.Left = 6;
                    ucSleep.Top = 18;
                    grbAction.Height = ucSleep.Height + 30;
                    grbAction.Controls.Add(ucSleep);
                    lvScript.Items[lvScript.SelectedIndices.ToString()].SubItems[0].Text = cbbAction.Text;
                    string time = ucSleep.time;
                    break;
                default:
                    
                    break;
            }    
           
            
        }
    }
}
