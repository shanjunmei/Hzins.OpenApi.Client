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

namespace com.hzins.channel.api.model.info
{
   /// <p>
   /// 保单详情查询 保单明细（不包含保险人和被保险人）
   /// </p>
   public class PolicyDetailInfo
   {
      ///  总份数
      private int totalNum;
      /// 生效时间区间
      private String deallineText;
      ///  支付价
      private decimal buySinglePrice;
      ///  结算价
      private decimal settlementPrice;
      /// 保障项目
      private String insureProject;
      
      public int getTotalNum()
      {
          return totalNum;
      }
      
      public void setTotalNum(ref int totalNum)
      {
          this.totalNum = totalNum;
      }
      
      public String getDeallineText()
      {
          return deallineText;
      }
      
      public void setDeallineText(ref String deallineText)
      {
          this.deallineText = deallineText;
      }
      
      public decimal getBuySinglePrice()
      {
          return buySinglePrice;
      }
      
      public void setBuySinglePrice(ref decimal buySinglePrice)
      {
          this.buySinglePrice = buySinglePrice;
      }
      
      public decimal getSettlementPrice()
      {
          return settlementPrice;
      }
      
      public void setSettlementPrice(ref decimal settlementPrice)
      {
          this.settlementPrice = settlementPrice;
      }
      
      public String getInsureProject()
      {
          return insureProject;
      }
      
      public void setInsureProject(ref String insureProject)
      {
          this.insureProject = insureProject;
      }
   
   }
}