using SuperMarketIBLL.SuperMarketManager;
using SuperMarketModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketIDAL.SuperMarketManager;
using SuperMarketDAL.SuperMarketServer;
using SuperMarketIDAL.前台SuperMarketCashier;
using SuperMarketDAL.前台SuperMarketCashier;
using System.Net;

namespace SuperMarketBLL.SuperMarketManager
{
    public class SuperMarketAdminManager : ISuperMarketAdminManager
    {
        ISuperMarketAdminServer adminServer = new SuperMarketAdminServer();
        ISelesPersonServer selesServer = new SelesPersonServer();
        public SysAdmins AdminLogin(SysAdmins admin)
        {
            //【1】根据用户账号和密码调用查询用户登录
            SysAdmins sys = adminServer.AdminLogin(admin);
            //管理员登录然后状态是启用，可以登录
            if (sys!=null && sys.AdminStatus==1)
            {
                //【写入登录日志】
                LoginLogsModel login = new LoginLogsModel()
                {
                    LoginId = sys.LoginId,
                    SPName = sys.AdminName,
                    ServerName = Dns.GetHostName()
                };
                //保存当前管理员日志的ID
                sys.LoginLogId = selesServer.WriteSelesLog(login);
            }
            else
            {
                sys = null;
            }
            return sys;
        }

        public bool AdminUpdatePwd(SysAdmins admin)
        {
            int res = adminServer.AdminUpdatePwd(admin);
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SysAdmins> GetAdmins()
        {
            return adminServer.GetAdmins();
        }

        public List<SelesPersonSModel> GetSales()
        {
            return adminServer.GetSales();
        }

        public SysAdmins InsertAdmin(SysAdmins admin)
        {
            return adminServer.InsertAdmin(admin);
        }

        public SelesPersonSModel InsertSales(SelesPersonSModel person)
        {
            return adminServer.InsertSales(person);
        }

        public bool SetSysStatus(SysAdmins admin)
        {
            if (adminServer.SetSysStatus(admin) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SysAdmins UpdateAdmin(SysAdmins admin)
        {
            if (adminServer.UpdateAdmin(admin) > 0)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }

        public SelesPersonSModel UpdateSales(SelesPersonSModel person)
        {
            if (adminServer.UpdateSales(person) > 0)
            {
                return person;
            }
            else
            {
                return null;
            }
        }
    }
}
