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
   /// 
   /// </p>
   public class OrderInfo
   {
      ///  惠择投保单号
      private String insureNum;
      ///  保险公司保单号
      private String policyNum;
      ///  被保人姓名
      private String cName;
      ///  被保人证件号码
      private String cardCode;
      
      public String getInsureNum()
      {
          return insureNum;
      }
      
      public void setInsureNum(ref String insureNum)
      {
          this.insureNum = insureNum;
      }
      
      public String getPolicyNum()
      {
          return policyNum;
      }
      
      public void setPolicyNum(ref String policyNum)
      {
          this.policyNum = policyNum;
      }
      
      public String getcName()
      {
          return cName;
      }
      
      public void setcName(ref String cName)
      {
          this.cName = cName;
      }
      
      public String getCardCode()
      {
          return cardCode;
      }
      
      public void setCardCode(ref String cardCode)
      {
          this.cardCode = cardCode;
      }
   
   }
}