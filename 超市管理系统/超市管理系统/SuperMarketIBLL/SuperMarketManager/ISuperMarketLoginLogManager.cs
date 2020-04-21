using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIBLL.SuperMarketManager
{
   public  interface ISuperMarketLoginLogManager
    {
        List<LoginLogsModel> GetLoginLog();

        List<LoginLogsModel> GetLoginLogBy(DateTime starttime, DateTime dateTime, string wheres, int check);
    }
}
