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
      public String applicationDate;
      ///  起保日期，保单的生效时间
      public String startDate;
      ///  终保日期，保单的失效时间
      public String endDate;
      ///  结算价，即相应保险产品的保费
      public decimal singlePrice;

   }
}