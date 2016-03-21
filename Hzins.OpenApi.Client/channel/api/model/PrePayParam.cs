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

namespace com.hzins.channel.api.model
{
   /// <p>
   /// 
   /// </p>
   public class PrePayParam
   {
      private String payUrl;
      private int onliePaymnetId;
      private String bsId;
      private String price;
      private int partnerId;
      private int consumeType;
      private int companyId;
      private int productId;
      private String productName;
      private int bankId;
      private String notifyUrl;
      private String isNoDeal;
      private String deadline;
      private String sign;
      private String payOrderNumber;
      private String payToInsurer;
      private String ip;
      private String traceId;
      private String openId;
      private String descript;
      private String wxPayType;
      private String serviceNotifyUrl;
      
      public String getServiceNotifyUrl()
      {
          return serviceNotifyUrl;
      }
      
      public void setServiceNotifyUrl(ref String serviceNotifyUrl)
      {
          this.serviceNotifyUrl = serviceNotifyUrl;
      }
      
      public String getTraceId()
      {
          return traceId;
      }
      
      public void setTraceId(ref String traceId)
      {
          this.traceId = traceId;
      }
      
      public String getOpenId()
      {
          return openId;
      }
      
      public void setOpenId(ref String openId)
      {
          this.openId = openId;
      }
      
      public String getDescript()
      {
          return descript;
      }
      
      public void setDescript(ref String descript)
      {
          this.descript = descript;
      }
      
      public String getWxPayType()
      {
          return wxPayType;
      }
      
      public void setWxPayType(ref String wxPayType)
      {
          this.wxPayType = wxPayType;
      }
      
      public String getIp()
      {
          return ip;
      }
      
      public void setIp(ref String ip)
      {
          this.ip = ip;
      }
      
      public String getPayUrl()
      {
          return payUrl;
      }
      
      public void setPayUrl(ref String payUrl)
      {
          this.payUrl = payUrl;
      }
      
      public int getOnliePaymnetId()
      {
          return onliePaymnetId;
      }
      
      public void setOnliePaymnetId(ref int onliePaymnetId)
      {
          this.onliePaymnetId = onliePaymnetId;
      }
      
      public String getBsId()
      {
          return bsId;
      }
      
      public void setBsId(ref String bsId)
      {
          this.bsId = bsId;
      }
      
      public String getPrice()
      {
          return price;
      }
      
      public void setPrice(ref String price)
      {
          this.price = price;
      }
      
      public int getPartnerId()
      {
          return partnerId;
      }
      
      public void setPartnerId(ref int partnerId)
      {
          this.partnerId = partnerId;
      }
      
      public int getConsumeType()
      {
          return consumeType;
      }
      
      public void setConsumeType(ref int consumeType)
      {
          this.consumeType = consumeType;
      }
      
      public int getCompanyId()
      {
          return companyId;
      }
      
      public void setCompanyId(ref int companyId)
      {
          this.companyId = companyId;
      }
      
      public int getProductId()
      {
          return productId;
      }
      
      public void setProductId(ref int productId)
      {
          this.productId = productId;
      }
      
      public String getProductName()
      {
          return productName;
      }
      
      public void setProductName(ref String productName)
      {
          this.productName = productName;
      }
      
      public int getBankId()
      {
          return bankId;
      }
      
      public void setBankId(ref int bankId)
      {
          this.bankId = bankId;
      }
      
      public String getNotifyUrl()
      {
          return notifyUrl;
      }
      
      public void setNotifyUrl(ref String notifyUrl)
      {
          this.notifyUrl = notifyUrl;
      }
      
      public String getIsNoDeal()
      {
          return isNoDeal;
      }
      
      public void setIsNoDeal(ref String isNoDeal)
      {
          this.isNoDeal = isNoDeal;
      }
      
      public String getDeadline()
      {
          return deadline;
      }
      
      public void setDeadline(ref String deadline)
      {
          this.deadline = deadline;
      }
      
      public String getSign()
      {
          return sign;
      }
      
      public void setSign(ref String sign)
      {
          this.sign = sign;
      }
      
      public String getPayOrderNumber()
      {
          return payOrderNumber;
      }
      
      public void setPayOrderNumber(ref String payOrderNumber)
      {
          this.payOrderNumber = payOrderNumber;
      }
      
      public String getPayToInsurer()
      {
          return payToInsurer;
      }
      
      public void setPayToInsurer(ref String payToInsurer)
      {
          this.payToInsurer = payToInsurer;
      }
   
   }
}