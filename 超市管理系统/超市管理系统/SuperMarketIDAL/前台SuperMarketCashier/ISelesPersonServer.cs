using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;//获取实体类中的

namespace SuperMarketIDAL.前台SuperMarketCashier
{
    public interface ISelesPersonServer
    {
        //收银员登录信息
        SelesPersonSModel SelesLogin(SelesPersonSModel seles);

        //记录到日志信息
        int WriteSelesLog(LoginLogsModel loginLogs);

        //受影响行数
        int WriteSelesExitLog(int loginID);

        DateTime GetSysTime();

     

    }
}
