using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketManager
{
    public  interface ISuperMarketMemberServer
    {
        /// <summary>
        /// 会员账号
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        SMMembers GetMemberByIdPhone(string id);
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        SMMembers AddMember(SMMembers member);
    }
}
