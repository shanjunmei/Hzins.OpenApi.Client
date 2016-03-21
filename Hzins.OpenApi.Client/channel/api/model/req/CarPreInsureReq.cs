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
   /// 
   /// 车险预投保请求
   /// </p>
   public class CarPreInsureReq : CoreBaseReq
   {
      ///  平台标识
      private String platform;
      ///  渠道唯一用户标识
      private String partnerUniqueKey;
      
      public String getPlatform()
         {
      return platform;
         }
      
      public void setPlatform(ref String platform)
         {
      this.platform = platform;
         }
      
      public String getPartnerUniqueKey()
         {
      return partnerUniqueKey;
         }
      
      public void setPartnerUniqueKey(ref String partnerUniqueKey)
         {
      this.partnerUniqueKey = partnerUniqueKey;
         }
   
   }
}