using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage.Content
{
    using Attributes;

    public class SpiderOakStorageVersionInfoResponseContent
    {
        [RestContent("versions")]
        public SpiderOakVersionInfo[] Versions { get; internal set; }

        internal SpiderOakStorageVersionInfoResponseContent() { }
    }
}
