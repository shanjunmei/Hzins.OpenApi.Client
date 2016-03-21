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
using System.Collections.Generic;

namespace com.hzins.channel.api.model.info
{
   /// <summary>
   /// 
   /// 
   /// 
   /// </summary>
   public class ApiPartnerInsureInfo
   {
      /// 渠道用户身份标识
      public String partnerUniqueKey;
      /// 投保单号
      public String insureNo;
      /// 订单详情
      public List<OrderDetailInfo> orderDetailInfos;

   }
}