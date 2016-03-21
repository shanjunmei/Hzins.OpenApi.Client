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
      private String caseCode;
      ///  投保单号
      private String orderNum;
      ///  在线支付网关标识，1：支付宝；3：银联；12：易宝在线；13：易宝无卡支付；14：财付通；15：手机支付；16：银联(B2B)；21：微信支付
      private int onliePaymnetId;
      ///  银行标识，当值大于0时，会直接跳转到相应的银行页面
      private int bankId;
      ///  页面返回地址
      private String pageNoticeUrl;
      ///  支付金额（单位：元）
      private String price;
      ///  投保单号，兼容orderNum
      private String insureNum;
      
      public String getCaseCode()
         {
      return caseCode;
         }
      
      public void setCaseCode(ref String caseCode)
         {
      this.caseCode = caseCode;
         }
      
      public String getOrderNum()
         {
      return orderNum;
         }
      
      public void setOrderNum(ref String orderNum)
         {
      this.orderNum = orderNum;
         }
      
      public int getOnliePaymnetId()
         {
      return onliePaymnetId;
         }
      
      public void setOnliePaymnetId(ref int onliePaymnetId)
         {
      this.onliePaymnetId = onliePaymnetId;
         }
      
      public int getBankId()
         {
      return bankId;
         }
      
      public void setBankId(ref int bankId)
         {
      this.bankId = bankId;
         }
      
      public String getPageNoticeUrl()
         {
      return pageNoticeUrl;
         }
      
      public void setPageNoticeUrl(ref String pageNoticeUrl)
         {
      this.pageNoticeUrl = pageNoticeUrl;
         }
      
      public String getPrice()
         {
      return price;
         }
      
      public void setPrice(ref String price)
         {
      this.price = price;
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