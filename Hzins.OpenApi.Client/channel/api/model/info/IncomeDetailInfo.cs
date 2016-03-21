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
      private int settlementState;
      private int month;
      private String userId;
      private int year;
      /// 总计服务费(Income+Award)
      private decimal totalIncome;
      /// 总计保费
      private decimal premium;
      
      public int getSettlementState()
      {
          return settlementState;
      }
      
      public void setSettlementState(ref int settlementState)
      {
          this.settlementState = settlementState;
      }
      
      public int getMonth()
      {
          return month;
      }
      
      public void setMonth(ref int month)
      {
          this.month = month;
      }
      
      public String getUserId()
      {
          return userId;
      }
      
      public void setUserId(ref String userId)
      {
          this.userId = userId;
      }
      
      public int getYear()
      {
          return year;
      }
      
      public void setYear(ref int year)
      {
          this.year = year;
      }
      
      public decimal getTotalIncome()
      {
          return totalIncome;
      }
      
      public void setTotalIncome(ref decimal totalIncome)
      {
          this.totalIncome = totalIncome;
      }
      
      public decimal getPremium()
      {
          return premium;
      }
      
      public void setPremium(ref decimal premium)
      {
          this.premium = premium;
      }
   
   }
}