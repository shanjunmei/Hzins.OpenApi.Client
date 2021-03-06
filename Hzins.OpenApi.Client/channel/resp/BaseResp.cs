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
   /// 返回基础类
   /// </summary>
   public abstract class BaseResp
   {
      ///  交易流水号，每一单请求交易不能相同
      public String transNo;
      ///  代理商编号
      public int partnerId;

   }
}