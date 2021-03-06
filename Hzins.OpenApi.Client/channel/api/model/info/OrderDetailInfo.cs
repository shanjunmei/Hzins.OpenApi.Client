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
   /// 投保单信息
   /// </p>
   public class OrderDetailInfo
   {
      private String insureNum;
      ///  保单类型，2待完成，3未支付，4已支付
      private int payState;
      ///  (1 未支付;10 未出单;20 已出单;30 延时出单;40 取消出单)
      private int issueState;
      ///  生效状(1 未生效;2 已生效;3 已退保 21 退保中)
      private int effectiveState;
      ///  投保时间
      private String insureTime;
      ///  总份数
      private int totalNum;
      ///  价格
      private decimal price;
      private String productName;
      private String planName;
      ///  起保时间
      private String startDate;
      ///  截止时间
      private String endDate;
      ///  保险期限
      private String deadline;
      ///  保险公司名称
      private String companyName;
      ///  投保人姓名
      private String applicant;
      ///  被保险人姓名
      private String insurant;
      ///  保险公司保单号
      private String policyNum;
      /// 方案代码
      private String caseCode;
      
      public int getIssueState()
         {
      return issueState;
         }
      
      public void setIssueState(ref int issueState)
         {
      this.issueState = issueState;
         }
      
      public int getEffectiveState()
         {
      return effectiveState;
         }
      
      public void setEffectiveState(ref int effectiveState)
         {
      this.effectiveState = effectiveState;
         }
      
      public String getInsureNum()
         {
      return insureNum;
         }
      
      public void setInsureNum(ref String insureNum)
         {
      this.insureNum = insureNum;
         }
      
      public int getPayState()
         {
      return payState;
         }
      
      public void setPayState(ref int payState)
         {
      this.payState = payState;
         }
      
      public String getInsureTime()
         {
      return insureTime;
         }
      
      public void setInsureTime(ref String insureTime)
         {
      this.insureTime = insureTime;
         }
      
      public int getTotalNum()
         {
      return totalNum;
         }
      
      public void setTotalNum(ref int totalNum)
         {
      this.totalNum = totalNum;
         }
      
      public String getProductName()
         {
      return productName;
         }
      
      public void setProductName(ref String productName)
         {
      this.productName = productName;
         }
      
      public String getPlanName()
         {
      return planName;
         }
      
      public void setPlanName(ref String planName)
         {
      this.planName = planName;
         }
      
      public String getStartDate()
         {
      return startDate;
         }
      
      public void setStartDate(ref String startDate)
         {
      this.startDate = startDate;
         }
      
      public String getEndDate()
         {
      return endDate;
         }
      
      public void setEndDate(ref String endDate)
         {
      this.endDate = endDate;
         }
      
      public String getDeadline()
         {
      return deadline;
         }
      
      public void setDeadline(ref String deadline)
         {
      this.deadline = deadline;
         }
      
      public String getCompanyName()
         {
      return companyName;
         }
      
      public void setCompanyName(ref String companyName)
         {
      this.companyName = companyName;
         }
      
      public String getApplicant()
         {
      return applicant;
         }
      
      public void setApplicant(ref String applicant)
         {
      this.applicant = applicant;
         }
      
      public String getInsurant()
         {
      return insurant;
         }
      
      public void setInsurant(ref String insurant)
         {
      this.insurant = insurant;
         }
      
      public decimal getPrice()
         {
      return price;
         }
      
      public void setPrice(ref decimal price)
         {
      this.price = price;
         }
      
      public String getPolicyNum()
         {
      return policyNum;
         }
      
      public void setPolicyNum(ref String policyNum)
         {
      this.policyNum = policyNum;
         }
      
      public String getCaseCode()
      {
          return caseCode;
      }
      
      public void setCaseCode(ref String caseCode)
      {
          this.caseCode = caseCode;
      }
   
   }
}