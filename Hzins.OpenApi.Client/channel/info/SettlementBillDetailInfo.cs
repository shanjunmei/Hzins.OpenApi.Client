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
      public int billId;
      /// 结算年份
      public int year;
      /// 结算月度
      public int month;
      /// 结算周期
      public String range;
      /// 申请结算时间
      public String createTime;
      /// 用户类型(0表示渠道，1表示代理商)
      public int userType;
      /// 应付收入(税前)
      public decimal applyFee;
      /// 代扣税款
      public decimal deductTax;
      /// 应付收入(税后)
      public decimal payFee;
      /// 结算状态(0未结算，1表示已结算)
      public int state;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}