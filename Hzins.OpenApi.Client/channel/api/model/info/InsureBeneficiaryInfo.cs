using System;

namespace com.hzins.channel.api.model.info
{
   /// /**
   ///  * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved.
   ///  * <p/>
   ///  * This code is the confidential and proprietary information of
   ///  * Hzins. You shall not disclose such Confidential Information
   ///  * and shall use it only in accordance with the terms of the agreements
   ///  * you entered into with Hzins,http://www.hzins.com.
   ///  */
   /// <p>
   /// 寿险投保受益人实体类
   /// </p>
   public class InsureBeneficiaryInfo
   {
      /// 受益人生日
      private String birthdate;
      /// 证件号码
      private String cardNumber;
      /// 证件类型
      private int cardTypeId;
      /// 受益人名字
      private String cName;
      /// 与被保人关系
      private int relationId;
      /// 受益人顺序
      private short serial;
      private bool sex;
      /// 受益人比率
      private decimal proportion;
      
      public String getBirthdate()
      {
          return birthdate;
      }
      
      public void setBirthdate(ref String birthdate)
      {
          this.birthdate = birthdate;
      }
      
      public String getCardNumber()
      {
          return cardNumber;
      }
      
      public void setCardNumber(ref String cardNumber)
      {
          this.cardNumber = cardNumber;
      }
      
      public int getCardTypeId()
      {
          return cardTypeId;
      }
      
      public void setCardTypeId(ref int cardTypeId)
      {
          this.cardTypeId = cardTypeId;
      }
      
      public String getcName()
      {
          return cName;
      }
      
      public void setcName(ref String cName)
      {
          this.cName = cName;
      }
      
      public int getRelationId()
      {
          return relationId;
      }
      
      public void setRelationId(ref int relationId)
      {
          this.relationId = relationId;
      }
      
      public short getSerial()
      {
          return serial;
      }
      
      public void setSerial(ref short serial)
      {
          this.serial = serial;
      }
      
      public bool isSex()
      {
          return sex;
      }
      
      public void setSex(ref bool sex)
      {
          this.sex = sex;
      }
      
      public decimal getProportion()
      {
          return proportion;
      }
      
      public void setProportion(ref decimal proportion)
      {
          this.proportion = proportion;
      }
   
   }
}