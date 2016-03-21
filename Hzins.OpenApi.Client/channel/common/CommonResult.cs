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
      public int respCode;
      public String respMsg;
      public T data;
      
      public CommonResult()
      {
      
      }
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}