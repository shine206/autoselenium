using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AutoSelenium
{
    class ActionScript
    {
        public Script[] arrayScript
        {
            get; set;
        }

        private Dictionary<string, string> filterScript(string actionScript)
        { 
            //Action={0}|URL={1}|By={2}|Element={3}|Key={4}|Sleep={5}
            Match match = Regex.Match(actionScript , @"Action=(.*?)\|URL=(.*?)\|By=(.*?)\|Element=(.*?)\|Key=(.*?)\|Sleep=(.*?)");
            return new Dictionary<string, string>{
                {"action", match.Groups[1].Value},
                {"url", match.Groups[2].Value},
                {"by", match.Groups[3].Value},
                {"element", match.Groups[4].Value},
                {"key", match.Groups[5].Value},
                {"sleep", match.Groups[6].Value}
            };
        }

        public void dataScript(ListView lvScript) {
            List<Script> listscript = new List<Script>();
            for (int i = 0; i < lvScript.Items.Count; i++)
            {
                string dataListView = lvScript.Items[i].SubItems[2].Text;
                Dictionary<string, string> dic = filterScript(dataListView);
                
                Script row = new Script();
                row.Action = dic["action"];
                row.By = dic["by"];
                row.Url = dic["url"];
                row.Element = dic["element"];
                row.Key = dic["key"];
                row.Sleep = dic["sleep"];
                listscript.Add(row);
            }
            arrayScript = listscript.ToArray();
        }

        public void runScript()
        {
            for (int i = 0; i < arrayScript.Length; i++)
            {
                Console.WriteLine(arrayScript[i].Action);    
            }
            
        }

    }
}
