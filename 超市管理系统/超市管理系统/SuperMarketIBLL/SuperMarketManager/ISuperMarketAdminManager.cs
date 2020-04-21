using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketManager
{
    public interface ISuperMarketAdminManager
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        SysAdmins AdminLogin(SysAdmins admin);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        bool AdminUpdatePwd(SysAdmins admin);

        List<SysAdmins> GetAdmins();
        bool SetSysStatus(SysAdmins admin);
        SysAdmins InsertAdmin(SysAdmins admin);
        SysAdmins UpdateAdmin(SysAdmins admin);
        List<SelesPersonSModel> GetSales();
        SelesPersonSModel InsertSales(SelesPersonSModel person);
        SelesPersonSModel UpdateSales(SelesPersonSModel person);
    }
}
