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
   /// 车辆信息
   /// 
   /// </p>
   public class CarInfo
   {
      /// 投保区域名称，默认深圳
      public String insureAreaName;
      /// 投保区域码，全国统一
      public String insureAreaNum;
      /// 车牌
      public String plateNum;
      /// 车架号码
      public String frameNo;
      /// 发动机号
      public String engineNum;
      /// 注册日期
      [Newtonsoft.Json.JsonConverter(typeof(Hzins.OpenApi.Client.rpc.client.utils.DateTimeConverter))]

      public DateTime registerTime;
      /// 是否过户车辆（0：否，1：是）
      public byte isTransfer;
      /// 车主
      public String owner;
      /// 证件类型 1=身份证;2=护照；3=军官证；4=港澳回乡证；5=台胞证；6=组织机构代码证；7=税务登记证；8=其他
      public byte owerCardType;
      /// 证件号码
      public String ownerCardNum;
      /// 核定载人数
      public byte seatNum;
      /// 核定载质量
      public String weight;
      /// 核定排气量
      public String emissions;
      /// 品牌型号
      public String brandModel;
      /// 新车是否上牌照，1未上牌，0上牌
      public byte newCarLicenseFlag;
      /// 排量
      public float power;
      /// 过户时间
      [Newtonsoft.Json.JsonConverter(typeof(Hzins.OpenApi.Client.rpc.client.utils.DateTimeConverter))]

      public DateTime transferTime;

   }
}