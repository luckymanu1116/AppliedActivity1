using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Java.Util.Jar.Attributes;

namespace COVID19.Models
{
    internal class Covid
    {
        public string Recovered { get; set; }
        public string Deaths { get; set; }
        public string Confirmed { get; set; }

        public Covid(string recovered, string deaths, string confirmed)
        {
            Recovered = recovered;
            Deaths = deaths;
            Confirmed= confirmed;
        }
    }

}

