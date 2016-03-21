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
   /// <p>
   /// 结算申请请求信息
   /// </p>
   public class SettlementBillDetailReq : SubUserBaseReq
   {
      ///  申请服务费结算之后的settlementBill数据的Id
      public int billId;
      ///  查询的申请结算开始时间
      public String startTime;
      ///  查询的申请结算结束时间
      public String endTime;
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}