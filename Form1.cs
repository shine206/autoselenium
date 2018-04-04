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
using System.IO;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutoSelenium
{
    public partial class Form1 : Form
    {
        private string PATH_APP = System.IO.Directory.GetCurrentDirectory() + @"\Scripts\";
        private UCOpenSelenium ucOpen = new UCOpenSelenium();
        private UCGotoURL ucURL = new UCGotoURL();
        private UCClick ucClick = new UCClick();
        private UCSend ucSend = new UCSend();
        private UCSleep ucSleep = new UCSleep();
        private UCWait ucWait = new UCWait();
        private UCRunJavascript ucRunJs = new UCRunJavascript();
        private Function fn = new Function();
        private ActionScript actionScript = new ActionScript();
        private IWebDriver driver;
        private string script;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbAction.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
                case 5:
                    grbAction.Controls.Clear();
                    ucWait.Left = 6;
                    ucWait.Top = 18;
                    grbAction.Height = ucWait.Height + 30;
                    grbAction.Controls.Add(ucWait);
                    break;
                case 6:
                    grbAction.Controls.Clear();
                    break;
                case 7:
                    grbAction.Controls.Clear();
                    ucRunJs.Left = 6;
                    ucRunJs.Top = 18;
                    grbAction.Height = ucRunJs.Height + 30;
                    grbAction.Controls.Add(ucRunJs);
                    break;

                default:
                    MessageBox.Show("Chưa có user control");
                    break;
            }
        }

        private void btnAddToSrcipt_Click(object sender, EventArgs e)
        {
            addScript();
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {

            if (actionScript.dataScript(lvScript).Length > 0)
            {
                actionScript.runScript();
            }
            else
                MessageBox.Show("Chưa có kịch bản để chạy.");

        }

        private void btnTestScript_Click(object sender, EventArgs e)
        {
            testScript();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateScript();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (lvScript.SelectedIndices.Count > 0)
            {
                for (int i = lvScript.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lvScript.Items.RemoveAt(lvScript.SelectedIndices[i]);
                }
                MessageBox.Show("Xóa thành công.");
                btnAddToSrcipt.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
                MessageBox.Show("Bạn chưa chọn kịch bản muốn xóa.");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "AutoSelenium", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn.openFile(lvScript);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn.saveFile(lvScript);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionScript.dataScript(lvScript);
            actionScript.runScript();
        }


        //Function

        private void addScript()
        {
            string action = cbbAction.Text;
            if (action.ToLower().Contains("open selenium"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", ucOpen.browser, "", "", "", ucOpen.proxy, ucOpen.port);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("go to url"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, ucURL.URL);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("click"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", ucClick.byElement, ucClick.element);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("send"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", ucSend.byElement, ucSend.element, ucSend.key);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("sleep"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", "", "", "", ucSleep.time.ToString());
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("wait element"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", ucWait.byElement, ucWait.element, "", ucWait.time);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
                resetControl();
            }
            else if (action.ToLower().Contains("close selenium"))
            {
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action);
                lvScript.Items.Add(fn.AddScipt(id, action, script));
            }
            else if (action.ToLower().Contains("run javascript"))
            {
                string fileName = "Script" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt";
                File.WriteAllText(PATH_APP + fileName, ucRunJs.CodeJs);
                int id = lvScript.Items.Count + 1;
                script = fn.ActionToString(action, "", "", "", PATH_APP + fileName);
                lvScript.Items.Add(fn.AddScipt(id, cbbAction.Text, script));
                resetControl();

            }
        }

        private void updateScript()
        {
            try
            {
                switch (cbbAction.Text.ToLower())
                {
                    case "open selenium":
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", ucOpen.browser, "", "", "", ucOpen.proxy, ucOpen.port);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "go to url":
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, ucURL.URL);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "click":
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", ucClick.byElement, ucClick.element);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "send":

                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", ucSend.byElement, ucSend.element, ucSend.key);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "wait element":
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", ucWait.byElement, ucWait.element, "", ucWait.time);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "sleep":
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", "", "", "", ucSleep.time);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    case "run javascript":
                        string fileName = "Script" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt";
                        File.WriteAllText(PATH_APP + fileName, ucRunJs.CodeJs);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[1].Text = cbbAction.Text;
                        script = fn.ActionToString(cbbAction.Text, "", "", "", PATH_APP + fileName);
                        lvScript.Items[lvScript.SelectedIndices[0]].SubItems[2].Text = script;
                        resetControl();
                        break;
                    default:

                        break;
                }
                MessageBox.Show("Sửa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại.");
            }

        }

        //Test
        private void testScript()
        {
            switch (cbbAction.Text.ToLower())
            {
                case "open selenium":
                    try
                        {
                            if (ucOpen.browser.Contains("FireFox"))
                            {
                                if (ucOpen.proxy == "" | ucOpen.port == "")
                                {
                                    driver = new FirefoxDriver();

                                }
                                else
                                {

                                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                                    firefoxProfile.SetPreference("network.proxy.type", 1);
                                    // điền vào IP của proxy
                                    firefoxProfile.SetPreference("network.proxy.http", ucOpen.proxy);
                                    // điền vào port
                                    firefoxProfile.SetPreference("network.proxy.http_port", int.Parse(ucOpen.port));
                                    firefoxProfile.SetPreference("network.proxy.ssl", ucOpen.proxy);
                                    firefoxProfile.SetPreference("network.proxy.ssl_port", int.Parse(ucOpen.port));

                                    // khởi tạo WebDriver
                                    driver = new FirefoxDriver(firefoxProfile);
                                }
                            }
                            else
                            {
                                if (ucOpen.proxy == "" | ucOpen.port == "")
                                {
                                    driver = new ChromeDriver();
                                    Console.WriteLine("sssss");
                                }
                                else
                                {
                                    Console.WriteLine("Dang dooi proxy");
                                    ChromeOptions options = new ChromeOptions();
                                    var proxy = new Proxy();
                                    proxy.Kind = ProxyKind.Manual;
                                    proxy.IsAutoDetect = false;
                                    proxy.HttpProxy = proxy.SslProxy = ucOpen.proxy + ":" + ucOpen.port;
                                    options.Proxy = proxy;
                                    options.AddArgument("ignore-certificate-errors");
                                    var chromedriver = new ChromeDriver(options);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi! Không mở được selenium!!!");
                        }
                        break;
                case "go to url":
                        if (ucURL.URL != null)
                        {
                            if (Uri.IsWellFormedUriString(ucURL.URL, UriKind.RelativeOrAbsolute))
                                try
                                {
                                    driver.Url = ucURL.URL;

                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Lỗi proxy!!!");
                                }
                            else
                                MessageBox.Show("Url sai.");
                        }
                        else
                            MessageBox.Show("Bạn chưa nhập URL");
                    break;
                case "click":
                    try
                    {
                        if (ucClick.byElement.Contains("Xpath"))
                            driver.FindElement(By.XPath("" + ucClick.element)).Click();
                        else if (ucClick.byElement.Contains("Class"))
                            driver.FindElement(By.ClassName(ucClick.element)).Click();
                        else
                            driver.FindElement(By.Id(ucClick.element)).Click();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Element sai!!!!");
                    }

                    break;
                case "send":
                    try
                    {
                        if (ucSend.byElement.Contains("Xpath"))
                            driver.FindElement(By.XPath(ucSend.element)).SendKeys(ucSend.key);
                        else if (ucSend.byElement.Contains("Class"))
                            driver.FindElement(By.ClassName(ucSend.element)).SendKeys(ucSend.key);
                        else
                            driver.FindElement(By.Id(ucSend.element)).SendKeys(ucSend.key);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Element sai!!!!");
                    }
                    break;
                case "wait element":
                    try
                    {
                        if (ucWait.byElement.Contains("Xpath"))
                            new WebDriverWait(driver, TimeSpan.FromSeconds(double.Parse(ucWait.time))).Until(ExpectedConditions.ElementExists(By.XPath(ucWait.element)));
                        else if (ucWait.byElement.Contains("Class"))

                            new WebDriverWait(driver, TimeSpan.FromSeconds(double.Parse(ucWait.time))).Until(ExpectedConditions.ElementExists(By.ClassName(ucWait.element)));
                        else
                            new WebDriverWait(driver, TimeSpan.FromSeconds(double.Parse(ucWait.time))).Until(ExpectedConditions.ElementExists(By.Id(ucWait.element)));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Element sai!!!!");
                        
                    }

                    break;
                case "sleep":
                    try
                    {
                        Thread.Sleep(int.Parse(ucSleep.time));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Het time!!!!");
                        
                    }
                    break;
                case "run javascript":
                    try
                    {
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript(ucRunJs.CodeJs);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi!!!!");
                        
                    }

                    break;
                case "close selenium":
                    try
                    {
                        driver.Dispose();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi!!!!");
                        
                    }

                    break;
                default:

                    break;
            }

        }

        private void lvScript_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAddToSrcipt.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            ListViewHitTestInfo info = lvScript.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
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
                    ucOpen.proxy = dic["proxy"];
                    ucOpen.port = dic["port"];
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
                    grbAction.Controls.Clear();
                    ucWait.Left = 6;
                    ucWait.Top = 18;
                    grbAction.Height = ucWait.Height + 30;
                    grbAction.Controls.Add(ucWait);
                    cbbAction.Text = dic["action"];
                    ucWait.byElement = dic["by"];
                    ucWait.element = dic["element"];
                    ucWait.time = dic["time"];
                    break;
                case "sleep":
                    grbAction.Controls.Clear();
                    ucSleep.Left = 6;
                    ucSleep.Top = 18;
                    grbAction.Height = ucSleep.Height + 30;
                    grbAction.Controls.Add(ucSleep);
                    cbbAction.Text = dic["action"];
                    ucSleep.time = dic["time"];
                    break;
                default:

                    break;
            }
        }

        //Reset data các control
        public void resetControl()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddToSrcipt.Enabled = true;
            ucOpen.proxy = "";
            ucOpen.port = "";
            ucURL.URL = "";
            ucClick.byElement = "";
            ucClick.element = "";
            ucSend.byElement = "";
            ucSend.element = "";
            ucSend.key = "";
            ucSleep.time = "";
            ucWait.time = "";
            ucWait.element = "";
            ucRunJs.CodeJs = "";
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            resetControl();
        }
    }
}
