using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Share
{

    [RestRequest("share/${share_id}/${room_key}/${path}")]
    public class SpiderOakShareListRequest
        : SpiderOakShareRequest<SpiderOakShareListResponse>
    {

        [RestUrlParameter("${path}", Mandatory = false)]
        public string Path { get; set; }

        internal SpiderOakShareListRequest() : base() { }
    }
}
