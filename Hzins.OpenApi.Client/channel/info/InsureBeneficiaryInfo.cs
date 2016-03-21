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
      public String birthdate;
      /// 证件号码
      public String cardNumber;
      /// 证件类型
      public int cardTypeId;
      /// 受益人名字
      public String cName;
      /// 与被保人关系
      public int relationId;
      /// 受益人顺序
      public short serial;
      public bool sex;
      /// 受益人比率
      public decimal proportion;
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      public bool isSex()
      {
          return sex;
      }
      
      
      
      
      
      
   
   }
}