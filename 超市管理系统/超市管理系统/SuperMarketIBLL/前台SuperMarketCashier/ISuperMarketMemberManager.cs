using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIBLL.前台SuperMarketCashier
{
    public  interface ISuperMarketMemberManager
    {
        SMMembers GetMembersById(string id);
    }
}
