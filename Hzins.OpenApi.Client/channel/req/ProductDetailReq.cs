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
   /// <summary>
   /// 产品详情请求信息
   /// </summary>
   public class ProductDetailReq : BaseReq
   {
      ///  产品ID
      public int productId;
      ///  产品计划Id
      public int planId;

   }
}