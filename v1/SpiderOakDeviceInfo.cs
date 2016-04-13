using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1
{
    using Attributes;
    using Transformation;

    public class SpiderOakDeviceInfo
    {
        [RestContent("name")]
        public string Name { get; internal set; }
        
        [RestContent("encoded")]
        public string Encoded { get; internal set; }
        
        [RestContent("lastcommit")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime LastCommit { get; internal set; }

        [RestContent("lastlogin")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime LastLogin { get; internal set; }

        [RestContent("sysplatform")]
        public string Sysplatform { get; internal set; }

        internal SpiderOakDeviceInfo() { }
    }
}
