using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 在日志记录销售员的各种信息
    /// </summary>
    [Serializable]
    public class LoginLogsModel
    {
      
        /// <summary>
        /// 序列
        /// </summary>
        public int LogId { get; set; }
        /// <summary>
        /// 登陆者ID
        /// </summary>
        public int LoginId { get; set; }
        /// <summary>
        /// 登陆者姓名
        /// </summary>
        public string SPName { get; set; }
        /// <summary>
        /// 登录服务器名
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }
        /// <summary>
        /// 退出时间
        /// </summary>
        public DateTime? ExitTime { get; set; }
    }
}
