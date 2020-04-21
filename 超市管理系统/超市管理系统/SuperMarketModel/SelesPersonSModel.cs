using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 登录销售员
    /// </summary>
    [Serializable]//表示类可以被序列化，此类不能被继承
    public class SelesPersonSModel
    {
        /// <summary>
        /// 销售员ID
        /// </summary>
        public int SalesPersonId { get; set; }
        /// <summary>
        /// 销售员名
        /// </summary>
        public string SPName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public int LoginPwd { get; set; }
        /// <summary>
        /// ID
        /// </summary>
        public int LogId { get; set; }
    }
}
