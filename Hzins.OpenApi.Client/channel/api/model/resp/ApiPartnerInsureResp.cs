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
import java.util.List;
import com.hzins.channel.api.model.info.ApiPartnerInsureInfo;

namespace com.hzins.channel.api.model.resp
{
   /// <p>
   /// 
   /// 
   /// 
   /// </p>
   public class ApiPartnerInsureResp : BaseResp
   {
      private List<ApiPartnerInsureInfo> apiPartnerInsureInfos;
      
      public List<ApiPartnerInsureInfo> getApiPartnerInsureInfos()
         {
      return apiPartnerInsureInfos;
         }
      
      public void setApiPartnerInsureInfos(ref List<ApiPartnerInsureInfo> apiPartnerInsureInfos)
         {
      this.apiPartnerInsureInfos = apiPartnerInsureInfos;
         }
   
   }
}