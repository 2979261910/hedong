using SuperMarketDAL.SuperMarketServer;
using SuperMarketIBLL;
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
    public class SuperMarketLoginLogManager : ISuperMarketLoginLogManager
    {
        ISuperMarketLoginLogServer server = new SuperMarketLoginLogServer();
        public List<LoginLogsModel> GetLoginLog()
        {
            return server.GetLoginLog();
        }

         public List<LoginLogsModel> GetLoginLogBy(DateTime starttime, DateTime dateTime, string wheres, int check)
         {
            return server.GetLoginLogBy(starttime, dateTime, wheres, check);
         }

        
    }
}
