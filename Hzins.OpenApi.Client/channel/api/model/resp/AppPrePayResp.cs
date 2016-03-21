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

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 支付接口返回参数
   /// </p>
   public class AppPrePayResp
   {
      private String transNo;
      ///  投保单号
      private String orderNum;
      private String insureNum;
      ///  调用支付的参数串
      private String gatewayData;
      
      public String getTransNo()
         {
      return transNo;
         }
      
      public void setTransNo(ref String transNo)
         {
      this.transNo = transNo;
         }
      
      public String getOrderNum()
         {
      return orderNum;
         }
      
      public void setOrderNum(ref String orderNum)
         {
      this.orderNum = orderNum;
         }
      
      public String getGatewayData()
         {
      return gatewayData;
         }
      
      public void setGatewayData(ref String gatewayData)
         {
      this.gatewayData = gatewayData;
         }
      
      public String getInsureNum()
         {
      return insureNum;
         }
      
      public void setInsureNum(ref String insureNum)
         {
      this.insureNum = insureNum;
         }
   
   }
}