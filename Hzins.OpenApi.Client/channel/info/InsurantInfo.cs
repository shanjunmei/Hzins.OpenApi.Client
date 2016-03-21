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
   /// 被保人信息
   /// </p>
   public class InsurantInfo
   {
      ///  被保人ID，由代理商传递
      public String insurantId;
      ///  被保人姓名
      public String cName;
      ///  被保人英文名，境外险必填
      public String eName;
      ///  被保人证件类型
      public int cardType;
      ///  证件号码
      public String cardCode;
      ///  性别 0女1男
      public int sex;
      ///  出生日期
      public String birthday;
      ///  航班号，航意险必填
      public String fltNo;
      ///  起飞时间，航意险必填
      public String fltDate;
      ///  所在地区代码，由慧择分配，特定产品必填
      public String city;
      ///  出行目的，特定产品必填
      public int tripPurposeId;
      ///  出行目的地，特定产品必填
      public String destination;
      ///  签证办理城市，特定产品必填
      public String visaCity;
      ///  被保人与投保人关系
      public int relationId;
      ///  购买份数
      public int count;
      ///  职业信息
      public String jobInfo;
      ///  手机号码
      public String mobile;
      ///  结算价，即相应保险产品的保费
      public decimal singlePrice;
      /// 国籍
      public String country;
      /// 房屋类型,比如钢筋，混泥土（新增家财综合保险）
      public String houseTypeName;
      /// 财产所在地（新增家财综合保险）
      public String propertyAddress;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
   
   }
}