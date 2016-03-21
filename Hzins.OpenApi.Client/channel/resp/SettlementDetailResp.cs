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
using com.hzins.channel.api.model.info;

namespace com.hzins.channel.api.model.resp
{
   /// <summary>
   /// 	服务费明细返回实体
   /// </summary>
   public class SettlementDetailResp
   {
      /// 流水号
      public String transNo;
      /// 代理商编号
      public int partnerId;
      public int pageNum;
      public int pageSize;
      public int total;
      ///     public int pageIndex;
      /// 服务费明细信息
      public List<SettlementDetailInfo> settlementDetailList;

   }
}

//    
//
//
//    
//    