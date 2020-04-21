using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIDAL.前台SuperMarketCashier
{
   public  interface ISuperMarketMemberServer
    {
        SMMembers GetMembersById(string id);
    }
}
