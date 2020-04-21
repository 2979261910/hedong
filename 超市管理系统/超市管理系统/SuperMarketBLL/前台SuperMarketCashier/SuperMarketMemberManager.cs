using SuperMarketDAL.前台SuperMarketCashier;
using SuperMarketIBLL.前台SuperMarketCashier;
using SuperMarketIDAL.前台SuperMarketCashier;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketBLL.前台SuperMarketCashier
{
    public class SuperMarketMemberManager : ISuperMarketMemberManager
    {
        ISuperMarketMemberServer server = new SuperMarketMemberServer();
        public SMMembers GetMembersById(string id)
        {
            return server.GetMembersById(id);
        }
    }
}
