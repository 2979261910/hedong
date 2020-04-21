using SuperMarketIDAL.SuperMarketManager;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketDAL.SuperMarketServer
{
    public class SuperMarketMemberServer : ISuperMarketMemberServer
    {
      
        public SMMembers AddMember(SMMembers member)
        {
            string procName = "AddMember";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@memberName",member.MemberName ),
                new SqlParameter("@phoneNumber ",member.PhoneNumber ),
                new SqlParameter("@memberAddress ",member.MemberAddress )
            };

            object obj = SQLHelper.ExecuteScalar(procName, sp);
            if (obj!=null)
            {
                member.MemberId = Convert.ToInt32(obj);
            }
            else
            {
                member = null;
            }
            return member;
        }
        /// <summary>
        /// 会员账号
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SMMembers GetMemberByIdPhone(string id)
        {
            前台SuperMarketCashier.SuperMarketMemberServer server = new 前台SuperMarketCashier.SuperMarketMemberServer();
            return server.GetMembersById(id);
        }
    }
}
