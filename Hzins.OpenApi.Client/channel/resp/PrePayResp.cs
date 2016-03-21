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
using com.hzins.channel.api.model;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 支付接口返回参数
   /// </p>
   public class PrePayResp
   {
      public String transNo;
      public String orderNum;
      public String insureNum;
      public com.hzins.channel.api.model.PrePayParam prePayParam;

   }
}