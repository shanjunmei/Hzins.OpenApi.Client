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
using System.Collections.Generic;

namespace com.hzins.channel.api.model.info
{
   /// <summary>
   /// 
   /// </summary>
   public class OrderExtInfo
   {
      ///  惠择投保单号
      public String insureNum;
      ///  被保人id集合
      public List<String> insurantIds;
      ///  被保人数量
      public int insurantCount;
      /// 本单总价
      public decimal priceTotal;
      public Dictionary<String, String> insurantDictionary;

   }
}