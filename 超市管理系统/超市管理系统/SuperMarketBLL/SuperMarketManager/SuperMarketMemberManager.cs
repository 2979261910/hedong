using SuperMarketDAL.SuperMarketServer;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketIDAL.SuperMarketManager;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketBLL.SuperMarketManager
{
    public class SuperMarketMemberManager : ISuperMarketMemberManager
    {
        ISuperMarketMemberServer memserver = new SuperMarketMemberServer();
        public SMMembers AddMember(SMMembers member)
        {
            return memserver.AddMember(member);
        }

        public SMMembers GetMemberByIdPhone(string id)
        {
            return memserver.GetMemberByIdPhone(id);
        }
    }
}
