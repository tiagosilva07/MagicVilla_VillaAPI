﻿namespace MagicVilla_Web.Models
{
    public enum ApiType
    {
        GET, POST, PUT, DELETE
    }
    public class APIRequest
    {
        public ApiType ApiType { get;set;} = ApiType.GET;
        public string Url { get; set; }
        public object Data { get;set;}

    }
}
