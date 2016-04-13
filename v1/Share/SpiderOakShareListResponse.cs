using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Share
{
    using Content;

    public class SpiderOakShareListResponse
        : SpiderOakShareResponse
    {

        [RestContent("content")]
        public SpiderOakShareListResponseContent Content { get; internal set; }

        internal SpiderOakShareListResponse() : base() { }
    }
}
