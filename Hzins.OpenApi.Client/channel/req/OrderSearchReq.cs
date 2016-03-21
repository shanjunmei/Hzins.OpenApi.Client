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

namespace com.hzins.channel.api.model.req
{
   /// <summary>
   /// 
   /// </summary>
   public class OrderSearchReq : SubUserBaseReq
   {
      ///  当前页
      public int pageNum;
      ///  每页显示数据
      public int pageSize;
      ///  投保开始时间
      public String startTime;
      ///  投保结束时间
      public String endTime;
      ///  投保人姓名
      public String applicant;
      ///  被保险人姓名
      public String insurant;
      ///  投保人证件号码
      public String idCard;
      ///  多个投保单号
      public List<String> insureNums;

   }
}