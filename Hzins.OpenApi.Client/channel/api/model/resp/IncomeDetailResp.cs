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
import com.hzins.channel.api.model.info.IncomeDetailInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 结算申请返回
   /// </p>
   public class IncomeDetailResp
   {
      private String transNo;
      private int partnerId;
      private List<IncomeDetailInfo> incomeDetailInfos;
      
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
      
      public List<IncomeDetailInfo> getIncomeDetailInfos()
      {
          return incomeDetailInfos;
      }
      
      public void setIncomeDetailInfos(ref List<IncomeDetailInfo> incomeDetailInfos)
      {
          this.incomeDetailInfos = incomeDetailInfos;
      }
   
   }
}