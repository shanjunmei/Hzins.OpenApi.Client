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
   public class ApplicationData
   {
      ///  投保时间
      private String applicationDate;
      ///  起保日期，保单的生效时间
      private String startDate;
      ///  终保日期，保单的失效时间
      private String endDate;
      ///  结算价，即相应保险产品的保费
      private decimal singlePrice;
      
      public String getApplicationDate()
      {
          return applicationDate;
      }
      
      public void setApplicationDate(ref String applicationDate)
      {
          this.applicationDate = applicationDate;
      }
      
      public String getStartDate()
      {
          return startDate;
      }
      
      public void setStartDate(ref String startDate)
      {
          this.startDate = startDate;
      }
      
      public String getEndDate()
      {
          return endDate;
      }
      
      public void setEndDate(ref String endDate)
      {
          this.endDate = endDate;
      }
      
      public decimal getSinglePrice()
      {
          return singlePrice;
      }
      
      public void setSinglePrice(ref decimal singlePrice)
      {
          this.singlePrice = singlePrice;
      }
   
   }
}