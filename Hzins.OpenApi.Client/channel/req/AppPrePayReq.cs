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
   public class AppPrePayReq : SubUserBaseReq
   {
      ///  投保单号
      public String orderNum;
      ///  1 支付宝,21 微信充值
      public int payGatewayId;
      ///  银行编号，目前只支持微信和支付宝支付，暂时此字段不对外开放
      public int bankId;
      ///  安卓3 ios 6
      public int appTypeId;
      ///  IP地址
      public String ip;
      public String insureNum;

   }
}