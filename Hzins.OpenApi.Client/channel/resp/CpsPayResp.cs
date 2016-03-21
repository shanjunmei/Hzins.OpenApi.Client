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
   /// 异步投保 在线CPS页面支付
   /// 返回的实体（含支付链接）
   /// </p>
   public class CpsPayResp : java.io.Serializable
   {
      public const long serialVersionUID = -710272183659427282L;
      public String transNo;
      public String insureNum;
      public String paymentUrl;

   }
}