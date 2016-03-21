using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.req;
using com.hzins.channel.api.model.resp;
using com.hzins.openapi.client;
using com.hzins.rpc.client.core;

namespace com.hzins.rpc.client.test
{
    class OpenApiRemoteOperationTest
    {
        static OpenApiRemoteOperation operation = ProxyFactory.create<OpenApiRemoteOperation>(Configure.Request.baseUrl);

        private static void init() {
            Configure.Channel.partnerId = 23594;
            Configure.Channel.channelKey = "23594^*#%";
        }

        public static void  testProductList()
        {
            init();

            ProductListReq req = new ProductListReq();
            int partnerId = (int)Configure.Channel.partnerId;
            req.partnerId= partnerId;
            string transNo = "testc#sdk";
            req.transNo= transNo;
            
            //string sign = Md5.encrypt(SdkConfigure.Channel.channelKey + SdkConfigure.Channel.partnerId.ToString() + req.transNo);

            //req.sign = sign;

         
            System.Console.WriteLine(req.transNo);

            CommonResult<ProductListResp> ret = operation.productList(ref req);

            System.Console.WriteLine(ret.respCode);
            System.Console.ReadKey();
        }

        public static void testcarInsureDetail()
        {
            init();

          
            int partnerId = (int)Configure.Channel.partnerId;
           
           

            CarInsureDetailReq carInsureDetailReq = new CarInsureDetailReq();
            carInsureDetailReq.insureNum = "CX2016031017153917457";
            carInsureDetailReq.partnerId = partnerId;
            carInsureDetailReq.transNo = "testcarInsureDetail";
            System.Console.WriteLine(carInsureDetailReq.transNo);
            CommonResult<CarInsureDetailResp> ret = operation.carInsureDetail(ref carInsureDetailReq);

            System.Console.WriteLine(ret.respCode);
            System.Console.ReadKey();
        }
    }
}
