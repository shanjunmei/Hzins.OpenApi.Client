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

namespace com.hzins.channel.api.model.req
{
   /// <summary>
   /// 
   /// </summary>
   public class CpsPayReq : SubUserBaseReq
   {
      ///  投保单号，不是订单号
      public String orderNum;
      ///  普通类型，0为Pc.1为H5
      public int platformType;
      ///  支付成功之后返回链接(如果是cps支付，需填写，用户能有更好的体验)
      public String backUrl;
      ///  投保单号，兼容orderNum，为了统一，以后客户统一使用InsureNum
      public String insureNum;

   }
}