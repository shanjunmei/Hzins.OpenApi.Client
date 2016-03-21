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
   /// <p>
   /// 查询保单列表
   /// </p>
   public class SearchInsureResp
   {
      /// 代理商编号
      public int partnerId;
      /// 交易流水号，每一单请求交易不能相同
      public String transNo;
      /// 保单列表
      public List<OrderDetailInfo> orderDetailInfos;
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}