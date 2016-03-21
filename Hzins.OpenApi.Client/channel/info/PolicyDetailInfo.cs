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
   /// 保单详情查询 保单明细（不包含保险人和被保险人）
   /// </p>
   public class PolicyDetailInfo
   {
      ///  总份数
      public int totalNum;
      /// 生效时间区间
      public String deallineText;
      ///  支付价
      public decimal buySinglePrice;
      ///  结算价
      public decimal settlementPrice;
      /// 保障项目
      public String insureProject;

   }
}