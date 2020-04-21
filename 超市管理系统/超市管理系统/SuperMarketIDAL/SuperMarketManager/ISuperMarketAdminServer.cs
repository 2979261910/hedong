using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketIDAL.SuperMarketManager
{
    public  interface ISuperMarketAdminServer
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
        int AdminUpdatePwd(SysAdmins admin);

        //int GetTableCount(string tablename);

        List<SysAdmins> GetAdmins();

        int SetSysStatus(SysAdmins admin);
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="admi"></param>
        /// <returns></returns>
        SysAdmins InsertAdmin(SysAdmins admi);
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        int UpdateAdmin(SysAdmins admin);

        List<SelesPersonSModel> GetSales();

        SelesPersonSModel InsertSales(SelesPersonSModel person);

        int UpdateSales(SelesPersonSModel person);
    }
}
