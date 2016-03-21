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
   /// <p>
   /// 保单下载
   /// </p>
   public class InsureDownloadResp
   {
      public String getTransNo()
      {
          return transNo;
      }
      
      public void setTransNo(ref String transNo)
      {
          this.transNo = transNo;
      }
      
      public String getFileName()
      {
          return fileName;
      }
      
      public void setFileName(ref String fileName)
      {
          this.fileName = fileName;
      }
      
      public long getFileSize()
      {
          return fileSize;
      }
      
      public void setFileSize(ref long fileSize)
      {
          this.fileSize = fileSize;
      }
      
      public String getContentType()
      {
          return contentType;
      }
      
      public void setContentType(ref String contentType)
      {
          this.contentType = contentType;
      }
      
      public String getData()
      {
          return data;
      }
      
      public void setData(ref String data)
      {
          this.data = data;
      }
      
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