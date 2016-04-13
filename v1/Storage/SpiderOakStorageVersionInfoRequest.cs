using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;

    [RestRequest("storage/${share_id}/${device}/${path}?format=version_info")]
    public class SpiderOakStorageVersionInfoRequest
        : SpiderOakStorageRequest<SpiderOakStorageVersionInfoResponse>
    {

        [RestUrlParameterAttribute("${device}")]
        public string Device { get; set; }

        [RestUrlParameter("${path}")]
        public string Path { get; set; }

        internal SpiderOakStorageVersionInfoRequest() : base() { }
    }
}
