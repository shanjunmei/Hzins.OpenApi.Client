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
import com.hzins.channel.api.model.ApplicationData;
import com.hzins.channel.api.model.info.ApplicantInfo;
import com.hzins.channel.api.model.info.CalculatePriceDataInfo;
import com.hzins.channel.api.model.info.ExtendInfo;
import com.hzins.channel.api.model.info.HealthInfo;
import com.hzins.channel.api.model.info.InsurantInfo;
import com.hzins.channel.api.model.info.InsureBeneficiaryInfo;

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 第三方投保对接投保请求消息
   /// </p>
   public class OrderApplyReq : BaseReq
   {
      ///  方案代码，每一款保险公司的方案代码都不相同，由慧择分配
      private String caseCode;
      ///  订单数据
      private com.hzins.channel.api.model.ApplicationData applicationData;
      ///  投保人信息
      private com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;
      ///  被保人信息
      private List<InsurantInfo> insurantInfos;
      ///  扩展信息
      private com.hzins.channel.api.model.info.ExtendInfo extendInfo;
      ///  寿险健康险专用实体
      private com.hzins.channel.api.model.info.HealthInfo healthInfo;
      ///  寿险投保受益人实体类
      private List<InsureBeneficiaryInfo> insureBenfInfos;
      ///  寿险健康险需加入的试算实体类
      private com.hzins.channel.api.model.info.CalculatePriceDataInfo calculatePriceDataInfo;
      ///  投保类型 默认为0， 1：节假日不投保 2：节假日投保 3：一年一次 4：一年多次
      private int insureType;
      
      public com.hzins.channel.api.model.info.CalculatePriceDataInfo getCalculatePriceDataInfo()
         {
      return calculatePriceDataInfo;
         }
      
      public void setCalculatePriceDataInfo(ref com.hzins.channel.api.model.info.CalculatePriceDataInfo calculatePriceDataInfo)
         {
      this.calculatePriceDataInfo = calculatePriceDataInfo;
         }
      
      public List<InsureBeneficiaryInfo> getInsureBenfInfos()
         {
      return insureBenfInfos;
         }
      
      public void setInsureBenfInfos(ref List<InsureBeneficiaryInfo> insureBenfInfos)
         {
      this.insureBenfInfos = insureBenfInfos;
         }
      
      public com.hzins.channel.api.model.info.HealthInfo getHealthInfo()
         {
      return healthInfo;
         }
      
      public void setHealthInfo(ref com.hzins.channel.api.model.info.HealthInfo healthInfo)
         {
      this.healthInfo = healthInfo;
         }
      
      public String getCaseCode()
         {
      return caseCode;
         }
      
      public void setCaseCode(ref String caseCode)
         {
      this.caseCode = caseCode;
         }
      
      public com.hzins.channel.api.model.ApplicationData getApplicationData()
         {
      return applicationData;
         }
      
      public void setApplicationData(ref com.hzins.channel.api.model.ApplicationData applicationData)
         {
      this.applicationData = applicationData;
         }
      
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
      
      public com.hzins.channel.api.model.info.ExtendInfo getExtendInfo()
         {
      return extendInfo;
         }
      
      public void setExtendInfo(ref com.hzins.channel.api.model.info.ExtendInfo extendInfo)
         {
      this.extendInfo = extendInfo;
         }
      
      public int getInsureType()
         {
      return insureType;
         }
      
      public void setInsureType(ref int insureType)
         {
      this.insureType = insureType;
         }
   
   }
}