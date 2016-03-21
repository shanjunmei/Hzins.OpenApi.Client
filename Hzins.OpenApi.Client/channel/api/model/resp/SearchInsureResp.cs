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
import java.util.List;
import com.hzins.channel.api.model.info.OrderDetailInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 查询保单列表
   /// </p>
   public class SearchInsureResp
   {
      /// 代理商编号
      private int partnerId;
      /// 交易流水号，每一单请求交易不能相同
      private String transNo;
      /// 保单列表
      private List<OrderDetailInfo> orderDetailInfos;
      
      public int getPartnerId()
      {
          return partnerId;
      }
      
      public void setPartnerId(ref int partnerId)
      {
          this.partnerId = partnerId;
      }
      
      public String getTransNo()
      {
          return transNo;
      }
      
      public void setTransNo(ref String transNo)
      {
          this.transNo = transNo;
      }
      
      public List<OrderDetailInfo> getOrderDetailInfos()
      {
          return orderDetailInfos;
      }
      
      public void setOrderDetailInfos(ref List<OrderDetailInfo> orderDetailInfos)
      {
          this.orderDetailInfos = orderDetailInfos;
      }
   
   }
}