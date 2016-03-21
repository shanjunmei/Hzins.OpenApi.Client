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

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 结算申请返回
   /// </p>
   public class SettlementBillTotalResp
   {
      private String transNo;
      private int partnerId;
      /// 已结算
      private decimal payed;
      /// 未结算
      private decimal unPayed;
      /// 当前可结算(不会根据时间条件查询)
      private decimal allowPayed;
      
      public String getTransNo()
      {
          return transNo;
      }
      
      public void setTransNo(ref String transNo)
      {
          this.transNo = transNo;
      }
      
      public int getPartnerId()
      {
          return partnerId;
      }
      
      public void setPartnerId(ref int partnerId)
      {
          this.partnerId = partnerId;
      }
      
      public decimal getPayed()
      {
          return payed;
      }
      
      public void setPayed(ref decimal payed)
      {
          this.payed = payed;
      }
      
      public decimal getUnPayed()
      {
          return unPayed;
      }
      
      public void setUnPayed(ref decimal unPayed)
      {
          this.unPayed = unPayed;
      }
      
      public decimal getAllowPayed()
      {
          return allowPayed;
      }
      
      public void setAllowPayed(ref decimal allowPayed)
      {
          this.allowPayed = allowPayed;
      }
   
   }
}