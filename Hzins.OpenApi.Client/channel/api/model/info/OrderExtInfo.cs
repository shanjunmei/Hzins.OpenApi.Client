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
import java.util.Map;

namespace com.hzins.channel.api.model.info
{
   /// <p>
   /// 
   /// </p>
   public class OrderExtInfo
   {
      ///  惠择投保单号
      private String insureNum;
      ///  被保人id集合
      private List<String> insurantIds;
      ///  被保人数量
      private int insurantCount;
      /// 本单总价
      private decimal priceTotal;
      private Map<String, String> insurantMap;
      
      public Map<String, String> getInsurantMap()
      {
          return insurantMap;
      }
      
      public void setInsurantMap(ref Map<String, String> insurantMap)
      {
          this.insurantMap = insurantMap;
      }
      
      public decimal getPriceTotal()
      {
          return priceTotal;
      }
      
      public void setPriceTotal(ref decimal priceTotal)
      {
          this.priceTotal = priceTotal;
      }
      
      public String getInsureNum()
      {
          return insureNum;
      }
      
      public void setInsureNum(ref String insureNum)
      {
          this.insureNum = insureNum;
      }
      
      public List<String> getInsurantIds()
      {
          return insurantIds;
      }
      
      public void setInsurantIds(ref List<String> insurantIds)
      {
          this.insurantIds = insurantIds;
      }
      
      public int getInsurantCount()
      {
          return insurantCount;
      }
      
      public void setInsurantCount(ref int insurantCount)
      {
          this.insurantCount = insurantCount;
      }
   
   }
}