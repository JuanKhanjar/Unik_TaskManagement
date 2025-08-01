﻿using System.Security.AccessControl;
using static Unik_TaskManagement.web.Utilities.SD;

namespace Unik_TaskManagement.web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
