using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage.Content
{
    using Attributes;

    public class SpiderOakStorageDeviceListResponseContent
    {

        [RestContent("stats")]
        public SpiderOakStorageStats Statistics { get; internal set; }

        [RestContent("devices")]
        public SpiderOakDeviceInfo[] Devices { get; internal set; }

        [RestContent("syncfolder")]
        public SpiderOakSyncFolderInfo SyncFolder { get; internal set; }

        internal SpiderOakStorageDeviceListResponseContent() { }
    }
}
