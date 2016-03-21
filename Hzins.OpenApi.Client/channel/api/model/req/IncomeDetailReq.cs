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
   /// 结算前每月汇总查询请求参数
   /// </p>
   public class IncomeDetailReq : BaseReq
   {
      ///  渠道唯一的标识
      private List<String> userIds;
      ///  年份
      private int year;
      ///  月份
      private int month;
      
      public List<String> getUserIds()
         {
      return userIds;
         }
      
      public void setUserIds(ref List<String> userIds)
         {
      this.userIds = userIds;
         }
      
      public int getYear()
         {
      return year;
         }
      
      public void setYear(ref int year)
         {
      this.year = year;
         }
      
      public int getMonth()
         {
      return month;
         }
      
      public void setMonth(ref int month)
         {
      this.month = month;
         }
   
   }
}