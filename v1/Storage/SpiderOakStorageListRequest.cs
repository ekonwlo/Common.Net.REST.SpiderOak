using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Common.Net.REST.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Storage
{

    [RestRequest("storage/${share_id}/${device}/${path}")]
    public class SpiderOakStorageListRequest
        : SpiderOakStorageRequest<SpiderOakStorageListResponse>
    {

        [RestUrlParameterAttribute("${device}")]
        public string Device { get; set; }

        [RestUrlParameter("${path}", Mandatory = false)]
        public string Path { get; set; }

        internal SpiderOakStorageListRequest() : base() { }
    }
}
