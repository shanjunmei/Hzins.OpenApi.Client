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
import com.hzins.channel.api.model.info.ExtendInfo;

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 退保请求消息
   /// </p>
   public class OrderCancelReq : BaseReq
   {
      private String insureNo;
      private String insureNum;
      ///  扩展信息
      private com.hzins.channel.api.model.info.ExtendInfo extendInfo;
      
      public String getInsureNo()
         {
      return insureNo;
         }
      
      public void setInsureNo(ref String insureNo)
         {
      this.insureNo = insureNo;
         }
      
      public com.hzins.channel.api.model.info.ExtendInfo getExtendInfo()
         {
      return extendInfo;
         }
      
      public void setExtendInfo(ref com.hzins.channel.api.model.info.ExtendInfo extendInfo)
         {
      this.extendInfo = extendInfo;
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