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
import com.hzins.channel.api.model.common.CommonResult;
import com.hzins.channel.api.model.info.FinancialInfo;
import com.hzins.channel.api.model.req.ApiPartnerInsureReq;
import com.hzins.channel.api.model.req.AppPrePayReq;
import com.hzins.channel.api.model.req.CarInsureDetailReq;
import com.hzins.channel.api.model.req.CarPreInsureReq;
import com.hzins.channel.api.model.req.CarPrePayReq;
import com.hzins.channel.api.model.req.CpsPayReq;
import com.hzins.channel.api.model.req.CpsPreInsureReq;
import com.hzins.channel.api.model.req.IncomeDetailReq;
import com.hzins.channel.api.model.req.InsureDetailReq;
import com.hzins.channel.api.model.req.InsureDownloadReq;
import com.hzins.channel.api.model.req.OrderApplyReq;
import com.hzins.channel.api.model.req.OrderCancelReq;
import com.hzins.channel.api.model.req.OrderDetailReq;
import com.hzins.channel.api.model.req.OrderSearchReq;
import com.hzins.channel.api.model.req.PrePayReq;
import com.hzins.channel.api.model.req.ProductDetailReq;
import com.hzins.channel.api.model.req.ProductListReq;
import com.hzins.channel.api.model.req.RegisterReq;
import com.hzins.channel.api.model.req.SettlementBillDetailReq;
import com.hzins.channel.api.model.req.SettlementBillTotalReq;
import com.hzins.channel.api.model.req.SettlementDetailReq;
import com.hzins.channel.api.model.req.SettlementReq;
import com.hzins.channel.api.model.resp.ApiPartnerInsureResp;
import com.hzins.channel.api.model.resp.AppPrePayResp;
import com.hzins.channel.api.model.resp.CarInsureDetailResp;
import com.hzins.channel.api.model.resp.CarPreInsureResp;
import com.hzins.channel.api.model.resp.CarPrePayResp;
import com.hzins.channel.api.model.resp.CpsPayResp;
import com.hzins.channel.api.model.resp.CpsPreInsureResp;
import com.hzins.channel.api.model.resp.IncomeDetailResp;
import com.hzins.channel.api.model.resp.InsureDetailResp;
import com.hzins.channel.api.model.resp.InsureDownloadResp;
import com.hzins.channel.api.model.resp.OrderApplyResp;
import com.hzins.channel.api.model.resp.OrderCancelResp;
import com.hzins.channel.api.model.resp.PayResp;
import com.hzins.channel.api.model.resp.PrePayResp;
import com.hzins.channel.api.model.resp.ProductDetailResp;
import com.hzins.channel.api.model.resp.ProductListResp;
import com.hzins.channel.api.model.resp.RegisterResp;
import com.hzins.channel.api.model.resp.SearchInsureResp;
import com.hzins.channel.api.model.resp.SettlementBillDetailResp;
import com.hzins.channel.api.model.resp.SettlementBillTotalResp;
import com.hzins.channel.api.model.resp.SettlementDetailResp;

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