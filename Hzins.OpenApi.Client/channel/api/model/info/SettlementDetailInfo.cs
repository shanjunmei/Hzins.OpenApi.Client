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
   /// 服务费明细信息
   /// </p>
   public class SettlementDetailInfo
   {
      private String email;
      private String payDateTime;
      private String insureNum;
      private String productName;
      private decimal originalPrice;
      private decimal price;
      private decimal income;
      
      public String getEmail()
      {
          return email;
      }
      
      public void setEmail(ref String email)
      {
          this.email = email;
      }
      
      public String getInsureNum()
      {
          return insureNum;
      }
      
      public void setInsureNum(ref String insureNum)
      {
          this.insureNum = insureNum;
      }
      
      public String getProductName()
      {
          return productName;
      }
      
      public void setProductName(ref String productName)
      {
          this.productName = productName;
      }
      
      public decimal getOriginalPrice()
      {
          return originalPrice;
      }
      
      public void setOriginalPrice(ref decimal originalPrice)
      {
          this.originalPrice = originalPrice;
      }
      
      public decimal getPrice()
      {
          return price;
      }
      
      public void setPrice(ref decimal price)
      {
          this.price = price;
      }
      
      public decimal getIncome()
      {
          return income;
      }
      
      public void setIncome(ref decimal income)
      {
          this.income = income;
      }
      
      public String getPayDateTime()
      {
          return payDateTime;
      }
      
      public void setPayDateTime(ref String payDateTime)
      {
          this.payDateTime = payDateTime;
      }
   
   }
}