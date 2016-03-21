/**
 * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
 *  
 * This code is the confidential and proprietary information of   
 * Hzins. You shall not disclose such Confidential Information   
 * and shall use it only in accordance with the terms of the agreements   
 * you entered into with Hzins,http://www.hzins.com.
 *  
 */

using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.info;
using com.hzins.channel.api.model.req;

using com.hzins.channel.api.model.resp;

namespace com.hzins.openapi.client
{
    /// <p>
    /// 
    /// 远程方法接口声明
    /// 
    /// </p>
    public interface OpenApiRemoteOperation
   {
      /// <p>
      /// 
      /// 产品列表
      /// 
      /// </p>
      CommonResult<ProductListResp> productList(ref ProductListReq req);

      /// <p>
      /// 
      /// 产品详情
      /// 
      /// </p>
      CommonResult<ProductDetailResp> productDetail(ref ProductDetailReq req);

      /// <p>
      /// 
      /// 投保
      /// 
      /// </p>
      CommonResult<OrderApplyResp> orderApply(ref OrderApplyReq req);

      /// <p>
      /// 
      /// 退保
      /// 
      /// </p>
      CommonResult<OrderCancelResp> orderCancel(ref OrderCancelReq req);

      /// <p>
      /// 
      /// 保单下载
      /// 
      /// </p>
      CommonResult<InsureDownloadResp> download(ref InsureDownloadReq req);

      /// <p>
      /// 
      /// CPS支付
      /// 
      /// </p>
      CommonResult<CpsPayResp> cpsPay(ref CpsPayReq req);

      /// <p>
      /// 
      /// 8.API支付
      /// 
      /// </p>
      CommonResult<PrePayResp> prePay(ref PrePayReq req);

      /// <p>
      /// 
      /// APP支付
      /// 
      /// </p>
      CommonResult<AppPrePayResp> appPrePay(ref AppPrePayReq req);

      /// <p>
      /// 
      /// 渠道注册
      /// 
      /// </p>
      CommonResult<RegisterResp> register(ref RegisterReq req);

      /// <p>
      /// 
      /// 投保单查询
      /// 
      /// </p>
      CommonResult<SearchInsureResp> orderDetail(ref OrderDetailReq req);

      /// <p>
      /// 
      /// 批量查询保单（分页）
      /// 
      /// </p>
      CommonResult<SearchInsureResp> orderSearch(ref OrderSearchReq req);

      /// <p>
      /// 
      /// 投保单详情
      /// 
      /// </p>
      CommonResult<InsureDetailResp> insureDetail(ref InsureDetailReq req);

      /// <p>
      /// 
      /// 服务费结算
      /// 
      /// </p>
      CommonResult<FinancialInfo> submitSettlement(ref SettlementReq req);

      /// <p>
      /// 
      /// 服务费明细
      /// 
      /// </p>
      CommonResult<SettlementDetailResp> settlementDetail(ref SettlementDetailReq req);

      /// <p>
      /// 
      /// 结算申请明细
      /// 
      /// </p>
      CommonResult<SettlementBillDetailResp> settlementBillDetail(ref SettlementBillDetailReq req);

      /// <p>
      /// 
      /// 结算申请汇总
      /// 
      /// </p>
      CommonResult<SettlementBillTotalResp> settlementBillTotal(ref SettlementBillTotalReq req);

      /// <p>
      /// 
      /// 服务费按月汇总
      /// 
      /// </p>
      CommonResult<IncomeDetailResp> incomeDetail(ref IncomeDetailReq req);

      /// <p>
      /// 
      /// 支付，返回html
      /// 
      /// </p>
      CommonResult<PayResp> pay(ref PrePayReq req);

      /// <p>
      /// 
      /// 车险预投保
      /// 
      /// </p>
      CommonResult<CarPreInsureResp> carPreInsure(ref CarPreInsureReq req);

      /// <p>
      /// 
      /// 车险预支付
      /// 
      /// </p>
      CommonResult<CarPrePayResp> carPrePay(ref CarPrePayReq req);

      /// <p>
      /// 
      /// 车险订单查询
      /// 
      /// </p>
      CommonResult<CarInsureDetailResp> carInsureDetail(ref CarInsureDetailReq req);

      /// <p>
      /// 
      /// cps 预投保
      /// 
      /// </p>
      CommonResult<CpsPreInsureResp> cpsPreInsure(ref CpsPreInsureReq req);

      /// <p>
      /// 
      /// cps投保单详情
      /// 
      /// </p>
      CommonResult<ApiPartnerInsureResp> partnerInsureDetail(ref ApiPartnerInsureReq req);

   }
}