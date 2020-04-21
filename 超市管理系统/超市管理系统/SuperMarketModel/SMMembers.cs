using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    [Serializable]
   public  class SMMembers
    {
        /// <summary>
        /// 会员卡号
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 会员积分10元=1
        /// </summary>
        public int Points { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string MemberAddress { get; set; }
        /// <summary>
        /// 开户时间
        /// </summary>
        public DateTime OpenTime { get; set; }
        /// <summary>
        /// 会员卡状态1正，0冻，-1注销
        /// </summary>
        public int MemberStatus { get; set; }
    }
}
