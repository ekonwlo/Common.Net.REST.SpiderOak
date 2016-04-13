using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Runtime.Serialization.Transformation;
using Base32;

namespace Common.Net.REST.SpiderOak.v1.Transformation
{
    class Base32Transformation
        : IRestTransformation<string, string>
    {
        public string Transform(string input)
        {
            return Base32Encoder.Encode(Encoding.UTF8.GetBytes(input)).TrimEnd('=');
        }

        public string Revert(string input)
        {
            throw new NotImplementedException();
        }
    }
}
