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
   /// 寿险健康险专用实体（旅意险不考虑）
   /// </p>
   public class HealthInfo
   {
      /// *********************************
      /// 保单密码
      public String insurePassword;
      ///  持卡人卡号
      public String backPayAccount;
      ///  持卡人姓名
      public String backPayName;
      ///  赎回银行ID
      public int backPayBank;
      ///  赎回银行名称
      public String backPayBankName;
      ///  年收入
      public decimal insuredYearlyIncome;
      /// *********************************
      /// 续期缴费银行
      public int renewalPayBank;
      /// 续期缴费银行名称
      public String renewalPayBankName;
      /// 续期缴费户名
      public String renewalPayName;
      /// 续期缴费账号
      public String renewalPayAccount;
      /// 健康告知ID
      public int notifyAnswerId;

   }
}