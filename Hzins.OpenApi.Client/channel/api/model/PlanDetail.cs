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

namespace com.hzins.channel.api.model
{
   /// <p>
   /// 
   /// 
   /// 
   /// </p>
   public class PlanDetail
   {
      private String name;
      private String text;
      
      public String getName()
         {
      return name;
         }
      
      public void setName(ref String name)
         {
      this.name = name;
         }
      
      public String getText()
         {
      return text;
         }
      
      public void setText(ref String text)
         {
      this.text = text;
         }
   
   }
}