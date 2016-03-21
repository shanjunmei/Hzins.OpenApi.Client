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
import com.hzins.channel.api.model.info.FinancialInfo;

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 服务费结算请求实体
   /// </p>
   public class SettlementReq : SubUserBaseReq
   {
      private com.hzins.channel.api.model.info.FinancialInfo financialInfo;
      
      public com.hzins.channel.api.model.info.FinancialInfo getFinancialInfo()
         {
      return financialInfo;
         }
      
      public void setFinancialInfo(ref com.hzins.channel.api.model.info.FinancialInfo financialInfo)
         {
      this.financialInfo = financialInfo;
         }
   
   }
}