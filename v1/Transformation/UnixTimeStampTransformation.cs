using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;

namespace Common.Net.REST.SpiderOak.v1.Transformation
{
    class UnixTimeStampTransformation
        : IRestTransformation<DateTime, double>
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public double Transform(DateTime input)
        {
            return (DateTime.Now.ToUniversalTime() - _epoch).TotalSeconds;
        }

        public DateTime Revert(double input)
        {
            return _epoch.AddSeconds(input);
        }
    }
}
