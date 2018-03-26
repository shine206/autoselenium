using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSelenium
{
    class Function
    {
        public string ActionToString(string action = "click", string url = "", string by ="", string element = "", string key = "", string sleep = "")
        {
            return string.Format("Action={0}|URL={1}|By={2}|Element={3}|Key={4}|Sleep={5}", action.ToLower(), url, by, element, key, sleep);
        }
    }
}
