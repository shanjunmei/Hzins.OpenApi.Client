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
   /// 
   /// </p>
   public class ApiPartnerInsureReq : BaseReq
   {
      /// 投保单号
      private String insureNum;
      
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