using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hzins.OpenApi.Client.rpc.client.utils
{
    class DateTimeConverter : IsoDateTimeConverter
    {
        public DateTimeConverter()
        {
            DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':ss'";
        }
    }
}
