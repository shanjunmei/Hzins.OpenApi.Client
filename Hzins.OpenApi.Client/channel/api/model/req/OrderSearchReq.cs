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

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 
   /// </p>
   public class OrderSearchReq : SubUserBaseReq
   {
      ///  当前页
      private int pageNum;
      ///  每页显示数据
      private int pageSize;
      ///  投保开始时间
      private String startTime;
      ///  投保结束时间
      private String endTime;
      ///  投保人姓名
      private String applicant;
      ///  被保险人姓名
      private String insurant;
      ///  投保人证件号码
      private String idCard;
      ///  多个投保单号
      private List<String> insureNums;
      
      public List<String> getInsureNums()
         {
      return insureNums;
         }
      
      public void setInsureNums(ref List<String> insureNums)
         {
      this.insureNums = insureNums;
         }
      
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
      
      public String getApplicant()
         {
      return applicant;
         }
      
      public void setApplicant(ref String applicant)
         {
      this.applicant = applicant;
         }
      
      public String getInsurant()
         {
      return insurant;
         }
      
      public void setInsurant(ref String insurant)
         {
      this.insurant = insurant;
         }
      
      public String getIdCard()
         {
      return idCard;
         }
      
      public void setIdCard(ref String idCard)
         {
      this.idCard = idCard;
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
   
   }
}