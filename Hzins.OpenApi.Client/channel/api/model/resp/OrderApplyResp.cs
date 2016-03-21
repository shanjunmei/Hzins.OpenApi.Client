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
import com.hzins.channel.api.model.info.OrderExtInfo;
import com.hzins.channel.api.model.info.OrderInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 
   /// </p>
   public class OrderApplyResp
   {
      private String transNo;
      ///  代理商信息
      private int partnerId;
      ///  惠择投保单号
      private String insureNum;
      ///  保单信息
      private List<OrderInfo> orderInfos;
      
      public List<OrderExtInfo> getOrderExts()
      {
          return orderExts;
      }
      
      public void setOrderExts(ref List<OrderExtInfo> orderExts)
      {
          this.orderExts = orderExts;
      }
      
      public String getTransNo()
      {
          return transNo;
      }
      
      public void setTransNo(ref String transNo)
      {
          this.transNo = transNo;
      }
      
      public int getPartnerId()
      {
          return partnerId;
      }
      
      public void setPartnerId(ref int partnerId)
      {
          this.partnerId = partnerId;
      }
      
      public String getInsureNum()
      {
          return insureNum;
      }
      
      public void setInsureNum(ref String insureNum)
      {
          this.insureNum = insureNum;
      }
      
      public List<OrderInfo> getOrderInfos()
      {
          return orderInfos;
      }
      
      public void setOrderInfos(ref List<OrderInfo> orderInfos)
      {
          this.orderInfos = orderInfos;
      }
   
   }
}