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
   /// <p>
   /// 
   /// </p>
   public class CpsPayReq : SubUserBaseReq
   {
      ///  投保单号，不是订单号
      private String orderNum;
      ///  普通类型，0为Pc.1为H5
      private int platformType;
      ///  支付成功之后返回链接(如果是cps支付，需填写，用户能有更好的体验)
      private String backUrl;
      ///  投保单号，兼容orderNum，为了统一，以后客户统一使用InsureNum
      private String insureNum;
      
      public String getBackUrl()
         {
      return backUrl;
         }
      
      public void setBackUrl(ref String backUrl)
         {
      this.backUrl = backUrl;
         }
      
      public String getOrderNum()
         {
      return orderNum;
         }
      
      public void setOrderNum(ref String orderNum)
         {
      this.orderNum = orderNum;
         }
      
      public int getPlatformType()
         {
      return platformType;
         }
      
      public void setPlatformType(ref int platformType)
         {
      this.platformType = platformType;
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