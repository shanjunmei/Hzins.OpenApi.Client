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
   /// <p>
   /// 服务费按月汇总详细信息
   /// </p>
   public class IncomeDetailInfo
   {
      /// 0为未结算，1为结算中，2为已经结算
      public int settlementState;
      public int month;
      public String userId;
      public int year;
      /// 总计服务费(Income+Award)
      public decimal totalIncome;
      /// 总计保费
      public decimal premium;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}