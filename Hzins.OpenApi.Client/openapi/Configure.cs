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
      public class Channel
      {
         /// 22803
         public static int? partnerId = null;
         /// 22803^*#%
         public static String channelKey = null;

      }

      public class Request
      {
         public static String baseUrl = "http://channel.hzins.com/api/";
         ///  ms为单位
         public static int http_connection_timeout = 0;
         ///  默认为0，系统默认超时时间，根据操作系统而定
         ///  ms为单位
         public static int http_read_timeout = 0;
         ///  默认为0，系统默认超时时间，根据操作系统而定
         public const String userAgent = "Channel OpenApi Sdk(v1.1)";
         public const String contentType = "application/json;charset=UTF-8";

      }

   }
}