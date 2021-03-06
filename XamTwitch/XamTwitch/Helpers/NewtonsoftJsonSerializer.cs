﻿using System;
using Microsoft.MobCAT.Converters;
using Newtonsoft.Json;

namespace XamTwitch.Helpers
{
    public class NewtonsoftJsonSerializer : ISerializer<string>
    {
        public string MediaType => "application/json";

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
