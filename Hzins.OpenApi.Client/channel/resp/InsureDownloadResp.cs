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

namespace com.hzins.channel.api.model.resp
{
   /// <summary>
   /// 保单下载
   /// </summary>
   public class InsureDownloadResp
   {

      ///  文件名
      public String fileName;
      ///  文件大小
      public long fileSize;
      ///  类型
      public String contentType;
      ///  文件流
      public String data;
      /// 流水号
      public String transNo;

   }
}