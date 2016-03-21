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
using System.Collections.Generic;
using com.hzins.channel.api.model;
using com.hzins.channel.api.model.info;

namespace com.hzins.channel.api.model.req
{
   /// <summary>
   /// 第三方投保对接投保请求消息
   /// </summary>
   public class OrderApplyReq : BaseReq
   {
      ///  方案代码，每一款保险公司的方案代码都不相同，由慧择分配
      public String caseCode;
      ///  订单数据
      public com.hzins.channel.api.model.ApplicationData applicationData;
      ///  投保人信息
      public com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;
      ///  被保人信息
      public List<InsurantInfo> insurantInfos;
      ///  扩展信息
      public com.hzins.channel.api.model.info.ExtendInfo extendInfo;
      ///  寿险健康险专用实体
      public com.hzins.channel.api.model.info.HealthInfo healthInfo;
      ///  寿险投保受益人实体类
      public List<InsureBeneficiaryInfo> insureBenfInfos;
      ///  寿险健康险需加入的试算实体类
      public com.hzins.channel.api.model.info.CalculatePriceDataInfo calculatePriceDataInfo;
      ///  投保类型 默认为0， 1：节假日不投保 2：节假日投保 3：一年一次 4：一年多次
      public int insureType;

   }
}