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
import java.io.Serializable;

namespace com.hzins.channel.api.model.req
{
   /// <p>
   /// 
   /// </p>
   public class RegisterReq : SubUserBaseReq, java.io.Serializable
   {
      private const long serialVersionUID = 7431287304382522749L;
      ///  渠道类型 0：个人 1：公司 (必填)
      private int channelType;
      ///  1:户外=1 2:旅行社 3:签证机构 4:旅游网站 0:其他(必填)
      private int webType;
      ///  邮箱
      private String email;
      ///  登陆密码
      private String loginPassWord;
      ///  联系人 必填
      private String contactName;
      ///  联系电话 必填
      private String contactNumber;
      ///  渠道服务费模板Id(非必填)
      private int feetemplateId;
      ///  拓展人员名字
      private String expandEmployeeName;
      ///  拓展人员ID
      private int expandEmployeeId;
      ///  公司代码
      private String companyCode;
      ///  公司名称
      private String companyName;
      
      public String getCompanyCode()
         {
      return companyCode;
         }
      
      public void setCompanyCode(ref String companyCode)
         {
      this.companyCode = companyCode;
         }
      
      public String getCompanyName()
         {
      return companyName;
         }
      
      public void setCompanyName(ref String companyName)
         {
      this.companyName = companyName;
         }
      
      public String getExpandEmployeeName()
         {
      return expandEmployeeName;
         }
      
      public void setExpandEmployeeName(ref String expandEmployeeName)
         {
      this.expandEmployeeName = expandEmployeeName;
         }
      
      public int getExpandEmployeeId()
         {
      return expandEmployeeId;
         }
      
      public void setExpandEmployeeId(ref int expandEmployeeId)
         {
      this.expandEmployeeId = expandEmployeeId;
         }
      
      public int getFeetemplateId()
         {
      return feetemplateId;
         }
      
      public void setFeetemplateId(ref int feetemplateId)
         {
      this.feetemplateId = feetemplateId;
         }
      
      public int getChannelType()
         {
      return channelType;
         }
      
      public void setChannelType(ref int channelType)
         {
      this.channelType = channelType;
         }
      
      public int getWebType()
         {
      return webType;
         }
      
      public void setWebType(ref int webType)
         {
      this.webType = webType;
         }
      
      public String getEmail()
         {
      return email;
         }
      
      public void setEmail(ref String email)
         {
      this.email = email;
         }
      
      public String getLoginPassWord()
         {
      return loginPassWord;
         }
      
      public void setLoginPassWord(ref String loginPassWord)
         {
      this.loginPassWord = loginPassWord;
         }
      
      public String getContactName()
         {
      return contactName;
         }
      
      public void setContactName(ref String contactName)
         {
      this.contactName = contactName;
         }
      
      public String getContactNumber()
         {
      return contactNumber;
         }
      
      public void setContactNumber(ref String contactNumber)
         {
      this.contactNumber = contactNumber;
         }
   
   }
}