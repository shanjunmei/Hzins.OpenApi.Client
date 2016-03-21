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
      private String insurantId;
      ///  被保人姓名
      private String cName;
      ///  被保人英文名，境外险必填
      private String eName;
      ///  被保人证件类型
      private int cardType;
      ///  证件号码
      private String cardCode;
      ///  性别 0女1男
      private int sex;
      ///  出生日期
      private String birthday;
      ///  航班号，航意险必填
      private String fltNo;
      ///  起飞时间，航意险必填
      private String fltDate;
      ///  所在地区代码，由慧择分配，特定产品必填
      private String city;
      ///  出行目的，特定产品必填
      private int tripPurposeId;
      ///  出行目的地，特定产品必填
      private String destination;
      ///  签证办理城市，特定产品必填
      private String visaCity;
      ///  被保人与投保人关系
      private int relationId;
      ///  购买份数
      private int count;
      ///  职业信息
      private String jobInfo;
      ///  手机号码
      private String mobile;
      ///  结算价，即相应保险产品的保费
      private decimal singlePrice;
      /// 国籍
      private String country;
      /// 房屋类型,比如钢筋，混泥土（新增家财综合保险）
      private String houseTypeName;
      /// 财产所在地（新增家财综合保险）
      private String propertyAddress;
      
      public String getHouseTypeName()
      {
          return houseTypeName;
      }
      
      public void setHouseTypeName(ref String houseTypeName)
      {
          this.houseTypeName = houseTypeName;
      }
      
      public String getPropertyAddress()
      {
          return propertyAddress;
      }
      
      public void setPropertyAddress(ref String propertyAddress)
      {
          this.propertyAddress = propertyAddress;
      }
      
      public String getCountry()
      {
          return country;
      }
      
      public void setCountry(ref String country)
      {
          this.country = country;
      }
      
      public decimal getSinglePrice()
      {
          return singlePrice;
      }
      
      public void setSinglePrice(ref decimal singlePrice)
      {
          this.singlePrice = singlePrice;
      }
      
      public String getInsurantId()
      {
          return insurantId;
      }
      
      public void setInsurantId(ref String insurantId)
      {
          this.insurantId = insurantId;
      }
      
      public String getcName()
      {
          return cName;
      }
      
      public void setcName(ref String cName)
      {
          this.cName = cName;
      }
      
      public String geteName()
      {
          return eName;
      }
      
      public void seteName(ref String eName)
      {
          this.eName = eName;
      }
      
      public int getCardType()
      {
          return cardType;
      }
      
      public void setCardType(ref int cardType)
      {
          this.cardType = cardType;
      }
      
      public String getCardCode()
      {
          return cardCode;
      }
      
      public void setCardCode(ref String cardCode)
      {
          this.cardCode = cardCode;
      }
      
      public int getSex()
      {
          return sex;
      }
      
      public void setSex(ref int sex)
      {
          this.sex = sex;
      }
      
      public String getBirthday()
      {
          return birthday;
      }
      
      public void setBirthday(ref String birthday)
      {
          this.birthday = birthday;
      }
      
      public String getFltNo()
      {
          return fltNo;
      }
      
      public void setFltNo(ref String fltNo)
      {
          this.fltNo = fltNo;
      }
      
      public String getFltDate()
      {
          return fltDate;
      }
      
      public void setFltDate(ref String fltDate)
      {
          this.fltDate = fltDate;
      }
      
      public String getCity()
      {
          return city;
      }
      
      public void setCity(ref String city)
      {
          this.city = city;
      }
      
      public int getTripPurposeId()
      {
          return tripPurposeId;
      }
      
      public void setTripPurposeId(ref int tripPurposeId)
      {
          this.tripPurposeId = tripPurposeId;
      }
      
      public String getDestination()
      {
          return destination;
      }
      
      public void setDestination(ref String destination)
      {
          this.destination = destination;
      }
      
      public String getVisaCity()
      {
          return visaCity;
      }
      
      public void setVisaCity(ref String visaCity)
      {
          this.visaCity = visaCity;
      }
      
      public int getRelationId()
      {
          return relationId;
      }
      
      public void setRelationId(ref int insurantRelation)
      {
          this.relationId = insurantRelation;
      }
      
      public int getCount()
      {
          return count;
      }
      
      public void setCount(ref int count)
      {
          this.count = count;
      }
      
      public String getJobInfo()
      {
          return jobInfo;
      }
      
      public void setJobInfo(ref String jobInfo)
      {
          this.jobInfo = jobInfo;
      }
      
      public String getMobile()
      {
          return mobile;
      }
      
      public void setMobile(ref String mobile)
      {
          this.mobile = mobile;
      }
   
   }
}