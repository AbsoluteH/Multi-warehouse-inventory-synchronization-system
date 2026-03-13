using Inventory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure
{
    public class JsonSerializer : ISerializer
    {
        public T? Deserialize<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return default;
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }

        public object? Deserialize(string json, Type type)
        {
            if (string.IsNullOrWhiteSpace(json))
                return null;
            return System.Text.Json.JsonSerializer.Deserialize(json, type);
        }

        public string Serialize<T>(T obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj);
        }
    }
}
