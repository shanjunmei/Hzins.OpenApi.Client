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
   /// 
   /// 
   /// 
   /// </p>
   public class RegisterResp
   {
      private String transNo;
      private int partnerId;
      private String usreId;
      
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
      
      public String getUsreId()
      {
          return usreId;
      }
      
      public void setUsreId(ref String usreId)
      {
          this.usreId = usreId;
      }
   
   }
}