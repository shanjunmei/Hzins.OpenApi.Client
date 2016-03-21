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
using com.hzins.channel.api.model.info;



namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 保单查询返回信息
   /// </p>
   public class InsureDetailResp
   {
      ///  投保人信息
      public com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;
      ///  被保险人信息
      public List<InsurantInfo> insurantInfos;
      ///  保单明细
      public com.hzins.channel.api.model.info.PolicyDetailInfo policyDetailInfo;
      ///  紧急联系人
      public String contact;
      ///  紧急联系人电话
      public String contactMob;
      ///  保险公司名称
      public String companyName;
      ///  产品名称
      public String prodName;
      /// 流水号
      public String transNo;
      /// 渠道号
      public int partnerId;
      /// 投保单号
      public String insureNum;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}