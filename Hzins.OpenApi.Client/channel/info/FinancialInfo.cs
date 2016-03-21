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
   /// api服务费提现财务信息实体
   /// </p>
   public class FinancialInfo
   {
      /// 账户类型，0银行，1支付宝,2未设置，3会员，10其它
      public int accountType;
      /// 开户行
      public String bankName;
      /// 户名
      public String accountName;
      /// 银行账号
      public String bankAccount;
      /// 支付宝账户
      public String aliPayAccount;
      /// 性别
      public short sex;
      /// 身份证号码
      public String cardnumber;
      /// 户籍所在地省份
      public String provinces;
      /// 户籍所在地城市
      public String city;
      /// 工作单位
      public String unit;
      /// 通讯地址
      public String address;
      /// 邮政编码
      public String zipcode;
      /// 开户行所在省
      public String bankProvince;
      /// 开户行所在城市
      public String bankCity;
      /// 开户行分行支行
      public String bankBranchName;

   }
}