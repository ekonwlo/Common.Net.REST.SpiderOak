﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1
{
    using Attributes;
    using Transformation;

    public class SpiderOakVersionInfo
    {

        private string _url;

        [RestContent("url")]
        public string Url
        {
            get 
            {
                return _url;
            }
            internal set
            { 
                _url = value;
                Version = int.Parse(_url.Split('=').Last());
            }
        }

        public int Version { get; private set; }

        [RestContent("name")]
        public string Name { get; internal set; }
        
        [RestContent("size")]
        public long Size { get; internal set; }

        [RestContent("ctime")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime CreationTime { get; internal set; }

        [RestContent("mtime")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime ModificationTime { get; internal set; }

        //[RestContent("etime")]
        //[PropertyTransformation(typeof(UnixTimeStampTransformation))]
        //public DateTime ETime { get; set; }

        [RestContent("preview_25", Mandatory = false)]
        public string Preview25 { get; internal set; }

        [RestContent("preview_48", Mandatory = false)]
        public string Preview48 { get; internal set; }

        [RestContent("preview_228", Mandatory = false)]
        public string Preview228 { get; internal set; }

        [RestContent("preview_800", Mandatory = false)]
        public string Preview800 { get; internal set; }

        internal SpiderOakVersionInfo() { }
    }
}
