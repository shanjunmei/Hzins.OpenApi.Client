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

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 结算前每月汇总查询请求参数
   /// </p>
   public class IncomeDetailReq : BaseReq
   {
      ///  渠道唯一的标识
      public List<String> userIds;
      ///  年份
      public int year;
      ///  月份
      public int month;

   }
}