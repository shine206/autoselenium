using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Threading;

namespace AutoSelenium
{
    class ActionScript
    {
        private IWebDriver driver;
        public Script[] getdataScript
        {
            get; set;
        }

        public Dictionary<string, string> filterScript(string actionScript)
        { 
            //Action={0}|URL={1}|By={2}|Element={3}|Key={4}|Sleep={5}
            Match match = Regex.Match(actionScript , @"Action=(.*?)\|URL=(.*?)\|By=(.*?)\|Element=(.*?)\|Key=(.*?)\|Time=(.*?)\|");
            return new Dictionary<string, string>{
                {"action", match.Groups[1].Value},
                {"url", match.Groups[2].Value},
                {"by", match.Groups[3].Value},
                {"element", match.Groups[4].Value},
                {"key", match.Groups[5].Value},
                {"time", match.Groups[6].Value}
            };
        }

        public Array dataScript(ListView lvScript) {
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
                row.Time = dic["time"];
                listscript.Add(row);
            }
            getdataScript = listscript.ToArray();
            return getdataScript;
        }

        public void runScript()
        {
            for (int i = 0; i < getdataScript.Length; i++)
            {
                switch (getdataScript[i].Action)
                {
                    case "open selenium":
                        try
                        {
                            if (getdataScript[i].By.Contains("FireFox"))
                            {
                                driver = new FirefoxDriver();
                            }
                            else
                            {
                                driver = new ChromeDriver();
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi!!!!"+e);
                            throw;
                        }
                        break;
                    case "go to url":

                        if (Uri.IsWellFormedUriString(getdataScript[i].Url, UriKind.RelativeOrAbsolute))
                            driver.Url = getdataScript[i].Url;
                        else
                            MessageBox.Show("Url sai.");
                        break;
                    case "click":
                        try
                        {
                            if (getdataScript[i].By.Contains("Xpath"))
                                driver.FindElement(By.XPath("" + getdataScript[i].Element)).Click();
                            else if (getdataScript[i].By.Contains("Class"))
                                driver.FindElement(By.ClassName(getdataScript[i].Element)).Click();
                            else
                                driver.FindElement(By.Id(getdataScript[i].Element)).Click();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Element sai!!!!");
                        }
                        
                        break;
                    case "send":
                        try
                        {
                            if (getdataScript[i].By.Contains("Xpath"))
                                driver.FindElement(By.XPath(getdataScript[i].Element)).SendKeys(getdataScript[i].Key);
                            else if (getdataScript[i].By.Contains("Class"))
                                driver.FindElement(By.ClassName(getdataScript[i].Element)).SendKeys(getdataScript[i].Key);
                            else
                                driver.FindElement(By.Id(getdataScript[i].Element)).SendKeys(getdataScript[i].Key);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Element sai!!!!");
                        }
                        break;
                    case "wait element":
                        try
                        {
                            if (getdataScript[i].By.Contains("Xpath"))
                                new WebDriverWait(driver, TimeSpan.FromSeconds(int.Parse(getdataScript[i].Time))).Until(ExpectedConditions.ElementExists(By.XPath(getdataScript[i].Element)));
                            else if (getdataScript[i].By.Contains("Class"))

                                new WebDriverWait(driver, TimeSpan.FromSeconds(int.Parse(getdataScript[i].Time))).Until(ExpectedConditions.ElementExists(By.ClassName(getdataScript[i].Element)));
                            else
                                new WebDriverWait(driver, TimeSpan.FromSeconds(int.Parse(getdataScript[i].Time))).Until(ExpectedConditions.ElementExists(By.Id(getdataScript[i].Element)));
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Element sai!!!!" + e);
                            throw;
                        }
                        
                        break;
                    case "sleep":
                        try
                        {
                            Thread.Sleep(int.Parse(getdataScript[i].Time));
                            driver.Quit();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Het time!!!!" + e);
                            throw;
                        }
                        break;
                    case "run javascript":
                        try
                        {
                            string codeJS = File.ReadAllText(getdataScript[i].Key);
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            js.ExecuteScript(codeJS);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi!!!!" + e);
                            throw;
                        }
                        
                        break;
                    case"close selenium":
                        try
                        {
                            driver.Dispose();

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Lỗi!!!!" + e);
                            throw;
                        }
                        
                        break;
                    default:
                        
                        break;
                }    
            }
            
        }

    }
}
