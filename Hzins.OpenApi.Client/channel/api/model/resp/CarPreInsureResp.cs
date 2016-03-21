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
   /// 车险预投保返回
   /// 
   /// </p>
   public class CarPreInsureResp : BaseResp
   {
      ///  车险入口
      private String carInsureEntranceUrl;
      
      public String getCarInsureEntranceUrl()
         {
      return carInsureEntranceUrl;
         }
      
      public void setCarInsureEntranceUrl(ref String carInsureEntranceUrl)
         {
      this.carInsureEntranceUrl = carInsureEntranceUrl;
         }
   
   }
}