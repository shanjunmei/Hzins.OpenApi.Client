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
import java.util.Date;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.hzins.channel.base.utils.DateTimeDeserializer;
import com.hzins.channel.base.utils.DateTimeSerializer;

namespace com.hzins.channel.api.model.info
{
   /// <p>
   /// 
   /// 车险投保单信息
   /// 
   /// </p>
   public class CarInsureInfo
   {
      /// 保险公司名称
      private String companyName;
      /// 渠道用户唯一标识
      private String partnerUniqKey;
      /// 投保单号(CX开头+YYMMDD+10000000~99999999随机数）
      private String insureNum;
      /// 投保人姓名
      private String applicant;
      /// 投保人证件类型 1=身份证;2=护照；3=军官证；4=港澳回乡证；5=台胞证；6=组织机构代码证；7=税务登记证；8=其他
      private byte applicantCardType;
      /// 投保人电话
      private String applicantPhone;
      /// 证件号码
      private String applicantCardNum;
      /// 1:同车主 2：同投保人 3：其他
      private byte insurantType;
      /// 被保险人
      private String insurant;
      /// 被保险人证件类型
      private byte insurantCardType;
      /// 被保险人证件号码
      private String insurantCardNum;
      /// 被保人电话
      private String insurantPhone;
      /// 寄送方法 1:配送 2:自提
      private byte expreWay;
      /// 收件人
      private String expreReceiver;
      /// 配送联系地址
      private String expreAddress;
      /// 配送联系号码
      private String expreMobile;
      /// 车船税保费(冗余)
      private float travelTaxPremium;
      /// 商业险保费(冗余)
      private float bussinessPremium;
      /// 交强险保费(冗余)
      private float strongPremium;
      /// 滞纳金(冗余)
      private float lateFee;
      /// 用户支付金额
      private float userPayAmount;
      /// 保费(冗余)
      private float premium;
      /// 交强险保单号（出单填写）
      private String strongPolicyNum;
      /// 商业险保单号（出单填写）
      private String bussinessPolicyNum;
      /// 出单备注（出单填写）
      private String policyRemark;
      /// 状态： 0=初审中 1=初审失败 2=核保中 3=核保失败 5=核保成功 6=拒保 7=已过期 8=已撤销
      private byte status;
      /// 支付状态（1=待支付，2=待确认，3=已支付\n）
      private byte payStatus;
      /// 收款状态（1：待收款 2：已收款）
      private byte receivePayStatus;
      /// 出单状态（1=未出单 2=已出单）
      private byte issueStatus;
      /// 用户自己备注
      private String userRemark;
      /// 线上投保使用，假如交强险或商业险投保过，此字段为1
      private byte hasOnlineQuote;
      /// 支付时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime payTime;
      /// 交强险开始时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime trafficInsureStartTime;
      /// 交强险结束时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime trafficInsureEndTime;
      /// 商业险开始时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime busiInsureStartTime;
      /// 商业险结束时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime busiInsureEndTime;
      
      public String getCompanyName()
         {
      return companyName;
         }
      
      public void setCompanyName(ref String companyName)
         {
      this.companyName = companyName;
         }
      
      public String getPartnerUniqKey()
         {
      return partnerUniqKey;
         }
      
      public void setPartnerUniqKey(ref String partnerUniqKey)
         {
      this.partnerUniqKey = partnerUniqKey;
         }
      
      public String getInsureNum()
         {
      return insureNum;
         }
      
      public void setInsureNum(ref String insureNum)
         {
      this.insureNum = insureNum;
         }
      
      public String getApplicant()
         {
      return applicant;
         }
      
      public void setApplicant(ref String applicant)
         {
      this.applicant = applicant;
         }
      
      public byte getApplicantCardType()
         {
      return applicantCardType;
         }
      
      public void setApplicantCardType(ref byte applicantCardType)
         {
      this.applicantCardType = applicantCardType;
         }
      
      public String getApplicantPhone()
         {
      return applicantPhone;
         }
      
      public void setApplicantPhone(ref String applicantPhone)
         {
      this.applicantPhone = applicantPhone;
         }
      
      public String getApplicantCardNum()
         {
      return applicantCardNum;
         }
      
      public void setApplicantCardNum(ref String applicantCardNum)
         {
      this.applicantCardNum = applicantCardNum;
         }
      
      public byte getInsurantType()
         {
      return insurantType;
         }
      
      public void setInsurantType(ref byte insurantType)
         {
      this.insurantType = insurantType;
         }
      
      public String getInsurant()
         {
      return insurant;
         }
      
      public void setInsurant(ref String insurant)
         {
      this.insurant = insurant;
         }
      
      public byte getInsurantCardType()
         {
      return insurantCardType;
         }
      
      public void setInsurantCardType(ref byte insurantCardType)
         {
      this.insurantCardType = insurantCardType;
         }
      
      public String getInsurantCardNum()
         {
      return insurantCardNum;
         }
      
      public void setInsurantCardNum(ref String insurantCardNum)
         {
      this.insurantCardNum = insurantCardNum;
         }
      
      public String getInsurantPhone()
         {
      return insurantPhone;
         }
      
      public void setInsurantPhone(ref String insurantPhone)
         {
      this.insurantPhone = insurantPhone;
         }
      
      public byte getExpreWay()
         {
      return expreWay;
         }
      
      public void setExpreWay(ref byte expreWay)
         {
      this.expreWay = expreWay;
         }
      
      public String getExpreReceiver()
         {
      return expreReceiver;
         }
      
      public void setExpreReceiver(ref String expreReceiver)
         {
      this.expreReceiver = expreReceiver;
         }
      
      public String getExpreAddress()
         {
      return expreAddress;
         }
      
      public void setExpreAddress(ref String expreAddress)
         {
      this.expreAddress = expreAddress;
         }
      
      public String getExpreMobile()
         {
      return expreMobile;
         }
      
      public void setExpreMobile(ref String expreMobile)
         {
      this.expreMobile = expreMobile;
         }
      
      public float getTravelTaxPremium()
         {
      return travelTaxPremium;
         }
      
      public void setTravelTaxPremium(ref float travelTaxPremium)
         {
      this.travelTaxPremium = travelTaxPremium;
         }
      
      public float getBussinessPremium()
         {
      return bussinessPremium;
         }
      
      public void setBussinessPremium(ref float bussinessPremium)
         {
      this.bussinessPremium = bussinessPremium;
         }
      
      public float getStrongPremium()
         {
      return strongPremium;
         }
      
      public void setStrongPremium(ref float strongPremium)
         {
      this.strongPremium = strongPremium;
         }
      
      public float getLateFee()
         {
      return lateFee;
         }
      
      public void setLateFee(ref float lateFee)
         {
      this.lateFee = lateFee;
         }
      
      public float getUserPayAmount()
         {
      return userPayAmount;
         }
      
      public void setUserPayAmount(ref float userPayAmount)
         {
      this.userPayAmount = userPayAmount;
         }
      
      public float getPremium()
         {
      return premium;
         }
      
      public void setPremium(ref float premium)
         {
      this.premium = premium;
         }
      
      public String getStrongPolicyNum()
         {
      return strongPolicyNum;
         }
      
      public void setStrongPolicyNum(ref String strongPolicyNum)
         {
      this.strongPolicyNum = strongPolicyNum;
         }
      
      public String getBussinessPolicyNum()
         {
      return bussinessPolicyNum;
         }
      
      public void setBussinessPolicyNum(ref String bussinessPolicyNum)
         {
      this.bussinessPolicyNum = bussinessPolicyNum;
         }
      
      public String getPolicyRemark()
         {
      return policyRemark;
         }
      
      public void setPolicyRemark(ref String policyRemark)
         {
      this.policyRemark = policyRemark;
         }
      
      public byte getStatus()
         {
      return status;
         }
      
      public void setStatus(ref byte status)
         {
      this.status = status;
         }
      
      public byte getPayStatus()
         {
      return payStatus;
         }
      
      public void setPayStatus(ref byte payStatus)
         {
      this.payStatus = payStatus;
         }
      
      public byte getReceivePayStatus()
         {
      return receivePayStatus;
         }
      
      public void setReceivePayStatus(ref byte receivePayStatus)
         {
      this.receivePayStatus = receivePayStatus;
         }
      
      public byte getIssueStatus()
         {
      return issueStatus;
         }
      
      public void setIssueStatus(ref byte issueStatus)
         {
      this.issueStatus = issueStatus;
         }
      
      public String getUserRemark()
         {
      return userRemark;
         }
      
      public void setUserRemark(ref String userRemark)
         {
      this.userRemark = userRemark;
         }
      
      public byte getHasOnlineQuote()
         {
      return hasOnlineQuote;
         }
      
      public void setHasOnlineQuote(ref byte hasOnlineQuote)
         {
      this.hasOnlineQuote = hasOnlineQuote;
         }
      
      public DateTime getPayTime()
         {
      return payTime;
         }
      
      public void setPayTime(ref DateTime payTime)
         {
      this.payTime = payTime;
         }
      
      public DateTime getTrafficInsureStartTime()
         {
      return trafficInsureStartTime;
         }
      
      public void setTrafficInsureStartTime(ref DateTime trafficInsureStartTime)
         {
      this.trafficInsureStartTime = trafficInsureStartTime;
         }
      
      public DateTime getTrafficInsureEndTime()
         {
      return trafficInsureEndTime;
         }
      
      public void setTrafficInsureEndTime(ref DateTime trafficInsureEndTime)
         {
      this.trafficInsureEndTime = trafficInsureEndTime;
         }
      
      public DateTime getBusiInsureStartTime()
         {
      return busiInsureStartTime;
         }
      
      public void setBusiInsureStartTime(ref DateTime busiInsureStartTime)
         {
      this.busiInsureStartTime = busiInsureStartTime;
         }
      
      public DateTime getBusiInsureEndTime()
         {
      return busiInsureEndTime;
         }
      
      public void setBusiInsureEndTime(ref DateTime busiInsureEndTime)
         {
      this.busiInsureEndTime = busiInsureEndTime;
         }
   
   }
}