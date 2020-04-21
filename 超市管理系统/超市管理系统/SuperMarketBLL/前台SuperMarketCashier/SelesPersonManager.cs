using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIBLL;
using SuperMarketIDAL;
using SuperMarketDAL;


namespace SuperMarketBLL.前台SuperMarketCashier
{
    public class SelesPersonManager : SuperMarketIBLL.前台SuperMarketCashier.ISelesPersonManager
    {
        SuperMarketIDAL.前台SuperMarketCashier.ISelesPersonServer server = new SuperMarketDAL.前台SuperMarketCashier.SelesPersonServer();//SuperMarketDAL这个的方法DAL


        public SelesPersonSModel SelesLogin(SelesPersonSModel seles)
        {
            return server.SelesLogin(seles);
        }

        //日志
        public int BllWriteSelesLog(LoginLogsModel loginLogs)
        {
            return server.WriteSelesLog(loginLogs);
        }

        public bool BllWriteSelesExitLog(int id)
        {
            if (server.WriteSelesExitLog(id) >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool WriteSalesExitLog(int logid)
        {
            if (server.WriteSelesExitLog(logid) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DateTime GetSysTime()
        {
            return server.GetSysTime();
        }

     
    }
}
