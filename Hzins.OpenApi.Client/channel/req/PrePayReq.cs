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

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 支付接口请求对象
   /// </p>
   public class PrePayReq : SubUserBaseReq
   {
      ///  方案代码
      public String caseCode;
      ///  投保单号
      public String orderNum;
      ///  在线支付网关标识，1：支付宝；3：银联；12：易宝在线；13：易宝无卡支付；14：财付通；15：手机支付；16：银联(B2B)；21：微信支付
      public int onliePaymnetId;
      ///  银行标识，当值大于0时，会直接跳转到相应的银行页面
      public int bankId;
      ///  页面返回地址
      public String pageNoticeUrl;
      ///  支付金额（单位：元）
      public String price;
      ///  投保单号，兼容orderNum
      public String insureNum;

   }
}