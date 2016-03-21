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
   public class RegisterReq : SubUserBaseReq, java.io.Serializable
   {
      public const long serialVersionUID = 7431287304382522749L;
      ///  渠道类型 0：个人 1：公司 (必填)
      public int channelType;
      ///  1:户外=1 2:旅行社 3:签证机构 4:旅游网站 0:其他(必填)
      public int webType;
      ///  邮箱
      public String email;
      ///  登陆密码
      public String loginPassWord;
      ///  联系人 必填
      public String contactName;
      ///  联系电话 必填
      public String contactNumber;
      ///  渠道服务费模板Id(非必填)
      public int feetemplateId;
      ///  拓展人员名字
      public String expandEmployeeName;
      ///  拓展人员ID
      public int expandEmployeeId;
      ///  公司代码
      public String companyCode;
      ///  公司名称
      public String companyName;

   }
}