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
using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.info;
using com.hzins.channel.api.model.req;

using com.hzins.channel.api.model.resp;

namespace com.hzins.openapi.client
{
   /// <summary>
   /// 
   /// 远程方法接口声明
   /// 
   /// </summary>
   public interface OpenApiRemoteOperation
   {
      /// <summary>
      /// 
      /// 产品列表
      /// 
      /// </summary>
      CommonResult<ProductListResp> productList(ref ProductListReq req);

      /// <summary>
      /// 
      /// 产品详情
      /// 
      /// </summary>
      CommonResult<ProductDetailResp> productDetail(ref ProductDetailReq req);

      /// <summary>
      /// 
      /// 投保
      /// 
      /// </summary>
      CommonResult<OrderApplyResp> orderApply(ref OrderApplyReq req);

      /// <summary>
      /// 
      /// 退保
      /// 
      /// </summary>
      CommonResult<OrderCancelResp> orderCancel(ref OrderCancelReq req);

      /// <summary>
      /// 
      /// 保单下载
      /// 
      /// </summary>
      CommonResult<InsureDownloadResp> download(ref InsureDownloadReq req);

      /// <summary>
      /// 
      /// CPS支付
      /// 
      /// </summary>
      CommonResult<CpsPayResp> cpsPay(ref CpsPayReq req);

      /// <summary>
      /// 
      /// 8.API支付
      /// 
      /// </summary>
      CommonResult<PrePayResp> prePay(ref PrePayReq req);

      /// <summary>
      /// 
      /// APP支付
      /// 
      /// </summary>
      CommonResult<AppPrePayResp> appPrePay(ref AppPrePayReq req);

      /// <summary>
      /// 
      /// 渠道注册
      /// 
      /// </summary>
      CommonResult<RegisterResp> register(ref RegisterReq req);

      /// <summary>
      /// 
      /// 投保单查询
      /// 
      /// </summary>
      CommonResult<SearchInsureResp> orderDetail(ref OrderDetailReq req);

      /// <summary>
      /// 
      /// 批量查询保单（分页）
      /// 
      /// </summary>
      CommonResult<SearchInsureResp> orderSearch(ref OrderSearchReq req);

      /// <summary>
      /// 
      /// 投保单详情
      /// 
      /// </summary>
      CommonResult<InsureDetailResp> insureDetail(ref InsureDetailReq req);

      /// <summary>
      /// 
      /// 服务费结算
      /// 
      /// </summary>
      CommonResult<FinancialInfo> submitSettlement(ref SettlementReq req);

      /// <summary>
      /// 
      /// 服务费明细
      /// 
      /// </summary>
      CommonResult<SettlementDetailResp> settlementDetail(ref SettlementDetailReq req);

      /// <summary>
      /// 
      /// 结算申请明细
      /// 
      /// </summary>
      CommonResult<SettlementBillDetailResp> settlementBillDetail(ref SettlementBillDetailReq req);

      /// <summary>
      /// 
      /// 结算申请汇总
      /// 
      /// </summary>
      CommonResult<SettlementBillTotalResp> settlementBillTotal(ref SettlementBillTotalReq req);

      /// <summary>
      /// 
      /// 服务费按月汇总
      /// 
      /// </summary>
      CommonResult<IncomeDetailResp> incomeDetail(ref IncomeDetailReq req);

      /// <summary>
      /// 
      /// 支付，返回html
      /// 
      /// </summary>
      CommonResult<PayResp> pay(ref PrePayReq req);

      /// <summary>
      /// 
      /// 车险预投保
      /// 
      /// </summary>
      CommonResult<CarPreInsureResp> carPreInsure(ref CarPreInsureReq req);

      /// <summary>
      /// 
      /// 车险预支付
      /// 
      /// </summary>
      CommonResult<CarPrePayResp> carPrePay(ref CarPrePayReq req);

      /// <summary>
      /// 
      /// 车险订单查询
      /// 
      /// </summary>
      CommonResult<CarInsureDetailResp> carInsureDetail(ref CarInsureDetailReq req);

      /// <summary>
      /// 
      /// cps 预投保
      /// 
      /// </summary>
      CommonResult<CpsPreInsureResp> cpsPreInsure(ref CpsPreInsureReq req);

      /// <summary>
      /// 
      /// cps投保单详情
      /// 
      /// </summary>
      CommonResult<ApiPartnerInsureResp> partnerInsureDetail(ref ApiPartnerInsureReq req);

   }
}