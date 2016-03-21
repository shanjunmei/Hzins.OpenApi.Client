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
   /// 车险预支付返回
   /// 
   /// </p>
   public class CarPrePayResp : BaseResp
   {
      ///  车险支付入口
      private String carPayEntranceUrl;
      
      public String getCarPayEntranceUrl()
         {
      return carPayEntranceUrl;
         }
      
      public void setCarPayEntranceUrl(ref String carPayEntranceUrl)
         {
      this.carPayEntranceUrl = carPayEntranceUrl;
         }
   
   }
}