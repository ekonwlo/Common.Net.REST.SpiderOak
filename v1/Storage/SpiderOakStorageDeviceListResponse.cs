using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;
    using Content;

    public class SpiderOakStorageDeviceListResponse
        : SpiderOakStorageResponse
    {

        [RestContent("content")]
        public SpiderOakStorageDeviceListResponseContent Content { get; internal set; }

        internal SpiderOakStorageDeviceListResponse() : base() { }
    }
}
