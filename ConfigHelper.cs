using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PicListViewer
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigHelper
    {
        public static bool NOACTIVATE
        {
            get {
                var configItem = ConfigurationManager.AppSettings["NOACTIVATE"] ?? "false";
                return bool.Parse(configItem);
            }
        }

        public static bool IsSavePath
        {
            get
            {
                var configItem = ConfigurationManager.AppSettings["IsSavePath"] ?? "true";
                return bool.Parse(configItem);
            }
        }
    }
}
