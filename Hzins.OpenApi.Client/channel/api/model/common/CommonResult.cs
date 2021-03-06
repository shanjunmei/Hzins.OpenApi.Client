using System;

namespace com.hzins.channel.api.model.common
{
   /// /**
   ///  * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
   ///  *
   ///  * This code is the confidential and proprietary information of   
   ///  * Hzins. You shall not disclose such Confidential Information   
   ///  * and shall use it only in accordance with the terms of the agreements   
   ///  * you entered into with Hzins,http://www.hzins.com.
   ///  *
   ///  */
   /// <p>
   /// 
   /// 统一返回对象
   /// 
   /// </p>
   public class CommonResult<T>
   {
      private int respCode;
      private String respMsg;
      private T data;
      
      public CommonResult()
      {
      
      }
      
      public int getRespCode()
         {
      return respCode;
         }
      
      public void setRespCode(ref int respCode)
         {
      this.respCode = respCode;
         }
      
      public String getRespMsg()
         {
      return respMsg;
         }
      
      public void setRespMsg(ref String respMsg)
         {
      this.respMsg = respMsg;
         }
      
      public T getData()
         {
      return data;
         }
      
      public void setData(ref T data)
         {
      this.data = data;
         }
   
   }
}