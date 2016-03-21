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
using System.Collections.Generic;
using com.hzins.channel.api.model;

namespace com.hzins.channel.api.model.resp
{
   public class ProductDetailResp : BaseResp
   {
      public String productName;
      public String planName;
      public int productId;
      ///     public String introduction;
      public int planId;
      public List<PlanDetail> planDetails;
      ///     public List<Dictionary<String, String>> planParams;
      public decimal price;

   }
}