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
   /// 
   /// </p>
   public class ExtendInfo
   {
      ///  用户在代理商系统中的唯一标识
      private String userId;
      private String email;
      private String userName;
      private String phone;
      
      public String getUserId()
      {
          return userId;
      }
      
      public void setUserId(ref String userId)
      {
          this.userId = userId;
      }
      
      public String getEmail()
      {
          return email;
      }
      
      public void setEmail(ref String email)
      {
          this.email = email;
      }
      
      public String getUserName()
      {
          return userName;
      }
      
      public void setUserName(ref String userName)
      {
          this.userName = userName;
      }
      
      public String getPhone()
      {
          return phone;
      }
      
      public void setPhone(ref String phone)
      {
          this.phone = phone;
      }
   
   }
}