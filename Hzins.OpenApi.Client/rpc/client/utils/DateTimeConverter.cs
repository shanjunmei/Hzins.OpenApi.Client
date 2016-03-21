using Newtonsoft.Json.Converters;

namespace Hzins.OpenApi.Client.rpc.client.utils
{
    /// <summary>
    /// 时间格式化
    /// </summary>
    public class DateTimeConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTimeConverter()
        {
           DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }

    }
}
