using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WFEngine.Activities.Core.Model;

namespace WFEngine.Activities.Core.Helper
{
    public static class VariableHelper
    {
        public static T GetFirstArgumentFromJson<T>(this WFArgument argument)
        {
            var jArray = (Newtonsoft.Json.Linq.JArray)argument.Value;
            return (T)Convert.ChangeType(jArray.First, typeof(T));
        }

        public static object GetFirstArgumentFromJson(this WFArgument argument)
        {
            Type argumentType = Type.GetType(argument.ArgumentType);
            var jArray = (Newtonsoft.Json.Linq.JArray)argument.Value;
            return (Convert.ChangeType(jArray.First, argumentType));
        }

        public static T GetFirstArgumentParse<T>(this WFArgument argument)
        {
            try
            {
                var jArray = (Newtonsoft.Json.Linq.JArray)argument.Value;
                return JsonConvert.DeserializeObject<T>(jArray.First.ToString());
            }
            catch (Exception)
            {
                return JsonConvert.DeserializeObject<T>(argument.Value.ToString());
            }            
        }

        public static object GetFirstArgumentFromJson(this WFVariable variable)
        {
            var jArray = (Newtonsoft.Json.Linq.JArray)variable.Value;
            return Convert.ChangeType(jArray.First, Type.GetType(variable.Type));
        }

        public static string ReplaceToVariables(this string value, List<WFVariable> variables)
        {
            if (value.Contains("$"))
            {
                do
                {
                    var index = value.IndexOf("$");
                    if (value.Length - 1 != index)
                    {
                        var afterItem = value[index + 1];
                        if (afterItem.ToString() != "$")
                        {
                            foreach (var variable in variables)
                            {
                                value = value.Replace($"${variable.Name}", $"{Convert.ChangeType(variable.Value, typeof(System.String))}");
                            }
                        }
                    }
                } while (value.Contains("$"));
            }
            return value;
        }
        
        public static WFVariable FindVariable(string value,List<WFVariable> variables)
        {
            WFVariable variable = default;
            if (value.StartsWith("$"))
                value = value.TrimStart('$');
            variable = variables.FirstOrDefault(x => x.Name == value);
            return variable;
        }
    }
}
