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
   /// 结算申请返回
   /// </p>
   public class SettlementBillTotalResp
   {
      public String transNo;
      public int partnerId;
      /// 已结算
      public decimal payed;
      /// 未结算
      public decimal unPayed;
      /// 当前可结算(不会根据时间条件查询)
      public decimal allowPayed;

   }
}