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
using com.hzins.channel.api.model.info;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 
   /// 
   /// 
   /// </p>
   public class CarInsureDetailResp : BaseResp
   {
      /// 车辆信息
      public com.hzins.channel.api.model.info.CarInfo carInfo;
      /// 投保单信息
      public com.hzins.channel.api.model.info.CarInsureInfo insure;

   }
}