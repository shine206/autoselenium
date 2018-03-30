using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSelenium
{
    class Function
    {
        public string ActionToString(string action = "click", string url = "", string by = "", string element = "", string key = "", string time = "")
        {
            return string.Format("Action={0}|URL={1}|By={2}|Element={3}|Key={4}|Time={5}|", action.ToLower(), url, by, element, key, time);
        }

        public ListViewItem AddScipt(int id = 1, string action = "", string script = "")
        {
            string[] row = { id.ToString(), action, script };
            var listViewItem = new ListViewItem(row);
            return listViewItem;
        }
        public void openFile(ListView lvScript)
        {
            string path, line;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                path = theDialog.FileName.ToString();
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] kq = line.Split('&');
                    ListViewItem lvi = new ListViewItem(kq[0]);
                    lvi.SubItems.Add(kq[1]);
                    lvi.SubItems.Add(kq[2]);
                    lvScript.Items.Add(lvi);
                }
                file.Dispose();
            }
            theDialog.Dispose();
        }
        public void saveFile(ListView lvScript)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < lvScript.Items.Count; i++)
                {
                    string id = lvScript.Items[i].SubItems[0].Text;
                    string action = lvScript.Items[i].SubItems[1].Text;
                    string script = lvScript.Items[i].SubItems[2].Text;
                    myStream.WriteLine(id + "&" + action + "&" + script);

                }
                myStream.Close();
            }
            saveFileDialog1.Dispose();
        }
    }
}
