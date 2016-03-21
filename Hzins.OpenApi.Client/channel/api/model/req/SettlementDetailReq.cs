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
   /// 服务费明细请求信息
   /// </p>
   public class SettlementDetailReq : SubUserBaseReq
   {
      ///  投保单号(多个以英文逗号隔开)
      private String insureNums;
      ///  查询开始时间
      private String startTime;
      ///  查询结束时间
      private String endTime;
      ///  查询页数
      private int pageNum;
      ///  每页数量
      private int pageSize;
      
      public String getStartTime()
         {
      return startTime;
         }
      
      public void setStartTime(ref String startTime)
         {
      this.startTime = startTime;
         }
      
      public String getEndTime()
         {
      return endTime;
         }
      
      public void setEndTime(ref String endTime)
         {
      this.endTime = endTime;
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
      
      public String getInsureNums()
         {
      return insureNums;
         }
      
      public void setInsureNums(ref String insureNums)
         {
      this.insureNums = insureNums;
         }
   
   }
}