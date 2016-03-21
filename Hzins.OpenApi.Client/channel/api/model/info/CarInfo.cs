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
import java.util.Date;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.hzins.channel.base.utils.DateTimeDeserializer;
import com.hzins.channel.base.utils.DateTimeSerializer;

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
      private String insureAreaName;
      /// 投保区域码，全国统一
      private String insureAreaNum;
      /// 车牌
      private String plateNum;
      /// 车架号码
      private String frameNo;
      /// 发动机号
      private String engineNum;
      /// 注册日期
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime registerTime;
      /// 是否过户车辆（0：否，1：是）
      private byte isTransfer;
      /// 车主
      private String owner;
      /// 证件类型 1=身份证;2=护照；3=军官证；4=港澳回乡证；5=台胞证；6=组织机构代码证；7=税务登记证；8=其他
      private byte owerCardType;
      /// 证件号码
      private String ownerCardNum;
      /// 核定载人数
      private byte seatNum;
      /// 核定载质量
      private String weight;
      /// 核定排气量
      private String emissions;
      /// 品牌型号
      private String brandModel;
      /// 新车是否上牌照，1未上牌，0上牌
      private byte newCarLicenseFlag;
      /// 排量
      private float power;
      /// 过户时间
      [JsonSerialize(using = DateTimeSerializer.class)]
      [JsonDeserialize(using = DateTimeDeserializer.class)]
      private DateTime transferTime;
      
      public String getInsureAreaName()
         {
      return insureAreaName;
         }
      
      public void setInsureAreaName(ref String insureAreaName)
         {
      this.insureAreaName = insureAreaName;
         }
      
      public String getInsureAreaNum()
         {
      return insureAreaNum;
         }
      
      public void setInsureAreaNum(ref String insureAreaNum)
         {
      this.insureAreaNum = insureAreaNum;
         }
      
      public String getPlateNum()
         {
      return plateNum;
         }
      
      public void setPlateNum(ref String plateNum)
         {
      this.plateNum = plateNum;
         }
      
      public String getFrameNo()
         {
      return frameNo;
         }
      
      public void setFrameNo(ref String frameNo)
         {
      this.frameNo = frameNo;
         }
      
      public String getEngineNum()
         {
      return engineNum;
         }
      
      public void setEngineNum(ref String engineNum)
         {
      this.engineNum = engineNum;
         }
      
      public DateTime getRegisterTime()
         {
      return registerTime;
         }
      
      public void setRegisterTime(ref DateTime registerTime)
         {
      this.registerTime = registerTime;
         }
      
      public byte getIsTransfer()
         {
      return isTransfer;
         }
      
      public void setIsTransfer(ref byte isTransfer)
         {
      this.isTransfer = isTransfer;
         }
      
      public String getOwner()
         {
      return owner;
         }
      
      public void setOwner(ref String owner)
         {
      this.owner = owner;
         }
      
      public byte getOwerCardType()
         {
      return owerCardType;
         }
      
      public void setOwerCardType(ref byte owerCardType)
         {
      this.owerCardType = owerCardType;
         }
      
      public String getOwnerCardNum()
         {
      return ownerCardNum;
         }
      
      public void setOwnerCardNum(ref String ownerCardNum)
         {
      this.ownerCardNum = ownerCardNum;
         }
      
      public byte getSeatNum()
         {
      return seatNum;
         }
      
      public void setSeatNum(ref byte seatNum)
         {
      this.seatNum = seatNum;
         }
      
      public String getWeight()
         {
      return weight;
         }
      
      public void setWeight(ref String weight)
         {
      this.weight = weight;
         }
      
      public String getEmissions()
         {
      return emissions;
         }
      
      public void setEmissions(ref String emissions)
         {
      this.emissions = emissions;
         }
      
      public String getBrandModel()
         {
      return brandModel;
         }
      
      public void setBrandModel(ref String brandModel)
         {
      this.brandModel = brandModel;
         }
      
      public byte getNewCarLicenseFlag()
         {
      return newCarLicenseFlag;
         }
      
      public void setNewCarLicenseFlag(ref byte newCarLicenseFlag)
         {
      this.newCarLicenseFlag = newCarLicenseFlag;
         }
      
      public float getPower()
         {
      return power;
         }
      
      public void setPower(ref float power)
         {
      this.power = power;
         }
      
      public DateTime getTransferTime()
         {
      return transferTime;
         }
      
      public void setTransferTime(ref DateTime transferTime)
         {
      this.transferTime = transferTime;
         }
   
   }
}