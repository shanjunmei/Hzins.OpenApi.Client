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
      private int accountType;
      /// 开户行
      private String bankName;
      /// 户名
      private String accountName;
      /// 银行账号
      private String bankAccount;
      /// 支付宝账户
      private String aliPayAccount;
      /// 性别
      private short sex;
      /// 身份证号码
      private String cardnumber;
      /// 户籍所在地省份
      private String provinces;
      /// 户籍所在地城市
      private String city;
      /// 工作单位
      private String unit;
      /// 通讯地址
      private String address;
      /// 邮政编码
      private String zipcode;
      /// 开户行所在省
      private String bankProvince;
      /// 开户行所在城市
      private String bankCity;
      /// 开户行分行支行
      private String bankBranchName;
      
      public int getAccountType()
      {
          return accountType;
      }
      
      public void setAccountType(ref int accountType)
      {
          this.accountType = accountType;
      }
      
      public String getBankName()
      {
          return bankName;
      }
      
      public void setBankName(ref String bankName)
      {
          this.bankName = bankName;
      }
      
      public String getAccountName()
      {
          return accountName;
      }
      
      public void setAccountName(ref String accountName)
      {
          this.accountName = accountName;
      }
      
      public String getBankAccount()
      {
          return bankAccount;
      }
      
      public void setBankAccount(ref String bankAccount)
      {
          this.bankAccount = bankAccount;
      }
      
      public String getAliPayAccount()
      {
          return aliPayAccount;
      }
      
      public void setAliPayAccount(ref String aliPayAccount)
      {
          this.aliPayAccount = aliPayAccount;
      }
      
      public short getSex()
      {
          return sex;
      }
      
      public void setSex(ref short sex)
      {
          this.sex = sex;
      }
      
      public String getCardnumber()
      {
          return cardnumber;
      }
      
      public void setCardnumber(ref String cardnumber)
      {
          this.cardnumber = cardnumber;
      }
      
      public String getProvinces()
      {
          return provinces;
      }
      
      public void setProvinces(ref String provinces)
      {
          this.provinces = provinces;
      }
      
      public String getCity()
      {
          return city;
      }
      
      public void setCity(ref String city)
      {
          this.city = city;
      }
      
      public String getUnit()
      {
          return unit;
      }
      
      public void setUnit(ref String unit)
      {
          this.unit = unit;
      }
      
      public String getAddress()
      {
          return address;
      }
      
      public void setAddress(ref String address)
      {
          this.address = address;
      }
      
      public String getZipcode()
      {
          return zipcode;
      }
      
      public void setZipcode(ref String zipcode)
      {
          this.zipcode = zipcode;
      }
      
      public String getBankProvince()
      {
          return bankProvince;
      }
      
      public void setBankProvince(ref String bankProvince)
      {
          this.bankProvince = bankProvince;
      }
      
      public String getBankCity()
      {
          return bankCity;
      }
      
      public void setBankCity(ref String bankCity)
      {
          this.bankCity = bankCity;
      }
      
      public String getBankBranchName()
      {
          return bankBranchName;
      }
      
      public void setBankBranchName(ref String bankBranchName)
      {
          this.bankBranchName = bankBranchName;
      }
   
   }
}