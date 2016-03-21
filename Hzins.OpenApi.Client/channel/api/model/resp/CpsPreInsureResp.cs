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
   public class CpsPreInsureResp : BaseResp
   {
      /// 产品详情地址
      private String detailUrl;
      
      public String getDetailUrl()
      {
          return detailUrl;
      }
      
      public void setDetailUrl(ref String detailUrl)
      {
          this.detailUrl = detailUrl;
      }
   
   }
}