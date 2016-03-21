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

namespace com.hzins.channel.api.model.req
{
   /// <summary>
   /// 服务费明细请求信息
   /// </summary>
   public class SettlementDetailReq : SubUserBaseReq
   {
      ///  投保单号(多个以英文逗号隔开)
      public String insureNums;
      ///  查询开始时间
      public String startTime;
      ///  查询结束时间
      public String endTime;
      ///  查询页数
      public int pageNum;
      ///  每页数量
      public int pageSize;

   }
}