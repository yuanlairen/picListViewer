using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PicListViewer
{
    public enum SortCondType
    {
        [Description("按时间顺序")]
        ByTimeAsc = 1,

        [Description("按时间倒序")]
        ByTimeDesc = 2,

        [Description("按文件名顺序")]
        ByNameAsc = 3,

        [Description("按文件名倒序")]
        ByNameDesc = 4
    }
}
