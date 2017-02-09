﻿//JSON数据解析

using System.Collections;
using System.Collections.Generic;
using JsonFx.Json;
using UnityEngine;

namespace HUST_1_Demo.Model
{
    public class JsonHelper
    {

        /// <summary>  
        /// 根据一个JSON，得到一个类  
        /// </summary>  
        static public T JsonToClass<T>(string json) where T : class
        {
            T t = JsonReader.Deserialize<T>(json);
            return t;
        }

        /// <summary>  
        /// 根据一个JSON的文件地址，得到一个类  
        /// </summary>  
        static public T AddressToClass<T>(string txtAddress) where T : class
        {
            TextAsset jsonData = Resources.Load(txtAddress) as TextAsset;
            return JsonToClass<T>(jsonData.text);
        }

        /// <summary>  
        /// 将JSON转换为一个类数组  
        /// </summary>  
        static public T[] JsonToClasses<T>(string json) where T : class
        {
            //Debug.Log(json);  
            T[] list = JsonReader.Deserialize<T[]>(json);
            return list;
        }

        /// <summary>  
        /// 给Json文件的地址。转换为一个类数组  
        /// </summary>  
        static public T[] AddressToClasses<T>(string txtAddress) where T : class
        {
            TextAsset jsonData = Resources.Load(txtAddress) as TextAsset;
            return JsonToClasses<T>(jsonData.text);
        }

        /// <summary>  
        /// 将一个对象class转换成json字符串
        /// </summary>  
        static public string ClassToJson<T>(T t) where T : class
        {
            return JsonWriter.Serialize(t);
        }
    }

    //**定义了JSON数据的接收类
    public class LoginJson
    {
        public string status = "";
        public LoginResp resp = null;

        public LoginJson()
        { }
    }

    //**定义了JSON数据中Resp的数据类
    public class LoginResp
    {
        public string name = "";
        public string identity = "";

        public LoginResp()
        { }
    }
}
