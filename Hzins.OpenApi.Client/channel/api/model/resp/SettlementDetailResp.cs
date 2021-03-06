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
import java.util.List;
import com.hzins.channel.api.model.info.SettlementDetailInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 	服务费明细返回实体
   /// </p>
   public class SettlementDetailResp
   {
      /// 流水号
      private String transNo;
      /// 代理商编号
      private int partnerId;
      private int pageNum;
      private int pageSize;
      private int total;
      ///     private int pageIndex;
      /// 服务费明细信息
      private List<SettlementDetailInfo> settlementDetailList;
      
      public String getTransNo()
      {
          return transNo;
      }
      
      public void setTransNo(ref String transNo)
      {
          this.transNo = transNo;
      }
      
      public int getPartnerId()
      {
          return partnerId;
      }
      
      public void setPartnerId(ref int partnerId)
      {
          this.partnerId = partnerId;
      }
      
      public List<SettlementDetailInfo> getSettlementDetailList()
      {
          return settlementDetailList;
      }
      
      public void setSettlementDetailList(ref List<SettlementDetailInfo> settlementDetailList)
      {
          this.settlementDetailList = settlementDetailList;
      }
      
      public int getPageNum()
      {
          return pageNum;
      }
      
      public void setPageNum(ref int pageNum)
      {
          this.pageNum = pageNum;
      }
      
      public int getPageSize()
      {
          return pageSize;
      }
      
      public void setPageSize(ref int pageSize)
      {
          this.pageSize = pageSize;
      }
      
      public int getTotal()
      {
          return total;
      }
      
      public void setTotal(ref int total)
      {
          this.total = total;
      }
   
   }
}

//    public int getPageIndex() {
//        return pageIndex;
//    }
//
//
//    
//    public void setPageIndex(int pageIndex) {
//        this.pageIndex = pageIndex;
//    }