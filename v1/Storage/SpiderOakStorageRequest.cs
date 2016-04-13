using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;
    using Transformation;

    public abstract class SpiderOakStorageRequest<T>
        : SpiderOakRequest<T> where T : SpiderOakStorageResponse
    {
        [RestUrlParameterAttribute("${share_id}")]
        [PropertyTransformation(typeof(Base32Transformation))]
        public string ShareId { get; set; }

        internal SpiderOakStorageRequest() : base() { }
    }
}
