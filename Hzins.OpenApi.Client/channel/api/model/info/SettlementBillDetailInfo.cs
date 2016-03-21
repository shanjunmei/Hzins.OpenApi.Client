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
   /// 申请结算明细信息
   /// </p>
   public class SettlementBillDetailInfo
   {
      /// 申请服务费结算之后的settlementBill数据的Id
      private int billId;
      /// 结算年份
      private int year;
      /// 结算月度
      private int month;
      /// 结算周期
      private String range;
      /// 申请结算时间
      private String createTime;
      /// 用户类型(0表示渠道，1表示代理商)
      private int userType;
      /// 应付收入(税前)
      private decimal applyFee;
      /// 代扣税款
      private decimal deductTax;
      /// 应付收入(税后)
      private decimal payFee;
      /// 结算状态(0未结算，1表示已结算)
      private int state;
      
      public int getYear()
      {
          return year;
      }
      
      public void setYear(ref int year)
      {
          this.year = year;
      }
      
      public int getMonth()
      {
          return month;
      }
      
      public void setMonth(ref int month)
      {
          this.month = month;
      }
      
      public String getRange()
      {
          return range;
      }
      
      public void setRange(ref String range)
      {
          this.range = range;
      }
      
      public String getCreateTime()
      {
          return createTime;
      }
      
      public void setCreateTime(ref String createTime)
      {
          this.createTime = createTime;
      }
      
      public decimal getApplyFee()
      {
          return applyFee;
      }
      
      public void setApplyFee(ref decimal applyFee)
      {
          this.applyFee = applyFee;
      }
      
      public decimal getDeductTax()
      {
          return deductTax;
      }
      
      public void setDeductTax(ref decimal deductTax)
      {
          this.deductTax = deductTax;
      }
      
      public decimal getPayFee()
      {
          return payFee;
      }
      
      public void setPayFee(ref decimal payFee)
      {
          this.payFee = payFee;
      }
      
      public int getUserType()
      {
          return userType;
      }
      
      public void setUserType(ref int userType)
      {
          this.userType = userType;
      }
      
      public int getState()
      {
          return state;
      }
      
      public void setState(ref int state)
      {
          this.state = state;
      }
      
      public int getBillId()
      {
          return billId;
      }
      
      public void setBillId(ref int billId)
      {
          this.billId = billId;
      }
   
   }
}