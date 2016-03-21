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
   /// 车险投保单信息
   /// 
   /// </p>
   public class CarInsureInfo
   {
      /// 保险公司名称
      public String companyName;
      /// 渠道用户唯一标识
      public String partnerUniqKey;
      /// 投保单号(CX开头+YYMMDD+10000000~99999999随机数）
      public String insureNum;
      /// 投保人姓名
      public String applicant;
      /// 投保人证件类型 1=身份证;2=护照；3=军官证；4=港澳回乡证；5=台胞证；6=组织机构代码证；7=税务登记证；8=其他
      public byte applicantCardType;
      /// 投保人电话
      public String applicantPhone;
      /// 证件号码
      public String applicantCardNum;
      /// 1:同车主 2：同投保人 3：其他
      public byte insurantType;
      /// 被保险人
      public String insurant;
      /// 被保险人证件类型
      public byte insurantCardType;
      /// 被保险人证件号码
      public String insurantCardNum;
      /// 被保人电话
      public String insurantPhone;
      /// 寄送方法 1:配送 2:自提
      public byte expreWay;
      /// 收件人
      public String expreReceiver;
      /// 配送联系地址
      public String expreAddress;
      /// 配送联系号码
      public String expreMobile;
      /// 车船税保费(冗余)
      public float travelTaxPremium;
      /// 商业险保费(冗余)
      public float bussinessPremium;
      /// 交强险保费(冗余)
      public float strongPremium;
      /// 滞纳金(冗余)
      public float lateFee;
      /// 用户支付金额
      public float userPayAmount;
      /// 保费(冗余)
      public float premium;
      /// 交强险保单号（出单填写）
      public String strongPolicyNum;
      /// 商业险保单号（出单填写）
      public String bussinessPolicyNum;
      /// 出单备注（出单填写）
      public String policyRemark;
      /// 状态： 0=初审中 1=初审失败 2=核保中 3=核保失败 5=核保成功 6=拒保 7=已过期 8=已撤销
      public byte status;
      /// 支付状态（1=待支付，2=待确认，3=已支付\n）
      public byte payStatus;
      /// 收款状态（1：待收款 2：已收款）
      public byte receivePayStatus;
      /// 出单状态（1=未出单 2=已出单）
      public byte issueStatus;
      /// 用户自己备注
      public String userRemark;
      /// 线上投保使用，假如交强险或商业险投保过，此字段为1
      public byte hasOnlineQuote;
      /// 支付时间
      
      
      public DateTime payTime;
      /// 交强险开始时间
      
      
      public DateTime trafficInsureStartTime;
      /// 交强险结束时间
      
      
      public DateTime trafficInsureEndTime;
      /// 商业险开始时间
      
      
      public DateTime busiInsureStartTime;
      /// 商业险结束时间
      
      
      public DateTime busiInsureEndTime;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}