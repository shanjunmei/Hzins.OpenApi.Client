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
   /// 
   /// </p>
   public class OrderDetailReq : SubUserBaseReq
   {
      private String insureNum;
      ///  投保人证件号
      private String idCard;
      ///  投保人邮箱
      private String email;
      ///  当前页
      private int pageNum;
      ///  每页显示数据
      private int pageSize;
      
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
      
      public String getInsureNum()
         {
      return insureNum;
         }
      
      public String getIdCard()
         {
      return idCard;
         }
      
      public void setIdCard(ref String idCard)
         {
      this.idCard = idCard;
         }
      
      public String getEmail()
         {
      return email;
         }
      
      public void setEmail(ref String email)
         {
      this.email = email;
         }
      
      public void setInsureNum(ref String insureNum)
         {
      this.insureNum = insureNum;
         }
   
   }
}