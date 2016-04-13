using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Attributes;

namespace Common.Net.REST.SpiderOak.v1.Storage.Content
{
    using Attributes;
    using Transformation;

    public class SpiderOakStorageListResponseContent
    {

        [RestContent("files", Mandatory = false)]
        public SpiderOakFileInfo[] Files { get; internal set; }

        [RestContent("dirs")]
        [PropertyTransformation(typeof(DirectoryTransformation))]
        public SpiderOakDirectoryInfo[] Directories { get; internal set; }

        internal SpiderOakStorageListResponseContent() { }

    }
}
