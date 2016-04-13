using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1
{
    using Attributes;

    public class SpiderOakStorageStats
    {
        //firstname: "the users's first name",
        [RestContent("firstname")]
        public string FirstName { get; internal set; }
                
        //lastname: "the users's last name"
        [RestContent("lastname")]
        public string LastName { get; internal set; }
        
        //devices: <number of devices>,
        [RestContent("devices")]
        public int Devices { get; internal set; }
        
        //backupsize: "amount of data backed up",
        [RestContent("backupsize_for_robots")]
        public long BackupSize { get; internal set; }
                
        //size: <storage plan size in GB>
        [RestContent("size_for_robots")]
        public long StoragePlanSize { get; internal set; }

        [RestContent("billing_url")]
        public string BillingUrl { get; internal set; }

        internal SpiderOakStorageStats() { }
    }
}
