using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSelenium
{
    class Script
    {
        private string time;
        private string action;
        private string by;
        private string element;
        private string key;
        private string url;
        private string proxy;
        private string port;

        public Script()
        {
        }

        public Script(string action, string url, string by, string element, string key, string time, string proxy, string port)
        {
            this.action = action;
            this.url = url;
            this.by = by;
            this.element = element;
            this.key = key;
            this.time = time;
            this.proxy = proxy;
            this.port = port;

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

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public string Proxy
        {
            get
            {
                return proxy;
            }

            set
            {
                proxy = value;
            }
        }

        public string Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }
    }
}
