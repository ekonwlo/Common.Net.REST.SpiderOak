using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;

    [RestRequest("storage/${share_id}/${device}/${path}")]
    public class SpiderOakStorageGetFileRequest
        : SpiderOakStorageRequest<SpiderOakStorageGetFileResponse>
    {

        [RestUrlParameterAttribute("${device}")]
        public string Device { get; set; }

        [RestUrlParameter("${path}")]
        public string Path { get; set; }

        [RestUrlParameter("version", Mandatory = false)]
        public int? Version { get; set; }

        internal SpiderOakStorageGetFileRequest() : base() { }
    }
}
