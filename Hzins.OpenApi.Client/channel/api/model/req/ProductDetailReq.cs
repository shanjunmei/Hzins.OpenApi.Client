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
   /// 产品详情请求信息
   /// </p>
   public class ProductDetailReq : BaseReq
   {
      ///  产品ID
      private int productId;
      ///  产品计划Id
      private int planId;
      
      public int getProductId()
         {
      return productId;
         }
      
      public void setProductId(ref int productId)
         {
      this.productId = productId;
         }
      
      public int getPlanId()
         {
      return planId;
         }
      
      public void setPlanId(ref int planId)
         {
      this.planId = planId;
         }
   
   }
}