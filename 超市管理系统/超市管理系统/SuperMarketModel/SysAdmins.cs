using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 系统管理员
    /// </summary>
    [Serializable]
    public  class SysAdmins
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public int LoginId { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 管理员名
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// 当前状态1启0禁
        /// </summary>
        public int AdminStatus { get; set; }
        /// <summary>
        /// 角色类型1超级2一般
        /// </summary>
        public int Roleld { get; set; }

        //扩展属性
        public string StatusName { get; set; }

        public string RoleName { get; set; }

        public int LoginLogId { get; set; }
    }
}
