using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PicListViewer
{
    /// <summary>
    /// 
    /// </summary>
    public class UtilHelper
    {
        /// <summary>
        /// 获取枚举类型的键值对
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<T, string> GetEnumDic<T>()
        {
            FieldInfo[] fields = typeof(T).GetFields();
            return fields.Where(c => c.FieldType == typeof(T))
                .ToDictionary(
                    k => (T)k.GetRawConstantValue(),
                    v => GetFieldDesc((T)v.GetRawConstantValue())
                );
        }

        /// <summary>
        /// 获取字段描述
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string GetFieldDesc(object field)
        {
            string strValue = field.ToString();

            FieldInfo fi = field.GetType().GetField(strValue);
            if (fi == null)
                return string.Empty;
            Object[] objs = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (objs.Length == 0)
            {
                return strValue;
            }
            else
            {
                var da = (DescriptionAttribute)objs[0];
                return da.Description;
            }
        }
    }
}
