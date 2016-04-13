using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Content;

    public class SpiderOakStorageListResponse
        : SpiderOakStorageResponse
    {

        [RestContent("content")]
        public SpiderOakStorageListResponseContent Content { get; internal set; }

        internal SpiderOakStorageListResponse() : base() { }
    }
}
