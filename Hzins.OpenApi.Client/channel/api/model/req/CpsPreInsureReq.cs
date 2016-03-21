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
import com.hzins.channel.api.model.info.ApplicantInfo;

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 
   /// 
   /// 
   /// </p>
   public class CpsPreInsureReq : BaseReq
   {
      private String caseCode;
      private String platform;
      private String partnerUniqueKey;
      ///  投保人信息
      private com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;
      
      public String getCaseCode()
         {
      return caseCode;
         }
      
      public void setCaseCode(ref String caseCode)
         {
      this.caseCode = caseCode;
         }
      
      public String getPlatform()
         {
      return platform;
         }
      
      public void setPlatform(ref String platform)
         {
      this.platform = platform;
         }
      
      public String getPartnerUniqueKey()
         {
      return partnerUniqueKey;
         }
      
      public void setPartnerUniqueKey(ref String partnerUniqueKey)
         {
      this.partnerUniqueKey = partnerUniqueKey;
         }
      
      public com.hzins.channel.api.model.info.ApplicantInfo getApplicantInfo()
         {
      return applicantInfo;
         }
      
      public void setApplicantInfo(ref com.hzins.channel.api.model.info.ApplicantInfo applicantInfo)
         {
      this.applicantInfo = applicantInfo;
         }
   
   }
}