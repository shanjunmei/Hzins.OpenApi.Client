﻿using Castle.DynamicProxy;
using com.hzins.openapi.client;
using com.hzins.rpc.client.utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace com.hzins.rpc.client.core
{
    class Proxy : IInterceptor
    {

        private string serviceBase;

        public Proxy(string serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Intercept(IInvocation invocation)
        {
            MethodInfo method = invocation.Method;

            string command = method.Name;
            Command[] apis = (Command[])method.GetCustomAttributes(typeof(Command), false);

            if (apis != null && apis.Length > 0)
            {
                Command api = apis[0];
                if (!String.IsNullOrEmpty(api.command))
                {
                    command = api.command;
                }

            }


            object[] param = invocation.Arguments;

            string baseInfo = serviceBase;
            int pc = method.GetParameters().Length;
            object actualParam = param;
            if (pc == 1)
            {
                actualParam = param[0];
            }

            string response = remoteInvoke(baseInfo + command, actualParam);


            Type returnType = method.ReturnType;

            invocation.ReturnValue = convert2entity(response, returnType);

        }
        /// <summary>
        /// 远程方法调用
        /// </summary>
        /// <param name="api"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string remoteInvoke(string api, object obj)
        {
            string param = convert2json(obj);
            api = sign(api, param);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
            request.ContentType = Configure.Request.contentType;
            request.Method = "POST";
            if (Configure.Request.http_connection_timeout > 0)
            {
                request.Timeout = Configure.Request.http_connection_timeout;
            }
            if (Configure.Request.http_read_timeout > 0)
            {
                request.ReadWriteTimeout = Configure.Request.http_read_timeout;
            }



            StreamWriter writer = new StreamWriter(request.GetRequestStream(), System.Text.UTF8Encoding.UTF8);


            writer.Write(param);
            writer.Flush();

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.UTF8Encoding.UTF8);
            return reader.ReadToEnd();

        }
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="api"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private static string sign(string api, string param)
        {
            Debug.WriteLine("json "+param);
            string sign = Md5.encrypt(Configure.Channel.channelKey + param);
            api = api + "?sign=" + sign;
            return api;
        }
        /// <summary>
        /// 对象转json字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string convert2json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// json转对象
        /// </summary>
        /// <param name="json"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private object convert2entity(string json, Type type)
        {
            Debug.WriteLine("json : "+json);
            JsonSerializerSettings jsetting = new JsonSerializerSettings();
            jsetting.NullValueHandling = NullValueHandling.Ignore;
            return JsonConvert.DeserializeObject(json, type,jsetting);
        }
    }
}
