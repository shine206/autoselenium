using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSelenium
{
    class Script
    {
        private string sleep;
        private string action;
        private string by;
        private string element;
        private string key;
        private string url;

        public Script()
        {
        }

        public Script(string action, string url, string by, string element, string key, string sleep)
        {
            this.action = action;
            this.url = url;
            this.by = by;
            this.element = element;
            this.key = key;
            this.sleep = sleep;
        }

        public string Action
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public string By
        {
            get
            {
                return by;
            }

            set
            {
                by = value;
            }
        }

        public string Element
        {
            get
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public string Sleep
        {
            get
            {
                return sleep;
            }

            set
            {
                sleep = value;
            }
        }
    }
}
