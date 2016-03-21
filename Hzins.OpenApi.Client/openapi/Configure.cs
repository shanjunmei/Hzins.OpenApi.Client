/**
 * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
 *  
 * This code is the confidential and proprietary information of   
 * Hzins. You shall not disclose such Confidential Information   
 * and shall use it only in accordance with the terms of the agreements   
 * you entered into with Hzins,http://www.hzins.com.
 *  
 */

using System;

namespace com.hzins.openapi.client
{
    /// <p>
    /// 
    /// 
    /// 
    /// </p>
    public class Configure
    {
        /// <summary>
        /// 渠道配置信息
        /// </summary>
        public class Channel
        {
            /// 22803
            /// <summary>
            /// 渠道号
            /// </summary>
            public static int? partnerId = null;
            /// 22803^*#%
            /// <summary>
            /// 渠道密钥
            /// </summary>

            public static String channelKey = null;

        }
        /// <summary>
        /// 请求配置
        /// </summary>
        public class Request
        {
            /// <summary>
            /// 请求前缀，默认可用
            /// </summary>
            public static String baseUrl = "http://channel.hzins.com/api/";
            /// <summary>
            ///  连接超时时间 ms为单位
            /// </summary>
            public static int http_connection_timeout = 0;
            /// <summary>
            /// 读取相应超时时间 ms为单位 默认为0，系统默认超时时间，根据操作系统而定
            /// </summary>
            public static int http_read_timeout = 0;
            /// <summary>
            /// userAgent
            /// </summary>
            public const String userAgent = "Channel OpenApi Sdk(v1.1)";
            /// <summary>
            /// contentType
            /// </summary>
            public const String contentType = "application/json;charset=UTF-8";

        }

    }
}