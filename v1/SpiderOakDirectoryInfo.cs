using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.SpiderOak.v1
{
    public class SpiderOakDirectoryInfo
    {

        [RestContent("url")]
        public string Url { get; internal set; }

        [RestContent("name")]
        public string Name { get; internal set; }

        internal SpiderOakDirectoryInfo() { }
    }
}
