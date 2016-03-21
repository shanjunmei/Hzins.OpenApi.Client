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
   /// 投保单信息
   /// </summary>
   public class OrderDetailInfo
   {
      public String insureNum;
      ///  保单类型，2待完成，3未支付，4已支付
      public int payState;
      ///  (1 未支付;10 未出单;20 已出单;30 延时出单;40 取消出单)
      public int issueState;
      ///  生效状(1 未生效;2 已生效;3 已退保 21 退保中)
      public int effectiveState;
      ///  投保时间
      public String insureTime;
      ///  总份数
      public int totalNum;
      ///  价格
      public decimal price;
      public String productName;
      public String planName;
      ///  起保时间
      public String startDate;
      ///  截止时间
      public String endDate;
      ///  保险期限
      public String deadline;
      ///  保险公司名称
      public String companyName;
      ///  投保人姓名
      public String applicant;
      ///  被保险人姓名
      public String insurant;
      ///  保险公司保单号
      public String policyNum;
      /// 方案代码
      public String caseCode;

   }
}