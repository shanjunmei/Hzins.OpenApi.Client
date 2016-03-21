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

namespace com.hzins.channel.api.model.info
{
   /// <p>
   /// 寿险健康险需加入的试算实体类
   /// </p>
   public class CalculatePriceDataInfo
   {
      /// 保证项目选项值(暂时不传)
      public String optionValue;
      /// 缴费期限 一次性缴或者趸交 传0
      public int paymentLimit;
      /// 保障期限
      public int insurancePeriod;
      /// 保障期限单位 1为年 2为岁
      public int insuranceUnit;
      /// 保险金额
      public decimal insuranceAmount;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}