using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;
using Common.Runtime.Serialization.Transformation;
using Common.Net.REST;

namespace Common.Net.REST.SpiderOak.v1.Share
{
    using Attributes;
    using v1.Transformation;

    public abstract class SpiderOakShareRequest<T>
        : RestRequest<T> where T : SpiderOakShareResponse
    {
        [RestUrlParameterAttribute("${share_id}")]
        [PropertyTransformation(typeof(Base32Transformation))]
        public string ShareId { get; set; }
        
        [RestUrlParameterAttribute("${room_key}")]
        public string RoomKey { get; set; }
                
        internal SpiderOakShareRequest() : base() { }
    }
}
