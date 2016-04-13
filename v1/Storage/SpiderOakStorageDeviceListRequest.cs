using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak.v1.Storage
{
    using Attributes;

    [RestRequest("storage/${share_id}/?device_info=yes")]
    public class SpiderOakStorageDeviceListRequest
        : SpiderOakStorageRequest<SpiderOakStorageDeviceListResponse>
    {




        internal SpiderOakStorageDeviceListRequest() : base() { }
    }
}
