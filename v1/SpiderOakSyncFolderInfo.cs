using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1
{
    using Attributes;
    using Transformation;

    public class SpiderOakSyncFolderInfo
    {
        [RestContent("device")]
        public string Device { get; internal set; }

        //"device_encoded": "work/", 
    
        [RestContent("device_path")]
        public string DevicePath { get; internal set; }
         
        [RestContent("mtime")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime ModificationTime { get; internal set; }
                
        [RestContent("name")]
        public string Name { get; internal set; }

        [RestContent("url")]
        public string Url { get; internal set; }
 
        internal SpiderOakSyncFolderInfo() { }
    }
}
