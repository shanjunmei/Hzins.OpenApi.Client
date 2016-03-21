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

namespace com.hzins.channel.api.model.info
{
   /// <summary>
   /// 服务费明细信息
   /// </summary>
   public class SettlementDetailInfo
   {
      public String email;
      public String payDateTime;
      public String insureNum;
      public String productName;
      public decimal originalPrice;
      public decimal price;
      public decimal income;

   }
}