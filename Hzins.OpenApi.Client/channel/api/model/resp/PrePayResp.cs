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
import com.hzins.channel.api.model.PrePayParam;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 支付接口返回参数
   /// </p>
   public class PrePayResp
   {
      private String transNo;
      private String orderNum;
      private String insureNum;
      private com.hzins.channel.api.model.PrePayParam prePayParam;
      
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
      
      public com.hzins.channel.api.model.PrePayParam getPrePayParam()
         {
      return prePayParam;
         }
      
      public void setPrePayParam(ref com.hzins.channel.api.model.PrePayParam prePayParam)
         {
      this.prePayParam = prePayParam;
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