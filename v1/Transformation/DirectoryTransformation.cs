using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.SpiderOak.v1.Transformation
{
    class DirectoryTransformation
        : IRestTransformation<SpiderOakDirectoryInfo[], string[][]>
    {
        public string[][] Transform(SpiderOakDirectoryInfo[] input)
        {
            
            
            
            
            return null;
        }

        public SpiderOakDirectoryInfo[] Revert(string[][] input)
        {
            
            return (from item in input
                    select new SpiderOakDirectoryInfo() {
                        Name = item[0].TrimEnd('/'),
                        Url = item[1]
                    }).ToArray();
           
        }
    }
}
