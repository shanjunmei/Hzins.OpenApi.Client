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
import com.hzins.channel.api.model.info.ApplicantInfo;
import com.hzins.channel.api.model.info.InsurantInfo;
import com.hzins.channel.api.model.info.PolicyDetailInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 保单查询返回信息
   /// </p>
   public class InsureDetailResp
   {
      ///  投保人信息
      private com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;
      ///  被保险人信息
      private List<InsurantInfo> insurantInfos;
      ///  保单明细
      private com.hzins.channel.api.model.info.PolicyDetailInfo policyDetailInfo;
      ///  紧急联系人
      private String contact;
      ///  紧急联系人电话
      private String contactMob;
      ///  保险公司名称
      private String companyName;
      ///  产品名称
      private String prodName;
      /// 流水号
      private String transNo;
      /// 渠道号
      private int partnerId;
      /// 投保单号
      private String insureNum;
      
      public com.hzins.channel.api.model.info.ApplicantInfo getApplicantInfo()
      {
          return applicantInfo;
      }
      
      public void setApplicantInfo(ref com.hzins.channel.api.model.info.ApplicantInfo applicantInfo)
      {
          this.applicantInfo = applicantInfo;
      }
      
      public List<InsurantInfo> getInsurantInfos()
      {
          return insurantInfos;
      }
      
      public void setInsurantInfos(ref List<InsurantInfo> insurantInfos)
      {
          this.insurantInfos = insurantInfos;
      }
      
      public com.hzins.channel.api.model.info.PolicyDetailInfo getPolicyDetailInfo()
      {
          return policyDetailInfo;
      }
      
      public void setPolicyDetailInfo(ref com.hzins.channel.api.model.info.PolicyDetailInfo policyDetailInfo)
      {
          this.policyDetailInfo = policyDetailInfo;
      }
      
      public String getContact()
      {
          return contact;
      }
      
      public void setContact(ref String contact)
      {
          this.contact = contact;
      }
      
      public String getContactMob()
      {
          return contactMob;
      }
      
      public void setContactMob(ref String contactMob)
      {
          this.contactMob = contactMob;
      }
      
      public String getCompanyName()
      {
          return companyName;
      }
      
      public void setCompanyName(ref String companyName)
      {
          this.companyName = companyName;
      }
      
      public String getProdName()
      {
          return prodName;
      }
      
      public void setProdName(ref String prodName)
      {
          this.prodName = prodName;
      }
      
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
      
      public String getInsureNum()
      {
          return insureNum;
      }
      
      public void setInsureNum(ref String insureNum)
      {
          this.insureNum = insureNum;
      }
   
   }
}