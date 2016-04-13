using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1
{
    using Attributes;
    using Transformation;

    public class SpiderOakShareStats
    {
        
        [RestContent("start_date")]
        [PropertyTransformation(typeof(UnixTimeStampTransformation))]
        public DateTime StartDate { get; internal set; }
        
        [RestContent("room_name")]
        public string RoomName { get; internal set; }

        [RestContent("room_description")]
        public string RoomDescription { get; internal set; }

        [RestContent("number_of_files")]
        public long FilesCount { get; internal set; }

        [RestContent("number_of_folders")]
        public long FoldersCount { get; internal set; }
        
        [RestContent("firstname")]
        public string Firstname { get; internal set; }
        
        [RestContent("lastname")]
        public string Lastname { get; internal set; }

        internal SpiderOakShareStats() { }
    }
}
