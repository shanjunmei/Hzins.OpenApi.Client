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
import java.util.List;
import com.hzins.channel.api.model.PlanDetail;

namespace com.hzins.channel.api.model.resp
{
   public class ProductDetailResp : BaseResp
   {
      private String productName;
      private String planName;
      private int productId;
      ///     private String introduction;
      private int planId;
      private List<PlanDetail> planDetails;
      ///     private List<Map<String, String>> planParams;
      private decimal price;
      
      public List<PlanDetail> getPlanDetails()
      {
          return planDetails;
      }
      
      public void setPlanDetails(ref List<PlanDetail> planDetails)
      {
          this.planDetails = planDetails;
      }
      
      public String getPlanName()
      {
          return planName;
      }
      
      public void setPlanName(ref String planName)
      {
          this.planName = planName;
      }
      
      public int getPlanId()
         {
      return planId;
         }
      
      public void setPlanId(ref int planId)
         {
      this.planId = planId;
         }
      
      public decimal getPrice()
         {
      return price;
         }
      
      public void setPrice(ref decimal price)
         {
      this.price = price;
         }
      
      public String getProductName()
      {
          return productName;
      }
      
      public void setProductName(ref String productName)
      {
          this.productName = productName;
      }
      
      public int getProductId()
      {
          return productId;
      }
      
      public void setProductId(ref int productId)
      {
          this.productId = productId;
      }
   
   }
}