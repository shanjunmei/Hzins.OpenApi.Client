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
using com.hzins.channel.api.model.info;

namespace com.hzins.channel.api.model.req
{
   /// <summary>
   /// 退保请求消息
   /// </summary>
   public class OrderCancelReq : BaseReq
   {
      public String insureNo;
      public String insureNum;
      ///  扩展信息
      public com.hzins.channel.api.model.info.ExtendInfo extendInfo;

   }
}