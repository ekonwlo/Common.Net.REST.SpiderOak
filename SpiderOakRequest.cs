using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Net.REST.SpiderOak
{
    using Attributes;

    public abstract class SpiderOakRequest<T>
        : RestRequest<T> where T : SpiderOakResponse
	{
        
        internal protected SpiderOakRequest() : base() { }
	}
}
