using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;
    using Content;

    public class SpiderOakStorageVersionInfoResponse
        : SpiderOakStorageResponse
    {

        //[RestContent("content")]
        //public SpiderOakStorageVersionInfoResponseContent Content { get; internal set; }
        [RestContent("versions")]
        public SpiderOakVersionInfo[] Versions { get; internal set; }

        internal SpiderOakStorageVersionInfoResponse() : base() { }
    }
}
