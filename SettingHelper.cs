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
    /// 设置参数的model
    /// </summary>
    public class SettingConfig
    {
        public SettingConfig()
        {
            
        }

        public int FormWidth
        {
            get; set;
        } = 540;

        public int FormHeight
        {
            get; set;
        } = 480;

        public int FormOpacity
        {
            get; set;
        } = 100;

        public int TimerInterval
        {
            get; set;
        } = 5;

        public string ImgPath
        {
            get;set;
        }
        public bool TopMost
        {
            get; set;
        } = false;

        public SortCondType SortBy
        {
            get; set;
        } = SortCondType.ByTimeAsc;
    }

    /// <summary>
    /// Helper方法
    /// </summary>
    public class SettingHelper
    {
        public static SettingConfig GetSettingConfig()
        {
            var setting = new SettingConfig();
            try
            {
                string fullName = AppDomain.CurrentDomain.BaseDirectory + "Setting.json";
                string configJson = System.IO.File.ReadAllText(fullName);
                var tmpSetting = JsonConvert.DeserializeObject<SettingConfig>(configJson);
                if (tmpSetting != null)
                {
                    setting = tmpSetting;
                }
            }
            catch
            {
                setting = new SettingConfig();
            }

            return setting ?? new SettingConfig();
        }

        public static void SaveSettingConfig(SettingConfig settingConfig)
        {
            try
            {
                if (settingConfig != null)
                {
                    string fullName = AppDomain.CurrentDomain.BaseDirectory + "Setting.json";

                    string configJson = JsonConvert.SerializeObject(settingConfig);
                    System.IO.File.WriteAllText(fullName, configJson);
                }
            }
            catch
            {

            }
        }
    }
}
