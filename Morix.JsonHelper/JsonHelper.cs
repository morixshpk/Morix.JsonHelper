using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Morix
{
    public static class JsonHelper
    {
        private static JsonSerializerOptions _options;

        static JsonHelper()
        {
            _options = new JsonSerializerOptions
            {
                IncludeFields = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
        }

        public static bool GetPropertyAsBoolean(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetBoolean();
            }
            return default;
        }

        public static byte GetPropertyAsByte(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetByte();
            }
            return default;
        }

        public static int GetPropertyAsInt(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetInt32();
            }
            return default;
        }

        public static long GetPropertyAsLong(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetInt64();
            }
            return default;
        }

        public static double GetPropertyAsFloat(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetSingle();
            }
            return default;
        }

        public static double GetPropertyAsDouble(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetDouble();
            }
            return default;
        }

        public static decimal GetPropertyAsDecimal(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetDecimal();
            }
            return default;
        }

        public static DateTime GetPropertyAsDateTime(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetDateTime();
            }
            return default;
        }

        public static string GetPropertyAsString(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetString();
            }
            return default;
        }

        public static Guid GetPropertyAsGuid(this JsonElement element, string name)
        {
            if (element.TryGetProperty(name, out JsonElement prop))
            {
                return prop.GetGuid();
            }
            return default;
        }

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, _options);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}